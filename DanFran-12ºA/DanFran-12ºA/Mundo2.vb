Public Class Mundo2

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Mundo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picmino.BackColor = Color.Transparent
        PicFala.BackColor = Color.Transparent
        Dim cur As Icon
        cur = My.Resources.protagonist_idlefront
        Me.Cursor = New Cursor(cur.Handle)
        PicFala.Visible = False
    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(295, 295)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lblmino.Text = "AH! Quem és tu? De onde vens? Belzebu Mário... Dominar o mundo... Não sei do que falas, mas por favor não me faças mal! A saída é ali à direita, podes ir à vontade... Só não me faças mal! (Clica duas vezes no Minotauro para esconderes esta fala)"
        picmino.Visible = True
        lblmino.Visible = True
        PicFala.Visible = True
    End Sub


    Private Sub PBExit_Click(sender As Object, e As EventArgs) Handles PBExit.Click
        Me.Hide()
        Fim.Show()
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        picmino.Visible = False
        lblmino.Visible = False
        PicFala.Visible = False
    End Sub
End Class