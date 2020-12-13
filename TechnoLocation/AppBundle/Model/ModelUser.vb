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

    Public Function updateUser(code As Integer,
                               password As String,
                               firstName As String,
                               lastName As String,
                               email As String,
                               phoneMain As String,
                               ext1 As Integer,
                               phone2 As String,
                               ext2 As Integer,
                               job As Integer,
                               permissions As Integer,
                               balance As Double)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If Not ext1 = -1 And Not ext2 = -1 Then
                command.CommandText = $"update user set firstName='{firstName}',
                                                    lastName='{lastName}',
                                                    email='{email}',
                                                    phoneMain='{phoneMain}',
                                                    extensionMain='{ext1}',
                                                    phone2='{phone2}',
                                                    extension2='{ext2}',
                                                    job='{job}',
                                                    permissions='{permissions}',
                                                    balance='{balance}' 
                                                    where code = '{code}'"
            ElseIf Not ext1 = -1 And ext2 = -1 Then
                command.CommandText = $"update user set firstName='{firstName}',
                                                    lastName='{lastName}',
                                                    email='{email}',
                                                    phoneMain='{phoneMain}',
                                                    extensionMain='{ext1}',
                                                    phone2='{phone2}',
                                                    extension2=null,
                                                    job='{job}',
                                                    permissions='{permissions}',
                                                    balance='{balance}' 
                                                    where code = '{code}'"
            ElseIf ext1 = -1 And Not ext2 = -1 Then
                command.CommandText = $"update user set firstName='{firstName}',
                                                    lastName='{lastName}',
                                                    email='{email}',
                                                    phoneMain='{phoneMain}',
                                                    extensionMain=null,
                                                    phone2='{phone2}',
                                                    extension2='{ext2}',
                                                    job='{job}',
                                                    permissions='{permissions}',
                                                    balance='{balance}' 
                                                    where code = '{code}'"
            Else
                command.CommandText = $"update user set firstName='{firstName}',
                                                    lastName='{lastName}',
                                                    email='{email}',
                                                    phoneMain='{phoneMain}',
                                                    extensionMain=null,
                                                    phone2='{phone2}',
                                                    extension2=null,
                                                    job='{job}',
                                                    permissions='{permissions}',
                                                    balance='{balance}' 
                                                    where code = '{code}'"
            End If
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            If Not String.IsNullOrEmpty(password) Then
                Dim loginController As New LoginController
                loginController.createAccount(code, password)
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

    Public Function nextId() As Integer
        Dim code As Integer = 0
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = "select max(code) from user"
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

    Public Function addUser(code As Integer,
                            password As String,
                            firstName As String,
                            lastName As String,
                            email As String,
                            phoneMain As String,
                            ext1 As Integer,
                            phone2 As String,
                            ext2 As Integer,
                            job As Integer,
                            permissions As Integer,
                            balance As Double)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            If Not ext1 = -1 And Not ext2 = -1 Then
                command.CommandText = $"insert into user values ('{code}',
                                                            '',
                                                            '{firstName}',
                                                            '{lastName}',
                                                            '{email}',
                                                            '{phoneMain}',
                                                            '{ext1}',
                                                            '{phone2}',
                                                            '{ext2}',
                                                            '{job}',
                                                            '{permissions}',
                                                            '{balance}')"
            ElseIf Not ext1 = -1 And ext2 = -1 Then
                command.CommandText = $"insert into user values ('{code}',
                                                            '',
                                                            '{firstName}',
                                                            '{lastName}',
                                                            '{email}',
                                                            '{phoneMain}',
                                                            '{ext1}',
                                                            '{phone2}',
                                                            null,
                                                            '{job}',
                                                            '{permissions}',
                                                            '{balance}')"
            ElseIf ext1 = -1 And Not ext2 = -1 Then
                command.CommandText = $"insert into user values ('{code}',
                                                            '',
                                                            '{firstName}',
                                                            '{lastName}',
                                                            '{email}',
                                                            '{phoneMain}',
                                                            null,
                                                            '{phone2}',
                                                            '{ext2}',
                                                            '{job}',
                                                            '{permissions}',
                                                            '{balance}')"
            Else
                command.CommandText = $"insert into user values ('{code}',
                                                            '',
                                                            '{firstName}',
                                                            '{lastName}',
                                                            '{email}',
                                                            '{phoneMain}',
                                                            null,
                                                            '{phone2}',
                                                            null,
                                                            '{job}',
                                                            '{permissions}',
                                                            '{balance}')"
            End If
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            If Not String.IsNullOrEmpty(password) Then
                Dim loginController As New LoginController
                loginController.createAccount(code, password)
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

    Public Function delUser(code As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Delete from user where code = '{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

    Public Function updateUserPassword(code As Integer, password As String)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update user set password='{password}' where code='{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

End Class
