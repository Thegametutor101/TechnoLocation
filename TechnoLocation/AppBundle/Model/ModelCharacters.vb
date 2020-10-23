Imports MySql.Data.MySqlClient

Public Class ModelCharacters

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelCharacters = Nothing

    Public Shared Function getInstance() As ModelCharacters
        If IsNothing(instance) Then
            instance = New ModelCharacters()
        End If
        Return instance
    End Function

    Public Function addCharacter(passChar As Char, value As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into characters values('{passChar}', '{value}')"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function
End Class
