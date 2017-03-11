Public Class ClsProducto
    '***********************
    ' ATRIBUTOS DE LA CLASE
    '***********************
    Private _codigoProd As String
    Private _descripcionProd As String
    Private _precioProd As Double
    Private _stockProd As Integer

    Public Property codigoProd() As String
        Get
            Return _codigoProd
        End Get
        Set(value As String)
            _codigoProd = value
        End Set
    End Property

    Public Property descripcionProd() As String
        Get
            Return _descripcionProd
        End Get
        Set(value As String)
            _descripcionProd = value
        End Set
    End Property

    Public Property precioProd() As Double
        Get
            Return _precioProd
        End Get
        Set(value As Double)
            _precioProd = value
        End Set
    End Property

    Public Property stockProd() As Integer
        Get
            Return _stockProd
        End Get
        Set(value As Integer)
            _stockProd = value
        End Set
    End Property

    '**************************
    'CONSTRUCTORES DE LA CLASE
    '**************************
    Public Sub New()
        _codigoProd = "" : _descripcionProd = "" : _precioProd = 0 : _stockProd = 0
    End Sub

    Public Sub New(pCodigo As String, pDescripcion As String, pPrecio As Double, pCantidad As Integer)
        _codigoProd = pCodigo : _descripcionProd = pDescripcion : _precioProd = pPrecio : _stockProd = pCantidad
    End Sub

    '********************
    'METODOS DE LA CLASE
    '********************
    Public Function generaEtiqueta(pFormato As Integer)
        Dim strResp As String
        If pFormato = 1 Then
            strResp = "PRODUCTO: " & codigoProd & " - " & descripcionProd & vbCrLf & "PRECIO: " & precioProd
        Else
            strResp = "CODIGO: " & codigoProd & vbCrLf & "NOMBRE: " & descripcionProd & vbCrLf & "PRECIO: " & precioProd
        End If
        Return strResp
    End Function

    Public Function stockValorizado() As String
        Return precioProd * stockProd
    End Function
End Class
