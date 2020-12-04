Imports System.Text.RegularExpressions
Public Class UCUserAdd


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm
    Dim baseInputWidth As Integer
    Dim baseLastNameLocation As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        baseInputWidth = tbPassword.Width
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCUserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLanguages()
        checkPassword.Checked = False
        dropPermissions.SelectedIndex = 0
        dropStatus.SelectedIndex = 0
        baseLastNameLocation = tbLastName.Location
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

    Private Sub ChangedValues(sender As Object, e As EventArgs) Handles numCode.ValueChanged,
                                                                        tbFirstName.TextChanged,
                                                                        tbLastName.TextChanged,
                                                                        tbEmail.TextChanged,
                                                                        tbPhone1.TextChanged,
                                                                        tbPhone2.TextChanged
        mainForm.isEditing = True
    End Sub

    Private Sub submit(password As String,
                       firstName As String,
                       lastName As String,
                       email As String,
                       phone1 As String,
                       phone2 As String)
        mainForm.isEditing = False
        ModelUser.getInstance().addUser(CInt(numCode.Value),
                                        password,
                                        firstName,
                                        lastName,
                                        email,
                                        phone1,
                                        phone2,
                                        dropStatus.SelectedIndex,
                                        dropPermissions.SelectedIndex,
                                        0)
    End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles mainForm.SizeChanged
        resizeInputs()
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

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
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
                    If (Regex.IsMatch(phone1, "^\([\d]{3}\)\s[\d]{3}-[\d]{4}$") Or
                   Regex.IsMatch(phone1, "^[\d]{10}$")) Then
                        If (Regex.IsMatch(phone2, "^\([\d]{3}\)\s[\d]{3}-[\d]{4}$") Or
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

    Private Sub btCancelUser_Click(sender As Object, e As EventArgs) Handles btCancelUser.Click, btBack.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If Not String.IsNullOrEmpty(tbFirstName.Text) Or
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

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadLanguages()
        btAddUser.Text = Lang.getInstance().getLang()("SaveItem")
        btCancelUser.Text = Lang.getInstance().getLang()("CancelButton")
        labCodeUser.Text = Lang.getInstance().getLang()("UserAddLabMatricula")
        labName.Text = Lang.getInstance().getLang()("UserAddLabName")
        tbFirstName.PlaceholderText = Lang.getInstance().getLang()("UserAddLabFirstNamePlaceholder")
        tbLastName.PlaceholderText = Lang.getInstance().getLang()("UserAddLabLastNamePlaceholder")
        labEmail.Text = Lang.getInstance().getLang()("UserAddLabEmail")
        labPhone.Text = Lang.getInstance().getLang()("UserAddLabPhone1")
        labPhone2.Text = Lang.getInstance().getLang()("UserAddLabPhone2")
        labStatus.Text = Lang.getInstance().getLang()("UserAddLabStatus")
        labPermissions.Text = Lang.getInstance().getLang()("UserAddLabPermissions")
        labPassword.Text = Lang.getInstance().getLang()("UserAddLabPassword")
        labSetPassword.Text = Lang.getInstance().getLang()("UserAddLabSetPassword")
        dropPermissions.Items.Add(Lang.getInstance().getLang()("UserAddDropPermissions0"))
        dropPermissions.Items.Add(Lang.getInstance().getLang()("UserAddDropPermissions1"))
        dropPermissions.Items.Add(Lang.getInstance().getLang()("UserAddDropPermissions2"))
        dropPermissions.Items.Add(Lang.getInstance().getLang()("UserAddDropPermissions3"))
        dropStatus.Items.Add(Lang.getInstance().getLang()("UserAddDropStatus0"))
        dropStatus.Items.Add(Lang.getInstance().getLang()("UserAddDropStatus1"))
        dropStatus.Items.Add(Lang.getInstance().getLang()("UserAddDropStatus2"))
    End Sub

    Private Sub resizeInputs()
        If mainForm.Height = Screen.GetWorkingArea(mainForm.Location).Height And
           mainForm.Width = Screen.GetWorkingArea(mainForm.Location).Width Then
            Dim increaseWidth = (Me.Width / mainForm.panelBaseWidth) + 0.4
            Dim increaseHeight = (Me.Height / mainForm.panelBaseHeight) + 0.4
            numCode.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbFirstName.Size = New Size(CInt(((baseInputWidth * increaseWidth) / 2) - 3), 36)
            tbLastName.Location = New Point(tbLastName.Location.X + (CInt(((baseInputWidth * increaseWidth) / 2) + 3) - (baseInputWidth / 2) - 3),
                                            tbLastName.Location.Y)
            tbLastName.Size = New Size(CInt(((baseInputWidth * increaseWidth) / 2) - 3), 36)
            tbEmail.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPhone1.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPhone2.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            dropStatus.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            dropPermissions.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPassword.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
        Else
            numCode.Size = New Size(baseInputWidth, 36)
            tbFirstName.Size = New Size((baseInputWidth / 2) - 3, 36)
            tbLastName.Location = baseLastNameLocation
            tbLastName.Size = New Size((baseInputWidth / 2) - 3, 36)
            tbEmail.Size = New Size(baseInputWidth, 36)
            tbPhone1.Size = New Size(baseInputWidth, 36)
            tbPhone2.Size = New Size(baseInputWidth, 36)
            dropStatus.Size = New Size(baseInputWidth, 36)
            dropPermissions.Size = New Size(baseInputWidth, 36)
            tbPassword.Size = New Size(baseInputWidth, 36)
        End If
    End Sub

End Class
