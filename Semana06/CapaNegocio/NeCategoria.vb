Imports CapaDatos
Imports CapaEntidad

Public Class NeCategoria

    Public Shared Function ListarCategorias(pTipo As String, pCategoria As String) As DataTable
        Dim oDtCa As New DataTable
        oDtCa = DaCategoria.ConsultarCategoria(pTipo, pCategoria)
        Return (oDtCa)
    End Function

End Class
