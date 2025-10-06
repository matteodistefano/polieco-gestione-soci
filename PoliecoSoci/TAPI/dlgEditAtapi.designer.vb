<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEditAtapi
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
        Me.cbLinee = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbLinee
        '
        Me.cbLinee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLinee.FormattingEnabled = True
        Me.cbLinee.Location = New System.Drawing.Point(94, 22)
        Me.cbLinee.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbLinee.Name = "cbLinee"
        Me.cbLinee.Size = New System.Drawing.Size(719, 32)
        Me.cbLinee.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Linea"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(529, 96)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(138, 42)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(678, 96)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(138, 42)
        Me.btnUndo.TabIndex = 3
        Me.btnUndo.Text = "Annulla"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'dlgEditAtapi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 160)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbLinee)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgEditAtapi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impostazione linea TAPI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbLinee As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
End Class
