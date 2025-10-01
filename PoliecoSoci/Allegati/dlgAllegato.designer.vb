<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAllegato
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
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.bsAllegato = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.lDichiarazione = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bsDettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDettaglio = New System.Windows.Forms.DataGridView()
        Me.tsSedi = New System.Windows.Forms.ToolStrip()
        Me.tsbSediAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbSediEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbSediDel = New System.Windows.Forms.ToolStripButton()
        Me.lAnno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tsbAzienda = New System.Windows.Forms.ToolStripButton()
        Me.dgvcRagSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRuolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCodCer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcQta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.bsAllegato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsSedi.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk, Me.tsbDelete})
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
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_24_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(54, 34)
        Me.tsbOk.Text = "Ok"
        '
        'tsbDelete
        '
        Me.tsbDelete.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbDelete.Size = New System.Drawing.Size(123, 34)
        Me.tsbDelete.Text = "Elimina allegato"
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
        Me.lDichiarazione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAllegato, "IdDichiarazione", True))
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
        'dgvDettaglio
        '
        Me.dgvDettaglio.AllowUserToAddRows = False
        Me.dgvDettaglio.AllowUserToDeleteRows = False
        Me.dgvDettaglio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDettaglio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcRagSoc, Me.dgvcSede, Me.dgvcRuolo, Me.dgvcCodCer, Me.dgvcDescrizione, Me.dgvcUM, Me.dgvcQta})
        Me.dgvDettaglio.Location = New System.Drawing.Point(15, 109)
        Me.dgvDettaglio.Name = "dgvDettaglio"
        Me.dgvDettaglio.ReadOnly = True
        Me.dgvDettaglio.RowHeadersWidth = 20
        Me.dgvDettaglio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDettaglio.Size = New System.Drawing.Size(1021, 343)
        Me.dgvDettaglio.TabIndex = 88
        '
        'tsSedi
        '
        Me.tsSedi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsSedi.AutoSize = False
        Me.tsSedi.Dock = System.Windows.Forms.DockStyle.None
        Me.tsSedi.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsSedi.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsSedi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSediAdd, Me.tsbSediEdit, Me.tsbSediDel, Me.tsbAzienda})
        Me.tsSedi.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsSedi.Location = New System.Drawing.Point(1039, 109)
        Me.tsSedi.Name = "tsSedi"
        Me.tsSedi.Size = New System.Drawing.Size(36, 343)
        Me.tsSedi.TabIndex = 89
        '
        'tsbSediAdd
        '
        Me.tsbSediAdd.AutoSize = False
        Me.tsbSediAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSediAdd.Image = Global.PoliecoSoci.My.Resources.Resources.Green_Plus_24_n_g
        Me.tsbSediAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSediAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSediAdd.Name = "tsbSediAdd"
        Me.tsbSediAdd.Size = New System.Drawing.Size(70, 30)
        Me.tsbSediAdd.Text = "Nuova"
        '
        'tsbSediEdit
        '
        Me.tsbSediEdit.AutoSize = False
        Me.tsbSediEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSediEdit.Image = Global.PoliecoSoci.My.Resources.Resources.Edit_24_n_g
        Me.tsbSediEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSediEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSediEdit.Name = "tsbSediEdit"
        Me.tsbSediEdit.Size = New System.Drawing.Size(70, 30)
        Me.tsbSediEdit.Text = "Modifica"
        '
        'tsbSediDel
        '
        Me.tsbSediDel.AutoSize = False
        Me.tsbSediDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSediDel.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.tsbSediDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSediDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSediDel.Name = "tsbSediDel"
        Me.tsbSediDel.Size = New System.Drawing.Size(70, 30)
        Me.tsbSediDel.Text = "Elimina"
        '
        'lAnno
        '
        Me.lAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAnno.BackColor = System.Drawing.Color.White
        Me.lAnno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAllegato, "Anno", True))
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
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAllegato, "Periodo", True))
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
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAllegato, "CategoriaAzienda", True))
        Me.Label6.Location = New System.Drawing.Point(457, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 21)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Materiale"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'dgvcRagSoc
        '
        Me.dgvcRagSoc.DataPropertyName = "AziendaRagioneSociale"
        Me.dgvcRagSoc.FillWeight = 40.0!
        Me.dgvcRagSoc.HeaderText = "Ragione sociale"
        Me.dgvcRagSoc.Name = "dgvcRagSoc"
        Me.dgvcRagSoc.ReadOnly = True
        '
        'dgvcSede
        '
        Me.dgvcSede.DataPropertyName = "AziendaDescrizioneSede"
        Me.dgvcSede.FillWeight = 30.0!
        Me.dgvcSede.HeaderText = "Sede"
        Me.dgvcSede.Name = "dgvcSede"
        Me.dgvcSede.ReadOnly = True
        '
        'dgvcRuolo
        '
        Me.dgvcRuolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcRuolo.DataPropertyName = "RuoloAziendaAllegato"
        Me.dgvcRuolo.HeaderText = "Ruolo"
        Me.dgvcRuolo.Name = "dgvcRuolo"
        Me.dgvcRuolo.ReadOnly = True
        Me.dgvcRuolo.Width = 50
        '
        'dgvcCodCer
        '
        Me.dgvcCodCer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodCer.DataPropertyName = "CodiceCer"
        Me.dgvcCodCer.HeaderText = "Cod.CER"
        Me.dgvcCodCer.Name = "dgvcCodCer"
        Me.dgvcCodCer.ReadOnly = True
        Me.dgvcCodCer.Width = 60
        '
        'dgvcDescrizione
        '
        Me.dgvcDescrizione.DataPropertyName = "DescrizioneMateriale"
        Me.dgvcDescrizione.FillWeight = 30.0!
        Me.dgvcDescrizione.HeaderText = "Materiale"
        Me.dgvcDescrizione.Name = "dgvcDescrizione"
        Me.dgvcDescrizione.ReadOnly = True
        '
        'dgvcUM
        '
        Me.dgvcUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUM.DataPropertyName = "UnitaMisura"
        Me.dgvcUM.HeaderText = "U.M."
        Me.dgvcUM.Name = "dgvcUM"
        Me.dgvcUM.ReadOnly = True
        Me.dgvcUM.Width = 40
        '
        'dgvcQta
        '
        Me.dgvcQta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcQta.DataPropertyName = "Quantita"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.dgvcQta.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcQta.HeaderText = "Qta"
        Me.dgvcQta.Name = "dgvcQta"
        Me.dgvcQta.ReadOnly = True
        '
        'dlgAllegato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 506)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lAnno)
        Me.Controls.Add(Me.tsSedi)
        Me.Controls.Add(Me.dgvDettaglio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lDichiarazione)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgAllegato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allegato"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsAllegato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsSedi.ResumeLayout(False)
        Me.tsSedi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsAllegato As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lAzienda As Label
    Friend WithEvents lDichiarazione As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bsDettaglio As BindingSource
    Friend WithEvents dgvDettaglio As DataGridView
    Friend WithEvents tsSedi As ToolStrip
    Friend WithEvents tsbSediAdd As ToolStripButton
    Friend WithEvents tsbSediEdit As ToolStripButton
    Friend WithEvents tsbSediDel As ToolStripButton
    Friend WithEvents lAnno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents tsbAzienda As ToolStripButton
    Friend WithEvents dgvcRagSoc As DataGridViewTextBoxColumn
    Friend WithEvents dgvcSede As DataGridViewTextBoxColumn
    Friend WithEvents dgvcRuolo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCodCer As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcUM As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQta As DataGridViewTextBoxColumn
End Class
