Option Strict Off
Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports DAL.TypedViewClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FPassaggioAssociati
    Private _Soci As DataTable
    Private _IsReady As Boolean

    Public Sub Apri(Tipo As TipoPassaggioEnum)
        Me.TipoPassaggio = Tipo
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Enum TipoPassaggioEnum
        ASSEMBLEA
        CDA
    End Enum

    Public Enum TipoEnum
        DA_PASSARE = 0
        PASSATE = 1
    End Enum

    Private _TipoPassaggio As TipoPassaggioEnum
    Public Property TipoPassaggio() As TipoPassaggioEnum
        Get
            Return _TipoPassaggio
        End Get
        Set(value As TipoPassaggioEnum)
            _TipoPassaggio = value
            Dim descr As String = IIf(value = TipoPassaggioEnum.CDA, "CDA", "Assemblea")
            Me.Text = "Passaggio associati a " & descr
            tsbAction.Text = "Imposta data " & descr
            lDescrTipo.Text = descr & " del "
            dgvcDataCDA.Visible = (_TipoPassaggio = TipoPassaggioEnum.ASSEMBLEA)
        End Set
    End Property

    Private _Tipo As TipoEnum
    Private Property Tipo As TipoEnum
        Get
            Return _Tipo
        End Get
        Set(value As TipoEnum)
            _Tipo = value
            cbTipo.SelectedIndex = value
            If value = TipoEnum.DA_PASSARE Then
                ccMotivo.Visible = True
                pnlTipo.Visible = False
                tsbAction.Enabled = True
            Else
                ccMotivo.Visible = False
                pnlTipo.Visible = True
                tsbAction.Enabled = False
            End If
        End Set
    End Property
    
    Private Sub Inizializza()
        '_PP = New PrefetchPath2(CInt(EntityType.RiunioneEntity))
        '_PP.Add(UtenteEntity.PrefetchPathRuoli)
        Tipo = TipoEnum.DA_PASSARE
        ccMotivo.SetData(Lookups.MotiviPassaggio, "Descrizione", "Codice")
        _Soci = New VwPassaggioCdaTypedView

        pnlTipo.Location = ccMotivo.Location


        Dim Riunioni As New EntityCollection(Of RiunioneEntity)
        Dim rpb As New RelationPredicateBucket(New PredicateExpression(RiunioneFields.Tipo = IIf(TipoPassaggio = TipoPassaggioEnum.ASSEMBLEA, Enums.TipoRiunione.ASSEMBLEA, Enums.TipoRiunione.CDA)))
        DA.FetchEntityCollection(Riunioni, rpb, 0, New SortExpression(RiunioneFields.Data Or SortOperator.Descending))

        cbRiunioni.DataSource = Riunioni
        cbRiunioni.DisplayMember = "Data"
        cbRiunioni.ValueMember = "Data"
        cbRiunioni.SelectedIndex = 0
        _IsReady = True
        CaricaDati()
    End Sub

    Private Sub CaricaDati()
        If Not _IsReady Then Return

        Try

            _Soci.Clear()
            If Tipo = TipoEnum.PASSATE Then Throw New Exception("Non supportato")

            Cursor = Cursors.WaitCursor
            Dim pr As New PredicateExpression
            Dim FldMotivo As EntityField2
            Dim srt As SortExpression

            If Me.TipoPassaggio = TipoPassaggioEnum.CDA Then
                _Soci = New VwPassaggioCdaTypedView
                FldMotivo = VwPassaggioCdaFields.Motivo
                srt = New SortExpression(VwPassaggioCdaFields.Motivo Or SortOperator.Ascending)
                srt.Add(VwPassaggioCdaFields.RagioneSociale Or SortOperator.Ascending)
            ElseIf Me.TipoPassaggio = TipoPassaggioEnum.ASSEMBLEA Then
                _Soci = New VwPassaggioAssembleaTypedView
                FldMotivo = VwPassaggioAssembleaFields.Motivo
                srt = New SortExpression(VwPassaggioAssembleaFields.Motivo Or SortOperator.Ascending)
                srt.Add(VwPassaggioAssembleaFields.RagioneSociale Or SortOperator.Ascending)
            End If


            If ccMotivo.Checked Then
                pr.AddWithAnd(FldMotivo = ccMotivo.SelectedValue)
            End If

            Generale.DA.FetchTypedView(_Soci, New RelationPredicateBucket(pr), 0, srt, False)
            Me.bsElenco.DataSource = _Soci

            lTot.Text = bsElenco.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
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
            If V = Enums.MotivoPassaggio.NUOVO Then
                C = Color.FromArgb(192, 250, 192)
            ElseIf V = Enums.MotivoPassaggio.USCITA Then
                C = Color.FromArgb(250, 192, 192)
            Else
                C = Color.FromArgb(192, 192, 250)
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

    Private Sub ccMotivo_SelectionChanged(sender As Object, e As EventArgs) Handles ccMotivo.SelectionChanged
        CaricaDati()
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

    Private Sub tsbAction_Click(sender As Object, e As EventArgs) Handles tsbAction.Click
        Try
            Dim rwSel()
            If _TipoPassaggio = TipoPassaggioEnum.CDA Then
                rwSel = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of VwPassaggioCdaRow)(dgvElenco, False)
            Else
                rwSel = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of VwPassaggioAssembleaRow)(dgvElenco, False)
            End If


            If rwSel Is Nothing OrElse rwSel.Count = 0 Then Return
            If rwSel.Count = 1 Then
                If MsgBox("Attenzione !!! E' stato selezionato un solo socio." & vbCr _
                              & "Si intendeva selezionarli tutti ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    tsbSelAll.PerformClick()
                    tsbAction.PerformClick()
                    Return
                End If
            End If

            Dim CodTipo As String
            Dim NomePlurale As String
            Dim NomeSingolare As String
            Dim Campo As String
            If Me.TipoPassaggio = TipoPassaggioEnum.CDA Then
                CodTipo = Enums.TipoRiunione.CDA
                NomePlurale = "CDA"
                NomeSingolare = "il CDA"
                Campo = "DataPassaggioCDA"
            ElseIf Me.TipoPassaggio = TipoPassaggioEnum.ASSEMBLEA Then
                CodTipo = Enums.TipoRiunione.ASSEMBLEA
                NomePlurale = "Assemblee"
                NomeSingolare = "l'assemblea"
                Campo = "DataAssemblea"
            End If


            Dim F As New mdsUIControls.FSelTabella
            F.HideFilterBox = True
            F.Width = 300

            Dim Sql As String = String.Format("Select Id,Data from Riunione Where Tipo='{0}' Order By Data Desc", CodTipo)
            Dim tb As DataTable = DAL.DatabaseSpecific.Generale.SSHelp.GetDbTable(Sql)
            Dim rwData As DataRow = F.GetSelectedRow("Elenco " & NomePlurale, tb, "Data")
            If rwData Is Nothing Then Return
            Dim Msg As String = String.Format("Assegnare {0} del {1:d} ai soci selezionati ({2}) ?", NomeSingolare, rwData("Data"), rwSel.Count)
            If MsgBox(Msg, MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            Dim Dt As Date = CDate(rwData("Data"))
            'Dim IdAziende() As Integer = (From r In rwSel Select CInt(r("Id"))).ToArray
            If _TipoPassaggio = TipoPassaggioEnum.CDA Then
                DAL.Managers.SociManager.SetDataCDA(Dt, rwSel)
            Else
                DAL.Managers.SociManager.SetDataAssemblea(Dt, rwSel)
            End If



            MsgBox("Operazione correttamente effettuata", MsgBoxStyle.Information)
            CaricaDati()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbStampa_Click(sender As Object, e As EventArgs) Handles tsbStampa.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim rwSel() As DataRow = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of DataRow)(dgvElenco, True)
            If rwSel Is Nothing OrElse rwSel.Count = 0 Then Return

            Dim ds As New mdsReport.dsReports
            For i As Integer = 0 To rwSel.Count - 1
                Dim rw As DataRow = rwSel(i)
                ds.SELECTED_ID.AddSELECTED_IDRow(i, "", "", "", rw("ID"), 0, 0, 0, 0, 0)
            Next


            Dim F As New mdsReport.FReport

            Dim rptName As String
            If _TipoPassaggio = TipoPassaggioEnum.CDA Then
                rptName = "elencocda.rpt"
            Else
                rptName = "elencoassemblea.rpt"
            End If

            Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = F.GetReport(My.Application.Info.DirectoryPath & "\stampe\" & rptName)
            F.ApplyLogonData(Rpt, Generale.ConnectionString, ds)
            F.Apri(Rpt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Tipo = cbTipo.SelectedIndex
        CaricaDati()
    End Sub

    Private Sub cbRiunioni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRiunioni.SelectedIndexChanged
        CaricaDati()
    End Sub
End Class