Imports MySql.Data.MySqlClient
Public Class EntityKit
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityKit = Nothing

    Public Shared Function getInstance() As EntityKit
        If IsNothing(instance) Then
            instance = New EntityKit()
        End If
        Return instance
    End Function

    Public Function getKit() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from kit K order by K.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("kits")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getKitCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from kit K where code = '{code}'order by K.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("kits")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getKitName(name As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from kit K where name like '%{name}%'order by K.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("kits")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
