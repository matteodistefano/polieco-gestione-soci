Imports ATAPI = JulMar.Atapi
Public Class dlgEditAtapi
    Private _IdLinea As Integer?

    Public Function Edit(IdLinea As Integer) As Integer?
        _IdLinea = IdLinea
        Inizializza()
        Me.ShowDialog()
        Return _IdLinea
    End Function

    Private Sub Inizializza()
        Dim ll() As ATAPI.TapiLine = AtapiManager.Manager.Lines
        cbLinee.DisplayMember = "Name"
        cbLinee.ValueMember = "PermanentId"
        cbLinee.DataSource = ll

        cbLinee.SelectedIndex = -1
        If _IdLinea <> -1 Then
            Dim l As ATAPI.TapiLine = ll.FirstOrDefault(Function(x) x.PermanentId = _IdLinea)
            If l IsNot Nothing Then
                cbLinee.SelectedValue = l.PermanentId
            End If
        End If
        
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        _IdLinea = cbLinee.SelectedValue
        Me.Close()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        _IdLinea = Nothing
        Me.Close()
    End Sub
End Class