Public Class EnProducto

    Private _PROD_ID As String
    Private _PROD_DESCRIPCION As String
    Private _PROD_DESC_CORTA As String
    Private _PROD_PRECIO As Double
    Private _PROD_STOCK As Integer
    Private _PROD_ESTADO As Boolean


    Public Property PROD_ID() As String
        Get
            Return _PROD_ID
        End Get
        Set(ByVal value As String)
            _PROD_ID = value
        End Set
    End Property

    Public Property PROD_DESCRIPCION() As String
        Get
            Return _PROD_DESCRIPCION
        End Get
        Set(ByVal value As String)
            _PROD_DESCRIPCION = value
        End Set
    End Property


    Public Property PROD_DESC_CORTA() As String
        Get
            Return _PROD_DESC_CORTA
        End Get
        Set(ByVal value As String)
            _PROD_DESC_CORTA = value
        End Set
    End Property

    Public Property PROD_PRECIO() As Double
        Get
            Return _PROD_PRECIO
        End Get
        Set(ByVal value As Double)
            _PROD_PRECIO = value
        End Set
    End Property

    Public Property PROD_STOCK() As Integer
        Get
            Return _PROD_STOCK
        End Get
        Set(ByVal value As Integer)
            _PROD_STOCK = value
        End Set
    End Property

    Public Property PROD_ESTADO() As Boolean
        Get
            Return _PROD_ESTADO
        End Get
        Set(ByVal value As Boolean)
            _PROD_ESTADO = value
        End Set
    End Property




End Class
