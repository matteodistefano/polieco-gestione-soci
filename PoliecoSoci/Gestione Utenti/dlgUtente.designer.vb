<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUtente
    Inherits Form

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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataRegistrazioneLabel As System.Windows.Forms.Label
        Dim DataRilascioPasswordLabel As System.Windows.Forms.Label
        Dim DataUltimoAccessoLabel As System.Windows.Forms.Label
        Dim CellulareLabel As System.Windows.Forms.Label
        Dim NumAccessiLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim TmpPwdLabel As System.Windows.Forms.Label
        Dim AttivoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.tsUtenti = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.txtArxPwd = New System.Windows.Forms.TextBox()
        Me.bsUtente = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtArxUserId = New System.Windows.Forms.TextBox()
        Me.lstRuoli = New System.Windows.Forms.CheckedListBox()
        Me.btnResetPwd = New System.Windows.Forms.Button()
        Me.lPwd = New System.Windows.Forms.Label()
        Me.AttivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NumAccessiTextBox = New System.Windows.Forms.TextBox()
        Me.CellulareTextBox = New System.Windows.Forms.TextBox()
        Me.DataUltimoAccessoTextBox = New System.Windows.Forms.TextBox()
        Me.DataRilascioPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.DataRegistrazioneTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        DataRegistrazioneLabel = New System.Windows.Forms.Label()
        DataRilascioPasswordLabel = New System.Windows.Forms.Label()
        DataUltimoAccessoLabel = New System.Windows.Forms.Label()
        CellulareLabel = New System.Windows.Forms.Label()
        NumAccessiLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        TmpPwdLabel = New System.Windows.Forms.Label()
        AttivoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.tsUtenti.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.bsUtente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(43, 30)
        NomeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(69, 24)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Nome:"
        '
        'DataRegistrazioneLabel
        '
        DataRegistrazioneLabel.AutoSize = True
        DataRegistrazioneLabel.Location = New System.Drawing.Point(6, 517)
        DataRegistrazioneLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DataRegistrazioneLabel.Name = "DataRegistrazioneLabel"
        DataRegistrazioneLabel.Size = New System.Drawing.Size(137, 24)
        DataRegistrazioneLabel.TabIndex = 2
        DataRegistrazioneLabel.Text = "Registrazione:"
        '
        'DataRilascioPasswordLabel
        '
        DataRilascioPasswordLabel.AutoSize = True
        DataRilascioPasswordLabel.Location = New System.Drawing.Point(552, 514)
        DataRilascioPasswordLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DataRilascioPasswordLabel.Name = "DataRilascioPasswordLabel"
        DataRilascioPasswordLabel.Size = New System.Drawing.Size(138, 24)
        DataRilascioPasswordLabel.TabIndex = 4
        DataRilascioPasswordLabel.Text = "Rilascio Pass.:"
        '
        'DataUltimoAccessoLabel
        '
        DataUltimoAccessoLabel.AutoSize = True
        DataUltimoAccessoLabel.Location = New System.Drawing.Point(6, 560)
        DataUltimoAccessoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        DataUltimoAccessoLabel.Name = "DataUltimoAccessoLabel"
        DataUltimoAccessoLabel.Size = New System.Drawing.Size(115, 24)
        DataUltimoAccessoLabel.TabIndex = 6
        DataUltimoAccessoLabel.Text = "Ultimo acc.:"
        '
        'CellulareLabel
        '
        CellulareLabel.AutoSize = True
        CellulareLabel.Location = New System.Drawing.Point(586, 129)
        CellulareLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CellulareLabel.Name = "CellulareLabel"
        CellulareLabel.Size = New System.Drawing.Size(94, 24)
        CellulareLabel.TabIndex = 8
        CellulareLabel.Text = "Cellulare:"
        CellulareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumAccessiLabel
        '
        NumAccessiLabel.AutoSize = True
        NumAccessiLabel.Location = New System.Drawing.Point(552, 564)
        NumAccessiLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NumAccessiLabel.Name = "NumAccessiLabel"
        NumAccessiLabel.Size = New System.Drawing.Size(132, 24)
        NumAccessiLabel.TabIndex = 10
        NumAccessiLabel.Text = "Num Accessi:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(43, 78)
        EmailLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(65, 24)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(43, 129)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(93, 24)
        TelefonoLabel.TabIndex = 14
        TelefonoLabel.Text = "Telefono:"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(43, 174)
        UserIdLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(77, 24)
        UserIdLabel.TabIndex = 16
        UserIdLabel.Text = "User Id:"
        '
        'TmpPwdLabel
        '
        TmpPwdLabel.AutoSize = True
        TmpPwdLabel.Location = New System.Drawing.Point(43, 222)
        TmpPwdLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        TmpPwdLabel.Name = "TmpPwdLabel"
        TmpPwdLabel.Size = New System.Drawing.Size(103, 24)
        TmpPwdLabel.TabIndex = 18
        TmpPwdLabel.Text = "Password:"
        '
        'AttivoLabel
        '
        AttivoLabel.Location = New System.Drawing.Point(589, 272)
        AttivoLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        AttivoLabel.Name = "AttivoLabel"
        AttivoLabel.Size = New System.Drawing.Size(89, 36)
        AttivoLabel.TabIndex = 7
        AttivoLabel.Text = "Attivo:"
        AttivoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(43, 278)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 24)
        Label1.TabIndex = 25
        Label1.Text = "Ruoli:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(559, 177)
        Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(122, 24)
        Label2.TabIndex = 27
        Label2.Text = "Arxivar user:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(563, 225)
        Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 24)
        Label3.TabIndex = 29
        Label3.Text = "Arxivar pwd:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsUtenti
        '
        Me.tsUtenti.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsUtenti.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsUtenti.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsUtenti.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsUtenti.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk, Me.tsbStampa})
        Me.tsUtenti.Location = New System.Drawing.Point(0, 666)
        Me.tsUtenti.Name = "tsUtenti"
        Me.tsUtenti.Size = New System.Drawing.Size(1244, 45)
        Me.tsUtenti.TabIndex = 0
        Me.tsUtenti.Text = "ToolStrip1"
        '
        'tsbAnnulla
        '
        Me.tsbAnnulla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnnulla.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_32_n_g
        Me.tsbAnnulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnnulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnnulla.Name = "tsbAnnulla"
        Me.tsbAnnulla.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbAnnulla.Size = New System.Drawing.Size(119, 42)
        Me.tsbAnnulla.Text = "&Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_32_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbOk.Size = New System.Drawing.Size(76, 42)
        Me.tsbOk.Text = "&Ok"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "&Stampa"
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.txtArxPwd)
        Me.pnlEdit.Controls.Add(Label3)
        Me.pnlEdit.Controls.Add(Me.txtArxUserId)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(Me.lstRuoli)
        Me.pnlEdit.Controls.Add(Label1)
        Me.pnlEdit.Controls.Add(Me.btnResetPwd)
        Me.pnlEdit.Controls.Add(Me.lPwd)
        Me.pnlEdit.Controls.Add(Me.AttivoCheckBox)
        Me.pnlEdit.Controls.Add(TmpPwdLabel)
        Me.pnlEdit.Controls.Add(Me.txtPwd)
        Me.pnlEdit.Controls.Add(UserIdLabel)
        Me.pnlEdit.Controls.Add(Me.txtUserId)
        Me.pnlEdit.Controls.Add(TelefonoLabel)
        Me.pnlEdit.Controls.Add(Me.TelefonoTextBox)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Controls.Add(Me.EmailTextBox)
        Me.pnlEdit.Controls.Add(NumAccessiLabel)
        Me.pnlEdit.Controls.Add(Me.NumAccessiTextBox)
        Me.pnlEdit.Controls.Add(CellulareLabel)
        Me.pnlEdit.Controls.Add(Me.CellulareTextBox)
        Me.pnlEdit.Controls.Add(DataUltimoAccessoLabel)
        Me.pnlEdit.Controls.Add(Me.DataUltimoAccessoTextBox)
        Me.pnlEdit.Controls.Add(DataRilascioPasswordLabel)
        Me.pnlEdit.Controls.Add(Me.DataRilascioPasswordTextBox)
        Me.pnlEdit.Controls.Add(DataRegistrazioneLabel)
        Me.pnlEdit.Controls.Add(Me.DataRegistrazioneTextBox)
        Me.pnlEdit.Controls.Add(NomeLabel)
        Me.pnlEdit.Controls.Add(Me.NomeTextBox)
        Me.pnlEdit.Controls.Add(AttivoLabel)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(1244, 666)
        Me.pnlEdit.TabIndex = 6
        '
        'txtArxPwd
        '
        Me.txtArxPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtArxPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "ArxivarPassword", True))
        Me.txtArxPwd.Location = New System.Drawing.Point(689, 219)
        Me.txtArxPwd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtArxPwd.Name = "txtArxPwd"
        Me.txtArxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtArxPwd.Size = New System.Drawing.Size(296, 32)
        Me.txtArxPwd.TabIndex = 7
        '
        'bsUtente
        '
        Me.bsUtente.DataSource = GetType(DAL.EntityClasses.UtenteEntity)
        '
        'txtArxUserId
        '
        Me.txtArxUserId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtArxUserId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "ArxivarUserId", True))
        Me.txtArxUserId.Location = New System.Drawing.Point(689, 171)
        Me.txtArxUserId.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtArxUserId.Name = "txtArxUserId"
        Me.txtArxUserId.Size = New System.Drawing.Size(296, 32)
        Me.txtArxUserId.TabIndex = 6
        '
        'lstRuoli
        '
        Me.lstRuoli.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstRuoli.CheckOnClick = True
        Me.lstRuoli.FormattingEnabled = True
        Me.lstRuoli.Location = New System.Drawing.Point(177, 272)
        Me.lstRuoli.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstRuoli.Name = "lstRuoli"
        Me.lstRuoli.Size = New System.Drawing.Size(355, 208)
        Me.lstRuoli.TabIndex = 8
        '
        'btnResetPwd
        '
        Me.btnResetPwd.Image = Global.PoliecoSoci.My.Resources.Resources.Document_Settings_32_h_g
        Me.btnResetPwd.Location = New System.Drawing.Point(474, 216)
        Me.btnResetPwd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnResetPwd.Name = "btnResetPwd"
        Me.btnResetPwd.Size = New System.Drawing.Size(59, 42)
        Me.btnResetPwd.TabIndex = 9
        Me.btnResetPwd.UseVisualStyleBackColor = True
        '
        'lPwd
        '
        Me.lPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lPwd.Location = New System.Drawing.Point(474, 170)
        Me.lPwd.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lPwd.Name = "lPwd"
        Me.lPwd.Size = New System.Drawing.Size(57, 35)
        Me.lPwd.TabIndex = 24
        Me.lPwd.Text = "XXXXXXXXXX"
        Me.lPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttivoCheckBox
        '
        Me.AttivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsUtente, "IsAttivo", True))
        Me.AttivoCheckBox.Location = New System.Drawing.Point(689, 269)
        Me.AttivoCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AttivoCheckBox.Name = "AttivoCheckBox"
        Me.AttivoCheckBox.Size = New System.Drawing.Size(40, 45)
        Me.AttivoCheckBox.TabIndex = 9
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "PasswordProvvisoria", True))
        Me.txtPwd.Location = New System.Drawing.Point(177, 219)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(283, 32)
        Me.txtPwd.TabIndex = 5
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUserId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "UserName", True))
        Me.txtUserId.Location = New System.Drawing.Point(177, 171)
        Me.txtUserId.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(283, 32)
        Me.txtUserId.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(177, 123)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(352, 32)
        Me.TelefonoTextBox.TabIndex = 2
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(177, 75)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(1012, 32)
        Me.EmailTextBox.TabIndex = 1
        '
        'NumAccessiTextBox
        '
        Me.NumAccessiTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumAccessiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "NumeroAccessi", True))
        Me.NumAccessiTextBox.Location = New System.Drawing.Point(697, 558)
        Me.NumAccessiTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NumAccessiTextBox.Name = "NumAccessiTextBox"
        Me.NumAccessiTextBox.Size = New System.Drawing.Size(264, 32)
        Me.NumAccessiTextBox.TabIndex = 11
        '
        'CellulareTextBox
        '
        Me.CellulareTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CellulareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "Cellulare", True))
        Me.CellulareTextBox.Location = New System.Drawing.Point(689, 123)
        Me.CellulareTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CellulareTextBox.Name = "CellulareTextBox"
        Me.CellulareTextBox.Size = New System.Drawing.Size(499, 32)
        Me.CellulareTextBox.TabIndex = 3
        '
        'DataUltimoAccessoTextBox
        '
        Me.DataUltimoAccessoTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataUltimoAccessoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "DataAccesso", True))
        Me.DataUltimoAccessoTextBox.Location = New System.Drawing.Point(177, 560)
        Me.DataUltimoAccessoTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataUltimoAccessoTextBox.Name = "DataUltimoAccessoTextBox"
        Me.DataUltimoAccessoTextBox.Size = New System.Drawing.Size(352, 32)
        Me.DataUltimoAccessoTextBox.TabIndex = 9
        '
        'DataRilascioPasswordTextBox
        '
        Me.DataRilascioPasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataRilascioPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "DataRilascioPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "F"))
        Me.DataRilascioPasswordTextBox.Location = New System.Drawing.Point(697, 509)
        Me.DataRilascioPasswordTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataRilascioPasswordTextBox.Name = "DataRilascioPasswordTextBox"
        Me.DataRilascioPasswordTextBox.Size = New System.Drawing.Size(492, 32)
        Me.DataRilascioPasswordTextBox.TabIndex = 10
        '
        'DataRegistrazioneTextBox
        '
        Me.DataRegistrazioneTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataRegistrazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "DataRegistrazione", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "F"))
        Me.DataRegistrazioneTextBox.Location = New System.Drawing.Point(177, 509)
        Me.DataRegistrazioneTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataRegistrazioneTextBox.Name = "DataRegistrazioneTextBox"
        Me.DataRegistrazioneTextBox.Size = New System.Drawing.Size(352, 32)
        Me.DataRegistrazioneTextBox.TabIndex = 8
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUtente, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(177, 27)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(1012, 32)
        Me.NomeTextBox.TabIndex = 0
        '
        'dlgUtente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 711)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsUtenti)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgUtente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anagrafica utente"
        Me.tsUtenti.ResumeLayout(False)
        Me.tsUtenti.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.bsUtente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsUtenti As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents bsUtente As System.Windows.Forms.BindingSource
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumAccessiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CellulareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataUltimoAccessoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataRilascioPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataRegistrazioneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AttivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents lPwd As System.Windows.Forms.Label
    Friend WithEvents btnResetPwd As System.Windows.Forms.Button
    Friend WithEvents lstRuoli As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtArxPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtArxUserId As System.Windows.Forms.TextBox
End Class
