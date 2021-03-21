Public Class Puzzle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBD.Checked = True Then
            puzzle2 = False
            MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
            Mundo1.gamprogress.Increment(25)
            Me.Hide()
            Mundo1.Show()

            puzzle3 = False
        Else
            MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
        End If
    End Sub
End Class