<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRicercaQuantitativi
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRicercaQuantitativi))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbDettaglio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.dgvcRagSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnHelpImporto = New System.Windows.Forms.Button()
        Me.chkNoNull = New System.Windows.Forms.CheckBox()
        Me.cbUm = New System.Windows.Forms.ComboBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMateriale = New System.Windows.Forms.ComboBox()
        Me.cbCatMateria = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbRegione = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkCatE = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.chkCatD = New System.Windows.Forms.CheckBox()
        Me.chkCatC = New System.Windows.Forms.CheckBox()
        Me.chkCatB = New System.Windows.Forms.CheckBox()
        Me.chkCatA = New System.Windows.Forms.CheckBox()
        Me.txtRagioneSociale = New System.Windows.Forms.TextBox()
        Me.ccAnno = New mdsUIControls.ucCheckedCombo()
        Me.mcCat = New mdsUIControls.MultiCheck(Me.components)
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lTotPeso = New System.Windows.Forms.Label()
        Me.dgslPeso = New mdsUIControls.DataGridSummaryLabel()
        Me.lTotVoci = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(117, 17)
        Label1.TabIndex = 24
        Label1.Text = "Ragione sociale :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(354, 7)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(77, 17)
        Label5.TabIndex = 32
        Label5.Text = "Categoria :"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDettaglio, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 664)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1104, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbDettaglio
        '
        Me.tsbDettaglio.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbDettaglio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDettaglio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDettaglio.Name = "tsbDettaglio"
        Me.tsbDettaglio.Size = New System.Drawing.Size(108, 42)
        Me.tsbDettaglio.Text = "Dettaglio"
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
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Margin = New System.Windows.Forms.Padding(60, 1, 0, 2)
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(96, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'dgvElenco
        '
        Me.dgvElenco.AllowUserToAddRows = False
        Me.dgvElenco.AllowUserToDeleteRows = False
        Me.dgvElenco.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvElenco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcRagSoc, Me.dgvcAnno, Me.dgvcProv, Me.dgvcCat, Me.dgvcMateria, Me.dgvcPeso})
        Me.dgvElenco.DataSource = Me.bsData
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 108)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1104, 502)
        Me.dgvElenco.TabIndex = 6
        '
        'dgvcRagSoc
        '
        Me.dgvcRagSoc.DataPropertyName = "RagioneSociale"
        Me.dgvcRagSoc.HeaderText = "Ragione sociale"
        Me.dgvcRagSoc.Name = "dgvcRagSoc"
        Me.dgvcRagSoc.ReadOnly = True
        '
        'dgvcAnno
        '
        Me.dgvcAnno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAnno.DataPropertyName = "Anno"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcAnno.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcAnno.HeaderText = "Anno"
        Me.dgvcAnno.Name = "dgvcAnno"
        Me.dgvcAnno.ReadOnly = True
        Me.dgvcAnno.Width = 80
        '
        'dgvcProv
        '
        Me.dgvcProv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcProv.DataPropertyName = "Provincia"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcProv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcProv.FillWeight = 50.0!
        Me.dgvcProv.HeaderText = "Prov."
        Me.dgvcProv.Name = "dgvcProv"
        Me.dgvcProv.ReadOnly = True
        Me.dgvcProv.Width = 60
        '
        'dgvcCat
        '
        Me.dgvcCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCat.DataPropertyName = "CodCategoria"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcCat.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcCat.HeaderText = "Categoria"
        Me.dgvcCat.Name = "dgvcCat"
        Me.dgvcCat.ReadOnly = True
        Me.dgvcCat.Width = 80
        '
        'dgvcMateria
        '
        Me.dgvcMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMateria.DataPropertyName = "CodTipo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvcMateria.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvcMateria.FillWeight = 50.0!
        Me.dgvcMateria.HeaderText = "Materia"
        Me.dgvcMateria.Name = "dgvcMateria"
        Me.dgvcMateria.ReadOnly = True
        Me.dgvcMateria.Width = 240
        '
        'dgvcPeso
        '
        Me.dgvcPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPeso.DataPropertyName = "_ValoreTn"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.dgvcPeso.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcPeso.HeaderText = "Peso (Tn)"
        Me.dgvcPeso.Name = "dgvcPeso"
        Me.dgvcPeso.ReadOnly = True
        Me.dgvcPeso.Width = 120
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
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnHelpImporto)
        Me.pnlTop.Controls.Add(Me.chkNoNull)
        Me.pnlTop.Controls.Add(Me.cbUm)
        Me.pnlTop.Controls.Add(Me.txtPeso)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.cbMateriale)
        Me.pnlTop.Controls.Add(Me.cbCatMateria)
        Me.pnlTop.Controls.Add(Me.cbProvincia)
        Me.pnlTop.Controls.Add(Me.cbRegione)
        Me.pnlTop.Controls.Add(Me.Label6)
        Me.pnlTop.Controls.Add(Me.Label7)
        Me.pnlTop.Controls.Add(Me.chkCatE)
        Me.pnlTop.Controls.Add(Me.btnReset)
        Me.pnlTop.Controls.Add(Me.btnCerca)
        Me.pnlTop.Controls.Add(Me.chkCatD)
        Me.pnlTop.Controls.Add(Me.chkCatC)
        Me.pnlTop.Controls.Add(Me.chkCatB)
        Me.pnlTop.Controls.Add(Me.chkCatA)
        Me.pnlTop.Controls.Add(Label5)
        Me.pnlTop.Controls.Add(Me.txtRagioneSociale)
        Me.pnlTop.Controls.Add(Label1)
        Me.pnlTop.Controls.Add(Me.ccAnno)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1104, 108)
        Me.pnlTop.TabIndex = 7
        '
        'btnHelpImporto
        '
        Me.btnHelpImporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpImporto.Image = Global.PoliecoSoci.My.Resources.Resources.Info_Round_Blue_16_n_g
        Me.btnHelpImporto.Location = New System.Drawing.Point(927, 7)
        Me.btnHelpImporto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelpImporto.Name = "btnHelpImporto"
        Me.btnHelpImporto.Size = New System.Drawing.Size(25, 22)
        Me.btnHelpImporto.TabIndex = 50
        Me.btnHelpImporto.UseVisualStyleBackColor = True
        '
        'chkNoNull
        '
        Me.chkNoNull.AutoSize = True
        Me.chkNoNull.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoNull.Checked = True
        Me.chkNoNull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoNull.Location = New System.Drawing.Point(778, 38)
        Me.chkNoNull.Name = "chkNoNull"
        Me.chkNoNull.Size = New System.Drawing.Size(142, 21)
        Me.chkNoNull.TabIndex = 49
        Me.chkNoNull.Text = "Escludi valori nulli"
        Me.chkNoNull.UseVisualStyleBackColor = True
        '
        'cbUm
        '
        Me.cbUm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbUm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUm.FormattingEnabled = True
        Me.cbUm.Items.AddRange(New Object() {"Tn", "Kg"})
        Me.cbUm.Location = New System.Drawing.Point(750, 7)
        Me.cbUm.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUm.Name = "cbUm"
        Me.cbUm.Size = New System.Drawing.Size(64, 24)
        Me.cbUm.TabIndex = 48
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(821, 7)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(99, 22)
        Me.txtPeso.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(706, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Peso:"
        '
        'cbMateriale
        '
        Me.cbMateriale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbMateriale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMateriale.FormattingEnabled = True
        Me.cbMateriale.Location = New System.Drawing.Point(441, 36)
        Me.cbMateriale.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMateriale.Name = "cbMateriale"
        Me.cbMateriale.Size = New System.Drawing.Size(203, 24)
        Me.cbMateriale.TabIndex = 45
        '
        'cbCatMateria
        '
        Me.cbCatMateria.AutoSize = True
        Me.cbCatMateria.Location = New System.Drawing.Point(354, 41)
        Me.cbCatMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cbCatMateria.Name = "cbCatMateria"
        Me.cbCatMateria.Size = New System.Drawing.Size(70, 17)
        Me.cbCatMateria.TabIndex = 44
        Me.cbCatMateria.Text = "Materiale:"
        '
        'cbProvincia
        '
        Me.cbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(133, 68)
        Me.cbProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(184, 24)
        Me.cbProvincia.TabIndex = 43
        '
        'cbRegione
        '
        Me.cbRegione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbRegione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRegione.FormattingEnabled = True
        Me.cbRegione.Location = New System.Drawing.Point(133, 36)
        Me.cbRegione.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRegione.Name = "cbRegione"
        Me.cbRegione.Size = New System.Drawing.Size(184, 24)
        Me.cbRegione.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Regione:"
        '
        'chkCatE
        '
        Me.chkCatE.AutoSize = True
        Me.chkCatE.Location = New System.Drawing.Point(618, 7)
        Me.chkCatE.Name = "chkCatE"
        Me.chkCatE.Size = New System.Drawing.Size(39, 21)
        Me.chkCatE.TabIndex = 39
        Me.chkCatE.Text = "E"
        Me.chkCatE.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Image = Global.PoliecoSoci.My.Resources.Resources.Show_Grid_24_n_g
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(975, 58)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 44)
        Me.btnReset.TabIndex = 38
        Me.btnReset.Text = "       Ripristina"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.Image = Global.PoliecoSoci.My.Resources.Resources.Search_24_n_g
        Me.btnCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerca.Location = New System.Drawing.Point(975, 9)
        Me.btnCerca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(116, 41)
        Me.btnCerca.TabIndex = 37
        Me.btnCerca.Text = "    Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'chkCatD
        '
        Me.chkCatD.AutoSize = True
        Me.chkCatD.Location = New System.Drawing.Point(573, 7)
        Me.chkCatD.Name = "chkCatD"
        Me.chkCatD.Size = New System.Drawing.Size(40, 21)
        Me.chkCatD.TabIndex = 36
        Me.chkCatD.Text = "D"
        Me.chkCatD.UseVisualStyleBackColor = True
        '
        'chkCatC
        '
        Me.chkCatC.AutoSize = True
        Me.chkCatC.Location = New System.Drawing.Point(529, 7)
        Me.chkCatC.Name = "chkCatC"
        Me.chkCatC.Size = New System.Drawing.Size(39, 21)
        Me.chkCatC.TabIndex = 35
        Me.chkCatC.Text = "C"
        Me.chkCatC.UseVisualStyleBackColor = True
        '
        'chkCatB
        '
        Me.chkCatB.AutoSize = True
        Me.chkCatB.Location = New System.Drawing.Point(485, 7)
        Me.chkCatB.Name = "chkCatB"
        Me.chkCatB.Size = New System.Drawing.Size(39, 21)
        Me.chkCatB.TabIndex = 34
        Me.chkCatB.Text = "B"
        Me.chkCatB.UseVisualStyleBackColor = True
        '
        'chkCatA
        '
        Me.chkCatA.AutoSize = True
        Me.chkCatA.Location = New System.Drawing.Point(441, 7)
        Me.chkCatA.Name = "chkCatA"
        Me.chkCatA.Size = New System.Drawing.Size(39, 21)
        Me.chkCatA.TabIndex = 33
        Me.chkCatA.Text = "A"
        Me.chkCatA.UseVisualStyleBackColor = True
        '
        'txtRagioneSociale
        '
        Me.txtRagioneSociale.Location = New System.Drawing.Point(133, 7)
        Me.txtRagioneSociale.Name = "txtRagioneSociale"
        Me.txtRagioneSociale.Size = New System.Drawing.Size(184, 22)
        Me.txtRagioneSociale.TabIndex = 25
        '
        'ccAnno
        '
        Me.ccAnno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccAnno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccAnno.Checked = False
        Me.ccAnno.CheckText = "Anno:"
        Me.ccAnno.CheckWidth = 84
        Me.ccAnno.ComboText = ""
        Me.ccAnno.DataSource = Nothing
        Me.ccAnno.DisplayMember = ""
        Me.ccAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ccAnno.Location = New System.Drawing.Point(357, 68)
        Me.ccAnno.Margin = New System.Windows.Forms.Padding(4)
        Me.ccAnno.MaxDropDownItems = 8
        Me.ccAnno.Name = "ccAnno"
        Me.ccAnno.SelectedIndex = -1
        Me.ccAnno.SelectedValue = Nothing
        Me.ccAnno.Size = New System.Drawing.Size(181, 26)
        Me.ccAnno.TabIndex = 2
        Me.ccAnno.ValueFieldName = Nothing
        Me.ccAnno.ValueMember = ""
        Me.ccAnno.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'mcCat
        '
        Me.mcCat.AllowAllUnchecked = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lTotPeso)
        Me.pnlBottom.Controls.Add(Me.dgslPeso)
        Me.pnlBottom.Controls.Add(Me.lTotVoci)
        Me.pnlBottom.Controls.Add(Me.Label3)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 610)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1104, 54)
        Me.pnlBottom.TabIndex = 8
        '
        'lTotPeso
        '
        Me.lTotPeso.AutoSize = True
        Me.lTotPeso.Location = New System.Drawing.Point(722, 20)
        Me.lTotPeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTotPeso.Name = "lTotPeso"
        Me.lTotPeso.Size = New System.Drawing.Size(83, 17)
        Me.lTotPeso.TabIndex = 45
        Me.lTotPeso.Text = "Totale (Tn):"
        '
        'dgslPeso
        '
        Me.dgslPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgslPeso.DataFormat = "N2"
        Me.dgslPeso.GridColumn = Nothing
        Me.dgslPeso.GridMargin = 10
        Me.dgslPeso.Location = New System.Drawing.Point(810, 20)
        Me.dgslPeso.Name = "dgslPeso"
        Me.dgslPeso.PartialSummaryActive = False
        Me.dgslPeso.Size = New System.Drawing.Size(100, 20)
        Me.dgslPeso.SummaryOnSelection = False
        Me.dgslPeso.SummaryType = mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM
        Me.dgslPeso.TabIndex = 44
        Me.dgslPeso.Text = "0,00"
        Me.dgslPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dgslPeso.WeightColumn = Nothing
        '
        'lTotVoci
        '
        Me.lTotVoci.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lTotVoci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTotVoci.Location = New System.Drawing.Point(102, 20)
        Me.lTotVoci.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTotVoci.Name = "lTotVoci"
        Me.lTotVoci.Size = New System.Drawing.Size(98, 21)
        Me.lTotVoci.TabIndex = 43
        Me.lTotVoci.Text = "0"
        Me.lTotVoci.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Totale voci:"
        '
        'FRicercaQuantitativi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 709)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRicercaQuantitativi"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco dichiarazioni compilate on-line"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbDettaglio As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents ccAnno As mdsUIControls.ucCheckedCombo
    Friend WithEvents txtRagioneSociale As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCerca As System.Windows.Forms.Button
    Friend WithEvents mcCat As mdsUIControls.MultiCheck
    Friend WithEvents chkCatE As System.Windows.Forms.CheckBox
    Friend WithEvents chkCatD As System.Windows.Forms.CheckBox
    Friend WithEvents chkCatC As System.Windows.Forms.CheckBox
    Friend WithEvents chkCatB As System.Windows.Forms.CheckBox
    Friend WithEvents chkCatA As System.Windows.Forms.CheckBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMateriale As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatMateria As System.Windows.Forms.Label
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbRegione As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents lTotVoci As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgslPeso As mdsUIControls.DataGridSummaryLabel
    Friend WithEvents cbUm As System.Windows.Forms.ComboBox
    Friend WithEvents lTotPeso As System.Windows.Forms.Label
    Friend WithEvents dgvcRagSoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcAnno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcMateria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcPeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkNoNull As System.Windows.Forms.CheckBox
    Friend WithEvents btnHelpImporto As System.Windows.Forms.Button
End Class
