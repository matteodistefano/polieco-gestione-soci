<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDichiarazioneDettaglio
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProcedura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescrizione = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMateriale = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbUM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lNetto = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lIVA = New System.Windows.Forms.Label()
        Me.lLordo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lQuadro = New System.Windows.Forms.Label()
        Me.txtValore = New mdsUIControls.mdsTextBoxFMT()
        Me.txtImpUnitario = New mdsUIControls.mdsTextBoxFMT()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 305)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(587, 46)
        Me.tsMain.TabIndex = 1
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_24_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(91, 43)
        Me.tsbExit.Text = "Annulla"
        '
        'tsbOk
        '
        Me.tsbOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_24_n_g
        Me.tsbOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOk.Name = "tsbOk"
        Me.tsbOk.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbOk.Size = New System.Drawing.Size(59, 43)
        Me.tsbOk.Text = "Ok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Procedura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descrizione"
        '
        'txtProcedura
        '
        Me.txtProcedura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProcedura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Procedura", True))
        Me.txtProcedura.Location = New System.Drawing.Point(99, 43)
        Me.txtProcedura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProcedura.Multiline = True
        Me.txtProcedura.Name = "txtProcedura"
        Me.txtProcedura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProcedura.Size = New System.Drawing.Size(475, 54)
        Me.txtProcedura.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Quadro"
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizione.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Descrizione", True))
        Me.txtDescrizione.Location = New System.Drawing.Point(99, 106)
        Me.txtDescrizione.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescrizione.Multiline = True
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrizione.Size = New System.Drawing.Size(475, 73)
        Me.txtDescrizione.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Materiale"
        '
        'cbMateriale
        '
        Me.cbMateriale.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "IdMateriale", True))
        Me.cbMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMateriale.FormattingEnabled = True
        Me.cbMateriale.Location = New System.Drawing.Point(291, 9)
        Me.cbMateriale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMateriale.Name = "cbMateriale"
        Me.cbMateriale.Size = New System.Drawing.Size(284, 24)
        Me.cbMateriale.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Imp. unitario"
        '
        'txtIVA
        '
        Me.txtIVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Iva", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.txtIVA.Location = New System.Drawing.Point(233, 217)
        Me.txtIVA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(72, 22)
        Me.txtIVA.TabIndex = 3
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "IVA"
        '
        'cbUM
        '
        Me.cbUM.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodUnitaMisura", True))
        Me.cbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Location = New System.Drawing.Point(99, 187)
        Me.cbUM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(91, 24)
        Me.cbUM.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 187)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Valore dic."
        '
        'lNetto
        '
        Me.lNetto.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lNetto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNetto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "ImportoNetto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.lNetto.Location = New System.Drawing.Point(451, 187)
        Me.lNetto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNetto.Name = "lNetto"
        Me.lNetto.Size = New System.Drawing.Size(123, 24)
        Me.lNetto.TabIndex = 73
        Me.lNetto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 187)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 17)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Importo Netto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Importo IVA"
        '
        'lIVA
        '
        Me.lIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lIVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "ImportoIVA", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.lIVA.Location = New System.Drawing.Point(451, 220)
        Me.lIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lIVA.Name = "lIVA"
        Me.lIVA.Size = New System.Drawing.Size(123, 24)
        Me.lIVA.TabIndex = 75
        Me.lIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lLordo
        '
        Me.lLordo.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lLordo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lLordo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "ImportoLordo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.lLordo.Location = New System.Drawing.Point(451, 254)
        Me.lLordo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lLordo.Name = "lLordo"
        Me.lLordo.Size = New System.Drawing.Size(123, 24)
        Me.lLordo.TabIndex = 77
        Me.lLordo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(352, 257)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 17)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Importo lordo"
        '
        'lQuadro
        '
        Me.lQuadro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lQuadro.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lQuadro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lQuadro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "CodQuadro", True))
        Me.lQuadro.Location = New System.Drawing.Point(99, 11)
        Me.lQuadro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lQuadro.Name = "lQuadro"
        Me.lQuadro.Size = New System.Drawing.Size(70, 22)
        Me.lQuadro.TabIndex = 78
        '
        'txtValore
        '
        Me.txtValore.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Valore", True))
        Me.txtValore.ForzaControlloTastiValuta = True
        Me.txtValore.Location = New System.Drawing.Point(200, 187)
        Me.txtValore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValore.Name = "txtValore"
        Me.txtValore.NullDateValue = mdsUIControls.mdsTextBoxFMT.NullDateSetting.[NOTHING]
        Me.txtValore.Size = New System.Drawing.Size(105, 22)
        Me.txtValore.TabIndex = 0
        Me.txtValore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValore.TipoFormattazione = mdsUIControls.mdsTextBoxFMT.tagTipoFormattazione.FMT_NESSUNO
        '
        'txtImpUnitario
        '
        Me.txtImpUnitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "PrezzoUnitario", True))
        Me.txtImpUnitario.ForzaControlloTastiValuta = False
        Me.txtImpUnitario.Location = New System.Drawing.Point(99, 217)
        Me.txtImpUnitario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtImpUnitario.Name = "txtImpUnitario"
        Me.txtImpUnitario.NullDateValue = mdsUIControls.mdsTextBoxFMT.NullDateSetting.[NOTHING]
        Me.txtImpUnitario.NumeroDecimali = 4
        Me.txtImpUnitario.Size = New System.Drawing.Size(91, 22)
        Me.txtImpUnitario.TabIndex = 2
        Me.txtImpUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpUnitario.TipoFormattazione = mdsUIControls.mdsTextBoxFMT.tagTipoFormattazione.FMT_VALUTA
        '
        'dlgDichiarazioneDettaglio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 351)
        Me.Controls.Add(Me.txtImpUnitario)
        Me.Controls.Add(Me.txtValore)
        Me.Controls.Add(Me.lQuadro)
        Me.Controls.Add(Me.lLordo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lIVA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lNetto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbUM)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbMateriale)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProcedura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "dlgDichiarazioneDettaglio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dettaglio riga dichiarazione"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProcedura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbMateriale As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbUM As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lNetto As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lIVA As System.Windows.Forms.Label
    Friend WithEvents lLordo As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lQuadro As System.Windows.Forms.Label
    Friend WithEvents txtValore As mdsUIControls.mdsTextBoxFMT
    Friend WithEvents txtImpUnitario As mdsUIControls.mdsTextBoxFMT
End Class
