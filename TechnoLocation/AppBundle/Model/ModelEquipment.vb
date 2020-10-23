Imports MySql.Data.MySqlClient
Public Class ModelEquipment
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As ModelEquipment = Nothing

    Public Shared Function getInstance() As ModelEquipment
        If IsNothing(instance) Then
            instance = New ModelEquipment()
        End If
        Return instance
    End Function

    Public Function updateEquipment(code As Integer, name As String, kit As Integer, state As String, available As Integer, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set code='{code}',name='{name}',kit='{kit}',state='{state}', available='{available}', comments='{comments}' where code='{code}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from equipement"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addEquipment(code As Integer, name As String, kit As Integer, state As String, available As Integer, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into equipement values ('{code}','{name}','{kit}','{state}','{available}', '{comments}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delEquipement(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from equipement where noequipement = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
