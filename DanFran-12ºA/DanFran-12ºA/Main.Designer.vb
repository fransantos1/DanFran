﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RosyBrown
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(-16, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(629, 111)
        Me.Label1.TabIndex = 0
        '
        'BJogar
        '
        Me.BJogar.BackColor = System.Drawing.Color.MistyRose
        Me.BJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BJogar.Font = New System.Drawing.Font("Gadugi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BJogar.Location = New System.Drawing.Point(434, 230)
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
        Me.Bregras.Location = New System.Drawing.Point(319, 259)
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
        Me.BSair.Location = New System.Drawing.Point(12, 265)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(109, 37)
        Me.BSair.TabIndex = 3
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 314)
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
End Class
