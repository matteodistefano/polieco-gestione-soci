Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports DAL.Managers
Imports DAL
Imports System.Data.SqlClient

Public Class FMain

    Private Sub mbUscita_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub FMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    For Each ctl In pnlMain.Controls
    '        If TypeOf ctl Is mdsUIControls.ucMainButton Then
    '            CType(ctl, mdsUIControls.ucMainButton).UpdateLayout()
    '        End If

    '    Next
    'End Sub

    Private Sub FMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim ff As New ArrayList
        For Each f In My.Application.OpenForms
            If f IsNot Me Then
                ff.Add(f)
            End If
        Next

        For Each f As Form In ff
            f.Close()
        Next

        AuditManager.AddAudit("", AuditManager.OperazioneEnum.LOGOUT, "")

    End Sub

    Private Sub FMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Polieco - Gestione Soci - vers. " & My.Application.Info.Version.ToString
        Me.tsslApp.Text = Me.Text & " - Utente: " & UtentiManager.UtenteCorrente.Nome
        Me.tsslCopyright.Text = "Ing. Matteo Di Stefano - 2011-2020"
        InitUISecurity()

        If Generale.UserConfig.NotificaNuoviSociScaduti Then CheckNuoviSoci()
        If Generale.UserConfig.NumeroGiorniScadenzaNotifiche >= 0 Then CheckEventiNotifiche()
        Button1.Visible = System.IO.File.Exists(My.Application.Info.DirectoryPath & "\developer.txt")

        If UtentiManager.IsLoggedUserAdmin Then
            LoadUsersMenu()
        Else
            tsddUsers.Available = False
        End If

    End Sub

    Private Sub LoadUsersMenu()
        tsddUsers.DropDownItems.Clear()
        Dim Utenti = New EntityCollection(Of UtenteEntity)
        Dim pp As New PrefetchPath2(CInt(EntityType.UtenteEntity))
        pp.Add(UtenteEntity.PrefetchPathRuoli)
        DA.FetchEntityCollection(Utenti, Nothing, pp)
        For Each u In Utenti
            tsddUsers.DropDownItems.Add(u.Nome, My.Resources.User_2_16_n_g, AddressOf ChangeUser).Tag = u
        Next

    End Sub

    Private Sub ChangeUser(sender As Object, e As System.EventArgs)
        UtentiManager.SetCurrentUser(sender.tag)
        Me.tsslApp.Text = Me.Text & " - Utente: " & UtentiManager.UtenteCorrente.Nome
        InitUISecurity()
    End Sub


    Private Sub InitUISecurity()

        tsmiGestione.Enabled = UtentiManager.IsLoggedUserInRole(Enums.Ruolo.DIREZIONE, Enums.Ruolo.SEGRETERIA)
        tsmiUtenti.Enabled = UtentiManager.IsLoggedUserAdmin
        tsmiGenQuote.Available = UtentiManager.IsLoggedUserInRole(Enums.Ruolo.DIREZIONE, Enums.Ruolo.REPORT_QUOTE)
        tsbNotifiche.Available = UtentiManager.IsLoggedUserInRole(Enums.Ruolo.SEGRETERIA, Enums.Ruolo.DIREZIONE, Enums.Ruolo.REPORT_QUOTE)
        tsbCDAAss.Available = UtentiManager.IsLoggedUserInRole(Enums.Ruolo.SEGRETERIA, Enums.Ruolo.DIREZIONE, Enums.Ruolo.REPORT_QUOTE)
    End Sub

    Private Sub CheckEventiNotifiche()
        Try
            Dim NNG As Integer = UserConfig.NumeroGiorniScadenzaNotifiche
            If NNG = -1 Then Return

            Dim Ruoli As String = String.Join(",", UtentiManager.UtenteCorrente.Ruoli.Select(Function(x) "'" & x.CodRuolo & "'").ToArray)

            Dim Sql As String = "Select ea.DataAvviso,az.id,az.RagioneSociale,ea.causale 
                        from EventoAzienda ea 
                        inner join Azienda az on ea.idAzienda=az.Id
                        where az.CodTipoIscrizione<>'" & Enums.TipoSocio.ARC_STO & "' 
                        and ea.IsChiuso=0 
                        and datediff(day,getdate(),ea.dataavviso)<=" & NNG & "
                        and (ea.codUtente='" & UtentiManager.UtenteCorrente.UserName & "' or ea.RuoloNotifica in (" & Ruoli & "))     
                        order by ea.DataAvviso
                "
            Dim tb As DataTable = DAL.DbLib.GetDbTable(Sql)
            If tb.Rows.Count = 0 Then Return


            Dim F As New mdsUIControls.FVisData
            F.OnLoadData = Function() tb
            F.Font = Me.Font
            F.Text = "Notifiche"
            F.Message = "Elenco notifiche aperte in scadenza entro i prossimi " & NNG & " giorni."
            F.HideOkButton()
            F.UndoText = "Chiudi"
            AddHandler F.RowSelected, AddressOf ApriNotifica

            Dim CC As New List(Of mdsUIControls.FVisData.Campo)
            CC.Add(New mdsUIControls.FVisData.Campo("DataAvviso", "Scadenza", "120"))
            CC.Add(New mdsUIControls.FVisData.Campo("Id", "Codice", "80"))
            CC.Add(New mdsUIControls.FVisData.Campo("RagioneSociale", "Ragione Sociale", "100%"))
            CC.Add(New mdsUIControls.FVisData.Campo("Causale", "Causale", "100%"))

            F.InizializzaGrid(Nothing, CC)
            F.Size = New Size(1024, 600)
            F.Apri()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub


    Private Sub CheckNuoviSoci()
        Try
            Dim NNG As Integer = CommonConfig.NumeroGiorniStato_NUOVO

            Dim F As New mdsUIControls.FVisData
            F.OnLoadData = Function() DAL.Managers.SociManager.GetNuoviSociInScadenza(NNG)
            F.Font = Me.Font

            If F.OnLoadData.Invoke().Rows.Count = 0 Then Return

            F.Text = "Notifica nuovi soci"
            F.Message = "Attenzione !!! I seguenti soci sono nello stato ""NUOVO"" da oltre " & NNG & " giorni."
            F.HideOkButton()
            F.UndoText = "Chiudi"
            AddHandler F.RowSelected, AddressOf NotificaAzNuovaSelected

            Dim CC As New List(Of mdsUIControls.FVisData.Campo)
            CC.Add(New mdsUIControls.FVisData.Campo("Id", "Codice", "80"))
            CC.Add(New mdsUIControls.FVisData.Campo("RagioneSociale", "Ragione Sociale", "100%"))
            CC.Add(New mdsUIControls.FVisData.Campo("CodCategoria", "Cat.", "60", "", DataGridViewContentAlignment.MiddleCenter))
            CC.Add(New mdsUIControls.FVisData.Campo("DataLettera", "Data Iscrizione", "120", "d", DataGridViewContentAlignment.MiddleCenter))
            F.InizializzaGrid(Nothing, CC)
            F.Size = New Size(800, 600)
            F.Apri()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub NotificaAzNuovaSelected(sender As Object, e As mdsUIControls.FVisData.RowSelectedEventArg)
        Try
            Dim F As New FAzienda
            F.Apri(e.Row("Id"))
            CType(sender, mdsUIControls.FVisData).RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub ApriNotifica(sender As Object, e As mdsUIControls.FVisData.RowSelectedEventArg)
        Try
            Dim F As New FAzienda
            F.Apri(e.Row("Id"))
            CType(sender, mdsUIControls.FVisData).RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub mbEBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FElencoSoci.Apri(Me)
    End Sub

    Private Sub mbAttivita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Non implementato")
    End Sub

    Private Sub tsmiParametri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DatiProvaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatiProvaToolStripMenuItem.Click
        Try
            'Dim X As String = InputBox("Password", "Password", "")
            'If X <> "1111" Then Return
            'Dim F As New dlgTest
            'F.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RegioniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegioniToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Regioni", DAL.Lookups.Regioni)
            DAL.Lookups.ResetCollection("Regioni")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ProvinceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProvinceToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Province", DAL.Lookups.Province)
            DAL.Lookups.ResetCollection("Province")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ComuniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComuniToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Comuni", DAL.Lookups.Comuni)
            DAL.Lookups.ResetCollection("Comuni")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiUtenti_Click(sender As System.Object, e As System.EventArgs) Handles tsmiUtenti.Click
        Try
            Dim F As New FManagerUtenti
            F.Apri()
            LoadUsersMenu()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiAssCDA_Click(sender As Object, e As EventArgs) Handles tsmiAssCDA.Click
        Try
            Dim F As New FElencoRiunioni
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiScadenze_Click(sender As Object, e As EventArgs) Handles tsmiScadenze.Click
        Try
            Dim F As New FElencoScadenze
            F.Apri()
            DAL.Lookups.ResetCollection("Scadenze")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub GestioneMaterialiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiMateriali.Click
        Try
            Dim F As New FElencoMateriali
            F.Apri()
            DAL.Lookups.ResetCollection("Materiali")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub GestioneQuadriDichiarazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiQuadri.Click
        Try
            Dim F As New FElencoQuadri
            F.Apri()
            DAL.Lookups.ResetCollection("Quadri")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


