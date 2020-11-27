Imports System.Text.RegularExpressions
Public Class UCUserAdd
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        If (IsNumeric(tbCode.Text) And System.Text.RegularExpressions.Regex.IsMatch(tbFirstName.Text, "^[a-zA-Z-]+") And System.Text.RegularExpressions.Regex.IsMatch(tbLastName.Text, "^[a-zA-Z-]+") And System.Text.RegularExpressions.Regex.IsMatch(tbPhone1.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") And (System.Text.RegularExpressions.Regex.IsMatch(tbPhone2.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") Or tbPhone2.Text.Equals("")) And IsNumeric(tbJob.Text) And tbJob.Text.Length <= 1 And IsNumeric(tbPermissions.Text) And tbPermissions.Text.Length <= 1) Then
            If (tbPhone2.Text.Equals("")) Then
                ModelUser.getInstance().addUser1Phone(tbCode.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone1.Text, tbJob.Text, tbPermissions.Text, 0, False)
            Else
                ModelUser.getInstance().addUser(tbCode.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone1.Text, tbPhone2.Text, tbJob.Text, tbPermissions.Text, 0, False)
            End If
            Me.SendToBack()
        ElseIf (tbCode.Text.Equals("") Or tbPassword.Text.Equals("") Or tbEmail.Text.Equals("") Or tbFirstName.Equals("") Or tbLastName.Text.Equals("") Or tbPhone1.Text.Equals("") Or tbJob.Text.Equals("") Or tbPermissions.Text.Equals("")) Then
            MessageBox.Show("Veuillez remplir les informations obligatoires")
        ElseIf (Not IsNumeric(tbCode.Text)) Then
            MessageBox.Show("Veuillez entrer un code adéquat")
        ElseIf (Not System.Text.RegularExpressions.Regex.IsMatch(tbFirstName.Text, "^[a-zA-Z-]+") Or Not System.Text.RegularExpressions.Regex.IsMatch(tbLastName.Text, "^[a-zA-Z-]+")) Then
            MessageBox.Show("Veuillez entrer un nom adéquat")
        ElseIf (Not System.Text.RegularExpressions.Regex.IsMatch(tbPhone1.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") Or Not System.Text.RegularExpressions.Regex.IsMatch(tbPhone2.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$")) Then
            MessageBox.Show("Veuillez entrer numéro de téléphone adéquat")
        ElseIf (Not IsNumeric(tbJob.Text) Or Not tbJob.Text.Length <= 1 Or Not IsNumeric(tbPermissions.Text) Or Not tbPermissions.Text.Length <= 1) Then
            MessageBox.Show("Veuillez entrer un chiffre pour Job et Permission")
        End If
    End Sub

    Private Sub btCancelUser_Click(sender As Object, e As EventArgs) Handles btCancelUser.Click
        Me.SendToBack()
    End Sub
End Class
