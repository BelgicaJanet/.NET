Public Class SE4
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim lado As Integer
        Dim diametro As Integer
        Dim diametro2 As Integer
        Dim area As Double
        Dim perimetro As Double

        lado = txtLado.Text
        diametro = txtDiametro.Text
        diametro2 = txtDiametro2.Text



        perimetro = 4 * lado
        area = (diametro * diametro2) / 2

        txtPeriemtro.Text = perimetro
        txtArea.Text = area




    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class