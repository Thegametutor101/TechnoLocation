Imports System.Text.RegularExpressions

Public Class UCUserModify


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim interfaceUser As UCUser
    Dim baseInputWidth As Integer
    Dim baseLastNameLocation As Point
    Dim baseNumExt1Location As Point
    Dim baseNumExt2Location As Point
    Dim basecheckExt1Location As Point
    Dim basecheckExt2Location As Point
    Dim baselabExt1Location As Point
    Dim baselabExt2Location As Point
    Dim baseRow As DataRow
    Dim codesBarres As New BarCodes

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(id As Integer, main As MainForm, user As UCUser)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
        interfaceUser = user

        baseRow = EntityUser.getInstance().getUserByCode(id).Rows(0)
        baseInputWidth = tbPassword.Width
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCUserModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLanguages()
        checkPassword.Checked = False
        dropPermissions.SelectedIndex = 0
        dropStatus.SelectedIndex = 0
        baseLastNameLocation = tbLastName.Location
        baseNumExt1Location = numExtension1.Location
        baseNumExt2Location = numExtension2.Location
        basecheckExt1Location = checkExt1.Location
        basecheckExt2Location = checkExt2.Location
        baselabExt1Location = labExt1.Location
        baselabExt2Location = labExt2.Location
        resizeInputs()
        numCode.Value = baseRow.Item("code")
        tbFirstName.Text = baseRow.Item("firstName")
        tbLastName.Text = baseRow.Item("lastName")
        tbEmail.Text = baseRow.Item("email")
        tbPhone1.Text = baseRow.Item("phoneMain")
        tbPhone2.Text = baseRow.Item("phone2")
        dropStatus.SelectedIndex = baseRow.Item("job")
        dropPermissions.SelectedIndex = baseRow.Item("permissions")
        numBalance.Value = baseRow.Item("balance")
        numCode.Select()
        If baseRow.Item("extensionMain") = -1 Then
            numExtension1.Value = 0
            numExtension1.Enabled = False
        Else
            numExtension1.Value = baseRow.Item("extensionMain")
            checkExt1.Checked = True
        End If
        If baseRow.Item("extension2") = -1 Then
            numExtension2.Value = 0
            numExtension2.Enabled = False
        Else
            numExtension2.Value = baseRow.Item("extension2")
            checkExt2.Checked = True
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

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles mainForm.SizeChanged
        resizeInputs()
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
                                               numBalance.Value)
        interfaceUser.loadDataGridView()
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

    Private Sub btCancelUser_Click(sender As Object, e As EventArgs) Handles btCancelUser.Click, btBack.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If Not numCode.Value.Equals(baseRow.Item("code")) Or
           Not tbFirstName.Text.Equals(baseRow.Item("firstName")) Or
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

    Private Sub btModifyUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
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
        btAddUser.Text = json("SaveItem")
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
    End Sub

    Private Sub resizeInputs()
        If mainForm.Height = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Height And
           mainForm.Width = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Width Then
            Dim increaseWidth = (Me.Width / mainForm.panelBaseWidth) + 0.4
            Dim increaseHeight = (Me.Height / mainForm.panelBaseHeight) + 0.4
            numCode.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbFirstName.Size = New Size(CInt(((baseInputWidth * increaseWidth) / 2) - 3), 36)
            tbLastName.Location = New Point(tbLastName.Location.X +
                                            (CInt(((baseInputWidth * increaseWidth) / 2) + 3) -
                                             (baseInputWidth / 2) - 3),
                                            tbLastName.Location.Y)
            tbLastName.Size = New Size(CInt(((baseInputWidth * increaseWidth) / 2) - 3), 36)
            tbEmail.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPhone1.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPhone2.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            dropStatus.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            dropPermissions.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            tbPassword.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            numBalance.Size = New Size(CInt(baseInputWidth * increaseWidth), 36)
            numExtension1.Location = New Point(numExtension1.Location.X +
                                               CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                               numExtension1.Location.Y)
            numExtension2.Location = New Point(numExtension2.Location.X +
                                               CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                               numExtension2.Location.Y)
            checkExt1.Location = New Point(checkExt1.Location.X +
                                           CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                           checkExt1.Location.Y)
            checkExt2.Location = New Point(checkExt2.Location.X +
                                           CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                           checkExt2.Location.Y)
            labExt1.Location = New Point(labExt1.Location.X +
                                         CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                         labExt1.Location.Y)
            labExt2.Location = New Point(labExt2.Location.X +
                                         CInt(baseInputWidth * increaseWidth) - baseInputWidth,
                                         labExt2.Location.Y)
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
            numBalance.Size = New Size(baseInputWidth, 36)
            numExtension1.Location = baseNumExt1Location
            numExtension2.Location = baseNumExt2Location
            checkExt1.Location = basecheckExt1Location
            checkExt2.Location = basecheckExt2Location
            labExt1.Location = baselabExt1Location
            labExt2.Location = baselabExt2Location
        End If
    End Sub
End Class
