
Imports CapaDatos
Imports CapaEntidad
Public Class NePedido

    Public Shared Function AgregarPedido(pTipo As String, pId As String, pFecha As Date, pCliente As String, pUsrId As String, pEstado As String) As DataTable
        Dim oDtPe As New DataTable
        oDtPe = DaPedido.AgregarPedido(pTipo, pId, pFecha, pCliente, pUsrId, pEstado)
        Return (oDtPe)
    End Function
End Class
