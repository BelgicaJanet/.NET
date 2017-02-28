Public Class SE6
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim hora As Double
        Dim descuento As Double
        Dim montoFinal As Double
        Dim acumulado As Double

        hora = txtHora.Text

        acumulado = 15 * hora
        descuento = acumulado * 0.05
        montoFinal = acumulado - descuento

        txtMontoDesc.Text = descuento
        txtFinal.Text = montoFinal



    End Sub
End Class