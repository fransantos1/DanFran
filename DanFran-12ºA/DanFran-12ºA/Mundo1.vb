Public Class Mundo1
    Dim baixo As Boolean = False
    Dim cima As Boolean = False
    Dim esquerda As Boolean = False
    Dim direita As Boolean = False
    Dim start As Boolean = False
    Dim plsnaorepetir As Boolean = True
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
                    gamprogress.Increment(25)
                    mathgame = False
                Else
                    MsgBox("Erraste :(", MsgBoxStyle.Information, "Não conseguiste")
                    lab()
                End If

            Case 6 To 10
                resultado = InputBox("Quanto é que é: " & num1 & " - " & num2)
                If String.ReferenceEquals(resultado, String.Empty) Then
                ElseIf num1 - num2 = resultado Then
                    MsgBox("Conseguiste :DD", MsgBoxStyle.Information, "Parabéns")
                    gamprogress.Increment(25)
                    mathgame = False
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
        picbad.BackColor = Color.Transparent
        character.BackColor = Color.Transparent
        Ticks.Start()
        puzzle2 = True
        lblfala.BackColor = Color.Thistle
        PicFala.BackColor = Color.Transparent
        LblAvancar.Visible = False
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

        'conversa com mau
        If Collisions(mau, character) Then
            start = True
            If gamprogress.Value = 0 Then
                lblfala.Text = "Olá, eu sou Mário, Belzebu Mário. É um prazer. Reparei que o senhor não é de cá, bem vindo a Patópolis! Como uma prenda de boas vindas, podia me fazer um favor? Podia?! Obrigado. Só tenho umas tarefas para fazer nestes edifícios aqui, como maneira de pagar as minhas dívidas... Volte quando as tiver feito todas e dar-lhe-ei uma recompensa... (Afasta-te do Mário para deixares de ver esta fala)"
                picbad.Visible = True
                lblfala.Visible = True
                PicFala.Visible = True
            ElseIf (gamprogress.Value > 0 And gamprogress.Value < 100) Then
                lblfala.Text = "Ainda não acabaste tudo, volta quando tiveres feito o que te pedi! (Afasta-te do Mário para deixares de ver esta fala)"
                lblfala.Visible = True
                picbad.Visible = True
                PicFala.Visible = True
            ElseIf gamprogress.Value = 100 Then
                lblfala.Text = "Ah, conseguiste! Obrigado a sério, senhor. Agora o ritual está completo, finalmente consegui fazer alguém pagar as minhas dívidas! Finalmente domino o mundo! E a tua recompensa... Para que não me tentes derrubar, irei prender te no labirinto do Minotauro. Xau xau"
                picbad.Visible = True
                lblfala.Visible = True
                PicFala.Visible = True
                LblAvancar.Visible = True
            End If
        Else
            picbad.Visible = False
            lblfala.Visible = False
            PicFala.Visible = False
        End If


        'quando se faz as tasks todas
        If gamprogress.Value = 100 And plsnaorepetir = True Then
            plsnaorepetir = False
            MsgBox("Acabaste as tarefas, vai falar com o Mário para progredires!!", MsgBoxStyle.Information, "YAY!!!")
        End If
        If start = True Then
            'colisões com escola
            If Collisions(character, lblescola) = True And
            puzzle2 = True Then
                Me.Hide()
                Puzzle.Show()
                character.Top = 264
                character.Left = 554
                cima = False
                baixo = False
                direita = False
                esquerda = False
            End If
            'colisões com biblioteca
            If Collisions(character, lblbiblio) = True And
                trivia2 = True Then
                Me.Hide()
                Trivia.Show()
                character.Top = 264
                character.Left = 554
                cima = False
                baixo = False
                direita = False
                esquerda = False
            End If
            'colisões com lab
            If Collisions(character, lbllab) = True And
                 mathgame = True Then
                character.Top = 264
                character.Left = 554
                cima = False
                baixo = False
                direita = False
                esquerda = False
                lab()
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
        If gamprogress.Value = 100 Then
            lab()
        End If
    End Sub
    'arcade
    Private Sub ArcadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArcadeToolStripMenuItem.Click
        If gamprogress.Value = 100 Then
            Me.Hide()
            Pok_Man.Show()
        End If
    End Sub
    'biblioteca
    Private Sub BibliotecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BibliotecaToolStripMenuItem.Click
        If gamprogress.Value = 100 Then
            Me.Hide()
            Trivia.Show()
        End If
    End Sub
    'escolas
    Private Sub EscolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscolaToolStripMenuItem.Click
        If gamprogress.Value = 100 Then
            Me.Hide()
            Puzzle.Show()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblAvancar.Click
        Me.Hide()
        Mundo2.Show()
    End Sub
End Class