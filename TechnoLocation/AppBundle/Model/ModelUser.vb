Imports MySql.Data.MySqlClient
Public Class ModelUser
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelUser = Nothing

    Public Shared Function getInstance() As ModelUser
        If IsNothing(instance) Then
            instance = New ModelUser()
        End If
        Return instance
    End Function

    Public Function updateUser(code As Integer, password As String, firstName As String, lastName As String, email As String, phoneMain As String, phone2 As String, job As Integer, permissions As Integer, balance As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update user set code='{code}', password='{password}', firstName='{firstName}',lastName='{lastName}', email='{email}', phoneMain='{phoneMain}', phone2='{phone2}', job='{job}', permission='{permissions}', balance='{balance}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from user"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addUser(password As String, firstName As String, lastName As String, email As String, phoneMain As String, phone2 As String, job As Integer, permissions As Integer, balance As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into user values ('{password}', '{firstName}','{lastName}', '{email}', '{phoneMain}', '{phone2}', '{job}', '{permissions}', '{balance}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delUser(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from user where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
