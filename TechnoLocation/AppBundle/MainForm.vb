Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim Msg As FR_CA = New FR_CA
    Public connectionString = "Server='localhost';Database='technolocation';Uid='root';Pwd='';Port=3308;"
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Shared instance As MainForm = Nothing

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
        Me.CenterToScreen()
        Dim dashboard As New UCDashboard()
        dashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(dashboard)
        dashboard.BringToFront()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Public Sub bringToFrontAddEquipment()
        Dim iEquipmentAdd As New UCEquipmentAdd()
        iEquipmentAdd.Dock = DockStyle.Fill
        p_Main.Controls.Add(iEquipmentAdd)
        iEquipmentAdd.BringToFront()
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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Dim iDashboard As New UCDashboard()
        iDashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(iDashboard)
        iDashboard.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btAlert_Click(sender As Object, e As EventArgs) Handles btAlert.Click

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btBorrow_Click(sender As Object, e As EventArgs) Handles btBorrow.Click
        Dim iRent As New UCRent()
        iRent.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRent)
        iRent.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btReturn_Click(sender As Object, e As EventArgs) Handles btReturn.Click
        Dim iReturn As New UCReturn()
        iReturn.Dock = DockStyle.Fill
        p_Main.Controls.Add(iReturn)
        iReturn.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btUser_Click(sender As Object, e As EventArgs) Handles btUser.Click
        Dim iUser As New UCUser()
        iUser.Dock = DockStyle.Fill
        p_Main.Controls.Add(iUser)
        iUser.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btEquipment_Click(sender As Object, e As EventArgs) Handles btEquipment.Click
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        p_Main.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btHistory_Click(sender As Object, e As EventArgs) Handles btHistory.Click
        Dim iHistory As New UCHistory()
        iHistory.Dock = DockStyle.Fill
        p_Main.Controls.Add(iHistory)
        iHistory.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btCalendar_Click(sender As Object, e As EventArgs) Handles btCalendar.Click
        Dim iRestriction As New UCRestriction()
        iRestriction.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRestriction)
        iRestriction.BringToFront()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btQuit_Click(sender As Object, e As EventArgs) Handles btQuit.Click
        Dim style = vbYesNo + vbDefaultButton2
        Dim response = MsgBox(Msg.getMsgQuit, style, Msg.getMsgQuitTitle)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btDisconnection_Click(sender As Object, e As EventArgs) Handles btDisconnection.Click
        Dim style = vbYesNo + vbDefaultButton2
        Dim response = MsgBox(Msg.getMsgDisconnection, style, Msg.getMsgDisconnecTitle)

        If response = vbYes Then
            Connection.Show()
            Me.Close()
        End If
    End Sub

    Private Sub p_Main_Paint(sender As Object, e As PaintEventArgs) Handles p_Main.Paint

    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


End Class
