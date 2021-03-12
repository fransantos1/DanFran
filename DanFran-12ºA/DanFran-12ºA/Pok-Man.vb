Public Class Pok_Man
    Dim baixo As Boolean = False
    Dim cima As Boolean = False
    Dim esquerda As Boolean = False
    Dim direita As Boolean = False
    Private Sub Pok_Man_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cur As Icon
        cur = My.Resources.pokmanchar
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        MsgBox("Conseguiste!! :D", MsgBoxStyle.Information, "Parabéns")
        Me.Hide()
        Mundo2.Show()
    End Sub
End Class