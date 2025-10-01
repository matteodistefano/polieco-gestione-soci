<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgQuadro
    Inherits Form

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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgQuadro))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.btnMatDown = New System.Windows.Forms.Button()
        Me.btnMatUp = New System.Windows.Forms.Button()
        Me.dgvMateriali = New System.Windows.Forms.DataGridView()
        Me.btnMatDel = New System.Windows.Forms.Button()
        Me.btnMatAdd = New System.Windows.Forms.Button()
        Me.rbS1 = New System.Windows.Forms.RadioButton()
        Me.rbS0 = New System.Windows.Forms.RadioButton()
        Me.txtProcedura = New System.Windows.Forms.TextBox()
        Me.bsEntity = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescrizione = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.chkInteressi = New System.Windows.Forms.CheckBox()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        Me.bsMateriali = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdiPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.dgvcMatPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMatCodice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMatPrezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMatDal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcMatAl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.dgvMateriali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEntity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMateriali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(13, 18)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 17)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Codice:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(13, 422)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(61, 17)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Periodo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(13, 81)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 17)
        Label5.TabIndex = 36
        Label5.Text = "Descrizione:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(634, 21)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(69, 17)
        Label6.TabIndex = 38
        Label6.Text = "Utilizzato:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 50)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 17)
        Label2.TabIndex = 42
        Label2.Text = "Tipo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 111)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 17)
        Label1.TabIndex = 47
        Label1.Text = "Procedura:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(13, 234)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(65, 17)
        Label3.TabIndex = 50
        Label3.Text = "Materiali:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(13, 201)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 17)
        Label4.TabIndex = 51
        Label4.Text = "Segno:"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 480)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(746, 45)
        Me.tsMain.TabIndex = 0
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbAnnulla
        '
        Me.tsbAnnulla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnnulla.Image = CType(resources.GetObject("tsbAnnulla.Image"), System.Drawing.Image)
        Me.tsbAnnulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnnulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnnulla.Name = "tsbAnnulla"
        Me.tsbAnnulla.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbAnnulla.Size = New System.Drawing.Size(101, 42)
        Me.tsbAnnulla.Text = "&Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = CType(resources.GetObject("tsbOk.Image"), System.Drawing.Image)
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbOk.Size = New System.Drawing.Size(69, 42)
        Me.tsbOk.Text = "&Ok"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = CType(resources.GetObject("tsbStampa.Image"), System.Drawing.Image)
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(96, 42)
        Me.tsbStampa.Text = "&Stampa"
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.btnMatDown)
        Me.pnlEdit.Controls.Add(Me.btnMatUp)
        Me.pnlEdit.Controls.Add(Me.dgvMateriali)
        Me.pnlEdit.Controls.Add(Me.btnMatDel)
        Me.pnlEdit.Controls.Add(Me.btnMatAdd)
        Me.pnlEdit.Controls.Add(Me.rbS1)
        Me.pnlEdit.Controls.Add(Me.rbS0)
        Me.pnlEdit.Controls.Add(Label4)
        Me.pnlEdit.Controls.Add(Label3)
        Me.pnlEdit.Controls.Add(Me.txtProcedura)
        Me.pnlEdit.Controls.Add(Label1)
        Me.pnlEdit.Controls.Add(Me.cdiPeriodo)
        Me.pnlEdit.Controls.Add(Me.txtDescrizione)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(Label6)
        Me.pnlEdit.Controls.Add(Me.cbTipo)
        Me.pnlEdit.Controls.Add(Label5)
        Me.pnlEdit.Controls.Add(Me.chkInteressi)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Controls.Add(NomeLabel)
        Me.pnlEdit.Controls.Add(Me.txtCodice)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(746, 480)
        Me.pnlEdit.TabIndex = 6
        '
        'btnMatDown
        '
        Me.btnMatDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatDown.Image = Global.PoliecoSoci.My.Resources.Resources.Blue_Arrow_Down_24_n_g
        Me.btnMatDown.Location = New System.Drawing.Point(704, 385)
        Me.btnMatDown.Name = "btnMatDown"
        Me.btnMatDown.Size = New System.Drawing.Size(29, 30)
        Me.btnMatDown.TabIndex = 59
        Me.btnMatDown.UseVisualStyleBackColor = True
        '
        'btnMatUp
        '
        Me.btnMatUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatUp.Image = Global.PoliecoSoci.My.Resources.Resources.Blue_Arrow_Up_24_n_g
        Me.btnMatUp.Location = New System.Drawing.Point(704, 354)
        Me.btnMatUp.Name = "btnMatUp"
        Me.btnMatUp.Size = New System.Drawing.Size(29, 30)
        Me.btnMatUp.TabIndex = 58
        Me.btnMatUp.UseVisualStyleBackColor = True
        '
        'dgvMateriali
        '
        Me.dgvMateriali.AllowUserToAddRows = False
        Me.dgvMateriali.AllowUserToDeleteRows = False
        Me.dgvMateriali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMateriali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateriali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcMatPos, Me.dgvMatCodice, Me.dgvcMatPrezzo, Me.dgvcMatDal, Me.dgvcMatAl})
        Me.dgvMateriali.Location = New System.Drawing.Point(103, 234)
        Me.dgvMateriali.Name = "dgvMateriali"
        Me.dgvMateriali.RowHeadersWidth = 10
        Me.dgvMateriali.RowTemplate.Height = 24
        Me.dgvMateriali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMateriali.Size = New System.Drawing.Size(600, 181)
        Me.dgvMateriali.TabIndex = 57
        '
        'btnMatDel
        '
        Me.btnMatDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatDel.Image = CType(resources.GetObject("btnMatDel.Image"), System.Drawing.Image)
        Me.btnMatDel.Location = New System.Drawing.Point(704, 264)
        Me.btnMatDel.Name = "btnMatDel"
        Me.btnMatDel.Size = New System.Drawing.Size(29, 30)
        Me.btnMatDel.TabIndex = 56
        Me.btnMatDel.UseVisualStyleBackColor = True
        '
        'btnMatAdd
        '
        Me.btnMatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatAdd.Image = CType(resources.GetObject("btnMatAdd.Image"), System.Drawing.Image)
        Me.btnMatAdd.Location = New System.Drawing.Point(704, 234)
        Me.btnMatAdd.Name = "btnMatAdd"
        Me.btnMatAdd.Size = New System.Drawing.Size(29, 30)
        Me.btnMatAdd.TabIndex = 55
        Me.btnMatAdd.UseVisualStyleBackColor = True
        '
        'rbS1
        '
        Me.rbS1.AutoSize = True
        Me.rbS1.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Minus_24_n_g
        Me.rbS1.Location = New System.Drawing.Point(152, 201)
        Me.rbS1.Name = "rbS1"
        Me.rbS1.Size = New System.Drawing.Size(41, 24)
        Me.rbS1.TabIndex = 53
        Me.rbS1.TabStop = True
        Me.rbS1.UseVisualStyleBackColor = True
        '
        'rbS0
        '
        Me.rbS0.AutoSize = True
        Me.rbS0.Image = CType(resources.GetObject("rbS0.Image"), System.Drawing.Image)
        Me.rbS0.Location = New System.Drawing.Point(103, 201)
        Me.rbS0.Name = "rbS0"
        Me.rbS0.Size = New System.Drawing.Size(41, 24)
        Me.rbS0.TabIndex = 52
        Me.rbS0.TabStop = True
        Me.rbS0.UseVisualStyleBackColor = True
        '
        'txtProcedura
        '
        Me.txtProcedura.BackColor = System.Drawing.Color.White
        Me.txtProcedura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Procedura", True))
        Me.txtProcedura.Location = New System.Drawing.Point(103, 108)
        Me.txtProcedura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProcedura.Multiline = True
        Me.txtProcedura.Name = "txtProcedura"
        Me.txtProcedura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProcedura.Size = New System.Drawing.Size(630, 86)
        Me.txtProcedura.TabIndex = 4
        '
        'txtDescrizione
        '
        Me.txtDescrizione.BackColor = System.Drawing.Color.White
        Me.txtDescrizione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Descrizione", True))
        Me.txtDescrizione.Location = New System.Drawing.Point(103, 78)
        Me.txtDescrizione.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(630, 22)
        Me.txtDescrizione.TabIndex = 3
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(103, 47)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(630, 24)
        Me.cbTipo.TabIndex = 2
        '
        'chkInteressi
        '
        Me.chkInteressi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsEntity, "Utilizzato", True))
        Me.chkInteressi.Location = New System.Drawing.Point(711, 15)
        Me.chkInteressi.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInteressi.Name = "chkInteressi"
        Me.chkInteressi.Size = New System.Drawing.Size(22, 30)
        Me.chkInteressi.TabIndex = 1
        '
        'txtCodice
        '
        Me.txtCodice.BackColor = System.Drawing.Color.White
        Me.txtCodice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Codice", True))
        Me.txtCodice.Location = New System.Drawing.Point(103, 18)
        Me.txtCodice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(90, 22)
        Me.txtCodice.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.HeaderText = "Materiale"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 298
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Prezzo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n4"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataInizio"
        DataGridViewCellStyle7.Format = "d"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataFine"
        DataGridViewCellStyle8.Format = "d"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Al"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DataFine"
        DataGridViewCellStyle9.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Al"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("DataFinale", Me.bsEntity, "DataFine", True))
        Me.cdiPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("DataIniziale", Me.bsEntity, "DataInizio", True))
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiPeriodo.Location = New System.Drawing.Point(103, 422)
        Me.cdiPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(310, 28)
        Me.cdiPeriodo.TabIndex = 6
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'dgvcMatPos
        '
        Me.dgvcMatPos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMatPos.DataPropertyName = "PosizioneInQuadro"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcMatPos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcMatPos.HeaderText = "Pos."
        Me.dgvcMatPos.Name = "dgvcMatPos"
        Me.dgvcMatPos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvcMatPos.Width = 50
        '
        'dgvMatCodice
        '
        Me.dgvMatCodice.DataPropertyName = "Codice"
        Me.dgvMatCodice.HeaderText = "Materiale"
        Me.dgvMatCodice.Name = "dgvMatCodice"
        Me.dgvMatCodice.ReadOnly = True
        Me.dgvMatCodice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvcMatPrezzo
        '
        Me.dgvcMatPrezzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMatPrezzo.DataPropertyName = "Prezzo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n4"
        Me.dgvcMatPrezzo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcMatPrezzo.HeaderText = "Prezzo"
        Me.dgvcMatPrezzo.Name = "dgvcMatPrezzo"
        Me.dgvcMatPrezzo.ReadOnly = True
        Me.dgvcMatPrezzo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvcMatPrezzo.Width = 110
        '
        'dgvcMatDal
        '
        Me.dgvcMatDal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMatDal.DataPropertyName = "DataInizio"
        DataGridViewCellStyle3.Format = "d"
        Me.dgvcMatDal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcMatDal.HeaderText = "Dal"
        Me.dgvcMatDal.Name = "dgvcMatDal"
        Me.dgvcMatDal.ReadOnly = True
        Me.dgvcMatDal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvcMatDal.Width = 90
        '
        'dgvcMatAl
        '
        Me.dgvcMatAl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcMatAl.DataPropertyName = "DataFine"
        DataGridViewCellStyle4.Format = "d"
        Me.dgvcMatAl.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcMatAl.HeaderText = "Al"
        Me.dgvcMatAl.Name = "dgvcMatAl"
        Me.dgvcMatAl.ReadOnly = True
        Me.dgvcMatAl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgvcMatAl.Width = 90
        '
        'dlgQuadro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 525)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dlgQuadro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quadro dichiarazione periodica"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.dgvMateriali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEntity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMateriali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents bsEntity As System.Windows.Forms.BindingSource
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents chkInteressi As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents cdiPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents txtProcedura As System.Windows.Forms.TextBox
    Friend WithEvents rbS1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbS0 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMatDel As System.Windows.Forms.Button
    Friend WithEvents btnMatAdd As System.Windows.Forms.Button
    Friend WithEvents bsMateriali As System.Windows.Forms.BindingSource
    Friend WithEvents dgvMateriali As System.Windows.Forms.DataGridView
    Friend WithEvents btnMatDown As System.Windows.Forms.Button
    Friend WithEvents btnMatUp As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcMatPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMatCodice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcMatPrezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcMatDal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcMatAl As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
