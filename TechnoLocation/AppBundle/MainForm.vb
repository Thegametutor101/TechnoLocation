Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Public connectionString = "Server='localhost';Database='technolocation';Uid='root';Pwd='';Port=3308;"
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Shared instance As MainForm = Nothing
    Private baseHeight, baseWidth As Integer

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
        Dim dashboard As New UCDashboard()
        dashboard.Dock = DockStyle.Fill
        panelMain.Controls.Add(dashboard)
        dashboard.BringToFront()
        baseHeight = Me.Height
        baseWidth = Me.Width
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
        If MessageBox.Show("Voulez-vous quitter l'application?",
                           "Attention",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btHeaderMaximize_Click(sender As Object, e As EventArgs) Handles btHeaderMaximize.Click, panelHeaderBar.DoubleClick
        Dim topCorner = New Point(0, 0)
        If Not Me.Height = Screen.GetWorkingArea(Me.Location).Height And
           Not Me.Width = Screen.GetWorkingArea(Me.Location).Width And
           Not Me.Location = topCorner Then
            Me.Height = Screen.GetWorkingArea(Me.Location).Height
            Me.Width = Screen.GetWorkingArea(Me.Location).Width
            Me.Location = New Point(0, 0)
            btHeaderMaximize.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
            btHeaderMaximize.PressedState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
            btHeaderMaximize.HoverState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_light_main_18dp")
        ElseIf Me.Height = Screen.GetWorkingArea(Me.Location).Height And
               Me.Width = Screen.GetWorkingArea(Me.Location).Width And
               Me.Location = topCorner Then
            Me.Height = baseHeight
            Me.Width = baseWidth
            Me.CenterToScreen()
            btHeaderMaximize.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
            btHeaderMaximize.PressedState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
            btHeaderMaximize.HoverState.Image = My.Resources.ResourceManager.GetObject("baseline_maximize_2_light_main_18dp")
        End If
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btHome_Click(sender As Object, e As EventArgs)
        Dim iDashboard As New UCDashboard()
        iDashboard.Dock = DockStyle.Fill
        panelMain.Controls.Clear()
        panelMain.Controls.Add(iDashboard)
        iDashboard.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btRent_Click(sender As Object, e As EventArgs) Handles btRent.Click
        Dim iRent As New UCRent()
        iRent.Dock = DockStyle.Fill
        panelMain.Controls.Add(iRent)
        iRent.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btReturn_Click(sender As Object, e As EventArgs)
        Dim iReturn As New UCReturn()
        iReturn.Dock = DockStyle.Fill
        panelMain.Controls.Add(iReturn)
        iReturn.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btUser_Click(sender As Object, e As EventArgs)
        Dim iUser As New UCUser()
        iUser.Dock = DockStyle.Fill
        panelMain.Controls.Add(iUser)
        iUser.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btEquipment_Click(sender As Object, e As EventArgs)
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        panelMain.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btHistory_Click(sender As Object, e As EventArgs)
        Dim iHistory As New UCHistory()
        iHistory.Dock = DockStyle.Fill
        panelMain.Controls.Add(iHistory)
        iHistory.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btCalendar_Click(sender As Object, e As EventArgs)
        Dim iRestriction As New UCRestriction()
        iRestriction.Dock = DockStyle.Fill
        panelMain.Controls.Add(iRestriction)
        iRestriction.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btQuit_Click(sender As Object, e As EventArgs)
        'Dim style = vbYesNo + vbDefaultButton2
        'Dim response = MsgBox(Msg.getMsgQuit, style, Msg.getMsgQuitTitle)

        'If response = vbYes Then
        '    Application.Exit()
        'End If
    End Sub

    Private Sub btEquipment_Click_1(sender As Object, e As EventArgs) Handles btEquipment.Click
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        panelMain.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btDisconnection_Click(sender As Object, e As EventArgs)
        'Dim style = vbYesNo + vbDefaultButton2
        'Dim response = MsgBox(Msg.getMsgDisconnection, style, Msg.getMsgDisconnecTitle)

        'If response = vbYes Then
        '    Connection.Show()
        '    Me.Close()
        'End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


End Class
