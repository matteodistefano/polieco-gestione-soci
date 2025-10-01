Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class dlgUtente
    Private _Utente As UtenteEntity
    Private retValue As Boolean

    Public Function Apri(ByVal Ut As UtenteEntity) As Boolean
        Me._Utente = Ut
        Ut.AuditorToUse = New EntityAuditor
        inizializza()
        Me.ShowDialog()
        Ut.AuditorToUse = Nothing
        Return retValue
    End Function

    Private Sub Inizializza()

        _Utente.SaveFields("Edit")

        lstRuoli.DataSource = DAL.Lookups.Ruoli
        lstRuoli.DisplayMember = "Descrizione"
        lstRuoli.ValueMember = "Codice"



        Me.bsUtente.DataSource = _Utente

        For i As Integer = 0 To lstRuoli.Items.Count - 1
            lstRuoli.SetItemChecked(i, _Utente.IsInRole(lstRuoli.Items(i)("Codice")))
        Next
        
        Me.lPwd.Location = Me.txtPwd.Location
        Me.lPwd.Size = Me.txtPwd.Size

        Me.txtUserId.Enabled = _Utente.IsNew
        UpdatePasswordVisibility()

        Me.DataRegistrazioneTextBox.ReadOnly = True
        Me.DataRilascioPasswordTextBox.ReadOnly = True
        Me.DataUltimoAccessoTextBox.ReadOnly = True
        Me.NumAccessiTextBox.ReadOnly = True



    End Sub
    
    Private Sub UpdatePasswordVisibility()
        Dim IsPwdEditable As Boolean = (_Utente.Password.Length = 0)
        Me.btnResetPwd.Visible = Not IsPwdEditable
        Me.txtPwd.Visible = IsPwdEditable
        Me.lPwd.Visible = Not IsPwdEditable
    End Sub

    Private Sub tsbAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnnulla.Click
        Me.bsUtente.CancelEdit()
        If Not _Utente.IsNew Then
            _Utente.RollbackFields("Edit")
        End If
        retValue = False
        Me.Close()
    End Sub

    Private Sub tsbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOk.Click
        Try
            Me.bsUtente.EndEdit()


            DA.StartTransaction(IsolationLevel.ReadCommitted, "SaveUser")


            For i As Integer = 0 To lstRuoli.Items.Count - 1
                Dim CodRuolo As String = lstRuoli.Items(i)("Codice")
                If lstRuoli.GetItemChecked(i) Then
                    _Utente.AddRuolo(CodRuolo)
                Else
                    If _Utente.IsInRole(CodRuolo) Then
                        Dim ru As RuoloUtenteEntity = _Utente.Ruoli.First(Function(x) x.CodRuolo = CodRuolo)
                        DA.DeleteEntity(ru)
                        _Utente.Ruoli.Remove(ru)
                    End If
                End If
            Next


            Me._Utente.ValidateEntity()
            DA.SaveEntity(_Utente, True, True)

            DA.Commit()
            retValue = True

            Me.Close()
        Catch ex As Exception
            DA.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub





    Private Sub btnResetPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPwd.Click
        If MsgBox("La password sarà resettata e sarà consentito di inserirne una provvisoria. Al primo accesso sarà richiesto all'utente di definirne una nuova." & vbCr & "Proseguire ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information) = MsgBoxResult.No Then Return
        _Utente.Password = Nothing
        _Utente.PasswordProvvisoria = ""
        UpdatePasswordVisibility()
        Me.txtPwd.Focus()
    End Sub


End Class