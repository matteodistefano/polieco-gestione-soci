<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgProfilaDocumento
    Inherits System.Windows.Forms.Form

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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.lDescrContattoTarget = New System.Windows.Forms.Label()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAnnulla = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.cbProfilo = New System.Windows.Forms.ComboBox()
        Me.rbTaFile = New System.Windows.Forms.RadioButton()
        Me.pnlTipoArc = New System.Windows.Forms.Panel()
        Me.ucFile = New mdsUIControls.ucFileSel()
        Me.rbTaBarcode = New System.Windows.Forms.RadioButton()
        Me.chkTutti = New System.Windows.Forms.CheckBox()
        Me.cbRuoloContattoTarget = New System.Windows.Forms.ComboBox()
        Me.lDescrContattoDefault = New System.Windows.Forms.Label()
        Me.lRuoloContattoDefault = New System.Windows.Forms.Label()
        Me.txtOggetto = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.dgvAggiuntivi = New System.Windows.Forms.DataGridView()
        Me.dgvcAggNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAggValore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAggiuntivi = New System.Windows.Forms.BindingSource(Me.components)
        Me.pbFreccia = New System.Windows.Forms.PictureBox()
        Me.txtDataDoc = New mdsUIControls.mdsDate()
        NomeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        Me.pnlTipoArc.SuspendLayout()
        CType(Me.dgvAggiuntivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAggiuntivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFreccia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(13, 9)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(52, 17)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Profilo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 480)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(127, 17)
        Label1.TabIndex = 6
        Label1.Text = "Tipo archiviazione:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 146)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(63, 17)
        Label2.TabIndex = 12
        Label2.Text = "Oggetto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(9, 250)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(116, 17)
        Label3.TabIndex = 14
        Label3.Text = "Data documento:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(188, 250)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(62, 17)
        Label4.TabIndex = 16
        Label4.Text = "Numero:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(9, 306)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(127, 17)
        Label5.TabIndex = 18
        Label5.Text = "Tipo archiviazione:"
        '
        'lDescrContattoTarget
        '
        Me.lDescrContattoTarget.BackColor = System.Drawing.Color.White
        Me.lDescrContattoTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescrContattoTarget.Location = New System.Drawing.Point(104, 74)
        Me.lDescrContattoTarget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDescrContattoTarget.Name = "lDescrContattoTarget"
        Me.lDescrContattoTarget.Size = New System.Drawing.Size(535, 23)
        Me.lDescrContattoTarget.TabIndex = 8
        Me.lDescrContattoTarget.Text = "Profilo:"
        Me.lDescrContattoTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnnulla, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 569)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(685, 45)
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
        Me.tsbAnnulla.Size = New System.Drawing.Size(101, 42)
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
        Me.tsbOk.Size = New System.Drawing.Size(69, 42)
        Me.tsbOk.Text = "&Ok"
        '
        'cbProfilo
        '
        Me.cbProfilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProfilo.FormattingEnabled = True
        Me.cbProfilo.Location = New System.Drawing.Point(12, 29)
        Me.cbProfilo.Name = "cbProfilo"
        Me.cbProfilo.Size = New System.Drawing.Size(476, 24)
        Me.cbProfilo.TabIndex = 3
        '
        'rbTaFile
        '
        Me.rbTaFile.AutoSize = True
        Me.rbTaFile.Checked = True
        Me.rbTaFile.Location = New System.Drawing.Point(8, 3)
        Me.rbTaFile.Name = "rbTaFile"
        Me.rbTaFile.Size = New System.Drawing.Size(51, 21)
        Me.rbTaFile.TabIndex = 4
        Me.rbTaFile.TabStop = True
        Me.rbTaFile.Text = "File"
        Me.rbTaFile.UseVisualStyleBackColor = True
        '
        'pnlTipoArc
        '
        Me.pnlTipoArc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTipoArc.Controls.Add(Me.ucFile)
        Me.pnlTipoArc.Controls.Add(Me.rbTaBarcode)
        Me.pnlTipoArc.Controls.Add(Me.rbTaFile)
        Me.pnlTipoArc.Location = New System.Drawing.Point(12, 500)
        Me.pnlTipoArc.Name = "pnlTipoArc"
        Me.pnlTipoArc.Size = New System.Drawing.Size(660, 57)
        Me.pnlTipoArc.TabIndex = 5
        '
        'ucFile
        '
        Me.ucFile.BackColorTxt = System.Drawing.SystemColors.Window
        Me.ucFile.Location = New System.Drawing.Point(91, 4)
        Me.ucFile.Name = "ucFile"
        Me.ucFile.ReadOnly = False
        Me.ucFile.Size = New System.Drawing.Size(564, 20)
        Me.ucFile.TabIndex = 19
        Me.ucFile.TipoRicerca = mdsUIControls.ucFileSel.tagTipoRicerca.TP_FILE_OPEN
        '
        'rbTaBarcode
        '
        Me.rbTaBarcode.AutoSize = True
        Me.rbTaBarcode.Location = New System.Drawing.Point(8, 30)
        Me.rbTaBarcode.Name = "rbTaBarcode"
        Me.rbTaBarcode.Size = New System.Drawing.Size(82, 21)
        Me.rbTaBarcode.TabIndex = 5
        Me.rbTaBarcode.Text = "Barcode"
        Me.rbTaBarcode.UseVisualStyleBackColor = True
        '
        'chkTutti
        '
        Me.chkTutti.AutoSize = True
        Me.chkTutti.Location = New System.Drawing.Point(494, 29)
        Me.chkTutti.Name = "chkTutti"
        Me.chkTutti.Size = New System.Drawing.Size(58, 21)
        Me.chkTutti.TabIndex = 7
        Me.chkTutti.Text = "Tutti"
        Me.chkTutti.UseVisualStyleBackColor = True
        '
        'cbRuoloContattoTarget
        '
        Me.cbRuoloContattoTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRuoloContattoTarget.FormattingEnabled = True
        Me.cbRuoloContattoTarget.Items.AddRange(New Object() {"DA", "A"})
        Me.cbRuoloContattoTarget.Location = New System.Drawing.Point(12, 73)
        Me.cbRuoloContattoTarget.Name = "cbRuoloContattoTarget"
        Me.cbRuoloContattoTarget.Size = New System.Drawing.Size(85, 24)
        Me.cbRuoloContattoTarget.TabIndex = 9
        '
        'lDescrContattoDefault
        '
        Me.lDescrContattoDefault.BackColor = System.Drawing.Color.White
        Me.lDescrContattoDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescrContattoDefault.Location = New System.Drawing.Point(105, 107)
        Me.lDescrContattoDefault.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDescrContattoDefault.Name = "lDescrContattoDefault"
        Me.lDescrContattoDefault.Size = New System.Drawing.Size(534, 23)
        Me.lDescrContattoDefault.TabIndex = 10
        Me.lDescrContattoDefault.Text = "Profilo:"
        Me.lDescrContattoDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lRuoloContattoDefault
        '
        Me.lRuoloContattoDefault.BackColor = System.Drawing.Color.White
        Me.lRuoloContattoDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lRuoloContattoDefault.Location = New System.Drawing.Point(13, 107)
        Me.lRuoloContattoDefault.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lRuoloContattoDefault.Name = "lRuoloContattoDefault"
        Me.lRuoloContattoDefault.Size = New System.Drawing.Size(85, 23)
        Me.lRuoloContattoDefault.TabIndex = 11
        Me.lRuoloContattoDefault.Text = "Profilo:"
        Me.lRuoloContattoDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOggetto
        '
        Me.txtOggetto.Location = New System.Drawing.Point(12, 166)
        Me.txtOggetto.Multiline = True
        Me.txtOggetto.Name = "txtOggetto"
        Me.txtOggetto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOggetto.Size = New System.Drawing.Size(660, 71)
        Me.txtOggetto.TabIndex = 13
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(191, 270)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(139, 22)
        Me.txtNumero.TabIndex = 17
        '
        'dgvAggiuntivi
        '
        Me.dgvAggiuntivi.AllowUserToAddRows = False
        Me.dgvAggiuntivi.AllowUserToDeleteRows = False
        Me.dgvAggiuntivi.AutoGenerateColumns = False
        Me.dgvAggiuntivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAggiuntivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAggiuntivi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcAggNome, Me.dgvcAggValore})
        Me.dgvAggiuntivi.DataSource = Me.bsAggiuntivi
        Me.dgvAggiuntivi.Location = New System.Drawing.Point(12, 327)
        Me.dgvAggiuntivi.Name = "dgvAggiuntivi"
        Me.dgvAggiuntivi.RowHeadersWidth = 20
        Me.dgvAggiuntivi.RowTemplate.Height = 24
        Me.dgvAggiuntivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAggiuntivi.Size = New System.Drawing.Size(660, 142)
        Me.dgvAggiuntivi.TabIndex = 19
        '
        'dgvcAggNome
        '
        Me.dgvcAggNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvcAggNome.DataPropertyName = "LABEL"
        Me.dgvcAggNome.HeaderText = "Nome"
        Me.dgvcAggNome.Name = "dgvcAggNome"
        Me.dgvcAggNome.ReadOnly = True
        '
        'dgvcAggValore
        '
        Me.dgvcAggValore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAggValore.DataPropertyName = "Valore"
        Me.dgvcAggValore.HeaderText = "Valore"
        Me.dgvcAggValore.Name = "dgvcAggValore"
        Me.dgvcAggValore.Width = 200
        '
        'pbFreccia
        '
        Me.pbFreccia.Image = Global.PoliecoSoci.My.Resources.Resources.freccia_DA
        Me.pbFreccia.Location = New System.Drawing.Point(646, 74)
        Me.pbFreccia.Name = "pbFreccia"
        Me.pbFreccia.Size = New System.Drawing.Size(30, 60)
        Me.pbFreccia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFreccia.TabIndex = 20
        Me.pbFreccia.TabStop = False
        '
        'txtDataDoc
        '
        Me.txtDataDoc.DateFormat = Nothing
        Me.txtDataDoc.DateValue = Nothing
        Me.txtDataDoc.IsReadOnly = False
        Me.txtDataDoc.Location = New System.Drawing.Point(12, 270)
        Me.txtDataDoc.Name = "txtDataDoc"
        Me.txtDataDoc.SetNullDateToDbNull = False
        Me.txtDataDoc.Size = New System.Drawing.Size(151, 22)
        Me.txtDataDoc.TabIndex = 15
        '
        'dlgProfilaDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 614)
        Me.Controls.Add(Me.pbFreccia)
        Me.Controls.Add(Me.dgvAggiuntivi)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtDataDoc)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtOggetto)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lRuoloContattoDefault)
        Me.Controls.Add(Me.lDescrContattoDefault)
        Me.Controls.Add(Me.cbRuoloContattoTarget)
        Me.Controls.Add(Me.lDescrContattoTarget)
        Me.Controls.Add(Me.chkTutti)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.pnlTipoArc)
        Me.Controls.Add(Me.cbProfilo)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgProfilaDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profilazione documento"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.pnlTipoArc.ResumeLayout(False)
        Me.pnlTipoArc.PerformLayout()
        CType(Me.dgvAggiuntivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAggiuntivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFreccia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnnulla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbProfilo As System.Windows.Forms.ComboBox
    Friend WithEvents rbTaFile As System.Windows.Forms.RadioButton
    Friend WithEvents pnlTipoArc As System.Windows.Forms.Panel
    Friend WithEvents rbTaBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents chkTutti As System.Windows.Forms.CheckBox
    Friend WithEvents cbRuoloContattoTarget As System.Windows.Forms.ComboBox
    Friend WithEvents lDescrContattoTarget As System.Windows.Forms.Label
    Friend WithEvents lDescrContattoDefault As System.Windows.Forms.Label
    Friend WithEvents lRuoloContattoDefault As System.Windows.Forms.Label
    Friend WithEvents txtOggetto As System.Windows.Forms.TextBox
    Friend WithEvents txtDataDoc As mdsUIControls.mdsDate
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents bsAggiuntivi As System.Windows.Forms.BindingSource
    Friend WithEvents dgvAggiuntivi As System.Windows.Forms.DataGridView
    Friend WithEvents ucFile As mdsUIControls.ucFileSel
    Friend WithEvents pbFreccia As System.Windows.Forms.PictureBox
    Friend WithEvents dgvcAggNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcAggValore As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
