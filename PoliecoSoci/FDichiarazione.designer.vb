<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDichiarazione
    Inherits mdsUIControls.BaseForm

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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvDettaglio = New System.Windows.Forms.DataGridView()
        Me.dgvcDettCodQuadro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettProcedura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcDettPrezzoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettNetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettImpIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDettLordo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.rifArxivar = New ArxivarWCFWrapper.ucProtocolloArxivar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lAnno = New System.Windows.Forms.Label()
        Me.txtDataRicezione = New mdsUIControls.mdsDate()
        Me.txtDataProroga = New mdsUIControls.mdsDate()
        Me.lScadPagamento = New System.Windows.Forms.Label()
        Me.lScadDichiarazione = New System.Windows.Forms.Label()
        Me.lPeriodo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tsDettaglio = New System.Windows.Forms.ToolStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvIncassi = New System.Windows.Forms.DataGridView()
        Me.dgvcIncTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncModPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncDataPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncImporto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncScadenza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIncAcconto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlIncTot = New System.Windows.Forms.Panel()
        Me.lContrMin = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lDescrSaldo = New System.Windows.Forms.Label()
        Me.lSaldo = New System.Windows.Forms.Label()
        Me.lTotIncassi = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lTotDichiarazione = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tsbDettAdd = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbDettEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbDettDel = New System.Windows.Forms.ToolStripButton()
        Me.tsbIncAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbIncEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbIncDel = New System.Windows.Forms.ToolStripButton()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnStatoDoc = New System.Windows.Forms.Button()
        Me.lStatoIncasso = New System.Windows.Forms.Label()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbDOL = New System.Windows.Forms.ToolStripButton()
        Me.tsbAllegato = New System.Windows.Forms.ToolStripButton()
        Me.tsbProdotti = New System.Windows.Forms.ToolStripButton()
        Me.bsDettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsIncassi = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsMain.SuspendLayout()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tsDettaglio.SuspendLayout()
        CType(Me.dgvIncassi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlIncTot.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsIncassi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk, Me.tsbDOL, Me.tsbAllegato, Me.tsbProdotti})
        Me.tsMain.Location = New System.Drawing.Point(0, 505)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1008, 55)
        Me.tsMain.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Azienda:"
        '
        'lAzienda
        '
        Me.lAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(85, 9)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(883, 32)
        Me.lAzienda.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodCategoria", True))
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(85, 48)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(259, 21)
        Me.cbCategoria.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Anno / Periodo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(378, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Attrezzature"
        '
        'dgvDettaglio
        '
        Me.dgvDettaglio.AllowUserToAddRows = False
        Me.dgvDettaglio.AllowUserToDeleteRows = False
        Me.dgvDettaglio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDettaglio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcDettCodQuadro, Me.dgvcDettProcedura, Me.dgvcDettMateria, Me.dgvcDettUM, Me.dgvcDettPeso, Me.dgcDettPrezzoUnitario, Me.dgvcDettNetto, Me.dgvcDettIVA, Me.dgvcDettImpIVA, Me.dgvcDettLordo})
        Me.dgvDettaglio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDettaglio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDettaglio.Location = New System.Drawing.Point(0, 20)
        Me.dgvDettaglio.Name = "dgvDettaglio"
        Me.dgvDettaglio.ReadOnly = True
        Me.dgvDettaglio.RowHeadersWidth = 20
        Me.dgvDettaglio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDettaglio.Size = New System.Drawing.Size(970, 134)
        Me.dgvDettaglio.TabIndex = 70
        '
        'dgvcDettCodQuadro
        '
        Me.dgvcDettCodQuadro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettCodQuadro.DataPropertyName = "CodQuadro"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcDettCodQuadro.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcDettCodQuadro.HeaderText = "Quadro"
        Me.dgvcDettCodQuadro.Name = "dgvcDettCodQuadro"
        Me.dgvcDettCodQuadro.ReadOnly = True
        Me.dgvcDettCodQuadro.Width = 50
        '
        'dgvcDettProcedura
        '
        Me.dgvcDettProcedura.DataPropertyName = "Procedura"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcDettProcedura.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcDettProcedura.HeaderText = "Procedura"
        Me.dgvcDettProcedura.Name = "dgvcDettProcedura"
        Me.dgvcDettProcedura.ReadOnly = True
        '
        'dgvcDettMateria
        '
        Me.dgvcDettMateria.DataPropertyName = "Descrizione"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcDettMateria.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcDettMateria.HeaderText = "Materia prima"
        Me.dgvcDettMateria.Name = "dgvcDettMateria"
        Me.dgvcDettMateria.ReadOnly = True
        '
        'dgvcDettUM
        '
        Me.dgvcDettUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettUM.DataPropertyName = "CodUnitaMisura"
        Me.dgvcDettUM.HeaderText = "Unità Misura"
        Me.dgvcDettUM.Name = "dgvcDettUM"
        Me.dgvcDettUM.ReadOnly = True
        Me.dgvcDettUM.Width = 50
        '
        'dgvcDettPeso
        '
        Me.dgvcDettPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettPeso.DataPropertyName = "Valore"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.dgvcDettPeso.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcDettPeso.HeaderText = "Peso"
        Me.dgvcDettPeso.Name = "dgvcDettPeso"
        Me.dgvcDettPeso.ReadOnly = True
        Me.dgvcDettPeso.Width = 110
        '
        'dgcDettPrezzoUnitario
        '
        Me.dgcDettPrezzoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgcDettPrezzoUnitario.DataPropertyName = "PrezzoUnitario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "c4"
        DataGridViewCellStyle5.NullValue = "0"
        Me.dgcDettPrezzoUnitario.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgcDettPrezzoUnitario.HeaderText = "Quota Unitaria"
        Me.dgcDettPrezzoUnitario.Name = "dgcDettPrezzoUnitario"
        Me.dgcDettPrezzoUnitario.ReadOnly = True
        '
        'dgvcDettNetto
        '
        Me.dgvcDettNetto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettNetto.DataPropertyName = "ImportoNetto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "c2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.dgvcDettNetto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcDettNetto.HeaderText = "Importo Netto"
        Me.dgvcDettNetto.Name = "dgvcDettNetto"
        Me.dgvcDettNetto.ReadOnly = True
        '
        'dgvcDettIVA
        '
        Me.dgvcDettIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettIVA.DataPropertyName = "Iva"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "n2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.dgvcDettIVA.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcDettIVA.HeaderText = "IVA"
        Me.dgvcDettIVA.Name = "dgvcDettIVA"
        Me.dgvcDettIVA.ReadOnly = True
        Me.dgvcDettIVA.Width = 60
        '
        'dgvcDettImpIVA
        '
        Me.dgvcDettImpIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettImpIVA.DataPropertyName = "ImportoIva"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "c2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.dgvcDettImpIVA.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcDettImpIVA.HeaderText = "Importo IVA"
        Me.dgvcDettImpIVA.Name = "dgvcDettImpIVA"
        Me.dgvcDettImpIVA.ReadOnly = True
        '
        'dgvcDettLordo
        '
        Me.dgvcDettLordo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcDettLordo.DataPropertyName = "ImportoLordo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "c2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.dgvcDettLordo.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvcDettLordo.HeaderText = "Importo Lordo"
        Me.dgvcDettLordo.Name = "dgvcDettLordo"
        Me.dgvcDettLordo.ReadOnly = True
        Me.dgvcDettLordo.Width = 110
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.rifArxivar)
        Me.pnlTop.Controls.Add(Me.Label14)
        Me.pnlTop.Controls.Add(Me.btnStatoDoc)
        Me.pnlTop.Controls.Add(Me.lStatoIncasso)
        Me.pnlTop.Controls.Add(Me.Label12)
        Me.pnlTop.Controls.Add(Me.Label10)
        Me.pnlTop.Controls.Add(Me.lAnno)
        Me.pnlTop.Controls.Add(Me.txtDataRicezione)
        Me.pnlTop.Controls.Add(Me.txtDataProroga)
        Me.pnlTop.Controls.Add(Me.lScadPagamento)
        Me.pnlTop.Controls.Add(Me.lScadDichiarazione)
        Me.pnlTop.Controls.Add(Me.lPeriodo)
        Me.pnlTop.Controls.Add(Me.Label9)
        Me.pnlTop.Controls.Add(Me.Label8)
        Me.pnlTop.Controls.Add(Me.Label7)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.lAzienda)
        Me.pnlTop.Controls.Add(Me.lLogo)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.cbCategoria)
        Me.pnlTop.Controls.Add(Me.Label5)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1008, 137)
        Me.pnlTop.TabIndex = 71
        '
        'rifArxivar
        '
        Me.rifArxivar.AllowProfile = True
        Me.rifArxivar.BackColorTxt = System.Drawing.SystemColors.Window
        Me.rifArxivar.DataBindings.Add(New System.Windows.Forms.Binding("Protocollo", Me.bsData, "RifArxivar", True))
        Me.rifArxivar.Location = New System.Drawing.Point(86, 102)
        Me.rifArxivar.Margin = New System.Windows.Forms.Padding(2)
        Me.rifArxivar.Name = "rifArxivar"
        Me.rifArxivar.Protocollo = ""
        Me.rifArxivar.ProtocolPrefix = Nothing
        Me.rifArxivar.ReadOnly = False
        Me.rifArxivar.SearchDocumentMode = ArxivarWCFWrapper.ucProtocolloArxivar.SearchDocumentModeEnum.BY_DOC_NUMBER_AND_ID
        Me.rifArxivar.ShowContextMenu = True
        Me.rifArxivar.Size = New System.Drawing.Size(256, 20)
        Me.rifArxivar.TabIndex = 77
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Documenti"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(906, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Stato incassi"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(886, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Stato documento"
        '
        'lAnno
        '
        Me.lAnno.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Anno", True))
        Me.lAnno.Location = New System.Drawing.Point(86, 74)
        Me.lAnno.Name = "lAnno"
        Me.lAnno.Size = New System.Drawing.Size(76, 20)
        Me.lAnno.TabIndex = 70
        Me.lAnno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataRicezione
        '
        Me.txtDataRicezione.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataRicezione", True))
        Me.txtDataRicezione.DateFormat = Nothing
        Me.txtDataRicezione.DateValue = Nothing
        Me.txtDataRicezione.IsReadOnly = False
        Me.txtDataRicezione.Location = New System.Drawing.Point(608, 74)
        Me.txtDataRicezione.Name = "txtDataRicezione"
        Me.txtDataRicezione.SetNullDateToDbNull = False
        Me.txtDataRicezione.Size = New System.Drawing.Size(96, 20)
        Me.txtDataRicezione.TabIndex = 69
        '
        'txtDataProroga
        '
        Me.txtDataProroga.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataProroga", True))
        Me.txtDataProroga.DateFormat = Nothing
        Me.txtDataProroga.DateValue = Nothing
        Me.txtDataProroga.IsReadOnly = False
        Me.txtDataProroga.Location = New System.Drawing.Point(608, 47)
        Me.txtDataProroga.Name = "txtDataProroga"
        Me.txtDataProroga.SetNullDateToDbNull = False
        Me.txtDataProroga.Size = New System.Drawing.Size(96, 20)
        Me.txtDataProroga.TabIndex = 68
        '
        'lScadPagamento
        '
        Me.lScadPagamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lScadPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lScadPagamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DataScadenzaPagamento", True))
        Me.lScadPagamento.Location = New System.Drawing.Point(445, 74)
        Me.lScadPagamento.Name = "lScadPagamento"
        Me.lScadPagamento.Size = New System.Drawing.Size(77, 20)
        Me.lScadPagamento.TabIndex = 67
        Me.lScadPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lScadDichiarazione
        '
        Me.lScadDichiarazione.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lScadDichiarazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lScadDichiarazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DataScadenzaDichiarazione", True))
        Me.lScadDichiarazione.Location = New System.Drawing.Point(445, 48)
        Me.lScadDichiarazione.Name = "lScadDichiarazione"
        Me.lScadDichiarazione.Size = New System.Drawing.Size(77, 20)
        Me.lScadDichiarazione.TabIndex = 66
        Me.lScadDichiarazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lPeriodo
        '
        Me.lPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Periodo", True))
        Me.lPeriodo.Location = New System.Drawing.Point(167, 74)
        Me.lPeriodo.Name = "lPeriodo"
        Me.lPeriodo.Size = New System.Drawing.Size(176, 20)
        Me.lPeriodo.TabIndex = 65
        Me.lPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(527, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Data ricezione"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Data proroga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Scad.Pagamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Scad.Dichiarazione"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 137)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDettaglio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tsDettaglio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvIncassi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 301)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 72
        '
        'tsDettaglio
        '
        Me.tsDettaglio.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsDettaglio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsDettaglio.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsDettaglio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDettAdd, Me.tsbDettEdit, Me.tsbDettDel})
        Me.tsDettaglio.Location = New System.Drawing.Point(970, 20)
        Me.tsDettaglio.Name = "tsDettaglio"
        Me.tsDettaglio.Size = New System.Drawing.Size(38, 134)
        Me.tsDettaglio.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1008, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Dettaglio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvIncassi
        '
        Me.dgvIncassi.AllowUserToAddRows = False
        Me.dgvIncassi.AllowUserToDeleteRows = False
        Me.dgvIncassi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIncassi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncassi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcIncTipo, Me.dgvcIncModPag, Me.dgvcIncData, Me.dgvcIncDataPagamento, Me.dgvcIncImporto, Me.dgvcIncScadenza, Me.dgvcIncNumero, Me.dgvcIncNote, Me.dgvcIncAcconto})
        Me.dgvIncassi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIncassi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvIncassi.Location = New System.Drawing.Point(0, 20)
        Me.dgvIncassi.Name = "dgvIncassi"
        Me.dgvIncassi.ReadOnly = True
        Me.dgvIncassi.RowHeadersWidth = 20
        Me.dgvIncassi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIncassi.Size = New System.Drawing.Size(972, 124)
        Me.dgvIncassi.TabIndex = 73
        '
        'dgvcIncTipo
        '
        Me.dgvcIncTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncTipo.DataPropertyName = "DescrTipo"
        Me.dgvcIncTipo.HeaderText = "Tipo"
        Me.dgvcIncTipo.Name = "dgvcIncTipo"
        Me.dgvcIncTipo.ReadOnly = True
        Me.dgvcIncTipo.Width = 120
        '
        'dgvcIncModPag
        '
        Me.dgvcIncModPag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncModPag.DataPropertyName = "DescrModalitaPagamento"
        Me.dgvcIncModPag.HeaderText = "Modalita Pagamento"
        Me.dgvcIncModPag.Name = "dgvcIncModPag"
        Me.dgvcIncModPag.ReadOnly = True
        Me.dgvcIncModPag.Width = 140
        '
        'dgvcIncData
        '
        Me.dgvcIncData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncData.DataPropertyName = "DataValuta"
        DataGridViewCellStyle10.Format = "d"
        Me.dgvcIncData.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvcIncData.HeaderText = "Data Valuta"
        Me.dgvcIncData.Name = "dgvcIncData"
        Me.dgvcIncData.ReadOnly = True
        Me.dgvcIncData.Width = 110
        '
        'dgvcIncDataPagamento
        '
        Me.dgvcIncDataPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncDataPagamento.DataPropertyName = "DataPagamento"
        DataGridViewCellStyle11.Format = "d"
        Me.dgvcIncDataPagamento.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvcIncDataPagamento.HeaderText = "Data Pagamento"
        Me.dgvcIncDataPagamento.Name = "dgvcIncDataPagamento"
        Me.dgvcIncDataPagamento.ReadOnly = True
        Me.dgvcIncDataPagamento.Width = 110
        '
        'dgvcIncImporto
        '
        Me.dgvcIncImporto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncImporto.DataPropertyName = "Importo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "c2"
        Me.dgvcIncImporto.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvcIncImporto.HeaderText = "Importo"
        Me.dgvcIncImporto.Name = "dgvcIncImporto"
        Me.dgvcIncImporto.ReadOnly = True
        Me.dgvcIncImporto.Width = 120
        '
        'dgvcIncScadenza
        '
        Me.dgvcIncScadenza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncScadenza.DataPropertyName = "DataScadenza"
        DataGridViewCellStyle13.Format = "d"
        Me.dgvcIncScadenza.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvcIncScadenza.HeaderText = "Data scadenza"
        Me.dgvcIncScadenza.Name = "dgvcIncScadenza"
        Me.dgvcIncScadenza.ReadOnly = True
        Me.dgvcIncScadenza.Width = 110
        '
        'dgvcIncNumero
        '
        Me.dgvcIncNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncNumero.DataPropertyName = "NumeroRata"
        Me.dgvcIncNumero.HeaderText = "Numero Rata"
        Me.dgvcIncNumero.Name = "dgvcIncNumero"
        Me.dgvcIncNumero.ReadOnly = True
        Me.dgvcIncNumero.Width = 60
        '
        'dgvcIncNote
        '
        Me.dgvcIncNote.DataPropertyName = "Note"
        Me.dgvcIncNote.HeaderText = "Note"
        Me.dgvcIncNote.Name = "dgvcIncNote"
        Me.dgvcIncNote.ReadOnly = True
        '
        'dgvcIncAcconto
        '
        Me.dgvcIncAcconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIncAcconto.DataPropertyName = "IsAcconto"
        Me.dgvcIncAcconto.HeaderText = "Acc."
        Me.dgvcIncAcconto.Name = "dgvcIncAcconto"
        Me.dgvcIncAcconto.ReadOnly = True
        Me.dgvcIncAcconto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcIncAcconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcIncAcconto.Width = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIncAdd, Me.tsbIncEdit, Me.tsbIncDel})
        Me.ToolStrip1.Location = New System.Drawing.Point(972, 20)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(36, 124)
        Me.ToolStrip1.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1008, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Incassi"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlIncTot
        '
        Me.pnlIncTot.Controls.Add(Me.lContrMin)
        Me.pnlIncTot.Controls.Add(Me.Label16)
        Me.pnlIncTot.Controls.Add(Me.lDescrSaldo)
        Me.pnlIncTot.Controls.Add(Me.lSaldo)
        Me.pnlIncTot.Controls.Add(Me.lTotIncassi)
        Me.pnlIncTot.Controls.Add(Me.Label15)
        Me.pnlIncTot.Controls.Add(Me.lTotDichiarazione)
        Me.pnlIncTot.Controls.Add(Me.Label13)
        Me.pnlIncTot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlIncTot.Location = New System.Drawing.Point(0, 438)
        Me.pnlIncTot.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlIncTot.Name = "pnlIncTot"
        Me.pnlIncTot.Size = New System.Drawing.Size(1008, 67)
        Me.pnlIncTot.TabIndex = 75
        '
        'lContrMin
        '
        Me.lContrMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lContrMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lContrMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "ContributoMinimoAnnuale", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.lContrMin.Location = New System.Drawing.Point(101, 32)
        Me.lContrMin.Name = "lContrMin"
        Me.lContrMin.Size = New System.Drawing.Size(96, 20)
        Me.lContrMin.TabIndex = 77
        Me.lContrMin.Text = "0,00"
        Me.lContrMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Contributo minimo"
        '
        'lDescrSaldo
        '
        Me.lDescrSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lDescrSaldo.Location = New System.Drawing.Point(766, 8)
        Me.lDescrSaldo.Name = "lDescrSaldo"
        Me.lDescrSaldo.Size = New System.Drawing.Size(100, 22)
        Me.lDescrSaldo.TabIndex = 75
        Me.lDescrSaldo.Text = "Saldo"
        Me.lDescrSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lSaldo
        '
        Me.lSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lSaldo.Location = New System.Drawing.Point(872, 8)
        Me.lSaldo.Name = "lSaldo"
        Me.lSaldo.Size = New System.Drawing.Size(96, 20)
        Me.lSaldo.TabIndex = 74
        Me.lSaldo.Text = "0,00"
        Me.lSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lTotIncassi
        '
        Me.lTotIncassi.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lTotIncassi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTotIncassi.Location = New System.Drawing.Point(305, 8)
        Me.lTotIncassi.Name = "lTotIncassi"
        Me.lTotIncassi.Size = New System.Drawing.Size(96, 20)
        Me.lTotIncassi.TabIndex = 73
        Me.lTotIncassi.Text = "0,00"
        Me.lTotIncassi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(215, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Totale incassato"
        '
        'lTotDichiarazione
        '
        Me.lTotDichiarazione.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lTotDichiarazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lTotDichiarazione.Location = New System.Drawing.Point(101, 8)
        Me.lTotDichiarazione.Name = "lTotDichiarazione"
        Me.lTotDichiarazione.Size = New System.Drawing.Size(96, 20)
        Me.lTotDichiarazione.TabIndex = 71
        Me.lTotDichiarazione.Text = "0,00"
        Me.lTotDichiarazione.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Totale dichiarato"
        '
        'tsbDettAdd
        '
        Me.tsbDettAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDettAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.tsbDettAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDettAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDettAdd.Name = "tsbDettAdd"
        Me.tsbDettAdd.Size = New System.Drawing.Size(35, 28)
        Me.tsbDettAdd.Text = "Nuova"
        '
        'tsbDettEdit
        '
        Me.tsbDettEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDettEdit.Image = Global.PoliecoSoci.My.Resources.Resources.Edit_24_n_g
        Me.tsbDettEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDettEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDettEdit.Name = "tsbDettEdit"
        Me.tsbDettEdit.Size = New System.Drawing.Size(35, 28)
        Me.tsbDettEdit.Text = "Modifica"
        '
        'tsbDettDel
        '
        Me.tsbDettDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDettDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbDettDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDettDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDettDel.Name = "tsbDettDel"
        Me.tsbDettDel.Size = New System.Drawing.Size(35, 28)
        Me.tsbDettDel.Text = "Elimina"
        '
        'tsbIncAdd
        '
        Me.tsbIncAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbIncAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.tsbIncAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbIncAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncAdd.Name = "tsbIncAdd"
        Me.tsbIncAdd.Size = New System.Drawing.Size(34, 28)
        Me.tsbIncAdd.Text = "Nuova"
        '
        'tsbIncEdit
        '
        Me.tsbIncEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbIncEdit.Image = Global.PoliecoSoci.My.Resources.Resources.Edit_24_n_g
        Me.tsbIncEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbIncEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncEdit.Name = "tsbIncEdit"
        Me.tsbIncEdit.Size = New System.Drawing.Size(34, 28)
        Me.tsbIncEdit.Text = "Modifica"
        '
        'tsbIncDel
        '
        Me.tsbIncDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbIncDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbIncDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbIncDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIncDel.Name = "tsbIncDel"
        Me.tsbIncDel.Size = New System.Drawing.Size(34, 28)
        Me.tsbIncDel.Text = "Elimina"
        '
        'btnStatoDoc
        '
        Me.btnStatoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatoDoc.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Green_Round_16_n_g
        Me.btnStatoDoc.Location = New System.Drawing.Point(978, 51)
        Me.btnStatoDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStatoDoc.Name = "btnStatoDoc"
        Me.btnStatoDoc.Size = New System.Drawing.Size(22, 20)
        Me.btnStatoDoc.TabIndex = 75
        Me.btnStatoDoc.UseVisualStyleBackColor = True
        '
        'lStatoIncasso
        '
        Me.lStatoIncasso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lStatoIncasso.Image = Global.PoliecoSoci.My.Resources.Resources.Light_Green_Round_16_n_g
        Me.lStatoIncasso.Location = New System.Drawing.Point(978, 74)
        Me.lStatoIncasso.Name = "lStatoIncasso"
        Me.lStatoIncasso.Size = New System.Drawing.Size(20, 20)
        Me.lStatoIncasso.TabIndex = 74
        '
        'lLogo
        '
        Me.lLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Truck_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(972, 9)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(32, 32)
        Me.lLogo.TabIndex = 54
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_24_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(80, 52)
        Me.tsbExit.Text = "Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_24_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(54, 52)
        Me.tsbOk.Text = "Ok"
        '
        'tsbDOL
        '
        Me.tsbDOL.Image = Global.PoliecoSoci.My.Resources.Resources.List_32_n_g
        Me.tsbDOL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDOL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDOL.Name = "tsbDOL"
        Me.tsbDOL.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbDOL.Size = New System.Drawing.Size(159, 52)
        Me.tsbDOL.Text = "Dichiarazione on-line"
        '
        'tsbAllegato
        '
        Me.tsbAllegato.Image = Global.PoliecoSoci.My.Resources.Resources.Select_Document_32_n_g
        Me.tsbAllegato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAllegato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAllegato.Name = "tsbAllegato"
        Me.tsbAllegato.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAllegato.Size = New System.Drawing.Size(91, 52)
        Me.tsbAllegato.Text = "Allegato"
        '
        'tsbProdotti
        '
        Me.tsbProdotti.Image = Global.PoliecoSoci.My.Resources.Resources.Fill_Color_Rainbow_32_n_g
        Me.tsbProdotti.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbProdotti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProdotti.Name = "tsbProdotti"
        Me.tsbProdotti.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbProdotti.Size = New System.Drawing.Size(90, 52)
        Me.tsbProdotti.Text = "Prodotti"
        '
        'FDichiarazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 560)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pnlIncTot)
        Me.Controls.Add(Me.tsMain)
        Me.Name = "FDichiarazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dichiarazione periodica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tsDettaglio.ResumeLayout(False)
        Me.tsDettaglio.PerformLayout()
        CType(Me.dgvIncassi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlIncTot.ResumeLayout(False)
        Me.pnlIncTot.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsIncassi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents lAzienda As System.Windows.Forms.Label
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvDettaglio As System.Windows.Forms.DataGridView
    Friend WithEvents bsDettaglio As System.Windows.Forms.BindingSource
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lScadPagamento As System.Windows.Forms.Label
    Friend WithEvents lScadDichiarazione As System.Windows.Forms.Label
    Friend WithEvents lPeriodo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataRicezione As mdsUIControls.mdsDate
    Friend WithEvents txtDataProroga As mdsUIControls.mdsDate
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvIncassi As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bsIncassi As System.Windows.Forms.BindingSource
    Friend WithEvents tsDettaglio As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbDettEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDettDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlIncTot As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbIncAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbIncEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbIncDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lAnno As System.Windows.Forms.Label
    Friend WithEvents lStatoIncasso As System.Windows.Forms.Label
    Friend WithEvents lDescrSaldo As System.Windows.Forms.Label
    Friend WithEvents lSaldo As System.Windows.Forms.Label
    Friend WithEvents lTotIncassi As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lTotDichiarazione As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgvcIncTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncModPag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncDataPagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncImporto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncScadenza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIncAcconto As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnStatoDoc As System.Windows.Forms.Button
    Friend WithEvents tsbDettAdd As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents lContrMin As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rifArxivar As ArxivarWCFWrapper.ucProtocolloArxivar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tsbDOL As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvcDettCodQuadro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettProcedura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettMateria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettPeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcDettPrezzoUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettNetto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettImpIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDettLordo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbAllegato As ToolStripButton
    Friend WithEvents tsbProdotti As ToolStripButton
End Class
