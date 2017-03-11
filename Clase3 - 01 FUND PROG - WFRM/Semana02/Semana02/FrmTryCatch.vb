Public Class FrmTryCatch

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            Dim Num As Integer = TxtNumero.Text
            LstNumeros.Items.Add(Num)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        Finally
            MessageBox.Show("Controlando el Error")
        End Try
    End Sub
End Class
