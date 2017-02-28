Public Class SE2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Double
        Dim total As Double

        numero = txtNumero.Text

        total = Math.Round(((numero - 32) * (5 / 9)))


        txtResultado.Text = total

    End Sub
End Class