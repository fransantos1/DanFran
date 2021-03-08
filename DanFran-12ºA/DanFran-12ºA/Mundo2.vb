Public Class Mundo2
    Dim baixo As Boolean = False
    Dim cima As Boolean = False
    Dim esquerda As Boolean = False
    Dim direita As Boolean = False
    'Load form
    Private Sub Mundo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbllab.BackColor = Color.Transparent
        lblrcade.BackColor = Color.Transparent
        lblescola.BackColor = Color.Transparent
        lblbiblio.BackColor = Color.Transparent
        Ticks.Start()
        puzzle2 = True
    End Sub
    'boolean de movimentos
    Private Sub Mundo2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.W
                cima = True
            Case Keys.S
                baixo = True
            Case Keys.D
                direita = True
            Case Keys.A
                esquerda = True
        End Select
    End Sub
    Private Sub Mundo2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.W
                cima = False
            Case Keys.S
                baixo = False
            Case Keys.D
                direita = False
            Case Keys.A
                esquerda = False
        End Select
    End Sub
    'funçao de colisões
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
        'movimento
        If cima = True Then
            If character.Top > borderup.Top + borderup.Height Then
                character.Top = character.Top - 5
            End If
        End If
        If baixo = True Then
            character.Top = character.Top + 5
        End If
        If esquerda = True Then
            If character.Left > Borderleft.Left + Borderleft.Width Then
                character.Left = character.Left - 5
            End If
        End If
        If direita = True Then
            character.Left = character.Left + 5
        End If

        'colisões com os puzzles
        If Collisions(character, lblbiblio) = True Then
            Me.Hide()
            Trivia.Show()
        End If

        If Collisions(character, lblescola) = True And
                puzzle2 = True Then
            Me.Hide()
            Puzzle.Show()
            cima = False
            baixo = False
            direita = False
            esquerda = False
        End If

        If Collisions(character, lbllab) = True Then

        End If

        If Collisions(character, lblrcade) = True Then
            Me.Hide()
            Pok_Man.Show()


        End If
    End Sub
    'menu strip
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        MsgBox("Francisco e Daniela", MsgBoxStyle.Information, "Autores")
    End Sub


End Class