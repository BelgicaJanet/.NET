Imports CapaEntidad
Public Class DaCategoria
    Public Shared Function GuardarCategoria(ByVal strTipo As String, ByVal pCategoria As EnCategoria) As String
        Try
            Dim oConn As New SqlClient.SqlConnection
            Dim oCmd As New SqlClient.SqlCommand
            oConn.ConnectionString = Conexion.CadenaConexion
            oConn.Open()
            oCmd.Connection = oConn
            oCmd.CommandText = "sp_mant_categoria"
            oCmd.CommandType = CommandType.StoredProcedure
            'Parametro de Entrada
            oCmd.Parameters.Add("@TIPO", SqlDbType.Char, 1).Value = strTipo
            oCmd.Parameters.Add("@CAT_ID", SqlDbType.Char, 2).Value = pCategoria.CAT_ID
            oCmd.Parameters.Add("@CAT_DESCRIPCION", SqlDbType.VarChar, 100).Value = pCategoria.CAT_DESCRIPCION
            oCmd.Parameters.Add("@CAT_ORDEN", SqlDbType.Int).Value = pCategoria.CAT_ORDEN
            oCmd.Parameters.Add("@CAT_ESTADO", SqlDbType.Char, 1).Value = pCategoria.CAT_ESTADO
            oCmd.ExecuteNonQuery()
            oConn.Close()
            Return "OK"
        Catch e As Exception
            MsgBox(e.ToString)
            Return "**"
        End Try
    End Function
End Class
