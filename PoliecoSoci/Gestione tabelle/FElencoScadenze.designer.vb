<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoScadenze
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoScadenze))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuova = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbDuplica = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.bsScadenze = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.ccAnno = New mdsUIControls.ucCheckedCombo()
        Me.ccCategoria = New mdsUIControls.ucCheckedCombo()
        Me.dgvcCodice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcScadRifPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcInizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUltimoAccesso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcScadDichiarazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcScadPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcInteresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAuto = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsScadenze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuova, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbSelect, Me.tsbDuplica, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 876)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(2372, 45)
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
        'tsbDuplica
        '
        Me.tsbDuplica.Image = Global.PoliecoSoci.My.Resources.Resources.Select_Document_32_n_g
        Me.tsbDuplica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDuplica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDuplica.Margin = New System.Windows.Forms.Padding(0, 1, 60, 2)
        Me.tsbDuplica.Name = "tsbDuplica"
        Me.tsbDuplica.Size = New System.Drawing.Size(112, 42)
        Me.tsbDuplica.Text = "Duplica"
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
        Me.dgvElenco.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvElenco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCodice, Me.dgvcAnno, Me.dgvcScadRifPer, Me.dgvcInizio, Me.dgvcUltimoAccesso, Me.dgvcScadDichiarazione, Me.dgvcScadPagamento, Me.dgvcCategoria, Me.dgvcInteresse, Me.dgvcAuto})
        Me.dgvElenco.DataSource = Me.bsScadenze
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 62)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.RowHeadersWidth = 51
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(2372, 814)
        Me.dgvElenco.TabIndex = 6
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAuto)
        Me.Panel1.Controls.Add(Me.ccAnno)
        Me.Panel1.Controls.Add(Me.ccCategoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2372, 62)
        Me.Panel1.TabIndex = 7
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Location = New System.Drawing.Point(1244, 14)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(189, 28)
        Me.chkAuto.TabIndex = 3
        Me.chkAuto.Text = "Solo automatiche"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'ccAnno
        '
        Me.ccAnno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccAnno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccAnno.Checked = False
        Me.ccAnno.CheckText = "Anno"
        Me.ccAnno.CheckWidth = 96
        Me.ccAnno.ComboText = ""
        Me.ccAnno.DataSource = Nothing
        Me.ccAnno.DisplayMember = ""
        Me.ccAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ccAnno.Location = New System.Drawing.Point(980, 10)
        Me.ccAnno.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ccAnno.MaxDropDownItems = 8
        Me.ccAnno.Name = "ccAnno"
        Me.ccAnno.SelectedIndex = -1
        Me.ccAnno.SelectedValue = Nothing
        Me.ccAnno.Size = New System.Drawing.Size(224, 39)
        Me.ccAnno.TabIndex = 2
        Me.ccAnno.ValueFieldName = Nothing
        Me.ccAnno.ValueMember = ""
        Me.ccAnno.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'ccCategoria
        '
        Me.ccCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccCategoria.Checked = False
        Me.ccCategoria.CheckText = "Solo categoria"
        Me.ccCategoria.CheckWidth = 179
        Me.ccCategoria.ComboText = ""
        Me.ccCategoria.DataSource = Nothing
        Me.ccCategoria.DisplayMember = ""
        Me.ccCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccCategoria.Location = New System.Drawing.Point(18, 10)
        Me.ccCategoria.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ccCategoria.MaxDropDownItems = 8
        Me.ccCategoria.Name = "ccCategoria"
        Me.ccCategoria.SelectedIndex = -1
        Me.ccCategoria.SelectedValue = Nothing
        Me.ccCategoria.Size = New System.Drawing.Size(952, 39)
        Me.ccCategoria.TabIndex = 1
        Me.ccCategoria.ValueFieldName = Nothing
        Me.ccCategoria.ValueMember = ""
        Me.ccCategoria.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'dgvcCodice
        '
        Me.dgvcCodice.DataPropertyName = "Codice"
        Me.dgvcCodice.HeaderText = "Codice"
        Me.dgvcCodice.MinimumWidth = 800
        Me.dgvcCodice.Name = "dgvcCodice"
        Me.dgvcCodice.ReadOnly = True
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
        Me.dgvcAnno.Width = 125
        '
        'dgvcScadRifPer
        '
        Me.dgvcScadRifPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcScadRifPer.DataPropertyName = "RifPeriodo"
        Me.dgvcScadRifPer.HeaderText = "Periodo"
        Me.dgvcScadRifPer.MinimumWidth = 6
        Me.dgvcScadRifPer.Name = "dgvcScadRifPer"
        Me.dgvcScadRifPer.ReadOnly = True
        '
        'dgvcInizio
        '
        Me.dgvcInizio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcInizio.DataPropertyName = "DataInizio"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgvcInizio.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcInizio.HeaderText = "Inizio"
        Me.dgvcInizio.MinimumWidth = 6
        Me.dgvcInizio.Name = "dgvcInizio"
        Me.dgvcInizio.ReadOnly = True
        Me.dgvcInizio.Width = 140
        '
        'dgvcUltimoAccesso
        '
        Me.dgvcUltimoAccesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUltimoAccesso.DataPropertyName = "DataFine"
        DataGridViewCellStyle4.Format = "G"
        Me.dgvcUltimoAccesso.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcUltimoAccesso.HeaderText = "Fine"
        Me.dgvcUltimoAccesso.MinimumWidth = 6
        Me.dgvcUltimoAccesso.Name = "dgvcUltimoAccesso"
        Me.dgvcUltimoAccesso.ReadOnly = True
        Me.dgvcUltimoAccesso.Width = 140
        '
        'dgvcScadDichiarazione
        '
        Me.dgvcScadDichiarazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcScadDichiarazione.DataPropertyName = "DataScadenzaDichiarazione"
        DataGridViewCellStyle5.Format = "G"
        Me.dgvcScadDichiarazione.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvcScadDichiarazione.HeaderText = "Scadenza dichiarazione"
        Me.dgvcScadDichiarazione.MinimumWidth = 6
        Me.dgvcScadDichiarazione.Name = "dgvcScadDichiarazione"
        Me.dgvcScadDichiarazione.ReadOnly = True
        Me.dgvcScadDichiarazione.Width = 140
        '
        'dgvcScadPagamento
        '
        Me.dgvcScadPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcScadPagamento.DataPropertyName = "DataScadenzaPagamento"
        DataGridViewCellStyle6.Format = "G"
        Me.dgvcScadPagamento.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcScadPagamento.HeaderText = "Scadenza Pagamento"
        Me.dgvcScadPagamento.MinimumWidth = 6
        Me.dgvcScadPagamento.Name = "dgvcScadPagamento"
        Me.dgvcScadPagamento.ReadOnly = True
        Me.dgvcScadPagamento.Width = 140
        '
        'dgvcCategoria
        '
        Me.dgvcCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCategoria.DataPropertyName = "CodCategoria"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcCategoria.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcCategoria.HeaderText = "Categoria"
        Me.dgvcCategoria.MinimumWidth = 6
        Me.dgvcCategoria.Name = "dgvcCategoria"
        Me.dgvcCategoria.ReadOnly = True
        Me.dgvcCategoria.Width = 110
        '
        'dgvcInteresse
        '
        Me.dgvcInteresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcInteresse.DataPropertyName = "TassoInteresse"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "n2"
        Me.dgvcInteresse.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcInteresse.HeaderText = "% Interesse"
        Me.dgvcInteresse.MinimumWidth = 6
        Me.dgvcInteresse.Name = "dgvcInteresse"
        Me.dgvcInteresse.ReadOnly = True
        Me.dgvcInteresse.Width = 110
        '
        'dgvcAuto
        '
        Me.dgvcAuto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAuto.DataPropertyName = "CreaAutomatico"
        Me.dgvcAuto.HeaderText = "Crea automatico"
        Me.dgvcAuto.ImageFalse = Nothing
        Me.dgvcAuto.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.dgvcAuto.MinimumWidth = 6
        Me.dgvcAuto.Name = "dgvcAuto"
        Me.dgvcAuto.ReadOnly = True
        Me.dgvcAuto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcAuto.ValueFalse = "False"
        Me.dgvcAuto.ValueTrue = "True"
        Me.dgvcAuto.Width = 160
        '
        'FElencoScadenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2372, 921)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FElencoScadenze"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione scadenze"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsScadenze, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsScadenze As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ccCategoria As mdsUIControls.ucCheckedCombo
    Friend WithEvents ccAnno As mdsUIControls.ucCheckedCombo
    Friend WithEvents tsbSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDuplica As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents dgvcCodice As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAnno As DataGridViewTextBoxColumn
    Friend WithEvents dgvcScadRifPer As DataGridViewTextBoxColumn
    Friend WithEvents dgvcInizio As DataGridViewTextBoxColumn
    Friend WithEvents dgvcUltimoAccesso As DataGridViewTextBoxColumn
    Friend WithEvents dgvcScadDichiarazione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcScadPagamento As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvcInteresse As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAuto As mdsUIControls.DataGridViewBooleanImageColumn
End Class
