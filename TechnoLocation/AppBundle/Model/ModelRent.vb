Imports MySql.Data.MySqlClient
Public Class ModelRent
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelRent = Nothing

    Public Shared Function getInstance() As ModelRent
        If IsNothing(instance) Then
            instance = New ModelRent()
        End If
        Return instance
    End Function

    Public Function updateRent(code As Integer, renter As Integer, lender As Integer, equipment As Integer, rentDate As DateTime, returnDate As DateTime, deposit As Double, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update rent set code='{code}',renter='{renter}', lender='{lender}', equipment='{equipment}', rentDate='{rentDate}', returnDate='{returnDate}', deposit='{deposit}', comments='{comments}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextId() As Integer
        Dim command As New MySqlCommand
        Dim code As Integer
        command.Connection = connection
        command.CommandText = "select max(code) from rent"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        code = reader(0)
        connection.Close()
        Return (code + 1)
    End Function

    Public Function addRent(renter As Integer, lender As Integer, equipment As Integer, rentDate As DateTime, returnDate As DateTime, deposit As Double, comments As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into rent values ('{renter}', '{lender}', '{equipment}', '{rentDate}', '{returnDate}', '{deposit}', '{comments}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function delRent(code As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from rent where code = '{code}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
