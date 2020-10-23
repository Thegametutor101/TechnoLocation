Imports MySql.Data.MySqlClient

Public Class EntityUser

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityUser = Nothing

    Public Shared Function getInstance() As EntityUser
        If IsNothing(instance) Then
            instance = New EntityUser()
        End If
        Return instance
    End Function

    Public Function testConnection() As Boolean
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim cmd As New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME " &
                                    "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @DbName), 'Y','N')", connection)
        cmd.Parameters.AddWithValue("@DbName", "projetsession")
        connection.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        Console.WriteLine(exists)
        connection.Close()
        Return exists = "Y"
    End Function

    Public Function getUsers() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from user U order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUserCodes() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code from user U order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUserPasswords() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select password from user U order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
