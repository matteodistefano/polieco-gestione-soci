Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports DAL.TypedViewClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ARXWCF = ArxivarWCFWrapper

Public Class FElencoAziendeAllegato
    Private _IsReady As Boolean
    Private _Aziende As VwAziendeAllegatoTypedView
    Private _SelAzienda As AziendaAllegatoEntity
    Private _SelectionMode As Boolean

    Public Function GetAzienda() As AziendaAllegatoEntity
        _SelectionMode = True
        Inizializza()
        Me.ShowDialog()
        Return _SelAzienda
    End Function


    Public Sub Apri()
        Inizializza()
        Me.ShowDialog()
    End Sub

    Private Sub Inizializza()

        'DichiarazioneOnLine.Manager.SetDataAdapter(Generale.DA)
        'DichiarazioneOnLine.Manager.PrenotaDocumentoArxivar = Nothing

        tsbSeleziona.Available = _SelectionMode
        mcTipo.Initialize(New CheckBox() {chkTipoNonSocio, chkTipoSocio})
        mcRuolo.Initialize(New CheckBox() {chkRuoloForn, chkRuoloRic})

        dgvElenco.AutoGenerateColumns = False
        dgvElenco.DataSource = bsData



        ResetFilters()
        _IsReady = True
        CaricaDati()
    End Sub

    Private Sub CaricaDati()
        If Not _IsReady Then Return
        Dim txt As String
        Dim pr As New PredicateExpression

        txt = txtRagioneSociale.Text.Trim
        If txt <> "" Then pr.AddWithAnd(VwAziendeAllegatoFields.RagioneSociale Mod ("%" & txt & "%"))

        txt = txtPartitaIVA.Text.Trim
        If txt <> "" Then pr.AddWithAnd(VwAziendeAllegatoFields.PartitaIva Mod ("%" & txt & "%"))

        txt = txtSede.Text.Trim
        If txt <> "" Then pr.AddWithAnd(VwAziendeAllegatoFields.Localita Mod ("%" & txt & "%") Or VwAziendeAllegatoFields.Indirizzo Mod ("%" & txt & "%") Or VwAziendeAllegatoFields.Nazione Mod ("%" & txt & "%"))

        If mcTipo.HasUnCheck Then
            If chkTipoSocio.Checked Then
                pr.AddWithAnd(New FieldCompareNullPredicate(VwAziendeAllegatoFields.IdSocio, Nothing, True))
            ElseIf chkTipoNonSocio.Checked Then
                pr.AddWithAnd(New FieldCompareNullPredicate(VwAziendeAllegatoFields.IdSocio, Nothing, False))
            End If
        End If

        If mcRuolo.HasUnCheck Then
            If chkRuoloForn.Checked Then pr.AddWithAnd(VwAziendeAllegatoFields.NumFornitore > 0)
            If Me.chkRuoloRic.Checked Then pr.AddWithAnd(VwAziendeAllegatoFields.NumRicevitore > 0)
        End If



        Me._Aziende = New VwAziendeAllegatoTypedView
        DA.FetchTypedView(_Aziende, New RelationPredicateBucket(pr), False)
        bsData.DataSource = Me._Aziende

        Me.Text = "Elenco aziende [ " & _Aziende.Count & "]"

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub ResetFilters()
        _IsReady = False
        txtRagioneSociale.Text = ""
        txtSede.Text = ""
        txtPartitaIVA.Text = ""

        mcTipo.CheckAll()
        mcRuolo.CheckAll()
        _IsReady = True
        CaricaDati()
    End Sub



    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        Me.Close()
    End Sub

    Private Sub tsbNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuova.Click
        Try

            Dim F As New dlgAziendaAllegato
            Dim az As AziendaAllegatoEntity = F.Nuova
            If az IsNot Nothing Then
                Dim id As Integer = az.Id
                CaricaDati()
                dgvElenco.Invalidate()
                bsData.Position = bsData.Find("Id", id)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click
        ApriAzienda()
    End Sub

    Private Sub dgvElenco_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvElenco.DoubleClick
        If _SelectionMode Then
            tsbSeleziona.PerformClick()
        Else
            ApriAzienda()
        End If
    End Sub

    Private Sub ApriAzienda()
        Try

            Dim drw As DataRowView = bsData.Current
            If drw Is Nothing Then Return
            Dim rw As VwAziendeAllegatoRow = drw.Row

            Dim F As New dlgAziendaAllegato
            F.Apri(rw.Id)

            dgvElenco.Invalidate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim drw As DataRowView = bsData.Current
        If drw Is Nothing Then Return
        Dim aa As VwAziendeAllegatoRow = drw.Row
        If MsgBox("Eliminare l'azienda selezionata ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Azienda allegato", Managers.AuditManager.OperazioneEnum.DEL, aa.PartitaIva & " " & aa.RagioneSociale)
            DA.DeleteEntitiesDirectly("AziendaAllegatoEntity", New RelationPredicateBucket(AziendaAllegatoFields.Id = aa.Id))
            Me.bsData.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub btnCerca_Click(sender As Object, e As EventArgs) Handles btnCerca.Click
        CaricaDati()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFilters()
    End Sub

    Private Sub mc_CheckedChanged(sender As Object, e As EventArgs) Handles mcTipo.CheckedChanged, mcRuolo.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub dgvElenco_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvElenco.CellFormatting
        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim drw As DataRowView = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If drw Is Nothing Then Return
        Dim rw As VwAziendeAllegatoRow = drw.Row
        If col Is dgvcFornitore Then
            e.Value = IIf(rw.NumFornitore > 0, chkRuoloForn.Image, mdsUtility.GraphicsHelper.EmptyImage)
        ElseIf col Is dgvcRicevitore Then
            e.Value = IIf(rw.NumRicevitore > 0, chkRuoloRic.Image, mdsUtility.GraphicsHelper.EmptyImage)
        ElseIf col Is dgvcTipo Then
            e.Value = IIf(rw.IdSocio <> 0, chkTipoSocio.Image, chkTipoNonSocio.Image)
        End If
    End Sub

    Private Sub cmGrid_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmGrid.Opening

        Dim drw As DataRowView = bsData.Current
        If drw Is Nothing Then Return
        Dim aa As VwAziendeAllegatoRow = drw.Row
        If aa Is Nothing Then
            e.Cancel = True
            Return
        End If
        tsmiAzienda.Enabled = aa.IdSocio <> 0
    End Sub

    Private Sub tsmiAzienda_Click(sender As Object, e As EventArgs) Handles tsmiAzienda.Click
        Try
            Dim drw As DataRowView = bsData.Current
            If drw Is Nothing Then Return
            Dim aa As VwAziendeAllegatoRow = drw.Row
            Dim F As New FAzienda
            F.Apri(aa.IdSocio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FElencoAziendeAllegato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            CaricaDati()
        End If
    End Sub

    Private Sub tsbSeleziona_Click(sender As Object, e As EventArgs) Handles tsbSeleziona.Click
        Dim drw As DataRowView = bsData.Current
        If drw Is Nothing Then Return
        Dim aa As VwAziendeAllegatoRow = drw.Row
        _SelAzienda = New AziendaAllegatoEntity(aa.Id)
        DA.FetchEntity(_SelAzienda)
        Me.Close()
    End Sub
End Class