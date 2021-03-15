<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BJogar = New System.Windows.Forms.Button()
        Me.Bregras = New System.Windows.Forms.Button()
        Me.BSair = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(2, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(789, 119)
        Me.Label1.TabIndex = 0
        '
        'BJogar
        '
        Me.BJogar.BackColor = System.Drawing.Color.MistyRose
        Me.BJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BJogar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BJogar.Location = New System.Drawing.Point(627, 282)
        Me.BJogar.Name = "BJogar"
        Me.BJogar.Size = New System.Drawing.Size(151, 72)
        Me.BJogar.TabIndex = 1
        Me.BJogar.Text = "Jogar"
        Me.BJogar.UseVisualStyleBackColor = False
        '
        'Bregras
        '
        Me.Bregras.BackColor = System.Drawing.Color.MistyRose
        Me.Bregras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bregras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bregras.Location = New System.Drawing.Point(512, 311)
        Me.Bregras.Name = "Bregras"
        Me.Bregras.Size = New System.Drawing.Size(109, 43)
        Me.Bregras.TabIndex = 2
        Me.Bregras.Text = "Regras"
        Me.Bregras.UseVisualStyleBackColor = False
        '
        'BSair
        '
        Me.BSair.BackColor = System.Drawing.Color.MistyRose
        Me.BSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSair.Location = New System.Drawing.Point(12, 317)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(109, 37)
        Me.BSair.TabIndex = 3
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.LightSeaGreen
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 377)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.Bregras)
        Me.Controls.Add(Me.BJogar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BJogar As Button
    Friend WithEvents Bregras As Button
    Friend WithEvents BSair As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
