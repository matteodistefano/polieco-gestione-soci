<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoRiunioni
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoRiunioni))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuova = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.bsRiunioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cdiPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.ccTipo = New mdsUIControls.ucCheckedCombo()
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.dgvcData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRiunioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuova, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbSelect, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 876)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1607, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbNuova
        '
        Me.tsbNuova.Image = Global.PoliecoSoci.My.Resources.Resources.Add_Appointment_32_n_g
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
        Me.tsbModifica.Size = New System.Drawing.Size(122, 42)
        Me.tsbModifica.Text = "Modifica"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.Delete_Appointment_32_n_g
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
        'tsbSelect
        '
        Me.tsbSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSelect.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_32_n_p8
        Me.tsbSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelect.Name = "tsbSelect"
        Me.tsbSelect.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbSelect.Size = New System.Drawing.Size(139, 42)
        Me.tsbSelect.Text = "&Seleziona"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'dgvElenco
        '
        Me.dgvElenco.AllowUserToAddRows = False
        Me.dgvElenco.AllowUserToDeleteRows = False
        Me.dgvElenco.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvElenco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvElenco.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcData, Me.dgvcTipo, Me.dgvcTesto})
        Me.dgvElenco.DataSource = Me.bsRiunioni
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 62)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersWidth = 20
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1607, 814)
        Me.dgvElenco.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtNote)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cdiPeriodo)
        Me.Panel1.Controls.Add(Me.ccTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1607, 62)
        Me.Panel1.TabIndex = 7
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(1022, 14)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(306, 32)
        Me.txtNote.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(953, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Testo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Periodo"
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiPeriodo.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiPeriodo.Location = New System.Drawing.Point(520, 10)
        Me.cdiPeriodo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cdiPeriodo.MonthFormat = False
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(400, 42)
        Me.cdiPeriodo.TabIndex = 2
        Me.cdiPeriodo.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        AddHandler Me.cdiPeriodo.Load, AddressOf Me.cdiPeriodo_Load
        '
        'ccTipo
        '
        Me.ccTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccTipo.Checked = False
        Me.ccTipo.CheckText = "Solo "
        Me.ccTipo.CheckWidth = 82
        Me.ccTipo.ComboText = ""
        Me.ccTipo.DataSource = Nothing
        Me.ccTipo.DisplayMember = ""
        Me.ccTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccTipo.Location = New System.Drawing.Point(18, 10)
        Me.ccTipo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ccTipo.MaxDropDownItems = 8
        Me.ccTipo.Name = "ccTipo"
        Me.ccTipo.SelectedIndex = -1
        Me.ccTipo.SelectedValue = Nothing
        Me.ccTipo.Size = New System.Drawing.Size(386, 39)
        Me.ccTipo.TabIndex = 1
        Me.ccTipo.ValueFieldName = Nothing
        Me.ccTipo.ValueMember = ""
        Me.ccTipo.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
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
        'dgvcData
        '
        Me.dgvcData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcData.DataPropertyName = "Data"
        DataGridViewCellStyle2.Format = "d"
        Me.dgvcData.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcData.HeaderText = "Data"
        Me.dgvcData.Name = "dgvcData"
        Me.dgvcData.ReadOnly = True
        Me.dgvcData.Width = 250
        '
        'dgvcTipo
        '
        Me.dgvcTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcTipo.DataPropertyName = "DescrTipo"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcTipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcTipo.HeaderText = "Tipo"
        Me.dgvcTipo.Name = "dgvcTipo"
        Me.dgvcTipo.ReadOnly = True
        Me.dgvcTipo.Width = 200
        '
        'dgvcTesto
        '
        Me.dgvcTesto.DataPropertyName = "Note"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcTesto.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcTesto.HeaderText = "Note"
        Me.dgvcTesto.Name = "dgvcTesto"
        Me.dgvcTesto.ReadOnly = True
        '
        'FElencoRiunioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1607, 921)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FElencoRiunioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assemblee & CDA"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRiunioni, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsRiunioni As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ccTipo As mdsUIControls.ucCheckedCombo
    Friend WithEvents tsbSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cdiPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents dgvcData As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTipo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTesto As DataGridViewTextBoxColumn
End Class
