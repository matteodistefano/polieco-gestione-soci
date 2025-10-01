Public Class dlgEditAsterisk

    Private _cfg As AsteriskManager.Configuration
    Private _numTest As String

    Public Function Edit(cfg As AsteriskManager.Configuration) As AsteriskManager.Configuration
        If cfg Is Nothing Then
            cfg = New AsteriskManager.Configuration
        End If
        _cfg = cfg
        Inizializza()
        Me.ShowDialog()
        Return _cfg
    End Function

    Private Sub Inizializza()
        txtHost.Text = _cfg.IndirizzoHost
        txtPort.Text = _cfg.PortaHost
        txtUsername.Text = _cfg.Username
        txtPassword.Text = _cfg.Password
        txtTenantId.Text = _cfg.TenantId
        txtAttesa.Text = _cfg.Attesa
        txtInterno.Text = _cfg.Interno ' Generale.UserConfig.IdInternoAsterisk
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        _cfg.IndirizzoHost = txtHost.Text
        _cfg.PortaHost = txtPort.Text
        _cfg.Username = txtUsername.Text
        _cfg.Password = txtPassword.Text
        _cfg.TenantId = txtTenantId.Text
        _cfg.Attesa = Val(txtAttesa.Text)
        '_cfg.Interno = txtInterno.Text
        Me.Close()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        _cfg = Nothing
        Me.Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try

            Dim NN As String = InputBox("Numero da chiamare", "Test chiamata", _numTest)
            If NN = "" Then Return
            _numTest = NN

            Dim FLog As mdsUIControls.Logging.dlgLogRtf = mdsUIControls.Logging.dlgLogRtf.GetInstance
            FLog.ClearLog()
            FLog.LogTitle = "Test chiamata"
            FLog.Show()

            Dim cfg As New AsteriskManager.Configuration
            cfg.IndirizzoHost = txtHost.Text
            cfg.PortaHost = txtPort.Text
            cfg.Username = txtUsername.Text
            cfg.Password = txtPassword.Text
            cfg.TenantId = txtTenantId.Text
            cfg.Attesa = Val(txtAttesa.Text)
            cfg.Interno = txtInterno.Text

            Dim am As New AsteriskManager
            am.Initialize(cfg)
            am.MakeCall(NN)
            am.Shutdown()

            Trace.TraceInformation("-------------------------------------------")
            Trace.TraceInformation("Test terminato")
            Trace.TraceInformation("")
            Trace.TraceInformation("")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class