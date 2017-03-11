Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TsslUsuario.Text = "Usuario: " & usuario
    End Sub

    Private Sub MnuProductos_Click(sender As Object, e As EventArgs) Handles MnuProductos.Click
        FrmProductos.Show()
    End Sub
    Private Sub MnuConsultaProductos_Click(sender As Object, e As EventArgs) Handles MnuConsultaProductos.Click
        FrmConsultaProd.MdiParent = Me
        FrmConsultaProd.Show()
    End Sub
    Private Sub MnuSalir_Click(sender As Object, e As EventArgs) Handles MnuSalir.Click
        If MessageBox.Show("¿Está seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            End

        End If

    End Sub

    Private Sub TsbProductos_Click(sender As Object, e As EventArgs) Handles TsbProductos.Click
        MnuProductos_Click(Nothing, Nothing)
    End Sub
    Private Sub TsbConsultaProductos_Click(sender As Object, e As EventArgs) Handles TsbConsultaProductos.Click
        MnuConsultaProductos_Click(Nothing, Nothing)
    End Sub
    Private Sub TsbSalir_Click(sender As Object, e As EventArgs) Handles TsbSalir.Click
        MnuSalir_Click(Nothing, Nothing)
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MnuSalir_Click(Nothing, Nothing)
    End Sub
End Class