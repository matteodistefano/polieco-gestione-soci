<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEventoAzienda
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
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.txtDataRichiesta = New mdsUIControls.mdsDate()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtScadenza = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkUrgente = New System.Windows.Forms.CheckBox()
        Me.txtDataNotifica = New mdsUIControls.mdsDate()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ucArxivar = New ArxivarWCFWrapper.ucProtocolloArxivar()
        Me.chkChiuso = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbRuoloNotifica = New System.Windows.Forms.ComboBox()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 498)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(804, 37)
        Me.tsMain.TabIndex = 10
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
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo"
        '
        'lAzienda
        '
        Me.lAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(75, 9)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(678, 32)
        Me.lAzienda.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Data "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Note", True))
        Me.txtNote.Location = New System.Drawing.Point(75, 328)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(717, 133)
        Me.txtNote.TabIndex = 12
        '
        'lLogo
        '
        Me.lLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Lightning_1_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(759, 9)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(32, 32)
        Me.lLogo.TabIndex = 1
        '
        'txtDataRichiesta
        '
        Me.txtDataRichiesta.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "Data", True))
        Me.txtDataRichiesta.DateFormat = Nothing
        Me.txtDataRichiesta.DateValue = Nothing
        Me.txtDataRichiesta.IsReadOnly = False
        Me.txtDataRichiesta.Location = New System.Drawing.Point(75, 83)
        Me.txtDataRichiesta.Name = "txtDataRichiesta"
        Me.txtDataRichiesta.SetNullDateToDbNull = False
        Me.txtDataRichiesta.Size = New System.Drawing.Size(100, 20)
        Me.txtDataRichiesta.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Causale", True))
        Me.TextBox1.Location = New System.Drawing.Point(74, 145)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(717, 78)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Motivazione"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Utente"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Incaricato", True))
        Me.TextBox2.Location = New System.Drawing.Point(74, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(717, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Incaricato"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Valore", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox3.Location = New System.Drawing.Point(75, 466)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Importo"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DescrTipo", True))
        Me.Label9.Location = New System.Drawing.Point(75, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 18)
        Me.Label9.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DescrUtente", True))
        Me.Label10.Location = New System.Drawing.Point(499, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(293, 18)
        Me.Label10.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Scadenza"
        '
        'txtScadenza
        '
        Me.txtScadenza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScadenza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Scadenza", True))
        Me.txtScadenza.Location = New System.Drawing.Point(74, 254)
        Me.txtScadenza.Multiline = True
        Me.txtScadenza.Name = "txtScadenza"
        Me.txtScadenza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScadenza.Size = New System.Drawing.Size(717, 68)
        Me.txtScadenza.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(555, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Rif. Arxivar"
        '
        'chkUrgente
        '
        Me.chkUrgente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "IsUrgente", True))
        Me.chkUrgente.Image = Global.PoliecoSoci.My.Resources.Resources.Alert_or_Warning_2_16_n_g
        Me.chkUrgente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkUrgente.Location = New System.Drawing.Point(190, 78)
        Me.chkUrgente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkUrgente.Name = "chkUrgente"
        Me.chkUrgente.Size = New System.Drawing.Size(83, 32)
        Me.chkUrgente.TabIndex = 5
        Me.chkUrgente.Text = "      Urgente"
        Me.chkUrgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUrgente.UseVisualStyleBackColor = True
        '
        'txtDataNotifica
        '
        Me.txtDataNotifica.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataAvviso", True))
        Me.txtDataNotifica.DateFormat = Nothing
        Me.txtDataNotifica.DateValue = Nothing
        Me.txtDataNotifica.IsReadOnly = False
        Me.txtDataNotifica.Location = New System.Drawing.Point(499, 80)
        Me.txtDataNotifica.Name = "txtDataNotifica"
        Me.txtDataNotifica.SetNullDateToDbNull = False
        Me.txtDataNotifica.Size = New System.Drawing.Size(100, 20)
        Me.txtDataNotifica.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(416, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Notifica evento"
        '
        'ucArxivar
        '
        Me.ucArxivar.AllowProfile = True
        Me.ucArxivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucArxivar.BackColorTxt = System.Drawing.SystemColors.Window
        Me.ucArxivar.DataBindings.Add(New System.Windows.Forms.Binding("Protocollo", Me.bsData, "RifArxivar", True))
        Me.ucArxivar.Location = New System.Drawing.Point(617, 469)
        Me.ucArxivar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucArxivar.Name = "ucArxivar"
        Me.ucArxivar.Protocollo = ""
        Me.ucArxivar.ProtocolPrefix = Nothing
        Me.ucArxivar.ReadOnly = False
        Me.ucArxivar.SearchDocumentMode = ArxivarWCFWrapper.ucProtocolloArxivar.SearchDocumentModeEnum.BY_DOC_NUMBER_AND_ID
        Me.ucArxivar.ShowContextMenu = False
        Me.ucArxivar.Size = New System.Drawing.Size(174, 20)
        Me.ucArxivar.TabIndex = 14
        '
        'chkChiuso
        '
        Me.chkChiuso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkChiuso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "IsChiuso", True))
        Me.chkChiuso.Image = Global.PoliecoSoci.My.Resources.Resources.Lightning_1_16_n_g
        Me.chkChiuso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkChiuso.Location = New System.Drawing.Point(617, 74)
        Me.chkChiuso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkChiuso.Name = "chkChiuso"
        Me.chkChiuso.Size = New System.Drawing.Size(76, 32)
        Me.chkChiuso.TabIndex = 7
        Me.chkChiuso.Text = "      Chiuso"
        Me.chkChiuso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkChiuso.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(416, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Ruolo notifica"
        '
        'cbRuoloNotifica
        '
        Me.cbRuoloNotifica.FormattingEnabled = True
        Me.cbRuoloNotifica.Location = New System.Drawing.Point(499, 106)
        Me.cbRuoloNotifica.Name = "cbRuoloNotifica"
        Me.cbRuoloNotifica.Size = New System.Drawing.Size(293, 21)
        Me.cbRuoloNotifica.TabIndex = 8
        '
        'dlgEventoAzienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 535)
        Me.Controls.Add(Me.cbRuoloNotifica)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.chkChiuso)
        Me.Controls.Add(Me.txtDataNotifica)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkUrgente)
        Me.Controls.Add(Me.ucArxivar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtScadenza)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataRichiesta)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgEventoAzienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evento"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtDataRichiesta As mdsUIControls.mdsDate
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtScadenza As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ucArxivar As ArxivarWCFWrapper.ucProtocolloArxivar
    Friend WithEvents chkUrgente As CheckBox
    Friend WithEvents txtDataNotifica As mdsUIControls.mdsDate
    Friend WithEvents Label13 As Label
    Friend WithEvents chkChiuso As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbRuoloNotifica As ComboBox
End Class
