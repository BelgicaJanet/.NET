Imports CapaEntidad
Imports CapaNegocio
Public Class FrmMantUsuario

    Private Sub FrmMantUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtUsr As DataTable
        oDtUsr = NeUsuario.ListadoUsuarios("V", "")
        dgUsuario.DataSource = oDtUsr

    End Sub
End Class
