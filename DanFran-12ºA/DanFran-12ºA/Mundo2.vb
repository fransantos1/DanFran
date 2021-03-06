Public Class Mundo2
    Private Sub Mundo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbllab.BackColor = Color.Transparent
        lblrcade.BackColor = Color.Transparent
        lblescola.BackColor = Color.Transparent
        lblbiblio.BackColor = Color.Transparent
    End Sub
    Private Function Collisions(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim collide As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
           Object2.Top + Object2.Height >= Object1.Top And
           Object1.Left + Object1.Width >= Object2.Left And
           Object2.Left + Object2.Width >= Object1.Left Then
            Collisions = True
        End If
        Return Collisions
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Ticks.Tick
        If Collisions(character, lblbiblio) = True Then

        End If
        If Collisions(character, lblescola) = True Then

        End If
        If Collisions(character, lbllab) = True Then

        End If
        If Collisions(character, lblrcade) = True Then

        End If
    End Sub
End Class