Public Class FrmPrincipal

  
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssUsuario.Text = "Usuario" & usuario
    End Sub

    Private Sub pestProducto_Click(sender As Object, e As EventArgs) Handles pestProducto.Click
        FrmProducto.Show()
    End Sub

    Private Sub toolProducto_Click(sender As Object, e As EventArgs) Handles toolProducto.Click
        FrmProducto.MdiParent = Me
        FrmProducto.Show()
    End Sub

    Private Sub toolConsulta_Click(sender As Object, e As EventArgs) Handles toolConsulta.Click
        FrmConsultarProd.MdiParent = Me
        FrmConsultarProd.Show()
    End Sub

    Private Sub pestConsulta_Click(sender As Object, e As EventArgs) Handles pestConsulta.Click
        FrmConsultarProd.Show()
    End Sub

    Private Sub toolSalir_Click(sender As Object, e As EventArgs) Handles toolSalir.Click
        End
    End Sub

    Private Sub pestSalir_Click(sender As Object, e As EventArgs) Handles pestSalir.Click
        End
    End Sub
End Class
