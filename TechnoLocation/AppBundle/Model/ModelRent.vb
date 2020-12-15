Imports MySql.Data.MySqlClient
Public Class ModelRent
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelRent = Nothing

    Public Shared Function getInstance() As ModelRent
        If IsNothing(instance) Then
            instance = New ModelRent()
        End If
        Return instance
    End Function

    Public Function updateRent(code As Integer,
                               renter As Integer,
                               lender As Integer,
                               equipment As Integer,
                               rentDate As DateTime,
                               returnDate As DateTime,
                               deposit As Double,
                               comments As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update rent set renter='{renter}',
                                                    lender='{lender}',
                                                    equipment='{equipment}',
                                                    rentDate='{rentDate}',
                                                    returnDate='{returnDate}',
                                                    deposit='{deposit}',
                                                    comments='{comments}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à la mise à jour de l'emprunt {code}.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function addRent(code As Integer,
                            renter As Integer,
                            lender As Integer,
                            equipment As Integer,
                            rentDate As DateTime,
                            returnDate As DateTime,
                            deposit As Double,
                            comments As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into rent values ('{code}',
                                                             '{renter}',
                                                             '{lender}',
                                                             '{equipment}',
                                                             '{rentDate}',
                                                             '{returnDate}',
                                                             '{deposit}',
                                                             '{comments}')"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à l'ajout de l'emprunt.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function removeRental(code As Integer, equipment As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"DELETE FROM rent 
                                    WHERE code = '{code}' AND
                                        equipment = '{equipment}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show($"Échec à la supression de l'emprunt {code}.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

End Class
