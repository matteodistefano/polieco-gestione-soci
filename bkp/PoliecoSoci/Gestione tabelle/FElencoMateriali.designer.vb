<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoMateriali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoMateriali))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.bsMateriali = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAttivi = New System.Windows.Forms.CheckBox()
        Me.ccTipo = New mdsUIControls.ucCheckedCombo()
        Me.dgvcCodice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPrezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUtilizzato = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMateriali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuovo, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbSelect, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 454)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(877, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbNuovo
        '
        Me.tsbNuovo.Image = Global.PoliecoSoci.My.Resources.Resources.Add_Appointment_32_n_g
        Me.tsbNuovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuovo.Name = "tsbNuovo"
        Me.tsbNuovo.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbNuovo.Size = New System.Drawing.Size(82, 42)
        Me.tsbNuovo.Text = "Nuova"
        Me.tsbNuovo.ToolTipText = "Nuovo scadenza"
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(90, 42)
        Me.tsbModifica.Text = "Modifica"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.Delete_Appointment_32_n_g
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Size = New System.Drawing.Size(85, 42)
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
        Me.tsbChiudi.Size = New System.Drawing.Size(84, 42)
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
        Me.tsbSelect.Size = New System.Drawing.Size(98, 42)
        Me.tsbSelect.Text = "&Seleziona"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(83, 42)
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
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCodice, Me.dgvcDescrizione, Me.dgvcTipo, Me.dgvcUM, Me.dgvcPrezzo, Me.dgvcIva, Me.dgvcPeriodo, Me.dgvcUtilizzato})
        Me.dgvElenco.DataSource = Me.bsMateriali
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 33)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(877, 421)
        Me.dgvElenco.TabIndex = 6
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAttivi)
        Me.Panel1.Controls.Add(Me.ccTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 33)
        Me.Panel1.TabIndex = 7
        '
        'chkAttivi
        '
        Me.chkAttivi.Checked = True
        Me.chkAttivi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAttivi.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.chkAttivi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkAttivi.Location = New System.Drawing.Point(415, 4)
        Me.chkAttivi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAttivi.Name = "chkAttivi"
        Me.chkAttivi.Size = New System.Drawing.Size(95, 27)
        Me.chkAttivi.TabIndex = 2
        Me.chkAttivi.Text = "     Solo attivi"
        Me.chkAttivi.UseVisualStyleBackColor = True
        '
        'ccTipo
        '
        Me.ccTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccTipo.Checked = False
        Me.ccTipo.CheckText = "Solo tipo"
        Me.ccTipo.CheckWidth = 130
        Me.ccTipo.ComboText = ""
        Me.ccTipo.DataSource = Nothing
        Me.ccTipo.DisplayMember = ""
        Me.ccTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccTipo.Location = New System.Drawing.Point(10, 6)
        Me.ccTipo.MaxDropDownItems = 8
        Me.ccTipo.Name = "ccTipo"
        Me.ccTipo.SelectedIndex = -1
        Me.ccTipo.SelectedValue = Nothing
        Me.ccTipo.Size = New System.Drawing.Size(385, 21)
        Me.ccTipo.TabIndex = 1
        Me.ccTipo.ValueFieldName = Nothing
        Me.ccTipo.ValueMember = ""
        Me.ccTipo.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'dgvcCodice
        '
        Me.dgvcCodice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodice.DataPropertyName = "Codice"
        Me.dgvcCodice.HeaderText = "Codice"
        Me.dgvcCodice.Name = "dgvcCodice"
        Me.dgvcCodice.ReadOnly = True
        Me.dgvcCodice.Width = 160
        '
        'dgvcDescrizione
        '
        Me.dgvcDescrizione.DataPropertyName = "Descrizione"
        Me.dgvcDescrizione.HeaderText = "Descrizione"
        Me.dgvcDescrizione.Name = "dgvcDescrizione"
        Me.dgvcDescrizione.ReadOnly = True
        '
        'dgvcTipo
        '
        Me.dgvcTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcTipo.DataPropertyName = "CodTipo"
        Me.dgvcTipo.HeaderText = "Tipo"
        Me.dgvcTipo.Name = "dgvcTipo"
        Me.dgvcTipo.ReadOnly = True
        Me.dgvcTipo.Width = 120
        '
        'dgvcUM
        '
        Me.dgvcUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUM.DataPropertyName = "CodUnitaMisura"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcUM.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcUM.HeaderText = "Unita misura"
        Me.dgvcUM.Name = "dgvcUM"
        Me.dgvcUM.ReadOnly = True
        Me.dgvcUM.Width = 60
        '
        'dgvcPrezzo
        '
        Me.dgvcPrezzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPrezzo.DataPropertyName = "Prezzo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "c4"
        Me.dgvcPrezzo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcPrezzo.HeaderText = "Prezzo"
        Me.dgvcPrezzo.Name = "dgvcPrezzo"
        Me.dgvcPrezzo.ReadOnly = True
        '
        'dgvcIva
        '
        Me.dgvcIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcIva.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        Me.dgvcIva.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcIva.HeaderText = "Iva"
        Me.dgvcIva.Name = "dgvcIva"
        Me.dgvcIva.ReadOnly = True
        Me.dgvcIva.Width = 50
        '
        'dgvcPeriodo
        '
        Me.dgvcPeriodo.DataPropertyName = "DescrPeriodo"
        Me.dgvcPeriodo.HeaderText = "Periodo"
        Me.dgvcPeriodo.Name = "dgvcPeriodo"
        Me.dgvcPeriodo.ReadOnly = True
        '
        'dgvcUtilizzato
        '
        Me.dgvcUtilizzato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUtilizzato.DataPropertyName = "Utilizzato"
        Me.dgvcUtilizzato.HeaderText = "Utiliz."
        Me.dgvcUtilizzato.ImageFalse = Nothing
        Me.dgvcUtilizzato.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.dgvcUtilizzato.Name = "dgvcUtilizzato"
        Me.dgvcUtilizzato.ReadOnly = True
        Me.dgvcUtilizzato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcUtilizzato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcUtilizzato.ValueFalse = "False"
        Me.dgvcUtilizzato.ValueTrue = "True"
        Me.dgvcUtilizzato.Width = 40
        '
        'FElencoMateriali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 499)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FElencoMateriali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione materiali"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMateriali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvElenco As System.Windows.Forms.DataGridView
    Friend WithEvents bsMateriali As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ccTipo As mdsUIControls.ucCheckedCombo
    Friend WithEvents tsbSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkAttivi As System.Windows.Forms.CheckBox
    Friend WithEvents dgvcCodice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcPrezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcPeriodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcUtilizzato As mdsUIControls.DataGridViewBooleanImageColumn
End Class
