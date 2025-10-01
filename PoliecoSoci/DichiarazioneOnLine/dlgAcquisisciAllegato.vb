Imports Syncfusion.XlsIO
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Public Class dlgAcquisisciAllegato

    Private _xlsApp As IApplication
    Private _wb As IWorkbook

    Public OpenAziendaAction As Action(Of AziendaEntity)

    Private _isReady As Boolean
    Private _FLog As mdsUIControls.Logging.dlgLogRtf = mdsUIControls.Logging.dlgLogRtf.GetInstance

    Private ReadOnly Property xlsApp As IApplication
        Get
            If _xlsApp Is Nothing Then
                _xlsApp = New ExcelEngine().Excel
            End If
            Return _xlsApp
        End Get
    End Property

    Private _AziendaAllegato As AziendaEntity
    Property AziendaAllegato As AziendaEntity
        Get
            Return _AziendaAllegato
        End Get
        Set(value As AziendaEntity)
            _AziendaAllegato = value
            If _AziendaAllegato Is Nothing Then
                tsbAzienda.Available = False
            Else
                tsbAzienda.Available = (OpenAziendaAction IsNot Nothing)
            End If
        End Set
    End Property

    Public Sub Apri(Optional Path As String = "")
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()
        AziendaAllegato = Nothing
    End Sub

    Private Sub ucFile_SceltaFile(sender As Object, e As EventArgs) Handles ucFile.SceltaFile
        tsbAcquisisci.PerformClick()
    End Sub

    Private Sub ApriFile(Path As String)

        Try

            Trace.TraceInformation("Apertura file [" & Path & "]")
            _wb = xlsApp.Workbooks.Open(Path, ExcelParseOptions.Default, True, "")
            'Test 
            AziendaAllegato = Nothing
            Dim ws As IWorksheet = _wb.Worksheets(0)
            If ws.Name <> "01-Dati generali" Then Throw New Exception("File non valido")
            If ws(1, 3).Value <> "Dichiarazione periodica" Then Throw New Exception("File non valido")
            Dim Vers As String = ws(1, 8).Value
            If Vers = "" Then Throw New Exception("File non valido")
            Trace.TraceInformation("File riconosciuto - Versione " & Vers.Replace("Versione", ""))
            Trace.TraceInformation("")
            Dim PIVA As String = ws(7, 3).Value
            Dim RagSoc As String = ws(6, 3).Value
            Trace.TraceInformation("Azienda: " & RagSoc & " - PIVA:" & PIVA)

            Dim pr As New PredicateExpression
            pr.AddWithAnd(AziendaFields.PartitaIva = PIVA)
            Dim aa As New EntityCollection(Of AziendaEntity)

            DAL.DA.FetchEntityCollection(aa, New RelationPredicateBucket(pr))
            If aa.Count = 0 Then Throw New Exception("Azienda non trovata")
            If aa.Count > 1 Then
                Trace.TraceWarning("Azienda non univoca")
            End If

            AziendaAllegato = aa(0)

            Trace.TraceInformation("Azienda corrispondente: " & AziendaAllegato.Id & " - " & AziendaAllegato.RagioneSociale)

            Trace.TraceInformation("Individuazione dichiarazione")

            Dim anno As String = ws(11, 3).Value
            Dim periodo As String = ws(12, 3).Value

            Dim DtIni As Date
            Dim DtFine As Date
            If periodo = "ANNUALE" Then
                DtIni = DateSerial(anno, 1, 1)
                DtFine = DateSerial(anno, 12, 31)
            ElseIf periodo = "SEMESTRE 1" Then
                DtIni = DateSerial(anno, 1, 1)
                DtFine = DateSerial(anno, 6, 30)
            ElseIf periodo = "SEMESTRE 2" Then
                DtIni = DateSerial(anno, 6, 30)
                DtFine = DateSerial(anno, 12, 31)
            Else
                Throw New Exception("Periodo indicato non valido [" & periodo & "]")
            End If

            Dim dd As EntityCollection(Of DichiarazioneEntity) = AziendaAllegato.Dichiarazioni
            Dim pp As New PrefetchPath2(CInt(DAL.EntityType.DichiarazioneEntity))
            pp.Add(DichiarazioneEntity.PrefetchPathAllegato)


            Dim rpbDic As RelationPredicateBucket = AziendaAllegato.GetRelationInfoDichiarazioni
            rpbDic.PredicateExpression.Add(DichiarazioneFields.Anno = anno)
            DAL.DA.FetchEntityCollection(dd, rpbDic, pp)

            If dd.Count = 0 Then Throw New Exception("Nessuna dichiarazione trovata per l'anno " & anno)
            Trace.TraceInformation("Trovate " & dd.Count & " dichiarazioni nell'anno " & anno)

            Dim d As DichiarazioneEntity
            Dim p As Integer = 0
            Do While p < dd.Count
                d = dd(p)
                If d.DataInizio <> DtIni Or d.DataFine <> DtFine Then
                    dd.Remove(d)
                Else
                    p += 1
                End If
            Loop

            If dd.Count = 0 Then Throw New Exception("Nessuna dichiarazione dell'azienda corrisponde al periodo indicato: " & DtIni & " - " & DtFine)
            If dd.Count > 1 Then Throw New Exception("Trovate più dichiarazioni che corrispondono al periodo indicato: " & DtIni & " - " & DtFine)

            d = dd(0)
            Trace.TraceInformation("Trovata unica dichiarazione")
            If d.HasAllegato Then Throw New Exception("La dichiarazione ha già un allegato")

            Trace.TraceInformation("Acquisizione dati allegati")

            If ws(8, 3).Value <> "" Then
                Trace.TraceInformation("Allegato categoria B")
                Dim wsAllB As IWorksheet = _wb.Worksheets("CAT.B")
                ImportaFoglioAllegato(wsAllB, "B", d)
            End If

            If ws(9, 3).Value <> "" Then
                Trace.TraceInformation("Allegato categoria C")
                Dim wsAllC As IWorksheet = _wb.Worksheets("CAT.C")
                ImportaFoglioAllegato(wsAllC, "C", d)
            End If

            If ws(10, 3).Value <> "" Then
                Trace.TraceInformation("Allegato categoria E")
                Dim wsAllE As IWorksheet = _wb.Worksheets("CAT.E")
                ImportaFoglioAllegato(wsAllE, "E", d)
            End If

            Trace.TraceInformation("")
            Trace.TraceInformation("**********************************")
            Trace.TraceInformation("IMPORTAZIONE TERMINATA")

        Catch ex As Exception
            Trace.TraceError(ex.Message)
            Throw
        End Try



    End Sub


    Private Sub ImportaFoglioAllegato(ws As IWorksheet, CodCategoria As String, d As DichiarazioneEntity)
        If d.CodCategoria <> CodCategoria Then
            'Throw New Exception("Categoria non corrispondente")
            Trace.TraceWarning(String.Format("Attenzione categoria allegato [{0}] diversa da categoria dichiarazione [{1}]", CodCategoria, d.CodCategoria))
        End If
        Dim idStart As Integer = 6
        Dim idEnd As Integer = 6
        Do While idEnd < 10000
            Dim v As String = CStr(ws(idEnd, 1).Value)
            If v = "" OrElse v.ToLower.StartsWith("indicazioni") Then Exit Do
            idEnd += 1
        Loop
        idEnd -= 1

        Dim all As New AllegatoEntity
        all.Dichiarazione = d
        all.IdAzienda = d.IdAzienda
        all.CategoriaAzienda = CodCategoria
        all.Anno = d.Anno
        all.Periodo = d.Periodo


        Trace.TraceInformation("Individuate " & idEnd - idStart + 1 & " righe")
        For idRow As Integer = idStart To idEnd

            Dim allDett As DettaglioAllegatoEntity = all.Dettaglio.AddNew


            Trace.TraceInformation("Azienda: " & ws(idRow, 1).Value & " - " & ws(idRow, 2).Value)

            Dim azAll As New AziendaAllegatoEntity
            azAll.PartitaIva = ws(idRow, 1).Value
            'If Not DAL.DA.FetchEntityUsingUniqueConstraint(azAll, azAll.ConstructFilterForUCPartitaIva()) Then
            If Not DAL.DA.FetchEntityUsingUniqueConstraint(azAll, New PredicateExpression(AziendaAllegatoFields.PartitaIva = azAll.PartitaIva)) Then
                azAll = New AziendaAllegatoEntity
                azAll.PartitaIva = ws(idRow, 1).Value
                Trace.TraceInformation("    AGGIUNTA")
            Else
                Trace.TraceInformation("    MODIFICATA")
            End If

            Trace.TraceInformation("Verifica match soci")
            Dim az As AziendaEntity = DAL.Managers.SociManager.GetSocioByPiva(azAll.PartitaIva)
            If az Is Nothing Then
                Trace.TraceInformation("   Azienda non associata")
            Else
                Dim Msg As String = "       Azienda associata: " & az.Id & " - " & az.RagioneSociale & " - PI: " & az.PartitaIva
                If az.CodStato = Enums.StatoSocio.USCITO Then
                    Trace.TraceWarning(Msg & " - USCITA")
                Else
                    Trace.TraceInformation(Msg)
                End If
                azAll.IdSocio = az.Id
            End If

            azAll.RagioneSociale = ws(idRow, 2).Value
            azAll.Indirizzo = ws(idRow, 3).Value
            azAll.Localita = ws(idRow, 4).Value
            azAll.Provincia = ws(idRow, 5).Value
            azAll.Cap = ws(idRow, 6).Value


            DAL.DA.SaveEntity(azAll, True)
            allDett.AziendaAllegato = azAll

            If CodCategoria = "B" Then
                allDett.RuoloAziendaAllegato = DAL.Enums.RuoloAziendaAllegato.FORNITORE
                allDett.UnitaMisura = DAL.Enums.UNITA_MISURA.KG
                allDett.Quantita = ws(idRow, 7).Value
                allDett.ContributoApplicato = ws(idRow, 8).Value
            ElseIf CodCategoria = "C" Then
                allDett.RuoloAziendaAllegato = DAL.Enums.RuoloAziendaAllegato.FORNITORE
                allDett.UnitaMisura = DAL.Enums.UNITA_MISURA.TONN
                allDett.Quantita = ws(idRow, 7).Value
                allDett.CodiceCer = ws(idRow, 8).Value
            ElseIf CodCategoria = "E" Then
                azAll.Nazione = ws(idRow, 7).Value
                allDett.RuoloAziendaAllegato = Trim(ws(idRow, 8).Value)
                allDett.UnitaMisura = DAL.Enums.UNITA_MISURA.TONN
                allDett.Quantita = ws(idRow, 9).Value
                allDett.CodiceCer = ws(idRow, 10).Value
            End If
        Next

        Trace.TraceInformation("Salvataggio")
        DA.SaveEntity(all, True)



    End Sub


    Private Sub dlgAcquisisciAllegato_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If _wb IsNot Nothing Then
            _wb.Close()
        End If

        If _xlsApp IsNot Nothing Then
            _xlsApp = Nothing
        End If
    End Sub

    Private Sub tsbAcquisisci_Click(sender As Object, e As EventArgs) Handles tsbAcquisisci.Click
        Try
            _FLog.LogTitle = "Acquisizione file"
            _FLog.ClearLog()
            _FLog.ShowLog()
            ApriFile(ucFile.Text)

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        End Try
        rtfLog.Rtf = _FLog.GetLogRtfText
        _FLog.CloseLog()
    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbAzienda_Click(sender As Object, e As EventArgs) Handles tsbAzienda.Click
        Try
            If AziendaAllegato Is Nothing Then Return
            If OpenAziendaAction IsNot Nothing Then OpenAziendaAction.Invoke(AziendaAllegato)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class