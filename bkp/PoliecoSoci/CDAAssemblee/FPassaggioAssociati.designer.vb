<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPassaggioAssociati
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPassaggioAssociati))
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.dgvcMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCodice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRagSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCodFisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDataCDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsElenco = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ccMotivo = New mdsUIControls.ucCheckedCombo()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lSel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lTot = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelAll = New System.Windows.Forms.ToolStripButton()
        Me.tsbAction = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbRiunioni = New System.Windows.Forms.ComboBox()
        Me.pnlTipo = New System.Windows.Forms.Panel()
        Me.lDescrTipo = New System.Windows.Forms.Label()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.pnlTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvElenco
        '
        Me.dgvElenco.AllowUserToAddRows = False
        Me.dgvElenco.AllowUserToDeleteRows = False
        Me.dgvElenco.AllowUserToResizeColumns = False
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvElenco.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcMotivo, Me.dgvcCodice, Me.dgvcRagSoc, Me.dgvcCategoria, Me.dgvcCodFisc, Me.dgvcPIva, Me.dgvcDataCDA})
        Me.dgvElenco.DataSource = Me.bsElenco
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvElenco.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 41)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersWidth = 20
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1169, 483)
        Me.dgvElenco.TabIndex = 6
        '
        'dgvcMotivo
        '
        Me.dgvcMotivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMotivo.DataPropertyName = "Motivo"
        Me.dgvcMotivo.HeaderText = "Motivo"
        Me.dgvcMotivo.Name = "dgvcMotivo"
        Me.dgvcMotivo.ReadOnly = True
        Me.dgvcMotivo.Width = 160
        '
        'dgvcCodice
        '
        Me.dgvcCodice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodice.DataPropertyName = "Id"
        Me.dgvcCodice.FillWeight = 194.5946!
        Me.dgvcCodice.HeaderText = "Codice"
        Me.dgvcCodice.Name = "dgvcCodice"
        Me.dgvcCodice.ReadOnly = True
        Me.dgvcCodice.Width = 80
        '
        'dgvcRagSoc
        '
        Me.dgvcRagSoc.DataPropertyName = "RagioneSociale"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcRagSoc.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcRagSoc.FillWeight = 81.08109!
        Me.dgvcRagSoc.HeaderText = "Ragione Sociale"
        Me.dgvcRagSoc.Name = "dgvcRagSoc"
        Me.dgvcRagSoc.ReadOnly = True
        '
        'dgvcCategoria
        '
        Me.dgvcCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCategoria.DataPropertyName = "CodCategoria"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcCategoria.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcCategoria.FillWeight = 81.08109!
        Me.dgvcCategoria.HeaderText = "Categoria"
        Me.dgvcCategoria.Name = "dgvcCategoria"
        Me.dgvcCategoria.ReadOnly = True
        Me.dgvcCategoria.Width = 80
        '
        'dgvcCodFisc
        '
        Me.dgvcCodFisc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodFisc.DataPropertyName = "CodiceFiscale"
        Me.dgvcCodFisc.FillWeight = 81.08109!
        Me.dgvcCodFisc.HeaderText = "Codice Fiscale"
        Me.dgvcCodFisc.Name = "dgvcCodFisc"
        Me.dgvcCodFisc.ReadOnly = True
        Me.dgvcCodFisc.Width = 150
        '
        'dgvcPIva
        '
        Me.dgvcPIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPIva.DataPropertyName = "PartitaIVA"
        Me.dgvcPIva.FillWeight = 81.08109!
        Me.dgvcPIva.HeaderText = "Partita IVA"
        Me.dgvcPIva.Name = "dgvcPIva"
        Me.dgvcPIva.ReadOnly = True
        Me.dgvcPIva.Width = 140
        '
        'dgvcDataCDA
        '
        Me.dgvcDataCDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDataCDA.DataPropertyName = "DataPassaggioCDA"
        DataGridViewCellStyle3.Format = "d"
        Me.dgvcDataCDA.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcDataCDA.FillWeight = 81.08109!
        Me.dgvcDataCDA.HeaderText = "Data CDA"
        Me.dgvcDataCDA.Name = "dgvcDataCDA"
        Me.dgvcDataCDA.ReadOnly = True
        Me.dgvcDataCDA.Width = 120
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlTipo)
        Me.Panel1.Controls.Add(Me.cbTipo)
        Me.Panel1.Controls.Add(Me.ccMotivo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 41)
        Me.Panel1.TabIndex = 7
        '
        'ccMotivo
        '
        Me.ccMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccMotivo.Checked = False
        Me.ccMotivo.CheckText = "Solo "
        Me.ccMotivo.CheckWidth = 60
        Me.ccMotivo.ComboText = ""
        Me.ccMotivo.DataSource = Nothing
        Me.ccMotivo.DisplayMember = ""
        Me.ccMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccMotivo.Location = New System.Drawing.Point(249, 9)
        Me.ccMotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.ccMotivo.MaxDropDownItems = 8
        Me.ccMotivo.Name = "ccMotivo"
        Me.ccMotivo.SelectedIndex = -1
        Me.ccMotivo.SelectedValue = Nothing
        Me.ccMotivo.Size = New System.Drawing.Size(294, 26)
        Me.ccMotivo.TabIndex = 1
        Me.ccMotivo.ValueFieldName = Nothing
        Me.ccMotivo.ValueMember = ""
        Me.ccMotivo.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'pnlBottom
        '
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.lSel)
        Me.pnlBottom.Controls.Add(Me.Label3)
        Me.pnlBottom.Controls.Add(Me.lTot)
        Me.pnlBottom.Controls.Add(Me.Label1)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 524)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1169, 45)
        Me.pnlBottom.TabIndex = 8
        '
        'lSel
        '
        Me.lSel.BackColor = System.Drawing.Color.White
        Me.lSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lSel.Location = New System.Drawing.Point(315, 14)
        Me.lSel.Name = "lSel"
        Me.lSel.Size = New System.Drawing.Size(91, 24)
        Me.lSel.TabIndex = 3
        Me.lSel.Text = "0"
        Me.lSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Selezionati:"
        '
        'lTot
        '
        Me.lTot.BackColor = System.Drawing.Color.White
        Me.lTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTot.Location = New System.Drawing.Point(108, 14)
        Me.lTot.Name = "lTot"
        Me.lTot.Size = New System.Drawing.Size(91, 24)
        Me.lTot.TabIndex = 1
        Me.lTot.Text = "0"
        Me.lTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero soci:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Motivo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn2.FillWeight = 194.5946!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codice"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RagioneSociale"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.FillWeight = 81.08109!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ragione Sociale"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 417
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CodCategoria"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.FillWeight = 81.08109!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CodiceFiscale"
        Me.DataGridViewTextBoxColumn5.FillWeight = 81.08109!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Codice Fiscale"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PartitaIVA"
        Me.DataGridViewTextBoxColumn6.FillWeight = 81.08109!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Partita IVA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 140
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataCDA"
        DataGridViewCellStyle7.Format = "d"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.FillWeight = 81.08109!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Data CDA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
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
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(132, 42)
        Me.tsbModifica.Text = "Scheda socio"
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
        Me.tsbChiudi.Size = New System.Drawing.Size(93, 42)
        Me.tsbChiudi.Text = "&Chiudi"
        '
        'tsbSelAll
        '
        Me.tsbSelAll.Image = Global.PoliecoSoci.My.Resources.Resources.List_32_n_g
        Me.tsbSelAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSelAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelAll.Name = "tsbSelAll"
        Me.tsbSelAll.Size = New System.Drawing.Size(145, 42)
        Me.tsbSelAll.Text = "Seleziona tutto"
        '
        'tsbAction
        '
        Me.tsbAction.Image = Global.PoliecoSoci.My.Resources.Resources.Next_Document_32_n_g
        Me.tsbAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAction.Name = "tsbAction"
        Me.tsbAction.Size = New System.Drawing.Size(167, 42)
        Me.tsbAction.Text = "Imposta data CDA"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(96, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbModifica, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbSelAll, Me.tsbAction, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 569)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1169, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Da passare", "Passati"})
        Me.cbTipo.Location = New System.Drawing.Point(15, 9)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(209, 24)
        Me.cbTipo.TabIndex = 2
        '
        'cbRiunioni
        '
        Me.cbRiunioni.FormattingEnabled = True
        Me.cbRiunioni.Items.AddRange(New Object() {"Da passare", "Passati"})
        Me.cbRiunioni.Location = New System.Drawing.Point(130, 1)
        Me.cbRiunioni.Name = "cbRiunioni"
        Me.cbRiunioni.Size = New System.Drawing.Size(181, 24)
        Me.cbRiunioni.TabIndex = 3
        '
        'pnlTipo
        '
        Me.pnlTipo.Controls.Add(Me.lDescrTipo)
        Me.pnlTipo.Controls.Add(Me.cbRiunioni)
        Me.pnlTipo.Location = New System.Drawing.Point(565, 9)
        Me.pnlTipo.Name = "pnlTipo"
        Me.pnlTipo.Size = New System.Drawing.Size(326, 26)
        Me.pnlTipo.TabIndex = 4
        '
        'lDescrTipo
        '
        Me.lDescrTipo.Location = New System.Drawing.Point(3, 0)
        Me.lDescrTipo.Name = "lDescrTipo"
        Me.lDescrTipo.Size = New System.Drawing.Size(121, 21)
        Me.lDescrTipo.TabIndex = 4
        Me.lDescrTipo.Text = "Asssemblea del:"
        Me.lDescrTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FPassaggioAssociati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 614)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FPassaggioAssociati"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passaggio associati"
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsElenco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlTipo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvElenco As System.Windows.Forms.DataGridView
    Friend WithEvents bsElenco As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ccMotivo As mdsUIControls.ucCheckedCombo
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lSel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lTot As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvcMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCodice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcRagSoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCodFisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcPIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDataCDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSelAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAction As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlTipo As System.Windows.Forms.Panel
    Friend WithEvents lDescrTipo As System.Windows.Forms.Label
    Friend WithEvents cbRiunioni As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
End Class
