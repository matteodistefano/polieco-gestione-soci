<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lTitle = New System.Windows.Forms.Label()
        Me.lCredits = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lTitle
        '
        Me.lTitle.AutoSize = True
        Me.lTitle.BackColor = System.Drawing.Color.Transparent
        Me.lTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lTitle.Location = New System.Drawing.Point(4, 374)
        Me.lTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lTitle.Name = "lTitle"
        Me.lTitle.Size = New System.Drawing.Size(404, 69)
        Me.lTitle.TabIndex = 0
        Me.lTitle.Text = "Gestione soci"
        '
        'lCredits
        '
        Me.lCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lCredits.BackColor = System.Drawing.Color.Transparent
        Me.lCredits.Location = New System.Drawing.Point(407, 496)
        Me.lCredits.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lCredits.Name = "lCredits"
        Me.lCredits.Size = New System.Drawing.Size(490, 42)
        Me.lCredits.TabIndex = 1
        Me.lCredits.Text = "Versione 1.1.1.1 - Copyright Matteo Di Stefano 2013"
        Me.lCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(610, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(610, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(616, 56)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(269, 32)
        Me.txtUser.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(616, 128)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(269, 32)
        Me.txtPassword.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Image = Global.PoliecoSoci.My.Resources.Resources.OK_32_n_g
        Me.btnOk.Location = New System.Drawing.Point(776, 176)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(51, 42)
        Me.btnOk.TabIndex = 2
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Image = Global.PoliecoSoci.My.Resources.Resources.Undo_32_n_g
        Me.btnUndo.Location = New System.Drawing.Point(837, 176)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(51, 42)
        Me.btnUndo.TabIndex = 3
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLog.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtLog.Location = New System.Drawing.Point(616, 230)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(278, 250)
        Me.txtLog.TabIndex = 8
        Me.txtLog.Visible = False
        '
        'dlgSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PoliecoSoci.My.Resources.Resources.Splash2020
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(918, 555)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lCredits)
        Me.Controls.Add(Me.lTitle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dlgSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgSplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lTitle As System.Windows.Forms.Label
    Friend WithEvents lCredits As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
End Class
