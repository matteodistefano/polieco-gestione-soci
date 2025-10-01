<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMain))
        Me.sStrip = New System.Windows.Forms.StatusStrip()
        Me.tsslApp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCopyright = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmAdmin = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiUtenti = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiScadenze = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestioneMaterialiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestioneQuadriDichiarazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiComuni = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComuniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormeGiuridicheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TipiSociToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoStatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RuoliContattoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitoliContattoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiGestIncassi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModPagamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAliquoteIVA = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiQuadroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuoteAdesioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGestAttivita = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiAttivitàToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiAttrezzatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiLicenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiSedeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipiMaterialeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitaDiMisuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatiProvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiParametri = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmStatistiche = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiStatAziende = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmImport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmCDA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAssCDA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiPassCDA = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPassAss = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibroSociToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.cmNotifiche = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiNotificheNuoviSoci = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbStatistiche = New System.Windows.Forms.ToolStripButton()
        Me.tsbNotifiche = New System.Windows.Forms.ToolStripButton()
        Me.tsbAmministrazione = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.mbUscita = New mdsUIControls.ucMainButton()
        Me.mbNotifiche = New mdsUIControls.ucMainButton()
        Me.mbCDAAss = New mdsUIControls.ucMainButton()
        Me.mbSoci = New mdsUIControls.ucMainButton()
        Me.mbAmministrazione = New mdsUIControls.ucMainButton()
        Me.mbEsportazioni = New mdsUIControls.ucMainButton()
        Me.mbStatistiche = New mdsUIControls.ucMainButton()
        Me.mbConfigurazione = New mdsUIControls.ucMainButton()
        Me.tsbCDAAss = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sStrip.SuspendLayout()
        Me.cmAdmin.SuspendLayout()
        Me.cmSettings.SuspendLayout()
        Me.cmStatistiche.SuspendLayout()
        Me.cmCDA.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.cmNotifiche.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'sStrip
        '
        Me.sStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslApp, Me.tsslCopyright})
        Me.sStrip.Location = New System.Drawing.Point(0, 637)
        Me.sStrip.Name = "sStrip"
        Me.sStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.sStrip.Size = New System.Drawing.Size(1051, 25)
        Me.sStrip.TabIndex = 6
        Me.sStrip.Text = "StatusStrip1"
        '
        'tsslApp
        '
        Me.tsslApp.Name = "tsslApp"
        Me.tsslApp.Size = New System.Drawing.Size(877, 20)
        Me.tsslApp.Spring = True
        Me.tsslApp.Text = "ToolStripStatusLabel1"
        Me.tsslApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsslCopyright
        '
        Me.tsslCopyright.Name = "tsslCopyright"
        Me.tsslCopyright.Size = New System.Drawing.Size(154, 20)
        Me.tsslCopyright.Text = "ToolStripStatusLabel2"
        '
        'cmAdmin
        '
        Me.cmAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmAdmin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUtenti, Me.tsmiScadenze, Me.GestioneMaterialiToolStripMenuItem, Me.GestioneQuadriDichiarazioneToolStripMenuItem, Me.ToolStripMenuItem4, Me.tsmiComuni, Me.ToolStripSeparator4, Me.TabelleToolStripMenuItem, Me.DatiProvaToolStripMenuItem})
        Me.cmAdmin.Name = "cmAdmin"
        Me.cmAdmin.ShowImageMargin = False
        Me.cmAdmin.Size = New System.Drawing.Size(282, 268)
        '
        'tsmiUtenti
        '
        Me.tsmiUtenti.ForeColor = System.Drawing.Color.Navy
        Me.tsmiUtenti.Name = "tsmiUtenti"
        Me.tsmiUtenti.Size = New System.Drawing.Size(281, 36)
        Me.tsmiUtenti.Text = "Utenti"
        '
        'tsmiScadenze
        '
        Me.tsmiScadenze.ForeColor = System.Drawing.Color.Navy
        Me.tsmiScadenze.Name = "tsmiScadenze"
        Me.tsmiScadenze.Size = New System.Drawing.Size(281, 36)
        Me.tsmiScadenze.Text = "Scadenze"
        '
        'GestioneMaterialiToolStripMenuItem
        '
        Me.GestioneMaterialiToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.GestioneMaterialiToolStripMenuItem.Name = "GestioneMaterialiToolStripMenuItem"
        Me.GestioneMaterialiToolStripMenuItem.Size = New System.Drawing.Size(281, 36)
        Me.GestioneMaterialiToolStripMenuItem.Text = "Materiali"
        '
        'GestioneQuadriDichiarazioneToolStripMenuItem
        '
        Me.GestioneQuadriDichiarazioneToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.GestioneQuadriDichiarazioneToolStripMenuItem.Name = "GestioneQuadriDichiarazioneToolStripMenuItem"
        Me.GestioneQuadriDichiarazioneToolStripMenuItem.Size = New System.Drawing.Size(281, 36)
        Me.GestioneQuadriDichiarazioneToolStripMenuItem.Text = "Quadri Dichiarazioni"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(278, 6)
        '
        'tsmiComuni
        '
        Me.tsmiComuni.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegioniToolStripMenuItem, Me.ProvinceToolStripMenuItem, Me.ComuniToolStripMenuItem})
        Me.tsmiComuni.ForeColor = System.Drawing.Color.Navy
        Me.tsmiComuni.Name = "tsmiComuni"
        Me.tsmiComuni.Size = New System.Drawing.Size(281, 36)
        Me.tsmiComuni.Text = "Comuni e stradario"
        '
        'RegioniToolStripMenuItem
        '
        Me.RegioniToolStripMenuItem.Name = "RegioniToolStripMenuItem"
        Me.RegioniToolStripMenuItem.Size = New System.Drawing.Size(181, 36)
        Me.RegioniToolStripMenuItem.Text = "Regioni"
        '
        'ProvinceToolStripMenuItem
        '
        Me.ProvinceToolStripMenuItem.Name = "ProvinceToolStripMenuItem"
        Me.ProvinceToolStripMenuItem.Size = New System.Drawing.Size(181, 36)
        Me.ProvinceToolStripMenuItem.Text = "Province"
        '
        'ComuniToolStripMenuItem
        '
        Me.ComuniToolStripMenuItem.Name = "ComuniToolStripMenuItem"
        Me.ComuniToolStripMenuItem.Size = New System.Drawing.Size(181, 36)
        Me.ComuniToolStripMenuItem.Text = "Comuni"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(278, 6)
        '
        'TabelleToolStripMenuItem
        '
        Me.TabelleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategorieToolStripMenuItem, Me.FormeGiuridicheToolStripMenuItem, Me.ToolStripMenuItem1, Me.TipiSociToolStripMenuItem, Me.StatoToolStripMenuItem, Me.InfoStatoToolStripMenuItem, Me.ToolStripMenuItem2, Me.RuoliContattoToolStripMenuItem, Me.TitoliContattoToolStripMenuItem, Me.ToolStripMenuItem3, Me.tsmiGestIncassi, Me.tsmiGestAttivita})
        Me.TabelleToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.TabelleToolStripMenuItem.Name = "TabelleToolStripMenuItem"
        Me.TabelleToolStripMenuItem.Size = New System.Drawing.Size(281, 36)
        Me.TabelleToolStripMenuItem.Text = "Tabelle"
        '
        'CategorieToolStripMenuItem
        '
        Me.CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        Me.CategorieToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.CategorieToolStripMenuItem.Text = "Categorie"
        '
        'FormeGiuridicheToolStripMenuItem
        '
        Me.FormeGiuridicheToolStripMenuItem.Name = "FormeGiuridicheToolStripMenuItem"
        Me.FormeGiuridicheToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.FormeGiuridicheToolStripMenuItem.Text = "Forme giuridiche"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(268, 6)
        '
        'TipiSociToolStripMenuItem
        '
        Me.TipiSociToolStripMenuItem.Name = "TipiSociToolStripMenuItem"
        Me.TipiSociToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.TipiSociToolStripMenuItem.Text = "Tipi soci"
        '
        'StatoToolStripMenuItem
        '
        Me.StatoToolStripMenuItem.Name = "StatoToolStripMenuItem"
        Me.StatoToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.StatoToolStripMenuItem.Text = "Stato"
        '
        'InfoStatoToolStripMenuItem
        '
        Me.InfoStatoToolStripMenuItem.Name = "InfoStatoToolStripMenuItem"
        Me.InfoStatoToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.InfoStatoToolStripMenuItem.Text = "Info Stato"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(268, 6)
        '
        'RuoliContattoToolStripMenuItem
        '
        Me.RuoliContattoToolStripMenuItem.Name = "RuoliContattoToolStripMenuItem"
        Me.RuoliContattoToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.RuoliContattoToolStripMenuItem.Text = "Ruoli contatto"
        '
        'TitoliContattoToolStripMenuItem
        '
        Me.TitoliContattoToolStripMenuItem.Name = "TitoliContattoToolStripMenuItem"
        Me.TitoliContattoToolStripMenuItem.Size = New System.Drawing.Size(271, 36)
        Me.TitoliContattoToolStripMenuItem.Text = "Titoli contatto"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(268, 6)
        '
        'tsmiGestIncassi
        '
        Me.tsmiGestIncassi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiModPagamento, Me.tsmiAliquoteIVA, Me.TipiQuadroToolStripMenuItem, Me.QuoteAdesioneToolStripMenuItem})
        Me.tsmiGestIncassi.Name = "tsmiGestIncassi"
        Me.tsmiGestIncassi.Size = New System.Drawing.Size(271, 36)
        Me.tsmiGestIncassi.Text = "Gestione incassi"
        '
        'tsmiModPagamento
        '
        Me.tsmiModPagamento.Name = "tsmiModPagamento"
        Me.tsmiModPagamento.Size = New System.Drawing.Size(313, 36)
        Me.tsmiModPagamento.Text = "Modalità pagamento"
        '
        'tsmiAliquoteIVA
        '
        Me.tsmiAliquoteIVA.Name = "tsmiAliquoteIVA"
        Me.tsmiAliquoteIVA.Size = New System.Drawing.Size(313, 36)
        Me.tsmiAliquoteIVA.Text = "Aliquote IVA"
        '
        'TipiQuadroToolStripMenuItem
        '
        Me.TipiQuadroToolStripMenuItem.Name = "TipiQuadroToolStripMenuItem"
        Me.TipiQuadroToolStripMenuItem.Size = New System.Drawing.Size(313, 36)
        Me.TipiQuadroToolStripMenuItem.Text = "Tipi quadro"
        '
        'QuoteAdesioneToolStripMenuItem
        '
        Me.QuoteAdesioneToolStripMenuItem.Name = "QuoteAdesioneToolStripMenuItem"
        Me.QuoteAdesioneToolStripMenuItem.Size = New System.Drawing.Size(313, 36)
        Me.QuoteAdesioneToolStripMenuItem.Text = "Quote di adesione"
        '
        'tsmiGestAttivita
        '
        Me.tsmiGestAttivita.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipiAttivitàToolStripMenuItem, Me.TipiAttrezzatureToolStripMenuItem, Me.TipiLicenzeToolStripMenuItem, Me.TipiSedeToolStripMenuItem, Me.TipiMaterialeToolStripMenuItem, Me.UnitaDiMisuraToolStripMenuItem})
        Me.tsmiGestAttivita.Name = "tsmiGestAttivita"
        Me.tsmiGestAttivita.Size = New System.Drawing.Size(271, 36)
        Me.tsmiGestAttivita.Text = "Gestione attività"
        '
        'TipiAttivitàToolStripMenuItem
        '
        Me.TipiAttivitàToolStripMenuItem.Name = "TipiAttivitàToolStripMenuItem"
        Me.TipiAttivitàToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.TipiAttivitàToolStripMenuItem.Text = "Tipi attività"
        '
        'TipiAttrezzatureToolStripMenuItem
        '
        Me.TipiAttrezzatureToolStripMenuItem.Name = "TipiAttrezzatureToolStripMenuItem"
        Me.TipiAttrezzatureToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.TipiAttrezzatureToolStripMenuItem.Text = "Tipi attrezzature"
        '
        'TipiLicenzeToolStripMenuItem
        '
        Me.TipiLicenzeToolStripMenuItem.Name = "TipiLicenzeToolStripMenuItem"
        Me.TipiLicenzeToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.TipiLicenzeToolStripMenuItem.Text = "Tipi licenza"
        '
        'TipiSedeToolStripMenuItem
        '
        Me.TipiSedeToolStripMenuItem.Name = "TipiSedeToolStripMenuItem"
        Me.TipiSedeToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.TipiSedeToolStripMenuItem.Text = "Tipi sede"
        '
        'TipiMaterialeToolStripMenuItem
        '
        Me.TipiMaterialeToolStripMenuItem.Name = "TipiMaterialeToolStripMenuItem"
        Me.TipiMaterialeToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.TipiMaterialeToolStripMenuItem.Text = "Tipi Materiale"
        '
        'UnitaDiMisuraToolStripMenuItem
        '
        Me.UnitaDiMisuraToolStripMenuItem.Name = "UnitaDiMisuraToolStripMenuItem"
        Me.UnitaDiMisuraToolStripMenuItem.Size = New System.Drawing.Size(262, 36)
        Me.UnitaDiMisuraToolStripMenuItem.Text = "Unita di misura"
        '
        'DatiProvaToolStripMenuItem
        '
        Me.DatiProvaToolStripMenuItem.Name = "DatiProvaToolStripMenuItem"
        Me.DatiProvaToolStripMenuItem.Size = New System.Drawing.Size(281, 36)
        Me.DatiProvaToolStripMenuItem.Text = "Dati prova e utility"
        Me.DatiProvaToolStripMenuItem.Visible = False
        '
        'cmSettings
        '
        Me.cmSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmSettings.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiParametri, Me.ToolStripSeparator2})
        Me.cmSettings.Name = "cmAdmin"
        Me.cmSettings.ShowImageMargin = False
        Me.cmSettings.Size = New System.Drawing.Size(167, 46)
        '
        'tsmiParametri
        '
        Me.tsmiParametri.ForeColor = System.Drawing.Color.Navy
        Me.tsmiParametri.Name = "tsmiParametri"
        Me.tsmiParametri.Size = New System.Drawing.Size(166, 36)
        Me.tsmiParametri.Text = "Parametri"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'cmStatistiche
        '
        Me.cmStatistiche.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmStatistiche.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmStatistiche.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiStatAziende})
        Me.cmStatistiche.Name = "cmAdmin"
        Me.cmStatistiche.ShowImageMargin = False
        Me.cmStatistiche.Size = New System.Drawing.Size(159, 40)
        '
        'tsmiStatAziende
        '
        Me.tsmiStatAziende.ForeColor = System.Drawing.Color.Navy
        Me.tsmiStatAziende.Name = "tsmiStatAziende"
        Me.tsmiStatAziende.Size = New System.Drawing.Size(158, 36)
        Me.tsmiStatAziende.Text = "Aziende "
        '
        'cmImport
        '
        Me.cmImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmImport.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmImport.Name = "cmAdmin"
        Me.cmImport.ShowImageMargin = False
        Me.cmImport.Size = New System.Drawing.Size(36, 4)
        '
        'cmCDA
        '
        Me.cmCDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmCDA.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmCDA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAssCDA, Me.ToolStripMenuItem5, Me.tsmiPassCDA, Me.tsmiPassAss, Me.ToolStripMenuItem6, Me.LibroSociToolStripMenuItem})
        Me.cmCDA.Name = "cmCDA"
        Me.cmCDA.Size = New System.Drawing.Size(317, 160)
        '
        'tsmiAssCDA
        '
        Me.tsmiAssCDA.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.tsmiAssCDA.ForeColor = System.Drawing.Color.Navy
        Me.tsmiAssCDA.Name = "tsmiAssCDA"
        Me.tsmiAssCDA.Size = New System.Drawing.Size(316, 36)
        Me.tsmiAssCDA.Text = "Riunioni"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(313, 6)
        '
        'tsmiPassCDA
        '
        Me.tsmiPassCDA.ForeColor = System.Drawing.Color.Navy
        Me.tsmiPassCDA.Name = "tsmiPassCDA"
        Me.tsmiPassCDA.Size = New System.Drawing.Size(316, 36)
        Me.tsmiPassCDA.Text = "Passaggio CDA"
        '
        'tsmiPassAss
        '
        Me.tsmiPassAss.ForeColor = System.Drawing.Color.Navy
        Me.tsmiPassAss.Name = "tsmiPassAss"
        Me.tsmiPassAss.Size = New System.Drawing.Size(316, 36)
        Me.tsmiPassAss.Text = "Passaggio Assemblea"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(313, 6)
        '
        'LibroSociToolStripMenuItem
        '
        Me.LibroSociToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.LibroSociToolStripMenuItem.Name = "LibroSociToolStripMenuItem"
        Me.LibroSociToolStripMenuItem.Size = New System.Drawing.Size(316, 36)
        Me.LibroSociToolStripMenuItem.Text = "Libro soci"
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.tlpMain.Controls.Add(Me.mbUscita, 1, 3)
        Me.tlpMain.Controls.Add(Me.mbNotifiche, 0, 1)
        Me.tlpMain.Controls.Add(Me.mbCDAAss, 1, 0)
        Me.tlpMain.Controls.Add(Me.mbSoci, 0, 0)
        Me.tlpMain.Controls.Add(Me.mbAmministrazione, 1, 2)
        Me.tlpMain.Controls.Add(Me.mbEsportazioni, 0, 2)
        Me.tlpMain.Controls.Add(Me.mbStatistiche, 1, 1)
        Me.tlpMain.Controls.Add(Me.mbConfigurazione, 0, 3)
        Me.tlpMain.Location = New System.Drawing.Point(249, 156)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(653, 586)
        Me.tlpMain.TabIndex = 8
        '
        'cmNotifiche
        '
        Me.cmNotifiche.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmNotifiche.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmNotifiche.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNotificheNuoviSoci})
        Me.cmNotifiche.Name = "cmAdmin"
        Me.cmNotifiche.ShowImageMargin = False
        Me.cmNotifiche.Size = New System.Drawing.Size(260, 40)
        '
        'tsmiNotificheNuoviSoci
        '
        Me.tsmiNotificheNuoviSoci.Name = "tsmiNotificheNuoviSoci"
        Me.tsmiNotificheNuoviSoci.Size = New System.Drawing.Size(259, 36)
        Me.tsmiNotificheNuoviSoci.Text = "Verifica nuovi soci"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.tsMain)
        Me.pnlMain.Controls.Add(Me.Button1)
        Me.pnlMain.Controls.Add(Me.tlpMain)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1051, 637)
        Me.pnlMain.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 52)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.tsbCDAAss, Me.tsbStatistiche, Me.tsbNotifiche, Me.tsbAmministrazione, Me.tsbExit})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1051, 111)
        Me.tsMain.TabIndex = 10
        Me.tsMain.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.PoliecoSoci.My.Resources.Resources.Office_Block_48_n_g
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(115, 108)
        Me.ToolStripButton1.Text = "Gestione soci"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbStatistiche
        '
        Me.tsbStatistiche.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbStatistiche.Image = Global.PoliecoSoci.My.Resources.Resources.Charts_and_Graphs_48_n_g
        Me.tsbStatistiche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStatistiche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStatistiche.Name = "tsbStatistiche"
        Me.tsbStatistiche.Size = New System.Drawing.Size(92, 108)
        Me.tsbStatistiche.Text = "Statistiche"
        Me.tsbStatistiche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbNotifiche
        '
        Me.tsbNotifiche.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNotifiche.Image = Global.PoliecoSoci.My.Resources.Resources.alert_icon
        Me.tsbNotifiche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNotifiche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNotifiche.Name = "tsbNotifiche"
        Me.tsbNotifiche.Size = New System.Drawing.Size(153, 108)
        Me.tsbNotifiche.Text = "CDA && Assemblee"
        Me.tsbNotifiche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbAmministrazione
        '
        Me.tsbAmministrazione.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbAmministrazione.Image = Global.PoliecoSoci.My.Resources.Resources.View_Details_48_n_g
        Me.tsbAmministrazione.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAmministrazione.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAmministrazione.Name = "tsbAmministrazione"
        Me.tsbAmministrazione.Size = New System.Drawing.Size(142, 108)
        Me.tsbAmministrazione.Text = "Amministrazione"
        Me.tsbAmministrazione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Close_X_Red_48_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(60, 108)
        Me.tsbExit.Text = "Uscita"
        Me.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mbUscita
        '
        Me.mbUscita.BackColor = System.Drawing.Color.Transparent
        Me.mbUscita.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbUscita.BorderWidth = 2
        Me.mbUscita.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbUscita.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Left
        Me.mbUscita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbUscita.Descrizione = "Gestione anagrafica soci"
        Me.mbUscita.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbUscita.Immagine = Global.PoliecoSoci.My.Resources.Resources.Office_Block_48_n_g
        Me.mbUscita.Location = New System.Drawing.Point(331, 449)
        Me.mbUscita.Margin = New System.Windows.Forms.Padding(5)
        Me.mbUscita.Name = "mbUscita"
        Me.mbUscita.Size = New System.Drawing.Size(315, 130)
        Me.mbUscita.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbUscita.TabIndex = 10
        Me.mbUscita.Testo = "Gestione Soci"
        Me.mbUscita.TitleColor = System.Drawing.Color.Blue
        '
        'mbNotifiche
        '
        Me.mbNotifiche.BackColor = System.Drawing.Color.Transparent
        Me.mbNotifiche.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbNotifiche.BorderWidth = 2
        Me.mbNotifiche.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbNotifiche.ContextMenuStrip = Me.cmNotifiche
        Me.mbNotifiche.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Left
        Me.mbNotifiche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbNotifiche.Descrizione = "Analisi, controlli e notifiche"
        Me.mbNotifiche.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbNotifiche.Immagine = Global.PoliecoSoci.My.Resources.Resources.alert_icon
        Me.mbNotifiche.Location = New System.Drawing.Point(5, 153)
        Me.mbNotifiche.Margin = New System.Windows.Forms.Padding(5)
        Me.mbNotifiche.Name = "mbNotifiche"
        Me.mbNotifiche.Size = New System.Drawing.Size(316, 130)
        Me.mbNotifiche.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbNotifiche.TabIndex = 9
        Me.mbNotifiche.Testo = "Notifiche"
        Me.mbNotifiche.TitleColor = System.Drawing.Color.Blue
        '
        'mbCDAAss
        '
        Me.mbCDAAss.BackColor = System.Drawing.Color.Transparent
        Me.mbCDAAss.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbCDAAss.BorderWidth = 2
        Me.mbCDAAss.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbCDAAss.ContextMenuStrip = Me.cmCDA
        Me.mbCDAAss.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Right
        Me.mbCDAAss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbCDAAss.Descrizione = "Creazione e gestione passaggi associati, esportazione libro soci"
        Me.mbCDAAss.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbCDAAss.Immagine = CType(resources.GetObject("mbCDAAss.Immagine"), System.Drawing.Image)
        Me.mbCDAAss.Location = New System.Drawing.Point(331, 5)
        Me.mbCDAAss.Margin = New System.Windows.Forms.Padding(5)
        Me.mbCDAAss.Name = "mbCDAAss"
        Me.mbCDAAss.Size = New System.Drawing.Size(317, 130)
        Me.mbCDAAss.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbCDAAss.TabIndex = 9
        Me.mbCDAAss.Testo = "CDA && Assemblee"
        Me.mbCDAAss.TitleColor = System.Drawing.Color.Blue
        '
        'mbSoci
        '
        Me.mbSoci.BackColor = System.Drawing.Color.Transparent
        Me.mbSoci.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbSoci.BorderWidth = 2
        Me.mbSoci.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbSoci.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Left
        Me.mbSoci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbSoci.Descrizione = "Gestione anagrafica soci"
        Me.mbSoci.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbSoci.Immagine = Global.PoliecoSoci.My.Resources.Resources.Office_Block_48_n_g
        Me.mbSoci.Location = New System.Drawing.Point(5, 5)
        Me.mbSoci.Margin = New System.Windows.Forms.Padding(5)
        Me.mbSoci.Name = "mbSoci"
        Me.mbSoci.Size = New System.Drawing.Size(315, 130)
        Me.mbSoci.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbSoci.TabIndex = 0
        Me.mbSoci.Testo = "Gestione Soci"
        Me.mbSoci.TitleColor = System.Drawing.Color.Blue
        '
        'mbAmministrazione
        '
        Me.mbAmministrazione.BackColor = System.Drawing.Color.Transparent
        Me.mbAmministrazione.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbAmministrazione.BorderWidth = 2
        Me.mbAmministrazione.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbAmministrazione.ContextMenuStrip = Me.cmAdmin
        Me.mbAmministrazione.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Right
        Me.mbAmministrazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbAmministrazione.Descrizione = "Altre anagrafiche, gestione utenti e sicurezza"
        Me.mbAmministrazione.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbAmministrazione.Immagine = CType(resources.GetObject("mbAmministrazione.Immagine"), System.Drawing.Image)
        Me.mbAmministrazione.Location = New System.Drawing.Point(331, 301)
        Me.mbAmministrazione.Margin = New System.Windows.Forms.Padding(5)
        Me.mbAmministrazione.Name = "mbAmministrazione"
        Me.mbAmministrazione.Size = New System.Drawing.Size(317, 130)
        Me.mbAmministrazione.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbAmministrazione.TabIndex = 2
        Me.mbAmministrazione.Testo = "Amministrazione"
        Me.mbAmministrazione.TitleColor = System.Drawing.Color.Blue
        '
        'mbEsportazioni
        '
        Me.mbEsportazioni.BackColor = System.Drawing.Color.Transparent
        Me.mbEsportazioni.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbEsportazioni.BorderWidth = 2
        Me.mbEsportazioni.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbEsportazioni.ContextMenuStrip = Me.cmImport
        Me.mbEsportazioni.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Left
        Me.mbEsportazioni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbEsportazioni.Descrizione = "Importazione dati"
        Me.mbEsportazioni.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbEsportazioni.Immagine = CType(resources.GetObject("mbEsportazioni.Immagine"), System.Drawing.Image)
        Me.mbEsportazioni.Location = New System.Drawing.Point(5, 301)
        Me.mbEsportazioni.Margin = New System.Windows.Forms.Padding(5)
        Me.mbEsportazioni.Name = "mbEsportazioni"
        Me.mbEsportazioni.Size = New System.Drawing.Size(316, 130)
        Me.mbEsportazioni.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbEsportazioni.TabIndex = 1
        Me.mbEsportazioni.Testo = "Esportazione flussi"
        Me.mbEsportazioni.TitleColor = System.Drawing.Color.Blue
        '
        'mbStatistiche
        '
        Me.mbStatistiche.BackColor = System.Drawing.Color.Transparent
        Me.mbStatistiche.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbStatistiche.BorderWidth = 2
        Me.mbStatistiche.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbStatistiche.ContextMenuStrip = Me.cmStatistiche
        Me.mbStatistiche.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Right
        Me.mbStatistiche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbStatistiche.Descrizione = "Report, grafici e statistiche"
        Me.mbStatistiche.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbStatistiche.Immagine = CType(resources.GetObject("mbStatistiche.Immagine"), System.Drawing.Image)
        Me.mbStatistiche.Location = New System.Drawing.Point(331, 153)
        Me.mbStatistiche.Margin = New System.Windows.Forms.Padding(5)
        Me.mbStatistiche.Name = "mbStatistiche"
        Me.mbStatistiche.Size = New System.Drawing.Size(317, 130)
        Me.mbStatistiche.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbStatistiche.TabIndex = 3
        Me.mbStatistiche.Testo = "Reports  && Statistiche"
        Me.mbStatistiche.TitleColor = System.Drawing.Color.Blue
        '
        'mbConfigurazione
        '
        Me.mbConfigurazione.BackColor = System.Drawing.Color.Transparent
        Me.mbConfigurazione.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbConfigurazione.BorderWidth = 2
        Me.mbConfigurazione.ClickColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mbConfigurazione.ContextMenuStrip = Me.cmSettings
        Me.mbConfigurazione.ContextMenuStripDirection = mdsUIControls.ucMainButton.SideMenuEnum.Left
        Me.mbConfigurazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbConfigurazione.Descrizione = "Configurazione, parametri generali"
        Me.mbConfigurazione.HighLightColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mbConfigurazione.Immagine = CType(resources.GetObject("mbConfigurazione.Immagine"), System.Drawing.Image)
        Me.mbConfigurazione.Location = New System.Drawing.Point(5, 449)
        Me.mbConfigurazione.Margin = New System.Windows.Forms.Padding(5)
        Me.mbConfigurazione.Name = "mbConfigurazione"
        Me.mbConfigurazione.Size = New System.Drawing.Size(316, 130)
        Me.mbConfigurazione.SubTitleColor = System.Drawing.SystemColors.ControlText
        Me.mbConfigurazione.TabIndex = 4
        Me.mbConfigurazione.Testo = "Impostazioni"
        Me.mbConfigurazione.TitleColor = System.Drawing.Color.Blue
        '
        'tsbCDAAss
        '
        Me.tsbCDAAss.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCDAAss.Image = Global.PoliecoSoci.My.Resources.Resources.AssembleaTrasp
        Me.tsbCDAAss.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCDAAss.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCDAAss.Name = "tsbCDAAss"
        Me.tsbCDAAss.Size = New System.Drawing.Size(162, 108)
        Me.tsbCDAAss.Text = "CDA && Assemblee"
        Me.tsbCDAAss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 662)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.sStrip)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione soci - Polieco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sStrip.ResumeLayout(False)
        Me.sStrip.PerformLayout()
        Me.cmAdmin.ResumeLayout(False)
        Me.cmSettings.ResumeLayout(False)
        Me.cmStatistiche.ResumeLayout(False)
        Me.cmCDA.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.cmNotifiche.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents cmAdmin As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiUtenti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiComuni As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsslApp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslCopyright As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmStatistiche As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiStatAziende As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmSettings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiParametri As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatiProvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComuniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmImport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TabelleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormeGiuridicheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoStatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RuoliContattoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiAttivitàToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiAttrezzatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiModPagamento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiLicenzeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiSedeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiSociToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitoliContattoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiScadenze As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiQuadroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipiMaterialeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestioneMaterialiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitaDiMisuraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestioneQuadriDichiarazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmCDA As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAssCDA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPassCDA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mbNotifiche As mdsUIControls.ucMainButton
    Friend WithEvents mbCDAAss As mdsUIControls.ucMainButton
    Friend WithEvents mbSoci As mdsUIControls.ucMainButton
    Friend WithEvents mbConfigurazione As mdsUIControls.ucMainButton
    Friend WithEvents mbAmministrazione As mdsUIControls.ucMainButton
    Friend WithEvents mbEsportazioni As mdsUIControls.ucMainButton
    Friend WithEvents mbStatistiche As mdsUIControls.ucMainButton
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiPassAss As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuoteAdesioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGestIncassi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGestAttivita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAliquoteIVA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LibroSociToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmNotifiche As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiNotificheNuoviSoci As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mbUscita As mdsUIControls.ucMainButton
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStatistiche As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNotifiche As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAmministrazione As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCDAAss As System.Windows.Forms.ToolStripDropDownButton

End Class
