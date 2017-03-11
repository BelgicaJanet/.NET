Public Class Ejercicio1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim sueldo As Double
        Dim cantHijos As Integer
        Dim total As Double
        Dim bonificacion As Double

        sueldo = txtSueldo.Text
        cantHijos = txtCantHijos.Text

        bonificacion = (0.05 * sueldo) * cantHijos
        total = sueldo + bonificacion

        txtBonificacion.Text = "S/." & bonificacion
        txtTotal.Text = "S/." & total

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtSueldo.Text = ""
        txtCantHijos.Text = ""
        txtBonificacion.Text = ""
        txtTotal.Text = ""
        txtSueldo.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub
End Class
