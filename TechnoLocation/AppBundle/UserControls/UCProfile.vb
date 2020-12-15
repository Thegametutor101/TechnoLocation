Imports System.Text.RegularExpressions
Public Class UCProfile



    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim data As DataRow
    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(main As MainForm)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not mainForm.code = 0 Then
            data = EntityUser.getInstance().getUserByCode(mainForm.code).Rows(0)
            tbCode.Text = mainForm.code
            tbFirstName.Text = data.Item("firstName")
            tbLastName.Text = data.Item("lastName")
            tbEmail.Text = data.Item("email")
            tbPhone1.Text = data.Item("phoneMain")
            tbPhone2.Text = data.Item("phone2")
            dropStatus.SelectedIndex = data.Item("job")
            dropPermissions.SelectedIndex = data.Item("permissions")
        End If
    End Sub



    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub submit(password As String,
                       firstName As String,
                       lastName As String,
                       email As String,
                       phone1 As String,
                       phone2 As String)
        mainForm.isEditing = False
        Dim matricule As Integer
        Dim ext1, ext2 As Integer
        If numExtension1.Enabled Then
            ext1 = numExtension1.Value
        Else
            ext1 = -1
        End If
        If numExtension2.Enabled Then
            ext2 = numExtension2.Value
        Else
            ext2 = -1
        End If
        If tbCode.Text >= 10000000 Then
            matricule = Math.Floor(tbCode.Text / 10)
        Else
            matricule = tbCode.Text
        End If
        Try
            ModelUser.getInstance().updateUser(CInt(tbCode.Text),
                                               password,
                                               firstName,
                                               lastName,
                                               email,
                                               phone1,
                                               ext1,
                                               phone2,
                                               ext2,
                                               dropStatus.SelectedIndex,
                                               dropPermissions.SelectedIndex,
                                               0)
            'interfaceUser.loadDataGridView()
            Me.SendToBack()
        Catch ex As Exception
            MsgBox(Lang.getInstance().getLang()("SameMatricula"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("SameMatriculaTitle"))
            'numCode.BorderColor = Color.LightCoral
            'numCode.FocusedState.BorderColor = Color.LightCoral
        End Try
    End Sub


    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________
    Private Sub btSaveModifications_Click(sender As Object, e As EventArgs) Handles btSaveModifications.Click
        Dim firstName, lastName, email, phone1, phone2, password As String
        firstName = Trim(tbFirstName.Text)
        lastName = Trim(tbLastName.Text)
        email = Trim(tbEmail.Text)
        phone1 = Trim(tbPhone1.Text)
        phone2 = Trim(tbPhone2.Text)
        password = Trim(tbPassword.Text)
        If Regex.IsMatch(firstName, "^[a-zA-Z-' éèêâôîûçàëäöïüÉÈÊÂÔÎÛÇÀËÄÖÏÜ]+") Then
            If Regex.IsMatch(lastName, "^[a-zA-Z-' éèêâôîûçàëäöïüÉÈÊÂÔÎÛÇÀËÄÖÏÜ]+") Then
                If Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
                    If (Regex.IsMatch(phone1, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                        Regex.IsMatch(phone1, "^[\d]{10}$")) Then
                        If (Regex.IsMatch(phone2, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                            Regex.IsMatch(phone2, "^[\d]{10}$") Or
                            phone2 = "") Then
                            If checkPassword.Checked And Not String.IsNullOrEmpty(password) Then
                                submit(password, firstName, lastName, email, phone1, phone2)
                            ElseIf checkPassword.Checked And String.IsNullOrEmpty(password) Then
                                Dim title As String = Lang.getInstance().getLang()("MsgWarning")
                                Dim message As String = Lang.getInstance().getLang()("MsgSubmitNoPassword")
                                If MessageBox.Show(message,
                                               title,
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                                    submit(password, firstName, lastName, email, phone1, phone2)
                                End If
                            Else
                                submit(password, firstName, lastName, email, phone1, phone2)
                            End If
                        Else
                            MessageBox.Show("phone2")
                            '    tbPhone2.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                        End If
                    Else
                        MessageBox.Show("phone1")
                        '   tbPhone1.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                    End If
                Else
                    MessageBox.Show("email")
                    '  tbEmail.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                End If
            Else
                MessageBox.Show("lastname")
                ' tbLastName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
            End If
        Else
            MessageBox.Show("firstname")
            'tbFirstName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
        End If
    End Sub

    Private Sub btDeleteAccount_Click(sender As Object, e As EventArgs) Handles btDeleteAccount.Click
        ModelUser.getInstance.delUser(tbCode.Text)
        Connection.Show()
        mainForm.Close()
    End Sub

    Private Sub checkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkPassword.CheckedChanged
        mainForm.isEditing = True
        If checkPassword.Checked Then
            tbPassword.Text = ""
            labPassword.Visible = True
            tbPassword.Visible = True
        Else
            tbPassword.Text = ""
            labPassword.Visible = False
            tbPassword.Visible = False
        End If
    End Sub

    Private Sub checkExt2_CheckedChanged(sender As Object, e As EventArgs) Handles checkExt2.CheckedChanged
        Dim phone2 = Trim(tbPhone2.Text)
        If checkExt2.Checked And
           (Regex.IsMatch(phone2, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
            Regex.IsMatch(phone2, "^[\d]{10}$")) Then
            numExtension2.Enabled = True
        ElseIf checkExt2.Checked And
               Not (Regex.IsMatch(phone2, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                    Regex.IsMatch(phone2, "^[\d]{10}$")) Then
            'tbPhone2.BorderColor = red
        Else
            numExtension2.Enabled = False
            'tbPhone2.BorderColor = grey
        End If
    End Sub

    Private Sub checkExt1_CheckedChanged(sender As Object, e As EventArgs) Handles checkExt1.CheckedChanged
        Dim phone1 = Trim(tbPhone1.Text)
        If checkExt1.Checked And
           (Regex.IsMatch(phone1, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
            Regex.IsMatch(phone1, "^[\d]{10}$")) Then
            numExtension1.Enabled = True
        ElseIf checkExt1.Checked And
               Not (Regex.IsMatch(phone1, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                    Regex.IsMatch(phone1, "^[\d]{10}$")) Then
            'tbPhone1.BorderColor = red
        Else
            numExtension1.Enabled = False
            'tbPhone1.BorderColor = grey
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________



End Class
