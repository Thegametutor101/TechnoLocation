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

    Public Function getUsers(lang As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SET lc_time_names = 'fr_CA';
                                Select code, 
                                        U.firstName, 
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
                                        CASE
                                            WHEN U.job = 0 THEN 'Étudiant'
                                            WHEN U.job = 1 THEN 'Professeur'
                                            WHEN U.job = 2 THEN 'Employé'
                                        END AS job,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(U.balance, 2)), '.', ',') AS CHAR) AS balance  
                                    from user U
                                    ORDER BY code"
            Else
                command.CommandText = $"SET lc_time_names = 'en_US';
                                Select code, 
                                        U.firstName, 
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
                                        CASE
                                            WHEN U.job = 0 THEN 'Student'
                                            WHEN U.job = 1 THEN 'Teacher'
                                            WHEN U.job = 2 THEN 'Employee'
                                        END AS job,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(U.balance, 2)), '.', ',') AS CHAR) AS balance  
                                    from user U
                                    ORDER BY code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("users")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les utilisateurs.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUsersBySearch(lang As String, value As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If lang = "EN" Then
                command.CommandText = $"SET lc_time_names = 'fr_CA';
                                Select code, 
                                        U.firstName, 
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
                                        CASE
                                            WHEN U.job = 0 THEN 'Étudiant'
                                            WHEN U.job = 1 THEN 'Professeur'
                                            WHEN U.job = 2 THEN 'Employé'
                                        END AS job,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(U.balance, 2)), '.', ',') AS CHAR) AS balance  
                                    from user U
                                    WHERE code LIKE '%{value}%' OR
                                        upper(firstName) LIKE upper('%{value}%') OR
                                        upper(lastName) LIKE upper('%{value}%') OR
                                        upper(email) LIKE upper('%{value}%') OR
                                        (CASE
                                            WHEN U.job = 0 THEN 'Étudiant'
                                            WHEN U.job = 1 THEN 'Professeur'
                                            WHEN U.job = 2 THEN 'Employé'
                                        END) LIKE upper('%{value}%')
                                    ORDER BY code"
            Else
                command.CommandText = $"SET lc_time_names = 'en_US';
                                Select code, 
                                        U.firstName, 
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
                                        CASE
                                            WHEN U.job = 0 THEN 'Student'
                                            WHEN U.job = 1 THEN 'Teacher'
                                            WHEN U.job = 2 THEN 'Employee'
                                        END AS job,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(U.balance, 2)), '.', ',') AS CHAR) AS balance  
                                    from user U
                                    WHERE upper(firstName) LIKE upper('%{value}%') OR
                                        upper(lastName) LIKE upper('%{value}%') OR
                                        upper(email) LIKE upper('%{value}%') OR
                                        (CASE
                                            WHEN U.job = 0 THEN 'Student'
                                            WHEN U.job = 1 THEN 'Teacher'
                                            WHEN U.job = 2 THEN 'Employee'
                                        END) LIKE upper('%{value}%')
                                    ORDER BY code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("users")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les utilisateurs filtrés.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUserAccounts() As DataTable
        Try
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
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les comptes d'utilisateurs.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUserByRental(rental As Integer) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT U.code, 
                                    U.firstName, 
                                    U.lastName, 
                                    U.balance
                                FROM user U
                                INNER JOIN rent R on R.renter = U.code
                                WHERE R.code = {rental}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("users")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Échec à la recherche de l'utilisateur souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function checkUserMatriculeExists(code As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * 
                                FROM user
                                WHERE code = '{code}' 
                                ORDER BY code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("users")
            table.Load(reader)
            connection.Close()
            Return table.Rows.Count > 0
        Catch ex As Exception
            MessageBox.Show($"Impossible de valider le matricule.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUsersCode(code As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select code, 
                                    firstName, 
                                    lastName, 
                                    email, 
                                    phoneMain, 
                                    phone2, 
                                    job, 
                                    balance 
                                from user U 
                                where code = '{code}' 
                                order by U.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("users")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer l'utilisateur souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUserByCode(code As String) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select code, 
                                    password, 
                                    firstName, 
                                    lastName, 
                                    email, 
                                    phoneMain, 
                                    CASE
                                    	WHEN extensionMain Is NULL THEN -1
                                        WHEN extensionMain IS NOT NULL THEN extensionMain
                                    END AS extensionMain, 
                                    phone2, 
                                    CASE
                                    	WHEN extension2 Is NULL THEN -1
                                        WHEN extension2 IS NOT NULL THEN extension2
                                    END AS extension2,
                                    job, 
                                    permissions, 
                                    balance 
                                from user 
                                where code = '{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("user")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer l'utilisateur souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getUsersCount() As Integer
        Try
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
        Catch ex As Exception
        End Try
    End Function

    Public Function getUsersInactive() As Integer
        Try
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
                                WHERE (DATE(H.dateReturned) < (str_to_date('{currentDay.Year},{currentDay.Month},{currentDay.Day}', '%Y,%m,%d') - 120)))"
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
        Catch ex As Exception

        End Try
    End Function

End Class
