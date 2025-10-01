<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLicenza
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lAzienda = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.bsData = New System.Windows.Forms.BindingSource(Me.components)
        Me.lLogo = New System.Windows.Forms.Label()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbOk = New System.Windows.Forms.ToolStripButton()
        Me.txtDataRichiesta = New mdsUIControls.mdsDate()
        Me.txtDataScadenza = New mdsUIControls.mdsDate()
        Me.txtDataRicevuta = New mdsUIControls.mdsDate()
        Me.tsMain.SuspendLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.AutoSize = False
        Me.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbOk})
        Me.tsMain.Location = New System.Drawing.Point(0, 293)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(804, 37)
        Me.tsMain.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Azienda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo"
        '
        'lAzienda
        '
        Me.lAzienda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lAzienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lAzienda.Location = New System.Drawing.Point(75, 9)
        Me.lAzienda.Name = "lAzienda"
        Me.lAzienda.Size = New System.Drawing.Size(678, 32)
        Me.lAzienda.TabIndex = 0
        '
        'cbTipo
        '
        Me.cbTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsData, "CodLicenza", True))
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(75, 60)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(305, 21)
        Me.cbTipo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Data richiesta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data scadenza"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(412, 90)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 13)
        Me.Label32.TabIndex = 49
        Me.Label32.Text = "Data ricevuta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsData, "Note", True))
        Me.txtNote.Location = New System.Drawing.Point(74, 130)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(717, 148)
        Me.txtNote.TabIndex = 58
        '
        'lLogo
        '
        Me.lLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lLogo.Image = Global.PoliecoSoci.My.Resources.Resources.Certificate_32_n_g
        Me.lLogo.Location = New System.Drawing.Point(759, 9)
        Me.lLogo.Name = "lLogo"
        Me.lLogo.Size = New System.Drawing.Size(32, 32)
        Me.lLogo.TabIndex = 53
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_24_n_g
        Me.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbExit.Size = New System.Drawing.Size(80, 34)
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
        Me.tsbOk.Size = New System.Drawing.Size(54, 34)
        Me.tsbOk.Text = "Ok"
        '
        'txtDataRichiesta
        '
        Me.txtDataRichiesta.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataRichiesta", True))
        Me.txtDataRichiesta.DateFormat = Nothing
        Me.txtDataRichiesta.DateValue = Nothing
        Me.txtDataRichiesta.IsReadOnly = False
        Me.txtDataRichiesta.Location = New System.Drawing.Point(75, 87)
        Me.txtDataRichiesta.Name = "txtDataRichiesta"
        Me.txtDataRichiesta.SetNullDateToDbNull = False
        Me.txtDataRichiesta.Size = New System.Drawing.Size(100, 20)
        Me.txtDataRichiesta.TabIndex = 59
        '
        'txtDataScadenza
        '
        Me.txtDataScadenza.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataScadenza", True))
        Me.txtDataScadenza.DateFormat = Nothing
        Me.txtDataScadenza.DateValue = Nothing
        Me.txtDataScadenza.IsReadOnly = False
        Me.txtDataScadenza.Location = New System.Drawing.Point(280, 87)
        Me.txtDataScadenza.Name = "txtDataScadenza"
        Me.txtDataScadenza.SetNullDateToDbNull = False
        Me.txtDataScadenza.Size = New System.Drawing.Size(100, 20)
        Me.txtDataScadenza.TabIndex = 60
        '
        'txtDataRicevuta
        '
        Me.txtDataRicevuta.DataBindings.Add(New System.Windows.Forms.Binding("DateValue", Me.bsData, "DataRicevuta", True))
        Me.txtDataRicevuta.DateFormat = Nothing
        Me.txtDataRicevuta.DateValue = Nothing
        Me.txtDataRicevuta.IsReadOnly = False
        Me.txtDataRicevuta.Location = New System.Drawing.Point(489, 87)
        Me.txtDataRicevuta.Name = "txtDataRicevuta"
        Me.txtDataRicevuta.SetNullDateToDbNull = False
        Me.txtDataRicevuta.Size = New System.Drawing.Size(100, 20)
        Me.txtDataRicevuta.TabIndex = 61
        '
        'dlgContatto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 330)
        Me.Controls.Add(Me.txtDataRicevuta)
        Me.Controls.Add(Me.txtDataScadenza)
        Me.Controls.Add(Me.txtDataRichiesta)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lLogo)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lAzienda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgContatto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licenza"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        CType(Me.bsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOk As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bsData As System.Windows.Forms.BindingSource
    Friend WithEvents lAzienda As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lLogo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtDataRichiesta As mdsUIControls.mdsDate
    Friend WithEvents txtDataScadenza As mdsUIControls.mdsDate
    Friend WithEvents txtDataRicevuta As mdsUIControls.mdsDate
End Class
