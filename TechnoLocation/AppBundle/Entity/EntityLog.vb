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

    Public Function getLog() As DataTable
        Try
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
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les logs.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

End Class
