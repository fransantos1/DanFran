Public Class Mundo2
    Dim baixo As Boolean = False
    Dim cima As Boolean = False
    Dim esquerda As Boolean = False
    Dim direita As Boolean = False

    'funçao lab
    Private Function lab()
        Dim resultado As String
        Dim num1 As Single
        Dim num2 As Single
        Dim num3 As Single
        num3 = Int(Rnd() * 10)
        num1 = Int(Rnd() * 10)
        num2 = Int(Rnd() * 10)

        Select Case num3
            Case 1 To 5
                resultado = InputBox("Quanto é que é: " & num1 & " + " & num2)
                If String.ReferenceEquals(resultado, String.Empty) Then
                ElseIf num1 + num2 = resultado Then
                    MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
                Else
                    MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
                    lab()
                End If

            Case 6 To 10
                resultado = InputBox("Quanto é que é: " & num1 & " - " & num2)
                If String.ReferenceEquals(resultado, String.Empty) Then
                ElseIf num1 - num2 = resultado Then
                    MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
                Else
                    MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
                    lab()
                End If
        End Select
        Return True
    End Function
    'Load form
    Private Sub Mundo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbllab.BackColor = Color.Transparent
        lblrcade.BackColor = Color.Transparent
        lblescola.BackColor = Color.Transparent
        lblbiblio.BackColor = Color.Transparent
        character.BackColor = Color.Transparent
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Ticks.Tick
        'movimento
        If cima = True Then
            If character.Top > Bordertopleft.Top + Bordertopleft.Height Then
                character.Top = character.Top - 5
            End If
        End If
        If baixo = True Then
            If character.Top + character.Height < borderdownright.Top Then
                character.Top = character.Top + 5
            End If
        End If
        If esquerda = True Then
            If character.Left > Bordertopleft.Left + Bordertopleft.Width Then
                character.Left = character.Left - 5
            End If
        End If
        If direita = True Then
            character.Left = character.Left + 5
        End If

        'colisões com biblioteca
        If Collisions(character, lblbiblio) = True Then
            Me.Hide()
            Trivia.Show()
            cima = False
            baixo = False
            direita = False
            esquerda = False
        End If
        'colisões com escola
        If Collisions(character, lblescola) = True And
            puzzle2 = True Then
            puzzle2 = False
            Me.Hide()
            Puzzle.Show()
            cima = False
            baixo = False
            direita = False
            esquerda = False
        End If
        'colisões com lab
        If Collisions(character, lbllab) = True Then
            If mathgame = True Then
                mathgame = False
                cima = False
                baixo = False
                direita = False
                esquerda = False
                lab()
            End If
        End If
        'colisões com arcade
        If Collisions(character, lblrcade) = True And
            pokman2 = True Then
            pokman2 = False
            cima = False
            baixo = False
            direita = False
            esquerda = False
            Me.Hide()
            Pok_Man.Show()
        End If
    End Sub
    'menu strip
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub
    'autores
    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        MsgBox("Francisco e Daniela", MsgBoxStyle.Information, "Autores")
    End Sub
    'lab
    Private Sub LabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabToolStripMenuItem.Click
        lab()
    End Sub
    'arcade
    Private Sub ArcadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArcadeToolStripMenuItem.Click
        Me.Hide()
        Pok_Man.Show()
    End Sub
    'biblioteca
    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        Me.Hide()
        Trivia.Show()
    End Sub
    'escolas
    Private Sub EscolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscolaToolStripMenuItem.Click
        Me.Hide()
        Puzzle.Show()
    End Sub


End Class