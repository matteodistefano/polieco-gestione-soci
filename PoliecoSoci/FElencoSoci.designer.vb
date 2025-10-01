<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoSoci
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSoci = New System.Windows.Forms.DataGridView()
        Me.dgvcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRagioneSociale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIndirizzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcLocalita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcStato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvcStatoDic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvcStatoPag = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmFlt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImpostaFiltroPerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IbanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompetenzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsSoci = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.tcFiltri = New System.Windows.Forms.TabControl()
        Me.tpAnagrafici = New System.Windows.Forms.TabPage()
        Me.chkSediOperative = New System.Windows.Forms.CheckBox()
        Me.chkStPagamenti = New System.Windows.Forms.CheckBox()
        Me.chkStDichiarazioni = New System.Windows.Forms.CheckBox()
        Me.chkStPag2 = New System.Windows.Forms.CheckBox()
        Me.chkStPag1 = New System.Windows.Forms.CheckBox()
        Me.chkStDic2 = New System.Windows.Forms.CheckBox()
        Me.chkStPag0 = New System.Windows.Forms.CheckBox()
        Me.chkStDic0 = New System.Windows.Forms.CheckBox()
        Me.chkSt2 = New System.Windows.Forms.CheckBox()
        Me.chkSt1 = New System.Windows.Forms.CheckBox()
        Me.chkSt0 = New System.Windows.Forms.CheckBox()
        Me.rbStato1 = New System.Windows.Forms.RadioButton()
        Me.rbStato0 = New System.Windows.Forms.RadioButton()
        Me.cbInfoStato = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLocalita = New System.Windows.Forms.TextBox()
        Me.txtIndirizzo = New System.Windows.Forms.TextBox()
        Me.lIndirizzo = New System.Windows.Forms.Label()
        Me.txtReferente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAssociazione = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lLocalita = New System.Windows.Forms.Label()
        Me.cbStato = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbRegione = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRagSoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpAmministrativi = New System.Windows.Forms.TabPage()
        Me.cdiDataInizioAtt = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbAttivitaSecondaria = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbAttivitaPrincipale = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodiceFiscale = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPartitaIVA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cdiDataAdesione = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.cdiDataAssemblea = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.cdiDataCDA = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tpEventi = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTestoEvento = New System.Windows.Forms.TextBox()
        Me.chkIncludiDatiEvento = New System.Windows.Forms.CheckBox()
        Me.tsFltEventi = New System.Windows.Forms.ToolStrip()
        Me.tsbFltAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbFltDel = New System.Windows.Forms.ToolStripButton()
        Me.ucSelEvento = New PoliecoSoci.ucEventSelector()
        Me.lvwFltEventi = New System.Windows.Forms.ListView()
        Me.tpAtt = New System.Windows.Forms.TabPage()
        Me.chkLstAtt = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbAtt1 = New System.Windows.Forms.RadioButton()
        Me.rbAtt0 = New System.Windows.Forms.RadioButton()
        Me.txtAttAteco = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtAttDescrizione = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cdiAttPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.tpProd = New System.Windows.Forms.TabPage()
        Me.chkVisProdotti = New System.Windows.Forms.CheckBox()
        Me.btnProdDel = New System.Windows.Forms.Button()
        Me.btnProdAdd = New System.Windows.Forms.Button()
        Me.lvwProdotti = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbProdUno = New System.Windows.Forms.RadioButton()
        Me.rbProdTutti = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pagerMov = New mdsUIControls.ucPager()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbSeleziona = New System.Windows.Forms.ToolStripButton()
        Me.tsSepSel = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNuovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAggiornaStato = New System.Windows.Forms.ToolStripButton()
        Me.tsbAltreAziende = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.Ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmReset = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiResetCurrent = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiResetAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcStatoMovimento = New mdsUIControls.MultiCheck(Me.components)
        Me.mcTipoConto = New mdsUIControls.MultiCheck(Me.components)
        Me.mcStatoFlusso = New mdsUIControls.MultiCheck(Me.components)
        Me.chkStDic1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgvSoci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmFlt.SuspendLayout()
        CType(Me.bsSoci, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.tcFiltri.SuspendLayout()
        Me.tpAnagrafici.SuspendLayout()
        Me.tpAmministrativi.SuspendLayout()
        Me.tpEventi.SuspendLayout()
        Me.tsFltEventi.SuspendLayout()
        Me.tpAtt.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tpProd.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.cmReset.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSoci
        '
        Me.dgvSoci.AllowUserToAddRows = False
        Me.dgvSoci.AllowUserToDeleteRows = False
        Me.dgvSoci.AutoGenerateColumns = False
        Me.dgvSoci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSoci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoci.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcId, Me.dgvcRagioneSociale, Me.dgvcCategoria, Me.dgvcIndirizzo, Me.dgvcLocalita, Me.dgvcProvincia, Me.dgvcTelefono, Me.dgvcFax, Me.dgvcMail, Me.dgvcStato, Me.dgvcStatoDic, Me.dgvcStatoPag})
        Me.dgvSoci.ContextMenuStrip = Me.cmFlt
        Me.dgvSoci.DataSource = Me.bsSoci
        Me.dgvSoci.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSoci.Location = New System.Drawing.Point(0, 0)
        Me.dgvSoci.Name = "dgvSoci"
        Me.dgvSoci.ReadOnly = True
        Me.dgvSoci.RowHeadersWidth = 20
        Me.dgvSoci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSoci.Size = New System.Drawing.Size(1239, 359)
        Me.dgvSoci.TabIndex = 1
        '
        'dgvcId
        '
        Me.dgvcId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcId.DataPropertyName = "Id"
        Me.dgvcId.HeaderText = "Codice"
        Me.dgvcId.Name = "dgvcId"
        Me.dgvcId.ReadOnly = True
        Me.dgvcId.Width = 60
        '
        'dgvcRagioneSociale
        '
        Me.dgvcRagioneSociale.DataPropertyName = "RagioneSociale"
        Me.dgvcRagioneSociale.HeaderText = "Ragione sociale"
        Me.dgvcRagioneSociale.Name = "dgvcRagioneSociale"
        Me.dgvcRagioneSociale.ReadOnly = True
        '
        'dgvcCategoria
        '
        Me.dgvcCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCategoria.DataPropertyName = "CodCategoria"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcCategoria.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcCategoria.HeaderText = "Categ."
        Me.dgvcCategoria.Name = "dgvcCategoria"
        Me.dgvcCategoria.ReadOnly = True
        Me.dgvcCategoria.Width = 60
        '
        'dgvcIndirizzo
        '
        Me.dgvcIndirizzo.DataPropertyName = "Indirizzo"
        Me.dgvcIndirizzo.HeaderText = "Indirizzo"
        Me.dgvcIndirizzo.Name = "dgvcIndirizzo"
        Me.dgvcIndirizzo.ReadOnly = True
        '
        'dgvcLocalita
        '
        Me.dgvcLocalita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcLocalita.DataPropertyName = "Localita"
        Me.dgvcLocalita.HeaderText = "Localita"
        Me.dgvcLocalita.Name = "dgvcLocalita"
        Me.dgvcLocalita.ReadOnly = True
        Me.dgvcLocalita.Width = 200
        '
        'dgvcProvincia
        '
        Me.dgvcProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcProvincia.DataPropertyName = "Provincia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcProvincia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcProvincia.HeaderText = "Prov."
        Me.dgvcProvincia.Name = "dgvcProvincia"
        Me.dgvcProvincia.ReadOnly = True
        Me.dgvcProvincia.Width = 40
        '
        'dgvcTelefono
        '
        Me.dgvcTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcTelefono.DataPropertyName = "DescrTelefoni"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcTelefono.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcTelefono.HeaderText = "Telefono"
        Me.dgvcTelefono.Name = "dgvcTelefono"
        Me.dgvcTelefono.ReadOnly = True
        Me.dgvcTelefono.Width = 110
        '
        'dgvcFax
        '
        Me.dgvcFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcFax.DataPropertyName = "Fax"
        Me.dgvcFax.HeaderText = "Fax"
        Me.dgvcFax.Name = "dgvcFax"
        Me.dgvcFax.ReadOnly = True
        Me.dgvcFax.Width = 110
        '
        'dgvcMail
        '
        Me.dgvcMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMail.DataPropertyName = "Email"
        Me.dgvcMail.HeaderText = "Mail"
        Me.dgvcMail.Name = "dgvcMail"
        Me.dgvcMail.ReadOnly = True
        Me.dgvcMail.Width = 160
        '
        'dgvcStato
        '
        Me.dgvcStato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcStato.DataPropertyName = "CodStato"
        Me.dgvcStato.HeaderText = "Stato"
        Me.dgvcStato.Name = "dgvcStato"
        Me.dgvcStato.ReadOnly = True
        Me.dgvcStato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcStato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcStato.Width = 50
        '
        'dgvcStatoDic
        '
        Me.dgvcStatoDic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcStatoDic.DataPropertyName = "StatoDichiarazione"
        Me.dgvcStatoDic.HeaderText = "Stato dic."
        Me.dgvcStatoDic.Name = "dgvcStatoDic"
        Me.dgvcStatoDic.ReadOnly = True
        Me.dgvcStatoDic.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcStatoDic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcStatoDic.Width = 50
        '
        'dgvcStatoPag
        '
        Me.dgvcStatoPag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcStatoPag.DataPropertyName = "StatoPagamenti"
        Me.dgvcStatoPag.HeaderText = "Stato pag."
        Me.dgvcStatoPag.Name = "dgvcStatoPag"
        Me.dgvcStatoPag.ReadOnly = True
        Me.dgvcStatoPag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcStatoPag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcStatoPag.Width = 50
        '
        'cmFlt
        '
        Me.cmFlt.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmFlt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostaFiltroPerToolStripMenuItem})
        Me.cmFlt.Name = "cmFlt"
        Me.cmFlt.Size = New System.Drawing.Size(166, 26)
        '
        'ImpostaFiltroPerToolStripMenuItem
        '
        Me.ImpostaFiltroPerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IbanToolStripMenuItem, Me.RegioneToolStripMenuItem, Me.ProvinciaToolStripMenuItem, Me.CompetenzaToolStripMenuItem})
        Me.ImpostaFiltroPerToolStripMenuItem.Name = "ImpostaFiltroPerToolStripMenuItem"
        Me.ImpostaFiltroPerToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ImpostaFiltroPerToolStripMenuItem.Text = "Imposta filtro per"
        '
        'IbanToolStripMenuItem
        '
        Me.IbanToolStripMenuItem.Name = "IbanToolStripMenuItem"
        Me.IbanToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.IbanToolStripMenuItem.Text = "Iban"
        '
        'RegioneToolStripMenuItem
        '
        Me.RegioneToolStripMenuItem.Name = "RegioneToolStripMenuItem"
        Me.RegioneToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RegioneToolStripMenuItem.Text = "Regione"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ProvinciaToolStripMenuItem.Text = "Provincia"
        '
        'CompetenzaToolStripMenuItem
        '
        Me.CompetenzaToolStripMenuItem.Name = "CompetenzaToolStripMenuItem"
        Me.CompetenzaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CompetenzaToolStripMenuItem.Text = "Competenza"
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.dgvSoci)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 168)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1239, 359)
        Me.pnlGrid.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.tcFiltri)
        Me.pnlHeader.Controls.Add(Me.btnReset)
        Me.pnlHeader.Controls.Add(Me.btnCerca)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1239, 168)
        Me.pnlHeader.TabIndex = 2
        '
        'tcFiltri
        '
        Me.tcFiltri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcFiltri.Controls.Add(Me.tpAnagrafici)
        Me.tcFiltri.Controls.Add(Me.tpAmministrativi)
        Me.tcFiltri.Controls.Add(Me.tpEventi)
        Me.tcFiltri.Controls.Add(Me.tpAtt)
        Me.tcFiltri.Controls.Add(Me.tpProd)
        Me.tcFiltri.ItemSize = New System.Drawing.Size(85, 30)
        Me.tcFiltri.Location = New System.Drawing.Point(3, 3)
        Me.tcFiltri.Name = "tcFiltri"
        Me.tcFiltri.SelectedIndex = 0
        Me.tcFiltri.Size = New System.Drawing.Size(1133, 159)
        Me.tcFiltri.TabIndex = 0
        '
        'tpAnagrafici
        '
        Me.tpAnagrafici.Controls.Add(Me.chkStDic1)
        Me.tpAnagrafici.Controls.Add(Me.chkSediOperative)
        Me.tpAnagrafici.Controls.Add(Me.chkStPagamenti)
        Me.tpAnagrafici.Controls.Add(Me.chkStDichiarazioni)
        Me.tpAnagrafici.Controls.Add(Me.chkStPag2)
        Me.tpAnagrafici.Controls.Add(Me.chkStPag1)
        Me.tpAnagrafici.Controls.Add(Me.chkStDic2)
        Me.tpAnagrafici.Controls.Add(Me.chkStPag0)
        Me.tpAnagrafici.Controls.Add(Me.chkStDic0)
        Me.tpAnagrafici.Controls.Add(Me.chkSt2)
        Me.tpAnagrafici.Controls.Add(Me.chkSt1)
        Me.tpAnagrafici.Controls.Add(Me.chkSt0)
        Me.tpAnagrafici.Controls.Add(Me.rbStato1)
        Me.tpAnagrafici.Controls.Add(Me.rbStato0)
        Me.tpAnagrafici.Controls.Add(Me.cbInfoStato)
        Me.tpAnagrafici.Controls.Add(Me.Label15)
        Me.tpAnagrafici.Controls.Add(Me.txtLocalita)
        Me.tpAnagrafici.Controls.Add(Me.txtIndirizzo)
        Me.tpAnagrafici.Controls.Add(Me.lIndirizzo)
        Me.tpAnagrafici.Controls.Add(Me.txtReferente)
        Me.tpAnagrafici.Controls.Add(Me.Label9)
        Me.tpAnagrafici.Controls.Add(Me.txtAssociazione)
        Me.tpAnagrafici.Controls.Add(Me.Label8)
        Me.tpAnagrafici.Controls.Add(Me.lLocalita)
        Me.tpAnagrafici.Controls.Add(Me.cbStato)
        Me.tpAnagrafici.Controls.Add(Me.cbTipo)
        Me.tpAnagrafici.Controls.Add(Me.cbProvincia)
        Me.tpAnagrafici.Controls.Add(Me.cbRegione)
        Me.tpAnagrafici.Controls.Add(Me.Label6)
        Me.tpAnagrafici.Controls.Add(Me.Label5)
        Me.tpAnagrafici.Controls.Add(Me.Label4)
        Me.tpAnagrafici.Controls.Add(Me.Label3)
        Me.tpAnagrafici.Controls.Add(Me.txtCodice)
        Me.tpAnagrafici.Controls.Add(Me.Label2)
        Me.tpAnagrafici.Controls.Add(Me.txtRagSoc)
        Me.tpAnagrafici.Controls.Add(Me.Label1)
        Me.tpAnagrafici.Location = New System.Drawing.Point(4, 34)
        Me.tpAnagrafici.Name = "tpAnagrafici"
        Me.tpAnagrafici.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnagrafici.Size = New System.Drawing.Size(1125, 121)
        Me.tpAnagrafici.TabIndex = 0
        Me.tpAnagrafici.Text = "Dati anagrafici"
        Me.tpAnagrafici.UseVisualStyleBackColor = True
        '
        'chkSediOperative
        '
        Me.chkSediOperative.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSediOperative.AutoSize = True
        Me.chkSediOperative.Location = New System.Drawing.Point(881, 81)
        Me.chkSediOperative.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSediOperative.Name = "chkSediOperative"
        Me.chkSediOperative.Size = New System.Drawing.Size(126, 17)
        Me.chkSediOperative.TabIndex = 40
        Me.chkSediOperative.Text = "Includi sedi operative"
        Me.chkSediOperative.UseVisualStyleBackColor = True
        '
        'chkStPagamenti
        '
        Me.chkStPagamenti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStPagamenti.AutoSize = True
        Me.chkStPagamenti.Location = New System.Drawing.Point(881, 28)
        Me.chkStPagamenti.Margin = New System.Windows.Forms.Padding(2)
        Me.chkStPagamenti.Name = "chkStPagamenti"
        Me.chkStPagamenti.Size = New System.Drawing.Size(103, 17)
        Me.chkStPagamenti.TabIndex = 39
        Me.chkStPagamenti.Text = "Stato pagamenti"
        Me.chkStPagamenti.UseVisualStyleBackColor = True
        '
        'chkStDichiarazioni
        '
        Me.chkStDichiarazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStDichiarazioni.AutoSize = True
        Me.chkStDichiarazioni.Location = New System.Drawing.Point(881, 4)
        Me.chkStDichiarazioni.Margin = New System.Windows.Forms.Padding(2)
        Me.chkStDichiarazioni.Name = "chkStDichiarazioni"
        Me.chkStDichiarazioni.Size = New System.Drawing.Size(112, 17)
        Me.chkStDichiarazioni.TabIndex = 38
        Me.chkStDichiarazioni.Text = "Stato dichiarazioni"
        Me.chkStDichiarazioni.UseVisualStyleBackColor = True
        '
        'chkStPag2
        '
        Me.chkStPag2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStPag2.Enabled = False
        Me.chkStPag2.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Red_Round_16_n_g
        Me.chkStPag2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStPag2.Location = New System.Drawing.Point(1088, 23)
        Me.chkStPag2.Name = "chkStPag2"
        Me.chkStPag2.Size = New System.Drawing.Size(36, 25)
        Me.chkStPag2.TabIndex = 46
        Me.Ttip.SetToolTip(Me.chkStPag2, "Nessun pagamento regolare")
        Me.chkStPag2.UseVisualStyleBackColor = True
        '
        'chkStPag1
        '
        Me.chkStPag1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStPag1.Enabled = False
        Me.chkStPag1.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Yellow_Round_16_n_g
        Me.chkStPag1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStPag1.Location = New System.Drawing.Point(1048, 23)
        Me.chkStPag1.Name = "chkStPag1"
        Me.chkStPag1.Size = New System.Drawing.Size(36, 25)
        Me.chkStPag1.TabIndex = 45
        Me.Ttip.SetToolTip(Me.chkStPag1, "Almeno un pagamento non regolare")
        Me.chkStPag1.UseVisualStyleBackColor = True
        '
        'chkStDic2
        '
        Me.chkStDic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStDic2.Enabled = False
        Me.chkStDic2.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Red_Round_16_n_g
        Me.chkStDic2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStDic2.Location = New System.Drawing.Point(1088, 0)
        Me.chkStDic2.Name = "chkStDic2"
        Me.chkStDic2.Size = New System.Drawing.Size(36, 25)
        Me.chkStDic2.TabIndex = 43
        Me.Ttip.SetToolTip(Me.chkStDic2, "Almeno una dichiarazione non regolare")
        Me.chkStDic2.UseVisualStyleBackColor = True
        '
        'chkStPag0
        '
        Me.chkStPag0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStPag0.Checked = True
        Me.chkStPag0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStPag0.Enabled = False
        Me.chkStPag0.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Green_Round_16_n_g
        Me.chkStPag0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStPag0.Location = New System.Drawing.Point(1011, 24)
        Me.chkStPag0.Name = "chkStPag0"
        Me.chkStPag0.Size = New System.Drawing.Size(36, 25)
        Me.chkStPag0.TabIndex = 44
        Me.Ttip.SetToolTip(Me.chkStPag0, "Tutti i pagamenti regolari")
        Me.chkStPag0.UseVisualStyleBackColor = True
        '
        'chkStDic0
        '
        Me.chkStDic0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStDic0.Checked = True
        Me.chkStDic0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStDic0.Enabled = False
        Me.chkStDic0.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Green_Round_16_n_g
        Me.chkStDic0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStDic0.Location = New System.Drawing.Point(1011, 1)
        Me.chkStDic0.Name = "chkStDic0"
        Me.chkStDic0.Size = New System.Drawing.Size(36, 25)
        Me.chkStDic0.TabIndex = 41
        Me.Ttip.SetToolTip(Me.chkStDic0, "Tutte le dichiarazioni regolari")
        Me.chkStDic0.UseVisualStyleBackColor = True
        '
        'chkSt2
        '
        Me.chkSt2.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Red_Round_16_n_g
        Me.chkSt2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkSt2.Location = New System.Drawing.Point(575, 24)
        Me.chkSt2.Name = "chkSt2"
        Me.chkSt2.Size = New System.Drawing.Size(36, 25)
        Me.chkSt2.TabIndex = 28
        Me.Ttip.SetToolTip(Me.chkSt2, "Socio uscito")
        Me.chkSt2.UseVisualStyleBackColor = True
        '
        'chkSt1
        '
        Me.chkSt1.Checked = True
        Me.chkSt1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSt1.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Blue_Round_16_n_g
        Me.chkSt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkSt1.Location = New System.Drawing.Point(536, 24)
        Me.chkSt1.Name = "chkSt1"
        Me.chkSt1.Size = New System.Drawing.Size(36, 25)
        Me.chkSt1.TabIndex = 26
        Me.Ttip.SetToolTip(Me.chkSt1, "Nuovo socio")
        Me.chkSt1.UseVisualStyleBackColor = True
        '
        'chkSt0
        '
        Me.chkSt0.Checked = True
        Me.chkSt0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSt0.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Green_Round_16_n_g
        Me.chkSt0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkSt0.Location = New System.Drawing.Point(500, 24)
        Me.chkSt0.Name = "chkSt0"
        Me.chkSt0.Size = New System.Drawing.Size(36, 25)
        Me.chkSt0.TabIndex = 25
        Me.Ttip.SetToolTip(Me.chkSt0, "Socio attivo")
        Me.chkSt0.UseVisualStyleBackColor = True
        '
        'rbStato1
        '
        Me.rbStato1.AutoSize = True
        Me.rbStato1.Location = New System.Drawing.Point(477, 53)
        Me.rbStato1.Name = "rbStato1"
        Me.rbStato1.Size = New System.Drawing.Size(14, 13)
        Me.rbStato1.TabIndex = 24
        Me.rbStato1.UseVisualStyleBackColor = True
        '
        'rbStato0
        '
        Me.rbStato0.AutoSize = True
        Me.rbStato0.Checked = True
        Me.rbStato0.Location = New System.Drawing.Point(477, 28)
        Me.rbStato0.Name = "rbStato0"
        Me.rbStato0.Size = New System.Drawing.Size(14, 13)
        Me.rbStato0.TabIndex = 23
        Me.rbStato0.TabStop = True
        Me.rbStato0.UseVisualStyleBackColor = True
        '
        'cbInfoStato
        '
        Me.cbInfoStato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbInfoStato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbInfoStato.FormattingEnabled = True
        Me.cbInfoStato.Location = New System.Drawing.Point(477, 78)
        Me.cbInfoStato.Name = "cbInfoStato"
        Me.cbInfoStato.Size = New System.Drawing.Size(152, 21)
        Me.cbInfoStato.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(416, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Info stato"
        '
        'txtLocalita
        '
        Me.txtLocalita.Location = New System.Drawing.Point(283, 53)
        Me.txtLocalita.Name = "txtLocalita"
        Me.txtLocalita.Size = New System.Drawing.Size(128, 20)
        Me.txtLocalita.TabIndex = 20
        '
        'txtIndirizzo
        '
        Me.txtIndirizzo.Location = New System.Drawing.Point(283, 79)
        Me.txtIndirizzo.Name = "txtIndirizzo"
        Me.txtIndirizzo.Size = New System.Drawing.Size(128, 20)
        Me.txtIndirizzo.TabIndex = 19
        '
        'lIndirizzo
        '
        Me.lIndirizzo.AutoSize = True
        Me.lIndirizzo.Location = New System.Drawing.Point(232, 85)
        Me.lIndirizzo.Name = "lIndirizzo"
        Me.lIndirizzo.Size = New System.Drawing.Size(45, 13)
        Me.lIndirizzo.TabIndex = 18
        Me.lIndirizzo.Text = "Indirizzo"
        '
        'txtReferente
        '
        Me.txtReferente.Location = New System.Drawing.Point(95, 80)
        Me.txtReferente.Name = "txtReferente"
        Me.txtReferente.Size = New System.Drawing.Size(124, 20)
        Me.txtReferente.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Referente"
        '
        'txtAssociazione
        '
        Me.txtAssociazione.Location = New System.Drawing.Point(95, 54)
        Me.txtAssociazione.Name = "txtAssociazione"
        Me.txtAssociazione.Size = New System.Drawing.Size(124, 20)
        Me.txtAssociazione.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Associazione"
        '
        'lLocalita
        '
        Me.lLocalita.AutoSize = True
        Me.lLocalita.Location = New System.Drawing.Point(232, 60)
        Me.lLocalita.Name = "lLocalita"
        Me.lLocalita.Size = New System.Drawing.Size(44, 13)
        Me.lLocalita.TabIndex = 13
        Me.lLocalita.Text = "Localita"
        '
        'cbStato
        '
        Me.cbStato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbStato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStato.FormattingEnabled = True
        Me.cbStato.Location = New System.Drawing.Point(500, 51)
        Me.cbStato.Name = "cbStato"
        Me.cbStato.Size = New System.Drawing.Size(129, 21)
        Me.cbStato.TabIndex = 12
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(477, 2)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(152, 21)
        Me.cbTipo.TabIndex = 11
        '
        'cbProvincia
        '
        Me.cbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(283, 29)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(128, 21)
        Me.cbProvincia.TabIndex = 10
        '
        'cbRegione
        '
        Me.cbRegione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbRegione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRegione.FormattingEnabled = True
        Me.cbRegione.Location = New System.Drawing.Point(283, 3)
        Me.cbRegione.Name = "cbRegione"
        Me.cbRegione.Size = New System.Drawing.Size(128, 21)
        Me.cbRegione.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Provincia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Stato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo socio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Regione"
        '
        'txtCodice
        '
        Me.txtCodice.Location = New System.Drawing.Point(95, 30)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(124, 20)
        Me.txtCodice.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codice"
        '
        'txtRagSoc
        '
        Me.txtRagSoc.Location = New System.Drawing.Point(95, 4)
        Me.txtRagSoc.Name = "txtRagSoc"
        Me.txtRagSoc.Size = New System.Drawing.Size(124, 20)
        Me.txtRagSoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ragione sociale"
        '
        'tpAmministrativi
        '
        Me.tpAmministrativi.Controls.Add(Me.cdiDataInizioAtt)
        Me.tpAmministrativi.Controls.Add(Me.Label21)
        Me.tpAmministrativi.Controls.Add(Me.Label20)
        Me.tpAmministrativi.Controls.Add(Me.Label18)
        Me.tpAmministrativi.Controls.Add(Me.cbAttivitaSecondaria)
        Me.tpAmministrativi.Controls.Add(Me.Label14)
        Me.tpAmministrativi.Controls.Add(Me.cbAttivitaPrincipale)
        Me.tpAmministrativi.Controls.Add(Me.Label13)
        Me.tpAmministrativi.Controls.Add(Me.txtCodiceFiscale)
        Me.tpAmministrativi.Controls.Add(Me.Label12)
        Me.tpAmministrativi.Controls.Add(Me.txtPartitaIVA)
        Me.tpAmministrativi.Controls.Add(Me.Label11)
        Me.tpAmministrativi.Controls.Add(Me.cdiDataAdesione)
        Me.tpAmministrativi.Controls.Add(Me.cdiDataAssemblea)
        Me.tpAmministrativi.Controls.Add(Me.cdiDataCDA)
        Me.tpAmministrativi.Controls.Add(Me.Label19)
        Me.tpAmministrativi.Location = New System.Drawing.Point(4, 34)
        Me.tpAmministrativi.Name = "tpAmministrativi"
        Me.tpAmministrativi.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAmministrativi.Size = New System.Drawing.Size(1015, 121)
        Me.tpAmministrativi.TabIndex = 1
        Me.tpAmministrativi.Text = "Dati amministrativi"
        Me.tpAmministrativi.UseVisualStyleBackColor = True
        '
        'cdiDataInizioAtt
        '
        Me.cdiDataInizioAtt.DataFinale = Nothing
        Me.cdiDataInizioAtt.DataIniziale = Nothing
        Me.cdiDataInizioAtt.DateFormat = "dd/MM/yyyy"
        Me.cdiDataInizioAtt.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiDataInizioAtt.Location = New System.Drawing.Point(451, 84)
        Me.cdiDataInizioAtt.MonthFormat = False
        Me.cdiDataInizioAtt.Name = "cdiDataInizioAtt"
        Me.cdiDataInizioAtt.Size = New System.Drawing.Size(214, 23)
        Me.cdiDataInizioAtt.TabIndex = 21
        Me.cdiDataInizioAtt.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiDataInizioAtt.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(334, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Inizio attività"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(334, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Data adesione"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(334, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Passaggio CDA "
        '
        'cbAttivitaSecondaria
        '
        Me.cbAttivitaSecondaria.FormattingEnabled = True
        Me.cbAttivitaSecondaria.Location = New System.Drawing.Point(108, 84)
        Me.cbAttivitaSecondaria.Name = "cbAttivitaSecondaria"
        Me.cbAttivitaSecondaria.Size = New System.Drawing.Size(213, 21)
        Me.cbAttivitaSecondaria.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Cat.Att. secondaria"
        '
        'cbAttivitaPrincipale
        '
        Me.cbAttivitaPrincipale.FormattingEnabled = True
        Me.cbAttivitaPrincipale.Location = New System.Drawing.Point(109, 58)
        Me.cbAttivitaPrincipale.Name = "cbAttivitaPrincipale"
        Me.cbAttivitaPrincipale.Size = New System.Drawing.Size(212, 21)
        Me.cbAttivitaPrincipale.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Cat.Att. principale"
        '
        'txtCodiceFiscale
        '
        Me.txtCodiceFiscale.Location = New System.Drawing.Point(109, 34)
        Me.txtCodiceFiscale.Name = "txtCodiceFiscale"
        Me.txtCodiceFiscale.Size = New System.Drawing.Size(131, 20)
        Me.txtCodiceFiscale.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Codice fiscale"
        '
        'txtPartitaIVA
        '
        Me.txtPartitaIVA.Location = New System.Drawing.Point(109, 10)
        Me.txtPartitaIVA.Name = "txtPartitaIVA"
        Me.txtPartitaIVA.Size = New System.Drawing.Size(131, 20)
        Me.txtPartitaIVA.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Partita IVA"
        '
        'cdiDataAdesione
        '
        Me.cdiDataAdesione.DataFinale = Nothing
        Me.cdiDataAdesione.DataIniziale = Nothing
        Me.cdiDataAdesione.DateFormat = "dd/MM/yyyy"
        Me.cdiDataAdesione.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiDataAdesione.Location = New System.Drawing.Point(451, 58)
        Me.cdiDataAdesione.MonthFormat = False
        Me.cdiDataAdesione.Name = "cdiDataAdesione"
        Me.cdiDataAdesione.Size = New System.Drawing.Size(214, 23)
        Me.cdiDataAdesione.TabIndex = 19
        Me.cdiDataAdesione.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiDataAdesione.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'cdiDataAssemblea
        '
        Me.cdiDataAssemblea.DataFinale = Nothing
        Me.cdiDataAssemblea.DataIniziale = Nothing
        Me.cdiDataAssemblea.DateFormat = "dd/MM/yyyy"
        Me.cdiDataAssemblea.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiDataAssemblea.Location = New System.Drawing.Point(451, 34)
        Me.cdiDataAssemblea.MonthFormat = False
        Me.cdiDataAssemblea.Name = "cdiDataAssemblea"
        Me.cdiDataAssemblea.Size = New System.Drawing.Size(214, 23)
        Me.cdiDataAssemblea.TabIndex = 17
        Me.cdiDataAssemblea.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiDataAssemblea.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'cdiDataCDA
        '
        Me.cdiDataCDA.DataFinale = Nothing
        Me.cdiDataCDA.DataIniziale = Nothing
        Me.cdiDataCDA.DateFormat = "dd/MM/yyyy"
        Me.cdiDataCDA.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiDataCDA.Location = New System.Drawing.Point(451, 10)
        Me.cdiDataCDA.MonthFormat = False
        Me.cdiDataCDA.Name = "cdiDataCDA"
        Me.cdiDataCDA.Size = New System.Drawing.Size(214, 23)
        Me.cdiDataCDA.TabIndex = 16
        Me.cdiDataCDA.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiDataCDA.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(334, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Passaggio Assemblea"
        '
        'tpEventi
        '
        Me.tpEventi.Controls.Add(Me.Label16)
        Me.tpEventi.Controls.Add(Me.txtTestoEvento)
        Me.tpEventi.Controls.Add(Me.chkIncludiDatiEvento)
        Me.tpEventi.Controls.Add(Me.tsFltEventi)
        Me.tpEventi.Controls.Add(Me.ucSelEvento)
        Me.tpEventi.Controls.Add(Me.lvwFltEventi)
        Me.tpEventi.Location = New System.Drawing.Point(4, 34)
        Me.tpEventi.Name = "tpEventi"
        Me.tpEventi.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEventi.Size = New System.Drawing.Size(1015, 121)
        Me.tpEventi.TabIndex = 2
        Me.tpEventi.Text = "Eventi"
        Me.tpEventi.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(574, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Testo evento"
        '
        'txtTestoEvento
        '
        Me.txtTestoEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTestoEvento.Location = New System.Drawing.Point(649, 6)
        Me.txtTestoEvento.Name = "txtTestoEvento"
        Me.txtTestoEvento.Size = New System.Drawing.Size(212, 20)
        Me.txtTestoEvento.TabIndex = 2
        '
        'chkIncludiDatiEvento
        '
        Me.chkIncludiDatiEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludiDatiEvento.AutoSize = True
        Me.chkIncludiDatiEvento.Location = New System.Drawing.Point(571, 69)
        Me.chkIncludiDatiEvento.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIncludiDatiEvento.Name = "chkIncludiDatiEvento"
        Me.chkIncludiDatiEvento.Size = New System.Drawing.Size(231, 17)
        Me.chkIncludiDatiEvento.TabIndex = 3
        Me.chkIncludiDatiEvento.Text = "Includi  motivazioni / note dell'ultimo evento"
        Me.chkIncludiDatiEvento.UseVisualStyleBackColor = True
        '
        'tsFltEventi
        '
        Me.tsFltEventi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsFltEventi.AutoSize = False
        Me.tsFltEventi.Dock = System.Windows.Forms.DockStyle.None
        Me.tsFltEventi.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFltEventi.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsFltEventi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFltAdd, Me.tsbFltDel})
        Me.tsFltEventi.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsFltEventi.Location = New System.Drawing.Point(538, 3)
        Me.tsFltEventi.Name = "tsFltEventi"
        Me.tsFltEventi.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsFltEventi.Size = New System.Drawing.Size(28, 122)
        Me.tsFltEventi.TabIndex = 1
        '
        'tsbFltAdd
        '
        Me.tsbFltAdd.AutoSize = False
        Me.tsbFltAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFltAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.tsbFltAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFltAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFltAdd.Name = "tsbFltAdd"
        Me.tsbFltAdd.Size = New System.Drawing.Size(70, 30)
        Me.tsbFltAdd.Text = "Nuova"
        '
        'tsbFltDel
        '
        Me.tsbFltDel.AutoSize = False
        Me.tsbFltDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFltDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbFltDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbFltDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFltDel.Name = "tsbFltDel"
        Me.tsbFltDel.Size = New System.Drawing.Size(70, 30)
        Me.tsbFltDel.Text = "Elimina"
        '
        'ucSelEvento
        '
        Me.ucSelEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucSelEvento.DropDownAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ucSelEvento.Location = New System.Drawing.Point(577, 90)
        Me.ucSelEvento.ManualOnly = False
        Me.ucSelEvento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucSelEvento.Name = "ucSelEvento"
        Me.ucSelEvento.SelectedCode = ""
        Me.ucSelEvento.SelectedEvent = Nothing
        Me.ucSelEvento.Size = New System.Drawing.Size(283, 23)
        Me.ucSelEvento.TabIndex = 4
        '
        'lvwFltEventi
        '
        Me.lvwFltEventi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFltEventi.FullRowSelect = True
        Me.lvwFltEventi.GridLines = True
        Me.lvwFltEventi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwFltEventi.HideSelection = False
        Me.lvwFltEventi.Location = New System.Drawing.Point(0, 1)
        Me.lvwFltEventi.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwFltEventi.MultiSelect = False
        Me.lvwFltEventi.Name = "lvwFltEventi"
        Me.lvwFltEventi.Size = New System.Drawing.Size(537, 118)
        Me.lvwFltEventi.TabIndex = 0
        Me.lvwFltEventi.UseCompatibleStateImageBehavior = False
        Me.lvwFltEventi.View = System.Windows.Forms.View.Details
        '
        'tpAtt
        '
        Me.tpAtt.Controls.Add(Me.chkLstAtt)
        Me.tpAtt.Controls.Add(Me.Panel1)
        Me.tpAtt.Controls.Add(Me.txtAttAteco)
        Me.tpAtt.Controls.Add(Me.Label25)
        Me.tpAtt.Controls.Add(Me.Label24)
        Me.tpAtt.Controls.Add(Me.Label22)
        Me.tpAtt.Controls.Add(Me.txtAttDescrizione)
        Me.tpAtt.Controls.Add(Me.Label23)
        Me.tpAtt.Controls.Add(Me.cdiAttPeriodo)
        Me.tpAtt.Location = New System.Drawing.Point(4, 34)
        Me.tpAtt.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAtt.Name = "tpAtt"
        Me.tpAtt.Size = New System.Drawing.Size(1015, 121)
        Me.tpAtt.TabIndex = 3
        Me.tpAtt.Text = "Attivita e attrezzature"
        Me.tpAtt.UseVisualStyleBackColor = True
        '
        'chkLstAtt
        '
        Me.chkLstAtt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLstAtt.CheckOnClick = True
        Me.chkLstAtt.FormattingEnabled = True
        Me.chkLstAtt.Location = New System.Drawing.Point(393, 35)
        Me.chkLstAtt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLstAtt.MultiColumn = True
        Me.chkLstAtt.Name = "chkLstAtt"
        Me.chkLstAtt.Size = New System.Drawing.Size(473, 79)
        Me.chkLstAtt.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbAtt1)
        Me.Panel1.Controls.Add(Me.rbAtt0)
        Me.Panel1.Location = New System.Drawing.Point(393, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 23)
        Me.Panel1.TabIndex = 78
        '
        'rbAtt1
        '
        Me.rbAtt1.AutoSize = True
        Me.rbAtt1.Location = New System.Drawing.Point(86, 2)
        Me.rbAtt1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAtt1.Name = "rbAtt1"
        Me.rbAtt1.Size = New System.Drawing.Size(93, 17)
        Me.rbAtt1.TabIndex = 1
        Me.rbAtt1.Text = "Almeno una ..."
        Me.rbAtt1.UseVisualStyleBackColor = True
        '
        'rbAtt0
        '
        Me.rbAtt0.AutoSize = True
        Me.rbAtt0.Checked = True
        Me.rbAtt0.Location = New System.Drawing.Point(2, 2)
        Me.rbAtt0.Margin = New System.Windows.Forms.Padding(2)
        Me.rbAtt0.Name = "rbAtt0"
        Me.rbAtt0.Size = New System.Drawing.Size(62, 17)
        Me.rbAtt0.TabIndex = 0
        Me.rbAtt0.TabStop = True
        Me.rbAtt0.Text = "Tutte ..."
        Me.rbAtt0.UseVisualStyleBackColor = True
        '
        'txtAttAteco
        '
        Me.txtAttAteco.Location = New System.Drawing.Point(83, 63)
        Me.txtAttAteco.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAttAteco.Name = "txtAttAteco"
        Me.txtAttAteco.Size = New System.Drawing.Size(226, 20)
        Me.txtAttAteco.TabIndex = 77
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(324, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Attrezzature"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 13)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Cod.Ateco"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Periodo:"
        '
        'txtAttDescrizione
        '
        Me.txtAttDescrizione.Location = New System.Drawing.Point(83, 37)
        Me.txtAttDescrizione.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAttDescrizione.Name = "txtAttDescrizione"
        Me.txtAttDescrizione.Size = New System.Drawing.Size(226, 20)
        Me.txtAttDescrizione.TabIndex = 76
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Descrizione"
        '
        'cdiAttPeriodo
        '
        Me.cdiAttPeriodo.DataFinale = Nothing
        Me.cdiAttPeriodo.DataIniziale = Nothing
        Me.cdiAttPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiAttPeriodo.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiAttPeriodo.Location = New System.Drawing.Point(83, 11)
        Me.cdiAttPeriodo.MonthFormat = False
        Me.cdiAttPeriodo.Name = "cdiAttPeriodo"
        Me.cdiAttPeriodo.Size = New System.Drawing.Size(225, 23)
        Me.cdiAttPeriodo.TabIndex = 6
        Me.cdiAttPeriodo.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiAttPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'tpProd
        '
        Me.tpProd.Controls.Add(Me.chkVisProdotti)
        Me.tpProd.Controls.Add(Me.btnProdDel)
        Me.tpProd.Controls.Add(Me.btnProdAdd)
        Me.tpProd.Controls.Add(Me.lvwProdotti)
        Me.tpProd.Controls.Add(Me.Panel2)
        Me.tpProd.Location = New System.Drawing.Point(4, 34)
        Me.tpProd.Margin = New System.Windows.Forms.Padding(2)
        Me.tpProd.Name = "tpProd"
        Me.tpProd.Padding = New System.Windows.Forms.Padding(2)
        Me.tpProd.Size = New System.Drawing.Size(1015, 121)
        Me.tpProd.TabIndex = 4
        Me.tpProd.Text = "Prodotti"
        Me.tpProd.UseVisualStyleBackColor = True
        '
        'chkVisProdotti
        '
        Me.chkVisProdotti.Location = New System.Drawing.Point(7, 7)
        Me.chkVisProdotti.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVisProdotti.Name = "chkVisProdotti"
        Me.chkVisProdotti.Size = New System.Drawing.Size(91, 20)
        Me.chkVisProdotti.TabIndex = 84
        Me.chkVisProdotti.Text = "Visualizza"
        Me.chkVisProdotti.UseVisualStyleBackColor = True
        '
        'btnProdDel
        '
        Me.btnProdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Minus_24_n_g
        Me.btnProdDel.Location = New System.Drawing.Point(42, 84)
        Me.btnProdDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProdDel.Name = "btnProdDel"
        Me.btnProdDel.Size = New System.Drawing.Size(33, 20)
        Me.btnProdDel.TabIndex = 83
        Me.btnProdDel.UseVisualStyleBackColor = True
        '
        'btnProdAdd
        '
        Me.btnProdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.btnProdAdd.Location = New System.Drawing.Point(4, 84)
        Me.btnProdAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProdAdd.Name = "btnProdAdd"
        Me.btnProdAdd.Size = New System.Drawing.Size(33, 20)
        Me.btnProdAdd.TabIndex = 82
        Me.btnProdAdd.UseVisualStyleBackColor = True
        '
        'lvwProdotti
        '
        Me.lvwProdotti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwProdotti.HideSelection = False
        Me.lvwProdotti.Location = New System.Drawing.Point(102, 2)
        Me.lvwProdotti.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwProdotti.Name = "lvwProdotti"
        Me.lvwProdotti.Size = New System.Drawing.Size(767, 122)
        Me.lvwProdotti.TabIndex = 81
        Me.lvwProdotti.UseCompatibleStateImageBehavior = False
        Me.lvwProdotti.View = System.Windows.Forms.View.List
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbProdUno)
        Me.Panel2.Controls.Add(Me.rbProdTutti)
        Me.Panel2.Location = New System.Drawing.Point(5, 28)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(93, 52)
        Me.Panel2.TabIndex = 80
        '
        'rbProdUno
        '
        Me.rbProdUno.AutoSize = True
        Me.rbProdUno.Location = New System.Drawing.Point(2, 24)
        Me.rbProdUno.Margin = New System.Windows.Forms.Padding(2)
        Me.rbProdUno.Name = "rbProdUno"
        Me.rbProdUno.Size = New System.Drawing.Size(81, 17)
        Me.rbProdUno.TabIndex = 1
        Me.rbProdUno.Text = "Almeno uno"
        Me.rbProdUno.UseVisualStyleBackColor = True
        '
        'rbProdTutti
        '
        Me.rbProdTutti.AutoSize = True
        Me.rbProdTutti.Checked = True
        Me.rbProdTutti.Location = New System.Drawing.Point(2, 2)
        Me.rbProdTutti.Margin = New System.Windows.Forms.Padding(2)
        Me.rbProdTutti.Name = "rbProdTutti"
        Me.rbProdTutti.Size = New System.Drawing.Size(46, 17)
        Me.rbProdTutti.TabIndex = 0
        Me.rbProdTutti.TabStop = True
        Me.rbProdTutti.Text = "Tutti"
        Me.rbProdTutti.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Image = Global.PoliecoSoci.My.Resources.Resources.Show_Grid_24_n_g
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(1142, 71)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 36)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "       Ripristina"
        Me.Ttip.SetToolTip(Me.btnReset, "Ripristina i filtri alle impostazioni predefinite")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.Image = Global.PoliecoSoci.My.Resources.Resources.Search_24_n_g
        Me.btnCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerca.Location = New System.Drawing.Point(1142, 31)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(87, 33)
        Me.btnCerca.TabIndex = 9
        Me.btnCerca.Text = "    Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.pagerMov)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 527)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1239, 38)
        Me.pnlBottom.TabIndex = 0
        '
        'pagerMov
        '
        Me.pagerMov.CurrentPage = 1
        Me.pagerMov.ItemsCount = 0
        Me.pagerMov.LastPage = 0
        Me.pagerMov.Location = New System.Drawing.Point(12, 6)
        Me.pagerMov.Margin = New System.Windows.Forms.Padding(4)
        Me.pagerMov.Name = "pagerMov"
        Me.pagerMov.PageSize = 12
        Me.pagerMov.Size = New System.Drawing.Size(367, 24)
        Me.pagerMov.TabIndex = 4
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSeleziona, Me.tsSepSel, Me.tsbNuovo, Me.tsbModifica, Me.tsbElimina, Me.tsbChiudi, Me.ToolStripSeparator1, Me.tsbAggiornaStato, Me.tsbAltreAziende, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 565)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1239, 43)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbSeleziona
        '
        Me.tsbSeleziona.Image = Global.PoliecoSoci.My.Resources.Resources.Fast_Rewind_32_n_g
        Me.tsbSeleziona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSeleziona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSeleziona.Name = "tsbSeleziona"
        Me.tsbSeleziona.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbSeleziona.Size = New System.Drawing.Size(96, 40)
        Me.tsbSeleziona.Text = "Seleziona"
        Me.tsbSeleziona.ToolTipText = "Seleziona"
        '
        'tsSepSel
        '
        Me.tsSepSel.Margin = New System.Windows.Forms.Padding(0, 0, 60, 0)
        Me.tsSepSel.Name = "tsSepSel"
        Me.tsSepSel.Size = New System.Drawing.Size(6, 43)
        '
        'tsbNuovo
        '
        Me.tsbNuovo.Image = Global.PoliecoSoci.My.Resources.Resources.AddAzienda
        Me.tsbNuovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuovo.Name = "tsbNuovo"
        Me.tsbNuovo.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbNuovo.Size = New System.Drawing.Size(83, 40)
        Me.tsbNuovo.Text = "Nuovo"
        Me.tsbNuovo.ToolTipText = "Modifica"
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Edit_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbModifica.Size = New System.Drawing.Size(94, 40)
        Me.tsbModifica.Text = "Modifica"
        Me.tsbModifica.ToolTipText = "Modifica"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.DeleteAzienda
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbElimina.Size = New System.Drawing.Size(86, 40)
        Me.tsbElimina.Text = "Elimina"
        Me.tsbElimina.ToolTipText = "Modifica"
        '
        'tsbChiudi
        '
        Me.tsbChiudi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbChiudi.Image = Global.PoliecoSoci.My.Resources.Resources.SE_Arrow_32_n_g
        Me.tsbChiudi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbChiudi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChiudi.Name = "tsbChiudi"
        Me.tsbChiudi.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbChiudi.Size = New System.Drawing.Size(82, 40)
        Me.tsbChiudi.Text = "Chiudi"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'tsbAggiornaStato
        '
        Me.tsbAggiornaStato.Image = Global.PoliecoSoci.My.Resources.Resources.Shapes_Colored_32_n_g
        Me.tsbAggiornaStato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAggiornaStato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAggiornaStato.Name = "tsbAggiornaStato"
        Me.tsbAggiornaStato.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAggiornaStato.Size = New System.Drawing.Size(121, 40)
        Me.tsbAggiornaStato.Text = "Aggiorna stati"
        Me.tsbAggiornaStato.ToolTipText = "Analizza e aggiorna lo stato delle dichiarazioni e dei relativi pagamenti"
        '
        'tsbAltreAziende
        '
        Me.tsbAltreAziende.Image = Global.PoliecoSoci.My.Resources.Resources.Office_Block_32_n_g
        Me.tsbAltreAziende.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAltreAziende.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAltreAziende.Name = "tsbAltreAziende"
        Me.tsbAltreAziende.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAltreAziende.Size = New System.Drawing.Size(130, 40)
        Me.tsbAltreAziende.Text = "Aziende allegati"
        Me.tsbAltreAziende.ToolTipText = "Aziende definite negli allegati delle dichiarazioni"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbStampa.Size = New System.Drawing.Size(137, 40)
        Me.tsbStampa.Text = "Stampa - Esporta"
        Me.tsbStampa.ToolTipText = "Stampa"
        '
        'cmReset
        '
        Me.cmReset.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmReset.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiResetCurrent, Me.tsmiResetAll})
        Me.cmReset.Name = "cmReset"
        Me.cmReset.Size = New System.Drawing.Size(160, 48)
        '
        'tsmiResetCurrent
        '
        Me.tsmiResetCurrent.Name = "tsmiResetCurrent"
        Me.tsmiResetCurrent.Size = New System.Drawing.Size(159, 22)
        Me.tsmiResetCurrent.Text = "Scheda corrente"
        '
        'tsmiResetAll
        '
        Me.tsmiResetAll.Name = "tsmiResetAll"
        Me.tsmiResetAll.Size = New System.Drawing.Size(159, 22)
        Me.tsmiResetAll.Text = "Tutte le schede"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CbTipoConto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeFlusso"
        Me.DataGridViewTextBoxColumn2.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 185
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CbDescrizione"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Conto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 138
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Competenza"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Competenza"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 139
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CbCodProvincia"
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prov."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DataImportazione"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "d"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data imp."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataSaldoFinale"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "d"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data saldo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SaldoContabileFinale"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn8.HeaderText = "Saldo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 130
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.DataPropertyName = "Stato"
        Me.DataGridViewImageColumn1.HeaderText = "Stato"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.DataPropertyName = "StatoDichiarazione"
        Me.DataGridViewImageColumn2.DividerWidth = 3
        Me.DataGridViewImageColumn2.HeaderText = "Fl."
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 40
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.DataPropertyName = "FecStato"
        Me.DataGridViewImageColumn3.HeaderText = "St."
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ContoIban"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Iban"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 180
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FecNomeFlusso"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Flusso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FecCompetenza"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Competenza"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 5
        '
        'mcStatoMovimento
        '
        Me.mcStatoMovimento.AllowAllUnchecked = False
        Me.mcStatoMovimento.UseContextMenu = False
        '
        'mcTipoConto
        '
        Me.mcTipoConto.AllowAllUnchecked = False
        Me.mcTipoConto.UseContextMenu = False
        '
        'mcStatoFlusso
        '
        Me.mcStatoFlusso.AllowAllUnchecked = False
        Me.mcStatoFlusso.UseContextMenu = False
        '
        'chkStDic1
        '
        Me.chkStDic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStDic1.Enabled = False
        Me.chkStDic1.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Yellow_Round_16_n_g
        Me.chkStDic1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStDic1.Location = New System.Drawing.Point(1048, 0)
        Me.chkStDic1.Name = "chkStDic1"
        Me.chkStDic1.Size = New System.Drawing.Size(36, 25)
        Me.chkStDic1.TabIndex = 42
        Me.Ttip.SetToolTip(Me.chkStDic1, "Almeno un pagamento non regolare")
        Me.chkStDic1.UseVisualStyleBackColor = True
        '
        'FElencoSoci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 608)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.tsMain)
        Me.KeyPreview = True
        Me.Name = "FElencoSoci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco soci "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvSoci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmFlt.ResumeLayout(False)
        CType(Me.bsSoci, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.tcFiltri.ResumeLayout(False)
        Me.tpAnagrafici.ResumeLayout(False)
        Me.tpAnagrafici.PerformLayout()
        Me.tpAmministrativi.ResumeLayout(False)
        Me.tpAmministrativi.PerformLayout()
        Me.tpEventi.ResumeLayout(False)
        Me.tpEventi.PerformLayout()
        Me.tsFltEventi.ResumeLayout(False)
        Me.tsFltEventi.PerformLayout()
        Me.tpAtt.ResumeLayout(False)
        Me.tpAtt.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tpProd.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.cmReset.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSoci As System.Windows.Forms.DataGridView
    Friend WithEvents bsSoci As System.Windows.Forms.BindingSource
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCerca As System.Windows.Forms.Button
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCognomeNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmFlt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImpostaFiltroPerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IbanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompetenzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcFiltri As System.Windows.Forms.TabControl
    Friend WithEvents tpAnagrafici As System.Windows.Forms.TabPage
    Friend WithEvents tpAmministrativi As System.Windows.Forms.TabPage
    Friend WithEvents mcStatoMovimento As mdsUIControls.MultiCheck
    Friend WithEvents mcTipoConto As mdsUIControls.MultiCheck
    Friend WithEvents pagerMov As mdsUIControls.ucPager
    Friend WithEvents Ttip As System.Windows.Forms.ToolTip
    Friend WithEvents cmReset As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiResetCurrent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiResetAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents mcStatoFlusso As mdsUIControls.MultiCheck
    Friend WithEvents tsbNuovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRagSoc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lLocalita As System.Windows.Forms.Label
    Friend WithEvents cbStato As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbRegione As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIndirizzo As System.Windows.Forms.TextBox
    Friend WithEvents lIndirizzo As System.Windows.Forms.Label
    Friend WithEvents txtReferente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAssociazione As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tpEventi As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodiceFiscale As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPartitaIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbAttivitaSecondaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbAttivitaPrincipale As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocalita As System.Windows.Forms.TextBox
    Friend WithEvents cbInfoStato As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkSt2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSt1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSt0 As System.Windows.Forms.CheckBox
    Friend WithEvents rbStato1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbStato0 As System.Windows.Forms.RadioButton
    Friend WithEvents lvwFltEventi As System.Windows.Forms.ListView
    Friend WithEvents tsFltEventi As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbFltAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFltDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cdiDataAssemblea As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents cdiDataCDA As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents cdiDataAdesione As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cdiDataInizioAtt As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tpAtt As System.Windows.Forms.TabPage
    Friend WithEvents cdiAttPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtAttDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAttAteco As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbAtt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbAtt0 As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents chkLstAtt As System.Windows.Forms.CheckedListBox
    Friend WithEvents tsbSeleziona As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSepSel As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkIncludiDatiEvento As System.Windows.Forms.CheckBox
    Friend WithEvents chkStPagamenti As System.Windows.Forms.CheckBox
    Friend WithEvents chkStDichiarazioni As System.Windows.Forms.CheckBox
    Friend WithEvents chkStPag2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStPag1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStDic2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStPag0 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStDic0 As System.Windows.Forms.CheckBox
    Friend WithEvents ucSelEvento As PoliecoSoci.ucEventSelector
    Friend WithEvents tpProd As System.Windows.Forms.TabPage
    Friend WithEvents lvwProdotti As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbProdUno As System.Windows.Forms.RadioButton
    Friend WithEvents rbProdTutti As System.Windows.Forms.RadioButton
    Friend WithEvents btnProdDel As System.Windows.Forms.Button
    Friend WithEvents btnProdAdd As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTestoEvento As System.Windows.Forms.TextBox
    Friend WithEvents tsbAltreAziende As ToolStripButton
    Friend WithEvents chkVisProdotti As CheckBox
    Friend WithEvents dgvcId As DataGridViewTextBoxColumn
    Friend WithEvents dgvcRagioneSociale As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvcIndirizzo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcLocalita As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProvincia As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTelefono As DataGridViewTextBoxColumn
    Friend WithEvents dgvcFax As DataGridViewTextBoxColumn
    Friend WithEvents dgvcMail As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStato As DataGridViewImageColumn
    Friend WithEvents dgvcStatoDic As DataGridViewImageColumn
    Friend WithEvents dgvcStatoPag As DataGridViewImageColumn
    Friend WithEvents chkSediOperative As CheckBox
    Friend WithEvents tsbAggiornaStato As ToolStripButton
    Friend WithEvents chkStDic1 As CheckBox
End Class
