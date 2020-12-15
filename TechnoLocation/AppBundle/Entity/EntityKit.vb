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
        Try
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
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les ensembles.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

End Class
