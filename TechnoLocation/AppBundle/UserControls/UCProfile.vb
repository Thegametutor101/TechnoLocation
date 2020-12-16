Imports System.Text.RegularExpressions
Public Class UCProfile



    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim data As DataRow
    Dim codesBarres As New BarCodes
    Dim msgDelete As String
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
            loadLanguages()
            numCode.Text = mainForm.code
            tbFirstName.Text = data.Item("firstName")
            tbLastName.Text = data.Item("lastName")
            tbEmail.Text = data.Item("email")
            tbPhone1.Text = data.Item("phoneMain")
            tbPhone2.Text = data.Item("phone2")
            dropStatus.SelectedIndex = data.Item("job")
            dropPermissions.SelectedIndex = data.Item("permissions")
            numBalance.Text = data.Item("balance")
            If (Not data.Item("extensionMain") = -1) Then
                numExtension1.Enabled = True
                checkExt1.Checked = True
                numExtension1.Text = data.Item("extensionMain")
            End If
            If (Not data.Item("extension2") = -1) Then
                numExtension2.Enabled = True
                checkExt2.Checked = True
                numExtension1.Text = data.Item("extension2")
            End If
        End If
        If Not data.Item("permissions") = 3 Then
            tbFirstName.Enabled = False
            tbLastName.Enabled = False
            dropStatus.Enabled = False
            dropPermissions.Enabled = False
            numBalance.Enabled = False
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

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

    Private Sub ChangedValues(sender As Object, e As EventArgs) Handles tbFirstName.TextChanged,
                                                                        tbLastName.TextChanged,
                                                                        tbEmail.TextChanged,
                                                                        tbPhone1.TextChanged,
                                                                        tbPhone2.TextChanged
        mainForm.isEditing = True
    End Sub

    Private Sub numCode_ValueChanged(sender As Object, e As EventArgs) Handles numCode.ValueChanged
        mainForm.isEditing = True
        If numCode.Value >= 10000000 Then
            numCode.Value = Integer.Parse(codesBarres.isBarcodeUser(numCode.Value.ToString))
        End If
    End Sub



    Private Sub numCode_GotFocus(sender As Object, e As EventArgs) Handles numCode.GotFocus
        numCode.Text = ""
    End Sub



    Private Sub numCode_LostFocus(sender As Object, e As EventArgs) Handles numCode.LostFocus
        numCode.Text = numCode.Value
    End Sub

    Private Sub numCode_KeyUp(sender As Object, e As KeyEventArgs) Handles numCode.KeyUp
        If e.KeyCode = Keys.V Then
            Try
                numCode.Value = Integer.Parse(codesBarres.isBarcodeUser(numCode.Value.ToString))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub checkExt1_CheckedChanged(sender As Object, e As EventArgs) Handles checkExt1.CheckedChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim phone1 = Trim(tbPhone1.Text)
        If checkExt1.Checked And
           (Regex.IsMatch(phone1, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
            Regex.IsMatch(phone1, "^[\d]{10}$")) Then
            numExtension1.Enabled = True
        ElseIf checkExt1.Checked And
               Not (Regex.IsMatch(phone1, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                    Regex.IsMatch(phone1, "^[\d]{10}$")) Then
            tbPhone1.BorderColor = red
        Else
            numExtension1.Enabled = False
            tbPhone1.BorderColor = grey
        End If
    End Sub

    Private Sub checkExt2_CheckedChanged(sender As Object, e As EventArgs) Handles checkExt2.CheckedChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim phone2 = Trim(tbPhone2.Text)
        If checkExt2.Checked And
           (Regex.IsMatch(phone2, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
            Regex.IsMatch(phone2, "^[\d]{10}$")) Then
            numExtension2.Enabled = True
        ElseIf checkExt2.Checked And
               Not (Regex.IsMatch(phone2, "^(\([\d]{3}\)|[\d]{3})(\s|-)[\d]{3}-[\d]{4}$") Or
                    Regex.IsMatch(phone2, "^[\d]{10}$")) Then
            tbPhone2.BorderColor = red
        Else
            numExtension2.Enabled = False
            tbPhone2.BorderColor = grey
        End If
    End Sub

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
        If numCode.Value >= 10000000 Then
            matricule = Math.Floor(numCode.Value / 10)
        Else
            matricule = numCode.Value
        End If
        ModelUser.getInstance().updateUser(CInt(numCode.Value),
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
                                               CInt(numBalance.Value))
        Me.SendToBack()
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

    Private Sub btCancelUser_Click(sender As Object, e As EventArgs) Handles btCancelUser.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If Not numCode.Value.Equals(mainForm.code) Or
           Not String.IsNullOrEmpty(tbFirstName.Text) Or
           Not String.IsNullOrEmpty(tbLastName.Text) Or
           Not String.IsNullOrEmpty(tbEmail.Text) Or
           Not String.IsNullOrEmpty(tbPhone1.Text) Or
           Not String.IsNullOrEmpty(tbPhone2.Text) Or
           (Not numCode.Value = numCode.Minimum) Then
            If MessageBox.Show(message,
                               title,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                mainForm.isEditing = False
                Me.SendToBack()
            End If
        Else
            mainForm.isEditing = False
            Me.SendToBack()
        End If
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If (EntityRent.getInstance().getRentCountRenter(mainForm.code) = 0) Then
            ModelUser.getInstance().delUser(mainForm.code)
        Else MessageBox.Show(msgDelete)
        End If
        Me.SendToBack()
    End Sub

    Private Sub btModifyUser_Click(sender As Object, e As EventArgs) Handles btSaveModification.Click
        tbFirstName.BorderColor = Color.FromArgb(1, 213, 218, 223)
        tbLastName.BorderColor = Color.FromArgb(1, 213, 218, 223)
        tbEmail.BorderColor = Color.FromArgb(1, 213, 218, 223)
        tbPhone1.BorderColor = Color.FromArgb(1, 213, 218, 223)
        tbPhone2.BorderColor = Color.FromArgb(1, 213, 218, 223)
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
                            tbPhone2.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                        End If
                    Else
                        tbPhone1.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                    End If
                Else
                    tbEmail.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                End If
            Else
                tbLastName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
            End If
        Else
            tbFirstName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


    Public Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btSaveModification.Text = json("SaveItem")
        btDelete.Text = json("DeleteItem")
        btCancelUser.Text = json("CancelButton")
        labCodeUser.Text = json("UserAddLabMatricula")
        labName.Text = json("UserAddLabName")
        tbFirstName.PlaceholderText = json("UserAddLabFirstNamePlaceholder")
        tbLastName.PlaceholderText = json("UserAddLabLastNamePlaceholder")
        labEmail.Text = json("UserAddLabEmail")
        labPhone.Text = json("UserAddLabPhone1")
        labPhone2.Text = json("UserAddLabPhone2")
        labStatus.Text = json("UserAddLabStatus")
        labPermissions.Text = json("UserAddLabPermissions")
        labPassword.Text = json("UserAddLabPassword")
        labSetPassword.Text = json("UserAddLabSetPassword")
        labBalance.Text = json("UserAddLabBalance")
        dropPermissions.Items.Add(json("UserAddDropPermissions0"))
        dropPermissions.Items.Add(json("UserAddDropPermissions1"))
        dropPermissions.Items.Add(json("UserAddDropPermissions2"))
        dropPermissions.Items.Add(json("UserAddDropPermissions3"))
        dropStatus.Items.Add(json("UserAddDropStatus0"))
        dropStatus.Items.Add(json("UserAddDropStatus1"))
        dropStatus.Items.Add(json("UserAddDropStatus2"))
        labExt1.Text = json("UserLabCheckExtension")
        labExt2.Text = json("UserLabCheckExtension")
        msgDelete = json("MsgDeleteUserFail")
    End Sub
End Class
