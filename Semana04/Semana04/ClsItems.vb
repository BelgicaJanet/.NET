Public Class ClsItems
    Private _codigo As Integer
    Private _nombre As String
    Private _tipoTraslado As Double
    Private _precioCosto As Double
    Private _precioVenta As Double

    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property tipoTraslado() As Double
        Get
            Return _tipoTraslado
        End Get
        Set(value As Double)
            _tipoTraslado = value
        End Set
    End Property

    Public Property precioCosto() As Double
        Get
            Return _precioCosto
        End Get
        Set(value As Double)
            _precioCosto = value
        End Set
    End Property

    Public Property precioVenta() As Double
        Get
            Return _precioVenta
        End Get
        Set(value As Double)
            _precioVenta = value
        End Set
    End Property

    Public Sub New()
        _codigo = 0 : _nombre = " " : _tipoTraslado = " " : _precioCosto = 0 : _precioVenta = 0
    End Sub

    Public Sub New(pCodigo As Integer, pNombre As String, pTipoTraslado As Double, pPrecioCosto As Double)
        _codigo = pCodigo : _nombre = pNombre : _tipoTraslado = pTipoTraslado : _precioCosto = pPrecioCosto
    End Sub

    Public Function calcularPrecioVenta(porcTipoTraslado As Double)

        Return precioCosto + precioCosto * 0.6 + precioCosto * porcTipoTraslado
    End Function
End Class
