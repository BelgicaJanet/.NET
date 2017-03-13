Public Class FrmItems
    Dim objItem As ClsItems
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim cantidad As Double

        If cmbTipo.SelectedItem.Equals("Normal") Then
            cantidad = 0.05
            MessageBox.Show(cantidad)
        ElseIf cmbTipo.SelectedItem.Equals("Fragil") Then
            cantidad = 0.15
        ElseIf cmbTipo.SelectedItem.Equals("Especial") Then
            cantidad = 0.2

        End If

        With objItem
            .codigo = txtCodigo.Text
            .nombre = txtProducto.Text
            .tipoTraslado = cantidad
            .precioCosto = txtPrecioCosto.Text
            txtPrecioVenta.Text = .calcularPrecioVenta(cantidad)

        End With

    End Sub
End Class