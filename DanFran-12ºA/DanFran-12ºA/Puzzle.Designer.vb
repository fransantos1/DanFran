<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puzzle
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
        Me.RBA = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RBB = New System.Windows.Forms.RadioButton()
        Me.RBC = New System.Windows.Forms.RadioButton()
        Me.RBD = New System.Windows.Forms.RadioButton()
        Me.RBE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBA
        '
        Me.RBA.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.puzzleA
        Me.RBA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBA.Location = New System.Drawing.Point(30, 22)
        Me.RBA.Name = "RBA"
        Me.RBA.Size = New System.Drawing.Size(106, 98)
        Me.RBA.TabIndex = 0
        Me.RBA.TabStop = True
        Me.RBA.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.DanFran_12ºA.My.Resources.Resources.tubarao
        Me.PictureBox1.Location = New System.Drawing.Point(298, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RBB
        '
        Me.RBB.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.puzzleB
        Me.RBB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBB.Location = New System.Drawing.Point(30, 126)
        Me.RBB.Name = "RBB"
        Me.RBB.Size = New System.Drawing.Size(106, 98)
        Me.RBB.TabIndex = 2
        Me.RBB.TabStop = True
        Me.RBB.UseVisualStyleBackColor = True
        '
        'RBC
        '
        Me.RBC.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.puzzleC
        Me.RBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBC.Location = New System.Drawing.Point(30, 230)
        Me.RBC.Name = "RBC"
        Me.RBC.Size = New System.Drawing.Size(106, 98)
        Me.RBC.TabIndex = 3
        Me.RBC.TabStop = True
        Me.RBC.UseVisualStyleBackColor = True
        '
        'RBD
        '
        Me.RBD.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.puzzleD
        Me.RBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBD.Location = New System.Drawing.Point(163, 71)
        Me.RBD.Name = "RBD"
        Me.RBD.Size = New System.Drawing.Size(106, 98)
        Me.RBD.TabIndex = 4
        Me.RBD.TabStop = True
        Me.RBD.UseVisualStyleBackColor = True
        '
        'RBE
        '
        Me.RBE.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.puzzleE
        Me.RBE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBE.Location = New System.Drawing.Point(163, 175)
        Me.RBE.Name = "RBE"
        Me.RBE.Size = New System.Drawing.Size(106, 98)
        Me.RBE.TabIndex = 5
        Me.RBE.TabStop = True
        Me.RBE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Qual das opções completa corretamente o puzzle?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(170, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Puzzle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(726, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RBE)
        Me.Controls.Add(Me.RBD)
        Me.Controls.Add(Me.RBC)
        Me.Controls.Add(Me.RBB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RBA)
        Me.Name = "Puzzle"
        Me.Text = "Puzzle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBA As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBB As RadioButton
    Friend WithEvents RBC As RadioButton
    Friend WithEvents RBD As RadioButton
    Friend WithEvents RBE As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
