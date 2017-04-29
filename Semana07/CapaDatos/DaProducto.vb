Imports CapaEntidad
Public Class DaProducto
    Public Shared Function buscarProducto(pStrFilter As String, pStrLstCampos As String) As IDataAdapter
        Dim oDa As New SqlClient.SqlDataAdapter

        Try
            Dim strSql As String = "SELECT * FROM PEDIDO P, USUARIO U WHERE P.USR_ID = U.USR_ID" & pStrLstCampos
            Dim oConn As New SqlClient.SqlConnection
            oConn.ConnectionString = Conexion.CadenaConexion
            oConn.Open()
            oDa = New SqlClient.SqlDataAdapter(strSql, oConn)
            oConn.Close()
            Return oDa
        Catch e As Exception
            MsgBox(e.ToString)
            Return oDa
        End Try
    End Function


End Class
