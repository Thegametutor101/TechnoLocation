Imports System.Text.RegularExpressions

Public Class UCRent
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd()
        iUserAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers()
    End Sub

    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged
        If (Not String.IsNullOrEmpty(tbUserSearch.Text)) Then
            Dim recherche As String = tbUserSearch.Text
            Dim entityUser As EntityUser = EntityUser.getInstance()
            If (Regex.IsMatch(recherche, "^[0-9]*$")) Then
                If recherche.Length <= 10 Then
                    gridUserSearch.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
                End If
            Else
                gridUserSearch.DataSource = entityUser.getUsers()
            End If
        End If
    End Sub
End Class
