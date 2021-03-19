<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mundo2
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
        Me.lblfala = New System.Windows.Forms.Label()
        Me.picbad = New System.Windows.Forms.PictureBox()
        Me.PicFala = New System.Windows.Forms.PictureBox()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bordertopleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderdownright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menustrip.SuspendLayout()
        CType(Me.mau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFala, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblfala
        '
        Me.lblfala.BackColor = System.Drawing.Color.Thistle
        Me.lblfala.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfala.Location = New System.Drawing.Point(40, 324)
        Me.lblfala.Name = "lblfala"
        Me.lblfala.Size = New System.Drawing.Size(1062, 101)
        Me.lblfala.TabIndex = 10
        Me.lblfala.Visible = False
        '
        'picbad
        '
        Me.picbad.Image = Global.DanFran_12ºA.My.Resources.Resources.antagonistcloseup
        Me.picbad.Location = New System.Drawing.Point(892, 95)
        Me.picbad.Name = "picbad"
        Me.picbad.Size = New System.Drawing.Size(251, 214)
        Me.picbad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbad.TabIndex = 11
        Me.picbad.TabStop = False
        Me.picbad.Visible = False
        '
        'PicFala
        '
        Me.PicFala.BackColor = System.Drawing.SystemColors.Control
        Me.PicFala.Image = Global.DanFran_12ºA.My.Resources.Resources.CaixaFalasMau2
        Me.PicFala.Location = New System.Drawing.Point(2, 311)
        Me.PicFala.Name = "PicFala"
        Me.PicFala.Size = New System.Drawing.Size(1141, 121)
        Me.PicFala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFala.TabIndex = 12
        Me.PicFala.TabStop = False
        '
        'Mundo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 434)
        Me.Controls.Add(Me.picbad)
        Me.Controls.Add(Me.lblfala)
        Me.Controls.Add(Me.PicFala)
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
        CType(Me.picbad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFala, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblfala As Label
    Friend WithEvents picbad As PictureBox
    Friend WithEvents PicFala As PictureBox
End Class
