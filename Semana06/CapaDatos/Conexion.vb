Public Class Conexion
    Shared _cadenaConexion As String = "Data Source= belgica123.database.windows.net; Initial Catalog= testdatabase; User Id=belgica; Password=JButton123"
    '"Data Source=(local);Initial Catalog=bdFastFood; Integrated security=true"
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
End Class
