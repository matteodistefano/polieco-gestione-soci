<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoProdotti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoProdotti))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.tsbSelect = New System.Windows.Forms.ToolStripButton()
        Me.bsProd = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRic = New System.Windows.Forms.TextBox()
        Me.btnRic = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.dgvcCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.bsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuovo, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbStampa, Me.tsbSelect})
        Me.tsMain.Location = New System.Drawing.Point(0, 569)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1169, 45)
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
        Me.tsbNuovo.Size = New System.Drawing.Size(92, 42)
        Me.tsbNuovo.Text = "Nuova"
        Me.tsbNuovo.ToolTipText = "Nuovo scadenza"
        Me.tsbNuovo.Visible = False
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(104, 42)
        Me.tsbModifica.Text = "Modifica"
        Me.tsbModifica.Visible = False
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.Delete_Appointment_32_n_g
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Size = New System.Drawing.Size(98, 42)
        Me.tsbElimina.Text = "Elimina "
        Me.tsbElimina.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        Me.ToolStripSeparator1.Visible = False
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
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(96, 42)
        Me.tsbStampa.Text = "Stampa"
        Me.tsbStampa.Visible = False
        '
        'tsbSelect
        '
        Me.tsbSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSelect.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_32_n_p8
        Me.tsbSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSelect.Name = "tsbSelect"
        Me.tsbSelect.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbSelect.Size = New System.Drawing.Size(115, 42)
        Me.tsbSelect.Text = "&Seleziona"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Cerca"
        '
        'txtRic
        '
        Me.txtRic.Location = New System.Drawing.Point(57, 13)
        Me.txtRic.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRic.Name = "txtRic"
        Me.txtRic.Size = New System.Drawing.Size(287, 22)
        Me.txtRic.TabIndex = 37
        '
        'btnRic
        '
        Me.btnRic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRic.Image = Global.PoliecoSoci.My.Resources.Resources.Search_16_n_g
        Me.btnRic.Location = New System.Drawing.Point(351, 13)
        Me.btnRic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRic.Name = "btnRic"
        Me.btnRic.Size = New System.Drawing.Size(44, 25)
        Me.btnRic.TabIndex = 77
        Me.btnRic.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtRic)
        Me.Panel1.Controls.Add(Me.btnRic)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 57)
        Me.Panel1.TabIndex = 9
        '
        'dgvProd
        '
        Me.dgvProd.AllowUserToAddRows = False
        Me.dgvProd.AllowUserToDeleteRows = False
        Me.dgvProd.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProd.AutoGenerateColumns = False
        Me.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCat, Me.dgvcProd})
        Me.dgvProd.DataSource = Me.bsProd
        Me.dgvProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProd.Location = New System.Drawing.Point(0, 57)
        Me.dgvProd.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.ReadOnly = True
        Me.dgvProd.RowHeadersVisible = False
        Me.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProd.Size = New System.Drawing.Size(1169, 512)
        Me.dgvProd.TabIndex = 80
        '
        'dgvcCat
        '
        Me.dgvcCat.DataPropertyName = "DescrCategoria"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcCat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcCat.HeaderText = "Categoria"
        Me.dgvcCat.Name = "dgvcCat"
        Me.dgvcCat.ReadOnly = True
        '
        'dgvcProd
        '
        Me.dgvcProd.DataPropertyName = "Descrizione"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcProd.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcProd.HeaderText = "Prodotto"
        Me.dgvcProd.Name = "dgvcProd"
        Me.dgvcProd.ReadOnly = True
        '
        'FElencoProdotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 614)
        Me.Controls.Add(Me.dgvProd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FElencoProdotti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione prodotti"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsProd As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents tsbSelect As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRic As System.Windows.Forms.TextBox
    Friend WithEvents btnRic As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvProd As System.Windows.Forms.DataGridView
    Friend WithEvents dgvcCat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcProd As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
