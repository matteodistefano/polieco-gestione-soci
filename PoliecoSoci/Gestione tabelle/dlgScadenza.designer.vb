<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScadenza
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.txtRifPeriodo = New System.Windows.Forms.TextBox()
        Me.bsEntity = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.txtTasso = New System.Windows.Forms.TextBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtScadPagamento = New mdsUIControls.mdsDate()
        Me.txtScadDichiarazione = New mdsUIControls.mdsDate()
        Me.txtDataFine = New mdsUIControls.mdsDate()
        Me.txtDataInizio = New mdsUIControls.mdsDate()
        Me.txtAnno = New System.Windows.Forms.TextBox()
        Me.chkInteressi = New System.Windows.Forms.CheckBox()
        Me.txtCodice = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.bsEntity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(6, 27)
        NomeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(76, 24)
        NomeLabel.TabIndex = 0
        NomeLabel.Text = "Codice:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 119)
        EmailLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(109, 24)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Data inizio:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 72)
        Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 24)
        Label2.TabIndex = 27
        Label2.Text = "Anno:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 161)
        Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(95, 24)
        Label3.TabIndex = 29
        Label3.Text = "Data fine:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(373, 116)
        Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(183, 24)
        Label1.TabIndex = 32
        Label1.Text = "Scad. dichiarazione"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(373, 158)
        Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(166, 24)
        Label4.TabIndex = 34
        Label4.Text = "Scad. pagamento"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 208)
        Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(102, 24)
        Label5.TabIndex = 36
        Label5.Text = "Categoria:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 250)
        Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(92, 24)
        Label6.TabIndex = 38
        Label6.Text = "Interessi:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(183, 250)
        Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(68, 24)
        Label7.TabIndex = 39
        Label7.Text = "Tasso:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(373, 250)
        Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(212, 24)
        Label8.TabIndex = 41
        Label8.Text = "Creazione automatica:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(373, 72)
        Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(189, 24)
        Label9.TabIndex = 42
        Label9.Text = "Periodo riferimento:"
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
        Me.tsMain.Size = New System.Drawing.Size(793, 45)
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
        Me.pnlEdit.Controls.Add(Me.txtRifPeriodo)
        Me.pnlEdit.Controls.Add(Label9)
        Me.pnlEdit.Controls.Add(Me.chkAuto)
        Me.pnlEdit.Controls.Add(Label8)
        Me.pnlEdit.Controls.Add(Me.txtTasso)
        Me.pnlEdit.Controls.Add(Label7)
        Me.pnlEdit.Controls.Add(Label6)
        Me.pnlEdit.Controls.Add(Me.cbCategoria)
        Me.pnlEdit.Controls.Add(Label5)
        Me.pnlEdit.Controls.Add(Me.txtScadPagamento)
        Me.pnlEdit.Controls.Add(Label4)
        Me.pnlEdit.Controls.Add(Me.txtScadDichiarazione)
        Me.pnlEdit.Controls.Add(Label1)
        Me.pnlEdit.Controls.Add(Me.txtDataFine)
        Me.pnlEdit.Controls.Add(Me.txtDataInizio)
        Me.pnlEdit.Controls.Add(Label3)
        Me.pnlEdit.Controls.Add(Me.txtAnno)
        Me.pnlEdit.Controls.Add(Label2)
        Me.pnlEdit.Controls.Add(Me.chkInteressi)
        Me.pnlEdit.Controls.Add(EmailLabel)
        Me.pnlEdit.Controls.Add(NomeLabel)
        Me.pnlEdit.Controls.Add(Me.txtCodice)
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(793, 355)
        Me.pnlEdit.TabIndex = 6
        '
        'txtRifPeriodo
        '
        Me.txtRifPeriodo.BackColor = System.Drawing.Color.White
        Me.txtRifPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "RifPeriodo", True))
        Me.txtRifPeriodo.Location = New System.Drawing.Point(572, 72)
        Me.txtRifPeriodo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtRifPeriodo.Name = "txtRifPeriodo"
        Me.txtRifPeriodo.Size = New System.Drawing.Size(199, 32)
        Me.txtRifPeriodo.TabIndex = 2
        '
        'chkAuto
        '
        Me.chkAuto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsEntity, "CreaAutomatico", True))
        Me.chkAuto.Location = New System.Drawing.Point(597, 241)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(30, 45)
        Me.chkAuto.TabIndex = 10
        '
        'txtTasso
        '
        Me.txtTasso.BackColor = System.Drawing.Color.White
        Me.txtTasso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "TassoInteresse", True))
        Me.txtTasso.Location = New System.Drawing.Point(264, 250)
        Me.txtTasso.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTasso.Name = "txtTasso"
        Me.txtTasso.Size = New System.Drawing.Size(77, 32)
        Me.txtTasso.TabIndex = 9
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(142, 204)
        Me.cbCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(630, 32)
        Me.cbCategoria.TabIndex = 7
        '
        'txtScadPagamento
        '
        Me.txtScadPagamento.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsEntity, "DataScadenzaPagamento", True))
        Me.txtScadPagamento.DateFormat = Nothing
        Me.txtScadPagamento.DateValue = Nothing
        Me.txtScadPagamento.IsReadOnly = False
        Me.txtScadPagamento.Location = New System.Drawing.Point(572, 158)
        Me.txtScadPagamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtScadPagamento.Name = "txtScadPagamento"
        Me.txtScadPagamento.SetNullDateToDbNull = False
        Me.txtScadPagamento.Size = New System.Drawing.Size(199, 32)
        Me.txtScadPagamento.TabIndex = 6
        '
        'txtScadDichiarazione
        '
        Me.txtScadDichiarazione.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsEntity, "DataScadenzaDichiarazione", True))
        Me.txtScadDichiarazione.DateFormat = Nothing
        Me.txtScadDichiarazione.DateValue = Nothing
        Me.txtScadDichiarazione.IsReadOnly = False
        Me.txtScadDichiarazione.Location = New System.Drawing.Point(572, 116)
        Me.txtScadDichiarazione.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtScadDichiarazione.Name = "txtScadDichiarazione"
        Me.txtScadDichiarazione.SetNullDateToDbNull = False
        Me.txtScadDichiarazione.Size = New System.Drawing.Size(199, 32)
        Me.txtScadDichiarazione.TabIndex = 4
        '
        'txtDataFine
        '
        Me.txtDataFine.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsEntity, "DataFine", True))
        Me.txtDataFine.DateFormat = Nothing
        Me.txtDataFine.DateValue = Nothing
        Me.txtDataFine.IsReadOnly = False
        Me.txtDataFine.Location = New System.Drawing.Point(142, 158)
        Me.txtDataFine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataFine.Name = "txtDataFine"
        Me.txtDataFine.SetNullDateToDbNull = False
        Me.txtDataFine.Size = New System.Drawing.Size(199, 32)
        Me.txtDataFine.TabIndex = 5
        '
        'txtDataInizio
        '
        Me.txtDataInizio.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsEntity, "DataInizio", True))
        Me.txtDataInizio.DateFormat = Nothing
        Me.txtDataInizio.DateValue = Nothing
        Me.txtDataInizio.IsReadOnly = False
        Me.txtDataInizio.Location = New System.Drawing.Point(142, 116)
        Me.txtDataInizio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataInizio.Name = "txtDataInizio"
        Me.txtDataInizio.SetNullDateToDbNull = False
        Me.txtDataInizio.Size = New System.Drawing.Size(199, 32)
        Me.txtDataInizio.TabIndex = 3
        '
        'txtAnno
        '
        Me.txtAnno.BackColor = System.Drawing.Color.White
        Me.txtAnno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Anno", True))
        Me.txtAnno.Location = New System.Drawing.Point(142, 72)
        Me.txtAnno.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(166, 32)
        Me.txtAnno.TabIndex = 1
        '
        'chkInteressi
        '
        Me.chkInteressi.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsEntity, "ApplicaInteressi", True))
        Me.chkInteressi.Location = New System.Drawing.Point(142, 241)
        Me.chkInteressi.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkInteressi.Name = "chkInteressi"
        Me.chkInteressi.Size = New System.Drawing.Size(30, 45)
        Me.chkInteressi.TabIndex = 8
        '
        'txtCodice
        '
        Me.txtCodice.BackColor = System.Drawing.Color.White
        Me.txtCodice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEntity, "Codice", True))
        Me.txtCodice.Location = New System.Drawing.Point(142, 27)
        Me.txtCodice.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(166, 32)
        Me.txtCodice.TabIndex = 0
        '
        'dlgScadenza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 400)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgScadenza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scadenza"
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
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents txtScadPagamento As mdsUIControls.mdsDate
    Friend WithEvents txtScadDichiarazione As mdsUIControls.mdsDate
    Friend WithEvents txtDataFine As mdsUIControls.mdsDate
    Friend WithEvents txtDataInizio As mdsUIControls.mdsDate
    Friend WithEvents txtAnno As System.Windows.Forms.TextBox
    Friend WithEvents chkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents txtTasso As System.Windows.Forms.TextBox
    Friend WithEvents txtRifPeriodo As System.Windows.Forms.TextBox
End Class
