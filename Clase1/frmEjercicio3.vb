Public Class frmEjercicio3

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        Dim producto As String
        Dim cantidad As Integer
        Dim precio As Double
        Dim importe As Double
        Dim igv As Double
        Dim total As Double

        producto = txtProducto.Text
        cantidad = txtCantidad.Text
        precio = txtPrecio.Text

        importe = precio * cantidad
        igv = importe * 0.18
        total = importe + igv


        txtImporte.Text = importe
        txtIGV.Text = igv
        txtotal.Text = total



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class