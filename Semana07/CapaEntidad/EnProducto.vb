Public Class EnProducto
    Private _PROD_ID
    Private _PROD_DESCRIPCION
    Private _PROD_DESC_CORTA
    Private _PROD_PRECIO
    Private _PROD_STOCK
    Private _PROD_ESTADO


    Public Property PROD_ID() As String
        Get
            Return _PROD_ID
        End Get
        Set(value As String)
            _PROD_ID = value
        End Set
    End Property

    Public Property PROD_DESCRIPCION() As String
        Get
            Return _PROD_DESCRIPCION
        End Get
        Set(value As String)
            _PROD_DESCRIPCION = value
        End Set
    End Property

    Public Property PROD_DESC_CORTA() As String
        Get
            Return _PROD_DESC_CORTA
        End Get
        Set(value As String)
            _PROD_DESC_CORTA = value
        End Set
    End Property

    Public Property PROD_PRECIO() As Integer
        Get
            Return _PROD_PRECIO
        End Get
        Set(value As Integer)
            _PROD_PRECIO = value
        End Set
    End Property

    Public Property PROD_STOCK() As String
        Get
            Return _PROD_STOCK
        End Get
        Set(value As String)
            _PROD_STOCK = value
        End Set
    End Property


    Public Property PROD_ESTADO() As String
        Get
            Return _PROD_ESTADO
        End Get
        Set(value As String)
            _PROD_ESTADO = value
        End Set
    End Property

End Class
