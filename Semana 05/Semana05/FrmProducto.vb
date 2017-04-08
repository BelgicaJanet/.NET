Public Class FrmProducto
    Dim strSQL As String, strMsg As String
    Dim oDa As SqlDataAdapter
    Dim oCm As SqlCommand
    Dim oDtProd As DataTable, oDtCat As DataTable, oDtProdB As DataTable

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir_bd()
        oDa = New SqlDataAdapter("SELECT CAT_ID, CAT_DESCRIPCION FROM CATEGORIA", oCn)
        oDtCat = New DataTable
        oDa.Fill(oDtCat)

        oDa = New SqlDataAdapter("SELECT PROD_ID, PROD_DESCRIPCION FROM PRODUCTO", oCn)
        oDtProd = New DataTable
        oDa.Fill(oDtProd)

        cerrar_bd()

        DgvProducto.DataSource = oDtProd

        CboCategoria.DisplayMember = "CAT_DESCRIPCION"
        CboCategoria.ValueMember = "CAT_ID"
        CboCategoria.DataSource = oDtCat

        CboCategoria.SelectedValue = ""

        EstadoAcciones(True)
        EstadoDatos(False)

        If DgvProducto.Rows.Count > 0 Then
            muestra_producto()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        EstadoAcciones(False)
        limpiarDatos()
        EstadoDatos(True)
        BtnGuardar.Text = "Guardar"
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If LblId.Text <> "" Then
            EstadoAcciones(False)
            EstadoDatos(True)
            BtnGuardar.Text = "Actualizar"
        Else
            MessageBox.Show("Seleccione un producto de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LblId.Text <> "" Then
            If MessageBox.Show("¿Eliminar el producto seleccionado?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = "DELETE FROM PRODUCTO WHERE PROD_ID='" & LblId.Text & "'"
                oCn.Open()
                oCm = New SqlCommand
                oCm.Connection = oCn
                oCm.CommandType = CommandType.Text
                oCm.CommandText = strSQL
                oCm.ExecuteNonQuery()
                oCn.Close()
                MessageBox.Show("Producto Eliminado...!!!", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarDatos()
                ActualizarLista()
            End If
        Else
            MessageBox.Show("Seleccione un producto de la lista", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim strEstado As String
            If RbtActivo.Checked Then
                strEstado = "A"
            Else
                strEstado = "I"
            End If
            oCn.Open()
            If BtnGuardar.Text = "Guardar" Then
                strSQL = "SELECT CASE WHEN MAX(PROD_ID)>0 THEN CONVERT(INT,MAX(PROD_ID))+1 ELSE 1 END AS NUEVO_ID FROM PRODUCTO"
                oDa = New SqlDataAdapter(strSQL, oCn)
                oDtProdB = New DataTable
                oDa.Fill(oDtProdB)
                LblId.Text = Integer.Parse(oDtProdB.Rows(0)(0)).ToString("0000")
                strSQL = "INSERT INTO PRODUCTO(PROD_ID, PROD_DESCRIPCION, PROD_DESC_CORTA, PROD_PRECIO, PROD_STOCK, PROD_ESTADO, CAT_ID) " _
                    & "VALUES ('" & LblId.Text & "','" & TxtDesc.Text & "','" & TxtDescCorta.Text _
                    & "'," & TxtPrecio.Text & "," & TxtStock.Text & ",'" & strEstado & "','" & CboCategoria.SelectedValue & "')"
                strMsg = "Producto guardado ...!!!"
            Else
                strSQL = "UPDATE PRODUCTO SET " _
                    & "PROD_DESCRIPCION='" & TxtDesc.Text & "', PROD_DESC_CORTA='" & TxtDescCorta.Text & "', PROD_PRECIO=" & TxtPrecio.Text & ", PROD_STOCK=" & TxtStock.Text & ", PROD_ESTADO='" & strEstado & "', CAT_ID='" & CboCategoria.SelectedValue & "' " _
                    & "WHERE PROD_ID='" & LblId.Text & "'"
                strMsg = "Producto Actualizado ...!!!"
            End If
            oCm = New SqlCommand
            oCm.Connection = oCn
            oCm.CommandType = CommandType.Text
            oCm.CommandText = strSQL
            oCm.ExecuteNonQuery()
            ActualizarLista()
            EstadoAcciones(True)
            EstadoDatos(False)
            MessageBox.Show(strMsg, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            oCn.Close()
        End Try
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        EstadoAcciones(True)
        EstadoDatos(False)
        muestra_producto()
    End Sub

    Private Sub DgvProducto_Click(sender As Object, e As EventArgs) Handles DgvProducto.Click
        muestra_producto()
    End Sub

    Private Sub limpiarDatos()
        LblId.Text = ""
        TxtDesc.Text = ""
        TxtDescCorta.Text = ""
        TxtPrecio.Text = ""
        TxtStock.Text = ""
        RbtActivo.Checked = True
        CboCategoria.SelectedIndex = -1
    End Sub

    Private Sub EstadoDatos(est As Boolean)
        TxtDesc.Enabled = est
        TxtDescCorta.Enabled = est
        TxtPrecio.Enabled = est
        TxtStock.Enabled = est
        RbtActivo.Enabled = est
        RbtInactivo.Enabled = est
        CboCategoria.Enabled = est
    End Sub

    Private Sub EstadoAcciones(est As Boolean)
        DgvProducto.Enabled = est
        BtnNuevo.Enabled = est
        BtnEditar.Enabled = est
        BtnEliminar.Enabled = est
        BtnGuardar.Enabled = Not est
        BtnCancelar.Enabled = Not est
    End Sub

    Private Sub muestra_producto()
        LblId.Text = DgvProducto.CurrentRow.Cells(0).Value
        TxtDesc.Text = DgvProducto.CurrentRow.Cells(1).Value
        abrir_bd()
        strSQL = "SELECT PROD_DESC_CORTA, PROD_PRECIO, PROD_STOCK, PROD_ESTADO, CAT_ID " _
            & "FROM PRODUCTO " _
            & "WHERE PROD_ID='" & LblId.Text & "'"
        oDa = New SqlDataAdapter(strSQL, oCn)
        oDtProdB = New DataTable
        oDa.Fill(oDtProdB)
        cerrar_bd()
        TxtDescCorta.Text = oDtProdB.Rows(0)(0).ToString
        TxtPrecio.Text = oDtProdB.Rows(0)(1).ToString
        TxtStock.Text = oDtProdB.Rows(0)(2).ToString
        If oDtProdB.Rows(0)(3).ToString = "A" Then
            RbtActivo.Checked = True
        Else
            RbtInactivo.Checked = True
        End If
        CboCategoria.SelectedValue = oDtProdB.Rows(0)(4).ToString
    End Sub

    Private Sub ActualizarLista()
        abrir_bd()
        oDa = New SqlDataAdapter("SELECT PROD_ID, PROD_DESCRIPCION FROM PRODUCTO", oCn)
        oDtProd = New DataTable
        oDa.Fill(oDtProd)
        cerrar_bd()

        DgvProducto.DataSource = oDtProd

        If DgvProducto.Rows.Count > 0 Then
            muestra_producto()
        End If
    End Sub
End Class