Public Class Game
    Dim countdown As Integer = 3
    Private Sub Game_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Keys.Enter Then
            MsgBox("funciona")
        End If

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs)
        Timer.Start()
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        countdown = countdown - 1
        If countdown = 0 Then
            nextmessage.Visible = True
            Timer.Stop()
            countdown = 3
        End If
    End Sub
End Class