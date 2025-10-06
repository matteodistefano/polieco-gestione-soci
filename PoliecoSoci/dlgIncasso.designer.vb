<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgIncasso
    Inherits mdsUIControls.BaseForm

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
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImporto = New mdsUIControls.mdsTextBoxFMT()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txtDataPag = New mdsUIControls.mdsDate()
        Me.lDataIns = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataVal = New mdsUIControls.mdsDate()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbModPag = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataScad = New mdsUIControls.mdsDate()
        Me.txtNumRata = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlRata = New System.Windows.Forms.Panel()
        Me.chkAcconto = New System.Windows.Forms.CheckBox()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRata.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 503)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(683, 69)
        Me.tsMain.TabIndex = 8
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_32_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(117, 66)
        Me.tsbExit.Text = "Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_32_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(74, 66)
        Me.tsbOk.Text = "Ok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 316)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Note"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Data inserimento"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Note", True))
        Me.txtNote.Location = New System.Drawing.Point(177, 316)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(469, 158)
        Me.txtNote.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 214)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Imp. unitario"
        '
        'txtImporto
        '
        Me.txtImporto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Importo", True))
        Me.txtImporto.ForzaControlloTastiValuta = False
        Me.txtImporto.Location = New System.Drawing.Point(177, 214)
        Me.txtImporto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImporto.Name = "txtImporto"
        Me.txtImporto.NullDateValue = mdsUIControls.mdsTextBoxFMT.NullDateSetting.[NOTHING]
        Me.txtImporto.NullNumberValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImporto.Size = New System.Drawing.Size(176, 32)
        Me.txtImporto.TabIndex = 3
        Me.txtImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImporto.TipoFormattazione = mdsUIControls.mdsTextBoxFMT.tagTipoFormattazione.FMT_VALUTA
        '
        'cbTipo
        '
        Me.cbTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodTipo", True))
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(176, 110)
        Me.cbTipo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(470, 32)
        Me.cbTipo.TabIndex = 1
        '
        'txtDataPag
        '
        Me.txtDataPag.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataPagamento", True))
        Me.txtDataPag.DateFormat = Nothing
        Me.txtDataPag.DateValue = Nothing
        Me.txtDataPag.IsReadOnly = False
        Me.txtDataPag.Location = New System.Drawing.Point(177, 58)
        Me.txtDataPag.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataPag.Name = "txtDataPag"
        Me.txtDataPag.SetNullDateToDbNull = False
        Me.txtDataPag.Size = New System.Drawing.Size(176, 32)
        Me.txtDataPag.TabIndex = 78
        '
        'lDataIns
        '
        Me.lDataIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lDataIns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDataIns.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "DataInserimento", True))
        Me.lDataIns.Location = New System.Drawing.Point(177, 12)
        Me.lDataIns.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lDataIns.Name = "lDataIns"
        Me.lDataIns.Size = New System.Drawing.Size(177, 35)
        Me.lDataIns.TabIndex = 79
        Me.lDataIns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Data pagamento"
        '
        'txtDataVal
        '
        Me.txtDataVal.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataValuta", True))
        Me.txtDataVal.DateFormat = Nothing
        Me.txtDataVal.DateValue = Nothing
        Me.txtDataVal.IsReadOnly = False
        Me.txtDataVal.Location = New System.Drawing.Point(491, 62)
        Me.txtDataVal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataVal.Name = "txtDataVal"
        Me.txtDataVal.SetNullDateToDbNull = False
        Me.txtDataVal.Size = New System.Drawing.Size(157, 32)
        Me.txtDataVal.TabIndex = 81
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 63)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Data valuta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Tipo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 24)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Mod. pagamento"
        '
        'cbModPag
        '
        Me.cbModPag.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodModalitaPagamento", True))
        Me.cbModPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModPag.FormattingEnabled = True
        Me.cbModPag.Location = New System.Drawing.Point(177, 160)
        Me.cbModPag.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbModPag.Name = "cbModPag"
        Me.cbModPag.Size = New System.Drawing.Size(469, 32)
        Me.cbModPag.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 24)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Data scadenza"
        '
        'txtDataScad
        '
        Me.txtDataScad.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataScadenza", True))
        Me.txtDataScad.DateFormat = Nothing
        Me.txtDataScad.DateValue = Nothing
        Me.txtDataScad.IsReadOnly = False
        Me.txtDataScad.Location = New System.Drawing.Point(162, 8)
        Me.txtDataScad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataScad.Name = "txtDataScad"
        Me.txtDataScad.SetNullDateToDbNull = False
        Me.txtDataScad.Size = New System.Drawing.Size(177, 32)
        Me.txtDataScad.TabIndex = 86
        '
        'txtNumRata
        '
        Me.txtNumRata.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "NumeroRata", True))
        Me.txtNumRata.Location = New System.Drawing.Point(479, 8)
        Me.txtNumRata.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumRata.Name = "txtNumRata"
        Me.txtNumRata.Size = New System.Drawing.Size(122, 32)
        Me.txtNumRata.TabIndex = 88
        Me.txtNumRata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(368, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Rata num."
        '
        'pnlRata
        '
        Me.pnlRata.Controls.Add(Me.Label6)
        Me.pnlRata.Controls.Add(Me.Label8)
        Me.pnlRata.Controls.Add(Me.txtDataScad)
        Me.pnlRata.Controls.Add(Me.txtNumRata)
        Me.pnlRata.Location = New System.Drawing.Point(14, 256)
        Me.pnlRata.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRata.Name = "pnlRata"
        Me.pnlRata.Size = New System.Drawing.Size(634, 50)
        Me.pnlRata.TabIndex = 90
        '
        'chkAcconto
        '
        Me.chkAcconto.AutoSize = True
        Me.chkAcconto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsData, "IsAcconto", True))
        Me.chkAcconto.Location = New System.Drawing.Point(375, 213)
        Me.chkAcconto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAcconto.Name = "chkAcconto"
        Me.chkAcconto.Size = New System.Drawing.Size(105, 28)
        Me.chkAcconto.TabIndex = 91
        Me.chkAcconto.Text = "Acconto"
        Me.chkAcconto.UseVisualStyleBackColor = True
        '
        'dlgIncasso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 572)
        Me.Controls.Add(Me.chkAcconto)
        Me.Controls.Add(Me.pnlRata)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbModPag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDataVal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lDataIns)
        Me.Controls.Add(Me.txtDataPag)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.txtImporto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgIncasso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incasso"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRata.ResumeLayout(False)
        Me.pnlRata.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtImporto As mdsUIControls.mdsTextBoxFMT
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataPag As mdsUIControls.mdsDate
    Friend WithEvents lDataIns As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDataVal As mdsUIControls.mdsDate
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbModPag As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDataScad As mdsUIControls.mdsDate
    Friend WithEvents txtNumRata As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlRata As System.Windows.Forms.Panel
    Friend WithEvents chkAcconto As System.Windows.Forms.CheckBox
End Class
