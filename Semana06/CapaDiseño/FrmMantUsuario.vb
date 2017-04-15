Imports CapaEntidad
Imports CapaNegocio
Public Class FrmMantUsuario

    Private Sub FrmMantUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtUsr As DataTable
        oDtUsr = NeUsuario.ListadoUsuarios("V", "")
        dgUsuario.DataSource = oDtUsr

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class
