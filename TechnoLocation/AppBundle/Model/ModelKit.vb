Imports MySql.Data.MySqlClient
Public Class ModelKit
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelKit = Nothing

    Public Shared Function getInstance() As ModelKit
        If IsNothing(instance) Then
            instance = New ModelKit()
        End If
        Return instance
    End Function

    Public Function updateKit(code As Integer, name As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update kit set code='{code}', name='{name}' where code='{code}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from kit"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addKit(name As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into kit values ('{name}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delKit(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from kit where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
