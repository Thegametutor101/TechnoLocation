Imports MySql.Data.MySqlClient
Public Class EntityRent

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityRent = Nothing

    Public Shared Function getInstance() As EntityRent
        If IsNothing(instance) Then
            instance = New EntityRent()
        End If
        Return instance
    End Function

    Public Function getRentals(lang As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SET lc_time_names = 'fr_CA';
                                Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') AS rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') AS returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                GROUP BY R.code"
            Else
                command.CommandText = $"SET lc_time_names = 'en_US';
                                Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                GROUP BY R.code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rentals")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les emprunts.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getRentalsBySearch(lang As String, value As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SET lc_time_names = 'fr_CA';
                                    Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                WHERE upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        )) LIKE upper('%{value}%') OR
                                    upper(( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        )) LIKE upper('%{value}%') OR
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') LIKE upper('%{value}%') OR
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') LIKE upper('%{value}%')
                                GROUP BY R.code"
            Else
                command.CommandText = $"SET lc_time_names = 'en_US';
                                    Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                WHERE upper(( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        )) LIKE upper('%{value}%') OR
                                    upper(( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        )) LIKE upper('%{value}%') OR
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') LIKE upper('%{value}%') OR
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') LIKE upper('%{value}%')
                                GROUP BY R.code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rentals")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les emprunts filtrés.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getLateRentals(lang As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim today = DateTime.Now
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SET lc_time_names = 'fr_CA';
                                    Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                WHERE R.returnDate < CURRENT_DATE
                                GROUP BY R.code"
            Else
                command.CommandText = $"SET lc_time_names = 'en_US';
                                    Select R.code, 
                                        ( 
                                            SELECT initcap(CONCAT(U.lastName, ', ', U.firstName)) 
                                            from user U 
                                            where U.code = R.renter 
                                        ) AS renterName, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        COUNT(R.equipment) as equipmentAmount,
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                WHERE R.returnDate < CURRENT_DATE
                                GROUP BY R.code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rentals")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les emprunts en retards.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getRentalDetails(lang As String, code As Integer) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                lang = "fr_CA"
            Else
                lang = "en_US"
            End If
            command.CommandText = $"SET lc_time_names = '{lang}';
                                    Select U.firstName,
                                        U.lastName,
                                        U.email,
                                        CASE
                                        	WHEN U.extensionMain IS NULL THEN U.phoneMain
                                            WHEN U.extensionMain IS NOT NULL THEN CAST(CONCAT(U.phoneMain, ' #', U.extensionMain) AS CHAR)
                                        END AS phoneMain, 
                                        CASE
                                        	WHEN U.extension2 IS NULL THEN U.phone2
                                            WHEN U.extension2 IS NOT NULL THEN CAST(CONCAT(U.phone2, ' #', U.extension2) AS CHAR)
                                        END AS phone2, 
                                        ( 
                                            SELECT initcap(CONCAT(U1.lastName, ', ', U1.firstName)) 
                                            from user U1 
                                            where U1.code = R.lender 
                                        ) AS lenderName, 
                                        DATE_FORMAT(R.rentDate, '%d %M %Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d %M %Y') as returnDate, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(( 
                                            SELECT SUM(R1.deposit) 
                                            from rent R1 
                                            where R1.code = R.code AND 
                                                R1.renter = R.renter AND 
                                                R1.lender = R.lender 
                                            GROUP BY R1.code 
                                        ), 2)), '.', ',') AS CHAR) AS depositAmount 
                                from rent R 
                                INNER JOIN user U on U.code = R.renter
                                WHERE R.code = {code}
                                GROUP BY R.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rents")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Échec à la recherche des détails de l'emprunt.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getRentCount() As Integer
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select count(code) from rent"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rents")
            table.Load(reader)
            connection.Close()
            Return table.Rows.Item(0).Item(0)
        Catch ex As Exception
            MessageBox.Show($"Échec au compte des emprunts.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getRentDeposits() As Double
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select sum(deposit) from rent"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rents")
            table.Load(reader)
            connection.Close()
            Return table.Rows.Item(0).Item(0)
        Catch ex As Exception
            MessageBox.Show($"Échec au compte du montant de dépots.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getRentBetweenDate(dateBegin As Date, dateEnd As Date) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select equipment from rent R 
                                where (rentDate between '{dateBegin}' and '{dateEnd}') and 
                                (returnDate between '{dateBegin}' and '{dateEnd}') 
                                order by R.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("rents")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Échec à la validation de dates.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getLastIDRent() As Integer
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select max(code) from rent"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table.Rows(0).ItemArray(0)
    End Function
End Class
