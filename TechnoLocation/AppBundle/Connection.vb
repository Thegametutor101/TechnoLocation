Imports System.Text.RegularExpressions

Public Class Connection

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim Msg As FR_CA = New FR_CA
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        testConnection()
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
        If Not IsNothing(username) Then
            Dim result As Boolean = loginController.login(username, password)
            If result Then
                MainForm.getInstance().Show()
                Me.Close()
            End If
        End If
    End Sub

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

    Private Sub btHeaderClose_btQuit_Click(sender As Object, e As EventArgs) Handles btHeaderClose.Click
        If MessageBox.Show("Voulez-vous quitter l'application?",
                           "Attention",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
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


End Class