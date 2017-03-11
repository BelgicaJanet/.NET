Public Class frmEjercicio2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim numero As Integer
        Dim cuadrado As Integer
        Dim doble As Integer
        Dim mitad As Double

        numero = txtNumero.Text

        mitad = numero / 2
        doble = numero * 2
        cuadrado = numero * numero

        txtmitad.Text = mitad
        txtcuadrado.Text = cuadrado
        txtdoble.Text = doble




    End Sub
End Class