Imports DAL
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports Syncfusion.XlsIO

Module Generale
    Public MainForm As FMain
    Public ConnectionString As String
    Public UserApplicationFolder As String

    Public LogView As mdsUIControls.Logging.dlgLogRtf = mdsUIControls.Logging.dlgLogRtf.GetInstance

    Public CommonConfig As DAL.Config.clsCommonConfig
    Public UserConfig As clsUserConfig

    Private _DA As DAL.DatabaseSpecific.DataAccessAdapter

    Public COLOR_EDIT As Color = Color.FromArgb(192, 255, 192)
    Public COLOR_NO_EDIT As Color = Color.FromArgb(255, 255, 192)
    Public COLOR_ERR As Color = Color.FromArgb(255, 192, 192)


    Public ReadOnly Property DA As DAL.DatabaseSpecific.DataAccessAdapter
        Get
            Return _DA
        End Get
    End Property


    Public Function InitConnection() As Boolean
        Try
            UserApplicationFolder = mdsUtility.FileSystem.GetUserConfigFolder(True)
            UserConfig = New clsUserConfig(UserApplicationFolder & "\settings.xml")
            ConnectionString = UserConfig.StringaConnessioneDB

            If ConnectionString = "" Then Throw New Exception("Connessione non definita")

            mdsDBLib.SqlServer.TestConnection(ConnectionString, True)
            DAL.DatabaseSpecific.InitConnection(ConnectionString)
            _DA = DAL.DatabaseSpecific.Generale.DA
            DAL.Generale.InitDataAccess(_DA)
            mdsLLBLGenUtility.Adapter.FTabelleEditorAD.SetDataAdapter(_DA)

            CommonConfig = DAL.Config.clsCommonConfig.Instance

            Dim F As New FAggiornaDB
            If Not F.VerificaVersione Then
                If MsgBox("Proseguire comunque ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then End
            End If

            'Controllo versione minima applicazione
            Dim VM As String = CommonConfig.VersioneApplicazione
            If VM <> "" Then
                Dim VA As String = Application.ProductVersion
                If VA < VM Then
                    Dim Msg As String
                    Msg = "Per il corretto accesso ai dati è richiesta almeno la versione " & VM & " dell'applicazione mentre la versione attuale è la " & VA & "."
                    Msg &= vbCr & "Controllare la disponibilità dell'aggiornamento ?"
                    Msg &= vbCr & "Rispondendo [NO] sarà comunque consentito l'accesso, ma potrebbero presentarsi malfunzionamenti e perdite di dati."
                    Dim Risp As MsgBoxResult = MsgBox(Msg, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNoCancel)
                    If Risp = MsgBoxResult.Yes Then
                        InstallaAggiornamento(VM)
                        End
                    ElseIf Risp = MsgBoxResult.No Then
                        'GoTo Accesso
                    Else
                        End
                    End If
                End If
            Else
                MsgBox("Attenzione numero di versione minima non impostato !!!", MsgBoxStyle.Information)
                CommonConfig.VersioneApplicazione = "0.0.0.0"
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

            If MsgBox("Accedere al modulo di configurazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return False
            Dim F As New mdsConfig.dlgImpostazioni
            F.Apri("Impostazioni utente", UserConfig)
            Return False

        End Try
    End Function

    Private Sub InstallaAggiornamento(ByVal V As String)
        Try
            Dim Buff As String = CommonConfig.UpdateFilePath
            If Buff = "" Then Throw New Exception("Percorso aggiornamenti non definito")

            Dim PathAgg As String = String.Format(Buff, V)
            If Not System.IO.File.Exists(PathAgg) Then
                Throw New Exception("File aggiornamento non trovato.")
            End If

            If CommonConfig.InstallUtente <> "" AndAlso CommonConfig.InstallPassword <> "" Then
                Dim pwd As New System.Security.SecureString
                For Each c As Char In CommonConfig.InstallPassword
                    pwd.AppendChar(c)
                Next
                Process.Start(PathAgg, CommonConfig.InstallUtente, pwd, CommonConfig.InstallDomain)
            Else
                Process.Start(PathAgg)
            End If


        Catch ex As Exception
            MsgBox(ex.Message & vbCr & vbCr & "Cercare il file manualmente o rivolgersi all'amministratore.", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub MessageBox(ByVal FOwner As IWin32Window, ByVal Msg As String, ByVal Icon As MessageBoxIcon)
        Dim Risp
        Risp = System.Windows.Forms.MessageBox.Show(FOwner, Msg, "Polieco", MessageBoxButtons.OK, Icon)
    End Sub


    Public Function GetCartellaModelli()


        Dim Path As String
        Path = UserConfig.CartellaModelli
        If System.IO.Directory.Exists(Path) Then Return Path

        Path = CommonConfig.CartellaModelli
        If System.IO.Directory.Exists(Path) Then Return Path

        Path = Environment.SpecialFolder.LocalApplicationData & "\PoliecoSoci\modelli"
        If Not System.IO.Directory.Exists(Path) Then
            System.IO.Directory.CreateDirectory(Path)
        End If

        Return Path
    End Function

    'Dim _gridLogger As mdsUIControls.Logging.dlgLogGridview
    'Public Function GetCommonGridLogger() As mdsUIControls.Logging.dlgLogGridview
    '    If _gridLogger Is Nothing Then
    '        _gridLogger = New mdsUIControls.Logging.dlgLogGridview()
    '    End If
    '    Return _gridLogger
    'End Function

    'Dim _txtLogger As mdsUIControls.Logging.TextBoxLogManager
    'Public Function GetCommonTxtLogger() As mdsUIControls.Logging.TextBoxLogManager
    '    If _txtLogger Is Nothing Then
    '        _txtLogger = New mdsUIControls.Logging.TextBoxLogManager
    '    End If
    '    Return _txtLogger
    'End Function

    'Dim _rtfLogger As mdsUIControls.Logging.dlgLogRtf
    'Public Function GetCommonRtfLogger() As mdsUIControls.Logging.dlgLogRtf
    '    If _rtfLogger Is Nothing Then
    '        _rtfLogger = New mdsUIControls.Logging.dlgLogRtf
    '    End If
    '    Return _rtfLogger
    'End Function


    Public Sub InizializzaApplicazione()

        ''Inizializzazione shared controls
        'ucStatoFlussoEC.Init()
        'ucStatoEBT.Init()
        'ucStatoMovimento.Init()
        'ucStatoAtecoF24.Init()

        Generale.InitCallManager()

        mdsUIControls.ucTxtCall.DefaultAction(mdsUIControls.ucTxtCall.TipoEnum.Telefono) =
            Sub(sender As System.Object, e As mdsUIControls.MdsEventArgs.HandledEventArgs)
                Try
                    e.IsHandled = True
                    Dim nn() As String = Caller.GetCallableNumber(sender.text)
                    If nn Is Nothing OrElse nn.Length = 0 Then Return
                    'Dim lineId As Integer = Generale.UserConfig.IdLineaTAPI
                    If nn.Length = 1 Then
                        Caller.MakeCall(nn(0))
                    Else
                        Dim cm As ContextMenuStrip = Caller.GetContextMenu(nn)
                        Dim ctl As Control = sender
                        cm.Show(sender, New Point(ctl.Width, 0), ToolStripDropDownDirection.Right)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End Sub

        MainForm = New FMain
        MainForm.Show()
    End Sub

    Dim _Caller As CallManager.ManagerBase
    Public ReadOnly Property Caller As CallManager.ManagerBase
        Get
            Return _Caller
        End Get
    End Property

    Public Sub InitCallManager()
        If UserConfig.CallerType = UserConfig.CallerTypeEnum.ATAPI Then
            _Caller = New CallManager.AtapiManager
            Dim cfg As New CallManager.AtapiManager.Configuration
            cfg.LineId = UserConfig.IdLineaTAPI
            _Caller.Initialize(cfg)
        ElseIf UserConfig.CallerType = UserConfig.CallerTypeEnum.ASTERISK Then
            _Caller = New CallManager.AsteriskManager
            Dim cfg As CallManager.AsteriskManager.Configuration = CommonConfig.ConfigurazioneAsterisk
            If cfg Is Nothing Then
                cfg = New CallManager.AsteriskManager.Configuration
            End If

            cfg.Interno = UserConfig.IdInternoAsterisk
            _Caller.Initialize(cfg)
        Else
            _Caller = New CallManager.ManagerBase
        End If
    End Sub


End Module
