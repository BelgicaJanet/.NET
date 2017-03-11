Public Class frmEjercicio1

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim lado As Integer
        Dim area As Integer
        Dim perimetro As Integer

        lado = txtlado.Text
        area = lado * lado
        perimetro = lado * 4

        txtperimetro.Text = perimetro
        txtarea.Text = area




    End Sub
End Class
