﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bordertopleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderdownright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menustrip.SuspendLayout()
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
        Me.character.Image = Global.DanFran_12ºA.My.Resources.Resources.Character
        Me.character.Location = New System.Drawing.Point(550, 268)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(26, 50)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.character.TabIndex = 4
        Me.character.TabStop = False
        '
        'Bordertopleft
        '
        Me.Bordertopleft.Location = New System.Drawing.Point(92, 144)
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
        'Mundo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 434)
        Me.Controls.Add(Me.borderdownright)
        Me.Controls.Add(Me.Bordertopleft)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.lblescola)
        Me.Controls.Add(Me.lblbiblio)
        Me.Controls.Add(Me.lblrcade)
        Me.Controls.Add(Me.lbllab)
        Me.Controls.Add(Me.Menustrip)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.Menustrip
        Me.Name = "Mundo2"
        Me.Text = "Mundo2"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bordertopleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderdownright, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menustrip.ResumeLayout(False)
        Me.Menustrip.PerformLayout()
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
End Class
