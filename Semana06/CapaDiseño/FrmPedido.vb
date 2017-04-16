Imports CapaNegocio
Imports CapaEntidad


Public Class FrmPedido

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtCat As DataTable

        oDtCat = NeCategoria.ListarCategorias("L", "")

        For i = 0 To oDtCat.Rows.Count - 1
            LvCategoria.Items.Add(oDtCat(i)(1)).Tag = oDtCat(i)(0)
        Next
        LvPedido.Columns.Add("Codigo")
        LvPedido.Columns.Add("Descripción")
        LvPedido.Columns.Add("Precio")
        LvPedido.Columns.Add("Cantidad")
        LvPedido.Columns.Add("Importe")

        LblUsrId.Text = gUsrId
        LblUsuario.Text = gUsrNombre
    End Sub

    Private Sub LvCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles LvCategoria.MouseClick
        LvProducto.Items.Clear()
        Dim oDtPro As DataTable
        oDtPro = NeProducto.ListadoProductos("C", "", LvCategoria.SelectedItems(0).Tag)
        For i = 0 To oDtPro.Rows.Count - 1
            ' Posicion de la columna representa el numero al costado del I
            LvProducto.Items.Add(oDtPro(i)(1)).Tag = oDtPro(i)(0) & "|" & oDtPro(i)(2)
        Next

    End Sub

    Private Sub LvProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles LvProducto.MouseClick
        lblProducto.Text = LvProducto.SelectedItems(0).Text
        Dim strProd As String = LvProducto.SelectedItems(0).Tag
        Dim avProd As String() = strProd.Split("|")
        lblProducto.Tag = avProd(0)
        lblPrecio.Text = avProd(1)
        txtCantidad.Focus()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim item As New ListViewItem
            item = LvPedido.Items.Add(lblProducto.Tag)
            item.SubItems.Add(lblProducto.Text)
            item.SubItems.Add(lblPrecio.Text)
            item.SubItems.Add(txtCantidad.Text)
            Dim dblImporte As Double = Double.Parse(lblPrecio.Text) * Double.Parse(txtCantidad.Text)
            item.SubItems.Add(dblImporte)
            lblProducto.Text = ""
            lblPrecio.Text = ""
            txtCantidad.Text = ""
            GenerarTotal()
        End If
    End Sub

    Private Sub GenerarTotal()
        Dim dblTotal As Double
        For i = 0 To LvPedido.Items.Count - 1
            dblTotal = dblTotal + Double.Parse(LvPedido.Items(i).SubItems(4).Text)
        Next
        lblTotal.Text = dblTotal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oDt As DataTable
        oDt = NeUsuario.ListadoUsuarios("N", "")
        Dim objUsuario As EnUsuario
        LblUsrId.Text = oDt(0)(0)
        objUsuario.USR_ID = LblUsrId.text()

    End Sub
End Class
