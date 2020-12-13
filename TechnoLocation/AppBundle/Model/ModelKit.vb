Imports MySql.Data.MySqlClient
Public Class ModelKit
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelKit = Nothing

    Public Shared Function getInstance() As ModelKit
        If IsNothing(instance) Then
            instance = New ModelKit()
        End If
        Return instance
    End Function

    Public Function updateKit(code As Integer, name As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update kit set name=inctap('{name}') where code='{code}'"
            connection.Open()
            Dim add As Integer = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

    Public Function nextId() As Integer
        Dim code As Integer
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = "select max(code) from kit"
            connection.Open()
            Dim reader = command.ExecuteReader()
            reader.Read()
            code = reader(0)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
        Return (code + 1)
    End Function

    Public Function addKit(name As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into kit (name) values (initcap('{name}'))"
            connection.Open()
            Dim add As Integer = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function delKit(code As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Delete from kit where code = '{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

End Class
