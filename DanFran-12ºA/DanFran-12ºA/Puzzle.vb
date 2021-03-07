Public Class Puzzle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBD.Checked = True Then
            MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
            Me.Hide()
            Mundo2.Show()

        Else
            MsgBox("Como é q erraste?", MsgBoxStyle.Information, "WTF")
        End If
    End Sub

End Class