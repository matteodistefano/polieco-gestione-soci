Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports DAL.EntityClasses
Imports DAL.HelperClasses
Imports DAL.Managers
Imports System.Data.SqlClient

Public Class FMain

    Private Sub mbUscita_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mbUscita.Click
        If My.Application.OpenForms.Count > 1 Then
            If MsgBox("Chiudere l'applicazione ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        End If
        Me.Close()
        End
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
        Me.tsslCopyright.Text = "Ing. Matteo Di Stefano - 2011-2014"
        InitUISecurity()

        If Generale.UserConfig.NotificaNuoviSociScaduti Then CheckNotifiche()


    End Sub
    Private Sub InitUISecurity()
        mbAmministrazione.Enabled = UtentiManager.IsLoggedUserSegreteria
        'mbImportazioni.Enabled = UtentiManager.IsLoggedUserSereteria
        'mbStatistiche.Enabled = UtentiManager.IsLoggedUserSereteria
        tsmiUtenti.Enabled = UtentiManager.IsLoggedUserAdmin
    End Sub

    Private Sub CheckNotifiche()
        Try
            Dim NNG As Integer = CommonConfig.NumeroGiorniStato_NUOVO

            Dim F As New mdsUIControls.FVisData
            F.OnLoadData = Function() DAL.Managers.SociManager.GetNuoviSociInScadenza(NNG)

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

    Private Sub FMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        mdsUtility.WindowsForms.CenterControlInParent(tlpMain)
    End Sub

    Private Sub mbEBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbSoci.Click
        FElencoSoci.Apri(Me)
    End Sub

    Private Sub mbAttivita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbEsportazioni.Click
        MsgBox("Non implementato")
    End Sub

    Private Sub tsmiParametri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiParametri.Click
        Try
            Dim F As New mdsConfig.dlgImpostazioni
            F.Apri(UserConfig, IIf(UtentiManager.IsLoggedUserAdmin, CommonConfig, Nothing))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
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
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Regioni", DAL.Lookups.Regioni, Nothing)
            DAL.Lookups.ResetCollection("Regioni")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ProvinceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProvinceToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Province", DAL.Lookups.Province, Nothing)
            DAL.Lookups.ResetCollection("Province")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ComuniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComuniToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Comuni", DAL.Lookups.Comuni, Nothing)
            DAL.Lookups.ResetCollection("Comuni")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiUtenti_Click(sender As System.Object, e As System.EventArgs) Handles tsmiUtenti.Click
        Try
            Dim F As New FManagerUtenti
            F.Apri()
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

    Private Sub GestioneMaterialiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestioneMaterialiToolStripMenuItem.Click
        Try
            Dim F As New FElencoMateriali
            F.Apri()
            DAL.Lookups.ResetCollection("Materiali")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub GestioneQuadriDichiarazioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestioneQuadriDichiarazioneToolStripMenuItem.Click
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
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Categorie", DAL.Lookups.Categorie, Nothing)
            DAL.Lookups.ResetCollection("Categorie")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub FormeGiuridicheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormeGiuridicheToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Forme Giuridiche", DAL.Lookups.FormeGiuridiche, Nothing)
            DAL.Lookups.ResetCollection("FormeGiuridiche")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiSociToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiSociToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi Socio", DAL.Lookups.TipiSocio, Nothing)
            DAL.Lookups.ResetCollection("TipiSocio")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub StatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatoToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Stati Socio", DAL.Lookups.StatiSocio, Nothing)
            DAL.Lookups.ResetCollection("StatiSocio")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub InfoStatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoStatoToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Info Stati Socio", DAL.Lookups.InfoStati, Nothing)
            DAL.Lookups.ResetCollection("InfoStati")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub RuoliContattoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuoliContattoToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Ruoli contatto", DAL.Lookups.RuoliContatto, Nothing)
            DAL.Lookups.ResetCollection("RuoliContatto")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TitoliContattoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoliContattoToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Titoli contatto", DAL.Lookups.TitoliContatto, Nothing)
            DAL.Lookups.ResetCollection("TitoliContatto")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub



    Private Sub TipiAttivitàToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiAttivitàToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi attività", DAL.Lookups.TipiAttivita, Nothing)
            DAL.Lookups.ResetCollection("TipiAttivita")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiAttrezzatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiAttrezzatureToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi attrezzatura", DAL.Lookups.TipiAttrezzatura, Nothing)
            DAL.Lookups.ResetCollection("TipiAttrezzatura")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiQuadroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiQuadroToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi quadro", DAL.Lookups.TipiQuadro, Nothing)
            DAL.Lookups.ResetCollection("TipiQuadro")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub TipiMaterialeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiMaterialeToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi materiale", DAL.Lookups.TipiMateriale, Nothing)
            DAL.Lookups.ResetCollection("TipiMateriale")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub UnitaDiMisuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitaDiMisuraToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Unita di misura", DAL.Lookups.UnitaMisura, Nothing)
            DAL.Lookups.ResetCollection("UnitaMisura")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiLicenzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiLicenzeToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi licenza", DAL.Lookups.TipiLicenza, Nothing)
            DAL.Lookups.ResetCollection("TipiLicenza")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TipiSedeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipiSedeToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Tipi sede", DAL.Lookups.TipiSede, Nothing)
            DAL.Lookups.ResetCollection("TipiSede")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub QuoteAdesioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuoteAdesioneToolStripMenuItem.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Quote di adesione", DAL.Lookups.QuoteAdesione, Nothing)
            DAL.Lookups.ResetCollection("QuoteAdesione")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiModPagamento_Click(sender As Object, e As EventArgs) Handles tsmiModPagamento.Click
        Try
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Modalità pagamento", DAL.Lookups.ModalitaPagamento, Nothing)
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
            Dim F As New mdsLLBLGenUtility.Adapter.FTabelleEditorAD
            F.Apri("Aliquote IVA", DAL.Lookups.AliquoteIVA, Nothing)
            DAL.Lookups.ResetCollection("AliquoteIVA")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub pnlMain_DoubleClick(sender As Object, e As EventArgs) Handles pnlMain.DoubleClick
        mbSoci.UpdateLayout()
    End Sub

    
    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim f As New dlgProfilaDocumento
            Dim p As New Dictionary(Of String, String)
            p.Add("docname", "ccccc")
            p.Add("datadoc", "01/11/2011")
            p.Add("numero", "123")
            p.Add("#-competenza_dichiarazione", "aaaa-11")
            Dim r As Integer? = f.ProfileFor("3,1821", p)
            If r.HasValue Then
                MsgBox("Documento profilato:" & r.Value)
            End If
            'f.Nuovo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tsmiNotificheNuoviSoci_Click(sender As Object, e As EventArgs) Handles tsmiNotificheNuoviSoci.Click
        CheckNotifiche()
    End Sub

End Class
