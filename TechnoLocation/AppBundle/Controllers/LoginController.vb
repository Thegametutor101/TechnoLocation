Public Class LoginController

    Dim encryptionTranslator As New EncryptionTranslator

    Public Function login(inputCode As String, inputPassword As String) As Boolean
        Dim listCodes, listPasswords As New List(Of String)
        Dim entityUser As EntityUser = EntityUser.getInstance()
        For Each row As DataRow In entityUser.getUserAccounts().Rows
            listCodes.Add(row.Item("code"))
            listPasswords.Add(row.Item("password"))
        Next row
        If Not IsNothing(listCodes) Then
            For Each code As String In listCodes
                If code = inputCode Then
                    Dim encryptedPassword As String = encryptionTranslator.encrypt(inputPassword)
                    If encryptedPassword = listPasswords(listCodes.IndexOf(code)) Then
                        Return True
                    Else
                        MessageBox.Show("Identifiant ou mot de passe invalide", "Erreur", MessageBoxButtons.OK)
                    End If
                End If
            Next code
        End If
        Return False
    End Function

    Public Sub createAccount(inputCode As String, inputPassword As String)
        Dim encryptedPassword As String = encryptionTranslator.encrypt(inputPassword)
        ModelUser.getInstance().updateUserPassword(inputCode, encryptedPassword)
    End Sub

End Class
