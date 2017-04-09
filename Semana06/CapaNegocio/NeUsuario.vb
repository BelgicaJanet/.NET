Imports CapaDatos
Imports CapaEntidad

Public Class NeUsuario
    Public Shared Function ListadoUsuarios(pTipo As String, pUsrId As String) As DataTable
        Dim oDt As New DataTable
        oDt = DaUsuario.ConsultarUsuarios(pTipo, pUsrId)
        Return (oDt)
    End Function

    Public Shared Function ValidarUsuario(pUsrId As String, pUsrclave As String) As DataTable
        Dim oDtUsuario As New DataTable
        DaUsuario.ValidarUsuario(pUsrId, pUsrclave).Fill(oDtUsuario)
        Return (oDtUsuario)
    End Function

End Class
