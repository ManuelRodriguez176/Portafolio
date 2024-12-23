Public Class Form1
    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        txt_Inferior.Text = 1
        txt_Superior.Text = 101
        'Dim rnd As New Random()
        'txt_Computadora.Text = rnd.Next(CInt(txt_Inferior.Text), CInt(txt_Superior.Text))
        generar()
    End Sub

    Private Sub btn_Alto_Click(sender As Object, e As EventArgs) Handles btn_Alto.Click
        txt_Superior.Text = txt_Computadora.Text
        generar()
    End Sub

    Private Sub generar()
        Dim rnd As New Random()
        txt_Computadora.Text = rnd.Next(CInt(txt_Inferior.Text), CInt(txt_Superior.Text))
        txt_Intentos.Text = Val(txt_Intentos.Text) + 1
    End Sub

    Private Sub btn_Bajo_Click(sender As Object, e As EventArgs) Handles btn_Bajo.Click
        txt_Inferior.Text = txt_Computadora.Text
        generar()
    End Sub
End Class
