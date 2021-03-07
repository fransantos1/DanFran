<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mundo2
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
        Me.components = New System.ComponentModel.Container()
        Me.lbllab = New System.Windows.Forms.Label()
        Me.lblrcade = New System.Windows.Forms.Label()
        Me.lblbiblio = New System.Windows.Forms.Label()
        Me.lblescola = New System.Windows.Forms.Label()
        Me.Ticks = New System.Windows.Forms.Timer(Me.components)
        Me.character = New System.Windows.Forms.PictureBox()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllab
        '
        Me.lbllab.Location = New System.Drawing.Point(208, 275)
        Me.lbllab.Name = "lbllab"
        Me.lbllab.Size = New System.Drawing.Size(47, 23)
        Me.lbllab.TabIndex = 0
        '
        'lblrcade
        '
        Me.lblrcade.Location = New System.Drawing.Point(388, 275)
        Me.lblrcade.Name = "lblrcade"
        Me.lblrcade.Size = New System.Drawing.Size(47, 23)
        Me.lblrcade.TabIndex = 1
        '
        'lblbiblio
        '
        Me.lblbiblio.Location = New System.Drawing.Point(704, 262)
        Me.lblbiblio.Name = "lblbiblio"
        Me.lblbiblio.Size = New System.Drawing.Size(47, 23)
        Me.lblbiblio.TabIndex = 2
        '
        'lblescola
        '
        Me.lblescola.Location = New System.Drawing.Point(950, 262)
        Me.lblescola.Name = "lblescola"
        Me.lblescola.Size = New System.Drawing.Size(47, 23)
        Me.lblescola.TabIndex = 3
        '
        'Ticks
        '
        Me.Ticks.Interval = 10
        '
        'character
        '
        Me.character.Location = New System.Drawing.Point(505, 294)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(100, 50)
        Me.character.TabIndex = 4
        Me.character.TabStop = False
        '
        'Mundo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.mapadef
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 453)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.lblescola)
        Me.Controls.Add(Me.lblbiblio)
        Me.Controls.Add(Me.lblrcade)
        Me.Controls.Add(Me.lbllab)
        Me.Name = "Mundo2"
        Me.Text = "Mundo2"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbllab As Label
    Friend WithEvents lblrcade As Label
    Friend WithEvents lblbiblio As Label
    Friend WithEvents lblescola As Label
    Friend WithEvents Ticks As Timer
    Friend WithEvents character As PictureBox
End Class
