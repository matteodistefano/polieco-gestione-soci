<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSelFiltroEvento
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.chkOnlyCurrUser = New System.Windows.Forms.CheckBox()
        Me.cdiNotifica = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.chkUrgente = New System.Windows.Forms.CheckBox()
        Me.ucSelEvento = New PoliecoSoci.ucEventSelector()
        Me.txtMotivazione = New System.Windows.Forms.TextBox()
        Me.chkSoloAperti = New System.Windows.Forms.CheckBox()
        Me.cdiPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        EmailLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(18, 75)
        EmailLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(84, 24)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Periodo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 24)
        Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 24)
        Label2.TabIndex = 42
        Label2.Text = "Evento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 268)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(111, 24)
        Label1.TabIndex = 43
        Label1.Text = "Solo aperti:"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(18, 201)
        Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(143, 57)
        Label3.TabIndex = 45
        Label3.Text = "Motivazione Note:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(18, 138)
        Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(84, 24)
        Label4.TabIndex = 49
        Label4.Text = "Notifica:"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 353)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(931, 45)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "ToolStrip1"
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
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.chkOnlyCurrUser)
        Me.pnlEdit.Controls.Add(Me.cdiNotifica)
        Me.pnlEdit.Controls.Add(Label4)
        Me.pnlEdit.Controls.Add(Me.chkUrgente)
        Me.pnlEdit.Controls.Add(Me.ucSelEvento)
        Me.pnlEdit.Controls.Add(Me.txtMotivazione)
        Me.pnlEdit.Controls.Add(Label3)
        Me.pnlEdit.Controls.Add(Me.chkSoloAperti)
        Me.pnlEdit.Controls.Add(Label1)
        Me.pnlEdit.Controls.Add(Me.cdiPeriodo)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(931, 353)
        Me.pnlEdit.TabIndex = 0
        '
        'chkOnlyCurrUser
        '
        Me.chkOnlyCurrUser.Image = Global.PoliecoSoci.My.Resources.Resources.Smart_Male_1_32_n_g
        Me.chkOnlyCurrUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkOnlyCurrUser.Location = New System.Drawing.Point(654, 132)
        Me.chkOnlyCurrUser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkOnlyCurrUser.Name = "chkOnlyCurrUser"
        Me.chkOnlyCurrUser.Size = New System.Drawing.Size(226, 50)
        Me.chkOnlyCurrUser.TabIndex = 4
        Me.chkOnlyCurrUser.Text = "Solo  i miei eventi"
        Me.chkOnlyCurrUser.UseVisualStyleBackColor = True
        '
        'cdiNotifica
        '
        Me.cdiNotifica.DataFinale = Nothing
        Me.cdiNotifica.DataIniziale = Nothing
        Me.cdiNotifica.DateFormat = "dd/MM/yyyy"
        Me.cdiNotifica.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiNotifica.Location = New System.Drawing.Point(170, 139)
        Me.cdiNotifica.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.cdiNotifica.MonthFormat = False
        Me.cdiNotifica.Name = "cdiNotifica"
        Me.cdiNotifica.Size = New System.Drawing.Size(425, 32)
        Me.cdiNotifica.TabIndex = 3
        Me.cdiNotifica.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiNotifica.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'chkUrgente
        '
        Me.chkUrgente.Image = Global.PoliecoSoci.My.Resources.Resources.Alert_or_Warning_1_24_n_g
        Me.chkUrgente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUrgente.Location = New System.Drawing.Point(654, 75)
        Me.chkUrgente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkUrgente.Name = "chkUrgente"
        Me.chkUrgente.Size = New System.Drawing.Size(139, 42)
        Me.chkUrgente.TabIndex = 2
        Me.chkUrgente.Text = "Urgenti"
        Me.chkUrgente.UseVisualStyleBackColor = True
        '
        'ucSelEvento
        '
        Me.ucSelEvento.DropDownAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ucSelEvento.Location = New System.Drawing.Point(170, 24)
        Me.ucSelEvento.ManualOnly = False
        Me.ucSelEvento.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ucSelEvento.Name = "ucSelEvento"
        Me.ucSelEvento.SelectedCode = ""
        Me.ucSelEvento.SelectedEvent = Nothing
        Me.ucSelEvento.Size = New System.Drawing.Size(741, 42)
        Me.ucSelEvento.TabIndex = 0
        '
        'txtMotivazione
        '
        Me.txtMotivazione.Location = New System.Drawing.Point(170, 201)
        Me.txtMotivazione.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMotivazione.Name = "txtMotivazione"
        Me.txtMotivazione.Size = New System.Drawing.Size(426, 32)
        Me.txtMotivazione.TabIndex = 5
        '
        'chkSoloAperti
        '
        Me.chkSoloAperti.AutoSize = True
        Me.chkSoloAperti.Location = New System.Drawing.Point(170, 275)
        Me.chkSoloAperti.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkSoloAperti.Name = "chkSoloAperti"
        Me.chkSoloAperti.Size = New System.Drawing.Size(18, 17)
        Me.chkSoloAperti.TabIndex = 6
        Me.chkSoloAperti.UseVisualStyleBackColor = True
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiPeriodo.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiPeriodo.Location = New System.Drawing.Point(170, 75)
        Me.cdiPeriodo.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.cdiPeriodo.MonthFormat = False
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(425, 32)
        Me.cdiPeriodo.TabIndex = 1
        Me.cdiPeriodo.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'dlgSelFiltroEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 398)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "dlgSelFiltroEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selezione evento"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents cdiPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents chkSoloAperti As System.Windows.Forms.CheckBox
    Friend WithEvents txtMotivazione As System.Windows.Forms.TextBox
    Friend WithEvents ucSelEvento As PoliecoSoci.ucEventSelector
    Friend WithEvents chkUrgente As CheckBox
    Friend WithEvents cdiNotifica As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents chkOnlyCurrUser As CheckBox
End Class
