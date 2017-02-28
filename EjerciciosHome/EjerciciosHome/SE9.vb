Public Class SE9
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim deposito As Double
        Dim computacion As Double
        Dim adminitracion As Double
        Dim contabilidad As Double
        Dim diseno As Double

        deposito = txtDeposito.Text
        computacion = (deposito * 0.4) / 2
        adminitracion = (deposito * 0.5) / 2
        contabilidad = (deposito * 0.7) / 2
        diseno = deposito - (computacion + adminitracion + contabilidad)

        txtComputacion.Text = computacion
        txtAdministracion.Text = adminitracion
        txtContabilidad.Text = contabilidad
        txtDiseño.Text = diseno






    End Sub
End Class