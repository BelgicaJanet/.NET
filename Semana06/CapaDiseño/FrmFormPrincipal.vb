Public Class FrmFormPrincipal

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles toolUser.Click

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        FrmMantUsuario.Show()

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        FrmPedido.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        FrmReporte.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        FrmProducto.Show()
    End Sub

    Private Sub FrmFormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolUser.Text = "Usuario: " & gUsrNombre & " " & gUsrApellido
    End Sub
End Class