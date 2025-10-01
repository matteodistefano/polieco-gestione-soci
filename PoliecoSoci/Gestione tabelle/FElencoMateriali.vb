Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FElencoMateriali
    Private _PP As PrefetchPath2
    Private _Materiali As EntityView2(Of MaterialeEntity)
    Private _SelMateriali() As MaterialeEntity
    Private _CanEdit As Boolean
    Public Sub Apri()
        tsbSelect.Available = False
        Inizializza()
        Me.ShowDialog()
    End Sub

    Public Function GetMateriali() As IEnumerable(Of MaterialeEntity)
        tsbSelect.Available = True
        Inizializza()
        Me.ShowDialog()
        Return _SelMateriali
    End Function

    Private Sub Inizializza()
        ccTipo.SetData(Lookups.TipiMateriale, "Descrizione", "Codice")
        _Materiali = Lookups.Materiali.CreateView
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
        If _Materiali Is Nothing Then Return

        Dim pr As New PredicateExpression
        If ccTipo.Checked Then
            pr.AddWithAnd(MaterialeFields.CodTipo = ccTipo.SelectedValue)
        End If

        If chkAttivi.Checked Then
            pr.AddWithAnd(MaterialeFields.Utilizzato = True)
        End If

        _Materiali.Filter = pr
        Me.bsMateriali.DataSource = _Materiali
    End Sub

    Private Sub tsbChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbChiudi.Click
        _SelMateriali = Nothing
        Me.Close()
    End Sub

    Private Sub tsbNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuovo.Click
        Dim M As New MaterialeEntity
        M.Utilizzato = True
        M.Prezzo = 0
        Dim F As New dlgMateriale
        If F.Apri(M) Then
            Me._Materiali.RelatedCollection.Add(M)
            CaricaDati()
            bsMateriali.Position = bsMateriali.IndexOf(M)
        End If
    End Sub

    Private Sub tsbModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModifica.Click, dgvElenco.DoubleClick
        ApriMateriale()
    End Sub

    Private Sub ApriMateriale()
        If Not _CanEdit Then Return
        If Me.bsMateriali.Current Is Nothing Then Return
        Dim F As New dlgMateriale
        F.Apri(Me.bsMateriali.Current)
        CaricaDati()
        dgvElenco.Invalidate()
    End Sub


    Private Sub tsbElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbElimina.Click
        Dim Mat As MaterialeEntity = bsMateriali.Current
        If Mat Is Nothing Then Return
        If MsgBox("Eliminare il materiale selezionato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            DAL.Managers.AuditManager.AddAudit("Materiale", Managers.AuditManager.OperazioneEnum.DEL, Mat.Codice)
            DA.DeleteEntity(Mat)
            Me.bsMateriali.RemoveCurrent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ccTipo_SelectionChanged(sender As Object, e As EventArgs) Handles ccTipo.SelectionChanged
        CaricaDati()
    End Sub

    Private Sub tsbSelect_Click(sender As Object, e As EventArgs) Handles tsbSelect.Click
        Dim ss() As MaterialeEntity = mdsUIControls.ExtendedDataGridView.GetSelectedDataRow(Of MaterialeEntity)(dgvElenco, False)
        If ss Is Nothing OrElse ss.Length = 0 Then Return
        _SelMateriali = ss
        Me.Close()
    End Sub

    Private Sub chkAttivi_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttivi.CheckedChanged
        CaricaDati()
    End Sub
End Class