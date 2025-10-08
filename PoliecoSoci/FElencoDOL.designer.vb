<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencoDOL
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
        Dim CognomeNomeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FElencoDOL))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNuova = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbLoadFolder = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnalizza = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvElenco = New System.Windows.Forms.DataGridView()
        Me.dgvcProtocollo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcAnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcScadRifPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcEsito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcStato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiAnnulla = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiAzienda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDichiarazione = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCerca = New System.Windows.Forms.Button()
        Me.chkStatoANN = New System.Windows.Forms.CheckBox()
        Me.chkStatoASS = New System.Windows.Forms.CheckBox()
        Me.chkStatoVAL = New System.Windows.Forms.CheckBox()
        Me.chkStatoINS = New System.Windows.Forms.CheckBox()
        Me.txtPartitaIVA = New System.Windows.Forms.TextBox()
        Me.txtSedeLegale = New System.Windows.Forms.TextBox()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.txtRagioneSociale = New System.Windows.Forms.TextBox()
        Me.txtProtocollo = New System.Windows.Forms.TextBox()
        Me.ccAnno = New mdsUIControls.ucCheckedCombo()
        Me.mcStato = New mdsUIControls.MultiCheck(Me.components)
        Me.DataGridViewBooleanImageColumn1 = New mdsUIControls.DataGridViewBooleanImageColumn()
        CognomeNomeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmGrid.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CognomeNomeLabel
        '
        CognomeNomeLabel.AutoSize = True
        CognomeNomeLabel.Location = New System.Drawing.Point(16, 14)
        CognomeNomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CognomeNomeLabel.Name = "CognomeNomeLabel"
        CognomeNomeLabel.Size = New System.Drawing.Size(111, 24)
        CognomeNomeLabel.TabIndex = 23
        CognomeNomeLabel.Text = "Protocollo :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(396, 14)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(160, 24)
        Label1.TabIndex = 24
        Label1.Text = "Ragione sociale :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(396, 57)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(124, 24)
        Label2.TabIndex = 26
        Label2.Text = "Sede legale :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 57)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(89, 24)
        Label3.TabIndex = 27
        Label3.Text = "Periodo :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(396, 99)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(116, 24)
        Label4.TabIndex = 30
        Label4.Text = "Partita IVA :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(832, 14)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(68, 24)
        Label5.TabIndex = 32
        Label5.Text = "Stato :"
        '
        'tsMain
        '
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuova, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbLoadFolder, Me.tsbAnalizza, Me.tsbStampa})
        Me.tsMain.Location = New System.Drawing.Point(0, 817)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1623, 45)
        Me.tsMain.TabIndex = 4
        Me.tsMain.Text = "ToolStrip1"
        '
        'tsbNuova
        '
        Me.tsbNuova.Image = Global.PoliecoSoci.My.Resources.Resources.Add_Appointment_32_n_g
        Me.tsbNuova.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNuova.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuova.Name = "tsbNuova"
        Me.tsbNuova.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbNuova.Size = New System.Drawing.Size(107, 42)
        Me.tsbNuova.Text = "Nuova"
        Me.tsbNuova.ToolTipText = "Nuovo scadenza"
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(127, 42)
        Me.tsbModifica.Text = "Dettaglio"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.Delete_Appointment_32_n_g
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Size = New System.Drawing.Size(117, 42)
        Me.tsbElimina.Text = "Elimina "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'tsbChiudi
        '
        Me.tsbChiudi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbChiudi.Image = Global.PoliecoSoci.My.Resources.Resources.SE_Arrow_32_n_g
        Me.tsbChiudi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbChiudi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbChiudi.Name = "tsbChiudi"
        Me.tsbChiudi.Padding = New System.Windows.Forms.Padding(3)
        Me.tsbChiudi.Size = New System.Drawing.Size(108, 42)
        Me.tsbChiudi.Text = "&Chiudi"
        '
        'tsbLoadFolder
        '
        Me.tsbLoadFolder.Image = Global.PoliecoSoci.My.Resources.Resources.Database_Check_In_32_n_g
        Me.tsbLoadFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbLoadFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLoadFolder.Name = "tsbLoadFolder"
        Me.tsbLoadFolder.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbLoadFolder.Size = New System.Drawing.Size(179, 42)
        Me.tsbLoadFolder.Text = "Carica cartella"
        Me.tsbLoadFolder.ToolTipText = "Carica cartella"
        '
        'tsbAnalizza
        '
        Me.tsbAnalizza.Image = Global.PoliecoSoci.My.Resources.Resources.verify_1_
        Me.tsbAnalizza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnalizza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnalizza.Name = "tsbAnalizza"
        Me.tsbAnalizza.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAnalizza.Size = New System.Drawing.Size(215, 42)
        Me.tsbAnalizza.Text = "Analizza e associa"
        Me.tsbAnalizza.ToolTipText = "Carica cartella"
        '
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Margin = New System.Windows.Forms.Padding(60, 1, 0, 2)
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'dgvElenco
        '
        Me.dgvElenco.AllowUserToAddRows = False
        Me.dgvElenco.AllowUserToDeleteRows = False
        Me.dgvElenco.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvElenco.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvElenco.AutoGenerateColumns = False
        Me.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvElenco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElenco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcProtocollo, Me.dgvcData, Me.dgvcAnno, Me.dgvcScadRifPer, Me.dgvcCategoria, Me.dgvcSede, Me.dgvcEsito, Me.dgvcStato})
        Me.dgvElenco.ContextMenuStrip = Me.cmGrid
        Me.dgvElenco.DataSource = Me.bsData
        Me.dgvElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvElenco.Location = New System.Drawing.Point(0, 192)
        Me.dgvElenco.Margin = New System.Windows.Forms.Padding(6)
        Me.dgvElenco.Name = "dgvElenco"
        Me.dgvElenco.ReadOnly = True
        Me.dgvElenco.RowHeadersVisible = False
        Me.dgvElenco.RowHeadersWidth = 51
        Me.dgvElenco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvElenco.Size = New System.Drawing.Size(1623, 625)
        Me.dgvElenco.TabIndex = 6
        '
        'dgvcProtocollo
        '
        Me.dgvcProtocollo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcProtocollo.DataPropertyName = "Protocollo"
        Me.dgvcProtocollo.HeaderText = "Protocollo"
        Me.dgvcProtocollo.MinimumWidth = 6
        Me.dgvcProtocollo.Name = "dgvcProtocollo"
        Me.dgvcProtocollo.ReadOnly = True
        Me.dgvcProtocollo.Width = 180
        '
        'dgvcData
        '
        Me.dgvcData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcData.DataPropertyName = "DataCompilazione"
        DataGridViewCellStyle6.Format = "d"
        Me.dgvcData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcData.HeaderText = "Data compilazione"
        Me.dgvcData.MinimumWidth = 6
        Me.dgvcData.Name = "dgvcData"
        Me.dgvcData.ReadOnly = True
        Me.dgvcData.Width = 210
        '
        'dgvcAnno
        '
        Me.dgvcAnno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcAnno.DataPropertyName = "Anno"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvcAnno.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcAnno.HeaderText = "Anno"
        Me.dgvcAnno.MinimumWidth = 6
        Me.dgvcAnno.Name = "dgvcAnno"
        Me.dgvcAnno.ReadOnly = True
        Me.dgvcAnno.Width = 125
        '
        'dgvcScadRifPer
        '
        Me.dgvcScadRifPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcScadRifPer.DataPropertyName = "Periodo"
        Me.dgvcScadRifPer.HeaderText = "Periodo"
        Me.dgvcScadRifPer.MinimumWidth = 6
        Me.dgvcScadRifPer.Name = "dgvcScadRifPer"
        Me.dgvcScadRifPer.ReadOnly = True
        Me.dgvcScadRifPer.Width = 90
        '
        'dgvcCategoria
        '
        Me.dgvcCategoria.DataPropertyName = "DichiarazioneRagioneSociale"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvcCategoria.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcCategoria.FillWeight = 50.0!
        Me.dgvcCategoria.HeaderText = "Azienda"
        Me.dgvcCategoria.MinimumWidth = 6
        Me.dgvcCategoria.Name = "dgvcCategoria"
        Me.dgvcCategoria.ReadOnly = True
        '
        'dgvcSede
        '
        Me.dgvcSede.DataPropertyName = "DichiarazioneSedeLegale"
        Me.dgvcSede.FillWeight = 50.0!
        Me.dgvcSede.HeaderText = "Sede"
        Me.dgvcSede.MinimumWidth = 6
        Me.dgvcSede.Name = "dgvcSede"
        Me.dgvcSede.ReadOnly = True
        '
        'dgvcEsito
        '
        Me.dgvcEsito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcEsito.DataPropertyName = "EsitoAnalisi"
        Me.dgvcEsito.HeaderText = "Esito"
        Me.dgvcEsito.MinimumWidth = 6
        Me.dgvcEsito.Name = "dgvcEsito"
        Me.dgvcEsito.ReadOnly = True
        Me.dgvcEsito.Width = 200
        '
        'dgvcStato
        '
        Me.dgvcStato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcStato.DataPropertyName = "Stato"
        Me.dgvcStato.HeaderText = "Stato"
        Me.dgvcStato.MinimumWidth = 6
        Me.dgvcStato.Name = "dgvcStato"
        Me.dgvcStato.ReadOnly = True
        Me.dgvcStato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcStato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcStato.Width = 70
        '
        'cmGrid
        '
        Me.cmGrid.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAnnulla, Me.ToolStripMenuItem1, Me.tsmiAzienda, Me.tsmiDichiarazione, Me.tsmiDocumento})
        Me.cmGrid.Name = "cmGrid"
        Me.cmGrid.Size = New System.Drawing.Size(222, 106)
        '
        'tsmiAnnulla
        '
        Me.tsmiAnnulla.Name = "tsmiAnnulla"
        Me.tsmiAnnulla.Size = New System.Drawing.Size(221, 24)
        Me.tsmiAnnulla.Text = "Annulla dichiarazione"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(218, 6)
        '
        'tsmiAzienda
        '
        Me.tsmiAzienda.Name = "tsmiAzienda"
        Me.tsmiAzienda.Size = New System.Drawing.Size(221, 24)
        Me.tsmiAzienda.Text = "Apri azienda"
        '
        'tsmiDichiarazione
        '
        Me.tsmiDichiarazione.Name = "tsmiDichiarazione"
        Me.tsmiDichiarazione.Size = New System.Drawing.Size(221, 24)
        Me.tsmiDichiarazione.Text = "Apri dichiarazione"
        '
        'tsmiDocumento
        '
        Me.tsmiDocumento.Name = "tsmiDocumento"
        Me.tsmiDocumento.Size = New System.Drawing.Size(221, 24)
        Me.tsmiDocumento.Text = "Apri documento "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnCerca)
        Me.Panel1.Controls.Add(Me.chkStatoANN)
        Me.Panel1.Controls.Add(Me.chkStatoASS)
        Me.Panel1.Controls.Add(Me.chkStatoVAL)
        Me.Panel1.Controls.Add(Me.chkStatoINS)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.txtPartitaIVA)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.txtSedeLegale)
        Me.Panel1.Controls.Add(Me.txtPeriodo)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.txtRagioneSociale)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(CognomeNomeLabel)
        Me.Panel1.Controls.Add(Me.txtProtocollo)
        Me.Panel1.Controls.Add(Me.ccAnno)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1623, 192)
        Me.Panel1.TabIndex = 7
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Image = Global.PoliecoSoci.My.Resources.Resources.Show_Grid_24_n_g
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(1444, 87)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 66)
        Me.btnReset.TabIndex = 38
        Me.btnReset.Text = "       Ripristina"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCerca
        '
        Me.btnCerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerca.Image = Global.PoliecoSoci.My.Resources.Resources.Search_32_n_g
        Me.btnCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerca.Location = New System.Drawing.Point(1444, 14)
        Me.btnCerca.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCerca.Name = "btnCerca"
        Me.btnCerca.Size = New System.Drawing.Size(160, 62)
        Me.btnCerca.TabIndex = 37
        Me.btnCerca.Text = "    Cerca"
        Me.btnCerca.UseVisualStyleBackColor = True
        '
        'chkStatoANN
        '
        Me.chkStatoANN.Image = Global.PoliecoSoci.My.Resources.Resources.Red_Delete_24_n_g
        Me.chkStatoANN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStatoANN.Location = New System.Drawing.Point(908, 134)
        Me.chkStatoANN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkStatoANN.Name = "chkStatoANN"
        Me.chkStatoANN.Size = New System.Drawing.Size(188, 51)
        Me.chkStatoANN.TabIndex = 36
        Me.chkStatoANN.Text = "      Annullata"
        Me.chkStatoANN.UseVisualStyleBackColor = True
        '
        'chkStatoASS
        '
        Me.chkStatoASS.Image = Global.PoliecoSoci.My.Resources.Resources.OK_24_n_g
        Me.chkStatoASS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStatoASS.Location = New System.Drawing.Point(908, 91)
        Me.chkStatoASS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkStatoASS.Name = "chkStatoASS"
        Me.chkStatoASS.Size = New System.Drawing.Size(188, 54)
        Me.chkStatoASS.TabIndex = 35
        Me.chkStatoASS.Text = "      Associata"
        Me.chkStatoASS.UseVisualStyleBackColor = True
        '
        'chkStatoVAL
        '
        Me.chkStatoVAL.Image = Global.PoliecoSoci.My.Resources.Resources.ANGEM_32
        Me.chkStatoVAL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStatoVAL.Location = New System.Drawing.Point(908, 48)
        Me.chkStatoVAL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkStatoVAL.Name = "chkStatoVAL"
        Me.chkStatoVAL.Size = New System.Drawing.Size(158, 51)
        Me.chkStatoVAL.TabIndex = 34
        Me.chkStatoVAL.Text = "      Validata"
        Me.chkStatoVAL.UseVisualStyleBackColor = True
        '
        'chkStatoINS
        '
        Me.chkStatoINS.Image = CType(resources.GetObject("chkStatoINS.Image"), System.Drawing.Image)
        Me.chkStatoINS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkStatoINS.Location = New System.Drawing.Point(908, 2)
        Me.chkStatoINS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkStatoINS.Name = "chkStatoINS"
        Me.chkStatoINS.Size = New System.Drawing.Size(158, 51)
        Me.chkStatoINS.TabIndex = 33
        Me.chkStatoINS.Text = "      Inserita"
        Me.chkStatoINS.UseVisualStyleBackColor = True
        '
        'txtPartitaIVA
        '
        Me.txtPartitaIVA.Location = New System.Drawing.Point(565, 99)
        Me.txtPartitaIVA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPartitaIVA.Name = "txtPartitaIVA"
        Me.txtPartitaIVA.Size = New System.Drawing.Size(213, 32)
        Me.txtPartitaIVA.TabIndex = 31
        '
        'txtSedeLegale
        '
        Me.txtSedeLegale.Location = New System.Drawing.Point(565, 57)
        Me.txtSedeLegale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSedeLegale.Name = "txtSedeLegale"
        Me.txtSedeLegale.Size = New System.Drawing.Size(213, 32)
        Me.txtSedeLegale.TabIndex = 29
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(133, 57)
        Me.txtPeriodo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(213, 32)
        Me.txtPeriodo.TabIndex = 28
        '
        'txtRagioneSociale
        '
        Me.txtRagioneSociale.Location = New System.Drawing.Point(565, 14)
        Me.txtRagioneSociale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRagioneSociale.Name = "txtRagioneSociale"
        Me.txtRagioneSociale.Size = New System.Drawing.Size(213, 32)
        Me.txtRagioneSociale.TabIndex = 25
        '
        'txtProtocollo
        '
        Me.txtProtocollo.Location = New System.Drawing.Point(133, 14)
        Me.txtProtocollo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtProtocollo.Name = "txtProtocollo"
        Me.txtProtocollo.Size = New System.Drawing.Size(213, 32)
        Me.txtProtocollo.TabIndex = 22
        '
        'ccAnno
        '
        Me.ccAnno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccAnno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccAnno.Checked = False
        Me.ccAnno.CheckText = "Anno"
        Me.ccAnno.CheckWidth = 182
        Me.ccAnno.ComboText = ""
        Me.ccAnno.DataSource = Nothing
        Me.ccAnno.DisplayMember = ""
        Me.ccAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ccAnno.Location = New System.Drawing.Point(20, 99)
        Me.ccAnno.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.ccAnno.MaxDropDownItems = 8
        Me.ccAnno.Name = "ccAnno"
        Me.ccAnno.SelectedIndex = -1
        Me.ccAnno.SelectedValue = Nothing
        Me.ccAnno.Size = New System.Drawing.Size(326, 39)
        Me.ccAnno.TabIndex = 2
        Me.ccAnno.ValueFieldName = Nothing
        Me.ccAnno.ValueMember = ""
        Me.ccAnno.ValueType = mdsUIControls.ucCheckedCombo.ValueTypeEnum.TEXT
        '
        'mcStato
        '
        Me.mcStato.AllowAllUnchecked = False
        Me.mcStato.UseContextMenu = False
        '
        'DataGridViewBooleanImageColumn1
        '
        Me.DataGridViewBooleanImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewBooleanImageColumn1.DataPropertyName = "CreaAutomatico"
        Me.DataGridViewBooleanImageColumn1.HeaderText = "Crea automatico"
        Me.DataGridViewBooleanImageColumn1.ImageFalse = Nothing
        Me.DataGridViewBooleanImageColumn1.ImageTrue = Global.PoliecoSoci.My.Resources.Resources.Green_Checkmark_16_n_g
        Me.DataGridViewBooleanImageColumn1.MinimumWidth = 6
        Me.DataGridViewBooleanImageColumn1.Name = "DataGridViewBooleanImageColumn1"
        Me.DataGridViewBooleanImageColumn1.ReadOnly = True
        Me.DataGridViewBooleanImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBooleanImageColumn1.ValueFalse = "False"
        Me.DataGridViewBooleanImageColumn1.ValueTrue = "True"
        Me.DataGridViewBooleanImageColumn1.Width = 60
        '
        'FElencoDOL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 862)
        Me.Controls.Add(Me.dgvElenco)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FElencoDOL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco dichiarazioni compilate on-line"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.dgvElenco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmGrid.ResumeLayout(False)
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuova As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvElenco As System.Windows.Forms.DataGridView
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewBooleanImageColumn1 As mdsUIControls.DataGridViewBooleanImageColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ccAnno As mdsUIControls.ucCheckedCombo
    Friend WithEvents txtProtocollo As System.Windows.Forms.TextBox
    Friend WithEvents txtPartitaIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSedeLegale As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents txtRagioneSociale As System.Windows.Forms.TextBox
    Friend WithEvents chkStatoINS As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatoANN As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatoASS As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatoVAL As System.Windows.Forms.CheckBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCerca As System.Windows.Forms.Button
    Friend WithEvents mcStato As mdsUIControls.MultiCheck
    Friend WithEvents tsbLoadFolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAnalizza As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiAzienda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDichiarazione As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAnnulla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvcProtocollo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcData As DataGridViewTextBoxColumn
    Friend WithEvents dgvcAnno As DataGridViewTextBoxColumn
    Friend WithEvents dgvcScadRifPer As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvcSede As DataGridViewTextBoxColumn
    Friend WithEvents dgvcEsito As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStato As DataGridViewImageColumn
End Class
