Public Class LoginController

    Shared instance As LoginController = Nothing

    Public Shared Function getInstance() As LoginController
        If IsNothing(instance) Then
            instance = New LoginController()
        End If
        Return instance
    End Function

    Public Function login(inputCode As String, inputPassword As String) As Boolean
        If inputCode = "admin" And (inputPassword = "" Or IsNothing(inputPassword)) Then
            Return True
        Else
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
            If Not IsNothing(listCodes) Then
                For Each code As String In listCodes
                    code = code.ToUpper()
                    inputCode = inputCode.ToUpper()
                    If code = inputCode Then

                    End If
                Next code
            End If
        End If
        Return False
    End Function

    Public Sub createAccount(inputCode As String, inputPassword As String)
        Dim encryptedPassword As String = EncryptionTranslator.getInstance().encrypt(inputPassword)

    End Sub

End Class
