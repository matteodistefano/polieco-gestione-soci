<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTest
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
        Me.UcEventSelector1 = New PoliecoSoci.ucEventSelector()
        Me.SuspendLayout()
        '
        'UcEventSelector1
        '
        Me.UcEventSelector1.DropDownAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.UcEventSelector1.Location = New System.Drawing.Point(46, 76)
        Me.UcEventSelector1.ManualOnly = False
        Me.UcEventSelector1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcEventSelector1.Name = "UcEventSelector1"
        Me.UcEventSelector1.SelectedCode = ""
        Me.UcEventSelector1.SelectedEvent = Nothing
        Me.UcEventSelector1.Size = New System.Drawing.Size(532, 42)
        Me.UcEventSelector1.TabIndex = 0
        '
        'FTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 627)
        Me.Controls.Add(Me.UcEventSelector1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FTest"
        Me.Text = "FTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcEventSelector1 As PoliecoSoci.ucEventSelector
End Class
