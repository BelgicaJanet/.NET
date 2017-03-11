Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarDatos(False)
        HabilitarOpciones(True)
        ListaProductos()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarOpciones(False)
        HabilitarDatos(True)
        LimpiarDatos()
        BtnGuardar.Text = "Guardar"
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If LstProductos.Items.Count > 0 Then
            If LstProductos.SelectedIndex >= 0 Then
                HabilitarDatos(True)
                HabilitarOpciones(False)
                BtnGuardar.Text = "Actualizar"
            Else
                MessageBox.Show("Seleccione un producto...!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Arreglo vacio...!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LstProductos.Items.Count > 0 Then
            If LstProductos.SelectedIndex >= 0 Then
                Dim indiceBus As Integer = -1
                For idx = 0 To LstProductos.Items.Count - 1
                    If TxtNombre.Text = aNombre(idx) Then
                        indiceBus = idx
                    End If
                Next
                If indiceBus >= 0 Then
                    If indiceBus < indice Then
                        For idx = indiceBus To indice
                            aCodigo(idx) = aCodigo(idx + 1)
                            aNombre(idx) = aNombre(idx + 1)
                            aPrecio(idx) = aPrecio(idx + 1)
                            aCantidad(idx) = aCantidad(idx + 1)
                        Next
                    End If
                    indice = indice - 1
                    LimpiarDatos()
                    ListaProductos()
                    MessageBox.Show("Producto eliminado...!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Seleccione un producto...!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Arreglo vacio...!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim msgDesc As String
        If BtnGuardar.Text = "Guardar" Then
            indice = indice + 1
            aCodigo(indice) = TxtCodigo.Text
            aNombre(indice) = TxtNombre.Text
            aPrecio(indice) = TxtPrecio.Text
            aCantidad(indice) = TxtCantidad.Text
            msgDesc = "Producto guardado...!!!"
        Else
            aCodigo(LstProductos.SelectedIndex) = TxtCodigo.Text
            aNombre(LstProductos.SelectedIndex) = TxtNombre.Text
            aPrecio(LstProductos.SelectedIndex) = TxtPrecio.Text
            aCantidad(LstProductos.SelectedIndex) = TxtCantidad.Text
            msgDesc = "Producto actualizado...!!!"
        End If
        HabilitarDatos(False)
        HabilitarOpciones(True)
        LimpiarDatos()
        ListaProductos()
        MessageBox.Show(msgDesc, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        MuestraProductoSeleccionado()
        HabilitarDatos(False)
        HabilitarOpciones(True)
    End Sub
    Private Sub LstProductos_Click(sender As Object, e As EventArgs) Handles LstProductos.Click
        MuestraProductoSeleccionado()
    End Sub

    Private Sub HabilitarOpciones(Estado As Boolean)
        BtnNuevo.Enabled = Estado
        BtnEditar.Enabled = Estado
        BtnEliminar.Enabled = Estado
        BtnGuardar.Enabled = Not Estado
        BtnCancelar.Enabled = Not Estado
    End Sub

    Private Sub HabilitarDatos(Estado As Boolean)
        TxtCodigo.Enabled = Estado
        TxtNombre.Enabled = Estado
        TxtPrecio.Enabled = Estado
        TxtCantidad.Enabled = Estado
        LstProductos.Enabled = Not Estado
    End Sub

    Private Sub LimpiarDatos()
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecio.Text = ""
        TxtCantidad.Text = ""
    End Sub

    Private Sub MuestraProductoSeleccionado()
        If LstProductos.SelectedIndex >= 0 Then
            TxtNombre.Text = LstProductos.Items.Item(LstProductos.SelectedIndex)
            TxtCodigo.Text = aCodigo(LstProductos.SelectedIndex)
            TxtPrecio.Text = aPrecio(LstProductos.SelectedIndex)
            TxtCantidad.Text = aCantidad(LstProductos.SelectedIndex)
        End If
    End Sub
    Private Sub ListaProductos()
        LstProductos.Items.Clear()
        For idx = 0 To indice
            LstProductos.Items.Add(aNombre(idx))
        Next
    End Sub

End Class
