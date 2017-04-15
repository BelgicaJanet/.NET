Imports CapaDatos
Imports CapaEntidad
Public Class Necategoria
    Public Shared Function GuardarCategoria(ByVal pTipo As String, ByVal pCategoria As EnCategoria) As String
        GuardarCategoria = DaCategoria.GuardarCategoria(pTipo, pCategoria)
        Return (GuardarCategoria)
    End Function
End Class
