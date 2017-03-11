Public Class FrmAcceso

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtUsuario.Text = "belgica" And txtContrasena.Text = "belgica" Then
            usuario = "Belgica de la Torre"
            FrmPrincipal.Show()
            Me.Hide()

        Else
            MessageBox.Show("Usuario no autorizado", "Mensaje")
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End

    End Sub
End Class