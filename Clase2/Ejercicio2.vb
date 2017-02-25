Public Class Ejercicio2

    Private Sub Nuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim precio As Double
        Dim montoInicial As Double
        Dim precioFinal As Double

        precio = txtPrecio.Text

        montoInicial = precio * 0.1
        precioFinal = ((1 + 0.35) * 12) * montoInicial


        txtMontoInicial.Text = montoInicial
        txtPrecioFinal.Text = precioFinal



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPrecio.Text = ""
        txtMontoInicial.Text = ""
        txtPrecioFinal.Text = ""
        txtPrecio.Focus()
    End Sub
End Class