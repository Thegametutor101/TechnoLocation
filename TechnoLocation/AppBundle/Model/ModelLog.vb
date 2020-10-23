Imports MySql.Data.MySqlClient
Public Class ModelLog
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelLog = Nothing

    Public Shared Function getInstance() As ModelLog
        If IsNothing(instance) Then
            instance = New ModelLog()
        End If
        Return instance
    End Function

    Public Function updateLog(code As Integer, admin As Integer, action As String, dateModified As DateTime, tableName As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update log set code='{code}',admin='{admin}',action='{action}',dateModified='{dateModified}', tableName='{tableName}' where code='{code}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from log"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addLog(admin As Integer, action As String, dateModified As DateTime, tableName As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into log values ('{admin}','{action}','{dateModified}', '{tableName}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delLog(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from log where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
