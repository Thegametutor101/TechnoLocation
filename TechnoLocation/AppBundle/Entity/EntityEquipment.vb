Imports MySql.Data.MySqlClient
Public Class EntityEquipment

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityEquipment = Nothing

    Public Shared Function getInstance() As EntityEquipment
        If IsNothing(instance) Then
            instance = New EntityEquipment()
        End If
        Return instance
    End Function

    Public Function getEquipment() As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        state, 
                                        available, 
                                        comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    ORDER BY E.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les équipements.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentsBySearch(value As String, available As Boolean) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If available Then
                command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        state, 
                                        available, 
                                        comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    WHERE (E.code LIKE '%{value}%' OR
                                        E.name LIKE '%{value}%' OR
                                        K.name LIKE '%{value}%' OR
                                        state LIKE '%{value}%' OR
                                        comments LIKE '%{value}%') AND
                                        available = 1
                                    ORDER BY E.code"
            Else
                command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        state, 
                                        available, 
                                        comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    WHERE (E.code LIKE '%{value}%' OR
                                        E.name LIKE '%{value}%' OR
                                        K.name LIKE '%{value}%' OR
                                        state LIKE '%{value}%' OR
                                        comments LIKE '%{value}%')
                                    ORDER BY E.code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les équipements filtrés.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentsByRental(rental As Integer) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        E.state, 
                                        R.comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(R.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    INNER JOIN rent R on R.equipment = E.code
                                    WHERE R.code = {rental}
                                    ORDER BY E.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Echec à la récupération de l'équipement souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentsByRentalForMod(rental As Integer) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        E.state, 
                                        R.comments,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS depositSuggest,
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(R.deposit, 2)), '.', ',') AS CHAR) AS depositReel
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    INNER JOIN rent R on R.equipment = E.code
                                    WHERE R.code = {rental}
                                    ORDER BY E.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Echec à la récupération de l'équipement souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentByCode(code As Integer) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * 
                                    FROM equipment
                                    WHERE code = '{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipment")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Echec à la récupération de l'équipement souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getEquipmentsBySearchRent(value As String, available As Boolean, dateBegin As Date, dateEnd As Date) As DataTable
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If available Then
                command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        state, 
                                        E.comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    WHERE (E.code LIKE '%{value}%' OR
                                        E.name LIKE '%{value}%' OR
                                        K.name LIKE '%{value}%' OR
                                        state LIKE '%{value}%' OR
                                        E.comments LIKE '%{value}%') AND
                                        available = 1 AND
                                        E.code not in (Select equipment from rent R 
                                                    where (rentDate between '{dateBegin}' and '{dateEnd}') or 
                                                   (returnDate between '{dateBegin}' and '{dateEnd}'))
                                    ORDER BY E.code"
            Else
                command.CommandText = $"SELECT E.code, 
                                        E.name, 
                                        K.name AS kit, 
                                        state, 
                                        comments, 
                                        CAST(REPLACE(CONCAT('$ ', FORMAT(E.deposit, 2)), '.', ',') AS CHAR) AS deposit
                                    FROM equipment E
                                    INNER JOIN kit K on K.code = E.kit
                                    WHERE (E.code LIKE '%{value}%' OR
                                        E.name LIKE '%{value}%' OR
                                        K.name LIKE '%{value}%' OR
                                        state LIKE '%{value}%' OR
                                        comments LIKE '%{value}%')
                                    ORDER BY E.code"
            End If
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show($"Impossible de récupérer les équipements filtrés.{Environment.NewLine}" + ex.Message)
        End Try
    End Function

    Public Function getAvailability(id As Integer) As Integer
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select available 
                                    from equipment E 
                                    where code = '{id}' 
                                    order by E.code"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("equipments")
            table.Load(reader)
            connection.Close()
            Return table.Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show($"Impossible de voir la disponibilité de l'équipement souhaité.{Environment.NewLine}" + ex.Message)
        End Try
    End Function
End Class
