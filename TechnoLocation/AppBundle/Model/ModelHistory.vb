Imports MySql.Data.MySqlClient
Public Class ModelHistory
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelHistory = Nothing

    Public Shared Function getInstance() As ModelHistory
        If IsNothing(instance) Then
            instance = New ModelHistory()
        End If
        Return instance
    End Function

    Public Function updateHistory(code As Integer, jour As DateTime, admin As Integer, broken As Integer, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update history set code='{code}',date='{jour}',admin='{admin}',broken='{broken}', comments='{comments}' where code='{code}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from history"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addHistory(jour As DateTime, admin As Integer, broken As Integer, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into history values ('{jour}','{admin}','{broken}', '{comments}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delHistory(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from history where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
