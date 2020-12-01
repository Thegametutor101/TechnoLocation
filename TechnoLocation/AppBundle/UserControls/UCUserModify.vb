Public Class UCUserModify
    Dim code As Integer
    Private Sub UCUserModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entityUser As EntityUser = EntityUser.getInstance()

        tbCode.Text = code
        tbFirstName.Text = entityUser.getUsersCode(code).Rows(0).Item("firstName")
        tbLastName.Text = entityUser.getUsersCode(code).Rows(0).Item("lastName")
        tbEmail.Text = entityUser.getUsersCode(code).Rows(0).Item("email")
        tbPhone1.Text = entityUser.getUsersCode(code).Rows(0).Item("phoneMain")
        tbPhone2.Text = entityUser.getUsersCode(code).Rows(0).Item("phone2")
        tbJob.Text = entityUser.getUsersCode(code).Rows(0).Item("job")
        'tbPermissions.Text = entityUser.getUsersCode(code).Rows(0).Item("permissions")
    End Sub

    Public Sub New(id As Integer)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        code = id
    End Sub

    Private Sub btCancelUser_Click(sender As Object, e As EventArgs) Handles btCancelUser.Click
        Me.SendToBack()
    End Sub

    Private Sub btModifyUser_Click(sender As Object, e As EventArgs) Handles btModifyUser.Click
        If (tbCode.Text.Equals("") Or tbEmail.Text.Equals("") Or tbFirstName.Equals("") Or tbLastName.Text.Equals("") Or tbPhone1.Text.Equals("") Or tbJob.Text.Equals("") Or tbPermissions.Text.Equals("")) Then
            MessageBox.Show("Veuillez remplir tous les emplacements obligatoires")
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(tbFirstName.Text, "^[a-zA-Z-]+") Or Not System.Text.RegularExpressions.Regex.IsMatch(tbLastName.Text, "^[a-zA-Z-]+") Then
            MessageBox.Show("Veuillez entrer un nom valide")
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(tbPhone1.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") Or (Not System.Text.RegularExpressions.Regex.IsMatch(tbPhone2.Text, "^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$") And Not tbPhone2.text.equals("")) Then
            MessageBox.Show("Veuillez Entrer un numéro de téléphone valide")
        ElseIf (Not IsNumeric(tbJob.Text) Or Not tbJob.Text.Length <= 1 Or Not IsNumeric(tbPermissions.Text) Or Not tbPermissions.Text.Length <= 1) Then
            MessageBox.Show("Veuillez entrer un chiffre pour Job et Permission")
        ElseIf tbPassword.Text.Equals(EntityUser.getInstance.getUsersPassword(code).rows(0).Item("password")) Then
            If tbPhone2.Text.Equals("") Then
                ModelUser.getInstance.updateUser1Phone(code, EntityUser.getInstance.getUsersPassword(code).Rows(0).Item("password"), tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone1.Text, tbJob.Text, tbPermissions.Text, EntityUser.getInstance.getUsersCode(code).Rows(0).Item("balance"))
            Else
                ModelUser.getInstance.updateUser(code, EntityUser.getInstance.getUsersPassword(code).Rows(0).Item("password"), tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone1.Text, tbPhone2.Text, tbJob.Text, tbPermissions.Text, EntityUser.getInstance.getUsersCode(code).Rows(0).Item("balance"))
            End If
            MessageBox.Show("Modifications sauvegardées")
            Me.SendToBack()
            ElseIf Not tbPassword.Text.Equals(EntityUser.getInstance.getUsersPassword(code).Rows(0).Item("password")) Then
                MessageBox.Show("Mot de passe non valide, veuillez réessayer")
        End If
    End Sub
End Class
