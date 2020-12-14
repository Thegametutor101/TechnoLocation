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
        Try
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
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer l'historique.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

End Class
