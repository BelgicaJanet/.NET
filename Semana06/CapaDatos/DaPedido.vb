Imports CapaEntidad
Public Class DaPedido
    Shared strSql As String

    Public Shared Function AgregarPedido(pTipo As String, pId As String, pFecha As Date, pCliente As String, pUsrId As String, pEstado As String) As DataTable
        Dim oDTPe As New DataTable
        Dim oConn As New SqlClient.SqlConnection
        Dim oCmd As New SqlClient.SqlCommand
        oCmd.Connection = oConn
        oCmd.CommandText = "SP_MANT_PEDIDO"
        oCmd.CommandType = CommandType.StoredProcedure
        oCmd.Parameters.Add("@TIPO", SqlDbType.Char, 1).Value = pTipo
        oCmd.Parameters.Add("@PED_ID", SqlDbType.Char, 8).Value = pId
        oCmd.Parameters.Add("@PED_FECHA", SqlDbType.Date).Value = pFecha
        oCmd.Parameters.Add("@PED_CLIENTE", SqlDbType.Char, 255).Value = pCliente
        oCmd.Parameters.Add("@USR_ID", SqlDbType.Char, 5).Value = pUsrId
        oCmd.Parameters.Add("@PED_ESTADO", SqlDbType.Char, 1).Value = pEstado
        oDTPe.Load(oCmd.ExecuteReader)
        oConn.Close()
        Return oDTPe
    End Function

End Class

