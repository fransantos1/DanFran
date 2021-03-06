<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Blogin = New System.Windows.Forms.Button()
        Me.Bclose = New System.Windows.Forms.Button()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Blogin
        '
        Me.Blogin.Location = New System.Drawing.Point(9, 181)
        Me.Blogin.Name = "Blogin"
        Me.Blogin.Size = New System.Drawing.Size(75, 23)
        Me.Blogin.TabIndex = 0
        Me.Blogin.Text = "Login"
        Me.Blogin.UseVisualStyleBackColor = True
        '
        'Bclose
        '
        Me.Bclose.Location = New System.Drawing.Point(121, 181)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(75, 23)
        Me.Bclose.TabIndex = 1
        Me.Bclose.Text = "CLose"
        Me.Bclose.UseVisualStyleBackColor = True
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(12, 43)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxUser.TabIndex = 2
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.Location = New System.Drawing.Point(12, 22)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(72, 18)
        Me.Lbluser.TabIndex = 3
        Me.Lbluser.Text = "Username"
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpass.Location = New System.Drawing.Point(12, 97)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(72, 18)
        Me.Lblpass.TabIndex = 4
        Me.Lblpass.Text = "Password"
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(15, 118)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxPass.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 216)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.Lblpass)
        Me.Controls.Add(Me.Lbluser)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.Bclose)
        Me.Controls.Add(Me.Blogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Blogin As Button
    Friend WithEvents Bclose As Button
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Lbluser As Label
    Friend WithEvents Lblpass As Label
    Friend WithEvents TextBoxPass As TextBox
End Class
