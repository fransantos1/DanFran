Public Class Login
    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles Blogin.Click
        If TextBoxPass.Text = "Gamer" And
                TextBoxUser.Text = "Daniela" Or
                TextBoxUser.Text = "Francisco" Then
            Me.Hide()
            Main.Show()
        ElseIf TextBoxPass.Text = "" And
                TextBoxUser.Text = "" Then
            MsgBox("Por favor intruduza uma Password e Username", MsgBoxStyle.Information, "Erro")
        ElseIf TextBoxPass.Text = "" Then
            MsgBox("Por favor intruduza uma Password", MsgBoxStyle.Information, "Erro")
        ElseIf TextBoxUser.Text = "" Then
            MsgBox("Por favor introduza um Username", MsgBoxStyle.Information, "Erro")
        Else
            MsgBox("O valor que introduzio está errado", MsgBoxStyle.Information, "Erro")
        End If
    End Sub

    Private Sub Bclose_Click(sender As Object, e As EventArgs) Handles Bclose.Click
        End
    End Sub

End Class
