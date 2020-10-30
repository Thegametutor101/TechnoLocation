Imports MySql.Data.MySqlClient
Public Class EntityHistory

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityHistory = Nothing

    Public Shared Function getInstance() As EntityHistory
        If IsNothing(instance) Then
            instance = New EntityHistory()
        End If
        Return instance
    End Function

    Public Function getHistory() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from history"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("history")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getHistoryCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from history where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("history")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getHistoryDate(day As Date) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from history where date = '{day}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("history")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
