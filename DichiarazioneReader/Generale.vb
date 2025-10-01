Module Generale
    Sub Main()
        Dim Par() As String = My.Application.CommandLineArgs.ToArray
        Dim DA As DAL.DatabaseSpecific.DataAccessAdapter = Nothing

        Dim cfgPath As String = mdsUtility.FileSystem.GetUserConfigFolder(True) & "\settings.xml"
        cfgPath = cfgPath.Replace(My.Application.Info.AssemblyName, "PoliecoSoci")
        If Not System.IO.File.Exists(cfgPath) Then
            MsgBox("File di configurazione non trovato. Non sarà possibile l'acceso alla gestione dei soci", MsgBoxStyle.Information)
        Else
            Dim cfg As New mdsConfig.clsConfig(cfgPath)
            If cfg IsNot Nothing Then
                DA = New DAL.DatabaseSpecific.DataAccessAdapter(cfg.Encrypt(cfg.Parameter("StringaConnessioneDB")))
            End If
            DAL.Generale.InitDataAccess(DA)
        End If
        
        If Par.Length = 1 Then
            DichiarazioneOnLine.Manager.Open(Par(0))
        Else
            DichiarazioneOnLine.Manager.Open()
        End If
    End Sub

End Module
