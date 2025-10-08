<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoQuadri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoQuadri))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.tsbMateriali = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.dgvcCodice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcSegno = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgvcPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUtilizzato = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.bsQuadri = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAttivi = New System.Windows.Forms.CheckBox()
        Me.ccTipo = New mdsUIControls.ucCheckedCombo()
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsQuadri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuovo, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbSelect, Me.tsbStampa, Me.tsbMateriali})
        Me.tsMain.Location = New System.Drawing.Point(0, 811)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1607, 45)
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
        Me.tsbNuovo.Size = New System.Drawing.Size(107, 42)
        Me.tsbNuovo.Text = "Nuova"
        Me.tsbNuovo.ToolTipText = "Nuovo scadenza"
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
        Me.tsbChiudi.Image = CType(resources.GetObject("tsbChiudi.Image"), System.Drawing.Image)
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
        Me.tsbStampa.Image = CType(resources.GetObject("tsbStampa.Image"), System.Drawing.Image)
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'tsbMateriali
        '
        Me.tsbMateriali.Image = Global.PoliecoSoci.My.Resources.Resources.List_32_n_g
        Me.tsbMateriali.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbMateriali.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMateriali.Margin = New System.Windows.Forms.Padding(50, 1, 0, 2)
        Me.tsbMateriali.Name = "tsbMateriali"
        Me.tsbMateriali.Size = New System.Drawing.Size(125, 42)
        Me.tsbMateriali.Text = "Materiali"
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
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCodice, Me.dgvcDescrizione, Me.dgvcTipo, Me.dgvcSegno, Me.dgvcPeriodo, Me.dgvcUtilizzato})
        Me.dgvElenco.DataSource = Me.bsQuadri
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 62)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.RowHeadersWidth = 51
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1607, 749)
        Me.dgvElenco.TabIndex = 6
        '
        'dgvcCodice
        '
        Me.dgvcCodice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodice.DataPropertyName = "Codice"
        Me.dgvcCodice.HeaderText = "Codice"
        Me.dgvcCodice.MinimumWidth = 6
        Me.dgvcCodice.Name = "dgvcCodice"
        Me.dgvcCodice.ReadOnly = True
        Me.dgvcCodice.Width = 90
        '
        'dgvcDescrizione
        '
        Me.dgvcDescrizione.DataPropertyName = "Descrizione"
        Me.dgvcDescrizione.HeaderText = "Descrizione"
        Me.dgvcDescrizione.MinimumWidth = 6
        Me.dgvcDescrizione.Name = "dgvcDescrizione"
        Me.dgvcDescrizione.ReadOnly = True
        '
        'dgvcTipo
        '
        Me.dgvcTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcTipo.DataPropertyName = "CodTipo"
        Me.dgvcTipo.HeaderText = "Tipo"
        Me.dgvcTipo.MinimumWidth = 6
        Me.dgvcTipo.Name = "dgvcTipo"
        Me.dgvcTipo.ReadOnly = True
        Me.dgvcTipo.Width = 180
        '
        'dgvcSegno
        '
        Me.dgvcSegno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcSegno.HeaderText = "Segno"
        Me.dgvcSegno.MinimumWidth = 6
        Me.dgvcSegno.Name = "dgvcSegno"
        Me.dgvcSegno.ReadOnly = True
        Me.dgvcSegno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcSegno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcSegno.Width = 90
        '
        'dgvcPeriodo
        '
        Me.dgvcPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPeriodo.DataPropertyName = "DescrPeriodo"
        Me.dgvcPeriodo.HeaderText = "Periodo"
        Me.dgvcPeriodo.MinimumWidth = 6
        Me.dgvcPeriodo.Name = "dgvcPeriodo"
        Me.dgvcPeriodo.ReadOnly = True
        Me.dgvcPeriodo.Width = 300
        '
        'dgvcUtilizzato
        '
        Me.dgvcUtilizzato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUtilizzato.DataPropertyName = "Utilizzato"
        Me.dgvcUtilizzato.HeaderText = "Utiliz."
        Me.dgvcUtilizzato.ImageFalse = Nothing
        Me.dgvcUtilizzato.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.dgvcUtilizzato.MinimumWidth = 6
        Me.dgvcUtilizzato.Name = "dgvcUtilizzato"
        Me.dgvcUtilizzato.ReadOnly = True
        Me.dgvcUtilizzato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcUtilizzato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcUtilizzato.ValueFalse = "False"
        Me.dgvcUtilizzato.ValueTrue = "True"
        Me.dgvcUtilizzato.Width = 80
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAttivi)
        Me.Panel1.Controls.Add(Me.ccTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1607, 62)
        Me.Panel1.TabIndex = 7
        '
        'chkAttivi
        '
        Me.chkAttivi.Checked = True
        Me.chkAttivi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAttivi.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_32_n_p8
        Me.chkAttivi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkAttivi.Location = New System.Drawing.Point(760, 8)
        Me.chkAttivi.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAttivi.Name = "chkAttivi"
        Me.chkAttivi.Size = New System.Drawing.Size(205, 50)
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
        Me.ccTipo.CheckWidth = 246
        Me.ccTipo.ComboText = ""
        Me.ccTipo.DataSource = Nothing
        Me.ccTipo.DisplayMember = ""
        Me.ccTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccTipo.Location = New System.Drawing.Point(18, 10)
        Me.ccTipo.Margin = New System.Windows.Forms.Padding(6)
        Me.ccTipo.MaxDropDownItems = 8
        Me.ccTipo.Name = "ccTipo"
        Me.ccTipo.SelectedIndex = -1
        Me.ccTipo.SelectedValue = Nothing
        Me.ccTipo.Size = New System.Drawing.Size(705, 39)
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
        Me.DataGridViewBooleanImageColumn1.MinimumWidth = 6
        Me.DataGridViewBooleanImageColumn1.Name = "DataGridViewBooleanImageColumn1"
        Me.DataGridViewBooleanImageColumn1.ReadOnly = True
        Me.DataGridViewBooleanImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBooleanImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewBooleanImageColumn1.ValueFalse = "False"
        Me.DataGridViewBooleanImageColumn1.ValueTrue = "True"
        Me.DataGridViewBooleanImageColumn1.Width = 60
        '
        'FElencoQuadri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1607, 856)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FElencoQuadri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione quadri dichiarazioni"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsQuadri, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsQuadri As System.Windows.Forms.BindingSource
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
    Friend WithEvents tsbMateriali As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvcCodice As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTipo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcSegno As DataGridViewImageColumn
    Friend WithEvents dgvcPeriodo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcUtilizzato As mdsUIControls.DataGridViewBooleanImageColumn
End Class
