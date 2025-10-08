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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.dgvcRagSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
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
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsbDettaglio = New System.Windows.Forms.ToolStripButton()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.btnHelpImporto = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 10)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(160, 24)
        Label1.TabIndex = 24
        Label1.Text = "Ragione sociale :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(487, 10)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(107, 24)
        Label5.TabIndex = 32
        Label5.Text = "Categoria :"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDettaglio, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 1019)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1518, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
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
        Me.dgvElenco.Location = New System.Drawing.Point(0, 162)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.RowHeadersWidth = 51
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1518, 776)
        Me.dgvElenco.TabIndex = 6
        '
        'dgvcRagSoc
        '
        Me.dgvcRagSoc.DataPropertyName = "RagioneSociale"
        Me.dgvcRagSoc.HeaderText = "Ragione sociale"
        Me.dgvcRagSoc.MinimumWidth = 800
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
        Me.dgvcAnno.MinimumWidth = 6
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
        Me.dgvcProv.MinimumWidth = 6
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
        Me.dgvcCat.MinimumWidth = 6
        Me.dgvcCat.Name = "dgvcCat"
        Me.dgvcCat.ReadOnly = True
        Me.dgvcCat.Width = 110
        '
        'dgvcMateria
        '
        Me.dgvcMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMateria.DataPropertyName = "CodTipo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvcMateria.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvcMateria.FillWeight = 50.0!
        Me.dgvcMateria.HeaderText = "Materia"
        Me.dgvcMateria.MinimumWidth = 6
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
        Me.dgvcPeso.MinimumWidth = 6
        Me.dgvcPeso.Name = "dgvcPeso"
        Me.dgvcPeso.ReadOnly = True
        Me.dgvcPeso.Width = 120
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
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1518, 162)
        Me.pnlTop.TabIndex = 7
        '
        'chkNoNull
        '
        Me.chkNoNull.AutoSize = True
        Me.chkNoNull.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNoNull.Checked = True
        Me.chkNoNull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoNull.Location = New System.Drawing.Point(1070, 57)
        Me.chkNoNull.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNoNull.Name = "chkNoNull"
        Me.chkNoNull.Size = New System.Drawing.Size(191, 28)
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
        Me.cbUm.Location = New System.Drawing.Point(1031, 10)
        Me.cbUm.Margin = New System.Windows.Forms.Padding(6)
        Me.cbUm.Name = "cbUm"
        Me.cbUm.Size = New System.Drawing.Size(86, 32)
        Me.cbUm.TabIndex = 48
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(1129, 10)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(135, 32)
        Me.txtPeso.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(971, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Peso:"
        '
        'cbMateriale
        '
        Me.cbMateriale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbMateriale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMateriale.FormattingEnabled = True
        Me.cbMateriale.Location = New System.Drawing.Point(606, 54)
        Me.cbMateriale.Margin = New System.Windows.Forms.Padding(6)
        Me.cbMateriale.Name = "cbMateriale"
        Me.cbMateriale.Size = New System.Drawing.Size(278, 32)
        Me.cbMateriale.TabIndex = 45
        '
        'cbCatMateria
        '
        Me.cbCatMateria.AutoSize = True
        Me.cbCatMateria.Location = New System.Drawing.Point(487, 62)
        Me.cbCatMateria.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.cbCatMateria.Name = "cbCatMateria"
        Me.cbCatMateria.Size = New System.Drawing.Size(100, 24)
        Me.cbCatMateria.TabIndex = 44
        Me.cbCatMateria.Text = "Materiale:"
        '
        'cbProvincia
        '
        Me.cbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(183, 102)
        Me.cbProvincia.Margin = New System.Windows.Forms.Padding(6)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(252, 32)
        Me.cbProvincia.TabIndex = 43
        '
        'cbRegione
        '
        Me.cbRegione.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbRegione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRegione.FormattingEnabled = True
        Me.cbRegione.Location = New System.Drawing.Point(183, 54)
        Me.cbRegione.Margin = New System.Windows.Forms.Padding(6)
        Me.cbRegione.Name = "cbRegione"
        Me.cbRegione.Size = New System.Drawing.Size(252, 32)
        Me.cbRegione.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 110)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 24)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 24)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Regione:"
        '
        'chkCatE
        '
        Me.chkCatE.AutoSize = True
        Me.chkCatE.Location = New System.Drawing.Point(850, 10)
        Me.chkCatE.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatE.Name = "chkCatE"
        Me.chkCatE.Size = New System.Drawing.Size(43, 28)
        Me.chkCatE.TabIndex = 39
        Me.chkCatE.Text = "E"
        Me.chkCatE.UseVisualStyleBackColor = True
        '
        'chkCatD
        '
        Me.chkCatD.AutoSize = True
        Me.chkCatD.Location = New System.Drawing.Point(788, 10)
        Me.chkCatD.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatD.Name = "chkCatD"
        Me.chkCatD.Size = New System.Drawing.Size(45, 28)
        Me.chkCatD.TabIndex = 36
        Me.chkCatD.Text = "D"
        Me.chkCatD.UseVisualStyleBackColor = True
        '
        'chkCatC
        '
        Me.chkCatC.AutoSize = True
        Me.chkCatC.Location = New System.Drawing.Point(727, 10)
        Me.chkCatC.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatC.Name = "chkCatC"
        Me.chkCatC.Size = New System.Drawing.Size(45, 28)
        Me.chkCatC.TabIndex = 35
        Me.chkCatC.Text = "C"
        Me.chkCatC.UseVisualStyleBackColor = True
        '
        'chkCatB
        '
        Me.chkCatB.AutoSize = True
        Me.chkCatB.Location = New System.Drawing.Point(667, 10)
        Me.chkCatB.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatB.Name = "chkCatB"
        Me.chkCatB.Size = New System.Drawing.Size(44, 28)
        Me.chkCatB.TabIndex = 34
        Me.chkCatB.Text = "B"
        Me.chkCatB.UseVisualStyleBackColor = True
        '
        'chkCatA
        '
        Me.chkCatA.AutoSize = True
        Me.chkCatA.Location = New System.Drawing.Point(606, 10)
        Me.chkCatA.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCatA.Name = "chkCatA"
        Me.chkCatA.Size = New System.Drawing.Size(45, 28)
        Me.chkCatA.TabIndex = 33
        Me.chkCatA.Text = "A"
        Me.chkCatA.UseVisualStyleBackColor = True
        '
        'txtRagioneSociale
        '
        Me.txtRagioneSociale.Location = New System.Drawing.Point(183, 10)
        Me.txtRagioneSociale.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRagioneSociale.Name = "txtRagioneSociale"
        Me.txtRagioneSociale.Size = New System.Drawing.Size(252, 32)
        Me.txtRagioneSociale.TabIndex = 25
        '
        'ccAnno
        '
        Me.ccAnno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccAnno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccAnno.Checked = False
        Me.ccAnno.CheckText = "Anno:"
        Me.ccAnno.CheckWidth = 160
        Me.ccAnno.ComboText = ""
        Me.ccAnno.DataSource = Nothing
        Me.ccAnno.DisplayMember = ""
        Me.ccAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ccAnno.Location = New System.Drawing.Point(491, 102)
        Me.ccAnno.Margin = New System.Windows.Forms.Padding(6)
        Me.ccAnno.MaxDropDownItems = 8
        Me.ccAnno.Name = "ccAnno"
        Me.ccAnno.SelectedIndex = -1
        Me.ccAnno.SelectedValue = Nothing
        Me.ccAnno.Size = New System.Drawing.Size(249, 39)
        Me.ccAnno.TabIndex = 2
        Me.ccAnno.ValueFieldName = Nothing
        Me.ccAnno.ValueMember = ""
        Me.ccAnno.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'mcCat
        '
        Me.mcCat.AllowAllUnchecked = False
        Me.mcCat.UseContextMenu = False
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lTotPeso)
        Me.pnlBottom.Controls.Add(Me.dgslPeso)
        Me.pnlBottom.Controls.Add(Me.lTotVoci)
        Me.pnlBottom.Controls.Add(Me.Label3)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 938)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1518, 81)
        Me.pnlBottom.TabIndex = 8
        '
        'lTotPeso
        '
        Me.lTotPeso.AutoSize = True
        Me.lTotPeso.Location = New System.Drawing.Point(993, 30)
        Me.lTotPeso.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lTotPeso.Name = "lTotPeso"
        Me.lTotPeso.Size = New System.Drawing.Size(112, 24)
        Me.lTotPeso.TabIndex = 45
        Me.lTotPeso.Text = "Totale (Tn):"
        '
        'dgslPeso
        '
        Me.dgslPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgslPeso.DataFormat = "N2"
        Me.dgslPeso.GridColumn = Nothing
        Me.dgslPeso.GridMargin = 10
        Me.dgslPeso.HorizontalOffset = 0
        Me.dgslPeso.Location = New System.Drawing.Point(1114, 30)
        Me.dgslPeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dgslPeso.Name = "dgslPeso"
        Me.dgslPeso.PartialSummaryActive = False
        Me.dgslPeso.Size = New System.Drawing.Size(137, 29)
        Me.dgslPeso.SummaryMemberName = Nothing
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
        Me.lTotVoci.Location = New System.Drawing.Point(140, 30)
        Me.lTotVoci.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lTotVoci.Name = "lTotVoci"
        Me.lTotVoci.Size = New System.Drawing.Size(134, 30)
        Me.lTotVoci.TabIndex = 43
        Me.lTotVoci.Text = "0"
        Me.lTotVoci.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Totale voci:"
        '
        'tsbDettaglio
        '
        Me.tsbDettaglio.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbDettaglio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDettaglio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDettaglio.Name = "tsbDettaglio"
        Me.tsbDettaglio.Size = New System.Drawing.Size(127, 42)
        Me.tsbDettaglio.Text = "Dettaglio"
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
        '
        'btnHelpImporto
        '
        Me.btnHelpImporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpImporto.Image = Global.PoliecoSoci.My.Resources.Resources.Info_Round_Blue_24_n_p8
        Me.btnHelpImporto.Location = New System.Drawing.Point(1275, 10)
        Me.btnHelpImporto.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHelpImporto.Name = "btnHelpImporto"
        Me.btnHelpImporto.Size = New System.Drawing.Size(34, 33)
        Me.btnHelpImporto.TabIndex = 50
        Me.btnHelpImporto.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Image = Global.PoliecoSoci.My.Resources.Resources.Show_Grid_24_n_g
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(1341, 87)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6)
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
        Me.btnCerca.Location = New System.Drawing.Point(1341, 14)
        Me.btnCerca.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(160, 62)
        Me.btnCerca.TabIndex = 37
        Me.btnCerca.Text = "    Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'DataGridViewBooleanImageColumn1
        '
        Me.DataGridViewBooleanImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewBooleanImageColumn1.DataPropertyName = "CreaAutomatico"
        Me.DataGridViewBooleanImageColumn1.HeaderText = "Crea automatico"
        Me.DataGridViewBooleanImageColumn1.ImageFalse = Nothing
        Me.DataGridViewBooleanImageColumn1.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.DataGridViewBooleanImageColumn1.MinimumWidth = 6
        Me.DataGridViewBooleanImageColumn1.Name = "DataGridViewBooleanImageColumn1"
        Me.DataGridViewBooleanImageColumn1.ReadOnly = True
        Me.DataGridViewBooleanImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBooleanImageColumn1.ValueFalse = "False"
        Me.DataGridViewBooleanImageColumn1.ValueTrue = "True"
        Me.DataGridViewBooleanImageColumn1.Width = 60
        '
        'FRicercaQuantitativi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1524, 1064)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FRicercaQuantitativi"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco dichiarazioni compilate on-line"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chkNoNull As System.Windows.Forms.CheckBox
    Friend WithEvents btnHelpImporto As System.Windows.Forms.Button
    Friend WithEvents dgvcRagSoc As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAnno As DataGridViewTextBoxColumn
    Friend WithEvents dgvcProv As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCat As DataGridViewTextBoxColumn
    Friend WithEvents dgvcMateria As DataGridViewTextBoxColumn
    Friend WithEvents dgvcPeso As DataGridViewTextBoxColumn
End Class
