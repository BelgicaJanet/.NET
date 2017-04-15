Public Class EnCategoria
    Private _CAT_ID As String
    Private _CAT_DESCRIPCION As String
    Private _CAT_ORDEN As Integer
    Private _CAT_ESTADO As String

    Public Property CAT_ID() As String
        Get
            Return _CAT_ID
        End Get
        Set(ByVal value As String)
            _CAT_ID = value
        End Set
    End Property

    Public Property CAT_DESCRIPCION() As String
        Get
            Return _CAT_DESCRIPCION
        End Get
        Set(ByVal value As String)
            _CAT_DESCRIPCION = value
        End Set
    End Property

    Public Property CAT_ORDEN() As Integer
        Get
            Return _CAT_ORDEN
        End Get
        Set(ByVal value As Integer)
            _CAT_ORDEN = value
        End Set
    End Property

    Public Property CAT_ESTADO() As String
        Get
            Return _CAT_ESTADO
        End Get
        Set(ByVal value As String)
            _CAT_ESTADO = value
        End Set
    End Property

End Class
