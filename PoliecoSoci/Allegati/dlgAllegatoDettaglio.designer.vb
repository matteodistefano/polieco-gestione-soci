<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAllegatoDettaglio
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
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.lDichiarazione = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bsDettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbAzienda = New System.Windows.Forms.GroupBox()
        Me.lAzPartitaIva = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRuolo = New System.Windows.Forms.ComboBox()
        Me.btnSetAzienda = New System.Windows.Forms.Button()
        Me.lAzNazione = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lAzProvincia = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lAzCap = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lAzLocalita = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lAzIndirizzo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lAzRagioneSociale = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbMateriale = New System.Windows.Forms.GroupBox()
        Me.txtContributo = New mdsUIControls.mdsTextBoxFMT()
        Me.ldescrQta = New System.Windows.Forms.Label()
        Me.lDescrContributo = New System.Windows.Forms.Label()
        Me.lCerDescrizione = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lCerCodice = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSetMateriale = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAzienda.SuspendLayout()
        Me.gbMateriale.SuspendLayout()
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
        Me.tsMain.Location = New System.Drawing.Point(0, 842)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1502, 69)
        Me.tsMain.TabIndex = 1
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
        'lDichiarazione
        '
        Me.lDichiarazione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lDichiarazione.BackColor = System.Drawing.Color.White
        Me.lDichiarazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDichiarazione.Location = New System.Drawing.Point(22, 115)
        Me.lDichiarazione.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lDichiarazione.Name = "lDichiarazione"
        Me.lDichiarazione.Size = New System.Drawing.Size(1432, 36)
        Me.lDichiarazione.TabIndex = 1
        Me.lDichiarazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Azienda dichiarante"
        '
        'lAzienda
        '
        Me.lAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzienda.BackColor = System.Drawing.Color.White
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzienda.Location = New System.Drawing.Point(22, 40)
        Me.lAzienda.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(1432, 36)
        Me.lAzienda.TabIndex = 0
        Me.lAzienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Dichiarazione"
        '
        'gbAzienda
        '
        Me.gbAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAzienda.Controls.Add(Me.lAzPartitaIva)
        Me.gbAzienda.Controls.Add(Me.Label4)
        Me.gbAzienda.Controls.Add(Me.cbRuolo)
        Me.gbAzienda.Controls.Add(Me.btnSetAzienda)
        Me.gbAzienda.Controls.Add(Me.lAzNazione)
        Me.gbAzienda.Controls.Add(Me.Label19)
        Me.gbAzienda.Controls.Add(Me.lAzProvincia)
        Me.gbAzienda.Controls.Add(Me.Label17)
        Me.gbAzienda.Controls.Add(Me.lAzCap)
        Me.gbAzienda.Controls.Add(Me.Label15)
        Me.gbAzienda.Controls.Add(Me.Label13)
        Me.gbAzienda.Controls.Add(Me.lAzLocalita)
        Me.gbAzienda.Controls.Add(Me.Label11)
        Me.gbAzienda.Controls.Add(Me.lAzIndirizzo)
        Me.gbAzienda.Controls.Add(Me.Label9)
        Me.gbAzienda.Controls.Add(Me.lAzRagioneSociale)
        Me.gbAzienda.Controls.Add(Me.Label6)
        Me.gbAzienda.Location = New System.Drawing.Point(22, 180)
        Me.gbAzienda.Margin = New System.Windows.Forms.Padding(6)
        Me.gbAzienda.Name = "gbAzienda"
        Me.gbAzienda.Padding = New System.Windows.Forms.Padding(6)
        Me.gbAzienda.Size = New System.Drawing.Size(1458, 336)
        Me.gbAzienda.TabIndex = 2
        Me.gbAzienda.TabStop = False
        Me.gbAzienda.Text = "Azienda"
        '
        'lAzPartitaIva
        '
        Me.lAzPartitaIva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzPartitaIva.BackColor = System.Drawing.Color.White
        Me.lAzPartitaIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzPartitaIva.Location = New System.Drawing.Point(1071, 126)
        Me.lAzPartitaIva.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzPartitaIva.Name = "lAzPartitaIva"
        Me.lAzPartitaIva.Size = New System.Drawing.Size(287, 36)
        Me.lAzPartitaIva.TabIndex = 3
        Me.lAzPartitaIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1066, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Partita IVA"
        '
        'cbRuolo
        '
        Me.cbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRuolo.FormattingEnabled = True
        Me.cbRuolo.Location = New System.Drawing.Point(11, 57)
        Me.cbRuolo.Margin = New System.Windows.Forms.Padding(6)
        Me.cbRuolo.Name = "cbRuolo"
        Me.cbRuolo.Size = New System.Drawing.Size(291, 32)
        Me.cbRuolo.TabIndex = 0
        '
        'btnSetAzienda
        '
        Me.btnSetAzienda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetAzienda.Image = Global.PoliecoSoci.My.Resources.Resources.Back_24_n_g
        Me.btnSetAzienda.Location = New System.Drawing.Point(1374, 126)
        Me.btnSetAzienda.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSetAzienda.Name = "btnSetAzienda"
        Me.btnSetAzienda.Size = New System.Drawing.Size(73, 184)
        Me.btnSetAzienda.TabIndex = 1
        Me.btnSetAzienda.UseVisualStyleBackColor = True
        '
        'lAzNazione
        '
        Me.lAzNazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzNazione.BackColor = System.Drawing.Color.White
        Me.lAzNazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzNazione.Location = New System.Drawing.Point(1045, 272)
        Me.lAzNazione.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzNazione.Name = "lAzNazione"
        Me.lAzNazione.Size = New System.Drawing.Size(311, 36)
        Me.lAzNazione.TabIndex = 8
        Me.lAzNazione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1040, 242)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 24)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Nazione"
        '
        'lAzProvincia
        '
        Me.lAzProvincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzProvincia.BackColor = System.Drawing.Color.White
        Me.lAzProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzProvincia.Location = New System.Drawing.Point(913, 272)
        Me.lAzProvincia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzProvincia.Name = "lAzProvincia"
        Me.lAzProvincia.Size = New System.Drawing.Size(119, 36)
        Me.lAzProvincia.TabIndex = 7
        Me.lAzProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(905, 248)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 24)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Prov."
        '
        'lAzCap
        '
        Me.lAzCap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzCap.BackColor = System.Drawing.Color.White
        Me.lAzCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzCap.Location = New System.Drawing.Point(713, 272)
        Me.lAzCap.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzCap.Name = "lAzCap"
        Me.lAzCap.Size = New System.Drawing.Size(179, 36)
        Me.lAzCap.TabIndex = 6
        Me.lAzCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(707, 242)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 24)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "CAP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 27)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 24)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Ruolo"
        '
        'lAzLocalita
        '
        Me.lAzLocalita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzLocalita.BackColor = System.Drawing.Color.White
        Me.lAzLocalita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzLocalita.Location = New System.Drawing.Point(11, 272)
        Me.lAzLocalita.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzLocalita.Name = "lAzLocalita"
        Me.lAzLocalita.Size = New System.Drawing.Size(688, 36)
        Me.lAzLocalita.TabIndex = 5
        Me.lAzLocalita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 248)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Localita"
        '
        'lAzIndirizzo
        '
        Me.lAzIndirizzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzIndirizzo.BackColor = System.Drawing.Color.White
        Me.lAzIndirizzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzIndirizzo.Location = New System.Drawing.Point(11, 195)
        Me.lAzIndirizzo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzIndirizzo.Name = "lAzIndirizzo"
        Me.lAzIndirizzo.Size = New System.Drawing.Size(1347, 36)
        Me.lAzIndirizzo.TabIndex = 4
        Me.lAzIndirizzo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 171)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 24)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Indirizzo"
        '
        'lAzRagioneSociale
        '
        Me.lAzRagioneSociale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lAzRagioneSociale.BackColor = System.Drawing.Color.White
        Me.lAzRagioneSociale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lAzRagioneSociale.Location = New System.Drawing.Point(11, 126)
        Me.lAzRagioneSociale.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lAzRagioneSociale.Name = "lAzRagioneSociale"
        Me.lAzRagioneSociale.Size = New System.Drawing.Size(903, 36)
        Me.lAzRagioneSociale.TabIndex = 2
        Me.lAzRagioneSociale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 24)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Ragione sociale"
        '
        'gbMateriale
        '
        Me.gbMateriale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMateriale.Controls.Add(Me.txtContributo)
        Me.gbMateriale.Controls.Add(Me.Label26)
        Me.gbMateriale.Controls.Add(Me.ldescrQta)
        Me.gbMateriale.Controls.Add(Me.lDescrContributo)
        Me.gbMateriale.Controls.Add(Me.lCerDescrizione)
        Me.gbMateriale.Controls.Add(Me.TextBox1)
        Me.gbMateriale.Controls.Add(Me.Label23)
        Me.gbMateriale.Controls.Add(Me.lCerCodice)
        Me.gbMateriale.Controls.Add(Me.Label21)
        Me.gbMateriale.Controls.Add(Me.btnSetMateriale)
        Me.gbMateriale.Location = New System.Drawing.Point(28, 527)
        Me.gbMateriale.Margin = New System.Windows.Forms.Padding(6)
        Me.gbMateriale.Name = "gbMateriale"
        Me.gbMateriale.Padding = New System.Windows.Forms.Padding(6)
        Me.gbMateriale.Size = New System.Drawing.Size(1452, 287)
        Me.gbMateriale.TabIndex = 3
        Me.gbMateriale.TabStop = False
        Me.gbMateriale.Text = "Materiale"
        '
        'txtContributo
        '
        Me.txtContributo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDettaglio, "ContributoApplicato", True))
        Me.txtContributo.ForzaControlloTastiValuta = False
        Me.txtContributo.Location = New System.Drawing.Point(253, 66)
        Me.txtContributo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtContributo.Name = "txtContributo"
        Me.txtContributo.NullDateValue = mdsUIControls.mdsTextBoxFMT.NullDateSetting.[NOTHING]
        Me.txtContributo.NullNumberValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContributo.Size = New System.Drawing.Size(246, 32)
        Me.txtContributo.TabIndex = 1
        Me.txtContributo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtContributo.TipoFormattazione = mdsUIControls.mdsTextBoxFMT.tagTipoFormattazione.FMT_VALUTA
        '
        'ldescrQta
        '
        Me.ldescrQta.AutoSize = True
        Me.ldescrQta.Location = New System.Drawing.Point(6, 38)
        Me.ldescrQta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ldescrQta.Name = "ldescrQta"
        Me.ldescrQta.Size = New System.Drawing.Size(87, 24)
        Me.ldescrQta.TabIndex = 111
        Me.ldescrQta.Text = "Quantità"
        '
        'lDescrContributo
        '
        Me.lDescrContributo.AutoSize = True
        Me.lDescrContributo.Location = New System.Drawing.Point(248, 38)
        Me.lDescrContributo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lDescrContributo.Name = "lDescrContributo"
        Me.lDescrContributo.Size = New System.Drawing.Size(262, 24)
        Me.lDescrContributo.TabIndex = 106
        Me.lDescrContributo.Text = "Contributo Polieco applicato"
        '
        'lCerDescrizione
        '
        Me.lCerDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lCerDescrizione.BackColor = System.Drawing.Color.White
        Me.lCerDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lCerDescrizione.Location = New System.Drawing.Point(253, 129)
        Me.lCerDescrizione.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lCerDescrizione.Name = "lCerDescrizione"
        Me.lCerDescrizione.Size = New System.Drawing.Size(1094, 36)
        Me.lCerDescrizione.TabIndex = 4
        Me.lCerDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDettaglio, "Quantita", True))
        Me.TextBox1.Location = New System.Drawing.Point(11, 66)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 32)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(248, 105)
        Me.Label23.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 24)
        Me.Label23.TabIndex = 106
        Me.Label23.Text = "Descrizione"
        '
        'lCerCodice
        '
        Me.lCerCodice.BackColor = System.Drawing.Color.White
        Me.lCerCodice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lCerCodice.Location = New System.Drawing.Point(11, 128)
        Me.lCerCodice.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lCerCodice.Name = "lCerCodice"
        Me.lCerCodice.Size = New System.Drawing.Size(201, 36)
        Me.lCerCodice.TabIndex = 3
        Me.lCerCodice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 104)
        Me.Label21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 24)
        Me.Label21.TabIndex = 104
        Me.Label21.Text = "Codice CER"
        '
        'btnSetMateriale
        '
        Me.btnSetMateriale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetMateriale.Image = Global.PoliecoSoci.My.Resources.Resources.Back_24_n_g
        Me.btnSetMateriale.Location = New System.Drawing.Point(1359, 117)
        Me.btnSetMateriale.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSetMateriale.Name = "btnSetMateriale"
        Me.btnSetMateriale.Size = New System.Drawing.Size(73, 58)
        Me.btnSetMateriale.TabIndex = 2
        Me.btnSetMateriale.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDettaglio, "Note", True))
        Me.TextBox2.Location = New System.Drawing.Point(37, 736)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(1423, 66)
        Me.TextBox2.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 179)
        Me.Label26.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 24)
        Me.Label26.TabIndex = 112
        Me.Label26.Text = "Note"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(40, 654)
        Me.Label24.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(145, 24)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "Unità di misura"
        '
        'dlgAllegatoDettaglio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 911)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.gbMateriale)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.gbAzienda)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lDichiarazione)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tsMain)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "dlgAllegatoDettaglio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dettaglio allegato"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAzienda.ResumeLayout(False)
        Me.gbAzienda.PerformLayout()
        Me.gbMateriale.ResumeLayout(False)
        Me.gbMateriale.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents lDichiarazione As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bsDettaglio As BindingSource
    Friend WithEvents lAzienda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbAzienda As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lAzLocalita As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lAzIndirizzo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lAzRagioneSociale As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lAzNazione As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lAzProvincia As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lAzCap As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSetAzienda As Button
    Friend WithEvents gbMateriale As GroupBox
    Friend WithEvents lCerDescrizione As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lCerCodice As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSetMateriale As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ldescrQta As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cbRuolo As ComboBox
    Friend WithEvents lAzPartitaIva As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lDescrContributo As Label
    Friend WithEvents txtContributo As mdsUIControls.mdsTextBoxFMT
End Class
