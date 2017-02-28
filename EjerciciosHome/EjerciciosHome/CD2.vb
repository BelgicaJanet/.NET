Public Class CD2

    Dim sueldo As Double
    Dim bonificacion As Double
    Dim montohijos As Double
    Dim total As Double


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        sueldo = txtSueldo.Text

        If checkbono.Checked = True And checkhijo.Checked = True Then
            bonificacion = 0.3 * sueldo
            montohijos = 0.1 * sueldo
            total = sueldo + bonificacion + montohijos
        ElseIf checkbono.Checked = True And checkhijo.Checked = False Then
            bonificacion = 0.3 * sueldo
            total = sueldo + bonificacion

        ElseIf checkbono.Checked = False And checkhijo.Checked = True Then
            montohijos = 0.1 * sueldo
            total = montohijos + sueldo

        End If


        txtRemuneracion.Text = total
    End Sub
End Class