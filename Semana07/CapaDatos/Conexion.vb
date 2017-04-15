Public Class Conexion
    Shared _cadenaConexion As String = "Data Source=(local);Initial Catalog=bdfastfood; Integrated security=true"
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
End Class
