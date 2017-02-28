Public Class ES1
    Private Sub ES1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim numero As Double
        Dim total As Double

        numero = txtTemperatura.Text
        total = (9 / 5 * numero) + 32

        txtResultado.Text = total



    End Sub
End Class