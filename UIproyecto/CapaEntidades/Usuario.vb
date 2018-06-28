Public Class Usuario
    Private _Cedula As Integer
    Private _Nombre As String
    Private _Apellido As String
    Private _nom_Usuario As String
    Private _Contraseña As String
    Private _Telefono As Integer
    Private _Email As String
    Private _Dirección As String
    Public Property Cedula As Integer
        Get
            Return _Cedula
        End Get
        Set(value As Integer)
            _Cedula = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    Public Property nomUsuario As String
        Get
            Return _nom_Usuario
        End Get
        Set(ByVal value As String)
            _nom_Usuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _Contraseña
        End Get
        Set(ByVal value As String)
            _Contraseña = value
        End Set
    End Property
    Public Property Telefono As Integer
        Get
            Return _Telefono
        End Get
        Set(ByVal value As Integer)
            _Telefono = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Dirección
        End Get
        Set(ByVal value As String)
            _Dirección = value
        End Set
    End Property


    Public Sub New()
    End Sub
End Class
