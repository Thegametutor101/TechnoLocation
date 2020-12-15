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

    Public Function getHistory(lang As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SELECT H.code,
                                        DATE_FORMAT(H.dateReturned, '%d %M %Y') as returnDate,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        ) AS renterName,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        ) AS receptorName,
                                        CASE
                                            WHEN H.broken = 0 THEN 'Aucun défault'
                                            WHEN H.broken = 1 THEN 'Défectueux'
                                        END AS state,
                                        H.comments
                                    FROM history H
                                    ORDER BY H.code"
            Else
                command.CommandText = $"SELECT H.code,
                                        H.dateReturned,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        ) AS renterName,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        ) AS receptorName,
                                        CASE
                                            WHEN H.broken = 0 THEN 'No issues'
                                            WHEN H.broken = 1 THEN 'Broken'
                                        END AS state,
                                        H.comments
                                    FROM history H
                                    ORDER BY H.code"
            End If
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

    Public Function getHistoryBySearch(lang As String, value As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SELECT H.code,
                                        H.dateReturned,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        ) AS renterName,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        ) AS receptorName,
                                        CASE
                                            WHEN H.broken = 0 THEN 'Aucun défault'
                                            WHEN H.broken = 1 THEN 'Défectueux'
                                        END AS state,
                                        H.comments
                                    FROM history H
                                    WHERE upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        )) LIKE upper('%{value}%') OR
                                        upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        )) LIKE upper('%{value}%') OR
                                        upper(CASE
                                            WHEN H.broken = 0 THEN 'Aucun défault'
                                            WHEN H.broken = 1 THEN 'Défectueux'
                                        END) LIKE upper('%{value}%') OR
                                        upper(H.comments) LIKE upper('%{value}%')
                                    ORDER BY H.code"
            Else
                command.CommandText = $"SELECT H.code,
                                        H.dateReturned,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        ) AS renterName,
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        ) AS receptorName,
                                        CASE
                                            WHEN H.broken = 0 THEN 'No issues'
                                            WHEN H.broken = 1 THEN 'Broken'
                                        END AS state,
                                        H.comments
                                    FROM history H
                                    WHERE upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.renter 
                                        )) LIKE upper('%{value}%') OR
                                        upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            FROM user U 
                                            where U.code = H.acceptedBy 
                                        )) LIKE upper('%{value}%') OR
                                        upper(CASE
                                            WHEN H.broken = 0 THEN 'No issues'
                                            WHEN H.broken = 1 THEN 'Broken'
                                        END) LIKE upper('%{value}%') OR
                                        upper(H.comments) LIKE upper('%{value}%')
                                    ORDER BY H.code"
            End If
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
