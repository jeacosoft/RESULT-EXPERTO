Imports MySql.Data.MySqlClient

Public Class LOGIN_REG_CONNECTION
    Dim connection As New MySqlConnection("Datasource = localhost; Port = 3306; Username = Admin; Password =almightygod; Database=resultcal")
    ReadOnly Property getconnection() As MySqlConnection
        Get
            Return connection
        End Get

    End Property
    Sub Openconnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub
    Sub closeConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If
    End Sub


End Class
