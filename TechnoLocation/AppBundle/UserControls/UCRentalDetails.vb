Public Class UCRentalDetails

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim rental As Integer
    Dim baseLocationLastName, baseLocationLabAuthorized, baseLocationTBAuthorized As Point
    Dim baseLeftInputWidth, baseRightInputWidth, baseAuthorizedWidth As Integer
    Dim basePanelLeft As Size

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, code As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        rental = code
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCRentalDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baseLocationLastName = tbLastName.Location
        baseLocationLabAuthorized = labAuthorized.Location
        baseLocationTBAuthorized = tbAuthorized.Location
        baseLeftInputWidth = tbPhone1.Width
        baseRightInputWidth = tbRentDate.Width
        baseAuthorizedWidth = tbAuthorized.Width
        basePanelLeft = panelLeft.Size
        loadData()
        loadLanguages()
        resizeInterface()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged
        If checkAll.Checked Then
            gridEquipments.SelectAll()
        Else
            gridEquipments.ClearSelection()
            gridEquipments.Rows(0).Selected = True
        End If
    End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles mainForm.SizeChanged
        resizeInterface()
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

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.SendToBack()
    End Sub
    Private Sub gridEquipments_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridEquipments.CellMouseDoubleClick
        Dim returnEquipment = New ReturnEquipment(mainForm, rental, gridEquipments.CurrentRow)
        returnEquipment.ShowDialog()
    End Sub

    Private Sub btReturn_Click(sender As Object, e As EventArgs) Handles btReturn.Click
        Dim returnEquipment = New ReturnEquipment(mainForm, rental, gridEquipments.SelectedRows)
        returnEquipment.ShowDialog()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadData()
        Dim data = EntityRent.getInstance().getRentalDetails(mainForm.labLang.Text, rental).Rows(0)
        tbFirstName.Text = data.Item(0)
        tbLastName.Text = data.Item(1)
        tbEmail.Text = data.Item(2)
        tbPhone1.Text = data.Item(3)
        tbPhone2.Text = data.Item(4)
        tbAuthorized.Text = data.Item(5)
        tbRentDate.Text = data.Item(6)
        tbReturnDate.Text = data.Item(7)
        tbDepositAmount.Text = data.Item(8)
        gridEquipments.DataSource = EntityEquipment.getInstance().getEquipmentsByRental(rental)
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        gridEquipments.Columns("code").HeaderText = json("EquipGridCode")
        gridEquipments.Columns("name").HeaderText = json("EquipGridName")
        gridEquipments.Columns("kit").HeaderText = json("EquipGridKit")
        gridEquipments.Columns("state").HeaderText = json("EquipGridState")
        gridEquipments.Columns("comments").HeaderText = json("EquipGridComments")
        gridEquipments.Columns("deposit").HeaderText = json("EquipGridDeposit")
        btReturn.Text = json("RentalDetailsbtReturn")
        labAuthorized.Text = json("RentalDetailsLabAuthorized")
        labRenterInfo.Text = json("RentalDetailsLabRenterInfo")
        labRentalInfo.Text = json("RentalDetailsLabRentalInfo")
        labName.Text = json("UserAddLabName")
        labEmail.Text = json("UserAddLabEmail")
        labPhone1.Text = json("UserAddLabPhone1")
        labPhone2.Text = json("UserAddLabPhone2")
        labRentDate.Text = json("RentalDetailsLabRentDate")
        labReturnDate.Text = json("RentalDetailsLabReturnDate")
        labDepositAmount.Text = json("RentalDetailsLabDepositAmount")
        labLateFee.Text = json("RentalDetailsLabLateFee")
        LabEquipmentList.Text = json("RentalDetailsLabEquipmentList")
    End Sub

    Private Sub resizeInterface()
        If mainForm.Height = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Height And
           mainForm.Width = Screen.FromControl(mainForm).GetWorkingArea(mainForm.Location).Width Then
            Dim increaseWidth = (Me.Width / mainForm.panelBaseWidth) + 0.4
            Dim increaseHeight = (Me.Height / mainForm.panelBaseHeight) + 0.4
            tbFirstName.Size = New Size(CInt(((baseLeftInputWidth * increaseWidth) / 2) - 3), 36)
            tbLastName.Location = New Point(tbLastName.Location.X +
                                            (CInt(((baseLeftInputWidth * increaseWidth) / 2) + 3) -
                                             (baseLeftInputWidth / 2) - 3),
                                            tbLastName.Location.Y)
            tbLastName.Size = New Size(CInt(((baseLeftInputWidth * increaseWidth) / 2) - 3), 36)
            tbEmail.Size = New Size(CInt(baseLeftInputWidth * increaseWidth), 36)
            tbPhone1.Size = New Size(CInt(baseLeftInputWidth * increaseWidth), 36)
            tbPhone2.Size = New Size(CInt(baseLeftInputWidth * increaseWidth), 36)
            panelLeft.Size = New Size(CInt(basePanelLeft.Width * increaseWidth) -
                                      (basePanelLeft.Width / 2),
                                      basePanelLeft.Height)
            tbAuthorized.Size = New Size(CInt(baseAuthorizedWidth * increaseWidth), 36)
            labAuthorized.Location = New Point(labAuthorized.Location.X +
                                               CInt(baseAuthorizedWidth * increaseWidth) - (baseAuthorizedWidth / 2),
                                               labAuthorized.Location.Y)
            tbAuthorized.Location = New Point(tbAuthorized.Location.X +
                                               CInt(baseAuthorizedWidth * increaseWidth) - (baseAuthorizedWidth / 2),
                                               tbAuthorized.Location.Y)
            tbRentDate.Size = New Size(CInt(baseRightInputWidth * increaseWidth), 36)
            tbReturnDate.Size = New Size(CInt(baseRightInputWidth * increaseWidth), 36)
            tbDepositAmount.Size = New Size(CInt(baseRightInputWidth * increaseWidth), 36)
            tbLateFee.Size = New Size(CInt(baseRightInputWidth * increaseWidth), 36)
        Else
            tbFirstName.Size = New Size((baseLeftInputWidth / 2) - 3, 36)
            tbLastName.Location = baseLocationLastName
            tbLastName.Size = New Size((baseLeftInputWidth / 2) - 3, 36)
            tbEmail.Size = New Size(baseLeftInputWidth, 36)
            tbPhone1.Size = New Size(baseLeftInputWidth, 36)
            tbPhone2.Size = New Size(baseLeftInputWidth, 36)
            panelLeft.Size = basePanelLeft
            tbAuthorized.Size = New Size(baseAuthorizedWidth, 36)
            labAuthorized.Location = baseLocationLabAuthorized
            tbAuthorized.Location = baseLocationTBAuthorized
            tbRentDate.Size = New Size(baseRightInputWidth, 36)
            tbReturnDate.Size = New Size(baseRightInputWidth, 36)
            tbDepositAmount.Size = New Size(baseRightInputWidth, 36)
            tbLateFee.Size = New Size(baseRightInputWidth, 36)
        End If
    End Sub

End Class
