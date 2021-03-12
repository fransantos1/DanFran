Module variaveis
    Public Property puzzle2 As Boolean = True
    Public Property puzzle3 As Boolean = True
    Public Property mathgame As Boolean = True
    Public Property mathgame1 As Boolean = True
    Public Property pokman2 As Boolean = True
    Public Property pokman3 As Boolean = True
    Public Property trivia2 As Boolean = True
    Public Property trivia3 As Boolean = True
    'funçao de colisões
    Public Function Collisions(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim collide As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
           Object2.Top + Object2.Height >= Object1.Top And
           Object1.Left + Object1.Width >= Object2.Left And
           Object2.Left + Object2.Width >= Object1.Left Then
            Collisions = True
        End If
        Return Collisions
    End Function

End Module
