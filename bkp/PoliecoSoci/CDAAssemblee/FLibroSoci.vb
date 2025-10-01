Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports DAL.TypedViewClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FLibroSoci
    Private _Soci As DataTable
    Private _IsReady As Boolean

    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub



    Private Sub Inizializza()

        '_PP = New PrefetchPath2(CInt(EntityType.RiunioneEntity))
        '_PP.Add(UtenteEntity.PrefetchPathRuoli)
        Dim Sql As String = String.Format("Select Id,Data from Riunione Where Tipo='{0}' Order By Data Desc", Enums.TipoRiunione.ASSEMBLEA)
        Dim tb As DataTable = DAL.DatabaseSpecific.Generale.SSHelp.GetDbTable(Sql)
        cbAssemblea.DataSource = tb
        cbAssemblea.DisplayMember = "Data"
        cbAssemblea.ValueMember = "Data"
        If cbAssemblea.Items.Count > 0 Then cbAssemblea.SelectedIndex = 0
        _IsReady = True
        CaricaDati()
    End Sub

    Private Sub CaricaDati()
        If Not _IsReady Then Return
        Try
            Cursor = Cursors.WaitCursor

            If Not IsDate(cbAssemblea.SelectedValue) Then Throw New Exception("Data non valida")
            Dim Nm As Integer = Val(txtNumero.Text)
            If Nm = 0 Then Nm = 1

            _Soci = DAL.DatabaseSpecific.RetrievalProcedures.GetLibroSoci(cbAssemblea.SelectedValue, DA)
            _Soci.Columns.Add("Numero")
            _Soci.Columns.Add("DescrIndirizzo", GetType(String), "Indirizzo+'" & vbCrLf & "'+Cap+' '+Localita+' '+Provincia")

            For Each rw In _Soci.Rows
                If rw("Motivo").ToString.StartsWith("NUOVO") Then
                    rw("Numero") = Nm
                    Nm += 1
                Else
                    rw("Numero") = DBNull.Value
                End If
            Next
            Me.bsElenco.DataSource = _Soci
            lTot.Text = bsElenco.Count
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    Private Sub dgvElenco_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvElenco.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As DataRowView = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcMotivo Then
            Dim V As String = e.Value
            Dim C As Color
            If V = Enums.MotivoLibroSoci.NUOVO Then
                C = Color.FromArgb(192, 250, 192)
            ElseIf V = Enums.MotivoLibroSoci.NUOVO_CRS Then
                C = Color.FromArgb(160, 250, 160)
            ElseIf V = Enums.MotivoLibroSoci.USCITA Then
                C = Color.FromArgb(250, 192, 192)
            Else
                C = Color.FromArgb(250, 160, 160)
            End If
            e.CellStyle.BackColor = C
            e.CellStyle.SelectionBackColor = mdsUtility.GraphicsHelper.ReduceColorBrightness(C, 0.5)
        End If
    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriSocio()
    End Sub

    Private Sub ApriSocio()
        If Me.bsElenco.Current Is Nothing Then Return
        Try
            Dim F As New FAzienda
            F.Apri(Me.bsElenco.Current("Id"))
            CaricaDati()
            dgvElenco.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub FElencoRiunioni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub dgvElenco_SelectionChanged(sender As Object, e As EventArgs) Handles dgvElenco.SelectionChanged
        Dim N As Integer
        If dgvElenco.SelectedRows Is Nothing Then
            N = 0
        Else
            N = dgvElenco.SelectedRows.Count
        End If
        lSel.Text = N
    End Sub

    Private Sub tsbSelAll_Click(sender As Object, e As EventArgs) Handles tsbSelAll.Click
        dgvElenco.SelectAll()
    End Sub

    'Private Sub tsbAction_Click(sender As Object, e As EventArgs) Handles tsbAction.Click
    '    Try
    '        Dim rwSel()
    '        If _TipoPassaggio = TipoPassaggioEnum.CDA Then
    '            rwSel = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of VwPassaggioCdaRow)(dgvElenco, False)
    '        Else
    '            rwSel = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of VwPassaggioAssembleaRow)(dgvElenco, False)
    '        End If


    '        If rwSel Is Nothing OrElse rwSel.Count = 0 Then Return
    '        If rwSel.Count = 1 Then
    '            If MsgBox("Attenzione !!! E' stato selezionato un solo socio." & vbCr _
    '                          & "Si intendeva selezionarli tutti ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

    '                tsbSelAll.PerformClick()
    '                tsbAction.PerformClick()
    '                Return
    '            End If
    '        End If

    '        Dim CodTipo As String
    '        Dim NomePlurale As String
    '        Dim NomeSingolare As String
    '        Dim Campo As String
    '        If Me.TipoPassaggio = TipoPassaggioEnum.CDA Then
    '            CodTipo = Enums.TipoRiunione.CDA
    '            NomePlurale = "CDA"
    '            NomeSingolare = "il CDA"
    '            Campo = "DataPassaggioCDA"
    '        ElseIf Me.TipoPassaggio = TipoPassaggioEnum.ASSEMBLEA Then
    '            CodTipo = Enums.TipoRiunione.ASSEMBLEA
    '            NomePlurale = "Assemblee"
    '            NomeSingolare = "l'assemblea"
    '            Campo = "DataAssemblea"
    '        End If


    '        Dim F As New mdsUIControls.FSelTabella
    '        F.HideFilterBox = True
    '        F.Width = 300

    '        Dim Sql As String = String.Format("Select Id,Data from Riunione Where Tipo='{0}' Order By Data Desc", CodTipo)
    '        Dim tb As DataTable = DAL.DatabaseSpecific.Generale.SSHelp.GetDbTable(Sql)
    '        Dim rwData As DataRow = F.GetSelectedRow("Elenco " & NomePlurale, tb, "Data")
    '        If rwData Is Nothing Then Return
    '        Dim Msg As String = String.Format("Assegnare {0} del {1:d} ai soci selezionati ({2}) ?", NomeSingolare, rwData("Data"), rwSel.Count)
    '        If MsgBox(Msg, MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

    '        Dim Dt As Date = CDate(rwData("Data"))
    '        'Dim IdAziende() As Integer = (From r In rwSel Select CInt(r("Id"))).ToArray
    '        If _TipoPassaggio = TipoPassaggioEnum.CDA Then
    '            DAL.Managers.SociManager.SetDataCDA(Dt, rwSel)
    '        Else
    '            DAL.Managers.SociManager.SetDataAssemblea(Dt, rwSel)
    '        End If



    '        MsgBox("Operazione correttamente effettuata", MsgBoxStyle.Information)
    '        CaricaDati()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            'Dim rwSel() As DataRow = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DataRow)(dgvElenco, True)
            'If rwSel Is Nothing OrElse rwSel.Count = 0 Then Return

            'Dim ds As New mdsReport.dsReports
            'For Each rw In rwSel
            '    ds.SELECTED_ID.AddSELECTED_IDRow(rw("Id"), "", "", "", 0, 0, 0, 0, 0, 0)
            'Next


            Dim F As New mdsReport.FReport

            Dim rptName As String = "librosoci.rpt"
            Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\" & rptName)
            Rpt.SetParameterValue("@DataAssemblea", CDate(cbAssemblea.SelectedValue))
            Dim NN As Integer = Val(txtNumero.Text)
            If NN = 0 Then NN = 1
            Rpt.SetParameterValue("NumeroIniziale", NN)
            Rpt.SetParameterValue("MargineSuperiore", UserConfig.MargineSuperioreReports)

            F.ApplyLogonData(Rpt, Generale.ConnectionString)
            F.Apri(Rpt)
            'AddHandler Rpt.RefreshReport, Sub(x, y) UserConfig.MargineSuperioreReports = CType(x, CrystalDecisions.CrystalReports.Engine.ReportDocument).ParameterFields("MargineSuperiore").CurrentValues(0).ToString
            UserConfig.MargineSuperioreReports = CType(Rpt.ParameterFields("MargineSuperiore").CurrentValues(0), CrystalDecisions.Shared.ParameterDiscreteValue).Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        CaricaDati()
    End Sub

End Class