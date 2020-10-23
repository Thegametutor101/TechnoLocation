Public Class EncryptionTranslator

    Dim arrayCharacters As New Dictionary(Of Char, String)
    Shared instance As EncryptionTranslator = Nothing

    Shared Function getInstance() As EncryptionTranslator
        If IsNothing(instance) Then
            instance = New EncryptionTranslator()
        End If
        Return instance
    End Function

    Public Function encrypt(password As String) As String
        For Each row As DataRow In EntityCharacters.getInstance().getCharacters().Rows
            arrayCharacters.Add(row.Item("passChar"), row.Item("value"))
        Next row
        Dim encryptedPassword As String = ""
        Dim table(200) As Char
        For Each passChar As Char In password
            addCharacter(passChar)
            encryptedPassword += createEncryption(passChar, table)
        Next passChar
        Return encryptedPassword
    End Function

    Private Sub addCharacter(passChar As Char)
        If IsNothing(arrayCharacters.Item(passChar)) Then
            Dim number As Integer = CInt(Int((46347 * Rnd()) + 10))
            Dim hashValue = Math.Sqrt(((number + 13) * 17) / 5)
            arrayCharacters.Add(passChar, ToString(hashValue))
            ModelCharacters.getInstance().addCharacter(passChar, ToString(hashValue))
        End If
    End Sub
    Private Function createEncryption(passChar As Char, table As Char()) As String
        Dim characterList As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=/?<>,.:;[]{}"
        Dim testedAll As Boolean = False
        For Each c As Char In characterList
            Dim i As Integer = characterList.IndexOf(c)
            If passChar = c Then
                Dim placed As Boolean = False
                Dim pos As Integer = i
                Dim ctr As Integer = 0
                If IsNothing(table(pos)) Then
                    table(pos) = characterList(i)
                    Return ToString((CInt(arrayCharacters.Item(passChar)) + pos + 13) * 17 / 5)
                Else
                    While Not placed
                        ctr += 1
                        If testedAll Then
                            pos += 1
                        End If
                        pos = ctr * 5 / 4
                        If pos > table.Length Then
                            pos = 0
                            testedAll = True
                        End If
                        If IsNothing(table(pos)) Then
                            table(pos) = characterList(i)
                            placed = True
                            Return ToString((CInt(arrayCharacters.Item(passChar)) + pos + 13) * 17 / 5)
                        End If
                    End While
                End If
            End If
        Next c
        Return ""
    End Function

End Class
