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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mundo2))
        Me.lbllab = New System.Windows.Forms.Label()
        Me.lblrcade = New System.Windows.Forms.Label()
        Me.lblbiblio = New System.Windows.Forms.Label()
        Me.lblescola = New System.Windows.Forms.Label()
        Me.Ticks = New System.Windows.Forms.Timer(Me.components)
        Me.character = New System.Windows.Forms.PictureBox()
        Me.Bordertopleft = New System.Windows.Forms.PictureBox()
        Me.borderdownright = New System.Windows.Forms.PictureBox()
        Me.Menustrip = New System.Windows.Forms.MenuStrip()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gamprogress = New System.Windows.Forms.ProgressBar()
        Me.mau = New System.Windows.Forms.PictureBox()
        Me.badpic = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblConversa = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonMundo3 = New System.Windows.Forms.Button()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bordertopleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderdownright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menustrip.SuspendLayout()
        CType(Me.mau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.badpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbllab
        '
        Me.lbllab.Location = New System.Drawing.Point(231, 236)
        Me.lbllab.Name = "lbllab"
        Me.lbllab.Size = New System.Drawing.Size(47, 23)
        Me.lbllab.TabIndex = 0
        '
        'lblrcade
        '
        Me.lblrcade.Location = New System.Drawing.Point(399, 236)
        Me.lblrcade.Name = "lblrcade"
        Me.lblrcade.Size = New System.Drawing.Size(47, 23)
        Me.lblrcade.TabIndex = 1
        '
        'lblbiblio
        '
        Me.lblbiblio.Location = New System.Drawing.Point(699, 218)
        Me.lblbiblio.Name = "lblbiblio"
        Me.lblbiblio.Size = New System.Drawing.Size(47, 23)
        Me.lblbiblio.TabIndex = 2
        '
        'lblescola
        '
        Me.lblescola.Location = New System.Drawing.Point(938, 218)
        Me.lblescola.Name = "lblescola"
        Me.lblescola.Size = New System.Drawing.Size(36, 23)
        Me.lblescola.TabIndex = 3
        '
        'Ticks
        '
        Me.Ticks.Interval = 10
        '
        'character
        '
        Me.character.BackColor = System.Drawing.Color.Transparent
        Me.character.Image = Global.DanFran_12ºA.My.Resources.Resources.Character
        Me.character.Location = New System.Drawing.Point(402, 273)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(26, 50)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.character.TabIndex = 4
        Me.character.TabStop = False
        '
        'Bordertopleft
        '
        Me.Bordertopleft.Location = New System.Drawing.Point(89, 170)
        Me.Bordertopleft.Name = "Bordertopleft"
        Me.Bordertopleft.Size = New System.Drawing.Size(49, 41)
        Me.Bordertopleft.TabIndex = 5
        Me.Bordertopleft.TabStop = False
        Me.Bordertopleft.Visible = False
        '
        'borderdownright
        '
        Me.borderdownright.Location = New System.Drawing.Point(1089, 324)
        Me.borderdownright.Name = "borderdownright"
        Me.borderdownright.Size = New System.Drawing.Size(42, 41)
        Me.borderdownright.TabIndex = 6
        Me.borderdownright.TabStop = False
        Me.borderdownright.Visible = False
        '
        'Menustrip
        '
        Me.Menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpçõesToolStripMenuItem, Me.AutoresToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.Menustrip.Location = New System.Drawing.Point(0, 0)
        Me.Menustrip.Name = "Menustrip"
        Me.Menustrip.Size = New System.Drawing.Size(1143, 24)
        Me.Menustrip.TabIndex = 7
        Me.Menustrip.Text = "MenuStrip1"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabToolStripMenuItem, Me.ArcadeToolStripMenuItem, Me.BibliotecaToolStripMenuItem, Me.EscolaToolStripMenuItem})
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OpçõesToolStripMenuItem.Text = "Jogos"
        '
        'LabToolStripMenuItem
        '
        Me.LabToolStripMenuItem.Name = "LabToolStripMenuItem"
        Me.LabToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LabToolStripMenuItem.Text = "Lab"
        '
        'ArcadeToolStripMenuItem
        '
        Me.ArcadeToolStripMenuItem.Name = "ArcadeToolStripMenuItem"
        Me.ArcadeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ArcadeToolStripMenuItem.Text = "Arcade"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'EscolaToolStripMenuItem
        '
        Me.EscolaToolStripMenuItem.Name = "EscolaToolStripMenuItem"
        Me.EscolaToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EscolaToolStripMenuItem.Text = "Escola"
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AutoresToolStripMenuItem.Text = "Autores"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'gamprogress
        '
        Me.gamprogress.Location = New System.Drawing.Point(402, 399)
        Me.gamprogress.Name = "gamprogress"
        Me.gamprogress.Size = New System.Drawing.Size(344, 23)
        Me.gamprogress.TabIndex = 8
        '
        'mau
        '
        Me.mau.BackColor = System.Drawing.Color.Transparent
        Me.mau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mau.Image = Global.DanFran_12ºA.My.Resources.Resources.antagonist
        Me.mau.Location = New System.Drawing.Point(560, 202)
        Me.mau.Name = "mau"
        Me.mau.Size = New System.Drawing.Size(93, 57)
        Me.mau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mau.TabIndex = 9
        Me.mau.TabStop = False
        '
        'badpic
        '
        Me.badpic.BackColor = System.Drawing.Color.Transparent
        Me.badpic.Image = Global.DanFran_12ºA.My.Resources.Resources.antagonistcloseup
        Me.badpic.Location = New System.Drawing.Point(914, 3)
        Me.badpic.Name = "badpic"
        Me.badpic.Size = New System.Drawing.Size(205, 186)
        Me.badpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.badpic.TabIndex = 10
        Me.badpic.TabStop = False
        Me.badpic.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonMundo3)
        Me.Panel1.Controls.Add(Me.ButtonOK)
        Me.Panel1.Controls.Add(Me.LblConversa)
        Me.Panel1.Controls.Add(Me.badpic)
        Me.Panel1.Location = New System.Drawing.Point(12, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1119, 295)
        Me.Panel1.TabIndex = 11
        '
        'LblConversa
        '
        Me.LblConversa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblConversa.Location = New System.Drawing.Point(3, 199)
        Me.LblConversa.Name = "LblConversa"
        Me.LblConversa.Size = New System.Drawing.Size(1113, 89)
        Me.LblConversa.TabIndex = 11
        Me.LblConversa.Text = "Label1"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(819, 239)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(67, 33)
        Me.ButtonOK.TabIndex = 12
        Me.ButtonOK.Text = "ok"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonMundo3
        '
        Me.ButtonMundo3.Location = New System.Drawing.Point(641, 243)
        Me.ButtonMundo3.Name = "ButtonMundo3"
        Me.ButtonMundo3.Size = New System.Drawing.Size(72, 29)
        Me.ButtonMundo3.TabIndex = 13
        Me.ButtonMundo3.Text = "vais"
        Me.ButtonMundo3.UseVisualStyleBackColor = True
        '
        'Mundo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 434)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gamprogress)
        Me.Controls.Add(Me.borderdownright)
        Me.Controls.Add(Me.Bordertopleft)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.lblescola)
        Me.Controls.Add(Me.lblbiblio)
        Me.Controls.Add(Me.lblrcade)
        Me.Controls.Add(Me.lbllab)
        Me.Controls.Add(Me.Menustrip)
        Me.Controls.Add(Me.mau)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menustrip
        Me.Name = "Mundo2"
        Me.Text = "Mundo2"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bordertopleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderdownright, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menustrip.ResumeLayout(False)
        Me.Menustrip.PerformLayout()
        CType(Me.mau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.badpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbllab As Label
    Friend WithEvents lblrcade As Label
    Friend WithEvents lblbiblio As Label
    Friend WithEvents lblescola As Label
    Friend WithEvents Ticks As Timer
    Friend WithEvents character As PictureBox
    Friend WithEvents Bordertopleft As PictureBox
    Friend WithEvents borderdownright As PictureBox
    Friend WithEvents Menustrip As MenuStrip
    Friend WithEvents OpçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArcadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gamprogress As ProgressBar
    Friend WithEvents mau As PictureBox
    Friend WithEvents badpic As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblConversa As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonMundo3 As Button
End Class
