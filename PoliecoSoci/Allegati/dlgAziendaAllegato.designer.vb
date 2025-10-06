<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAziendaAllegato
    Inherits mdsUIControls.BaseForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.bsAzienda = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bsDati = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPIva = New System.Windows.Forms.TextBox()
        Me.txtSocio = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.btnVerSocio = New System.Windows.Forms.Button()
        Me.pnlSocio = New System.Windows.Forms.Panel()
        Me.dgvDettaglio = New System.Windows.Forms.DataGridView()
        Me.dgvcSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDichiarante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRuolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCodCer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcQta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMain.SuspendLayout()
        CType(Me.bsAzienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSocio.SuspendLayout()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 1045)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1798, 69)
        Me.tsMain.TabIndex = 11
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Partita IVA / Codice fiscale"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1380, 238)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 24)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Nazione"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1277, 232)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 24)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Prov."
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1115, 238)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 24)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "CAP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 238)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Localita"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 160)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 24)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Indirizzo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Ragione sociale"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Note", True))
        Me.TextBox2.Location = New System.Drawing.Point(22, 339)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(1752, 182)
        Me.TextBox2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 310)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Note"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, -2)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 24)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Socio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 558)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 24)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Riepilogo dichiarazioni"
        '
        'txtPIva
        '
        Me.txtPIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPIva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "PartitaIva", True))
        Me.txtPIva.Location = New System.Drawing.Point(22, 40)
        Me.txtPIva.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPIva.Name = "txtPIva"
        Me.txtPIva.Size = New System.Drawing.Size(344, 32)
        Me.txtPIva.TabIndex = 0
        '
        'txtSocio
        '
        Me.txtSocio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSocio.Location = New System.Drawing.Point(0, 24)
        Me.txtSocio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSocio.Name = "txtSocio"
        Me.txtSocio.Size = New System.Drawing.Size(1303, 32)
        Me.txtSocio.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "RagioneSociale", True))
        Me.TextBox4.Location = New System.Drawing.Point(22, 118)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(1752, 32)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Indirizzo", True))
        Me.TextBox5.Location = New System.Drawing.Point(22, 190)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(1752, 32)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Localita", True))
        Me.TextBox6.Location = New System.Drawing.Point(22, 267)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(1083, 32)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Cap", True))
        Me.TextBox7.Location = New System.Drawing.Point(1121, 267)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(148, 32)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Provincia", True))
        Me.TextBox8.Location = New System.Drawing.Point(1283, 267)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(88, 32)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAzienda, "Nazione", True))
        Me.TextBox9.Location = New System.Drawing.Point(1386, 267)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(388, 32)
        Me.TextBox9.TabIndex = 8
        '
        'btnVerSocio
        '
        Me.btnVerSocio.Image = Global.PoliecoSoci.My.Resources.Resources.Search_32_n_g
        Me.btnVerSocio.Location = New System.Drawing.Point(380, 32)
        Me.btnVerSocio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnVerSocio.Name = "btnVerSocio"
        Me.btnVerSocio.Size = New System.Drawing.Size(78, 54)
        Me.btnVerSocio.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnVerSocio, "Verifica socio")
        Me.btnVerSocio.UseVisualStyleBackColor = True
        '
        'pnlSocio
        '
        Me.pnlSocio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSocio.Controls.Add(Me.txtSocio)
        Me.pnlSocio.Controls.Add(Me.Label7)
        Me.pnlSocio.Location = New System.Drawing.Point(469, 16)
        Me.pnlSocio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlSocio.Name = "pnlSocio"
        Me.pnlSocio.Size = New System.Drawing.Size(1308, 62)
        Me.pnlSocio.TabIndex = 2
        Me.pnlSocio.Visible = False
        '
        'dgvDettaglio
        '
        Me.dgvDettaglio.AllowUserToAddRows = False
        Me.dgvDettaglio.AllowUserToDeleteRows = False
        Me.dgvDettaglio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDettaglio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcSede, Me.dgvcDichiarante, Me.dgvcRuolo, Me.dgvcCodCer, Me.dgvcDescrizione, Me.dgvcUM, Me.dgvcQta})
        Me.dgvDettaglio.Location = New System.Drawing.Point(22, 586)
        Me.dgvDettaglio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvDettaglio.Name = "dgvDettaglio"
        Me.dgvDettaglio.ReadOnly = True
        Me.dgvDettaglio.RowHeadersWidth = 20
        Me.dgvDettaglio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDettaglio.Size = New System.Drawing.Size(1754, 432)
        Me.dgvDettaglio.TabIndex = 118
        '
        'dgvcSede
        '
        Me.dgvcSede.DataPropertyName = "DescrizioneDichiarazione"
        Me.dgvcSede.FillWeight = 30.0!
        Me.dgvcSede.HeaderText = "Dichiarazione"
        Me.dgvcSede.Name = "dgvcSede"
        Me.dgvcSede.ReadOnly = True
        '
        'dgvcDichiarante
        '
        Me.dgvcDichiarante.DataPropertyName = "DichiaranteDescrizione"
        Me.dgvcDichiarante.FillWeight = 40.0!
        Me.dgvcDichiarante.HeaderText = "Socio Dichiarante"
        Me.dgvcDichiarante.Name = "dgvcDichiarante"
        Me.dgvcDichiarante.ReadOnly = True
        '
        'dgvcRuolo
        '
        Me.dgvcRuolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcRuolo.DataPropertyName = "RuoloAziendaAllegato"
        Me.dgvcRuolo.HeaderText = "Ruolo"
        Me.dgvcRuolo.Name = "dgvcRuolo"
        Me.dgvcRuolo.ReadOnly = True
        Me.dgvcRuolo.Width = 80
        '
        'dgvcCodCer
        '
        Me.dgvcCodCer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCodCer.DataPropertyName = "CodiceCer"
        Me.dgvcCodCer.HeaderText = "Cod.CER"
        Me.dgvcCodCer.Name = "dgvcCodCer"
        Me.dgvcCodCer.ReadOnly = True
        Me.dgvcCodCer.Width = 90
        '
        'dgvcDescrizione
        '
        Me.dgvcDescrizione.DataPropertyName = "DescrizioneMateriale"
        Me.dgvcDescrizione.FillWeight = 30.0!
        Me.dgvcDescrizione.HeaderText = "Materiale"
        Me.dgvcDescrizione.Name = "dgvcDescrizione"
        Me.dgvcDescrizione.ReadOnly = True
        '
        'dgvcUM
        '
        Me.dgvcUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUM.DataPropertyName = "UnitaMisura"
        Me.dgvcUM.HeaderText = "U.M."
        Me.dgvcUM.Name = "dgvcUM"
        Me.dgvcUM.ReadOnly = True
        Me.dgvcUM.Width = 60
        '
        'dgvcQta
        '
        Me.dgvcQta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcQta.DataPropertyName = "Quantita"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        Me.dgvcQta.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcQta.HeaderText = "Qta"
        Me.dgvcQta.Name = "dgvcQta"
        Me.dgvcQta.ReadOnly = True
        '
        'dlgAziendaAllegato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1798, 1114)
        Me.Controls.Add(Me.dgvDettaglio)
        Me.Controls.Add(Me.pnlSocio)
        Me.Controls.Add(Me.btnVerSocio)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtPIva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgAziendaAllegato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Azienda allegato"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsAzienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSocio.ResumeLayout(False)
        Me.pnlSocio.PerformLayout()
        CType(Me.dgvDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsAzienda As BindingSource
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents bsDati As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPIva As TextBox
    Friend WithEvents txtSocio As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents btnVerSocio As Button
    Friend WithEvents pnlSocio As Panel
    Friend WithEvents dgvDettaglio As DataGridView
    Friend WithEvents dgvcSede As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDichiarante As DataGridViewTextBoxColumn
    Friend WithEvents dgvcRuolo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCodCer As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgvcUM As DataGridViewTextBoxColumn
    Friend WithEvents dgvcQta As DataGridViewTextBoxColumn
End Class
