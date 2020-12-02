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

    Public Function getRent() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from rent R where code = '{code}'order by R.code"
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
        command.CommandText = $"Select * from rent R where renter = '{renter}'order by R.code"
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
        command.CommandText = $"Select * from rent R where lender = '{lender}'order by R.code"
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
        command.CommandText = $"Select * from rent R where equipment = '{equipment}'order by R.code"
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
        command.CommandText = $"Select * from rent R where returnDate = '{returnDate}'order by R.code"
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
        command.CommandText = $"Select * from rent R where (rentDate between '{dateBegin}' and '{dateEnd}') and (returnDate between '{dateBegin}' and '{dateEnd}' order by R.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("rents")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
