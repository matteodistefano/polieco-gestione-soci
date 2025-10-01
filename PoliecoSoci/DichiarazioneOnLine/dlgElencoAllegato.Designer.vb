<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgElencoAllegato
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
        Dim QualificaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.dgvcAzienda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcPIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcQta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcB_Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcB_Contributo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCE_CodCER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCE_Provenienza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcE_Lavorazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcE_Nazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcE_ProcProduttivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcE_Autorizzazioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcE_Licenze = New System.Windows.Forms.DataGridViewTextBoxColumn()
        QualificaLabel = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'QualificaLabel
        '
        QualificaLabel.AutoSize = True
        QualificaLabel.Location = New System.Drawing.Point(12, 15)
        QualificaLabel.Name = "QualificaLabel"
        QualificaLabel.Size = New System.Drawing.Size(94, 17)
        QualificaLabel.TabIndex = 5
        QualificaLabel.Text = "Tipo allegato:"
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbClose})
        Me.tsMain.Location = New System.Drawing.Point(0, 495)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(982, 46)
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
        Me.tsbClose.Size = New System.Drawing.Size(83, 43)
        Me.tsbClose.Text = "Chiudi"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcAzienda, Me.dgvcPIVA, Me.dgvcQta, Me.dgvcB_Periodo, Me.dgvcB_Contributo, Me.dgvcCE_CodCER, Me.dgvcCE_Provenienza, Me.dgvcE_Lavorazione, Me.dgvcE_Nazione, Me.dgvcE_ProcProduttivo, Me.dgvcE_Autorizzazioni, Me.dgvcE_Licenze})
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 56)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersWidth = 20
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(982, 439)
        Me.dgvData.TabIndex = 37
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.cbTipo)
        Me.pnlTop.Controls.Add(QualificaLabel)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(982, 56)
        Me.pnlTop.TabIndex = 38
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(104, 12)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(857, 24)
        Me.cbTipo.TabIndex = 6
        '
        'dgvcAzienda
        '
        Me.dgvcAzienda.DataPropertyName = "_Azienda"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcAzienda.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcAzienda.FillWeight = 329.1799!
        Me.dgvcAzienda.HeaderText = "Azienda"
        Me.dgvcAzienda.Name = "dgvcAzienda"
        Me.dgvcAzienda.ReadOnly = True
        '
        'dgvcPIVA
        '
        Me.dgvcPIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcPIVA.DataPropertyName = "_PartitaIVA"
        Me.dgvcPIVA.HeaderText = "Partita IVA"
        Me.dgvcPIVA.Name = "dgvcPIVA"
        Me.dgvcPIVA.ReadOnly = True
        Me.dgvcPIVA.Width = 120
        '
        'dgvcQta
        '
        Me.dgvcQta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcQta.DataPropertyName = "Quantita"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.dgvcQta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcQta.FillWeight = 670.0508!
        Me.dgvcQta.HeaderText = "Quantita"
        Me.dgvcQta.Name = "dgvcQta"
        Me.dgvcQta.ReadOnly = True
        Me.dgvcQta.Width = 120
        '
        'dgvcB_Periodo
        '
        Me.dgvcB_Periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcB_Periodo.DataPropertyName = "B_Periodo"
        Me.dgvcB_Periodo.FillWeight = 11.19659!
        Me.dgvcB_Periodo.HeaderText = "Periodo"
        Me.dgvcB_Periodo.Name = "dgvcB_Periodo"
        Me.dgvcB_Periodo.ReadOnly = True
        Me.dgvcB_Periodo.Width = 80
        '
        'dgvcB_Contributo
        '
        Me.dgvcB_Contributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcB_Contributo.DataPropertyName = "B_Contributo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "c2"
        Me.dgvcB_Contributo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcB_Contributo.FillWeight = 11.19659!
        Me.dgvcB_Contributo.HeaderText = "Contributo"
        Me.dgvcB_Contributo.Name = "dgvcB_Contributo"
        Me.dgvcB_Contributo.ReadOnly = True
        Me.dgvcB_Contributo.Width = 120
        '
        'dgvcCE_CodCER
        '
        Me.dgvcCE_CodCER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCE_CodCER.DataPropertyName = "CE_CodiceCER"
        Me.dgvcCE_CodCER.FillWeight = 11.19659!
        Me.dgvcCE_CodCER.HeaderText = "Codice CER"
        Me.dgvcCE_CodCER.Name = "dgvcCE_CodCER"
        Me.dgvcCE_CodCER.ReadOnly = True
        Me.dgvcCE_CodCER.Width = 200
        '
        'dgvcCE_Provenienza
        '
        Me.dgvcCE_Provenienza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcCE_Provenienza.DataPropertyName = "CE_Provenienza"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcCE_Provenienza.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcCE_Provenienza.FillWeight = 11.19659!
        Me.dgvcCE_Provenienza.HeaderText = "Provenienza"
        Me.dgvcCE_Provenienza.Name = "dgvcCE_Provenienza"
        Me.dgvcCE_Provenienza.ReadOnly = True
        Me.dgvcCE_Provenienza.Width = 200
        '
        'dgvcE_Lavorazione
        '
        Me.dgvcE_Lavorazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcE_Lavorazione.DataPropertyName = "CE_ProcessoLavorazione"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcE_Lavorazione.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvcE_Lavorazione.FillWeight = 11.19659!
        Me.dgvcE_Lavorazione.HeaderText = "Processo lavorazione"
        Me.dgvcE_Lavorazione.Name = "dgvcE_Lavorazione"
        Me.dgvcE_Lavorazione.ReadOnly = True
        Me.dgvcE_Lavorazione.Width = 200
        '
        'dgvcE_Nazione
        '
        Me.dgvcE_Nazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcE_Nazione.DataPropertyName = "E_Nazione"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcE_Nazione.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcE_Nazione.FillWeight = 11.19659!
        Me.dgvcE_Nazione.HeaderText = "Nazione"
        Me.dgvcE_Nazione.Name = "dgvcE_Nazione"
        Me.dgvcE_Nazione.ReadOnly = True
        Me.dgvcE_Nazione.Width = 200
        '
        'dgvcE_ProcProduttivo
        '
        Me.dgvcE_ProcProduttivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcE_ProcProduttivo.DataPropertyName = "E_ProcProduttivo"
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcE_ProcProduttivo.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcE_ProcProduttivo.FillWeight = 11.19659!
        Me.dgvcE_ProcProduttivo.HeaderText = "Processo produttivo"
        Me.dgvcE_ProcProduttivo.Name = "dgvcE_ProcProduttivo"
        Me.dgvcE_ProcProduttivo.ReadOnly = True
        Me.dgvcE_ProcProduttivo.Width = 200
        '
        'dgvcE_Autorizzazioni
        '
        Me.dgvcE_Autorizzazioni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcE_Autorizzazioni.DataPropertyName = "E_Autorizzazioni"
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcE_Autorizzazioni.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcE_Autorizzazioni.FillWeight = 11.19659!
        Me.dgvcE_Autorizzazioni.HeaderText = "Autorizzazioni"
        Me.dgvcE_Autorizzazioni.Name = "dgvcE_Autorizzazioni"
        Me.dgvcE_Autorizzazioni.ReadOnly = True
        Me.dgvcE_Autorizzazioni.Width = 200
        '
        'dgvcE_Licenze
        '
        Me.dgvcE_Licenze.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcE_Licenze.DataPropertyName = "E_Licenze"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcE_Licenze.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvcE_Licenze.FillWeight = 11.19659!
        Me.dgvcE_Licenze.HeaderText = "Licenze"
        Me.dgvcE_Licenze.Name = "dgvcE_Licenze"
        Me.dgvcE_Licenze.ReadOnly = True
        Me.dgvcE_Licenze.Width = 200
        '
        'dlgElencoAllegato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 541)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgElencoAllegato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco allegato"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgvcAzienda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcPIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcQta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcB_Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcB_Contributo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCE_CodCER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcCE_Provenienza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcE_Lavorazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcE_Nazione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcE_ProcProduttivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcE_Autorizzazioni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcE_Licenze As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
