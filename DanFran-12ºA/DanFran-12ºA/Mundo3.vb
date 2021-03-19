Public Class Mundo3
    Private Sub Mundo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picmino.BackColor = Color.Transparent
        PicFala.BackColor = Color.Transparent
        Dim cur As Icon
        cur = My.Resources.protagonist_idlefront
        Me.Cursor = New Cursor(cur.Handle)
        PicFala.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lblmino.Text = "AH! Quem és tu? De onde vens? Belzebu Mário... Dominar o mundo... Não sei do que falas, mas por favor não me faças mal! A saída é ali à direita, podes ir à vontade... Só não me faças mal!"
        picmino.Visible = True
        lblmino.Visible = True
        PicFala.Visible = True
    End Sub

    Private Sub PBExit_Click(sender As Object, e As EventArgs) Handles PBExit.Click
        Me.Hide()
        Fim.Show()
    End Sub
End Class