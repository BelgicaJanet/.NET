Imports CapaNegocio
Imports CapaEntidad
Public Class FrmAccesoSistema

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim oDtUsr As DataTable

        oDtUsr = NeUsuario.ValidarUsuario(txtUsuario.Text, txtPassword.Text)
        If oDtUsr.Rows.Count > 0 Then
            gUsrId = oDtUsr(0)(0).ToString
            gUsrNombre = oDtUsr(0)(1).ToString
            gUsrApellido = oDtUsr(0)(2).ToString
            FrmFormPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario no autorizado", "Sistema")
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class