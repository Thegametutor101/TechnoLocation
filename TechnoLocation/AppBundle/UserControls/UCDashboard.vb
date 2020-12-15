Public Class UCDashboard

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim topPanelBaseWidth As Integer
    Dim table As DataTable

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        topPanelBaseWidth = panelTotalUsers.Width
        table = EntityRent.getInstance().getLateRentals(mainForm.labLang.Text)
        setValues()
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labRentCountName.TextAlignment = ContentAlignment.MiddleCenter
        labRentCountCount.TextAlignment = ContentAlignment.BottomCenter
        labTotalUserName.TextAlignment = ContentAlignment.MiddleCenter
        labTotalUserCount.TextAlignment = ContentAlignment.BottomCenter
        labInactiveUserName.TextAlignment = ContentAlignment.MiddleCenter
        labInactiveUserCount.TextAlignment = ContentAlignment.BottomCenter
        labDepositName.TextAlignment = ContentAlignment.MiddleCenter
        labDepositCount.TextAlignment = ContentAlignment.BottomCenter
        gridLate.DataSource = table
        loadLanguage()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles mainForm.SizeChanged
        resizeLabels()
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



    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub setValues()
        labRentCountCount.Text = EntityRent.getInstance().getRentCount()
        labTotalUserCount.Text = EntityUser.getInstance().getUsersCount()
        labInactiveUserCount.Text = EntityUser.getInstance().getUsersInactive()
        If mainForm.labLang.Text = "FR" Then
            labDepositCount.Text = Format(EntityRent.getInstance().getRentDeposits(), "0.00$")

        Else
            labDepositCount.Text = Replace(Format(EntityRent.getInstance().getRentDeposits(), "$0.00"),
                                           ".",
                                           ",")
        End If
        If labDepositCount.Text.Length = 7 Then
            labDepositCount.Font = New Font("Segoe UI Symbol", 35, FontStyle.Bold)
            labDepositCount.Location = New Point(labDepositCount.Location.X, labDepositCount.Location.Y + 5)
        ElseIf labDepositCount.Text.Length = 8 Then
            labDepositCount.Font = New Font("Segoe UI Symbol", 30, FontStyle.Bold)
            labDepositCount.Location = New Point(labDepositCount.Location.X, labDepositCount.Location.Y + 10)
        ElseIf labDepositCount.Text.Length = 9 Then
            labDepositCount.Font = New Font("Segoe UI Symbol", 25, FontStyle.Bold)
            labDepositCount.Location = New Point(labDepositCount.Location.X, labDepositCount.Location.Y + 15)
        Else
            labDepositCount.Font = New Font("Segoe UI Symbol", 40, FontStyle.Bold)
        End If
    End Sub

    Public Sub loadLanguage()
        Dim json = Lang.getInstance().getLang()
        labRentCountName.Text = json("DashboardlabRentCountName")
        labTotalUserName.Text = json("DashboardlabTotalUserName")
        labInactiveUserName.Text = json("DashboardlabInactiveUserName")
        labDepositName.Text = json("DashboardlabDepositName")
        gridLate.Columns("code").HeaderText = json("ReturnGridCode")
        gridLate.Columns("renterName").HeaderText = json("ReturnGridRenter")
        gridLate.Columns("lenderName").HeaderText = json("ReturnGridLender")
        gridLate.Columns("equipmentAmount").HeaderText = json("ReturnGridEquipments")
        gridLate.Columns("rentDate").HeaderText = json("ReturnGridRentDate")
        gridLate.Columns("returnDate").HeaderText = json("ReturnGridReturnDate")
        gridLate.Columns("depositAmount").HeaderText = json("ReturnGridDeposit")
        gridLate.Columns("code").Width = 80
        gridLate.Columns("depositAmount").Width = 90
        gridLate.Columns("equipmentAmount").Width = 100
        labLate.Text = json("DashboardLabLate")
    End Sub

    Public Sub resizeLabels()
        If mainForm.Height = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Height And
           mainForm.Width = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Width Then
            Dim increaseWidth = Me.Width / mainForm.panelBaseWidth
            Dim increaseHeight = Me.Height / mainForm.panelBaseHeight
            panelRentCount.Size = New Size(CInt(topPanelBaseWidth * increaseWidth), 160)
            panelTotalUsers.Size = New Size(CInt(topPanelBaseWidth * increaseWidth), 160)
            panelInactiveUsers.Size = New Size(CInt(topPanelBaseWidth * increaseWidth), 160)
            panelDepositCount.Size = New Size(CInt(topPanelBaseWidth * increaseWidth), 160)
        Else
            panelRentCount.Size = New Size(topPanelBaseWidth, 160)
            panelTotalUsers.Size = New Size(topPanelBaseWidth, 160)
            panelInactiveUsers.Size = New Size(topPanelBaseWidth, 160)
            panelDepositCount.Size = New Size(topPanelBaseWidth, 160)
        End If
    End Sub

End Class
