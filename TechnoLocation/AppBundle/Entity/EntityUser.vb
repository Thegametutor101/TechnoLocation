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
        cmd.Parameters.AddWithValue("@DbName", "technolocation")
        connection.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        Console.WriteLine(exists)
        connection.Close()
        Return exists = "Y"
    End Function

    Public Function getUsers() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUserAccounts() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, password from user"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersPassword(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select password from user U where code = '{code}' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersCode(code As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where code = '{code}' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUserByCode(code As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from user U where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("user")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersFirstName(firstName As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where firstName like '{firstName}%' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersLastName(lastName As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where lastName like '{lastName}%' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersEmail(email As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where email like '{email}%' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersPhone(phone As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where phoneMain like '{phone}%' || phone2 like '{phone}%' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersJob(job As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select code, firstName, lastName, email, phoneMain, phone2, job, balance from user U where job like '{job}' order by U.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersCount() As Integer
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select count(code) from user"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Return table.Rows.Item(0).Item(0)
    End Function

    Public Function getUsersInactive() As Integer
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim currentDay = Today
        'Select * From dbo.March2010 A Where A.Date >= Convert(DateTime, '2010-04-01')
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"(Select count(distinct U.code) 
                                from user U 
                                inner join rent R on R.renter = U.code 
                                where (DATE(R.rentDate) < (str_to_date('{currentDay.Year},{currentDay.Month},{currentDay.Day}', '%Y,%m,%d') - 120)))
                                UNION
                                (Select count(distinct U.code) 
                                from user U 
                                inner join history H on H.renter = U.code 
                                WHERE (DATE(H.date) < (str_to_date('{currentDay.Year},{currentDay.Month},{currentDay.Day}', '%Y,%m,%d') - 120)))"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("users")
        table.Load(reader)
        connection.Close()
        Dim count As Integer
        For Each row As DataRow In table.Rows
            count += row.Item(0)
        Next
        Return count
    End Function

End Class
