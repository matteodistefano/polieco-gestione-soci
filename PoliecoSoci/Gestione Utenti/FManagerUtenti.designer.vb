<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FManagerUtenti
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FManagerUtenti))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsUtenti = New System.Windows.Forms.ToolStrip()
        Me.tsbNuovo = New System.Windows.Forms.ToolStripButton()
        Me.tsbModifica = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbChiudi = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgvUtenti = New System.Windows.Forms.DataGridView()
        Me.bsUtenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.ilUsers = New System.Windows.Forms.ImageList(Me.components)
        Me.dgvcNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcUltimoAccesso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcNAccessi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcRuolo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcStato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tsUtenti.SuspendLayout()
        CType(Me.dgvUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsUtenti
        '
        Me.tsUtenti.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsUtenti.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.tsUtenti.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsUtenti.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsUtenti.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuovo, Me.tsbModifica, Me.tsbElimina, Me.ToolStripSeparator1, Me.tsbChiudi, Me.tsbStampa})
        Me.tsUtenti.Location = New System.Drawing.Point(0, 876)
        Me.tsUtenti.Name = "tsUtenti"
        Me.tsUtenti.Size = New System.Drawing.Size(1607, 45)
        Me.tsUtenti.TabIndex = 4
        Me.tsUtenti.Text = "ToolStrip1"
        '
        'tsbNuovo
        '
        Me.tsbNuovo.Image = Global.PoliecoSoci.My.Resources.Resources.Add_User_3_32_n_g
        Me.tsbNuovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbNuovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuovo.Name = "tsbNuovo"
        Me.tsbNuovo.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbNuovo.Size = New System.Drawing.Size(107, 42)
        Me.tsbNuovo.Text = "Nuovo"
        Me.tsbNuovo.ToolTipText = "Nuovo utente"
        '
        'tsbModifica
        '
        Me.tsbModifica.Image = Global.PoliecoSoci.My.Resources.Resources.Pencil_32_n_g
        Me.tsbModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbModifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModifica.Name = "tsbModifica"
        Me.tsbModifica.Size = New System.Drawing.Size(122, 42)
        Me.tsbModifica.Text = "Modifica"
        '
        'tsbElimina
        '
        Me.tsbElimina.Image = Global.PoliecoSoci.My.Resources.Resources.Delete_User_3_32_n_g
        Me.tsbElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimina.Name = "tsbElimina"
        Me.tsbElimina.Size = New System.Drawing.Size(112, 42)
        Me.tsbElimina.Text = "Elimina"
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
        'tsbStampa
        '
        Me.tsbStampa.Image = Global.PoliecoSoci.My.Resources.Resources.Printer_32_n_g
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(116, 42)
        Me.tsbStampa.Text = "Stampa"
        '
        'dgvUtenti
        '
        Me.dgvUtenti.AllowUserToAddRows = False
        Me.dgvUtenti.AllowUserToDeleteRows = False
        Me.dgvUtenti.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvUtenti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUtenti.AutoGenerateColumns = False
        Me.dgvUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUtenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUtenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcNome, Me.dgvcUltimoAccesso, Me.dgvcNAccessi, Me.dgvcRuolo, Me.dgvcStato})
        Me.dgvUtenti.DataSource = Me.bsUtenti
        Me.dgvUtenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUtenti.Location = New System.Drawing.Point(0, 0)
        Me.dgvUtenti.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvUtenti.Name = "dgvUtenti"
        Me.dgvUtenti.ReadOnly = True
        Me.dgvUtenti.RowHeadersVisible = False
        Me.dgvUtenti.RowHeadersWidth = 51
        Me.dgvUtenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUtenti.Size = New System.Drawing.Size(1607, 876)
        Me.dgvUtenti.TabIndex = 6
        '
        'ilUsers
        '
        Me.ilUsers.ImageStream = CType(resources.GetObject("ilUsers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilUsers.TransparentColor = System.Drawing.Color.Transparent
        Me.ilUsers.Images.SetKeyName(0, "NO-ATTIVO")
        Me.ilUsers.Images.SetKeyName(1, "PWD-OK")
        Me.ilUsers.Images.SetKeyName(2, "PWD-PROVVISORIA")
        '
        'dgvcNome
        '
        Me.dgvcNome.DataPropertyName = "Descrizione"
        Me.dgvcNome.HeaderText = "Nome"
        Me.dgvcNome.MinimumWidth = 6
        Me.dgvcNome.Name = "dgvcNome"
        Me.dgvcNome.ReadOnly = True
        '
        'dgvcUltimoAccesso
        '
        Me.dgvcUltimoAccesso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcUltimoAccesso.DataPropertyName = "DataAccesso"
        DataGridViewCellStyle2.Format = "G"
        Me.dgvcUltimoAccesso.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcUltimoAccesso.HeaderText = "Ultimo accesso"
        Me.dgvcUltimoAccesso.MinimumWidth = 6
        Me.dgvcUltimoAccesso.Name = "dgvcUltimoAccesso"
        Me.dgvcUltimoAccesso.ReadOnly = True
        Me.dgvcUltimoAccesso.Width = 350
        '
        'dgvcNAccessi
        '
        Me.dgvcNAccessi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcNAccessi.DataPropertyName = "NumeroAccessi"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgvcNAccessi.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcNAccessi.HeaderText = "Numero accessi"
        Me.dgvcNAccessi.MinimumWidth = 6
        Me.dgvcNAccessi.Name = "dgvcNAccessi"
        Me.dgvcNAccessi.ReadOnly = True
        Me.dgvcNAccessi.Width = 110
        '
        'dgvcRuolo
        '
        Me.dgvcRuolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcRuolo.DataPropertyName = "DescrRuoli"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcRuolo.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcRuolo.HeaderText = "Ruolo"
        Me.dgvcRuolo.MinimumWidth = 6
        Me.dgvcRuolo.Name = "dgvcRuolo"
        Me.dgvcRuolo.ReadOnly = True
        Me.dgvcRuolo.Width = 150
        '
        'dgvcStato
        '
        Me.dgvcStato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcStato.HeaderText = "Stato"
        Me.dgvcStato.MinimumWidth = 6
        Me.dgvcStato.Name = "dgvcStato"
        Me.dgvcStato.ReadOnly = True
        Me.dgvcStato.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcStato.Width = 80
        '
        'FManagerUtenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1607, 921)
        Me.Controls.Add(Me.dgvUtenti)
        Me.Controls.Add(Me.tsUtenti)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FManagerUtenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione utenti"
        Me.tsUtenti.ResumeLayout(False)
        Me.tsUtenti.PerformLayout()
        CType(Me.dgvUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsUtenti As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNuovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModifica As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbChiudi As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStampa As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvUtenti As System.Windows.Forms.DataGridView
    Friend WithEvents bsUtenti As System.Windows.Forms.BindingSource
    Friend WithEvents ilUsers As System.Windows.Forms.ImageList
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntePredefinitoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAccessiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoAccessoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcNome As DataGridViewTextBoxColumn
    Friend WithEvents dgvcUltimoAccesso As DataGridViewTextBoxColumn
    Friend WithEvents dgvcNAccessi As DataGridViewTextBoxColumn
    Friend WithEvents dgvcRuolo As DataGridViewTextBoxColumn
    Friend WithEvents dgvcStato As DataGridViewImageColumn
End Class
