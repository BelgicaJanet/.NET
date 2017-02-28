Public Class CD1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ingreso As Double
        Dim hora As Double
        Dim acumulado As Double
        Dim descuento As Double
        Dim montofinal As Double

        ingreso = txtIngreso.Text
        hora = txtHora.Text

        acumulado = ingreso * hora

        montofinal = acumulado
        txtTexto.Text = "NO"

        If acumulado > 1800 Then

            descuento = 0.1 * acumulado
            montofinal = acumulado - descuento
            txtTexto.Text = "SI"


        End If

        txtResultado.Text = montofinal



    End Sub
End Class