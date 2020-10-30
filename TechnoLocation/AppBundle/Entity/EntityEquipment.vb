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

    Public Function getEquipment() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipment E order by E.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipments")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentCode(code As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipment E where code = '{code}'order by E.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipments")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentName(name As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipment E where name like '%{name}%'order by E.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipments")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentKit(kit As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipment E where kit = '{kit}'order by E.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipments")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentAvailable(availability As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipment E where available = '{availability}'order by E.code"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipments")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
