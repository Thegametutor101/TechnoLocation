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

    Public Function getRentals() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select R.code, 
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
                                        DATE_FORMAT(R.rentDate, '%d/%m/%Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d/%m/%Y') as returnDate, 
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
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rentals")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsBySearch(value As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select R.code, 
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
                                        DATE_FORMAT(R.rentDate, '%d/%m/%Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d/%m/%Y') as returnDate, 
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
                                        DATE_FORMAT(R.rentDate, '%d/%m/%Y') LIKE upper('%{value}%') OR
                                        DATE_FORMAT(R.returnDate, '%d/%m/%Y') LIKE upper('%{value}%')
                                GROUP BY R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rentals")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getLateRentals() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim today = DateTime.Now
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select R.code, 
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
                                        DATE_FORMAT(R.rentDate, '%d/%m/%Y') as rentDate, 
                                        DATE_FORMAT(R.returnDate, '%d/%m/%Y') as returnDate, 
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
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rentals")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalByCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentRenter(renter As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where renter = '{renter}' order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentLender(lender As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where lender = '{lender}' order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentEquipment(equipment As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where equipment = '{equipment}' order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentDate(rentDate As Date) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where rentDate = '{rentDate}'order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentReturnDate(returnDate As Date) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where returnDate = '{returnDate}' order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentCount() As Integer
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
    End Function

    Public Function getRentDeposits() As Double
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
    End Function

    Public Function getRentBetweenDate(dateBegin As Date, dateEnd As Date) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R 
                                where (rentDate between '{dateBegin}' and '{dateEnd}') and 
                                (returnDate between '{dateBegin}' and '{dateEnd}') 
                                order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
