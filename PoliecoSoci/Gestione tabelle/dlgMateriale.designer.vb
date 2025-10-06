<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMateriale
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.cdiPeriodo = New mdsUIControls.ctlDateIntervalHorizontal()
        Me.bsEntity = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbUM = New System.Windows.Forms.ComboBox()
        Me.txtDescrizione = New System.Windows.Forms.TextBox()
        Me.txtPrezzo = New System.Windows.Forms.TextBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.chkInteressi = New System.Windows.Forms.CheckBox()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.bsEntity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(18, 27)
        NomeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(76, 24)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Codice:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(18, 261)
        EmailLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(84, 24)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Periodo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(18, 122)
        Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(119, 24)
        Label5.TabIndex = 36
        Label5.Text = "Descrizione:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(642, 27)
        Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(99, 24)
        Label6.TabIndex = 38
        Label6.Text = "Utilizzato:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(18, 165)
        Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(111, 24)
        Label7.TabIndex = 39
        Label7.Text = "Un. misura:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 75)
        Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 24)
        Label2.TabIndex = 42
        Label2.Text = "Tipo:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(18, 213)
        Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(129, 24)
        Label3.TabIndex = 45
        Label3.Text = "Prezzo netto:"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 355)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(819, 45)
        Me.tsMain.TabIndex = 0
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
        Me.pnlEdit.Controls.Add(Me.cdiPeriodo)
        Me.pnlEdit.Controls.Add(Label3)
        Me.pnlEdit.Controls.Add(Me.cbUM)
        Me.pnlEdit.Controls.Add(Me.txtDescrizione)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(Me.txtPrezzo)
        Me.pnlEdit.Controls.Add(Label7)
        Me.pnlEdit.Controls.Add(Label6)
        Me.pnlEdit.Controls.Add(Me.cbTipo)
        Me.pnlEdit.Controls.Add(Label5)
        Me.pnlEdit.Controls.Add(Me.chkInteressi)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Controls.Add(NomeLabel)
        Me.pnlEdit.Controls.Add(Me.txtCodice)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(819, 355)
        Me.pnlEdit.TabIndex = 6
        '
        'cdiPeriodo
        '
        Me.cdiPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("DataFinale", Me.bsEntity, "DataFine", True))
        Me.cdiPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("DataIniziale", Me.bsEntity, "DataInizio", True))
        Me.cdiPeriodo.DataFinale = Nothing
        Me.cdiPeriodo.DataIniziale = Nothing
        Me.cdiPeriodo.DateFormat = "dd/MM/yyyy"
        Me.cdiPeriodo.IntervalCodition = mdsUIControls.ctlDateIntervalHorizontal.IntervalConditionEnum.STANDARD
        Me.cdiPeriodo.Location = New System.Drawing.Point(150, 261)
        Me.cdiPeriodo.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.cdiPeriodo.MonthFormat = False
        Me.cdiPeriodo.Name = "cdiPeriodo"
        Me.cdiPeriodo.Size = New System.Drawing.Size(425, 42)
        Me.cdiPeriodo.TabIndex = 7
        Me.cdiPeriodo.TxtAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.cdiPeriodo.TxtBackColor = System.Drawing.SystemColors.Window
        '
        'cbUM
        '
        Me.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Location = New System.Drawing.Point(150, 159)
        Me.cbUM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(198, 32)
        Me.cbUM.TabIndex = 4
        '
        'txtDescrizione
        '
        Me.txtDescrizione.BackColor = System.Drawing.Color.White
        Me.txtDescrizione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Descrizione", True))
        Me.txtDescrizione.Location = New System.Drawing.Point(150, 117)
        Me.txtDescrizione.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(630, 32)
        Me.txtDescrizione.TabIndex = 3
        '
        'txtPrezzo
        '
        Me.txtPrezzo.BackColor = System.Drawing.Color.White
        Me.txtPrezzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Prezzo", True))
        Me.txtPrezzo.Location = New System.Drawing.Point(150, 210)
        Me.txtPrezzo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPrezzo.Name = "txtPrezzo"
        Me.txtPrezzo.Size = New System.Drawing.Size(198, 32)
        Me.txtPrezzo.TabIndex = 5
        Me.txtPrezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(150, 70)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(630, 32)
        Me.cbTipo.TabIndex = 2
        '
        'chkInteressi
        '
        Me.chkInteressi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsEntity, "Utilizzato", True))
        Me.chkInteressi.Location = New System.Drawing.Point(750, 18)
        Me.chkInteressi.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkInteressi.Name = "chkInteressi"
        Me.chkInteressi.Size = New System.Drawing.Size(29, 45)
        Me.chkInteressi.TabIndex = 1
        '
        'txtCodice
        '
        Me.txtCodice.BackColor = System.Drawing.Color.White
        Me.txtCodice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Codice", True))
        Me.txtCodice.Location = New System.Drawing.Point(150, 27)
        Me.txtCodice.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(481, 32)
        Me.txtCodice.TabIndex = 0
        '
        'dlgMateriale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 400)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgMateriale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materiale"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.bsEntity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents bsEntity As System.Windows.Forms.BindingSource
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents chkInteressi As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrezzo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents cdiPeriodo As mdsUIControls.ctlDateIntervalHorizontal
    Friend WithEvents cbUM As System.Windows.Forms.ComboBox
End Class
