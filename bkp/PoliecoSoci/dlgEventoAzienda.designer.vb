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
        Me.tsMain.Location = New System.Drawing.Point(0, 481)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1072, 46)
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
        Me.tsbExit.Size = New System.Drawing.Size(91, 43)
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
        Me.tsbOk.Size = New System.Drawing.Size(59, 43)
        Me.tsbOk.Text = "Ok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Azienda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo"
        '
        'lAzienda
        '
        Me.lAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(100, 11)
        Me.lAzienda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(904, 39)
        Me.lAzienda.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Data "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 347)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Note", True))
        Me.txtNote.Location = New System.Drawing.Point(100, 345)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(955, 90)
        Me.txtNote.TabIndex = 7
        '
        'lLogo
        '
        Me.lLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Lightning_1_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(1012, 11)
        Me.lLogo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(43, 39)
        Me.lLogo.TabIndex = 53
        '
        'txtDataRichiesta
        '
        Me.txtDataRichiesta.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "Data", True))
        Me.txtDataRichiesta.DateFormat = Nothing
        Me.txtDataRichiesta.DateValue = Nothing
        Me.txtDataRichiesta.IsReadOnly = False
        Me.txtDataRichiesta.Location = New System.Drawing.Point(100, 102)
        Me.txtDataRichiesta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataRichiesta.Name = "txtDataRichiesta"
        Me.txtDataRichiesta.SetNullDateToDbNull = False
        Me.txtDataRichiesta.Size = New System.Drawing.Size(132, 22)
        Me.txtDataRichiesta.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Causale", True))
        Me.TextBox1.Location = New System.Drawing.Point(100, 132)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(955, 83)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Motivazione"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Utente"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Incaricato", True))
        Me.TextBox2.Location = New System.Drawing.Point(100, 223)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(955, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Incaricato"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Valore", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox3.Location = New System.Drawing.Point(100, 442)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 442)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Importo"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DescrTipo", True))
        Me.Label9.Location = New System.Drawing.Point(100, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(442, 22)
        Me.Label9.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DescrUtente", True))
        Me.Label10.Location = New System.Drawing.Point(665, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(390, 22)
        Me.Label10.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 263)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Scadenza"
        '
        'txtScadenza
        '
        Me.txtScadenza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScadenza.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Scadenza", True))
        Me.txtScadenza.Location = New System.Drawing.Point(100, 254)
        Me.txtScadenza.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScadenza.Multiline = True
        Me.txtScadenza.Name = "txtScadenza"
        Me.txtScadenza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScadenza.Size = New System.Drawing.Size(955, 83)
        Me.txtScadenza.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(740, 448)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 17)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Rif. Arxivar"
        '
        'chkUrgente
        '
        Me.chkUrgente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "IsUrgente", True))
        Me.chkUrgente.Image = Global.PoliecoSoci.My.Resources.Resources.Alert_or_Warning_2_16_n_g
        Me.chkUrgente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkUrgente.Location = New System.Drawing.Point(264, 99)
        Me.chkUrgente.Name = "chkUrgente"
        Me.chkUrgente.Size = New System.Drawing.Size(107, 27)
        Me.chkUrgente.TabIndex = 1
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
        Me.txtDataNotifica.Location = New System.Drawing.Point(665, 99)
        Me.txtDataNotifica.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataNotifica.Name = "txtDataNotifica"
        Me.txtDataNotifica.SetNullDateToDbNull = False
        Me.txtDataNotifica.Size = New System.Drawing.Size(132, 22)
        Me.txtDataNotifica.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(555, 102)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 17)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Notifica evento"
        '
        'ucArxivar
        '
        Me.ucArxivar.AllowProfile = True
        Me.ucArxivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucArxivar.BackColorTxt = System.Drawing.SystemColors.Window
        Me.ucArxivar.DataBindings.Add(New System.Windows.Forms.Binding("Protocollo", Me.bsData, "RifArxivar", True))
        Me.ucArxivar.Location = New System.Drawing.Point(823, 445)
        Me.ucArxivar.Name = "ucArxivar"
        Me.ucArxivar.Protocollo = ""
        Me.ucArxivar.ProtocolPrefix = Nothing
        Me.ucArxivar.ReadOnly = False
        Me.ucArxivar.SearchDocumentMode = ArxivarWCFWrapper.ucProtocolloArxivar.SearchDocumentModeEnum.BY_DOC_NUMBER_AND_ID
        Me.ucArxivar.ShowContextMenu = False
        Me.ucArxivar.Size = New System.Drawing.Size(232, 20)
        Me.ucArxivar.TabIndex = 9
        '
        'chkChiuso
        '
        Me.chkChiuso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkChiuso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "IsChiuso", True))
        Me.chkChiuso.Image = Global.PoliecoSoci.My.Resources.Resources.Lightning_1_16_n_g
        Me.chkChiuso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkChiuso.Location = New System.Drawing.Point(804, 99)
        Me.chkChiuso.Name = "chkChiuso"
        Me.chkChiuso.Size = New System.Drawing.Size(101, 27)
        Me.chkChiuso.TabIndex = 3
        Me.chkChiuso.Text = "      Chiuso"
        Me.chkChiuso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkChiuso.UseVisualStyleBackColor = True
        '
        'dlgEventoAzienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 527)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class
