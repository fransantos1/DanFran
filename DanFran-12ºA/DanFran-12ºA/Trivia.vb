Public Class Trivia
    Dim nome1 As String
    Dim nome2 As String
    Dim nome3 As String
    Private Sub Trivia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBvila.Items.Add("Nova Patópolis")
        CBvila.Items.Add("Patópolis")
        CBvila.Items.Add("Velha Patópolis")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If correct.Checked = True And CBvila.SelectedIndex = 1 Then
            MsgBox("Conseguiste! :DD", MsgBoxStyle.Information, "Parabéns")
            trivia2 = False
            Me.Hide()
            Mundo1.Show()
            Mundo1.gamprogress.Increment(25)
        Else
            MsgBox("Tens algo errado...", MsgBoxStyle.Information, "Não conseguiste")
        End If
    End Sub

    Private Sub Binserir_Click(sender As Object, e As EventArgs) Handles Binserir.Click
        ListBNomes.Items.Add(txtnomes.Text)
    End Sub

    Private Sub BLimpar_Click(sender As Object, e As EventArgs) Handles BLimpar.Click
        ListBNomes.Items.Clear()
    End Sub
End Class