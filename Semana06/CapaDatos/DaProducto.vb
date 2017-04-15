Imports CapaEntidad
Public Class DaProducto

    Shared strSql As String

    Public Shared Function ConsultarProducto(pTipo As String, pProducto As String, pCategoria As String) As DataTable
        Dim oDt As New DataTable
        Dim oConn As New SqlClient.SqlConnection
        Dim oCmd As New SqlClient.SqlCommand
        oConn.ConnectionString = Conexion.CadenaConexion
        oConn.Open()
        oCmd.Connection = oConn
        oCmd.CommandText = "SP_CONSULTA_PRODUCTO"
        oCmd.CommandType = CommandType.StoredProcedure
        'Parametro de Entrada
        oCmd.Parameters.Add("@TIPO", SqlDbType.Char, 1).Value = pTipo
        oCmd.Parameters.Add("@PROD_ID", SqlDbType.Char, 4).Value = pProducto
        oCmd.Parameters.Add("@CAT_ID", SqlDbType.Char, 2).Value = pCategoria
        oDt.Load(oCmd.ExecuteReader)
        oConn.Close()
        Return oDt
    End Function


    Public Shared Function GuardarProducto(ByVal strTipo As String, ByVal pProducto As EnProducto) As String

        Try
            Dim oConn As New SqlClient.SqlConnection
            Dim oCmd As New SqlClient.SqlCommand
            oConn.ConnectionString = Conexion.CadenaConexion
            oConn.Open()
            oCmd.Connection = oConn
            oCmd.CommandText = "SP_MANT_PRODUCTO"
            oCmd.CommandType = CommandType.StoredProcedure
            'Parametro de Entrada
            oCmd.Parameters.Add("@TIPO", SqlDbType.Char, 1).Value = strTipo
            oCmd.Parameters.Add("@PROD_ID", SqlDbType.Char, 4).Value = pProducto.PROD_ID
            oCmd.Parameters.Add("@PROD_DESCRIPCION", SqlDbType.VarChar, 200).Value = pProducto.PROD_DESCRIPCION
            oCmd.Parameters.Add("@PROD_DESC_CORTA", SqlDbType.VarChar, 100).Value = pProducto.PROD_DESC_CORTA
            oCmd.Parameters.Add("@PROD_PRECIO", SqlDbType.Decimal, 10, 2).Value = pProducto.PROD_PRECIO
            oCmd.Parameters.Add("@PROD_STOCK", SqlDbType.Int, 5).Value = pProducto.PROD_STOCK
            oCmd.Parameters.Add("@PROD_ESTADO", SqlDbType.Char, 1).Value = pProducto.PROD_ESTADO
            oCmd.ExecuteNonQuery()
            oConn.Close()
            Return "OK"
        Catch e As Exception
            MsgBox(e.ToString)
            Return "**"
        End Try
    End Function




End Class
