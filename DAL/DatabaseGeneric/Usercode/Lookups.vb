Imports System
Imports System.ComponentModel
Imports System.Collections
Imports DAL.FactoryClasses
Imports DAL.RelationClasses
Imports DAL.HelperClasses
Imports DAL.EntityClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports System.Linq

Namespace DAL
    Public Class Lookups
        Public Shared Sub ResetCollection(CollName As String)
            Dim Nm As String = "_" & CollName
            Dim P As System.Reflection.FieldInfo = GetType(Lookups).GetField(Nm, Reflection.BindingFlags.Static Or Reflection.BindingFlags.NonPublic)
            P.SetValue(GetType(Lookups), Nothing)
        End Sub

        Public Shared Function GetLookupDescription(ByVal Tb As DataTable, ByVal Cod As String, ByVal CmpDescrizione As String) As String
            Dim rw As DataRow = Tb.Rows.Find(Cod)
            If rw Is Nothing Then Return "???"
            Return (rw(CmpDescrizione) & "")
        End Function

        Public Shared Function GetLookupDescription(ByVal Coll As IEnumerable(Of EntityBase2), ByVal Cod As String, Optional ByVal CmpCodice As String = "Codice", Optional ByVal CmpDescrizione As String = "Descrizione") As String
            Dim x As EntityBase2 = Coll.FirstOrDefault(Function(e) e.Fields(CmpCodice).CurrentValue = Cod)
            If x Is Nothing Then Return ""
            Return x.Fields(CmpDescrizione).CurrentValue
        End Function

        Public Shared Sub PreloadCollection(CollName As String)
            Dim P As System.Reflection.PropertyInfo = GetType(Lookups).GetProperty(CollName, Reflection.BindingFlags.Static Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.GetProperty)
            Dim V As Object = P.GetValue(Nothing, New Object() {True})
        End Sub

        Private Shared _Comuni As EntityCollection(Of ComuneEntity)
        Public Shared ReadOnly Property Comuni(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of ComuneEntity)
            Get
                If _Comuni Is Nothing Or ForceRefetch Then
                    _Comuni = New EntityCollection(Of ComuneEntity)
                    DA.FetchEntityCollection(_Comuni, Nothing, 0, New SortExpression(ComuneFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _Comuni
            End Get
        End Property

        Private Shared _Province As EntityCollection(Of ProvinciaEntity)
        Public Shared ReadOnly Property Province(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of ProvinciaEntity)
            Get
                If _Province Is Nothing Or ForceRefetch Then
                    _Province = New EntityCollection(Of ProvinciaEntity)
                    DA.FetchEntityCollection(_Province, Nothing, 0, New SortExpression(ProvinciaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _Province
            End Get
        End Property

        Private Shared _Regioni As EntityCollection(Of RegioneEntity)
        Public Shared ReadOnly Property Regioni(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of RegioneEntity)
            Get
                If _Regioni Is Nothing Or ForceRefetch Then
                    _Regioni = New EntityCollection(Of RegioneEntity)
                    DA.FetchEntityCollection(_Regioni, Nothing, 0, New SortExpression(RegioneFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _Regioni
            End Get
        End Property

        ' LOOKUPS SCHEMA

        Private Shared _TipiAttivita As EntityCollection(Of TipoAttivitaEntity)
        Public Shared ReadOnly Property TipiAttivita(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoAttivitaEntity)
            Get
                If ForceRefetch Or _TipiAttivita Is Nothing Then
                    _TipiAttivita = New EntityCollection(Of TipoAttivitaEntity)
                    DA.FetchEntityCollection(_TipiAttivita, Nothing, 0, New SortExpression(TipoAttivitaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiAttivita
            End Get
        End Property

        Private Shared _TipiSede As EntityCollection(Of TipoSedeEntity)
        Public Shared ReadOnly Property TipiSede(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoSedeEntity)
            Get
                If ForceRefetch Or _TipiSede Is Nothing Then
                    _TipiSede = New EntityCollection(Of TipoSedeEntity)
                    DA.FetchEntityCollection(_TipiSede, Nothing, 0, New SortExpression(TipoSedeFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiSede
            End Get
        End Property

        Private Shared _QuoteAdesione As EntityCollection(Of QuotaAdesioneEntity)
        Public Shared ReadOnly Property QuoteAdesione(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of QuotaAdesioneEntity)
            Get
                If ForceRefetch Or _QuoteAdesione Is Nothing Then
                    _QuoteAdesione = New EntityCollection(Of QuotaAdesioneEntity)
                    DA.FetchEntityCollection(_QuoteAdesione, Nothing, 0, New SortExpression(QuotaAdesioneFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _QuoteAdesione
            End Get
        End Property

        Private Shared _Categorie As EntityCollection(Of CategoriaEntity)
        Public Shared ReadOnly Property Categorie(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of CategoriaEntity)
            Get
                If ForceRefetch Or _Categorie Is Nothing Then
                    _Categorie = New EntityCollection(Of CategoriaEntity)
                    DA.FetchEntityCollection(_Categorie, Nothing, 0, New SortExpression(CategoriaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _Categorie
            End Get
        End Property

        Private Shared _StatiSocio As EntityCollection(Of StatoSocioEntity)
        Public Shared ReadOnly Property StatiSocio(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of StatoSocioEntity)
            Get
                If ForceRefetch Or _StatiSocio Is Nothing Then
                    _StatiSocio = New EntityCollection(Of StatoSocioEntity)
                    DA.FetchEntityCollection(_StatiSocio, Nothing, 0, New SortExpression(StatoSocioFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _StatiSocio
            End Get
        End Property

        Private Shared _InfoStati As EntityCollection(Of InfoStatoEntity)
        Public Shared ReadOnly Property InfoStati(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of InfoStatoEntity)
            Get
                If ForceRefetch Or _InfoStati Is Nothing Then
                    _InfoStati = New EntityCollection(Of InfoStatoEntity)
                    DA.FetchEntityCollection(_InfoStati, Nothing, 0, New SortExpression(InfoStatoFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _InfoStati
            End Get
        End Property

        Private Shared _RuoliContatto As EntityCollection(Of RuoloContattoEntity)
        Public Shared ReadOnly Property RuoliContatto(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of RuoloContattoEntity)
            Get
                If ForceRefetch Or _RuoliContatto Is Nothing Then
                    _RuoliContatto = New EntityCollection(Of RuoloContattoEntity)
                    DA.FetchEntityCollection(_RuoliContatto, Nothing, 0, New SortExpression(RuoloContattoFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _RuoliContatto
            End Get
        End Property

        Private Shared _TitoliContatto As EntityCollection(Of TitoloContattoEntity)
        Public Shared ReadOnly Property TitoliContatto(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TitoloContattoEntity)
            Get
                If ForceRefetch Or _TitoliContatto Is Nothing Then
                    _TitoliContatto = New EntityCollection(Of TitoloContattoEntity)
                    DA.FetchEntityCollection(_TitoliContatto, Nothing, 0, New SortExpression(TitoloContattoFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TitoliContatto
            End Get
        End Property

        Private Shared _TipiAttrezzatura As EntityCollection(Of TipoAttrezzaturaEntity)
        Public Shared ReadOnly Property TipiAttrezzatura(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoAttrezzaturaEntity)
            Get
                If ForceRefetch Or _TipiAttrezzatura Is Nothing Then
                    _TipiAttrezzatura = New EntityCollection(Of TipoAttrezzaturaEntity)
                    DA.FetchEntityCollection(_TipiAttrezzatura, Nothing, 0, New SortExpression(TipoAttrezzaturaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiAttrezzatura
            End Get
        End Property

        Private Shared _FormeGiuridiche As EntityCollection(Of FormaGiuridicaEntity)
        Public Shared ReadOnly Property FormeGiuridiche(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of FormaGiuridicaEntity)
            Get
                If ForceRefetch Or _FormeGiuridiche Is Nothing Then
                    _FormeGiuridiche = New EntityCollection(Of FormaGiuridicaEntity)
                    DA.FetchEntityCollection(_FormeGiuridiche, Nothing, 0, New SortExpression(FormaGiuridicaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _FormeGiuridiche
            End Get
        End Property

        Private Shared _TipiLicenza As EntityCollection(Of TipoLicenzaEntity)
        Public Shared ReadOnly Property TipiLicenza(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoLicenzaEntity)
            Get
                If ForceRefetch Or _TipiLicenza Is Nothing Then
                    _TipiLicenza = New EntityCollection(Of TipoLicenzaEntity)
                    DA.FetchEntityCollection(_TipiLicenza, Nothing, 0, New SortExpression(TipoLicenzaFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiLicenza
            End Get
        End Property

        Private Shared _TipiSocio As EntityCollection(Of TipoSocioEntity)
        Public Shared ReadOnly Property TipiSocio(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoSocioEntity)
            Get
                If ForceRefetch Or _TipiSocio Is Nothing Then
                    _TipiSocio = New EntityCollection(Of TipoSocioEntity)
                    DA.FetchEntityCollection(_TipiSocio, Nothing, 0, New SortExpression(TipoSocioFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiSocio
            End Get
        End Property


        Private Shared _TipiQuadro As EntityCollection(Of TipoQuadroEntity)
        Public Shared ReadOnly Property TipiQuadro(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoQuadroEntity)
            Get
                If ForceRefetch Or _TipiQuadro Is Nothing Then
                    _TipiQuadro = New EntityCollection(Of TipoQuadroEntity)
                    DA.FetchEntityCollection(_TipiQuadro, Nothing, 0, New SortExpression(TipoQuadroFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiQuadro
            End Get
        End Property

        Private Shared _TipiMateriale As EntityCollection(Of TipoMaterialeEntity)
        Public Shared ReadOnly Property TipiMateriale(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of TipoMaterialeEntity)
            Get
                If ForceRefetch Or _TipiMateriale Is Nothing Then
                    _TipiMateriale = New EntityCollection(Of TipoMaterialeEntity)
                    DA.FetchEntityCollection(_TipiMateriale, Nothing, 0, New SortExpression(TipoMaterialeFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _TipiMateriale
            End Get
        End Property


        Private Shared _Scadenze As EntityCollection(Of ScadenzaEntity)
        Public Shared ReadOnly Property Scadenze(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of ScadenzaEntity)
            Get
                If ForceRefetch Or _Scadenze Is Nothing Then
                    _Scadenze = New EntityCollection(Of ScadenzaEntity)
                    DA.FetchEntityCollection(_Scadenze, Nothing, 0, New SortExpression(ScadenzaFields.Codice Or SortOperator.Descending))
                End If
                Return _Scadenze
            End Get
        End Property

        Private Shared _Materiali As EntityCollection(Of MaterialeEntity)
        Public Shared ReadOnly Property Materiali(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of MaterialeEntity)
            Get
                If ForceRefetch Or _Materiali Is Nothing Then
                    _Materiali = New EntityCollection(Of MaterialeEntity)
                    DA.FetchEntityCollection(_Materiali, Nothing, 0, New SortExpression(MaterialeFields.Codice Or SortOperator.Descending))
                End If
                Return _Materiali
            End Get
        End Property

        Private Shared _UnitaMisura As EntityCollection(Of UnitaMisuraEntity)
        Public Shared ReadOnly Property UnitaMisura(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of UnitaMisuraEntity)
            Get
                If ForceRefetch Or _UnitaMisura Is Nothing Then
                    _UnitaMisura = New EntityCollection(Of UnitaMisuraEntity)
                    DA.FetchEntityCollection(_UnitaMisura, Nothing, 0, New SortExpression(UnitaMisuraFields.Codice Or SortOperator.Ascending))
                End If
                Return _UnitaMisura
            End Get
        End Property

        Private Shared _Quadri As EntityCollection(Of QuadroEntity)
        Public Shared ReadOnly Property Quadri(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of QuadroEntity)
            Get
                If ForceRefetch Or _Quadri Is Nothing Then
                    _Quadri = New EntityCollection(Of QuadroEntity)
                    DA.FetchEntityCollection(_Quadri, Nothing, 0, New SortExpression(QuadroFields.Codice Or SortOperator.Ascending))
                End If
                Return _Quadri
            End Get
        End Property

        Private Shared _ModalitaPagamento As EntityCollection(Of ModalitaPagamentoEntity)
        Public Shared ReadOnly Property ModalitaPagamento(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of ModalitaPagamentoEntity)
            Get
                If ForceRefetch Or _ModalitaPagamento Is Nothing Then
                    _ModalitaPagamento = New EntityCollection(Of ModalitaPagamentoEntity)
                    DA.FetchEntityCollection(_ModalitaPagamento, Nothing, 0, New SortExpression(ModalitaPagamentoFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _ModalitaPagamento
            End Get
        End Property

        Private Shared _Eventi As EntityCollection(Of EventoEntity)
        Public Shared ReadOnly Property Eventi(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of EventoEntity)
            Get
                If _Eventi Is Nothing Or ForceRefetch Then
                    _Eventi = New EntityCollection(Of EventoEntity)
                    Dim pp As New PrefetchPath2(CInt(EntityType.EventoEntity))
                    pp.Add(EventoEntity.PrefetchPathEventiFigli)
                    pp.Add(EventoEntity.PrefetchPathEventoPadre)
                    DA.FetchEntityCollection(_Eventi, Nothing, 0, New SortExpression(EventoFields.Descrizione Or SortOperator.Ascending), pp)
                End If
                Return _Eventi
            End Get
        End Property

        Private Shared _CodiciCER As EntityCollection(Of CodiciCerEntity)
        Public Shared ReadOnly Property CodiciCER(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of CodiciCerEntity)
            Get
                If _CodiciCER Is Nothing Or ForceRefetch Then
                    _CodiciCER = New EntityCollection(Of CodiciCerEntity)
                    Dim pp As New PrefetchPath2(CInt(EntityType.CodiciCerEntity))
                    DA.FetchEntityCollection(_CodiciCER, Nothing, 0, New SortExpression(CodiciCerFields.Descrizione Or SortOperator.Ascending), pp)
                End If
                Return _CodiciCER
            End Get
        End Property


        Private Shared _EventiUtente As EntityView2(Of EventoEntity)
        Public Shared ReadOnly Property EventiUtente() As EntityView2(Of EventoEntity)
            Get
                If _EventiUtente Is Nothing Then
                    _EventiUtente = Eventi.CreateView(New PredicateExpression(EventoFields.Codice Mod ("%_M")))
                End If
                Return _EventiUtente
            End Get
        End Property

        Private Shared _AliquoteIVA As EntityCollection(Of AliquotaIvaEntity)
        Public Shared ReadOnly Property AliquoteIVA(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of AliquotaIvaEntity)
            Get
                If _AliquoteIVA Is Nothing Or ForceRefetch Then
                    _AliquoteIVA = New EntityCollection(Of AliquotaIvaEntity)
                    DA.FetchEntityCollection(_AliquoteIVA, Nothing, 0, New SortExpression(AliquotaIvaFields.DataIniziale Or SortOperator.Descending))
                End If
                Return _AliquoteIVA
            End Get
        End Property

        Private Shared _CategorieProdotto As EntityCollection(Of ProdottoEntity)
        Public Shared ReadOnly Property CategorieProdotto(Optional ByVal ForceRefetch As Boolean = False) As EntityCollection(Of ProdottoEntity)
            Get
                If ForceRefetch Or _CategorieProdotto Is Nothing Then
                    _CategorieProdotto = New EntityCollection(Of ProdottoEntity)
                    Dim pr As New PredicateExpression(New FieldCompareNullPredicate(ProdottoFields.IdRiferimento, Nothing))
                    DA.FetchEntityCollection(_CategorieProdotto, New RelationPredicateBucket(pr), 0, New SortExpression(ProdottoFields.Descrizione Or SortOperator.Ascending))
                End If
                Return _CategorieProdotto
            End Get
        End Property

        'DATATABLE
        Private Shared _Ruoli As DataTable
        Public Shared ReadOnly Property Ruoli As DataTable
            Get
                If _Ruoli Is Nothing Then
                    _Ruoli = New DataTable
                    _Ruoli.Columns.Add("Codice")
                    _Ruoli.Columns.Add("Descrizione")
                    _Ruoli.PrimaryKey = New DataColumn() {_Ruoli.Columns("Codice")}
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.AMMINISTRATORE, "Amministratore"})
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.DIREZIONE, "Direzione"})
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.CONTABILITA, "Contabilità"})
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.SEGRETERIA, "Segreteria"})
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.REPORT_QUOTE, "Report quote"})
                    _Ruoli.Rows.Add(New Object() {Enums.Ruolo.SEMPLICE, "Semplice"})
                End If
                Return _Ruoli
            End Get
        End Property

        Private Shared _StatiDocumento As DataTable
        Public Shared ReadOnly Property StatiDocumento As DataTable
            Get
                If _StatiDocumento Is Nothing Then
                    _StatiDocumento = New DataTable
                    _StatiDocumento.Columns.Add("Codice")
                    _StatiDocumento.Columns.Add("Descrizione")
                    _StatiDocumento.PrimaryKey = New DataColumn() {_StatiDocumento.Columns("Codice")}
                    _StatiDocumento.Rows.Add(New Object() {Enums.StatoDocumento.NO, "No"})
                    _StatiDocumento.Rows.Add(New Object() {Enums.StatoDocumento.OK, "Ok"})
                    _StatiDocumento.Rows.Add(New Object() {Enums.StatoDocumento.PARTIAL, "Parziale"})
                    _StatiDocumento.Rows.Add(New Object() {Enums.StatoDocumento.FORCED, "Forzato"})
                End If
                Return _StatiDocumento
            End Get
        End Property

        Private Shared _TipiRiunione As DataTable
        Public Shared ReadOnly Property TipiRiunione As DataTable
            Get
                If _TipiRiunione Is Nothing Then
                    _TipiRiunione = New DataTable
                    _TipiRiunione.Columns.Add("Codice")
                    _TipiRiunione.Columns.Add("Descrizione")
                    _TipiRiunione.PrimaryKey = New DataColumn() {_TipiRiunione.Columns("Codice")}
                    _TipiRiunione.Rows.Add(New Object() {Enums.TipoRiunione.ASSEMBLEA, "Assemblea"})
                    _TipiRiunione.Rows.Add(New Object() {Enums.TipoRiunione.CDA, "Consiglio di Amministrazione"})
                End If
                Return _TipiRiunione
            End Get
        End Property

        Private Shared _MotiviPassaggio As DataTable
        Public Shared ReadOnly Property MotiviPassaggio As DataTable
            Get
                If _MotiviPassaggio Is Nothing Then
                    _MotiviPassaggio = New DataTable
                    _MotiviPassaggio.Columns.Add("Codice")
                    _MotiviPassaggio.Columns.Add("Descrizione")
                    _MotiviPassaggio.PrimaryKey = New DataColumn() {_MotiviPassaggio.Columns("Codice")}
                    _MotiviPassaggio.Rows.Add(New Object() {Enums.MotivoPassaggio.NUOVO, "Nuovo socio"})
                    _MotiviPassaggio.Rows.Add(New Object() {Enums.MotivoPassaggio.RAGIONE_SOCIALE, "Cambio ragione sociale"})
                    _MotiviPassaggio.Rows.Add(New Object() {Enums.MotivoPassaggio.USCITA, "Uscita"})
                End If
                Return _MotiviPassaggio
            End Get
        End Property

        Private Shared _TipiIncasso As DataTable
        Public Shared ReadOnly Property TipiIncasso As DataTable
            Get
                If _TipiIncasso Is Nothing Then
                    _TipiIncasso = New DataTable
                    _TipiIncasso.Columns.Add("Codice")
                    _TipiIncasso.Columns.Add("Descrizione")
                    _TipiIncasso.PrimaryKey = New DataColumn() {_TipiIncasso.Columns("Codice")}
                    _TipiIncasso.Rows.Add(New Object() {Enums.TipiIncasso.VERSAMENTO, "Versamento"})
                    _TipiIncasso.Rows.Add(New Object() {Enums.TipiIncasso.RATA, "Rata"})
                    _TipiIncasso.Rows.Add(New Object() {Enums.TipiIncasso.RATAPAGATA, "Rata pagata"})
                End If
                Return _TipiIncasso
            End Get
        End Property

        Private Shared _MotiviLibroSoci As DataTable
        Public Shared ReadOnly Property MotiviLibroSoci As DataTable
            Get
                If _MotiviLibroSoci Is Nothing Then
                    _MotiviLibroSoci = New DataTable
                    _MotiviLibroSoci.Columns.Add("Codice")
                    _MotiviLibroSoci.Columns.Add("Descrizione")
                    _MotiviLibroSoci.PrimaryKey = New DataColumn() {_MotiviLibroSoci.Columns("Codice")}
                    _MotiviLibroSoci.Rows.Add(New Object() {Enums.MotivoLibroSoci.NUOVO, "Nuovo"})
                    _MotiviLibroSoci.Rows.Add(New Object() {Enums.MotivoLibroSoci.NUOVO_CRS, "Nuova ragione sociale"})
                    _MotiviLibroSoci.Rows.Add(New Object() {Enums.MotivoLibroSoci.USCITA, "Uscita"})
                    _MotiviLibroSoci.Rows.Add(New Object() {Enums.MotivoLibroSoci.USCITA_CRS, "Vecchia ragione sociale"})
                End If
                Return _MotiviLibroSoci
            End Get
        End Property

        Private Shared _RuoliAziendeAllegato As DataTable
        Public Shared ReadOnly Property RuoliAziendeAllegato As DataTable
            Get
                If _RuoliAziendeAllegato Is Nothing Then
                    _RuoliAziendeAllegato = New DataTable
                    _RuoliAziendeAllegato.Columns.Add("Codice")
                    _RuoliAziendeAllegato.Columns.Add("Descrizione")
                    _RuoliAziendeAllegato.PrimaryKey = New DataColumn() {_RuoliAziendeAllegato.Columns("Codice")}
                    _RuoliAziendeAllegato.Rows.Add(New Object() {Enums.RuoloAziendaAllegato.FORNITORE, "Fornitore"})
                    _RuoliAziendeAllegato.Rows.Add(New Object() {Enums.RuoloAziendaAllegato.RICEVITORE, "Ricevitore"})
                End If
                Return _RuoliAziendeAllegato
            End Get
        End Property


    End Class
End Namespace