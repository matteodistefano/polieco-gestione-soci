<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAcquisisciAdesione
    Inherits System.Windows.Forms.Form

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
        Dim QualificaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.tsbAnalizza = New System.Windows.Forms.ToolStripButton()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.ucFile = New mdsUIControls.ucFileSel()
        Me.dgvDati = New System.Windows.Forms.DataGridView()
        Me.dgvcProprieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcValore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsbCrea = New System.Windows.Forms.ToolStripButton()
        QualificaLabel = New System.Windows.Forms.Label()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgvDati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QualificaLabel
        '
        QualificaLabel.AutoSize = True
        QualificaLabel.Location = New System.Drawing.Point(9, 12)
        QualificaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        QualificaLabel.Name = "QualificaLabel"
        QualificaLabel.Size = New System.Drawing.Size(72, 13)
        QualificaLabel.TabIndex = 5
        QualificaLabel.Text = "File adesione:"
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbClose, Me.tsbAnalizza, Me.tsbCrea})
        Me.tsMain.Location = New System.Drawing.Point(0, 343)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(736, 37)
        Me.tsMain.TabIndex = 36
        '
        'tsbClose
        '
        Me.tsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbClose.Image = Global.PoliecoSoci.My.Resources.Resources.SE_Arrow_24_n_g
        Me.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbClose.Size = New System.Drawing.Size(74, 34)
        Me.tsbClose.Text = "Chiudi"
        '
        'tsbAnalizza
        '
        Me.tsbAnalizza.Image = Global.PoliecoSoci.My.Resources.Resources.Search_32_n_g
        Me.tsbAnalizza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAnalizza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnalizza.Name = "tsbAnalizza"
        Me.tsbAnalizza.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbAnalizza.Size = New System.Drawing.Size(90, 34)
        Me.tsbAnalizza.Text = "Analizza"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.ucFile)
        Me.pnlTop.Controls.Add(QualificaLabel)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(736, 46)
        Me.pnlTop.TabIndex = 38
        '
        'ucFile
        '
        Me.ucFile.BackColorTxt = System.Drawing.SystemColors.Window
        Me.ucFile.Location = New System.Drawing.Point(85, 11)
        Me.ucFile.Margin = New System.Windows.Forms.Padding(2)
        Me.ucFile.Name = "ucFile"
        Me.ucFile.ReadOnly = False
        Me.ucFile.Size = New System.Drawing.Size(640, 22)
        Me.ucFile.TabIndex = 6
        Me.ucFile.TipoRicerca = mdsUIControls.ucFileSel.tagTipoRicerca.TP_FILE_OPEN
        '
        'dgvDati
        '
        Me.dgvDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDati.ColumnHeadersVisible = False
        Me.dgvDati.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcProprieta, Me.dgvcValore})
        Me.dgvDati.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDati.Location = New System.Drawing.Point(0, 46)
        Me.dgvDati.Name = "dgvDati"
        Me.dgvDati.RowHeadersVisible = False
        Me.dgvDati.Size = New System.Drawing.Size(736, 297)
        Me.dgvDati.TabIndex = 39
        '
        'dgvcProprieta
        '
        Me.dgvcProprieta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgvcProprieta.DataPropertyName = "Proprieta"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvcProprieta.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcProprieta.HeaderText = "Proprieta"
        Me.dgvcProprieta.Name = "dgvcProprieta"
        Me.dgvcProprieta.ReadOnly = True
        Me.dgvcProprieta.Width = 200
        '
        'dgvcValore
        '
        Me.dgvcValore.DataPropertyName = "Valore"
        Me.dgvcValore.HeaderText = "Valore"
        Me.dgvcValore.Name = "dgvcValore"
        Me.dgvcValore.ReadOnly = True
        '
        'tsbCrea
        '
        Me.tsbCrea.Image = Global.PoliecoSoci.My.Resources.Resources.Database_Check_In_32_n_g
        Me.tsbCrea.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCrea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCrea.Name = "tsbCrea"
        Me.tsbCrea.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbCrea.Size = New System.Drawing.Size(131, 34)
        Me.tsbCrea.Text = "Acquisisci socio"
        '
        'dlgAcquisisciAdesione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 380)
        Me.Controls.Add(Me.dgvDati)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgAcquisisciAdesione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acquisizione adesione"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgvDati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents ucFile As mdsUIControls.ucFileSel
    Friend WithEvents tsbAnalizza As ToolStripButton
    Friend WithEvents dgvDati As DataGridView
    Friend WithEvents dgvcProprieta As DataGridViewTextBoxColumn
    Friend WithEvents dgvcValore As DataGridViewTextBoxColumn
    Friend WithEvents tsbCrea As ToolStripButton
End Class
