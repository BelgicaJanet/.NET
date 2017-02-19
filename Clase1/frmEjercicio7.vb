Public Class frmEjercicio7

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim numero As Integer


        numero = txtNumero1.Text


        If (numero = 0) Then
            lbltext.Text = "El numero es : 0"
        ElseIf (numero Mod 2 = 0) Then
            lbltext.Text = "El numero es par " 

        Else
            lbltext.Text = "El numero es impar "

        End If


    End Sub
End Class