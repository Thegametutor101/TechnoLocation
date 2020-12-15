Imports MySql.Data.MySqlClient
Public Class ModelLog
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelLog = Nothing

    Public Shared Function getInstance() As ModelLog
        If IsNothing(instance) Then
            instance = New ModelLog()
        End If
        Return instance
    End Function

End Class
