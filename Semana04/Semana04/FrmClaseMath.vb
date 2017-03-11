Public Class FrmClaseMath
    Dim num1 As Integer
    Dim num3 As Integer
    Dim num2 As Double
    Private Sub BtnGenrar_Click(sender As Object, e As EventArgs) Handles BtnGenrar.Click
        num1 = TxtNumero.Text
        num2 = txtNum2.Text
        num3 = txtNum3.Text
        txtMayor.Text = Math.Max(Math.Max(num1, num2), num3)
        txtMenor.Text = Math.Min(Math.Min(num1, num2), num3)
        txtPotencia.Text = Math.Pow(Double.Parse(txtMenor.Text), 2)
        txtRaiz.Text = Math.Sqrt(Double.Parse(txtMayor.Text))
        txtPI.Text = Math.Round(Math.PI)


    End Sub
End Class