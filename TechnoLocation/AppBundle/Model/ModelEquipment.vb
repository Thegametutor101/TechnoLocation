Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq
Public Class ModelEquipment
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelEquipment = Nothing
    Public Shared Function getInstance() As ModelEquipment
        If IsNothing(instance) Then
            instance = New ModelEquipment()
        End If
        Return instance
    End Function

    Public Function updateEquipment(code As Integer,
                                    name As String,
                                    kit As Integer,
                                    state As String,
                                    available As Integer,
                                    comments As String,
                                    deposit As Double)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update equipment set name='{name}',
                                                        kit='{kit}',
                                                        state='{state}',
                                                        available='{available}',
                                                        comments='{comments}',
                                                        deposit='{deposit}'
                                                        where code='{code}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Function

    Public Function setAvailable(code As Integer, available As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"UPDATE equipment 
                                    SET available='{available}'
                                    WHERE code='{code}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function setCommentAndAvailable(code As Integer, comment As String, available As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"UPDATE equipment 
                                    SET available='{available}',
                                        comments = '{comment}'
                                    WHERE code='{code}'"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            command.CommandText = "select max(code) from equipment"
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

    Public Function addEquipment(name As String,
                                 kit As Integer,
                                 state As String,
                                 available As Integer,
                                 comments As String,
                                 deposit As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into equipment 
                                    (name,kit,state,available,comments,deposit) 
                                    values ('{name}',
                                            '{kit}',
                                            '{state}',
                                            '{available}',
                                            '{comments}',
                                            '{deposit}')"
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function delEquipment(code As Integer)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Delete from equipment where code = '{code}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la connexion.")
        End Try
    End Function

End Class
