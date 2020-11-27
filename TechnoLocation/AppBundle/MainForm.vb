Imports Newtonsoft.Json.Linq

Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Public connectionString = "Server='localhost';Database='technolocation';Uid='root';Pwd='';Port=3308;"
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Shared instance As MainForm = Nothing
    Private baseHeight, baseWidth As Integer
    Public panelBaseWidth, panelBaseHeight As Integer

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    ''' <summary>
    ''' Au chargement nous voulons voir le Dashboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dashboard As New UCDashboard(Me)
        dashboard.Dock = DockStyle.Fill
        panelMain.Controls.Add(dashboard)
        dashboard.BringToFront()
        baseHeight = Me.Height
        baseWidth = Me.Width
        labLang.TextAlignment = ContentAlignment.MiddleCenter
        labAccount.TextAlignment = ContentAlignment.MiddleLeft
        labDisconnect.TextAlignment = ContentAlignment.MiddleCenter
        labProfile.TextAlignment = ContentAlignment.MiddleCenter
        labSettings.TextAlignment = ContentAlignment.MiddleCenter
        panelAccountOptions.Visible = False
        panelBaseHeight = panelMain.Height
        panelBaseWidth = panelMain.Width
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    '* Only highlights 1 control on the form
    'Private Sub MainForm_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    If Me.WindowState = FormWindowState.Normal Then
    '        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid)
    '    End If
    'End Sub

    Private Sub HeaderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Window Position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Left Mouse Button has been pressed
            isMouseDown = True
            Dim top As New Point(0, 0)
            If Me.Location = top Then
                maximize()
            End If
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
            If Control.MousePosition.Y <= 5 Then
                maximize()
            End If
            isMouseDown = False
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________

    Public Shared Function getInstance() As MainForm
        If IsNothing(instance) Then
            instance = New MainForm()
        End If
        Return instance
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btHeaderClose_btQuit_Click(sender As Object, e As EventArgs) Handles btHeaderClose.Click
        Dim title As String = Lang.getInstance().getLang()("MsgQuitTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgQuit")
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btHeaderMaximize_Click(sender As Object, e As EventArgs) Handles btHeaderMaximize.Click, panelHeaderBar.DoubleClick
        maximize()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
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
        For Each o As Control In panelMain.Controls
            o.Refresh()
        Next
    End Sub

    Private Sub labAccount_Click(sender As Object, e As EventArgs) Handles labAccount.Click
        If Not panelAccountOptions.Visible Then
            panelAccountOptions.Visible = True
            panelAccountOptions.BringToFront()
        End If
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Dim iDashboard As New UCDashboard(Me)
        iDashboard.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iDashboard)
        iDashboard.BringToFront()
    End Sub

    Private Sub btAlert_Click(sender As Object, e As EventArgs) Handles btAlert.Click
        Dim open As Boolean = False
        Dim notifications As New UCNotif()
        For Each control As Object In panelMain.Controls
            If control.GetType() = notifications.GetType() Then
                open = True
                notifications = control
            End If
        Next
        If open Then
            panelMain.Controls.Remove(notifications)
        Else

            notifications.Dock = DockStyle.Left
            panelMain.Controls.Add(notifications)
            notifications.BringToFront()
        End If
    End Sub

    Private Sub btRent_Click(sender As Object, e As EventArgs) Handles btRent.Click
        Dim iRent As New UCRent()
        iRent.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iRent)
        iRent.BringToFront()
    End Sub

    Private Sub btReturn_Click(sender As Object, e As EventArgs) Handles btReturn.Click
        Dim iReturn As New UCReturn()
        iReturn.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iReturn)
        iReturn.BringToFront()
    End Sub

    Private Sub btEquipment_Click(sender As Object, e As EventArgs) Handles btEquipment.Click
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub

    Private Sub btHistory_Click(sender As Object, e As EventArgs) Handles btHistory.Click
        Dim iHistory As New UCHistory()
        iHistory.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iHistory)
        iHistory.BringToFront()
    End Sub

    Private Sub btCalendar_Click(sender As Object, e As EventArgs) Handles btCalendar.Click
        Dim iRestriction As New UCRestriction()
        iRestriction.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iRestriction)
        iRestriction.BringToFront()
    End Sub

    Private Sub btUser_Click(sender As Object, e As EventArgs) Handles btUser.Click
        Dim iUser As New UCUser(Me)
        iUser.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iUser)
        iUser.BringToFront()
    End Sub

    Private Sub labDisconnect_Click(sender As Object, e As EventArgs) Handles labDisconnect.Click
        Dim title As String = Lang.getInstance().getLang()("MsgDisconnecTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgDisconnection")
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim connection As New Connection
            connection.Show()
            Me.Close()
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadLanguage()
        labAccount.Text = Lang.getInstance().getLang()("MainlabAccount")
        labPersonConnected.Text = Lang.getInstance().getLang()("MainlabPersonConnected")
        btHome.Text = Lang.getInstance().getLang()("MainbtHome")
        btAlert.Text = Lang.getInstance().getLang()("MainbtAlert")
        btRent.Text = Lang.getInstance().getLang()("MainbtRent")
        btReturn.Text = Lang.getInstance().getLang()("MainbtReturn")
        btUser.Text = Lang.getInstance().getLang()("MainbtUser")
        btEquipment.Text = Lang.getInstance().getLang()("MainbtEquipment")
        btHistory.Text = Lang.getInstance().getLang()("MainbtHistory")
        btCalendar.Text = Lang.getInstance().getLang()("MainbtCalendar")
        labProfile.Text = Lang.getInstance().getLang()("MainlabProfile")
        labSettings.Text = Lang.getInstance().getLang()("MainlabSettings")
        labDisconnect.Text = Lang.getInstance().getLang()("MainlabDisconnect")
    End Sub

    Private Sub panelAccountOptions_MouseLeave(sender As Object, e As EventArgs) Handles panelAccountOptions.MouseLeave,
                                                                                         labAccount.MouseLeave
        Dim mouseX = Control.MousePosition.X
        Dim mouseY = Control.MousePosition.Y
        Dim panelAbsoluteLocation As Point
        Dim formLocation = Me.Location
        Dim panelHeaderBarHeight = panelHeaderBar.Height
        panelAbsoluteLocation = New Point((formLocation.X + panelAccountOptions.Location.X),
                                          (formLocation.Y + panelHeaderBarHeight))
        Dim labelWidth = labAccount.Width
        Dim labelHeight = labAccount.Height
        Dim labelLocation = formLocation + labAccount.Location
        Dim panelWidth = panelAccountOptions.Width
        Dim panelHeight = panelAccountOptions.Height
        Dim panelLocation = panelAbsoluteLocation
        If Not ((mouseX >= panelLocation.X) And
                (mouseX <= panelLocation.X + panelWidth) And
                (mouseY >= panelLocation.Y) And
                (mouseY <= panelLocation.Y + panelHeight)) AndAlso
            Not ((mouseX >= labelLocation.X) And
                    (mouseX <= labelLocation.X + labelWidth) And
                    (mouseY >= labelLocation.Y) And
                    (mouseY <= labelLocation.Y + labelHeight)) Then
            panelAccountOptions.Visible = False
        End If
    End Sub

    Private Sub panelMain_Paint(sender As Object, e As PaintEventArgs) Handles panelMain.Paint

    End Sub

    Public Sub setLanguage(language As String)
        If language = "FR" Then
            labLang.Text = "FR"
            Lang.getInstance().setLang("en_us")
        ElseIf language = "EN" Then
            labLang.Text = "EN"
            Lang.getInstance().setLang("fr_ca")
        End If
        loadLanguage()
    End Sub

    Public Sub maximize()
        Dim topCorner = New Point(0, 0)
        If Not Me.Height = Screen.GetWorkingArea(Me.Location).Height And
           Not Me.Width = Screen.GetWorkingArea(Me.Location).Width And
           Not Me.Location = topCorner Then
            'This changes the position and size of the window to be full screen while showing the task bar
            Me.Location = New Point(0, 0)
            Me.Height = Screen.GetWorkingArea(Me.Location).Height
            Me.Width = Screen.GetWorkingArea(Me.Location).Width
            'Changes the maximise icon according to it's state
            btHeaderMaximize.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
            btHeaderMaximize.PressedState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
            btHeaderMaximize.HoverState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
        ElseIf Me.Height = Screen.GetWorkingArea(Me.Location).Height And
               Me.Width = Screen.GetWorkingArea(Me.Location).Width And
               Me.Location = topCorner Then
            'This changes the position and size of the window to be centered and back to it's original size
            Me.Height = baseHeight
            Me.Width = baseWidth
            Me.CenterToScreen()
            'Changes the maximise icon according to it's state
            btHeaderMaximize.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
            btHeaderMaximize.PressedState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
            btHeaderMaximize.HoverState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
        End If
    End Sub
End Class
