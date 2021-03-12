Public Class Puzzle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBD.Checked = True Then
            puzzle2 = False
            MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
            Me.Hide()
            Mundo2.Show()

        Else
            MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
        End If
    End Sub


End Class