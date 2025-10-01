Imports System.Data.SqlClient
Imports DAL.HelperClasses
Imports DAL.EntityClasses

Imports System.ComponentModel

Namespace DAL.Config
    Public Class clsCommonConfig
        Inherits mdsLLBLGenUtility.Adapter.ConfigBase
        Implements mdsConfig.IConfigSettigs

        Private Sub New()
            MyBase.new()
            Init(Parametri, ParametroFields.Nome, ParametroFields.Valore, DA)
        End Sub

        Private Shared _instance As clsCommonConfig
        Public Shared ReadOnly Property Instance As clsCommonConfig
            Get
                If _instance Is Nothing Then
                    _instance = New clsCommonConfig
                End If
                Return _instance
            End Get
        End Property

        Private Parametri As New EntityCollection(Of ParametroEntity)

        <Category("Gestione applicazione"), _
      Description("Versione del DB") _
      > _
        Public Property VersioneDB() As String
            Get
                Return (MyBase.Parametro("VersioneDB", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("VersioneDB") = value
            End Set
        End Property

        <Category("Gestione applicazione"), _
      Description("Versione applicazione richiesta") _
      > _
        Public Property VersioneApplicazione() As String
            Get
                Return (MyBase.Parametro("VersioneApplicazione", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("VersioneApplicazione") = value
            End Set
        End Property

        <Category("Gestione applicazione"), _
      Description("Path condiviso aggiornamenti") _
      > _
        Public Property UpdateFilePath() As String
            Get
                Return (MyBase.Parametro("UpdateFilePath", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("UpdateFilePath") = value
            End Set
        End Property

        <Category("Gestione modelli") _
      , Description("Percorso base modelli stampe") _
      , Editor(GetType(System.Windows.Forms.Design.FolderNameEditor) _
     , GetType(System.Drawing.Design.UITypeEditor)) _
     > _
        Public Property CartellaModelli() As String
            Get
                Return (MyBase.Parametro("CartellaModelli", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("CartellaModelli") = value
            End Set
        End Property


        <Category("Generale"), _
         Description("Numero elementi nelle paginazioni (10-1000)") _
         > _
        Public Property ElementiPerPagina() As Integer
            Get
                Return (MyBase.Parametro("ElementiPerPagina", "100"))
            End Get
            Set(ByVal value As Integer)
                If value < 10 Then value = 10
                If value > 1000 Then value = 1000
                MyBase.Parametro("ElementiPerPagina") = value
            End Set
        End Property

        <Category("Dichiarazioni"), _
        Description("Numero massimo di anni per la generazione automatica delle dichiarazioni (3-20)") _
        > _
        Public Property MaxAnniDichiarazioni() As Integer
            Get
                Return (MyBase.Parametro("MaxAnniDichiarazioni", "10"))
            End Get
            Set(ByVal value As Integer)
                If value < 3 Then value = 3
                If value > 20 Then value = 20
                MyBase.Parametro("MaxAnniDichiarazioni") = value
            End Set
        End Property


        <Category("Sito web"),
      Description("Connnessione DB Polietile.Net")
      >
        Public Property ConnessioneDBPolietileNet() As String
            Get
                Return (MyBase.Parametro("ConnessioneDBPolietileNet", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("ConnessioneDBPolietileNet") = value
            End Set
        End Property


        <Category("Gestione Soci"),
       Description("Numero massimo di giorni nello stato NUOVO")
       >
        Public Property NumeroGiorniStato_NUOVO() As Integer
            Get
                Return (MyBase.Parametro("NumeroGiorniStato_NUOVO", "40"))
            End Get
            Set(ByVal value As Integer)
                MyBase.Parametro("NumeroGiorniStato_NUOVO") = value
            End Set
        End Property




        <Category("Gestione applicazione"), _
        Description("Utente con permessi amministrativi per aggiornamento") _
        > _
        Public Property InstallUtente() As String
            Get
                Return (MyBase.Parametro("InstallUtente", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("InstallUtente") = value
            End Set
        End Property

        <Category("Gestione applicazione"), _
        Description("Password Utente con permessi amministrativi per aggiornamento"), _
        PasswordPropertyText(True)
        > _
        Public Property InstallPassword() As String
            Get
                Return (MyBase.Parametro("InstallPassword", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("InstallPassword") = value
            End Set
        End Property

        <Category("Gestione applicazione"), _
        Description("Dominio utente con permessi amministrativi per aggiornamento"), _
        PasswordPropertyText(True)
        > _
        Public Property InstallDomain() As String
            Get
                Return (MyBase.Parametro("InstallDomain", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("InstallDomain") = value
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Url servizio WCF-Arxivar") _
         > _
        Public Property ArxivarWcfUrl() As String
            Get
                Return (MyBase.Parametro("ArxivarWcfUrl", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("ArxivarWcfUrl") = value
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Area organizzativa") _
         > _
        Public Property ArxivarAreaOrganizzativa() As String
            Get
                Return (MyBase.Parametro("ArxivarAreaOrganizzativa", ""))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("ArxivarAreaOrganizzativa") = value
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Id rubrica soci") _
         > _
        Public Property ArxivarIdRubricaSoci() As Integer?
            Get
                Dim V As String = MyBase.Parametro("ArxivarIdRubricaSoci", "")
                If V = "" Then Return Nothing
                Return CInt(V)
            End Get
            Set(ByVal value As Integer?)
                If value Is Nothing Then
                    MyBase.Parametro("ArxivarIdRubricaSoci") = ""
                Else
                    MyBase.Parametro("ArxivarIdRubricaSoci") = value
                End If

            End Set
        End Property

        <Category("Arxivar"), _
         Description("Prefisso codice rubrica") _
         > _
        Public Property PrefissoCodiceRubrica() As String
            Get
                Return (MyBase.Parametro("PrefissoCodiceRubrica", "SP-"))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("PrefissoCodiceRubrica") = value
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Maschera profilazione dichiarazioni") _
         > _
        Public Property MascheraProfilazioneDichiarazioni() As String
            Get
                Return MyBase.Parametro("MascheraProfilazioneDichiarazioni", "")
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("MascheraProfilazioneDichiarazioni") = value
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Id profilo lettera accettazione") _
         > _
        Public Property ArxivarIdProfiloLetteraAccettazione() As Integer?
            Get
                Dim V As String = MyBase.Parametro("ArxivarIdProfiloLetteraAccettazione", "")
                If V = "" Then Return Nothing
                Return CInt(V)
            End Get
            Set(ByVal value As Integer?)
                If value Is Nothing Then
                    MyBase.Parametro("ArxivarIdProfiloLetteraAccettazione") = ""
                Else
                    MyBase.Parametro("ArxivarIdProfiloLetteraAccettazione") = value
                End If
            End Set
        End Property

        <Category("Arxivar"), _
         Description("Id profilo dichiarazione") _
         > _
        Public Property ArxivarIdProfiloDichiarazione() As Integer?
            Get
                Dim V As String = MyBase.Parametro("ArxivarIdProfiloDichiarazione", "")
                If V = "" Then Return Nothing
                Return CInt(V)
            End Get
            Set(ByVal value As Integer?)
                If value Is Nothing Then
                    MyBase.Parametro("ArxivarIdProfiloDichiarazione") = ""
                Else
                    MyBase.Parametro("ArxivarIdProfiloDichiarazione") = value
                End If
            End Set
        End Property

        <Category("Arxivar"), _
        Description("Contatto predefinito: Codice[,IdRubrica]") _
        > _
        Public Property ContattoPredefinito() As String
            Get
                Return MyBase.Parametro("ArxivarContattoPredefinito", "")
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("ArxivarContattoPredefinito") = value
            End Set
        End Property

        <Category("Varie"), _
       Description("Id Associazioni Cat.B ") _
       > _
        Public Property ElencoAssociziaoniCatB() As String
            Get
                Return (MyBase.Parametro("ElencoAssociziaoniCatB", "44,52,61,325,326,339,387,398,509,638,1309,1311,1459,1537,1742"))
            End Get
            Set(ByVal value As String)
                MyBase.Parametro("ElencoAssociziaoniCatB") = value
            End Set
        End Property

        <Editor(GetType(CallManager.AsteriskEditor), GetType(System.Drawing.Design.UITypeEditor)), Description("ASTERISK settings")>
        Public Property ConfigurazioneAsterisk() As CallManager.AsteriskManager.Configuration
            Get
                Return mdsUtility.JSonHelper.DeserializeObject(Of CallManager.AsteriskManager.Configuration)(CStr(MyBase.Parametro("ConfigurazioneAsterisk", "")))
            End Get
            Set(value As CallManager.AsteriskManager.Configuration)
                MyBase.Parametro("ConfigurazioneAsterisk") = mdsUtility.JSonHelper.SerializeObject(Of CallManager.AsteriskManager.Configuration)(value)
            End Set
        End Property


        Public Sub Save() Implements mdsConfig.IConfigSettigs.Save
            Me.SalvaDati()
        End Sub
    End Class

End Namespace