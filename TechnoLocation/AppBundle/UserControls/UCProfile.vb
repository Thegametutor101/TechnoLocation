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
        data = EntityUser.getInstance().getUsersCode(mainForm.code).Rows(0)
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not mainForm.code = 0 Then

            tbCode.Text = mainForm.code
            tbFirstName.Text = data.Item("firstName")
            tbLastName.Text = data.Item("lastName")
            tbEmail.Text = data.Item("email")
            tbPhone1.Text = data.Item("phoneMain")
            tbPhone2.Text = data.Item("phone2")
            tbJob.Text = data.Item("job")
        End If
    End Sub



    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



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
                            'If checkPassword.Checked And Not String.IsNullOrEmpty(password) Then
                            'submit(password, firstName, lastName, email, phone1, phone2)
                            'ElseIf checkPassword.Checked And String.IsNullOrEmpty(password) Then
                            Dim title As String = Lang.getInstance().getLang()("MsgWarning")
                            Dim message As String = Lang.getInstance().getLang()("MsgSubmitNoPassword")
                            If MessageBox.Show(message,
                                               title,
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                                '           submit(password, firstName, lastName, email, phone1, phone2)
                            End If
                        Else
                            '      submit(password, firstName, lastName, email, phone1, phone2)
                        End If
                    Else
                        '    tbPhone2.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                    End If
                Else
                    '   tbPhone1.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
                End If
            Else
                '  tbEmail.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
            End If
        Else
            ' tbLastName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
        End If
        'Else
        ''tbFirstName.BorderColor = Color.FromArgb(0.8, 224, 70, 70)
        'End If
    End Sub

    Private Sub btDeleteAccount_Click(sender As Object, e As EventArgs) Handles btDeleteAccount.Click

    End Sub


    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________



End Class
