Imports System.Windows.Forms
Imports DAL.Managers

Public Class dlgCambioPassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Valida()
            UtentiManager.SetNewPassword(Me.txtPwd1.Text)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox(Me, ex.Message, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub Valida()
        Me.txtPwd1.Text = Me.txtPwd1.Text.Trim
        Me.txtPwd2.Text = Me.txtPwd2.Text.Trim
        If Me.txtPwd1.Text = "" Then Throw New Exception("Inserire una password.")
        If Me.txtPwd2.Text <> Me.txtPwd1.Text Then Throw New Exception("Inserimenti non coincidenti.")
    End Sub

End Class
