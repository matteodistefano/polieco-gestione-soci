<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSelEvento
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSelEvento))
        Dim Label1 As System.Windows.Forms.Label
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.cdiPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.cbEvento = New System.Windows.Forms.ComboBox()
        Me.chkSoloAperti = New System.Windows.Forms.CheckBox()
        EmailLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(13, 51)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(61, 17)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Periodo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 23)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 17)
        Label2.TabIndex = 42
        Label2.Text = "Evento:"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 138)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(577, 45)
        Me.tsMain.TabIndex = 0
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
        Me.tsbAnnulla.Size = New System.Drawing.Size(101, 42)
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
        Me.tsbOk.Size = New System.Drawing.Size(69, 42)
        Me.tsbOk.Text = "&Ok"
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.chkSoloAperti)
        Me.pnlEdit.Controls.Add(Label1)
        Me.pnlEdit.Controls.Add(Me.cdiPeriodo)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(Me.cbEvento)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(577, 138)
        Me.pnlEdit.TabIndex = 6
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.Location = New System.Drawing.Point(103, 51)
        Me.cdiPeriodo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(310, 28)
        Me.cdiPeriodo.TabIndex = 6
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'cbEvento
        '
        Me.cbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEvento.FormattingEnabled = True
        Me.cbEvento.Location = New System.Drawing.Point(103, 20)
        Me.cbEvento.Name = "cbEvento"
        Me.cbEvento.Size = New System.Drawing.Size(459, 24)
        Me.cbEvento.TabIndex = 2
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 83)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 17)
        Label1.TabIndex = 43
        Label1.Text = "Solo aperti:"
        '
        'chkSoloAperti
        '
        Me.chkSoloAperti.AutoSize = True
        Me.chkSoloAperti.Location = New System.Drawing.Point(103, 82)
        Me.chkSoloAperti.Name = "chkSoloAperti"
        Me.chkSoloAperti.Size = New System.Drawing.Size(18, 17)
        Me.chkSoloAperti.TabIndex = 44
        Me.chkSoloAperti.UseVisualStyleBackColor = True
        '
        'dlgSelEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 183)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dlgSelEvento"
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
    Friend WithEvents cbEvento As System.Windows.Forms.ComboBox
    Friend WithEvents cdiPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents chkSoloAperti As System.Windows.Forms.CheckBox
End Class
