<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSede
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIndirizzo = New System.Windows.Forms.TextBox()
        Me.txtLocalita = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.txtFax = New mdsUIControls.ucTxtCall()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtTelefono2 = New mdsUIControls.ucTxtCall()
        Me.txtTelefono1 = New mdsUIControls.ucTxtCall()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkUsaIndirizzo = New System.Windows.Forms.CheckBox()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.txtMail = New mdsUIControls.ucTxtCall()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 425)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1474, 69)
        Me.tsMain.TabIndex = 11
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
        Me.cbTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodTipoSede", True))
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(138, 111)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(209, 32)
        Me.cbTipo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 166)
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
        Me.txtDescrizione.Location = New System.Drawing.Point(138, 160)
        Me.txtDescrizione.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(1312, 32)
        Me.txtDescrizione.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Indirizzo"
        '
        'txtIndirizzo
        '
        Me.txtIndirizzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIndirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Indirizzo", True))
        Me.txtIndirizzo.Location = New System.Drawing.Point(138, 208)
        Me.txtIndirizzo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtIndirizzo.Name = "txtIndirizzo"
        Me.txtIndirizzo.Size = New System.Drawing.Size(1312, 32)
        Me.txtIndirizzo.TabIndex = 3
        '
        'txtLocalita
        '
        Me.txtLocalita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalita.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Localita", True))
        Me.txtLocalita.Location = New System.Drawing.Point(138, 256)
        Me.txtLocalita.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtLocalita.Name = "txtLocalita"
        Me.txtLocalita.Size = New System.Drawing.Size(817, 32)
        Me.txtLocalita.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 262)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 24)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Località"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1220, 262)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 24)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Provincia"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1001, 262)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 24)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "CAP"
        '
        'txtCap
        '
        Me.txtCap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Cap", True))
        Me.txtCap.Location = New System.Drawing.Point(1063, 256)
        Me.txtCap.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCap.Name = "txtCap"
        Me.txtCap.Size = New System.Drawing.Size(142, 32)
        Me.txtCap.TabIndex = 5
        '
        'cbProv
        '
        Me.cbProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProv.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "Provincia", True))
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Location = New System.Drawing.Point(1324, 256)
        Me.cbProv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(124, 32)
        Me.cbProv.TabIndex = 6
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Fax", True))
        Me.txtFax.Location = New System.Drawing.Point(1063, 306)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(384, 32)
        Me.txtFax.TabIndex = 9
        Me.txtFax.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Fax
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(1008, 310)
        Me.Label34.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 24)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "Fax"
        '
        'txtTelefono2
        '
        Me.txtTelefono2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Telefono2", True))
        Me.txtTelefono2.Location = New System.Drawing.Point(561, 304)
        Me.txtTelefono2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(393, 32)
        Me.txtTelefono2.TabIndex = 8
        Me.txtTelefono2.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Telefono
        '
        'txtTelefono1
        '
        Me.txtTelefono1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Telefono1", True))
        Me.txtTelefono1.Location = New System.Drawing.Point(138, 304)
        Me.txtTelefono1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(393, 32)
        Me.txtTelefono1.TabIndex = 7
        Me.txtTelefono1.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Telefono
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(11, 310)
        Me.Label32.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 24)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Telefono"
        '
        'chkUsaIndirizzo
        '
        Me.chkUsaIndirizzo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUsaIndirizzo.AutoSize = True
        Me.chkUsaIndirizzo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUsaIndirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "UsatoperSpedizione", True))
        Me.chkUsaIndirizzo.Location = New System.Drawing.Point(1113, 114)
        Me.chkUsaIndirizzo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkUsaIndirizzo.Name = "chkUsaIndirizzo"
        Me.chkUsaIndirizzo.Size = New System.Drawing.Size(338, 28)
        Me.chkUsaIndirizzo.TabIndex = 1
        Me.chkUsaIndirizzo.Text = "Indirizzo usato per corrispondenza"
        Me.chkUsaIndirizzo.UseVisualStyleBackColor = True
        '
        'lLogo
        '
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Office_Block_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(1392, 16)
        Me.lLogo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(59, 58)
        Me.lLogo.TabIndex = 54
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Email", True))
        Me.txtMail.Location = New System.Drawing.Point(138, 352)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(1309, 32)
        Me.txtMail.TabIndex = 10
        Me.txtMail.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Mail
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(11, 358)
        Me.Label33.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 24)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Email"
        '
        'dlgSede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 494)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.chkUsaIndirizzo)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtTelefono2)
        Me.Controls.Add(Me.txtTelefono1)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCap)
        Me.Controls.Add(Me.cbProv)
        Me.Controls.Add(Me.txtLocalita)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIndirizzo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgSede"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sede socio"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIndirizzo As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalita As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCap As System.Windows.Forms.TextBox
    Friend WithEvents cbProv As System.Windows.Forms.ComboBox
    Friend WithEvents txtFax As mdsUIControls.ucTxtCall
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As mdsUIControls.ucTxtCall
    Friend WithEvents txtTelefono1 As mdsUIControls.ucTxtCall
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents chkUsaIndirizzo As System.Windows.Forms.CheckBox
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents txtMail As mdsUIControls.ucTxtCall
    Friend WithEvents Label33 As System.Windows.Forms.Label
End Class
