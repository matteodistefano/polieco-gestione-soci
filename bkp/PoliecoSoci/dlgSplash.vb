Imports DAL.Managers
Public Class dlgSplash
    Private _Ret As Boolean

    Private Sub dlgSplash_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = vbCr Then
            If Me.ActiveControl Is txtUser Then
                Me.txtPassword.Focus()
            Else
                btnOk.Focus()
            End If
        End If
    End Sub

    Private Sub dlgSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lCredits.Text = String.Format("Vers. {0} - {1}", My.Application.Info.Version.ToString, My.Application.Info.Copyright)

        Try
            Dim Ips As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
            For Each ip In Ips.AddressList
                If Not System.Net.IPAddress.IsLoopback(ip) AndAlso ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    DAL.Managers.AuditManager.IpAddress = ip.ToString
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try

        'Ricava ultimo utente
        Dim Ut As String = My.Settings.LastUserLogged
        If Ut <> "" Then
            txtUser.Text = Ut
            txtPassword.TabIndex = 0
            txtUser.TabIndex = 1
        End If

        '#todo rimuovere
        'Preimposta la password
        'txtPassword.Text = "polieco"
        'btnOk.TabIndex = 0
        'txtPassword.TabIndex = 10
        'txtUser.TabIndex = 9


    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            txtUser.Text = txtUser.Text.Trim
            txtPassword.Text = txtPassword.Text.Trim
            If txtUser.Text.Length = 0 Then
                MsgBox("Inserire lo user name", MsgBoxStyle.Exclamation)
                txtUser.Focus()
                Exit Sub
            End If
            If txtPassword.Text.Length = 0 Then
                MsgBox("Inserire la password", MsgBoxStyle.Exclamation)
                txtPassword.Focus()
                Exit Sub
            End If

            AddLog("Inizializzazione connessione", Color.Blue)
            If Not Generale.InitConnection() Then Return

            Dim logRes As UtentiManager.LoginResponseEnum = UtentiManager.Login(txtUser.Text, txtPassword.Text)
            Select Case logRes
                Case UtentiManager.LoginResponseEnum.NO
                    Me.AddLog("UserId e password non validi..." & vbCrLf & vbCrLf & _
                            "Accesso non consentito", Color.Red)
                    Exit Sub
                Case UtentiManager.LoginResponseEnum.NO_ACTIVE
                    Me.AddLog("Account disattivato." & vbCrLf & vbCrLf & _
                            "Contattare l'amministratore", Color.Red)
                    Exit Sub
                Case UtentiManager.LoginResponseEnum.CHANGE_PASSWORD

                    Me.AddLog("Richiesto cambio password.", Color.Blue)
                    Dim fCP As New dlgCambioPassword
                    Dim rCP As DialogResult = fCP.ShowDialog

                    If rCP = Windows.Forms.DialogResult.OK Then
                        Me.txtPassword.Text = ""
                        Me.txtPassword.Focus()
                        Me.AddLog("Password provvisoria modificata", Color.Green)
                        AuditManager.AddAudit(txtUser.Text, "", AuditManager.OperazioneEnum.PWD_CHANGE, "")
                    Else
                        Me.AddLog("Password non modificata", Color.Red)
                    End If
                    Return
                Case UtentiManager.LoginResponseEnum.OK
                    AddLog("Password riconosciuta." & vbCrLf & vbCrLf & "Inizializzazione dati in corso ...", Color.DarkGreen)
                Case Else
                    Throw New Exception("Non riconosciuto")
            End Select

            AuditManager.AddAudit("", AuditManager.OperazioneEnum.LOGIN, "Vers.App. " & My.Application.Info.Version.ToString)
            My.Settings.LastUserLogged = txtUser.Text
            My.Settings.Save()


            AddLog("Inizializzazione Arxivar", Color.Blue)

            If (Control.ModifierKeys And Keys.Control) <> 0 Then
                AddLog("Inizializzazione Arxivar annullata", Color.Red)
            Else
                Try
                    ArxivarWCFWrapper.InitConnectionData(CommonConfig.ArxivarWcfUrl, UtentiManager.UtenteCorrente.ArxivarUserId, UtentiManager.UtenteCorrente.ArxivarPassword, "PoliecoSoci")
                    ArxivarWCFWrapper.SetContattoPredefinito(CommonConfig.ContattoPredefinito)

                    AddLog("Connessione WCF inizializzata", Color.Green)
                Catch ex As Exception
                    AddLog(ex.Message, Color.Red)
                End Try
            End If


            AddLog("Inizializzazione applicazione", Color.Blue)
            AddLog("Caricamento tabelle lookups", Color.Blue)
            'DAL.Lookups.PreloadCollection("Comuni")
            DAL.Lookups.PreloadCollection("Province")
            DAL.Lookups.PreloadCollection("Regioni")

            If System.Windows.Forms.Control.ModifierKeys And Keys.Control <> 0 Then
                MsgBox("Inizializzazione terminata")
            End If

            Generale.InizializzaApplicazione()


            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddLog(ByVal Msg As String, ByVal Col As Color)
        If Not txtLog.Visible Then
            'txtLog.SetBounds(pbLogo.Left, pbLogo.Top, pbLogo.Width, pbLogo.Height)

            'Dim yl As Integer = pbLogo.Top
            'For y As Integer = yl To Me.Height
            '    pbLogo.Top = y
            '    Me.Update()
            'Next
            'pbLogo.Visible = False
            txtLog.Visible = True
        End If

        txtLog.ForeColor = Col
        txtLog.AppendText(vbCrLf & Msg)
        'txtLog.SelectionStart = txtLog.Text.Length
        txtLog.ScrollToCaret()
        txtLog.Refresh()
    End Sub

End Class