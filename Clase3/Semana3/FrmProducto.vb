Public Class FrmProducto

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Guardar" Then
            If indice < 19 Then
                indice = indice + 1
                aCodigo(indice) = txtCodigo.Text
                aNombre(indice) = txtNombre.Text
                aPrecio(indice) = txtPrecio.Text
                aCantidad(indice) = txtCantidad.Text
                MessageBox.Show("Producto  Guardado", "mensaje")
            Else
                MessageBox.Show("No puede ingresar más elementos", "Mensaje")
            End If

        Else
            aCodigo(lstCodigos.SelectedIndex) = txtCodigo.Text
            aNombre(lstCodigos.SelectedIndex) = txtNombre.Text
            aPrecio(lstCodigos.SelectedIndex) = txtPrecio.Text
            aCantidad(lstCodigos.SelectedIndex) = txtCantidad.Text

            MessageBox.Show("Producto Actualizado")
        End If
        MuestraProductos()
        HabilitarOpciones(True)
        HabilitarDatos(False)
    End Sub

    Private Sub HabilitarOpciones(Estado As Boolean)
        btnNuevo.Enabled = Estado
        btnEditar.Enabled = Estado
        btnElimar.Enabled = Estado
        btnGuardar.Enabled = Not Estado
        btnCancelar.Enabled = Not Estado

    End Sub
    Private Sub HabilitarDatos(Estado As Boolean)
        txtCodigo.Enabled = Estado
        txtCantidad.Enabled = Estado
        txtNombre.Enabled = Estado
        txtPrecio.Enabled = Estado
        txtCantidad.Enabled = Estado
    End Sub
    Private Sub LimpiarDatos()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub MuestraProductos()
        lstCodigos.Items.Clear()
        For idx = 0 To indice
            lstCodigos.Items.Add(aNombre(idx))
        Next
    End Sub


    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuestraProductos()
        HabilitarDatos(False)
        HabilitarOpciones(True)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        HabilitarDatos(True)
        LimpiarDatos()
        btnGuardar.Text = "Guardar"
        HabilitarOpciones(False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarDatos(False)
        HabilitarOpciones(True)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click


        If lstCodigos.SelectedIndex >= 0 Then
            HabilitarDatos(True)
            btnGuardar.Text = "Actualizar"
            HabilitarOpciones(False)

        End If

    End Sub


    Private Sub lstCodigos_Click(sender As Object, e As EventArgs) Handles lstCodigos.Click
        txtNombre.Text = lstCodigos.Items.Item(lstCodigos.SelectedIndex)
        txtCodigo.Text = aCodigo(lstCodigos.SelectedIndex)
        txtCantidad.Text = aCantidad(lstCodigos.SelectedIndex)
        txtPrecio.Text = aPrecio(lstCodigos.SelectedIndex)
    End Sub
End Class