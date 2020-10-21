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

    Public Function getRentals() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Emprunté_par, initcap(E.autorisation) as autorisation from emprunt E inner join personne P on E.noPersonne = P.noPersonne order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
