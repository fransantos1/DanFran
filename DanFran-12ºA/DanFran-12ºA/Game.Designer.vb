<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.comms = New System.Windows.Forms.Label()
        Me.nextmessage = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextmessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DanFran_12ºA.My.Resources.Resources.finishedsdonecutscenegifstar
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(394, 617)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'comms
        '
        Me.comms.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.comms.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.comms.Location = New System.Drawing.Point(0, 611)
        Me.comms.Name = "comms"
        Me.comms.Size = New System.Drawing.Size(388, 150)
        Me.comms.TabIndex = 3
        '
        'nextmessage
        '
        Me.nextmessage.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.nextmessage.Image = Global.DanFran_12ºA.My.Resources.Resources.message
        Me.nextmessage.Location = New System.Drawing.Point(334, 704)
        Me.nextmessage.Name = "nextmessage"
        Me.nextmessage.Size = New System.Drawing.Size(35, 35)
        Me.nextmessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nextmessage.TabIndex = 4
        Me.nextmessage.TabStop = False
        '
        'Time
        '
        '
        'Game
        '
        Me.ClientSize = New System.Drawing.Size(381, 751)
        Me.Controls.Add(Me.nextmessage)
        Me.Controls.Add(Me.comms)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextmessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dialog As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents messageprovider As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents comms As Label
    Friend WithEvents nextmessage As PictureBox
    Friend WithEvents Time As Timer
End Class
