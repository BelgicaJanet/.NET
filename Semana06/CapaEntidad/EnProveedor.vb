Public Class EnProveedor

    Private _PROV_ID As String
    Private _PROV_NOMBRE As String
    Private _PROV_RUC As Integer

    Public Property PROV_ID() As String
        Get
            Return _PROV_ID
        End Get
        Set(ByVal value As String)
            _PROV_ID = value
        End Set
    End Property


    Public Property PROV_NOMBRE() As String
        Get
            Return _PROV_NOMBRE
        End Get
        Set(ByVal value As String)
            _PROV_NOMBRE = value
        End Set
    End Property

    Public Property PROV_RUC() As Integer
        Get
            Return _PROV_RUC
        End Get
        Set(ByVal value As Integer)
            _PROV_RUC = value
        End Set
    End Property


End Class
