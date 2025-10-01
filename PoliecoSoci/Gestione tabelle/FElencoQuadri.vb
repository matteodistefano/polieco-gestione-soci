Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FElencoQuadri
    Private _Quadri As EntityView2(Of QuadroEntity)
    Private _SelQuadri() As QuadroEntity
    Private _QuadriContext As New Context
    Private _CanEdit As Boolean

    Public Sub Apri()
        tsbSelect.Available = False
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function GetQuadri() As IEnumerable(Of QuadroEntity)
        tsbSelect.Available = True
        Inizializza()
        Me.ShowDialog()
        Return _SelQuadri
    End Function

    Private Sub Inizializza()
        ccTipo.SetData(Lookups.TipiQuadro, "Descrizione", "Codice")
        _Quadri = Lookups.Quadri.CreateView
        _QuadriContext.Add(_Quadri.RelatedCollection)
        CaricaDati()
        InitUISecurity()
    End Sub


    Private Sub InitUISecurity()
        _CanEdit = DAL.Managers.UtentiManager.IsLoggedUserInRole(Enums.Ruolo.DIREZIONE)
        tsbNuovo.Available = _CanEdit
        tsbModifica.Available = _CanEdit
        tsbElimina.Available = _CanEdit
    End Sub

    Private Sub CaricaDati()
        If _Quadri Is Nothing Then Return

        Dim pr As New PredicateExpression
        If ccTipo.Checked Then
            pr.AddWithAnd(QuadroFields.CodTipo = ccTipo.SelectedValue)
        End If

        If chkAttivi.Checked Then
            pr.AddWithAnd(QuadroFields.Utilizzato = True)
        End If

        _Quadri.Filter = pr
        Me.bsQuadri.DataSource = _Quadri
    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        _SelQuadri = Nothing
        Me.Close()
    End Sub

    Private Sub tsbNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuovo.Click
        Dim Q As New QuadroEntity
        Q.Utilizzato = True
        Dim F As New dlgQuadro
        If F.Apri(Q) Then
            Me._Quadri.RelatedCollection.Add(Q)
            CaricaDati()
            bsQuadri.Position = bsQuadri.IndexOf(Q)
        End If
    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriQuadro()
    End Sub

    Private Sub ApriQuadro()
        If Not _CanEdit Then Return
        If Me.bsQuadri.Current Is Nothing Then Return
        Dim F As New dlgQuadro
        F.Apri(Me.bsQuadri.Current)
        CaricaDati()
        dgvElenco.Invalidate()
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim Q As QuadroEntity = bsQuadri.Current
        If Q Is Nothing Then Return
        If MsgBox("Eliminare il quadro selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Quadro", Managers.AuditManager.OperazioneEnum.DEL, Q.Codice)
            DA.DeleteEntity(Q)
            Me.bsQuadri.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccTipo_SelectionChanged(sender As Object, e As EventArgs) Handles ccTipo.SelectionChanged
        CaricaDati()
    End Sub

    Private Sub tsbSelect_Click(sender As Object, e As EventArgs) Handles tsbSelect.Click
        Dim ss() As QuadroEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of QuadroEntity)(dgvElenco, False)
        If ss Is Nothing OrElse ss.Length = 0 Then Return
        _SelQuadri = ss
        Me.Close()
    End Sub

    Private Sub chkAttivi_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttivi.CheckedChanged
        CaricaDati()
    End Sub

    Private Sub dgvElenco_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvElenco.CellFormatting

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = -1 Then Return
        Dim col As DataGridViewColumn = CType(sender, DataGridView).Columns(e.ColumnIndex)
        Dim rw As QuadroEntity = CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem
        If col Is dgvcSegno Then
            If rw.Segno >= 0 Then
                e.Value = My.Resources.Green_Plus_16_n_g
            Else
                e.Value = My.Resources.Red_Minus_16_n_g
            End If
        End If

    End Sub

    Private Sub tsbMateriali_Click(sender As Object, e As EventArgs) Handles tsbMateriali.Click
        Try
            Dim F As New FElencoMateriali
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class