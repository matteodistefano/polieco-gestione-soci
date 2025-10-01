<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEventSelector
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

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lDescrizione = New System.Windows.Forms.Label()
        Me.btnSel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lDescrizione
        '
        Me.lDescrizione.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lDescrizione.Location = New System.Drawing.Point(0, 0)
        Me.lDescrizione.Name = "lDescrizione"
        Me.lDescrizione.Size = New System.Drawing.Size(55, 28)
        Me.lDescrizione.TabIndex = 0
        Me.lDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSel
        '
        Me.btnSel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSel.Image = Global.PoliecoSoci.My.Resources.Resources.Down_16_n_g
        Me.btnSel.Location = New System.Drawing.Point(61, 0)
        Me.btnSel.Name = "btnSel"
        Me.btnSel.Size = New System.Drawing.Size(30, 28)
        Me.btnSel.TabIndex = 1
        Me.btnSel.UseVisualStyleBackColor = True
        '
        'ucEventSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSel)
        Me.Controls.Add(Me.lDescrizione)
        Me.Name = "ucEventSelector"
        Me.Size = New System.Drawing.Size(94, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lDescrizione As System.Windows.Forms.Label
    Friend WithEvents btnSel As System.Windows.Forms.Button

End Class
