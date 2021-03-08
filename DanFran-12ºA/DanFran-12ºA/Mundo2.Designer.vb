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
        Me.Borderleft = New System.Windows.Forms.PictureBox()
        Me.borderup = New System.Windows.Forms.PictureBox()
        Me.Menustrip = New System.Windows.Forms.MenuStrip()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BibliotecaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borderleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbllab
        '
        Me.lbllab.Location = New System.Drawing.Point(207, 262)
        Me.lbllab.Name = "lbllab"
        Me.lbllab.Size = New System.Drawing.Size(47, 23)
        Me.lbllab.TabIndex = 0
        '
        'lblrcade
        '
        Me.lblrcade.Location = New System.Drawing.Point(383, 262)
        Me.lblrcade.Name = "lblrcade"
        Me.lblrcade.Size = New System.Drawing.Size(47, 23)
        Me.lblrcade.TabIndex = 1
        '
        'lblbiblio
        '
        Me.lblbiblio.Location = New System.Drawing.Point(703, 250)
        Me.lblbiblio.Name = "lblbiblio"
        Me.lblbiblio.Size = New System.Drawing.Size(47, 23)
        Me.lblbiblio.TabIndex = 2
        '
        'lblescola
        '
        Me.lblescola.Location = New System.Drawing.Point(954, 250)
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
        Me.character.Location = New System.Drawing.Point(422, 316)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(54, 50)
        Me.character.TabIndex = 4
        Me.character.TabStop = False
        '
        'Borderleft
        '
        Me.Borderleft.Location = New System.Drawing.Point(43, 399)
        Me.Borderleft.Name = "Borderleft"
        Me.Borderleft.Size = New System.Drawing.Size(49, 41)
        Me.Borderleft.TabIndex = 5
        Me.Borderleft.TabStop = False
        Me.Borderleft.Visible = False
        '
        'borderup
        '
        Me.borderup.Location = New System.Drawing.Point(1071, 218)
        Me.borderup.Name = "borderup"
        Me.borderup.Size = New System.Drawing.Size(42, 41)
        Me.borderup.TabIndex = 6
        Me.borderup.TabStop = False
        Me.borderup.Visible = False
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
        'LabToolStripMenuItem
        '
        Me.LabToolStripMenuItem.Name = "LabToolStripMenuItem"
        Me.LabToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LabToolStripMenuItem.Text = "Lab"
        '
        'ArcadeToolStripMenuItem
        '
        Me.ArcadeToolStripMenuItem.Name = "ArcadeToolStripMenuItem"
        Me.ArcadeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArcadeToolStripMenuItem.Text = "Arcade"
        '
        'BibliotecaToolStripMenuItem
        '
        Me.BibliotecaToolStripMenuItem.Name = "BibliotecaToolStripMenuItem"
        Me.BibliotecaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BibliotecaToolStripMenuItem.Text = "Biblioteca"
        '
        'EscolaToolStripMenuItem
        '
        Me.EscolaToolStripMenuItem.Name = "EscolaToolStripMenuItem"
        Me.EscolaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EscolaToolStripMenuItem.Text = "Escola"
        '
        'Mundo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DanFran_12ºA.My.Resources.Resources.mapadef
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 434)
        Me.Controls.Add(Me.borderup)
        Me.Controls.Add(Me.Borderleft)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.lblescola)
        Me.Controls.Add(Me.lblbiblio)
        Me.Controls.Add(Me.lblrcade)
        Me.Controls.Add(Me.lbllab)
        Me.Controls.Add(Me.Menustrip)
        Me.MainMenuStrip = Me.Menustrip
        Me.Name = "Mundo2"
        Me.Text = "Mundo2"
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borderleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderup, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Borderleft As PictureBox
    Friend WithEvents borderup As PictureBox
    Friend WithEvents Menustrip As MenuStrip
    Friend WithEvents OpçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArcadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BibliotecaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscolaToolStripMenuItem As ToolStripMenuItem
End Class