#Region "Lookup edit"
    Private Sub CategorieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Categorie", DAL.Lookups.Categorie)
            DAL.Lookups.ResetCollection("Categorie")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FormeGiuridicheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormeGiuridicheToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Forme Giuridiche", DAL.Lookups.FormeGiuridiche)
            DAL.Lookups.ResetCollection("FormeGiuridiche")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiSociToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiSociToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi Socio", DAL.Lookups.TipiSocio)
            DAL.Lookups.ResetCollection("TipiSocio")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub StatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatoToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Stati Socio", DAL.Lookups.StatiSocio)
            DAL.Lookups.ResetCollection("StatiSocio")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub InfoStatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoStatoToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Info Stati Socio", DAL.Lookups.InfoStati)
            DAL.Lookups.ResetCollection("InfoStati")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub RuoliContattoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuoliContattoToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Ruoli contatto", DAL.Lookups.RuoliContatto)
            DAL.Lookups.ResetCollection("RuoliContatto")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TitoliContattoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoliContattoToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Titoli contatto", DAL.Lookups.TitoliContatto)
            DAL.Lookups.ResetCollection("TitoliContatto")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub



    Private Sub TipiAttivitàToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiAttivitàToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi attività", DAL.Lookups.TipiAttivita)
            DAL.Lookups.ResetCollection("TipiAttivita")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiAttrezzatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiAttrezzatureToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi attrezzatura", DAL.Lookups.TipiAttrezzatura)
            DAL.Lookups.ResetCollection("TipiAttrezzatura")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiQuadroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiQuadroToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi quadro", DAL.Lookups.TipiQuadro)
            DAL.Lookups.ResetCollection("TipiQuadro")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub TipiMaterialeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiMaterialeToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi materiale", DAL.Lookups.TipiMateriale)
            DAL.Lookups.ResetCollection("TipiMateriale")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub UnitaDiMisuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitaDiMisuraToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Unita di misura", DAL.Lookups.UnitaMisura)
            DAL.Lookups.ResetCollection("UnitaMisura")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiLicenzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiLicenzeToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi licenza", DAL.Lookups.TipiLicenza)
            DAL.Lookups.ResetCollection("TipiLicenza")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiSedeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiSedeToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi sede", DAL.Lookups.TipiSede)
            DAL.Lookups.ResetCollection("TipiSede")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub QuoteAdesioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuoteAdesioneToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Quote di adesione", DAL.Lookups.QuoteAdesione)
            DAL.Lookups.ResetCollection("QuoteAdesione")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiModPagamento_Click(sender As Object, e As EventArgs) Handles tsmiModPagamento.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Modalità pagamento", DAL.Lookups.ModalitaPagamento)
            DAL.Lookups.ResetCollection("ModalitaPagamento")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

