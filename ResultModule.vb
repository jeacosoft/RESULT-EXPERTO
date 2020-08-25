Imports MySql.Data.MySqlClient

Module ResultModule
    Public sql As String
    Public ds As New DataSet
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter



    Public conn As New MySqlConnection
    Public Sub conndb()

        Try
            conn = New MySqlConnection("datasource=localhost;port=3306;username=Admin;password=almightygod;database=resultcal")
            conn.Open()


        Catch ex As Exception




        End Try


    End Sub



End Module
