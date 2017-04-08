Public Class EnUsuario
    Private _USR_ID As String
    Private _USR_NOMBRE As String
    Private _USR_APELLIDO As String
    Private _USR_CLAVE As String
    Private _USR_ESTADO As String

    Public Property USR_ID() As String
        Get
            Return _USR_ID
        End Get
        Set(ByVal value As String)
            _USR_ID = value
        End Set
    End Property

    Public Property USR_NOMBRE() As String
        Get
            Return _USR_NOMBRE
        End Get
        Set(ByVal value As String)
            _USR_NOMBRE = value
        End Set
    End Property

    Public Property USR_APELLIDO() As String
        Get
            Return _USR_APELLIDO
        End Get
        Set(ByVal value As String)
            _USR_APELLIDO = value
        End Set
    End Property

    Public Property USR_CLAVE() As String
        Get
            Return _USR_CLAVE
        End Get
        Set(ByVal value As String)
            _USR_CLAVE = value
        End Set
    End Property

    Public Property USR_ESTADO() As String
        Get
            Return _USR_ESTADO
        End Get
        Set(ByVal value As String)
            _USR_ESTADO = value
        End Set
    End Property
End Class
