Public Class LoginController

    Public Function login(inputCode As String, inputPassword As String) As Boolean
        Dim listCodes(), listPasswords() As String
        Dim entityUser = New EntityUser
        Dim count As Integer = 0
        For Each row As DataRow In entityUser.getUserCodes().Rows
            listCodes(count) = row.Item("code")
            count += 1
        Next row
        count = 0
        For Each row As DataRow In entityUser.getUserPasswords().Rows
            listPasswords(count) = row.Item("password")
            count += 1
        Next row
    End Function

End Class
