Public Class Trivia
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBvila.SelectedIndexChanged

    End Sub

    Private Sub Trivia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBvila.Items.Add("Nova Patópolis")
        CBvila.Items.Add("Patópolis")
        CBvila.Items.Add("Velha Patópolis")
    End Sub
End Class