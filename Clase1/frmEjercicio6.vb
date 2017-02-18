Public Class frmEjercicio6

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim numero1 As Integer
        Dim numero2 As Integer

        numero1 = txtnum1.Text
        numero2 = txtNum2.Text

        If (numero1 > numero2) Then
            lblresult.Text = "El mayor numero es:" & numero1

        ElseIf (numero2 > numero1) Then
            lblresult.Text = "El mayor numero es:" & numero2
        Else
            lblresult.Text = "Son iguales"
        End If




    End Sub
End Class