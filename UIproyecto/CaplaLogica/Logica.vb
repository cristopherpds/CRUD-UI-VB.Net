Public Class Logica
    Dim U As New Usuario
    Dim D As New Datos
    Public Function AgregarUsuario(ByVal U As Usuario) As String

        Dim Paux = D.BuscarUsuario(U.Cedula)
        If Paux.Cedula = U.Cedula Then
            Return "YA EXISTE"
        Else
            Dim resultado = D.AgregarUsuario(U)
            If resultado = 1 Then
                Return "Se Guardo"
            Else
                Return "no, se guardo"
            End If


        End If
    End Function
    
    Public Sub New()

    End Sub

End Class
