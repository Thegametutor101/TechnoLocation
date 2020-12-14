Public Class EncryptionTranslator

    Dim arrayCharacters As New Dictionary(Of Char, String)
    Dim table(200) As Char
    Dim rand As New Random

    Public Function encrypt(password As String) As String
        For Each row As DataRow In EntityCharacters.getInstance().getCharacters().Rows
            arrayCharacters.Add(row.Item("passChar"), row.Item("value"))
        Next row
        Dim encryptedPassword As String = ""
        For Each passChar As Char In password
            addCharacter(passChar)
            encryptedPassword += createEncryption(passChar)
        Next passChar
        Return encryptedPassword
    End Function

    Private Sub addCharacter(passChar As Char)
        If Not arrayCharacters.ContainsKey(passChar) Then
            Dim number As Integer = CInt(Math.Ceiling(rand.Next(1000) * 1482)) + 1
            Dim hashValue = Math.Sqrt(((number + 13) * 17) / 5)
            arrayCharacters.Add(passChar, hashValue.ToString())
            ModelCharacters.getInstance().addCharacter(passChar, hashValue.ToString())
        End If
    End Sub

    Private Function createEncryption(passChar As Char) As String
        Dim characterList As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=/?<>,.:;[]{}"
        Dim testedAll As Boolean = False
        For Each c As Char In characterList
            Dim i As Integer = characterList.IndexOf(c)
            If passChar = c Then
                Dim placed As Boolean = False
                Dim pos As Integer = i
                Dim ctr As Integer = 0
                If String.IsNullOrEmpty(table(pos)) Or table(pos) = vbNullChar Then
                    table(pos) = characterList(i)
                    Try
                        Return (Math.Ceiling((CInt(arrayCharacters.Item(passChar)) + pos + 13) * 17 / 5)).ToString()
                    Catch ex As Exception
                        Return (Math.Ceiling((CInt(Replace(arrayCharacters.Item(passChar), ".", ",")) + pos + 13) * 17 / 5)).ToString()
                    End Try
                Else
                    While Not placed
                        ctr += 1
                        If testedAll Then
                            pos += 1
                        End If
                        pos = ctr * 5 / 4
                        If pos >= table.Length Then
                            pos = 0
                            testedAll = True
                        End If
                        If String.IsNullOrEmpty(table(pos)) Or table(pos) = vbNullChar Then
                            table(pos) = characterList(i)
                            placed = True
                            Return (Math.Ceiling((CInt(arrayCharacters.Item(passChar)) + pos + 13) * 17 / 5)).ToString()
                        End If
                    End While
                End If
            End If
        Next c
        Return ""
    End Function

End Class
