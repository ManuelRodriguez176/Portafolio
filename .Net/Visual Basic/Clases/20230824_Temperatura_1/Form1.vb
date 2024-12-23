Public Class Form1
    Private Sub btn_CF_Click(sender As Object, e As EventArgs) Handles btn_CF.Click
        'txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
        txt_F.Text = cf(txt_C.Text)
    End Sub

    Private Sub btn_FC_Click(sender As Object, e As EventArgs) Handles btn_FC.Click
        txt_C.Text = (Val(txt_F.Text) - 32) / (9 / 5)
    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        If rb_C.Checked Then
            txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
        Else
            txt_C.Text = (Val(txt_F.Text) - 32) / (9 / 5)
        End If
    End Sub

    Private Sub txt_C_TextChanged(sender As Object, e As EventArgs) Handles txt_C.TextChanged
        'txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
        Try
            txt_F.Text = cf(txt_C.Text)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub hsb_Valor_Scroll(sender As Object, e As ScrollEventArgs) Handles hsb_Valor.Scroll
        txt_C.Text = hsb_Valor.Value
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles vsb_Valor.Scroll
        If rb_C.Checked Then
            txt_C.Text = -vsb_Valor.Value
        Else
            txt_F.Text = -vsb_Valor.Value
        End If

    End Sub

    Private Sub txt_F_TextChanged(sender As Object, e As EventArgs) Handles txt_F.TextChanged
        txt_C.Text = (Val(txt_F.Text) - 32) / (9 / 5)
    End Sub
    Private Function cf(valor As String) As Double
        Return Val(valor) * 9 / 5 + 32
    End Function
End Class
