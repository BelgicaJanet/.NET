Public Class FrmConsultaProd
    Private Sub RbtCodigo_Click(sender As Object, e As EventArgs) Handles RbtCodigo.Click
        LblDescripcion.Text = "Código:"
    End Sub

    Private Sub RbtNombre_Click(sender As Object, e As EventArgs) Handles RbtNombre.Click
        LblDescripcion.Text = "Nombre:"
    End Sub

    Private Sub RbtPrecio_Click(sender As Object, e As EventArgs) Handles RbtPrecio.Click
        LblDescripcion.Text = "Precio:"
    End Sub

    Private Sub RbtCantidad_Click(sender As Object, e As EventArgs) Handles RbtCantidad.Click
        LblDescripcion.Text = "Cantidad:"
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        LstProducto.Items.Clear()
        LstPrecio.Items.Clear()
        LstCantidad.Items.Clear()
        Select Case True
            Case RbtCodigo.Checked
                For idx = 0 To indice
                    If TxtValor.Text = aCodigo(idx) Then
                        LstProducto.Items.Add(aCodigo(idx) & " - " & aNombre(idx))
                        LstPrecio.Items.Add(aPrecio(idx))
                        LstCantidad.Items.Add(aCantidad(idx))
                    End If
                Next
            Case RbtNombre.Checked

            Case RbtPrecio.Checked

            Case RbtCantidad.Checked

        End Select
    End Sub

   
End Class