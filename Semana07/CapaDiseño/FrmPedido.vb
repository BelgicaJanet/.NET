Imports CapaNegocio
Imports CapaEntidad


Public Class FrmPedido

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LvCategoria.Items.Add("AAAA").Tag = "01"
        LvCategoria.Items.Add("BBBB").Tag = "02"

        LvPedido.Columns.Add("Codigo")
        LvPedido.Columns.Add("Descripción")
        LvPedido.Columns.Add("Precio")
        LvPedido.Columns.Add("Cantidad")
        LvPedido.Columns.Add("Importe")
    End Sub

    Private Sub LvCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles LvCategoria.MouseClick
        LvProducto.Items.Clear()
        If LvCategoria.SelectedItems(0).Tag = "01" Then
            LvProducto.Items.Add("XXXX").Tag = "0001|5"
            LvProducto.Items.Add("YYYY").Tag = "0002|8"
            LvProducto.Items.Add("ZZZZ").Tag = "0003|7"
        Else
            LvProducto.Items.Add("WWWW").Tag = "0004|12"
            LvProducto.Items.Add("QQQQ").Tag = "0005|10"
        End If
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

    End Sub
End Class
