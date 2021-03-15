<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trivia
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
        Me.CBvila = New System.Windows.Forms.ComboBox()
        Me.ListBNomes = New System.Windows.Forms.ListBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.correct = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Binserir = New System.Windows.Forms.Button()
        Me.BLimpar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBvila
        '
        Me.CBvila.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBvila.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBvila.FormattingEnabled = True
        Me.CBvila.Location = New System.Drawing.Point(803, 173)
        Me.CBvila.Name = "CBvila"
        Me.CBvila.Size = New System.Drawing.Size(237, 31)
        Me.CBvila.TabIndex = 0
        '
        'ListBNomes
        '
        Me.ListBNomes.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBNomes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBNomes.ForeColor = System.Drawing.Color.White
        Me.ListBNomes.FormattingEnabled = True
        Me.ListBNomes.ItemHeight = 15
        Me.ListBNomes.Location = New System.Drawing.Point(537, 158)
        Me.ListBNomes.Name = "ListBNomes"
        Me.ListBNomes.Size = New System.Drawing.Size(116, 79)
        Me.ListBNomes.TabIndex = 1
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(15, 27)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(63, 25)
        Me.Chk1.TabIndex = 2
        Me.Chk1.Text = "2:00"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Chk3)
        Me.GroupBox1.Controls.Add(Me.correct)
        Me.GroupBox1.Controls.Add(Me.Chk1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(85, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolha uma opção"
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Location = New System.Drawing.Point(15, 83)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(72, 25)
        Me.Chk3.TabIndex = 5
        Me.Chk3.Text = "23:00"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'correct
        '
        Me.correct.AutoSize = True
        Me.correct.Location = New System.Drawing.Point(15, 54)
        Me.correct.Name = "correct"
        Me.correct.Size = New System.Drawing.Size(72, 25)
        Me.correct.TabIndex = 5
        Me.correct.Text = "15:00"
        Me.correct.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(798, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Qual é o nome desta vila?"
        '
        'txtnomes
        '
        Me.txtnomes.Location = New System.Drawing.Point(537, 132)
        Me.txtnomes.Name = "txtnomes"
        Me.txtnomes.Size = New System.Drawing.Size(116, 20)
        Me.txtnomes.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(417, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 86)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Carregue os nomes dos seguintes criminosos para a base de dados:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(420, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "João do Pão"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(418, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Belzebu Mário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(417, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Serafim Perlimpimpim "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(505, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Insira aqui os nomes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(993, 27)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "A bibliotecária precisa da tua ajuda para completar o seu trabalho. Completa as s" &
    "eguintes tarefas para a ajudar."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(989, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 27)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Que horas são?"
        '
        'Binserir
        '
        Me.Binserir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Binserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Binserir.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Binserir.Location = New System.Drawing.Point(603, 241)
        Me.Binserir.Name = "Binserir"
        Me.Binserir.Size = New System.Drawing.Size(50, 23)
        Me.Binserir.TabIndex = 14
        Me.Binserir.Text = "Inserir"
        Me.Binserir.UseVisualStyleBackColor = False
        '
        'BLimpar
        '
        Me.BLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLimpar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpar.Location = New System.Drawing.Point(548, 242)
        Me.BLimpar.Name = "BLimpar"
        Me.BLimpar.Size = New System.Drawing.Size(50, 23)
        Me.BLimpar.TabIndex = 15
        Me.BLimpar.Text = "Limpar"
        Me.BLimpar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(418, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "(não obrigatório)"
        '
        'Trivia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.triviabg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 416)
        Me.Controls.Add(Me.BLimpar)
        Me.Controls.Add(Me.Binserir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnomes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBNomes)
        Me.Controls.Add(Me.CBvila)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Trivia"
        Me.Text = "Trivia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBvila As ComboBox
    Friend WithEvents ListBNomes As ListBox
    Friend WithEvents Chk1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Chk3 As CheckBox
    Friend WithEvents correct As CheckBox
    Friend WithEvents txtnomes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Binserir As Button
    Friend WithEvents BLimpar As Button
    Friend WithEvents Label9 As Label
End Class
