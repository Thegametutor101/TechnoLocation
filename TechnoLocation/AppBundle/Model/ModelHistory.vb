Imports MySql.Data.MySqlClient
Public Class ModelHistory
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelHistory = Nothing

    Public Shared Function getInstance() As ModelHistory
        If IsNothing(instance) Then
            instance = New ModelHistory()
        End If
        Return instance
    End Function

End Class
