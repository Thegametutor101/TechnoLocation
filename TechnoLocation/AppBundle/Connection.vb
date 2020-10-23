Imports System.Text.RegularExpressions

Public Class Connection

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim Msg As FR_CA = New FR_CA

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        testConnection()
        'testConnection()
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________

    Public Function testConnection()
        If Not EntityUser.getInstance().testConnection() Then
            MessageBox.Show($"Impossible de trouver la base de donnée associée à: {Environment.NewLine}{Environment.NewLine}{MainForm.getInstance().connectionString}")
            Me.Close()
        End If
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btQuitConnection_Click(sender As Object, e As EventArgs) Handles btQuitConnection.Click
        If MessageBox.Show("Voulez-vous quitter le programme ?",
                           "Attention",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btConnection_Click(sender As Object, e As EventArgs) Handles btConnection.Click
        Dim loginController = New LoginController
        Dim username As String = Regex.Replace(tbUsername.Text, "[^A-Za-z0-9]", String.Empty)
        Dim password As String = Replace(tbPassword.Text, " ", "")
        If Not IsNothing(username) Then
            Dim result As Boolean = loginController.login(username, password)
            If result Then
                MainForm.getInstance().Show()
                Me.Close()
            End If
        End If
        tbUsername.BackColor = Color.FromArgb(255, 107, 107)
        tbPassword.BackColor = Color.FromArgb(255, 107, 107)
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


End Class