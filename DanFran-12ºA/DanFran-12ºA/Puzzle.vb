﻿Public Class Puzzle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBD.Checked = True Then
            MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
            Me.Hide()
            Mundo2.Show()
            puzzle2 = False
        Else
            MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
        End If
    End Sub

    Private Sub Puzzle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class