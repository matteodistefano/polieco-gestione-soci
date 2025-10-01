Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses
'Imports System.Linq

Namespace DAL.EntityClasses
    Partial Public Class DichiarazioneEntity

        Public Sub Fetch()
            Me.RigheDettaglio.Clear()
            Me.Incassi.Clear()

            Dim PP As New PrefetchPath2(CInt(EntityType.DichiarazioneEntity))
            PP.Add(DichiarazioneEntity.PrefetchPathRigheDettaglio)
            PP.Add(DichiarazioneEntity.PrefetchPathIncassi)
            PP.Add(DichiarazioneEntity.PrefetchPathScadenza)
            PP.Add(DichiarazioneEntity.PrefetchPathAzienda)
            PP.Add(DichiarazioneEntity.PrefetchPathElencoProdottiDichiarati)

            Dim ppe As IPrefetchPath2 = PP.Add(DichiarazioneEntity.PrefetchPathAllegato).SubPath.Add(AllegatoEntity.PrefetchPathDettaglio).SubPath
            ppe.Add(DettaglioAllegatoEntity.PrefetchPathAziendaAllegato)
            ppe.Add(DettaglioAllegatoEntity.PrefetchPathMaterialeCer)
            DA.FetchEntity(Me, PP)

        End Sub

        Public ReadOnly Property HasAllegato As Boolean
            Get
                Return Me.Allegato IsNot Nothing
            End Get
        End Property

        Public ReadOnly Property HasProdottiDichiarati As Boolean
            Get
                Return Me.ElencoProdottiDichiarati IsNot Nothing AndAlso Me.ElencoProdottiDichiarati.Count > 0
            End Get
        End Property


        Public Sub DeleteAllegato()
            If Me.Allegato Is Nothing Then Return
            DA.DeleteEntityCollection(Me.Allegato.Dettaglio)
            DA.DeleteEntity(Me.Allegato)
            Me.Allegato = Nothing
        End Sub

        Public Overrides Sub ValidateEntity()
            MyBase.ValidateEntity()
            If Me.Anno = 0 Then Throw New ORMEntityValidationException("Definire l'anno", Me)
            If Me.DataInizio = Date.MinValue Then Throw New Exception("Data iniziale non valida")
            If Me.DataFine = Date.MinValue Then Throw New Exception("Data finale non valida")
            If Me.DataScadenzaDichiarazione = Date.MinValue Then Throw New Exception("Data Scadenza Dichiarazione non valida")
            If Me.DataScadenzaPagamento = Date.MinValue Then Throw New Exception("Data Scadenza Pagamento non valida")
            If Me.CodCategoria = "" Then Throw New ORMEntityValidationException("Definire una categoria", Me)
        End Sub

        Public ReadOnly Property Periodo As String
            Get
                Return String.Format("{0:d} - {1:d}", Me.DataInizio, Me.DataFine)
            End Get
        End Property

        Public ReadOnly Property Saldo As Decimal?
            Get
                If Not Me.ImportoRuolo.HasValue Then Return Nothing

                Dim impAtteso As Decimal = ContributoMinimoAnnuale.GetValueOrDefault
                If impAtteso < ImportoRuolo.GetValueOrDefault Then impAtteso = ImportoRuolo.GetValueOrDefault

                Return impAtteso - Me.ImportoPagato.GetValueOrDefault
            End Get
        End Property

        Protected Overrides Sub OnPropertyChanged(propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
            If propertyName = "DataRicezione" Then
                _ContributoMinimoAnnuale = Nothing
                'OnPropertyChanged("Saldo")
            End If
        End Sub

        Private Property _ContributoMinimoAnnuale As Decimal?
        Public ReadOnly Property ContributoMinimoAnnuale As Decimal?
            Get
                If Not _ContributoMinimoAnnuale.HasValue Then
                    Dim pr As New PredicateExpression(MaterialeFields.Utilizzato = True)
                    pr.AddWithAnd(MaterialeFields.CodTipo = Enums.TipiMateriale.CONTRIBUTO)
                    pr.AddWithAnd(MaterialeFields.Codice = "Contributo annuale")
                    pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataInizio, Nothing) Or MaterialeFields.DataInizio <= Me.DataInizio)
                    pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataFine, Nothing) Or MaterialeFields.DataFine >= Me.DataFine)

                    'Calcolo Iva corrente
                    Dim Iva As Decimal = DAL.Generale.GetAliquotaIVA(Me.DataRicezione.GetValueOrDefault(Date.Today))


                    Dim vm As EntityView2(Of MaterialeEntity) = Lookups.Materiali.CreateView(pr, New SortExpression(MaterialeFields.Prezzo Or SortOperator.Ascending))
                    If vm.Count = 0 Then
                        _ContributoMinimoAnnuale = 0
                    Else
                        '_ContributoMinimoAnnuale = vm(0).Prezzo.GetValueOrDefault * (1 + vm(0).Iva.GetValueOrDefault / 100)
                        _ContributoMinimoAnnuale = vm(0).Prezzo.GetValueOrDefault * (1 + Iva / 100)
                    End If
                End If
                Return _ContributoMinimoAnnuale
            End Get
        End Property


        Public Sub UpdateStato()

            'Return
            Me.ImportoRuolo = Me.RigheDettaglio.Sum(Function(x) x.ImportoLordo)
            Me.ImportoPagato = (From x In Me.Incassi Where x.CodTipo = Enums.TipiIncasso.VERSAMENTO Or x.CodTipo = Enums.TipiIncasso.RATAPAGATA Select x.Importo).Sum()

            If Not Me.CodStatoDichiarazione = Enums.StatoDocumento.FORCED Then
                If Not Me.DataRicezione.HasValue Then
                    'Me.CodStatoDichiarazione = IIf(Date.Today >= Me.DataScadenzaDichiarazione, Enums.StatoDocumento.NO, Enums.StatoDocumento.OK)
                    Me.CodStatoDichiarazione = Enums.StatoDocumento.NO
                Else
                    If Me.DataRicezione.Value <= Me.DataScadenzaDichiarazione Then
                        Me.CodStatoDichiarazione = Enums.StatoDocumento.OK
                    Else
                        Me.CodStatoDichiarazione = Enums.StatoDocumento.PARTIAL
                    End If

                End If
                End If

            If Me.CodStatoDichiarazione = Enums.StatoDocumento.NO Then
                Me.CodStatoPagamento = Enums.StatoDocumento.NO
            ElseIf Me.CodStatoDichiarazione = Enums.StatoDocumento.FORCED Then
                Me.CodStatoPagamento = Enums.StatoDocumento.FORCED
            Else
                'Recupero contributo minimo
                'Dim cm As MaterialeEntity=Lookups.Materiali.FirstOrDefault(Function(x) x.CodTipo=Enums.
                Dim ImpAtteso As Decimal
                ImpAtteso = ContributoMinimoAnnuale
                If ImpAtteso < ImportoRuolo Then ImpAtteso = ImportoRuolo
                If ImpAtteso - Me.ImportoPagato.GetValueOrDefault > 0.05 Then
                    Me.CodStatoPagamento = Enums.StatoDocumento.NO
                Else
                    'Controllo solo pagamenti regolari
                    Dim PagReg As Decimal = (From x In Me.Incassi
                                             Where (x.DataValuta <= Me.DataScadenzaPagamento And (x.CodTipo = Enums.TipiIncasso.VERSAMENTO Or x.CodTipo = Enums.TipiIncasso.RATAPAGATA))
                                             Select x.Importo).Sum()
                    Me.CodStatoPagamento = IIf(ImpAtteso - PagReg > 0.05, Enums.StatoDocumento.PARTIAL, Enums.StatoDocumento.OK)
                End If
            End If

            'Definizione data di pagamento
            If Me.CodStatoPagamento = Enums.StatoDocumento.NO Then
                Me.DataPagamento = Nothing
            Else
                Dim DtPag As Date? = Me.Incassi.Max(Function(x) x.DataPagamento)
                If DtPag Is Nothing Then DtPag = Me.DataScadenzaPagamento
                Me.DataPagamento = DtPag
            End If

        End Sub


        Private _QuadriConsentiti As EntityCollection(Of QuadroEntity)
        Public ReadOnly Property QuadriConsentiti As EntityCollection(Of QuadroEntity)
            Get
                If _QuadriConsentiti Is Nothing Then
                    _QuadriConsentiti = New EntityCollection(Of QuadroEntity)

                    Dim pr As New PredicateExpression()
                    pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataInizio, Nothing) Or MaterialeFields.DataInizio <= Me.DataInizio)
                    pr.AddWithAnd(New FieldCompareNullPredicate(MaterialeFields.DataFine, Nothing) Or MaterialeFields.DataFine >= Me.DataFine)

                    Dim pp As New PrefetchPath2(CInt(EntityType.QuadroEntity))
                    pp.Add(QuadroEntity.PrefetchPathMaterialiQuadro, 0, pr, New RelationCollection(MaterialeQuadroEntity.Relations.MaterialeEntityUsingIdMateriale), New SortExpression(MaterialeQuadroFields.Posizione Or SortOperator.Ascending)).SubPath.Add(MaterialeQuadroEntity.PrefetchPathMateriale)

                    
                    Dim rpb As New RelationPredicateBucket(QuadroFields.Utilizzato = True)
                    'rpb.Relations.Add(QuadroEntity.Relations.MaterialeQuadroEntityUsingIdQuadro)
                    'rpb.Relations.Add(MaterialeQuadroEntity.Relations.MaterialeEntityUsingIdMateriale)

                    DA.FetchEntityCollection(_QuadriConsentiti, rpb, 0, New SortExpression(QuadroFields.Codice Or SortOperator.Ascending), pp)

                End If
                Return _QuadriConsentiti
            End Get
        End Property

        Public ReadOnly Property HasDocument As Boolean
            Get
                Return Me.RifArxivar <> ""
            End Get
        End Property

        Public Function GetCompetenzaDescription() As String
            Return String.Format("{0}-{1}", Me.Anno, Me.Scadenza.RifPeriodo)

        End Function

        Public Function AddDettaglio(CodQuadro As String, PosMateriale As Integer, Iva As Decimal, Valore As Decimal) As RigaDichiarazioneEntity
            Dim Q As QuadroEntity = Me.QuadriConsentiti.FirstOrDefault(Function(x) x.Codice = CodQuadro)
            If Q Is Nothing Then Throw New Exception("Quadro non consentito")
            If Q.MaterialiQuadro.Count = 0 Then Throw New Exception("Materiali non definiti per il quadro " & Q.Codice)
            Dim PMat As Integer = Val(PosMateriale) - 1
            If PMat > Q.MaterialiQuadro.Count - 1 Then Throw New Exception("Posizione materiale non valida per quadro " & Q.Codice)
            Dim M As MaterialeEntity = Q.MaterialiQuadro(PMat).Materiale

            Dim ret As RigaDichiarazioneEntity = Me.RigheDettaglio.AddNew
            ret.CodQuadro = CodQuadro
            ret.Materiale = M
            ret.CodUnitaMisura = M.CodUnitaMisura
            ret.PrezzoUnitario = M.Prezzo
            ret.Iva = Iva
            ret.Descrizione = M.Codice
            ret.Valore = Valore
            Return ret
        End Function

        Public Shared Function CanHaveAllegato(CodCategoria As String) As Boolean
            Return CodCategoria = "B" OrElse CodCategoria = "C" OrElse CodCategoria = "E"
        End Function

        Public Shared Function CanHaveProdotti(CodCategoria As String) As Boolean
            Return CodCategoria = "A"
        End Function

    End Class
End Namespace

