<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAttivita
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
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescrizione = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodAteco = New System.Windows.Forms.TextBox()
        Me.cdiData = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConsAnno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrevAnno = New System.Windows.Forms.TextBox()
        Me.txtConsQta = New System.Windows.Forms.TextBox()
        Me.txtPrevQta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.dgvAttrezzature = New System.Windows.Forms.DataGridView()
        Me.dgvcAttSel = New mdsUIControls.DataGridViewBooleanImageColumn()
        Me.dgvcAttrDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAttrLarghezza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAttrAltezza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAttrezzature = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAttrezzature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAttrezzature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 562)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1471, 69)
        Me.tsMain.TabIndex = 10
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_32_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(117, 66)
        Me.tsbExit.Text = "Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_32_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(74, 66)
        Me.tsbOk.Text = "Ok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Azienda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo"
        '
        'lAzienda
        '
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(138, 16)
        Me.lAzienda.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(1243, 58)
        Me.lAzienda.TabIndex = 0
        '
        'cbTipo
        '
        Me.cbTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodTipoAttivita", True))
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(138, 111)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(6)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(209, 32)
        Me.cbTipo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descrizione"
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Descrizione", True))
        Me.txtDescrizione.Location = New System.Drawing.Point(138, 210)
        Me.txtDescrizione.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDescrizione.Multiline = True
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrizione.Size = New System.Drawing.Size(387, 85)
        Me.txtDescrizione.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodCategoria", True))
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(138, 160)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(6)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(498, 32)
        Me.cbCategoria.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 369)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Cod.ATECO"
        '
        'txtCodAteco
        '
        Me.txtCodAteco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "CodiceAteco", True))
        Me.txtCodAteco.Location = New System.Drawing.Point(138, 363)
        Me.txtCodAteco.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCodAteco.Name = "txtCodAteco"
        Me.txtCodAteco.Size = New System.Drawing.Size(235, 32)
        Me.txtCodAteco.TabIndex = 58
        '
        'cdiData
        '
        Me.cdiData.DataBindings.Add(New System.Windows.Forms.Binding("DataIniziale", Me.bsData, "DataIniziale", True))
        Me.cdiData.DataBindings.Add(New System.Windows.Forms.Binding("DataFinale", Me.bsData, "DataFinale", True))
        Me.cdiData.DataFinale = Nothing
        Me.cdiData.DataIniziale = Nothing
        Me.cdiData.DateFormat = "dd/MM/yyyy"
        Me.cdiData.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiData.Location = New System.Drawing.Point(138, 310)
        Me.cdiData.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.cdiData.MonthFormat = False
        Me.cdiData.Name = "cdiData"
        Me.cdiData.Size = New System.Drawing.Size(407, 32)
        Me.cdiData.TabIndex = 59
        Me.cdiData.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiData.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 310)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Periodo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 455)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 24)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Consuntivo"
        '
        'txtConsAnno
        '
        Me.txtConsAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "AnnoPrecedente", True))
        Me.txtConsAnno.Location = New System.Drawing.Point(139, 455)
        Me.txtConsAnno.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConsAnno.Name = "txtConsAnno"
        Me.txtConsAnno.Size = New System.Drawing.Size(187, 32)
        Me.txtConsAnno.TabIndex = 62
        Me.txtConsAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 426)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Anno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 506)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 24)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Preventivo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 428)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 24)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Quantità (Tn)"
        '
        'txtPrevAnno
        '
        Me.txtPrevAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "AnnoCorrente", True))
        Me.txtPrevAnno.Location = New System.Drawing.Point(139, 500)
        Me.txtPrevAnno.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPrevAnno.Name = "txtPrevAnno"
        Me.txtPrevAnno.Size = New System.Drawing.Size(187, 32)
        Me.txtPrevAnno.TabIndex = 66
        Me.txtPrevAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsQta
        '
        Me.txtConsQta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "QuantitaAnnoPrecedente", True))
        Me.txtConsQta.Location = New System.Drawing.Point(339, 455)
        Me.txtConsQta.Margin = New System.Windows.Forms.Padding(6)
        Me.txtConsQta.Name = "txtConsQta"
        Me.txtConsQta.Size = New System.Drawing.Size(187, 32)
        Me.txtConsQta.TabIndex = 67
        Me.txtConsQta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrevQta
        '
        Me.txtPrevQta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "QuantitaAnnoCorrente", True))
        Me.txtPrevQta.Location = New System.Drawing.Point(339, 500)
        Me.txtPrevQta.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPrevQta.Name = "txtPrevQta"
        Me.txtPrevQta.Size = New System.Drawing.Size(187, 32)
        Me.txtPrevQta.TabIndex = 68
        Me.txtPrevQta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(693, 87)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 24)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Attrezzature"
        '
        'lLogo
        '
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Truck_48_n_g
        Me.lLogo.Location = New System.Drawing.Point(1392, 16)
        Me.lLogo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(59, 58)
        Me.lLogo.TabIndex = 54
        '
        'dgvAttrezzature
        '
        Me.dgvAttrezzature.AllowUserToAddRows = False
        Me.dgvAttrezzature.AllowUserToDeleteRows = False
        Me.dgvAttrezzature.AutoGenerateColumns = False
        Me.dgvAttrezzature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttrezzature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttrezzature.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcAttSel, Me.dgvcAttrDescrizione, Me.dgvcAttrLarghezza, Me.dgvcAttrAltezza})
        Me.dgvAttrezzature.DataSource = Me.bsAttrezzature
        Me.dgvAttrezzature.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvAttrezzature.Location = New System.Drawing.Point(697, 117)
        Me.dgvAttrezzature.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvAttrezzature.Name = "dgvAttrezzature"
        Me.dgvAttrezzature.RowHeadersWidth = 20
        Me.dgvAttrezzature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAttrezzature.Size = New System.Drawing.Size(754, 415)
        Me.dgvAttrezzature.TabIndex = 70
        '
        'dgvcAttSel
        '
        Me.dgvcAttSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAttSel.DataPropertyName = "Selected"
        Me.dgvcAttSel.HeaderText = "Sel."
        Me.dgvcAttSel.ImageFalse = Nothing
        Me.dgvcAttSel.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.dgvcAttSel.MinimumWidth = 10
        Me.dgvcAttSel.Name = "dgvcAttSel"
        Me.dgvcAttSel.ReadOnly = True
        Me.dgvcAttSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcAttSel.ValueFalse = "False"
        Me.dgvcAttSel.ValueTrue = "True"
        Me.dgvcAttSel.Width = 60
        '
        'dgvcAttrDescrizione
        '
        Me.dgvcAttrDescrizione.DataPropertyName = "Descrizione"
        Me.dgvcAttrDescrizione.HeaderText = "Descrizione"
        Me.dgvcAttrDescrizione.MinimumWidth = 6
        Me.dgvcAttrDescrizione.Name = "dgvcAttrDescrizione"
        Me.dgvcAttrDescrizione.ReadOnly = True
        '
        'dgvcAttrLarghezza
        '
        Me.dgvcAttrLarghezza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAttrLarghezza.DataPropertyName = "Larghezza"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvcAttrLarghezza.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcAttrLarghezza.HeaderText = "Larghezza (mm)"
        Me.dgvcAttrLarghezza.MinimumWidth = 6
        Me.dgvcAttrLarghezza.Name = "dgvcAttrLarghezza"
        Me.dgvcAttrLarghezza.Width = 120
        '
        'dgvcAttrAltezza
        '
        Me.dgvcAttrAltezza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAttrAltezza.DataPropertyName = "Altezza"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.dgvcAttrAltezza.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcAttrAltezza.HeaderText = "Altezza (mm)"
        Me.dgvcAttrAltezza.MinimumWidth = 6
        Me.dgvcAttrAltezza.Name = "dgvcAttrAltezza"
        Me.dgvcAttrAltezza.Width = 110
        '
        'dlgAttivita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1471, 631)
        Me.Controls.Add(Me.dgvAttrezzature)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPrevQta)
        Me.Controls.Add(Me.txtConsQta)
        Me.Controls.Add(Me.txtPrevAnno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConsAnno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cdiData)
        Me.Controls.Add(Me.txtCodAteco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "dlgAttivita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attività socio"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAttrezzature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAttrezzature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents lAzienda As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodAteco As System.Windows.Forms.TextBox
    Friend WithEvents cdiData As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConsAnno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPrevAnno As System.Windows.Forms.TextBox
    Friend WithEvents txtConsQta As System.Windows.Forms.TextBox
    Friend WithEvents txtPrevQta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvAttrezzature As System.Windows.Forms.DataGridView
    Friend WithEvents bsAttrezzature As System.Windows.Forms.BindingSource
    Friend WithEvents dgvcAttSel As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents dgvcAttrDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAttrLarghezza As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAttrAltezza As DataGridViewTextBoxColumn
End Class
