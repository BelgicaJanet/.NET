Public Class frmEjercicio5

    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click

        Dim numero1 As Integer
        Dim numero2 As Integer



        numero1 = txtNumero.Text
        numero2 = txtNumero2.Text
        If (numero1 > numero2) Then
            lbltext.Text = "El mayor numero es: " & numero1 & " y el menor:" & numero2


        ElseIf (numero2 > numero1) Then
            lbltext.Text = "El mayor numero es: " & numero2 & " y el menor:" & numero1

        End If



    End Sub
End Class