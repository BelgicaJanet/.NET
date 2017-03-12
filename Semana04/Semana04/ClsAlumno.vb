Public Class ClsAlumno
    '***********************
    ' ATRIBUTOS DE LA CLASE
    '***********************

    Private _codigo As Integer
    Private _nombre As String
    Private _apePaterno As String
    Private _apeMaterno As String
    Private _sexo As Char
    Private _edad As Integer


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

    Public Property apePaterno() As String
        Get
            Return _apePaterno
        End Get
        Set(value As String)
            _apePaterno = value
        End Set
    End Property
   

    Public Property apeMaterno() As String
        Get
            Return _apeMaterno
        End Get
        Set(value As String)
            _apeMaterno = value
        End Set
    End Property
    Public Property sexo() As Char
        Get
            Return _sexo
        End Get
        Set(value As Char)
            _sexo = value
        End Set
    End Property

    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    '**************************
    'CONSTRUCTORES DE LA CLASE
    '**************************
    Public Sub New()
        _codigo = 0 : _nombre = " " : _apePaterno = " " : _apeMaterno = " " : _sexo = " " : _edad = 0
    End Sub

    Public Sub New(pCodigo As Integer, pNombre As String, pApePaterno As String, pApeMaterno As String, pSexo As Char, pEdad As Integer)
        _codigo = pCodigo : _nombre = pNombre : _apePaterno = pApePaterno : _apeMaterno = pApeMaterno : _sexo = pSexo : _edad = pEdad
    End Sub

    '********************
    'METODOS DE LA CLASE
    '********************
    Public Function datosAlumno(pFormato As Integer)
        Dim forma As String

        If pFormato = 1 Then
            forma = "NOMBRE: " & nombre & " APELLIDO: " & apellido
        ElseIf 
            forma = " APELLIDO: " & apellido & "NOMBRE: " & nombre
        End If

    End Function

End Class
