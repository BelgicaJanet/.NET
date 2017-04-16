Public Class EnPedido
    Private _PED_ID As String
    Private _PED_FECHA As Date
    Private _PED_CLIENTE As String
    Private _USR_ID As String
    Private _PED_ESTADO As String


    Public Property PED_ID() As String
        Get
            Return _PED_ID
        End Get
        Set(ByVal value As String)
            _PED_ID = value
        End Set
    End Property

    Public Property PED_CLIENTE() As String
        Get
            Return _PED_CLIENTE
        End Get
        Set(ByVal value As String)
            _PED_CLIENTE = value
        End Set
    End Property
    Public Property PED_FECHA() As String
        Get
            Return _PED_FECHA
        End Get
        Set(ByVal value As String)
            _PED_FECHA = value
        End Set
    End Property

    Public Property USR_ID() As String
        Get
            Return _USR_ID
        End Get
        Set(ByVal value As String)
            _USR_ID = value
        End Set
    End Property

    Public Property PED_ESTADO() As String
        Get
            Return _PED_ESTADO
        End Get
        Set(ByVal value As String)
            _PED_ESTADO = value
        End Set
    End Property



End Class
