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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSelFiltroEvento))
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
        EmailLabel.Location = New System.Drawing.Point(10, 41)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Periodo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 13)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(44, 13)
        Label2.TabIndex = 42
        Label2.Text = "Evento:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 136)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 13)
        Label1.TabIndex = 43
        Label1.Text = "Solo aperti:"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(10, 99)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(78, 31)
        Label3.TabIndex = 45
        Label3.Text = "Motivazione Note:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 70)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(46, 13)
        Label4.TabIndex = 49
        Label4.Text = "Notifica:"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 170)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(508, 45)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbAnnulla
        '
        Me.tsbAnnulla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnnulla.Image = CType(resources.GetObject("tsbAnnulla.Image"), System.Drawing.Image)
        Me.tsbAnnulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnnulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnnulla.Name = "tsbAnnulla"
        Me.tsbAnnulla.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbAnnulla.Size = New System.Drawing.Size(90, 42)
        Me.tsbAnnulla.Text = "&Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = CType(resources.GetObject("tsbOk.Image"), System.Drawing.Image)
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbOk.Size = New System.Drawing.Size(64, 42)
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
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(508, 170)
        Me.pnlEdit.TabIndex = 0
        '
        'chkOnlyCurrUser
        '
        Me.chkOnlyCurrUser.Image = Global.PoliecoSoci.My.Resources.Resources.User_2_16_n_g
        Me.chkOnlyCurrUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkOnlyCurrUser.Location = New System.Drawing.Point(357, 67)
        Me.chkOnlyCurrUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkOnlyCurrUser.Name = "chkOnlyCurrUser"
        Me.chkOnlyCurrUser.Size = New System.Drawing.Size(123, 27)
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
        Me.cdiNotifica.Location = New System.Drawing.Point(93, 71)
        Me.cdiNotifica.MonthFormat = False
        Me.cdiNotifica.Name = "cdiNotifica"
        Me.cdiNotifica.Size = New System.Drawing.Size(232, 23)
        Me.cdiNotifica.TabIndex = 3
        Me.cdiNotifica.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiNotifica.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'chkUrgente
        '
        Me.chkUrgente.Image = Global.PoliecoSoci.My.Resources.Resources.Alert_or_Warning_2_16_n_g
        Me.chkUrgente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkUrgente.Location = New System.Drawing.Point(357, 41)
        Me.chkUrgente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkUrgente.Name = "chkUrgente"
        Me.chkUrgente.Size = New System.Drawing.Size(76, 23)
        Me.chkUrgente.TabIndex = 2
        Me.chkUrgente.Text = "Urgenti"
        Me.chkUrgente.UseVisualStyleBackColor = True
        '
        'ucSelEvento
        '
        Me.ucSelEvento.DropDownAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ucSelEvento.Location = New System.Drawing.Point(93, 13)
        Me.ucSelEvento.ManualOnly = False
        Me.ucSelEvento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ucSelEvento.Name = "ucSelEvento"
        Me.ucSelEvento.SelectedCode = ""
        Me.ucSelEvento.SelectedEvent = Nothing
        Me.ucSelEvento.Size = New System.Drawing.Size(404, 23)
        Me.ucSelEvento.TabIndex = 0
        '
        'txtMotivazione
        '
        Me.txtMotivazione.Location = New System.Drawing.Point(93, 99)
        Me.txtMotivazione.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMotivazione.Name = "txtMotivazione"
        Me.txtMotivazione.Size = New System.Drawing.Size(234, 20)
        Me.txtMotivazione.TabIndex = 5
        '
        'chkSoloAperti
        '
        Me.chkSoloAperti.AutoSize = True
        Me.chkSoloAperti.Location = New System.Drawing.Point(75, 136)
        Me.chkSoloAperti.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSoloAperti.Name = "chkSoloAperti"
        Me.chkSoloAperti.Size = New System.Drawing.Size(15, 14)
        Me.chkSoloAperti.TabIndex = 6
        Me.chkSoloAperti.UseVisualStyleBackColor = True
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiPeriodo.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiPeriodo.Location = New System.Drawing.Point(93, 41)
        Me.cdiPeriodo.MonthFormat = False
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(232, 23)
        Me.cdiPeriodo.TabIndex = 1
        Me.cdiPeriodo.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'dlgSelFiltroEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 215)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
