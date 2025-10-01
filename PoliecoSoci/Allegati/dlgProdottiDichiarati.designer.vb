<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgProdottiDichiarati
    Inherits mdsUIControls.BaseForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.bsDichiarazione = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.lDichiarazione = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bsProdotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvProdotti = New System.Windows.Forms.DataGridView()
        Me.dgvcDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcQtaVer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcQtaRic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsProdotti = New System.Windows.Forms.ToolStrip()
        Me.tsbProdAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbProdEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbProdDel = New System.Windows.Forms.ToolStripButton()
        Me.tsbAzienda = New System.Windows.Forms.ToolStripButton()
        Me.lAnno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgslQV = New mdsUIControls.DataGridSummaryLabel()
        Me.dgslQR = New mdsUIControls.DataGridSummaryLabel()
        Me.tsMain.SuspendLayout()
        CType(Me.bsDichiarazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsProdotti.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 469)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1084, 37)
        Me.tsMain.TabIndex = 1
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_24_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(80, 34)
        Me.tsbExit.Text = "Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Enabled = False
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_24_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(54, 34)
        Me.tsbOk.Text = "Ok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Azienda dichiarante"
        '
        'lAzienda
        '
        Me.lAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzienda.BackColor = System.Drawing.Color.White
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzienda.Location = New System.Drawing.Point(12, 26)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(1047, 21)
        Me.lAzienda.TabIndex = 79
        Me.lAzienda.Text = "Materiale"
        Me.lAzienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lDichiarazione
        '
        Me.lDichiarazione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lDichiarazione.BackColor = System.Drawing.Color.White
        Me.lDichiarazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDichiarazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDichiarazione, "Id", True))
        Me.lDichiarazione.Location = New System.Drawing.Point(12, 74)
        Me.lDichiarazione.Name = "lDichiarazione"
        Me.lDichiarazione.Size = New System.Drawing.Size(136, 21)
        Me.lDichiarazione.TabIndex = 81
        Me.lDichiarazione.Text = "Materiale"
        Me.lDichiarazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Dichiarazione"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Anno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Periodo"
        '
        'dgvProdotti
        '
        Me.dgvProdotti.AllowUserToAddRows = False
        Me.dgvProdotti.AllowUserToDeleteRows = False
        Me.dgvProdotti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProdotti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdotti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcDescrizione, Me.dgvcQtaVer, Me.dgvcQtaRic})
        Me.dgvProdotti.Location = New System.Drawing.Point(15, 109)
        Me.dgvProdotti.Name = "dgvProdotti"
        Me.dgvProdotti.ReadOnly = True
        Me.dgvProdotti.RowHeadersWidth = 20
        Me.dgvProdotti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdotti.Size = New System.Drawing.Size(1021, 291)
        Me.dgvProdotti.TabIndex = 88
        '
        'dgvcDescrizione
        '
        Me.dgvcDescrizione.DataPropertyName = "Descrizione"
        Me.dgvcDescrizione.FillWeight = 40.0!
        Me.dgvcDescrizione.HeaderText = "Descrizione"
        Me.dgvcDescrizione.Name = "dgvcDescrizione"
        Me.dgvcDescrizione.ReadOnly = True
        '
        'dgvcQtaVer
        '
        Me.dgvcQtaVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcQtaVer.DataPropertyName = "QtaVergine"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.dgvcQtaVer.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcQtaVer.HeaderText = "Q.ta Vergine"
        Me.dgvcQtaVer.Name = "dgvcQtaVer"
        Me.dgvcQtaVer.ReadOnly = True
        Me.dgvcQtaVer.Width = 90
        '
        'dgvcQtaRig
        '
        Me.dgvcQtaRic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcQtaRic.DataPropertyName = "QtaRiciclato"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.dgvcQtaRic.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcQtaRic.FillWeight = 30.0!
        Me.dgvcQtaRic.HeaderText = "Q.ta Riciclato"
        Me.dgvcQtaRic.Name = "dgvcQtaRic"
        Me.dgvcQtaRic.ReadOnly = True
        Me.dgvcQtaRic.Width = 90
        '
        'tsProdotti
        '
        Me.tsProdotti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsProdotti.AutoSize = False
        Me.tsProdotti.Dock = System.Windows.Forms.DockStyle.None
        Me.tsProdotti.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsProdotti.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsProdotti.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProdAdd, Me.tsbProdEdit, Me.tsbProdDel, Me.tsbAzienda})
        Me.tsProdotti.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsProdotti.Location = New System.Drawing.Point(1039, 109)
        Me.tsProdotti.Name = "tsProdotti"
        Me.tsProdotti.Size = New System.Drawing.Size(36, 343)
        Me.tsProdotti.TabIndex = 89
        '
        'tsbProdAdd
        '
        Me.tsbProdAdd.AutoSize = False
        Me.tsbProdAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProdAdd.Enabled = False
        Me.tsbProdAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.tsbProdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbProdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProdAdd.Name = "tsbProdAdd"
        Me.tsbProdAdd.Size = New System.Drawing.Size(70, 30)
        Me.tsbProdAdd.Text = "Nuova"
        '
        'tsbProdEdit
        '
        Me.tsbProdEdit.AutoSize = False
        Me.tsbProdEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProdEdit.Enabled = False
        Me.tsbProdEdit.Image = Global.PoliecoSoci.My.Resources.Resources.Edit_24_n_g
        Me.tsbProdEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbProdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProdEdit.Name = "tsbProdEdit"
        Me.tsbProdEdit.Size = New System.Drawing.Size(70, 30)
        Me.tsbProdEdit.Text = "Modifica"
        '
        'tsbProdDel
        '
        Me.tsbProdDel.AutoSize = False
        Me.tsbProdDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProdDel.Enabled = False
        Me.tsbProdDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbProdDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbProdDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProdDel.Name = "tsbProdDel"
        Me.tsbProdDel.Size = New System.Drawing.Size(70, 30)
        Me.tsbProdDel.Text = "Elimina"
        '
        'tsbAzienda
        '
        Me.tsbAzienda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAzienda.AutoSize = False
        Me.tsbAzienda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAzienda.Image = Global.PoliecoSoci.My.Resources.Resources.Office_Block_24_h_g
        Me.tsbAzienda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAzienda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAzienda.Name = "tsbAzienda"
        Me.tsbAzienda.Size = New System.Drawing.Size(70, 30)
        Me.tsbAzienda.Text = "Azienda"
        Me.tsbAzienda.ToolTipText = "Scheda azienda allegato"
        '
        'lAnno
        '
        Me.lAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAnno.BackColor = System.Drawing.Color.White
        Me.lAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDichiarazione, "Anno", True))
        Me.lAnno.Location = New System.Drawing.Point(154, 74)
        Me.lAnno.Name = "lAnno"
        Me.lAnno.Size = New System.Drawing.Size(102, 21)
        Me.lAnno.TabIndex = 90
        Me.lAnno.Text = "Materiale"
        Me.lAnno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDichiarazione, "Periodo", True))
        Me.Label4.Location = New System.Drawing.Point(262, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 21)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Materiale"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDichiarazione, "CodCategoria", True))
        Me.Label6.Location = New System.Drawing.Point(457, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 21)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Materiale"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgslQV
        '
        Me.dgslQV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgslQV.DataFormat = "N2"
        Me.dgslQV.GridColumn = Nothing
        Me.dgslQV.GridMargin = 10
        Me.dgslQV.HorizontalOffset = 0
        Me.dgslQV.Location = New System.Drawing.Point(734, 416)
        Me.dgslQV.Name = "dgslQV"
        Me.dgslQV.PartialSummaryActive = False
        Me.dgslQV.Size = New System.Drawing.Size(100, 20)
        Me.dgslQV.SummaryOnSelection = False
        Me.dgslQV.SummaryType = mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM
        Me.dgslQV.TabIndex = 93
        Me.dgslQV.Text = "0"
        Me.dgslQV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dgslQV.WeightColumn = Nothing
        '
        'dgslQR
        '
        Me.dgslQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgslQR.DataFormat = "N2"
        Me.dgslQR.GridColumn = Nothing
        Me.dgslQR.GridMargin = 10
        Me.dgslQR.HorizontalOffset = 0
        Me.dgslQR.Location = New System.Drawing.Point(863, 416)
        Me.dgslQR.Name = "dgslQR"
        Me.dgslQR.PartialSummaryActive = False
        Me.dgslQR.Size = New System.Drawing.Size(100, 20)
        Me.dgslQR.SummaryOnSelection = False
        Me.dgslQR.SummaryType = mdsUIControls.DataGridSummaryLabel.SummaryTypeEnum.SUM
        Me.dgslQR.TabIndex = 94
        Me.dgslQR.Text = "0"
        Me.dgslQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dgslQR.WeightColumn = Nothing
        '
        'dlgProdottiDichiarati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 506)
        Me.Controls.Add(Me.dgslQR)
        Me.Controls.Add(Me.dgslQV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lAnno)
        Me.Controls.Add(Me.tsProdotti)
        Me.Controls.Add(Me.dgvProdotti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lDichiarazione)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgProdottiDichiarati"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allegato"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsDichiarazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsProdotti.ResumeLayout(False)
        Me.tsProdotti.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsDichiarazione As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lAzienda As Label
    Friend WithEvents lDichiarazione As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bsProdotti As BindingSource
    Friend WithEvents dgvProdotti As DataGridView
    Friend WithEvents tsProdotti As ToolStrip
    Friend WithEvents tsbProdAdd As ToolStripButton
    Friend WithEvents tsbProdEdit As ToolStripButton
    Friend WithEvents tsbProdDel As ToolStripButton
    Friend WithEvents lAnno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tsbAzienda As ToolStripButton
    Friend WithEvents dgvcDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQtaVer As DataGridViewTextBoxColumn
    Friend WithEvents dgslQV As mdsUIControls.DataGridSummaryLabel
    Friend WithEvents dgslQR As mdsUIControls.DataGridSummaryLabel
    Friend WithEvents dgvcQtaRic As DataGridViewTextBoxColumn
End Class
