Imports System.ComponentModel
Public Class clsUserConfig
    Inherits mdsConfig.clsConfig
    Public Sub New(ByVal FileConf As String)
        MyBase.New(FileConf)
    End Sub

    <Category("Connessione DB"), _
       Description("Stringa connessione database") _
       > _
    Public Property StringaConnessioneDB() As String
        Get
            Return Encrypt(MyBase.Parameter("StringaConnessioneDB"))
        End Get
        Set(ByVal value As String)
            MyBase.Parameter("StringaConnessioneDB") = Encrypt(value)
        End Set
    End Property

    <Category("Gestione modelli") _
     ,Description("Percorso base modelli stampe") _
     ,Editor(GetType(System.Windows.Forms.Design.FolderNameEditor) _
     , GetType(System.Drawing.Design.UITypeEditor)) _
     > _
    Public Property CartellaModelli() As String
        Get
            Return (MyBase.Parameter("CartellaModelli", ""))
        End Get
        Set(ByVal value As String)
            MyBase.Parameter("CartellaModelli") = value
        End Set
    End Property

    <Category("Gestione modelli"), _
       Description("Margine superiore reports") _
       > _
    Public Property MargineSuperioreReports() As Integer
        Get
            Return CInt(MyBase.Parameter("MargineSuperioreReports", "1000"))
        End Get
        Set(ByVal value As Integer)
            MyBase.Parameter("MargineSuperioreReports") = value
        End Set
    End Property




    <Category("Gestione notifiche") _
 , Description("Notifica all'avvio se esistono soci NUOVI scaduti")
  > _
    Public Property NotificaNuoviSociScaduti() As Boolean
        Get
            Return (MyBase.Parameter("NotificaNuoviSociScaduti", "N") = "S")
        End Get
        Set(ByVal value As Boolean)
            MyBase.Parameter("NotificaNuoviSociScaduti") = IIf(value, "S", "N")
        End Set
    End Property

    <Category("Gestione notifiche"),
       Description("Numero giorni da scadenza notifiche (-1 per disattivare")
       >
    Public Property NumeroGiorniScadenzaNotifiche() As Integer
        Get
            Return (MyBase.Parameter("NumeroGiorniScadenzaNotifiche", "5"))
        End Get
        Set(ByVal value As Integer)
            MyBase.Parameter("NumeroGiorniScadenzaNotifiche") = value
        End Set
    End Property



    <Category("Arxivar") _
 , Description("Sincronizza rubrica Arxivar")
  >
    Public Property ArxivarSincronizzaRubrica() As Boolean
        Get
            Return (MyBase.Parameter("ArxivarSincronizzaRubrica", "S") = "S")
        End Get
        Set(ByVal value As Boolean)
            MyBase.Parameter("ArxivarSincronizzaRubrica") = IIf(value, "S", "N")
        End Set
    End Property

    <Category("Arxivar") _
 , Description("Disattiva chiamate Arxivar")
  >
    Public Property DisableArxivarIntegration() As Boolean
        Get
            Return (MyBase.Parameter("DisableArxivarIntegration", "") = "S")
        End Get
        Set(ByVal value As Boolean)
            MyBase.Parameter("DisableArxivarIntegration") = IIf(value, "S", "N")
        End Set
    End Property


    <Category("Dichiarazioni"), _
         Description("Cartella caricamento file") _
         > _
    Public Property CartellaFileDichiarazioni() As String
        Get
            Return (MyBase.Parameter("CartellaFileDichiarazioni", ""))
        End Get
        Set(ByVal value As String)
            MyBase.Parameter("CartellaFileDichiarazioni") = value
        End Set
    End Property

    Public Enum CallerTypeEnum
        NOT_DEFINED
        ATAPI
        ASTERISK
    End Enum

    <Browsable(True)>
    Public Property CallerType() As CallerTypeEnum
        Get
            Return MyBase.Parameter("CallerType", CallerTypeEnum.NOT_DEFINED)
        End Get
        Set(value As CallerTypeEnum)
            MyBase.Parameter("CallerType") = value
        End Set
    End Property


    <Editor(GetType(AtapiLineEditor), GetType(System.Drawing.Design.UITypeEditor)) _
    , TypeConverter(GetType(ExpandableObjectConverter)), Category("ATAPI Configuration"), Description("ATAPI settings")>
    Public Property IdLineaTAPI() As Integer
        Get
            Return MyBase.Parameter("IdLineaTAPI", -1)
        End Get
        Set(value As Integer)
            MyBase.Parameter("IdLineaTAPI") = value
        End Set
    End Property

    <Category("ASTERISK Configuration"), Description("Numero Interno")>
    Public Property IdInternoAsterisk() As String
        Get
            Return MyBase.Parameter("IdInternoAsterisk", "")
        End Get
        Set(value As String)
            MyBase.Parameter("IdInternoAsterisk") = value
        End Set
    End Property



End Class