#End Region

    Private Sub tsmiPassCDA_Click(sender As Object, e As EventArgs) Handles tsmiPassCDA.Click
        Try
            Dim F As New FPassaggioAssociati
            F.Apri(FPassaggioAssociati.TipoPassaggioEnum.CDA)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiPassAss_Click(sender As Object, e As EventArgs) Handles tsmiPassAss.Click
        Try
            Dim F As New FPassaggioAssociati
            F.Apri(FPassaggioAssociati.TipoPassaggioEnum.ASSEMBLEA)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub LibroSociToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroSociToolStripMenuItem.Click
        Try
            Dim F As New FLibroSoci
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiAliquoteIVA_Click(sender As Object, e As EventArgs) Handles tsmiAliquoteIVA.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Aliquote IVA", DAL.Lookups.AliquoteIVA)
            DAL.Lookups.ResetCollection("AliquoteIVA")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim F As New FDichiarazione
            F.Apri(64437)

            'Dim f As New FElencoAziendeAllegato
            'f.Apri()

            'Dim F As New FElencoProdotti
            'F.GetProdotti()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiNotificheNuoviSoci_Click(sender As Object, e As EventArgs) Handles tsmiNotificheNuoviSoci.Click
        CheckNuoviSoci()
    End Sub

    Private Sub tsbSoci_Click(sender As Object, e As EventArgs) Handles tsbSoci.Click
        FElencoSoci.Apri(Me)
    End Sub

    Private Sub tsmiImpostazioni_Click(sender As Object, e As EventArgs) Handles tsmiImpostazioni.Click
        Try
            Dim F As New mdsConfig.dlgImpostazioni
            Dim cc As New Dictionary(Of String, mdsConfig.IConfigSettigs)
            cc.Add("Impostazioni utente", UserConfig)
            If UtentiManager.IsLoggedUserAdmin Then
                cc.Add("Impostazioni amministratore", CommonConfig)
            End If
            F.Apri(cc)
            Generale.InitCallManager()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        If My.Application.OpenForms.Count > 1 Then
            If MsgBox("Chiudere l'applicazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        End If
        Me.Close()
        End
    End Sub

    Private Sub DichiarazioniOnlineToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsmiGenQuote_Click(sender As Object, e As EventArgs) Handles tsmiGenQuote.Click
        Dim lg As mdsUIControls.Logging.dlgLogRtf = Nothing
        Try
            Dim F As New mdsUIControls.dlgGetInfo()

            Dim tbAnni As New DataTable
            tbAnni.Columns.Add("Anno", GetType(Integer))
            Dim ca As Integer = Date.Today.Year
            For i As Integer = ca To ca - 10 Step -1
                tbAnni.Rows.Add(New Object() {i})
            Next
            Dim itp As New mdsUIControls.dlgGetInfo.InfoType("Anno riferimento", GetType(Integer), False, ca - 1, tbAnni)

            If Not F.Apri(itp, "Esportazione prospetto quote") Then Return

            Dim anno As Integer = itp.Value

            lg = mdsUIControls.Logging.dlgLogRtf.GetInstance
            lg.ShowLog()
            lg.ClearLog()
            Trace.TraceInformation("Estrazione dati - anno " & anno)

            'Dim PathXML As String = System.IO.Path.GetTempFileName()
            Dim PathXML As String = Generale.UserApplicationFolder & "\out.xml"

            Using Conn As New System.Data.SqlClient.SqlConnection(DA.ConnectionString)

                Dim ds As New DataSet("report")
                Dim tbPar As New DataTable("parametro")
                tbPar.Columns.Add("nome")
                tbPar.Columns.Add("valore")
                tbPar.Rows.Add(New Object() {"Anno", anno})
                tbPar.Rows.Add(New Object() {"Categoria", "A"})
                tbPar.Rows.Add(New Object() {"Categoria", "B"})
                tbPar.Rows.Add(New Object() {"Categoria", "B(a)"})
                tbPar.Rows.Add(New Object() {"Categoria", "C"})
                tbPar.Rows.Add(New Object() {"Categoria", "D"})
                tbPar.Rows.Add(New Object() {"Categoria", "E"})
                ds.Tables.Add(tbPar)

                Dim tbAnalisi As New DataTable("analisi")
                Dim cmd As SqlClient.SqlCommand = Conn.CreateCommand
                cmd.CommandTimeout = 300
                cmd.CommandText = "getAnalisiQuote"
                cmd.Parameters.AddWithValue("Anno", anno)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(tbAnalisi)


                'Matricole Associazioni Cat.B: 44,52,61,325,326,339,387,398,509,638,1309,1311,1459,1537,1742
                Trace.TraceInformation("Estrazione dati associazioni utilizzatori (B)")

                Dim rrBA() As DataRow = tbAnalisi.Select("Id in(" & Generale.CommonConfig.ElencoAssociziaoniCatB & ")", "")
                For Each rwBA In rrBA
                    rwBA("CatQuota") = "B(a)"
                Next
                'Dim sql As String = "select 'B(a)' CatQuota" _
                '                    & ",az.RagioneSociale " _
                '                    & ",'' Cat1,'' Cat2,'' Altre " _
                '                    & ",0 Peso,0 Adempimento " _
                '                    & "from Azienda az " _
                '                    & "where 1 = 1 " _
                '                    & "and az.id in (" _
                '                    & Generale.CommonConfig.ElencoAssociziaoniCatB _
                '                    & ") " _
                '                    & "order by az.RagioneSociale "

                'da.SelectCommand.CommandText = sql
                'da.SelectCommand.CommandType = CommandType.Text
                'da.Fill(tbAnalisi)

                ds.Tables.Add(tbAnalisi)

                Trace.TraceInformation("Estratte " & tbAnalisi.Rows.Count & " quote")

                For Each tb As DataTable In ds.Tables
                    For Each c As DataColumn In tb.Columns
                        c.ColumnMapping = MappingType.Attribute
                    Next
                Next

                Trace.TraceInformation("Esportazione dati")
                ds.WriteXml(PathXML, XmlWriteMode.IgnoreSchema)
            End Using

            Dim PathXSL As String = My.Application.Info.DirectoryPath & "\quote.xl.xsl"
            If Not System.IO.File.Exists(PathXSL) Then Throw New Exception("File trasformazione XSLT non trovato")

            Trace.TraceInformation("Selezione file da generare")
            Dim sfd As New SaveFileDialog
            sfd.Filter = "File Excel|*.xls|File web|*.html"
            sfd.FileName = "Quote_" & anno
            sfd.OverwritePrompt = True
            If sfd.ShowDialog = vbCancel Then
                Trace.TraceError("Operazione annullata")
                Return
            End If
            Dim PathOut As String = sfd.FileName

            Trace.TraceInformation("Avvio trasformazione")
            Cursor.Current = Cursors.WaitCursor
            Dim xt As New Xml.Xsl.XslCompiledTransform(True)
            xt.Load(PathXSL)
            xt.Transform(PathXML, PathOut)

            Trace.TraceInformation("Trasformazione terminata")
            If MsgBox("Aprire il file generato ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start(PathOut)
            End If

        Catch ex As Exception
            Trace.TraceError(ex.Message)
        Finally
            Cursor.Current = Cursors.Default
            If lg IsNot Nothing Then lg.Close()
        End Try
    End Sub

    Private Sub tsmiStatQuantitativi_Click(sender As Object, e As EventArgs) Handles tsmiStatQuantitativi.Click
        Try
            Dim F As New FRicercaQuantitativi
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiCheckUpdate_Click(sender As Object, e As EventArgs) Handles tsmiCheckUpdate.Click
        Try
            Dim PathVC As String = My.Application.Info.DirectoryPath & "\UpdateChecker.exe"
            If Not System.IO.File.Exists(PathVC) Then Throw New Exception("Modulo controllo versione non trovato.")
            If MsgBox("Il controllo di versione chiuderà l'applicazione e sostituirà eventuali file aggiornati." & vbCr & "Proseguire ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

            Dim V As System.Version = My.Application.Info.Version
            Dim Version As String = V.ToString

            Dim UpdateFolder As String = System.IO.Path.GetDirectoryName(Generale.CommonConfig.UpdateFilePath)
            UpdateFolder &= "\" & String.Format("{0}.{1}.{2}.x", V.Major, V.Minor, V.Build)

            Dim Args As String = Version & " " & UpdateFolder '& " " & My.Application.Info.AssemblyName & ".exe"


            If CommonConfig.InstallUtente <> "" AndAlso CommonConfig.InstallPassword <> "" Then
                Dim pwd As New System.Security.SecureString
                For Each c As Char In CommonConfig.InstallPassword
                    pwd.AppendChar(c)
                Next
                Process.Start(PathVC, Args, CommonConfig.InstallUtente, pwd, CommonConfig.InstallDomain)
            Else
                Process.Start(PathVC, Args)
            End If

            tsbExit.PerformClick()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiEventi_Click(sender As Object, e As EventArgs) Handles tsmiEventi.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Eventi", DAL.Lookups.Eventi)
            DAL.Lookups.ResetCollection("Eventi")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ElencoNotificheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoNotificheToolStripMenuItem.Click
        Try
            CheckEventiNotifiche()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub CodiciCERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodiciCERToolStripMenuItem.Click
        Try
            DAL.Managers.UtentiManager.CheckLoggedUserRole(DAL.Enums.Ruolo.DIREZIONE)
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Codici CER", DAL.Lookups.CodiciCER)
            DAL.Lookups.ResetCollection("CodiciCER")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub AcquisciAllegatiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DichiarazioniOnlineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DichiarazioniOnlineToolStripMenuItem1.Click
        Try
            Dim F As New FElencoDOL
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub AcquisizioneAllegatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcquisizioneAllegatiToolStripMenuItem.Click
        Try
            Dim F As New DichiarazioneOnLine.dlgAcquisisciAllegato
            F.OpenAziendaAction = Sub(x As AziendaEntity)
                                      Dim Faz As New FAzienda
                                      Faz.Apri(x)
                                  End Sub
            F.Apri()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ElencoDichiarazioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoDichiarazioniToolStripMenuItem.Click
        Try
            Dim F As New FElencoDichiarazioni
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AcquisisciFileAdesioniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcquisisciFileAdesioniToolStripMenuItem.Click
        Try
            Dim F As New dlgAcquisisciAdesione
            F.Apri()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AcquisisciFileAllegatiAnnualiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcquisisciFileAllegatiAnnualiToolStripMenuItem.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "File Excel|*.xls;*.xlsx"
            If ofd.ShowDialog = DialogResult.Cancel Then Return
            Dim FileName As String = ofd.FileName

            Dim fi As New clsAllegatiAnniPrecedentiImporter

            Dim Cat As String = InputBox("Categoria: ", "")
            If Cat = "" Then Return
            If Cat <> "B" And Cat <> "C" And Cat <> "E" Then Throw New Exception("Categoria non valida")
            fi.AcquisisciFileAllegati(FileName, Cat)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub



End Class
