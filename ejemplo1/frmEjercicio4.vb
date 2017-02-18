Public Class frmEjercicio4

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim inversion1 As Double
        Dim inversion2 As Double
        Dim inversion3 As Double
        Dim result1 As Double
        Dim result2 As Double
        Dim result3 As Double

        Dim total As Double

        inversion1 = txtInv1.Text
        inversion2 = txtInv2.Text
        inversion3 = txtInv3.Text

        total = inversion1 + inversion2 + inversion3

        result1 = Math.Round((inversion1 / total) * 100)
        txtresul1.Text = result1 & "%"

        result2 = Math.Round((inversion2 / total) * 100)
        txtresul2.Text = result2 & "%"

        result3 = Math.Round((inversion3 / total) * 100)
        txtresul3.Text = result3 & "%"



    End Sub
End Class