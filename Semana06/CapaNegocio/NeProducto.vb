Imports CapaDatos
Imports CapaEntidad

Public Class NeProducto


    Public Shared Function ListadoProductos(pTipo As String, pProducto As String, pCategoria As String) As DataTable
        Dim oDtProd As New DataTable
        oDtProd = DaProducto.ConsultarProducto(pTipo, pProducto, pCategoria)
        Return (oDtProd)
    End Function

End Class
