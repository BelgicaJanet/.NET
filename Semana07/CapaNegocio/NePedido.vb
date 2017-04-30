Imports CapaDatos
Imports CapaEntidad

Public Class NePedido
    Public Shared Function ListarPedido(pStrFilter As String, pStrLstCampos As String) As DataTable
        Dim odtPed As New DataTable
        DaProducto.buscarProducto(pStrFilter, pStrLstCampos).Fill(odtPed)

        Return odtPed
    End Function

End Class
