Imports MySql.Data.MySqlClient
Public Class Datos
    Private oSql As String
    Public oLector As MySqlDataReader
    Dim sqlconection = New MySqlConnection()
    Dim sqlcommand As New MySqlCommand()
    
    Public Function AgregarUsuario(ByVal U As Usuario) As Integer
        sqlconection.connectionString = Conexion.cnn

        Try
            oSql = "insert into t_Usuario (Cedula, Nombre, Apellido, nom_Usuario, Contraseña, Telefono, Email, Dirección)  values(" & U.Cedula & ", '" & U.Nombre & "','" & U.Apellido & "','" & U.nomUsuario & "','" & U.Contraseña & "'," & U.Telefono & ",'" & U.Email & "','" & U.Direccion & "')"


            sqlconection.Open()
            sqlcommand.Connection = sqlconection
            sqlcommand.CommandText = oSql
            sqlcommand.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            Return 0
        Finally
            sqlconection.close()
        End Try

    End Function
    Public Function BuscarUsuario(ByVal CI As Integer) As Usuario
        sqlconection.connectionString = Conexion.cnn
        Dim Paux As Usuario
        oSql = " Select * from t_Usuario where Cedula= " & CI & ""
        sqlcommand = New MySqlCommand(oSql, sqlconection)
        Try
            sqlconection.open()
            oLector = sqlcommand.ExecuteReader
            Paux = New Usuario
            While oLector.Read()


                Paux.Cedula = CInt(oLector("Cedula"))
                Paux.Nombre = DirectCast(oLector("Nombre"), String)
                Paux.Apellido = DirectCast(oLector("Apellido"), String)
                Paux.nomUsuario = DirectCast(oLector("Usuario"), String)
                Paux.Contraseña = DirectCast(oLector("Password"), String)
                Paux.Telefono = CInt(oLector("Telefono"))
                Paux.Email = DirectCast(oLector("Email"), String)
                Paux.Direccion = DirectCast(oLector("Direccion"), String)
            End While
            Return Paux
        Catch ex As Exception
            Paux = New Usuario
            Return Paux

        Finally
            sqlconection.close()

        End Try
    End Function
    Public Sub New()

    End Sub
   


End Class
