Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ARXWCF = ArxivarWCFWrapper
Imports mdsUtility.TypeExtension

Public Class FElencoDOL
    Private _PP As PrefetchPath2
    Private _DOL As EntityCollection(Of DichiarazioneOnLineEntity)
    Private _IsReady As Boolean

    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()

        'DichiarazioneOnLine.Manager.SetDataAdapter(Generale.DA)
        DichiarazioneOnLine.Manager.RicercaAzienda = _
            Function(x)
                Dim sel() As TypedViewClasses.VwRicercaAziendeRow = FElencoSoci.GetSoci()
                If sel Is Nothing OrElse sel.Count = 0 Then Return Nothing
                Dim Az As New AziendaEntity()
                Az.Id = sel(0).Id
                DA.FetchEntity(Az)
                Return Az
            End Function

        DichiarazioneOnLine.Manager.ApriAzienda = _
                Sub(x)
                    Dim F As New FAzienda
                    F.Apri(x)
                End Sub

        DichiarazioneOnLine.Manager.ApriDichiarazione = _
            Sub(IdDic As Integer)
                Dim F As New FDichiarazione
                F.Apri(IdDic)
            End Sub

        If Not Generale.UserConfig.DisableArxivarIntegration Then

            DichiarazioneOnLine.Manager.PrenotaDocumentoArxivar =
            Sub(dol As DichiarazioneOnLineEntity)
                Dim IdDoc As Integer
                Dim BarCode As String = dol.Protocollo
                Dim pp As New Dictionary(Of String, Object)
                pp.Add("#-COMPETENZA_DICHIARAZIONE", dol.Dichiarazione.GetCompetenzaDescription)


                IdDoc = ARXWCF.Profiling.ProfileWithIdProfile(CommonConfig.ArxivarIdProfiloDichiarazione _
                                                    , CommonConfig.ArxivarIdRubricaSoci & "," & CommonConfig.PrefissoCodiceRubrica & dol.IdAzienda _
                                                    , CommonConfig.ContattoPredefinito _
                                                    , "DICHIARAZIONE PERIODICA " & dol.Anno & "-" & dol.Periodo _
                                                    , dol.DataRicevimento _
                                                    , ARXWCF.ProfilemodeEnum.BARCODE _
                                                    , BarCode _
                                                    , False _
                                                    , pp)
                dol.Dichiarazione.RifArxivar = IdDoc

            End Sub
        Else
            DichiarazioneOnLine.Manager.PrenotaDocumentoArxivar = Nothing
        End If
        'DichiarazioneOnLine.Manager.PrenotaDocumentoArxivar = Nothing

        mcStato.Initialize(New CheckBox() {chkStatoINS, chkStatoVAL, chkStatoASS, chkStatoANN})

        Dim aa(10) As Integer
        Dim a1 As Integer = Date.Today.Year
        For i As Integer = 0 To 10
            aa(i) = a1 + 1 - i
        Next
        ccAnno.SetData(aa, "", "")
        ccAnno.SelectedIndex = -1
        _DOL = New EntityCollection(Of DichiarazioneOnLineEntity)
        ResetFilters()
        '_IsReady = True
        'CaricaDati()
    End Sub

    Private Sub CaricaDati()
        If Not _IsReady Then Return

        Dim txt As String
        Dim pr As New PredicateExpression

        txt = txtProtocollo.Text.Trim
        If txt <> "" Then
            pr.AddWithAnd(DichiarazioneOnLineFields.Protocollo Mod ("%" & txt & "%"))
        End If

        txt = txtPeriodo.Text.Trim
        If txt <> "" Then
            pr.AddWithAnd(DichiarazioneOnLineFields.Periodo Mod ("%" & txt & "%"))
        End If

        If ccAnno.Checked AndAlso Val(ccAnno.ComboText) <> 0 Then
            pr.AddWithAnd(DichiarazioneOnLineFields.Anno = Val(ccAnno.ComboText))
        End If

        txt = txtRagioneSociale.Text.Trim
        If txt <> "" Then

            Dim fpi As FieldPersistenceInfo = DA.GetDAFieldPersistenceInfo(DichiarazioneOnLineFields.Dati)
            Dim Fld As New EntityField("RagioneSociale", New mdsLLBLGenUtility.Expressions.XPathExpression(DichiarazioneOnLineFields.Dati, fpi, "(//Dichiarazione/RagioneSociale)[1]", "varchar(200)"))
            pr.AddWithAnd(Fld Mod ("%" & txt & "%"))
        End If

        txt = txtSedeLegale.Text.Trim
        If txt <> "" Then
            Dim fpi As FieldPersistenceInfo = DA.GetDAFieldPersistenceInfo(DichiarazioneOnLineFields.Dati)
            Dim Fld As New EntityField("SedeLegale", New mdsLLBLGenUtility.Expressions.XPathExpression(DichiarazioneOnLineFields.Dati, fpi, "(//Dichiarazione/SedeLegale)[1]", "varchar(200)"))
            pr.AddWithAnd(Fld Mod ("%" & txt & "%"))
        End If

        txt = txtPartitaIVA.Text.Trim
        If txt <> "" Then
            Dim fpi As FieldPersistenceInfo = DA.GetDAFieldPersistenceInfo(DichiarazioneOnLineFields.Dati)
            Dim Fld As New EntityField("PartitaIVA", New mdsLLBLGenUtility.Expressions.XPathExpression(DichiarazioneOnLineFields.Dati, fpi, "(//Dichiarazione/PartitaIVA)[1]", "varchar(200)"))
            pr.AddWithAnd(Fld Mod ("%" & txt & "%"))
        End If

        If mcStato.HasUnCheck Then
            Dim prSt As New PredicateExpression
            Dim cc() As CheckBox = mcStato.GetAllChecked()
            For Each c In cc
                prSt.AddWithOr(DichiarazioneOnLineFields.Stato = c.Name.Replace("chkStato", ""))
            Next
            pr.AddWithAnd(prSt)
        End If

        Cursor.Current = Cursors.WaitCursor

        _DOL.Clear()
        DA.FetchEntityCollection(_DOL, New RelationPredicateBucket(pr))
        Me.bsData.DataSource = _DOL

        Me.Text = "Elenco dichiarazioni compilate on-line [ " & _DOL.Count & " documenti ]"

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub ResetFilters()
        _IsReady = False

        txtProtocollo.Text = ""
        txtPeriodo.Text = ""
        ccAnno.Checked = False

        txtRagioneSociale.Text = ""
        txtSedeLegale.Text = ""
        txtPartitaIVA.Text = ""

        mcStato.CheckAll()
        chkStatoASS.Checked = False
        chkStatoANN.Checked = False
        _IsReady = True
        CaricaDati()
    End Sub

        

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    Private Sub tsbNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuova.Click
        Try

            DichiarazioneOnLine.Manager.Open()
            CaricaDati()
            dgvElenco.Invalidate()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriDOL()
    End Sub

    Private Sub ApriDOL()
        Try
            If Me.bsData.Current Is Nothing Then Return
            Dim dol As DichiarazioneOnLineEntity = bsData.Current
            DichiarazioneOnLine.Manager.Open(dol)
            CaricaDati()
            bsData.Position = bsData.IndexOf(dol)
            dgvElenco.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim dol As DichiarazioneOnLineEntity = bsData.Current
        If dol Is Nothing Then Return
        If MsgBox("Eliminare la dichiarazione selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Dichiarazione ON LINE", Managers.AuditManager.OperazioneEnum.DEL, dol.Protocollo)
            DA.DeleteEntity(dol)
            Me.bsData.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccCategoria_SelectionChanged(sender As Object, e As EventArgs) Handles ccAnno.SelectionChanged
        CaricaDati()
    End Sub

    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        CaricaDati()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFilters()
    End Sub

    Private Sub mcStato_CheckedChanged(sender As Object, e As EventArgs) Handles mcStato.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub dgvElenco_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvElenco.CellFormatting
        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DichiarazioneOnLineEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcStato Then
            If e.Value = Enums.StatoDOL.ANNULLATA Then
                e.Value = chkStatoANN.Image
            ElseIf e.Value = Enums.StatoDOL.ASSOCIATA Then
                e.Value = chkStatoASS.Image
            ElseIf e.Value = Enums.StatoDOL.INSERITA Then
                e.Value = chkStatoINS.Image
            ElseIf e.Value = Enums.StatoDOL.VALIDATA Then
                e.Value = chkStatoVAL.Image
            Else
                e.Value = mdsUtility.GraphicsHelper.EmptyImage
            End If
        ElseIf col Is dgvcEsito Then
            If rw.Stato = Enums.StatoDOL.ASSOCIATA Then
                e.CellStyle.ForeColor = Color.Green
                e.CellStyle.SelectionForeColor = Color.LightSeaGreen
            Else
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.LightSalmon
            End If
        End If
    End Sub

    Private Sub tsbLoadFolder_Click(sender As Object, e As EventArgs) Handles tsbLoadFolder.Click
        Try
            Dim fld As New FolderBrowserDialog
            fld.SelectedPath = UserConfig.CartellaFileDichiarazioni
            fld.Description = "Cartella contenente le dichiarazioni (file .dicpoli)"
            If fld.ShowDialog = Windows.Forms.DialogResult.Cancel Then Return
            UserConfig.CartellaFileDichiarazioni = fld.SelectedPath

            Dim Path As String = fld.SelectedPath


            Dim ff() As String = System.IO.Directory.GetFiles(Path, "*.dicpoli")
            If ff.Count = 0 Then Throw New Exception("Nessun file dichiarazione trovato nella cartella")

            If MsgBox("Procedere con l'acquisizione di " & ff.Count & " dichiarazioni ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            LogView.LogTitle = "Acquisizione dichiarazioni"
            LogView.ClearLog()
            LogView.ShowLog()
            LogView.InitProgress(ff.Count, 10)
            LogView.ShowProgress()
            Trace.TraceInformation("Inizio acquisizione di " & ff.Count & " dichiarazioni")
            For Each f In ff
                Try
                    LogView.IncrementProgress()
                    DichiarazioneOnLine.Manager.ImportaFile(f)
                    Trace.TraceInformation(System.IO.Path.GetFileName(f) & " correttamente importato")

                Catch ex As Exception
                    Trace.TraceError("File " & System.IO.Path.GetFileName(f) & ":" & ex.Message)
                End Try
            Next
            Trace.TraceInformation("Acquisizione terminata")
            LogView.HideProgress()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbAnalizza_Click(sender As Object, e As EventArgs) Handles tsbAnalizza.Click
        Try
            
            Dim rr() As DichiarazioneOnLineEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DichiarazioneOnLineEntity)(dgvElenco, False)
            If rr Is Nothing OrElse rr.Count = 0 Then Return

            
            If MsgBox("Procedere con l'analisi di " & rr.Count & " dichiarazioni ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            LogView.LogTitle = "Analisi e associazione dichiarazioni"
            LogView.ClearLog()
            LogView.ShowLog()
            LogView.InitProgress(rr.Count, 10)
            LogView.ShowProgress()
            Trace.TraceInformation("Inizio acquisizione di " & rr.Count & " dichiarazioni")
            For Each r In rr
                Try
                    r.EsitoAnalisi = ""
                    LogView.IncrementProgress()
                    DichiarazioneOnLine.Manager.Analizza(r)
                    Trace.TraceInformation(r.Protocollo & " correttamente importato")
                    r.EsitoAnalisi = "Importata"
                Catch ex As Exception
                    r.EsitoAnalisi = ex.Message
                    Trace.TraceError(r.Protocollo & ":" & ex.Message)
                End Try
                DA.SaveEntity(r, True)
            Next

            Trace.TraceInformation("Analisi terminata")
            LogView.HideProgress()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub cmGrid_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmGrid.Opening
        Dim dol As DichiarazioneOnLineEntity = bsData.Current
        If dol Is Nothing Then
            e.Cancel = True
            Return
        End If
        tsmiAzienda.Enabled = dol.HasAzienda
        tsmiDichiarazione.Enabled = dol.HasDichiarazione
        If dol.HasDichiarazione Then
            tsmiDichiarazione.Enabled = True
            tsmiDocumento.Text = "Apri documento"
        ElseIf dol.Stato = Enums.StatoDOL.VALIDATA AndAlso dol.EsitoAnalisi.StartsWith("Competenza già profilata con Id:") Then
            tsmiDocumento.Text = "Apri documento in conflitto"
            tsmiDocumento.Enabled = True
        Else
            tsmiDocumento.Text = "Apri documento"
            tsmiDocumento.Enabled = False
        End If
    End Sub

    Private Sub tsmiAzienda_Click(sender As Object, e As EventArgs) Handles tsmiAzienda.Click
        Try
            Dim dol As DichiarazioneOnLineEntity = bsData.Current
            If dol Is Nothing Then Return
            Dim F As New FAzienda
            F.Apri(dol.IdAzienda)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiDichiarazione_Click(sender As Object, e As EventArgs) Handles tsmiDichiarazione.Click
        Try
            Dim dol As DichiarazioneOnLineEntity = bsData.Current
            If dol Is Nothing Then Return
            Dim F As New FDichiarazione
            F.Apri(dol.IdDichiarazione)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiDocumento_Click(sender As Object, e As EventArgs) Handles tsmiDocumento.Click
        Try
            Dim dol As DichiarazioneOnLineEntity = bsData.Current
            If dol Is Nothing Then Return
            If dol.HasDichiarazione Then
                Dim d As New DichiarazioneEntity(dol.IdDichiarazione)
                DA.FetchEntity(d)
                ArxivarWCFWrapper.Common.OpenDocumentById(d.RifArxivar)
            ElseIf dol.Stato = Enums.StatoDOL.VALIDATA AndAlso dol.EsitoAnalisi.StartsWith("Competenza già profilata con Id:") Then
                Dim p As Integer = dol.EsitoAnalisi.LastIndexOf(":")
                Dim Id As Integer = Val(dol.EsitoAnalisi.Substring(p + 1))
                ArxivarWCFWrapper.Common.OpenDocumentById(Id)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiAnnulla_Click(sender As Object, e As EventArgs) Handles tsmiAnnulla.Click
        Try
            Dim sel() As DichiarazioneOnLineEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DichiarazioneOnLineEntity)(dgvElenco, False)
            If sel Is Nothing OrElse sel.Count = 0 Then Return
            If MsgBox("Annullare le dichiarazoni selezionate ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
            For Each s In sel
                If s.Stato <> Enums.StatoDOL.ASSOCIATA Then
                    DichiarazioneOnLine.Manager.Annulla(s)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Function GetReportFilter() As String
        Dim ret As String = "1=1 "
        Dim txt As String
        txt = txtProtocollo.Text.ToSqlSafe()
        If txt <> "" Then
            ret &= $" and {{Comando.Protocollo}} like '*{txt}*' "
        End If

        txt = txtPeriodo.Text.ToSqlSafe
        If txt <> "" Then
            ret &= $" and {{Comando.Periodo}} like '*{txt}*' "
        End If

        If ccAnno.Checked AndAlso Val(ccAnno.ComboText) <> 0 Then
            ret &= $" and {{Comando.Anno}} = '{ccAnno.ComboText}' "
        End If

        txt = txtRagioneSociale.Text.ToSqlSafe
        If txt <> "" Then
            ret &= $" and {{Comando.RagioneSociale}} like '*{txt}*' "
        End If

        txt = txtSedeLegale.Text.ToSqlSafe
        If txt <> "" Then
            ret &= $" and {{Comando.Sede}} like '*{txt}*' "
        End If

        txt = txtPartitaIVA.Text.ToSqlSafe
        If txt <> "" Then
            ret &= $" and {{Comando.PartitaIVA}} like '*{txt}*' "
        End If

        If mcStato.HasUnCheck Then
            Dim prSt As New PredicateExpression
            Dim cc() As CheckBox = mcStato.GetAllChecked()
            ret &= " and {Comando.Stato} in ["

            For i As Integer = 0 To cc.Count - 1
                Dim c As CheckBox = cc(i)
                ret &= "'" & c.Name.Replace("chkStato", "") & "'"
                If i < cc.Count - 1 Then ret &= ","
            Next
            ret &= "]"
        End If

        Return ret
    End Function


    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try
            Dim F As New mdsReport.FReport
            Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\elenco-dol.rpt")

            'Rpt.SetParameterValue("@DataAssemblea", "xxxx")
            Rpt.RecordSelectionFormula = GetReportFilter()

            F.ApplyLogonData(Rpt, DA.ConnectionString)
            F.Apri(Rpt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class