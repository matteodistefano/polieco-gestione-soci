<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FElencoAziendeAllegato
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoAziendeAllegato))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbSeleziona = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuova = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.cmGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAzienda = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkRuoloRic = New System.Windows.Forms.CheckBox()
        Me.chkRuoloForn = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.chkTipoSocio = New System.Windows.Forms.CheckBox()
        Me.chkTipoNonSocio = New System.Windows.Forms.CheckBox()
        Me.txtPartitaIVA = New System.Windows.Forms.TextBox()
        Me.txtSede = New System.Windows.Forms.TextBox()
        Me.txtRagioneSociale = New System.Windows.Forms.TextBox()
        Me.mcTipo = New mdsUIControls.MultiCheck(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.mcRuolo = New mdsUIControls.MultiCheck(Me.components)
        Me.dgvcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRagSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPartitaIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcFornitore = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvcRicevitore = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvcTipo = New System.Windows.Forms.DataGridViewImageColumn()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmGrid.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(33, 18)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(160, 24)
        Label1.TabIndex = 24
        Label1.Text = "Ragione sociale :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(126, 57)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(65, 24)
        Label2.TabIndex = 26
        Label2.Text = "Sede :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(81, 104)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(116, 24)
        Label4.TabIndex = 30
        Label4.Text = "Partita IVA :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(898, 18)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 24)
        Label5.TabIndex = 32
        Label5.Text = "Tipo :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(1255, 26)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(70, 24)
        Label3.TabIndex = 39
        Label3.Text = "Ruolo :"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSeleziona, Me.tsbNuova, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 1149)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1764, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbSeleziona
        '
        Me.tsbSeleziona.Image = Global.PoliecoSoci.My.Resources.Resources.Fast_Rewind_32_n_g
        Me.tsbSeleziona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSeleziona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSeleziona.Margin = New System.Windows.Forms.Padding(0, 1, 40, 2)
        Me.tsbSeleziona.Name = "tsbSeleziona"
        Me.tsbSeleziona.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbSeleziona.Size = New System.Drawing.Size(137, 42)
        Me.tsbSeleziona.Text = "Seleziona"
        Me.tsbSeleziona.ToolTipText = "Seleziona"
        Me.tsbSeleziona.Visible = False
        '
        'tsbNuova
        '
        Me.tsbNuova.Image = Global.PoliecoSoci.My.Resources.Resources.AddAzienda
        Me.tsbNuova.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNuova.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuova.Name = "tsbNuova"
        Me.tsbNuova.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbNuova.Size = New System.Drawing.Size(107, 42)
        Me.tsbNuova.Text = "Nuova"
        Me.tsbNuova.ToolTipText = "Nuovo scadenza"
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(127, 42)
        Me.tsbModifica.Text = "Dettaglio"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.DeleteAzienda
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Size = New System.Drawing.Size(117, 42)
        Me.tsbElimina.Text = "Elimina "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'tsbChiudi
        '
        Me.tsbChiudi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbChiudi.Image = Global.PoliecoSoci.My.Resources.Resources.SE_Arrow_32_n_g
        Me.tsbChiudi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbChiudi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChiudi.Name = "tsbChiudi"
        Me.tsbChiudi.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbChiudi.Size = New System.Drawing.Size(108, 42)
        Me.tsbChiudi.Text = "&Chiudi"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Margin = New System.Windows.Forms.Padding(60, 1, 0, 2)
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "Stampa"
        Me.tsbStampa.Visible = False
        '
        'dgvElenco
        '
        Me.dgvElenco.AllowUserToAddRows = False
        Me.dgvElenco.AllowUserToDeleteRows = False
        Me.dgvElenco.AllowUserToResizeRows = False
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcId, Me.dgvcRagSoc, Me.dgvcSede, Me.dgvcPartitaIva, Me.dgvcFornitore, Me.dgvcRicevitore, Me.dgvcTipo})
        Me.dgvElenco.ContextMenuStrip = Me.cmGrid
        Me.dgvElenco.DataSource = Me.bsData
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 174)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersWidth = 20
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1764, 975)
        Me.dgvElenco.TabIndex = 6
        '
        'cmGrid
        '
        Me.cmGrid.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAzienda})
        Me.cmGrid.Name = "cmGrid"
        Me.cmGrid.Size = New System.Drawing.Size(228, 28)
        '
        'tsmiAzienda
        '
        Me.tsmiAzienda.Name = "tsmiAzienda"
        Me.tsmiAzienda.Size = New System.Drawing.Size(227, 24)
        Me.tsmiAzienda.Text = "Apri azienda associata"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkRuoloRic)
        Me.Panel1.Controls.Add(Me.chkRuoloForn)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnCerca)
        Me.Panel1.Controls.Add(Me.chkTipoSocio)
        Me.Panel1.Controls.Add(Me.chkTipoNonSocio)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.txtPartitaIVA)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.txtSede)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.txtRagioneSociale)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1764, 174)
        Me.Panel1.TabIndex = 7
        '
        'chkRuoloRic
        '
        Me.chkRuoloRic.Image = Global.PoliecoSoci.My.Resources.Resources.Import_Doc_24_n_g
        Me.chkRuoloRic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkRuoloRic.Location = New System.Drawing.Point(1338, 63)
        Me.chkRuoloRic.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkRuoloRic.Name = "chkRuoloRic"
        Me.chkRuoloRic.Size = New System.Drawing.Size(205, 54)
        Me.chkRuoloRic.TabIndex = 41
        Me.chkRuoloRic.Text = "      Ricevitore"
        Me.chkRuoloRic.UseVisualStyleBackColor = True
        '
        'chkRuoloForn
        '
        Me.chkRuoloForn.Image = Global.PoliecoSoci.My.Resources.Resources.Export_Doc_24_n_g
        Me.chkRuoloForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkRuoloForn.Location = New System.Drawing.Point(1338, 14)
        Me.chkRuoloForn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkRuoloForn.Name = "chkRuoloForn"
        Me.chkRuoloForn.Size = New System.Drawing.Size(205, 54)
        Me.chkRuoloForn.TabIndex = 40
        Me.chkRuoloForn.Text = "      Fornitore"
        Me.chkRuoloForn.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Image = Global.PoliecoSoci.My.Resources.Resources.Show_Grid_24_n_g
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(1585, 87)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 66)
        Me.btnReset.TabIndex = 38
        Me.btnReset.Text = "       Ripristina"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.Image = Global.PoliecoSoci.My.Resources.Resources.Search_32_n_g
        Me.btnCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerca.Location = New System.Drawing.Point(1585, 14)
        Me.btnCerca.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(160, 62)
        Me.btnCerca.TabIndex = 37
        Me.btnCerca.Text = "    Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'chkTipoSocio
        '
        Me.chkTipoSocio.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_24_n_p8
        Me.chkTipoSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkTipoSocio.Location = New System.Drawing.Point(984, 63)
        Me.chkTipoSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkTipoSocio.Name = "chkTipoSocio"
        Me.chkTipoSocio.Size = New System.Drawing.Size(198, 54)
        Me.chkTipoSocio.TabIndex = 34
        Me.chkTipoSocio.Text = "      Associata"
        Me.chkTipoSocio.UseVisualStyleBackColor = True
        '
        'chkTipoNonSocio
        '
        Me.chkTipoNonSocio.Image = Global.PoliecoSoci.My.Resources.Resources.Tile_Vertically_24_n_g
        Me.chkTipoNonSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkTipoNonSocio.Location = New System.Drawing.Point(984, 14)
        Me.chkTipoNonSocio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkTipoNonSocio.Name = "chkTipoNonSocio"
        Me.chkTipoNonSocio.Size = New System.Drawing.Size(205, 54)
        Me.chkTipoNonSocio.TabIndex = 33
        Me.chkTipoNonSocio.Text = "      Non associata"
        Me.chkTipoNonSocio.UseVisualStyleBackColor = True
        '
        'txtPartitaIVA
        '
        Me.txtPartitaIVA.Location = New System.Drawing.Point(204, 104)
        Me.txtPartitaIVA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPartitaIVA.Name = "txtPartitaIVA"
        Me.txtPartitaIVA.Size = New System.Drawing.Size(275, 32)
        Me.txtPartitaIVA.TabIndex = 31
        '
        'txtSede
        '
        Me.txtSede.Location = New System.Drawing.Point(204, 57)
        Me.txtSede.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSede.Name = "txtSede"
        Me.txtSede.Size = New System.Drawing.Size(548, 32)
        Me.txtSede.TabIndex = 29
        '
        'txtRagioneSociale
        '
        Me.txtRagioneSociale.Location = New System.Drawing.Point(204, 14)
        Me.txtRagioneSociale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRagioneSociale.Name = "txtRagioneSociale"
        Me.txtRagioneSociale.Size = New System.Drawing.Size(548, 32)
        Me.txtRagioneSociale.TabIndex = 25
        '
        'mcTipo
        '
        Me.mcTipo.AllowAllUnchecked = False
        Me.mcTipo.UseContextMenu = False
        '
        'DataGridViewBooleanImageColumn1
        '
        Me.DataGridViewBooleanImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewBooleanImageColumn1.DataPropertyName = "CreaAutomatico"
        Me.DataGridViewBooleanImageColumn1.HeaderText = "Crea automatico"
        Me.DataGridViewBooleanImageColumn1.ImageFalse = Nothing
        Me.DataGridViewBooleanImageColumn1.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.DataGridViewBooleanImageColumn1.Name = "DataGridViewBooleanImageColumn1"
        Me.DataGridViewBooleanImageColumn1.ReadOnly = True
        Me.DataGridViewBooleanImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBooleanImageColumn1.ValueFalse = "False"
        Me.DataGridViewBooleanImageColumn1.ValueTrue = "True"
        Me.DataGridViewBooleanImageColumn1.Width = 60
        '
        'mcRuolo
        '
        Me.mcRuolo.AllowAllUnchecked = False
        Me.mcRuolo.UseContextMenu = False
        '
        'dgvcId
        '
        Me.dgvcId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcId.DataPropertyName = "Id"
        Me.dgvcId.HeaderText = "Id"
        Me.dgvcId.Name = "dgvcId"
        Me.dgvcId.ReadOnly = True
        Me.dgvcId.Width = 80
        '
        'dgvcRagSoc
        '
        Me.dgvcRagSoc.DataPropertyName = "RagioneSociale"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvcRagSoc.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcRagSoc.FillWeight = 60.0!
        Me.dgvcRagSoc.HeaderText = "Azienda"
        Me.dgvcRagSoc.Name = "dgvcRagSoc"
        Me.dgvcRagSoc.ReadOnly = True
        '
        'dgvcSede
        '
        Me.dgvcSede.DataPropertyName = "Localita"
        Me.dgvcSede.FillWeight = 40.0!
        Me.dgvcSede.HeaderText = "Sede"
        Me.dgvcSede.Name = "dgvcSede"
        Me.dgvcSede.ReadOnly = True
        '
        'dgvcPartitaIva
        '
        Me.dgvcPartitaIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPartitaIva.DataPropertyName = "PartitaIva"
        Me.dgvcPartitaIva.HeaderText = "Partita IVA"
        Me.dgvcPartitaIva.Name = "dgvcPartitaIva"
        Me.dgvcPartitaIva.ReadOnly = True
        Me.dgvcPartitaIva.Width = 160
        '
        'dgvcFornitore
        '
        Me.dgvcFornitore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcFornitore.HeaderText = "Forn."
        Me.dgvcFornitore.Name = "dgvcFornitore"
        Me.dgvcFornitore.ReadOnly = True
        Me.dgvcFornitore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcFornitore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcFornitore.Width = 90
        '
        'dgvcRicevitore
        '
        Me.dgvcRicevitore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcRicevitore.HeaderText = "Ric."
        Me.dgvcRicevitore.Name = "dgvcRicevitore"
        Me.dgvcRicevitore.ReadOnly = True
        Me.dgvcRicevitore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcRicevitore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcRicevitore.Width = 90
        '
        'dgvcTipo
        '
        Me.dgvcTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcTipo.HeaderText = "Tipo"
        Me.dgvcTipo.Name = "dgvcTipo"
        Me.dgvcTipo.ReadOnly = True
        Me.dgvcTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcTipo.Width = 60
        '
        'FElencoAziendeAllegato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1764, 1194)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FElencoAziendeAllegato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco aziende riferite negli allegati"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmGrid.ResumeLayout(False)
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuova As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvElenco As System.Windows.Forms.DataGridView
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPartitaIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSede As System.Windows.Forms.TextBox
    Friend WithEvents txtRagioneSociale As System.Windows.Forms.TextBox
    Friend WithEvents chkTipoNonSocio As System.Windows.Forms.CheckBox
    Friend WithEvents chkTipoSocio As System.Windows.Forms.CheckBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCerca As System.Windows.Forms.Button
    Friend WithEvents mcTipo As mdsUIControls.MultiCheck
    Friend WithEvents dgvcProtocollo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcAnno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcScadRifPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcStato As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAzienda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkRuoloRic As CheckBox
    Friend WithEvents chkRuoloForn As CheckBox
    Friend WithEvents mcRuolo As mdsUIControls.MultiCheck
    Friend WithEvents tsbSeleziona As ToolStripButton
    Friend WithEvents dgvcId As DataGridViewTextBoxColumn
    Friend WithEvents dgvcRagSoc As DataGridViewTextBoxColumn
    Friend WithEvents dgvcSede As DataGridViewTextBoxColumn
    Friend WithEvents dgvcPartitaIva As DataGridViewTextBoxColumn
    Friend WithEvents dgvcFornitore As DataGridViewImageColumn
    Friend WithEvents dgvcRicevitore As DataGridViewImageColumn
    Friend WithEvents dgvcTipo As DataGridViewImageColumn
End Class
