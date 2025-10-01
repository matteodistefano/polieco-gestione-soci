<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgContatto
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
        Me.cbRuolo = New System.Windows.Forms.ComboBox()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNominativo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUfficio = New System.Windows.Forms.TextBox()
        Me.txtCellulare = New mdsUIControls.ucTxtCall()
        Me.txtTelefono = New mdsUIControls.ucTxtCall()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.cbTitolo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
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
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 314)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(804, 37)
        Me.tsMain.TabIndex = 11
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Azienda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ruolo"
        '
        'lAzienda
        '
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(75, 9)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(678, 32)
        Me.lAzienda.TabIndex = 0
        '
        'cbRuolo
        '
        Me.cbRuolo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodRuolo", True))
        Me.cbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRuolo.FormattingEnabled = True
        Me.cbRuolo.Location = New System.Drawing.Point(75, 60)
        Me.cbRuolo.Name = "cbRuolo"
        Me.cbRuolo.Size = New System.Drawing.Size(216, 21)
        Me.cbRuolo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nominativo"
        '
        'txtNominativo
        '
        Me.txtNominativo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNominativo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Nominativo", True))
        Me.txtNominativo.Location = New System.Drawing.Point(75, 87)
        Me.txtNominativo.Name = "txtNominativo"
        Me.txtNominativo.Size = New System.Drawing.Size(717, 20)
        Me.txtNominativo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ufficio"
        '
        'txtUfficio
        '
        Me.txtUfficio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUfficio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Ufficio", True))
        Me.txtUfficio.Location = New System.Drawing.Point(75, 113)
        Me.txtUfficio.Name = "txtUfficio"
        Me.txtUfficio.Size = New System.Drawing.Size(717, 20)
        Me.txtUfficio.TabIndex = 3
        '
        'txtCellulare
        '
        Me.txtCellulare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Cellulare", True))
        Me.txtCellulare.Location = New System.Drawing.Point(368, 139)
        Me.txtCellulare.Name = "txtCellulare"
        Me.txtCellulare.Size = New System.Drawing.Size(216, 20)
        Me.txtCellulare.TabIndex = 8
        Me.txtCellulare.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Telefono
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(75, 139)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(216, 20)
        Me.txtTelefono.TabIndex = 7
        Me.txtTelefono.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Telefono
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 142)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Telefono"
        '
        'lLogo
        '
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Contact_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(759, 9)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(32, 32)
        Me.lLogo.TabIndex = 53
        '
        'cbTitolo
        '
        Me.cbTitolo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodTitolo", True))
        Me.cbTitolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitolo.FormattingEnabled = True
        Me.cbTitolo.Location = New System.Drawing.Point(368, 60)
        Me.cbTitolo.Name = "cbTitolo"
        Me.cbTitolo.Size = New System.Drawing.Size(186, 21)
        Me.cbTitolo.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Titolo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Cellulare"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Note", True))
        Me.txtNote.Location = New System.Drawing.Point(75, 191)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(717, 111)
        Me.txtNote.TabIndex = 10
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Email", True))
        Me.txtMail.Location = New System.Drawing.Point(74, 165)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(717, 20)
        Me.txtMail.TabIndex = 9
        Me.txtMail.TipoDato = mdsUIControls.ucTxtCall.TipoEnum.Mail
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 13)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Email"
        '
        'dlgContatto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 351)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbTitolo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.txtCellulare)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtUfficio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNominativo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbRuolo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgContatto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contatto"
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
    Friend WithEvents cbRuolo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNominativo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUfficio As System.Windows.Forms.TextBox
    Friend WithEvents txtCellulare As mdsUIControls.ucTxtCall
    Friend WithEvents txtTelefono As mdsUIControls.ucTxtCall
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents cbTitolo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As mdsUIControls.ucTxtCall
    Friend WithEvents Label33 As System.Windows.Forms.Label
End Class
