<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStampaEsportaSoci
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStampaEsportaSoci))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbStop = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.pnlLog = New System.Windows.Forms.Panel()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.cbModelloWord = New System.Windows.Forms.ComboBox()
        Me.rbSt2 = New System.Windows.Forms.RadioButton()
        Me.rbSt1 = New System.Windows.Forms.RadioButton()
        Me.rbSt0 = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkGeneraEvento = New System.Windows.Forms.CheckBox()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk, Me.tsbStop})
        Me.tsMain.Location = New System.Drawing.Point(0, 208)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(658, 45)
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
        'tsbStop
        '
        Me.tsbStop.Image = Global.PoliecoSoci.My.Resources.Resources.Stop_1_
        Me.tsbStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStop.Name = "tsbStop"
        Me.tsbStop.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbStop.Size = New System.Drawing.Size(119, 42)
        Me.tsbStop.Text = "Interrompi"
        Me.tsbStop.Visible = False
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.chkGeneraEvento)
        Me.pnlEdit.Controls.Add(Me.pnlLog)
        Me.pnlEdit.Controls.Add(Me.cbModelloWord)
        Me.pnlEdit.Controls.Add(Me.rbSt2)
        Me.pnlEdit.Controls.Add(Me.rbSt1)
        Me.pnlEdit.Controls.Add(Me.rbSt0)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(658, 208)
        Me.pnlEdit.TabIndex = 6
        '
        'pnlLog
        '
        Me.pnlLog.Controls.Add(Me.lblLog)
        Me.pnlLog.Controls.Add(Me.pBar)
        Me.pnlLog.Location = New System.Drawing.Point(16, 143)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(630, 50)
        Me.pnlLog.TabIndex = 48
        Me.pnlLog.Visible = False
        '
        'lblLog
        '
        Me.lblLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLog.Location = New System.Drawing.Point(0, 23)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(630, 27)
        Me.lblLog.TabIndex = 1
        Me.lblLog.Text = "---"
        Me.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pBar
        '
        Me.pBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pBar.Location = New System.Drawing.Point(0, 0)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(630, 23)
        Me.pBar.TabIndex = 0
        '
        'cbModelloWord
        '
        Me.cbModelloWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModelloWord.FormattingEnabled = True
        Me.cbModelloWord.Location = New System.Drawing.Point(256, 66)
        Me.cbModelloWord.Name = "cbModelloWord"
        Me.cbModelloWord.Size = New System.Drawing.Size(390, 24)
        Me.cbModelloWord.TabIndex = 47
        '
        'rbSt2
        '
        Me.rbSt2.AutoSize = True
        Me.rbSt2.Location = New System.Drawing.Point(16, 66)
        Me.rbSt2.Name = "rbSt2"
        Me.rbSt2.Size = New System.Drawing.Size(234, 21)
        Me.rbSt2.TabIndex = 45
        Me.rbSt2.Text = "Stampa unione su modello Word"
        Me.rbSt2.UseVisualStyleBackColor = True
        '
        'rbSt1
        '
        Me.rbSt1.AutoSize = True
        Me.rbSt1.Location = New System.Drawing.Point(16, 39)
        Me.rbSt1.Name = "rbSt1"
        Me.rbSt1.Size = New System.Drawing.Size(134, 21)
        Me.rbSt1.TabIndex = 44
        Me.rbSt1.Text = "Esporta su Excel"
        Me.rbSt1.UseVisualStyleBackColor = True
        '
        'rbSt0
        '
        Me.rbSt0.AutoSize = True
        Me.rbSt0.Checked = True
        Me.rbSt0.Location = New System.Drawing.Point(16, 12)
        Me.rbSt0.Name = "rbSt0"
        Me.rbSt0.Size = New System.Drawing.Size(123, 21)
        Me.rbSt0.TabIndex = 43
        Me.rbSt0.TabStop = True
        Me.rbSt0.Text = "Stampa elenco"
        Me.rbSt0.UseVisualStyleBackColor = True
        '
        'chkGeneraEvento
        '
        Me.chkGeneraEvento.AutoSize = True
        Me.chkGeneraEvento.Location = New System.Drawing.Point(39, 102)
        Me.chkGeneraEvento.Name = "chkGeneraEvento"
        Me.chkGeneraEvento.Size = New System.Drawing.Size(307, 21)
        Me.chkGeneraEvento.TabIndex = 49
        Me.chkGeneraEvento.Text = "Genera evento [Certificato per Adempienza]"
        Me.chkGeneraEvento.UseVisualStyleBackColor = True
        Me.chkGeneraEvento.Visible = False
        '
        'dlgStampaEsportaSoci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 253)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dlgStampaEsportaSoci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stampa / Esporta"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.pnlLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents cbModelloWord As System.Windows.Forms.ComboBox
    Friend WithEvents rbSt2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbSt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbSt0 As System.Windows.Forms.RadioButton
    Friend WithEvents tsbStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents lblLog As System.Windows.Forms.Label
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkGeneraEvento As CheckBox
End Class
