Public Class FrmProducto
    Dim objProd As New ClsProducto

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With objProd
            .codigoProd = TextBox1.Text
            .descripcionProd = TextBox2.Text
            .precioProd = TextBox3.Text
            .stockProd = TextBox4.Text
            TextBox5.Text = .stockValorizado()
            TextBox6.Text = .generaEtiqueta(1)
        End With
    End Sub
End Class
