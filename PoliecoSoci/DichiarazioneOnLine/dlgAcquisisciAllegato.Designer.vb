<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAcquisisciAllegato
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim QualificaLabel As System.Windows.Forms.Label
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.tsbAcquisisci = New System.Windows.Forms.ToolStripButton()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.ucFile = New mdsUIControls.ucFileSel()
        Me.rtfLog = New System.Windows.Forms.RichTextBox()
        Me.tsbAzienda = New System.Windows.Forms.ToolStripButton()
        QualificaLabel = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'QualificaLabel
        '
        QualificaLabel.AutoSize = True
        QualificaLabel.Location = New System.Drawing.Point(9, 12)
        QualificaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        QualificaLabel.Name = "QualificaLabel"
        QualificaLabel.Size = New System.Drawing.Size(48, 13)
        QualificaLabel.TabIndex = 5
        QualificaLabel.Text = "Allegato:"
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbClose, Me.tsbAcquisisci, Me.tsbAzienda})
        Me.tsMain.Location = New System.Drawing.Point(0, 343)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(736, 37)
        Me.tsMain.TabIndex = 36
        '
        'tsbClose
        '
        Me.tsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbClose.Image = Global.DichiarazioneOnLine.My.Resources.Resources.SE_Arrow_24_n_g
        Me.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbClose.Size = New System.Drawing.Size(74, 34)
        Me.tsbClose.Text = "Chiudi"
        '
        'tsbAcquisisci
        '
        Me.tsbAcquisisci.Image = Global.DichiarazioneOnLine.My.Resources.Resources.Database_Check_In_32_n_g
        Me.tsbAcquisisci.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAcquisisci.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAcquisisci.Name = "tsbAcquisisci"
        Me.tsbAcquisisci.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAcquisisci.Size = New System.Drawing.Size(100, 34)
        Me.tsbAcquisisci.Text = "Acquisisci"
        '
        'pnlTop
        '
        Me.pnlTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTop.Controls.Add(Me.ucFile)
        Me.pnlTop.Controls.Add(QualificaLabel)
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(736, 46)
        Me.pnlTop.TabIndex = 38
        '
        'ucFile
        '
        Me.ucFile.BackColorTxt = System.Drawing.SystemColors.Window
        Me.ucFile.Location = New System.Drawing.Point(61, 11)
        Me.ucFile.Margin = New System.Windows.Forms.Padding(2)
        Me.ucFile.Name = "ucFile"
        Me.ucFile.ReadOnly = False
        Me.ucFile.Size = New System.Drawing.Size(664, 22)
        Me.ucFile.TabIndex = 6
        Me.ucFile.TipoRicerca = mdsUIControls.ucFileSel.tagTipoRicerca.TP_FILE_OPEN
        '
        'rtfLog
        '
        Me.rtfLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfLog.Location = New System.Drawing.Point(0, 51)
        Me.rtfLog.Name = "rtfLog"
        Me.rtfLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtfLog.Size = New System.Drawing.Size(736, 289)
        Me.rtfLog.TabIndex = 39
        Me.rtfLog.Text = ""
        '
        'tsbAzienda
        '
        Me.tsbAzienda.Image = Global.DichiarazioneOnLine.My.Resources.Resources.Office_Block_24_h_g
        Me.tsbAzienda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAzienda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAzienda.Name = "tsbAzienda"
        Me.tsbAzienda.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAzienda.Size = New System.Drawing.Size(104, 34)
        Me.tsbAzienda.Text = "Apri azienda"
        '
        'dlgAcquisisciAllegato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 380)
        Me.Controls.Add(Me.rtfLog)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgAcquisisciAllegato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acquisizione allegato dichiarazione"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents ucFile As mdsUIControls.ucFileSel
    Friend WithEvents rtfLog As RichTextBox
    Friend WithEvents tsbAcquisisci As ToolStripButton
    Friend WithEvents tsbAzienda As ToolStripButton
End Class
