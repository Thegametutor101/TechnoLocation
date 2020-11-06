Imports System.Text.RegularExpressions

Public Class UCUser
    Private Sub UCUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUser.DataSource = EntityUser.getInstance.getUsers()

    End Sub
    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged
        userSearch()
    End Sub
    Private Sub dropUserSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropUserSearch.SelectedIndexChanged
        userSearch()
    End Sub

    Private Function userSearch()
        If (Not String.IsNullOrEmpty(tbUserSearch.Text)) Then
            Dim recherche As String = tbUserSearch.Text
            Dim entityUser As EntityUser = EntityUser.getInstance()
            Select Case dropUserSearch.SelectedIndex
                Case 0
                    If (Regex.IsMatch(recherche, "^[0-9]")) Then
                        If recherche.Length <= 10 Then
                            gridUser.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
                        End If
                    Else
                            gridUser.DataSource = entityUser.getUsers()
                    End If
                Case 1
                    gridUser.DataSource = entityUser.getUsersFirstName(recherche)
                Case 2
                    gridUser.DataSource = entityUser.getUsersLastName(recherche)
                Case 3
                    gridUser.DataSource = entityUser.getUsersEmail(recherche)
                Case 4
                    gridUser.DataSource = entityUser.getUsersPhone(recherche)
                Case 5
                    gridUser.DataSource = entityUser.getUsersJob(recherche)
            End Select
        End If
    End Function

    Private Sub checkUser_CheckedChanged(sender As Object, e As EventArgs) Handles checkUser.CheckedChanged
        If checkUser.Checked Then
            gridUser.SelectAll()
        Else
            gridUser.ClearSelection()
        End If
    End Sub

    Private Sub btDeleteUser_Click(sender As Object, e As EventArgs) Handles btDeleteUser.Click
        For Each row As DataGridViewRow In gridUser.SelectedRows
            ModelUser.getInstance().delUser(row.Cells(0).Value)
        Next
        userSearch()
    End Sub

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd()
        iUserAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
    End Sub
End Class
