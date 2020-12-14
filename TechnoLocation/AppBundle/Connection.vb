Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class Connection

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Dim codesbarres As New BarCodes

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lang.getInstance().setLang("fr_ca")
        testConnection()
        loadLanguage()
        tbUsername.Select()
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub HeaderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Window Position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Left Mouse Button has been pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub HeaderBar_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Obtain new Window Position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub HeaderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseUp
        If e.Button = MouseButtons.Left Then
            'Left Mouse Button has been released
            isMouseDown = False
        End If
    End Sub

    Private Sub EnterPressed(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown, tbUsername.KeyDown, MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub login()
        Dim loginController = New LoginController
        Dim username As String = Regex.Replace(tbUsername.Text, "[^A-Za-z0-9]", String.Empty)
        Dim password As String = Replace(tbPassword.Text, " ", "")
        'loginController.createAccount(username, password)
        If Not IsNothing(username) Then
            Dim result As Boolean = loginController.login(username, password)
            If result Then
                Dim main As MainForm
                If username = "admin" Then
                    main = New MainForm(0)
                Else
                    main = New MainForm(CInt(username))
                End If
                main.Show()
                main.setLanguage(labLang.Text)
                Me.Close()
            End If
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________

    Public Function testConnection()
        If Not EntityUser.getInstance().testConnection() Then
            MessageBox.Show($"{Lang.getInstance().getLang()("DatabaseNotFound")}
                            {Environment.NewLine}{Environment.NewLine}{MainForm.getInstance().connectionString}")
            Me.Close()
        End If
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btHeaderClose_btQuit_Click(sender As Object, e As EventArgs) Handles btHeaderClose.Click
        Me.Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btConnect_Click(sender As Object, e As EventArgs) Handles btConnect.Click
        login()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadLanguage()
        Dim json = Lang.getInstance().getLang()
        labUsername.Text = json("ConnectionlabUsername")
        labPassword.Text = json("ConnectionlabPassword")
        tbUsername.PlaceholderText = json("ConnectiontbUsernamePlaceholder")
        linklabPasswordForget.Text = json("ConnectionlabPasswordForget")
        btConnect.Text = json("ConnectionbtConnect")
    End Sub

    Private Sub labLang_Click(sender As Object, e As EventArgs) Handles labLang.Click
        If labLang.Text = "EN" Then
            labLang.Text = "FR"
            Lang.getInstance().setLang("en_us")
            loadLanguage()
        ElseIf labLang.Text = "FR" Then
            labLang.Text = "EN"
            Lang.getInstance().setLang("fr_ca")
            loadLanguage()
        End If
    End Sub

    Private Sub tbUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles tbUsername.KeyUp
        If e.KeyCode = Keys.V Then
            tbUsername.Text = codesbarres.isBarcodeUser(tbUsername.Text)
        End If
    End Sub
End Class