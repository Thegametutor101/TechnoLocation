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

    Public Function removeHistory(code As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"DELETE FROM history 
                                    WHERE code = '{code}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à la supression de l'historique {code}.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function removeAllHistory()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"DELETE FROM history"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à la supression de l'historique complet.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function removeHistoryBeforeDate(value As DateTime)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"DELETE FROM history 
                                    WHERE dateReturned < '{value}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à la supression de l'historique plus vieux que {value}.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

End Class
