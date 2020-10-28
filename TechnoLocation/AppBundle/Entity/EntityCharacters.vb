Imports MySql.Data.MySqlClient

Public Class EntityCharacters

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityCharacters = Nothing

    Public Shared Function getInstance() As EntityCharacters
        If IsNothing(instance) Then
            instance = New EntityCharacters()
        End If
        Return instance
    End Function

    Public Function getCharacters() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select passChar, value from characters"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("characters")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
