Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProtocolloArxivar
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form.
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Protected WithEvents Txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txt = New System.Windows.Forms.TextBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.cmProfile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiPrFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrBarcode = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt
        '
        Me.Txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt.Location = New System.Drawing.Point(0, 0)
        Me.Txt.Name = "Txt"
        Me.Txt.Size = New System.Drawing.Size(192, 22)
        Me.Txt.TabIndex = 1
        '
        'BtnOpen
        '
        Me.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpen.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpen.Image = Global.PoliecoSoci.My.Resources.Resources.Arxivar16
        Me.BtnOpen.Location = New System.Drawing.Point(192, 0)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(20, 20)
        Me.BtnOpen.TabIndex = 2
        Me.TTip.SetToolTip(Me.BtnOpen, "Apri documento/i")
        '
        'btnProfile
        '
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Image = Global.PoliecoSoci.My.Resources.Resources.Save_Blue_16_n_g
        Me.btnProfile.Location = New System.Drawing.Point(212, 0)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(20, 20)
        Me.btnProfile.TabIndex = 3
        Me.TTip.SetToolTip(Me.btnProfile, "Avvia profilazione")
        '
        'cmProfile
        '
        Me.cmProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPrFile, Me.tsmiPrBarcode})
        Me.cmProfile.Name = "cmProfile"
        Me.cmProfile.Size = New System.Drawing.Size(134, 52)
        '
        'tsmiPrFile
        '
        Me.tsmiPrFile.Image = Global.PoliecoSoci.My.Resources.Resources.ArxProfile
        Me.tsmiPrFile.Name = "tsmiPrFile"
        Me.tsmiPrFile.Size = New System.Drawing.Size(133, 24)
        Me.tsmiPrFile.Text = "File"
        '
        'tsmiPrBarcode
        '
        Me.tsmiPrBarcode.Image = Global.PoliecoSoci.My.Resources.Resources.ArxBarcode
        Me.tsmiPrBarcode.Name = "tsmiPrBarcode"
        Me.tsmiPrBarcode.Size = New System.Drawing.Size(133, 24)
        Me.tsmiPrBarcode.Text = "Barcode"
        '
        'ucProtocolloArxivar
        '
        Me.Controls.Add(Me.Txt)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.btnProfile)
        Me.Name = "ucProtocolloArxivar"
        Me.Size = New System.Drawing.Size(232, 20)
        Me.cmProfile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents cmProfile As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiPrFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPrBarcode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTip As System.Windows.Forms.ToolTip

End Class
