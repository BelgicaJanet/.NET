Public Class SE1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim numero As Double
        Dim total As Double

        numero = txtNumero.Text
        total = ((9 / 5) * numero) + 32

        txtResultado.Text = total


    End Sub
End Class