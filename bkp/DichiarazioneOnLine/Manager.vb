Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class Manager

    Public Shared Sub Open()
        Try
            Dim dlg As New System.Windows.Forms.OpenFileDialog
            dlg.Filter = "Dichiarazioni Polieco|*.dicpoli|Tutti i file|*.*"
            dlg.CheckFileExists = True
            If dlg.ShowDialog = Windows.Forms.DialogResult.Cancel Then Return
            Dim Path As String = dlg.FileName
            Open(Path)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Sub Open(Path As String)
        Try
            Dim ds As New Datasets.dsDichiarazione
            ds.ReadXml(Path)
            Dim F As New FDichiarazione
            F.Apri(ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Sub Open(dol As DAL.EntityClasses.DichiarazioneOnLineEntity)
        Try
            Dim F As New FDichiarazione
            F.Apri(dol)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Function GetCoefficienti(d As Datasets.dsDichiarazione) As System.Collections.Generic.Dictionary(Of String, Single)
        Dim Anno As Integer = d.Dichiarazione(0).Periodo.Substring(0, 4)
        Return GetCoefficienti(Anno)
    End Function



    Public Shared Function GetCoefficienti(Anno As Integer) As System.Collections.Generic.Dictionary(Of String, Single)
        Dim ret As New System.Collections.Generic.Dictionary(Of String, Single)
        If Anno <= 2014 Then
            ret.Add("A.1.1", 0.05)
            ret.Add("A.1.2", 0.01)
            ret.Add("A.1.3.1", 0.005)
            ret.Add("A.1.3.2", 0.021)
            ret.Add("A.2", 0.01)

            ret.Add("B.1", 500)
            ret.Add("B.1.1", 0.05)
            ret.Add("B.1.2", 0.01)
            ret.Add("B.1.3.1", 0.005)
            ret.Add("B.1.3.2", 0.021)
            ret.Add("B.2", 0.01)

            ret.Add("C.1", 0.05)
            ret.Add("D.1", 0.05)
            ret.Add("E.1", 0.05)
        Else
            ret.Add("A.1.1", 0.045)
            ret.Add("A.1.2", 0.0095)
            ret.Add("A.1.3.1", 0.0045)
            ret.Add("A.1.3.2", 0.019)
            ret.Add("A.2", 0.0095)

            ret.Add("B.1", 450)
            ret.Add("B.1.1", 0.045)
            ret.Add("B.1.2", 0.0095)
            ret.Add("B.1.3.1", 0.0045)
            ret.Add("B.1.3.2", 0.019)
            ret.Add("B.2", 0.0095)

            ret.Add("C.1", 0.045)
            ret.Add("D.1", 0.045)
            ret.Add("E.1", 0.045)
        End If
        Return ret
    End Function

    Public Shared Sub ImportaFile(FilePath As String)
        Dim ds As New Datasets.dsDichiarazione
        ds.ReadXml(FilePath)
        ImportaDichiarazione(ds)
    End Sub


    Public Shared Sub Analizza(dol As DichiarazioneOnLineEntity)
        If dol.Stato = Enums.StatoDOL.ASSOCIATA Then Throw New Exception("Dichiarazione già associata")
        

        Dim ds As Datasets.dsDichiarazione = dol.DatiCompilati
        If Not dol.HasAzienda Then
            'Ricerca azienda
            Dim PIVA As String = dol.DichiarazionePartitaIVA
            If PIVA = "" Then Throw New Exception("Partita IVA non definita")
            Dim Az As AziendaEntity = Nothing
            Dim srcAz As New EntityCollection(Of AziendaEntity)
            DA.FetchEntityCollection(srcAz, New RelationPredicateBucket(AziendaFields.PartitaIva = PIVA), 2)
            If srcAz.Count = 0 Then Throw New Exception("Nessuna azienda trovata per partita IVA")
            If srcAz.Count > 1 Then Throw New Exception("Per la partita iva indicata sono state trovate più aziende")
            Az = srcAz(0)
            dol.AssociaAzienda(Az)
            DA.SaveEntity(dol, True)
        End If
        
        Manager.AssociaDichiarazione(dol, True)


    End Sub



    'Private Shared _DA As DataAccessAdapterBase
    'Public Shared ReadOnly Property DA As DataAccessAdapterBase
    '    Get
    '        Return _DA
    '    End Get
    'End Property

    'Public Shared Sub SetDataAdapter(DA As DataAccessAdapterBase)

    '    _DA = DA
    'End Sub


    Public Shared RicercaAzienda As System.Func(Of DichiarazioneOnLineEntity, AziendaEntity)
    Public Shared ApriAzienda As System.Action(Of AziendaEntity)
    Public Shared ApriDichiarazione As System.Action(Of Integer)
    Public Shared PrenotaDocumentoArxivar As System.Action(Of DichiarazioneOnLineEntity)

    Public Shared Function ImportaDichiarazione(ds As Datasets.dsDichiarazione) As DichiarazioneOnLineEntity
        'Verifica se esiste
        Dim Prot As String = ds.Dichiarazione(0).Protocollo
        Dim dol As New DichiarazioneOnLineEntity
        If DA.FetchEntityUsingUniqueConstraint(dol, New PredicateExpression(DichiarazioneOnLineFields.Protocollo = Prot)) Then
            Throw New Exception("Protocollo già utilizzato. Impossibile importare")
        End If

        dol = New DichiarazioneOnLineEntity
        dol.Protocollo = ds.Dichiarazione(0).Protocollo
        dol.DataCompilazione = ds.Dichiarazione(0).Data
        Dim PP As String = ds.Dichiarazione(0).Periodo
        dol.Anno = PP.Substring(0, 4)
        If PP.Contains("-") Then
            dol.Periodo = PP.Substring(5)
        Else
            dol.Periodo = "A"
        End If


        dol.Stato = DAL.Enums.StatoDOL.INSERITA
        dol.SetDatiCompilati(ds)

        DA.SaveEntity(dol, True)
        Return dol
    End Function


    Public Shared Function GetTotaleDichiarazione(ds As Datasets.dsDichiarazione) As Decimal


        Dim d As Datasets.dsDichiarazione.DichiarazioneRow = ds.Dichiarazione(0)
        Dim v, tA, tB, tC, tD, tE, tIVA, tNetto, Tot As Single

        Dim coeff As System.Collections.Generic.Dictionary(Of String, Single) = GetCoefficienti(ds)


        tA = 0
        If d.CatA Then
            v = d.V_A1_1 * coeff("A.1.1")
            tA += v

            v = d.V_A1_2 * coeff("A.1.2")
            tA += v

            v = d.V_A1_3_1 * coeff("A.1.3.1")
            tA += v

            v = d.V_A1_3_2 * coeff("A.1.3.2")
            tA += v

            v = d.V_A2_1 * coeff("A.2")
            tA += v
        End If

        tB = 0
        If d.CatB Then
            If d.V_B_SEL = "B1" Then
                tB = coeff("B.1")
            ElseIf d.V_B_SEL = "B2_1" Then
                tB = 0
            Else
                v = d.V_B1_1 * coeff("B.1.1")
                tB += v

                v = d.V_B1_2 * coeff("B.1.2")
                tB += v

                v = d.v_B1_3_1 * coeff("B.1.3.1")
                tB += v

                v = d.V_B1_3_2 * coeff("B.1.3.2")
                tB += v

                v = d.V_B2_1 * coeff("B.2")
                tB += v
            End If
        End If

        tC = 0
        If d.CatC Then
            tC = d.VC1 * coeff("C.1")
        End If

        tD = 0
        If d.CatD Then
            tD = d.VD1 * coeff("D.1")
        End If

        tE = 0
        If d.CatE Then
            tE = d.VE1 * coeff("E.1")
        End If


        Dim IVA As Single = d.Iva / 100

        v = tA * IVA
        tNetto += tA
        tIVA += v
        Tot += v + tA
        
        v = tB * IVA
        tNetto += tB
        tIVA += v
        Tot += v + tB
        
        v = tC * IVA
        tNetto += tC
        tIVA += v
        Tot += v + tC
        
        v = tD * IVA
        tNetto += tD
        tIVA += v
        Tot += v + tD
        
        v = tE * IVA
        tNetto += tE
        tIVA += v
        Tot += v + tE
        
        Return Tot

    End Function



    Public Shared Function AssociaDichiarazione(dol As DichiarazioneOnLineEntity, AutoCheck As Boolean) As DichiarazioneEntity

        Try
            'Trace.TraceInformation("Verifica dichiarazione")

            If dol.HasDichiarazione Then Throw New Exception("E' già stata creata e associata una dichiarazione")
            If Not dol.HasAzienda Then Throw New Exception("Non è  stata associata nessuna azieda")


            Dim ds As Datasets.dsDichiarazione = dol.DatiCompilati
            Dim dc As Datasets.dsDichiarazione.DichiarazioneRow = ds.Dichiarazione(0)
            'If ds.Voce.Compute("Count(Id)", "ISNULL(IdAzienda,'')=''") <> 0 Then Throw New Exception("Esistono aziende negli elenchi allegati non associate")
            If dol.StatoAllegatiValidati <> StateCompleteEnum.COMPLETE Then Throw New Exception("Esistono aziende negli elenchi allegati non associate")

            Dim az As New AziendaEntity(dol.IdAzienda)
            Dim pp As New PrefetchPath2(CInt(EntityType.AziendaEntity))
            Dim ppd As PrefetchPathElement2 = pp.Add(AziendaEntity.PrefetchPathDichiarazioni)
            ppd.SubPath.Add(DichiarazioneEntity.PrefetchPathScadenza)

            Dim c As New Context
            c.Add(az)
            DA.FetchEntity(az, pp, c)

            Dim dic As DichiarazioneEntity = az.Dichiarazioni.FirstOrDefault(Function(d)
                                                                                 Return d.Anno = dol.Anno AndAlso d.Scadenza IsNot Nothing AndAlso d.Scadenza.RifPeriodo = dol.Periodo
                                                                             End Function)
            If dic Is Nothing Then Throw New Exception("Non è stata trovata nessuna dichiarazione compatibile")

            pp = New PrefetchPath2(CInt(EntityType.DichiarazioneEntity))
            pp.Add(DichiarazioneEntity.PrefetchPathRigheDettaglio)
            DA.FetchEntity(dic, pp, c)

            If dic.RigheDettaglio.Count > 0 Then
                Dim Tot As Decimal = dic.RigheDettaglio.Sum(Function(x) x.ImportoLordo)

                If AutoCheck Then
                    Dim Totdol As Decimal = Manager.GetTotaleDichiarazione(ds)
                    If Math.Abs(Tot - Totdol) > 0.05 Then Throw New Exception(String.Format("Totale dichiarazione esistente non coincidente [ {0:c2} anzichè {1:c2} ]", Totdol, Tot))
                Else
                    If MsgBox("La dichiarazione trovata risulta essere già compilata per un importo totale di " & Tot.ToString("c2") & "." & vbCr _
                          & "Associare la dichiarazione online ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo Or vbDefaultButton2) = MsgBoxResult.No Then Return Nothing

                End If

                
            Else
                'Compilazione
                '   Trace.TraceInformation("Dichiarazione trovata - Inizio compilazione")

                Dim Iva As Decimal = dc.Iva

                'Trace.TraceInformation("Compilazione dettaglio")
                If dc.CatA Then
                    If dc.V_A1_1 <> 0 Then dic.AddDettaglio("A1", 1, Iva, dc.V_A1_1)
                    If dc.V_A1_2 <> 0 Then dic.AddDettaglio("A1", 2, Iva, dc.V_A1_2)
                    If dc.V_A1_3_1 <> 0 Then dic.AddDettaglio("A1", 3, Iva, dc.V_A1_3_1)
                    If dc.V_A1_3_2 <> 0 Then dic.AddDettaglio("A1", 4, Iva, dc.V_A1_3_2)
                    If dc.V_A2_1 <> 0 Then dic.AddDettaglio("A2", 1, Iva, dc.V_A2_1)
                End If

                If dc.CatB Then
                    If dc.V_B_SEL = "B1" Then
                        dic.AddDettaglio("B", 2, Iva, 1)
                    ElseIf dc.V_B_SEL = "B2_1" Then
                        dic.AddDettaglio("B", 1, Iva, 1)
                    ElseIf dc.V_B_SEL = "B2_2" Then
                        If dc.V_B1_1 <> 0 Then dic.AddDettaglio("A1", 1, Iva, dc.V_B1_1)
                        If dc.V_B1_2 <> 0 Then dic.AddDettaglio("A1", 2, Iva, dc.V_B1_2)
                        If dc.v_B1_3_1 <> 0 Then dic.AddDettaglio("A1", 3, Iva, dc.v_B1_3_1)
                        If dc.V_B1_3_2 <> 0 Then dic.AddDettaglio("A1", 4, Iva, dc.V_B1_3_2)
                        If dc.V_B2_1 <> 0 Then dic.AddDettaglio("A2", 1, Iva, dc.V_B2_1)
                    End If
                End If

                If dc.CatC Then
                    If dc.VC1 <> 0 Then dic.AddDettaglio("C", 1, Iva, dc.VC1)
                End If

                If dc.CatD Then
                    If dc.VD1 <> 0 Then dic.AddDettaglio("D", 1, Iva, dc.VD1)
                End If

                If dc.CatE Then
                    If dc.VE1 <> 0 Then dic.AddDettaglio("E", 1, Iva, dc.VE1)
                End If
            End If

            dol.DataRicevimento = Date.Now
            dic.DataRicezione = dol.DataRicevimento

            dic.CodStatoDichiarazione = Enums.StatoDocumento.OK
            dol.Dichiarazione = dic

            If PrenotaDocumentoArxivar IsNot Nothing Then
                PrenotaDocumentoArxivar.Invoke(dol)
            End If

            dol.Stato = Enums.StatoDOL.ASSOCIATA
            DA.SaveEntity(dol, True, True)
            'DA.Commit()
            Return dic
        Catch ex As Exception
            dol.Dichiarazione = Nothing
            If ex.Source = "ArxivarWCFWrapper" Then
                'UserMessage:   Regola di univocità sulla classe documentale violata a causa della presenza in ARXivar del profilo codice '6621'. Impossibile inserire il profilo.   ErrorMessage:6621"
                If Text.RegularExpressions.Regex.IsMatch(ex.Message, "^UserMessage:[^a-z]+Regola di univocit", Text.RegularExpressions.RegexOptions.IgnoreCase) Then
                    Dim p As Integer = ex.Message.LastIndexOf(":")
                    Dim id As Integer = Val(ex.Message.Substring(p + 1))
                    Dim Msg As String = "Competenza già profilata con Id:" & id
                    Throw New Exception(Msg)
                End If
            End If
            Throw
        End Try
    End Function

    Public Shared Sub Annulla(dol As DichiarazioneOnLineEntity)
        dol.Stato = Enums.StatoDOL.ANNULLATA
        DA.SaveEntity(dol, True)
    End Sub

    Public Shared Sub Ripristina(dol As DichiarazioneOnLineEntity)
        dol.Stato = Enums.StatoDOL.INSERITA
        DA.SaveEntity(dol, True)
    End Sub

    Public Enum TipoAllegato
        B
        C
        E1
        E2
        E3
    End Enum

    Private Shared _TipiAllegato As DataTable
    Public Shared ReadOnly Property TipiAllegato() As DataTable
        Get
            If _TipiAllegato Is Nothing Then
                _TipiAllegato = New DataTable
                _TipiAllegato.Columns.Add("Codice")
                _TipiAllegato.Columns.Add("Descrizione")
                _TipiAllegato.PrimaryKey = New DataColumn() {_TipiAllegato.Columns("Codice")}
                _TipiAllegato.Rows.Add(New Object() {TipoAllegato.B, "Allegato B"})
                _TipiAllegato.Rows.Add(New Object() {TipoAllegato.C, "Allegato C - Aziende da cui si ricevono i rifiuti"})
                _TipiAllegato.Rows.Add(New Object() {TipoAllegato.E1, "Allegato E1 - Aziende da cui si ricevono i rifiuti"})
                _TipiAllegato.Rows.Add(New Object() {TipoAllegato.E2, "Allegato E2 - Impianti finali a cui conferiscono i rifiuti"})
                _TipiAllegato.Rows.Add(New Object() {TipoAllegato.E3, "Allegato E3 - Impianti esteri a cui conferiscono i rifiuti"})
            End If
            Return _TipiAllegato
        End Get
    End Property



End Class
