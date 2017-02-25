Public Class FrmEjemplo03
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Definir Producto Como Cadena;
        Dim Producto As String
        'Definir Cantidad Como Entero;
        Dim Cantidad As Integer
        'Definir Precio, Importe, Igv, Total Como Real;
        Dim Precio As Double, Importe As Double, Igv As Double, Total As Double

        'Leer Producto;
        Producto = TxtProducto.Text
        'Leer Precio;	
        Precio = TxtPrecio.Text
        'Leer Cantidad;
        Cantidad = TxtCantidad.Text

        'Importe <- Precio * Cantidad;
        'Igv <- Importe * 0.18;
        'Total <- Importe + Igv;
        Importe = Precio * Cantidad
        Igv = Importe * 0.18
        Total = Importe + Igv

        'Escribir "Importe : ", Importe;
        TxtImporte.Text = Importe
        'Escribir "Igv 18% : ", Igv;
        TxtIgv.Text = Igv
        'Escribir "Total   : ", Total;
        TxtTotal.Text = Total
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtProducto.Text = ""
        TxtPrecio.Text = ""
        TxtCantidad.Text = ""
        TxtImporte.Text = ""
        TxtIgv.Text = ""
        TxtTotal.Text = ""
        TxtProducto.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class