Public Class Pok_Man
    Dim baixo As Boolean = False
    Dim cima As Boolean = False
    Dim esquerda As Boolean = False
    Dim direita As Boolean = False
    Dim ganhar As Boolean = True


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Pok_Man_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = My.Resources.pokmanchar
        Me.Cursor = New Cursor(cur.Handle)
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(40, 40)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        If ganhar = True Then
            Mundo1.gamprogress.Increment(25)
            MsgBox("Conseguiste!! :D", MsgBoxStyle.Information, "Parabéns")
            Me.Hide()
            Mundo1.Show()
        Else
            MsgBox("Não faças batota, tenta outra vez.", MsgBoxStyle.Information, "):")
            MoveToStart()
            ganhar = True
        End If
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Pok_Man_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ganhar = False

    End Sub
End Class