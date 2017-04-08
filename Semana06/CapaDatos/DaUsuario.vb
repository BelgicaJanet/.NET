Imports CapaEntidad
Public Class DaUsuario
    Shared strSql As String

    Public Shared Function ListadoUsuarios(pTipo As String, pUsrId As String) As DataTable
        Dim oDt As New DataTable
        Dim oConn As New SqlClient.SqlConnection
        Dim oCmd As New SqlClient.SqlCommand
        oConn.ConnectionString = Conexion.CadenaConexion
        oConn.Open()
        oCmd.Connection = oConn
        oCmd.CommandText = "SP_CONSULTA_USUARIO"
        oCmd.CommandType = CommandType.StoredProcedure
        'Parametro de Entrada
        oCmd.Parameters.Add("@TIPO", SqlDbType.Char, 1).Value = pTipo
        oCmd.Parameters.Add("@USR_ID", SqlDbType.Char, 5).Value = pUsrId
        oDt.Load(oCmd.ExecuteReader)
        oConn.Close()
        Return oDt
    End Function

    Public Shared Function ValidarUsuario(pUsrId As String, pUsrClave As String) As SqlClient.SqlDataAdapter
        Dim oDa As New SqlClient.SqlDataAdapter
        Try
            strSql = "SELECT * FROM USUARIO WHERE USR_ID='" & pUsrId & "' AND USR_CLAVE='" & pUsrClave & "'"
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
