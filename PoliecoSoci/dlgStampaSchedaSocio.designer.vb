<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStampaSchedaSocio
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
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.lLogo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSottotitolo = New System.Windows.Forms.TextBox()
        Me.chkRecapiti = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSedi = New System.Windows.Forms.CheckBox()
        Me.chkContatti = New System.Windows.Forms.CheckBox()
        Me.chkDichiarazioni = New System.Windows.Forms.CheckBox()
        Me.chkEventi = New System.Windows.Forms.CheckBox()
        Me.chkAttivita = New System.Windows.Forms.CheckBox()
        Me.chkLicenze = New System.Windows.Forms.CheckBox()
        Me.chkProdotti = New System.Windows.Forms.CheckBox()
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 259)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(494, 37)
        Me.tsMain.TabIndex = 10
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.SE_Arrow_24_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(74, 34)
        Me.tsbExit.Text = "Chiudi"
        '
        'tsbOk
        '
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_24_n_g1
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(95, 34)
        Me.tsbOk.Text = "Anteprima"
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
        'lAzienda
        '
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(75, 9)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(371, 32)
        Me.lAzienda.TabIndex = 0
        '
        'lLogo
        '
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Contact_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(452, 10)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(32, 32)
        Me.lLogo.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Sottotitolo"
        '
        'txtSottotitolo
        '
        Me.txtSottotitolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSottotitolo.Location = New System.Drawing.Point(75, 44)
        Me.txtSottotitolo.Multiline = True
        Me.txtSottotitolo.Name = "txtSottotitolo"
        Me.txtSottotitolo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSottotitolo.Size = New System.Drawing.Size(410, 77)
        Me.txtSottotitolo.TabIndex = 58
        '
        'chkRecapiti
        '
        Me.chkRecapiti.AutoSize = True
        Me.chkRecapiti.Checked = True
        Me.chkRecapiti.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecapiti.Location = New System.Drawing.Point(75, 132)
        Me.chkRecapiti.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkRecapiti.Name = "chkRecapiti"
        Me.chkRecapiti.Size = New System.Drawing.Size(121, 17)
        Me.chkRecapiti.TabIndex = 59
        Me.chkRecapiti.Text = "Recapiti && riferimenti"
        Me.chkRecapiti.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Aree"
        '
        'chkSedi
        '
        Me.chkSedi.AutoSize = True
        Me.chkSedi.Checked = True
        Me.chkSedi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSedi.Location = New System.Drawing.Point(75, 154)
        Me.chkSedi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSedi.Name = "chkSedi"
        Me.chkSedi.Size = New System.Drawing.Size(94, 17)
        Me.chkSedi.TabIndex = 61
        Me.chkSedi.Text = "Sedi operative"
        Me.chkSedi.UseVisualStyleBackColor = True
        '
        'chkContatti
        '
        Me.chkContatti.AutoSize = True
        Me.chkContatti.Checked = True
        Me.chkContatti.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkContatti.Location = New System.Drawing.Point(75, 176)
        Me.chkContatti.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkContatti.Name = "chkContatti"
        Me.chkContatti.Size = New System.Drawing.Size(62, 17)
        Me.chkContatti.TabIndex = 62
        Me.chkContatti.Text = "Contatti"
        Me.chkContatti.UseVisualStyleBackColor = True
        '
        'chkDichiarazioni
        '
        Me.chkDichiarazioni.AutoSize = True
        Me.chkDichiarazioni.Checked = True
        Me.chkDichiarazioni.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDichiarazioni.Location = New System.Drawing.Point(283, 176)
        Me.chkDichiarazioni.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDichiarazioni.Name = "chkDichiarazioni"
        Me.chkDichiarazioni.Size = New System.Drawing.Size(130, 17)
        Me.chkDichiarazioni.TabIndex = 63
        Me.chkDichiarazioni.Text = "Dichiarazioni && incassi"
        Me.chkDichiarazioni.UseVisualStyleBackColor = True
        '
        'chkEventi
        '
        Me.chkEventi.AutoSize = True
        Me.chkEventi.Location = New System.Drawing.Point(283, 198)
        Me.chkEventi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkEventi.Name = "chkEventi"
        Me.chkEventi.Size = New System.Drawing.Size(56, 17)
        Me.chkEventi.TabIndex = 64
        Me.chkEventi.Text = "Eventi"
        Me.chkEventi.UseVisualStyleBackColor = True
        '
        'chkAttivita
        '
        Me.chkAttivita.AutoSize = True
        Me.chkAttivita.Enabled = False
        Me.chkAttivita.Location = New System.Drawing.Point(75, 198)
        Me.chkAttivita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAttivita.Name = "chkAttivita"
        Me.chkAttivita.Size = New System.Drawing.Size(58, 17)
        Me.chkAttivita.TabIndex = 65
        Me.chkAttivita.Text = "Attività"
        Me.chkAttivita.UseVisualStyleBackColor = True
        '
        'chkLicenze
        '
        Me.chkLicenze.AutoSize = True
        Me.chkLicenze.Enabled = False
        Me.chkLicenze.Location = New System.Drawing.Point(283, 132)
        Me.chkLicenze.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkLicenze.Name = "chkLicenze"
        Me.chkLicenze.Size = New System.Drawing.Size(63, 17)
        Me.chkLicenze.TabIndex = 66
        Me.chkLicenze.Text = "Licenze"
        Me.chkLicenze.UseVisualStyleBackColor = True
        '
        'chkProdotti
        '
        Me.chkProdotti.AutoSize = True
        Me.chkProdotti.Enabled = False
        Me.chkProdotti.Location = New System.Drawing.Point(283, 154)
        Me.chkProdotti.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkProdotti.Name = "chkProdotti"
        Me.chkProdotti.Size = New System.Drawing.Size(62, 17)
        Me.chkProdotti.TabIndex = 67
        Me.chkProdotti.Text = "Prodotti"
        Me.chkProdotti.UseVisualStyleBackColor = True
        '
        'dlgStampaSchedaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 296)
        Me.Controls.Add(Me.chkProdotti)
        Me.Controls.Add(Me.chkLicenze)
        Me.Controls.Add(Me.chkAttivita)
        Me.Controls.Add(Me.chkEventi)
        Me.Controls.Add(Me.chkDichiarazioni)
        Me.Controls.Add(Me.chkContatti)
        Me.Controls.Add(Me.chkSedi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkRecapiti)
        Me.Controls.Add(Me.txtSottotitolo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgStampaSchedaSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stampa scheda socio"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lAzienda As System.Windows.Forms.Label
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSottotitolo As System.Windows.Forms.TextBox
    Friend WithEvents chkRecapiti As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkSedi As CheckBox
    Friend WithEvents chkContatti As CheckBox
    Friend WithEvents chkDichiarazioni As CheckBox
    Friend WithEvents chkEventi As CheckBox
    Friend WithEvents chkAttivita As CheckBox
    Friend WithEvents chkLicenze As CheckBox
    Friend WithEvents chkProdotti As CheckBox
End Class
