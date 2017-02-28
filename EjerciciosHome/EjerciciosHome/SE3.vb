Public Class SE3
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim ladoA As Integer
        Dim ladoB As Integer
        Dim ladoC As Integer
        Dim ladoD As Integer

        Dim area As Double
        Dim perimetro As Double


        ladoA = txtA.Text
        ladoB = txtB.Text
        ladoC = txtC.Text
        ladoD = txtD.Text

        area = ((ladoA + ladoB) / 2) * ladoD
        perimetro = ladoA + ladoB + ladoC + ladoD

        txtArea.Text = area
        txtPerimetro.Text = perimetro


    End Sub

    Private Sub SE3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class