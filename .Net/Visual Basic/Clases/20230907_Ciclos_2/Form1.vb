Public Class Form1
    Private Sub btn_For1_Click(sender As Object, e As EventArgs) Handles btn_For1.Click
        For i = 1 To 10
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 10 Step 1.5
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub btn_For2_Click(sender As Object, e As EventArgs) Handles btn_For2.Click
        For i = 1 To 10 Step 2
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub btn_For3_Click(sender As Object, e As EventArgs) Handles btn_For3.Click
        For i = 10 To 1 Step -1
            lst_Valor.Items.Add(i)
        Next
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        lst_Valor.Items.Clear()
    End Sub

    Private Sub btn_While1_Click(sender As Object, e As EventArgs) Handles btn_While1.Click
        Dim i As Integer
        i = 1
        While i <= 10
            lst_Valor.Items.Add(i)
            'i = i + 1
            'i++  NO EXISTE en VB.net
            i += 1
        End While
    End Sub

    Private Sub btn_While2_Click(sender As Object, e As EventArgs) Handles btn_While2.Click
        Dim i As Integer
        i = 1
        While i <= 10
            lst_Valor.Items.Add(i)
            i += 2
        End While
    End Sub

    Private Sub btn_While3_Click(sender As Object, e As EventArgs) Handles btn_While3.Click
        Dim i As Integer
        i = 10
        While i >= 1
            lst_Valor.Items.Add(i)
            i -= 1
        End While
    End Sub

    Private Sub Btn_While4_Click(sender As Object, e As EventArgs) Handles Btn_While4.Click
        Dim i As Integer
        i = 10
        While i >= 1
            lst_Valor.Items.Add(i)
            i -= 1
        End While
    End Sub

    Private Sub btn_While3_Click(sender As Object, e As EventArgs) Handles btn_While3.Click
        Dim i As Integer
        i = 1
        Do
            lst_Valor.Items.Add(i)
            i = i + 1

        Loop 1 <= 10
    End Sub

End Class
