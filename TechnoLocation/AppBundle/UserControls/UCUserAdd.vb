Imports System.Text.RegularExpressions
Public Class UCUserAdd
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        If (IsNumeric(tbCode.Text) And System.Text.RegularExpressions.Regex.IsMatch(tbFirstName.Text, "^[a-zA-Z]+-") And System.Text.RegularExpressions.Regex.IsMatch(tbLastName.Text, "^[a-zA-Z]+-") And System.Text.RegularExpressions.Regex.IsMatch(tbPhone1.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") And System.Text.RegularExpressions.Regex.IsMatch(tbPhone2.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") And IsNumeric(tbJob.Text) And tbJob.Text.Length <= 1 And IsNumeric(tbPermissions.Text) And tbPermissions.Text.Length <= 1) Then
            ModelUser.getInstance().addUser(tbCode.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone1.Text, tbPhone2.Text, tbJob.Text, tbPermissions.Text, 0, False)
        End If
    End Sub
End Class
