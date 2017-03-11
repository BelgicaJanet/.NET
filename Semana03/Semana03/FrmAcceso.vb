Public Class FrmAcceso

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TextBox1.Text = "belgica" And TextBox2.Text = "belgica" Then
            usuario = "Belgica de la Torre"
            FrmPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario no autorizado", "Mensaje")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

End Class