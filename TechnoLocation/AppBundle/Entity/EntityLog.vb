Imports MySql.Data.MySqlClient
Public Class EntityLog

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityLog = Nothing

    Public Shared Function getInstance() As EntityLog
        If IsNothing(instance) Then
            instance = New EntityLog()
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

    Public Function getLog() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from log L order by L.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("logs")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getLogCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from log L where code = '{code}'order by L.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("logs")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
