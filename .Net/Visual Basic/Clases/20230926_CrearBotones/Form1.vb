Public Class Form1
    Dim btn_Creado As Button
    Dim btn_CreadoV As Button
    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click
        btn_Creado = New Button()
        btn_Creado.Size = New Size(70, 30)
        btn_Creado.Location = New Point(200, 100)
        btn_Creado.Text = "Creado"
        Controls.Add(btn_Creado)
        AddHandler btn_Creado.Click, AddressOf btn_Creado_Click
    End Sub

    Private Sub btn_Creado_Click(sender As Object, e As EventArgs)
        txt_Creado.Text = "Hola"
    End Sub

    Private Sub btn_Varios_Click(sender As Object, e As EventArgs) Handles btn_Varios.Click
        For i = 0 To 5
            btn_CreadoV = New Button()
            btn_CreadoV.Size = New Size(70, 30)
            btn_CreadoV.Location = New Point(200 + 80 * i, 200)
            btn_CreadoV.Text = "Boton " & i
            Controls.Add(btn_CreadoV)
            AddHandler btn_CreadoV.Click, AddressOf btn_CreadoV_Click
        Next
    End Sub
    Private Sub btn_CreadoV_Click(sender As Object, e As EventArgs)
        'txt_Creado.Text = "Varios"
        'txt_Creado.Text = btn_CreadoV.Text
        Dim btn_tmp As Button
        btn_tmp = CType(sender, Button)
        txt_Creado.Text = btn_tmp.Text
    End Sub
End Class
