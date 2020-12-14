Public Class UCRentalDetails

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim rental As Integer

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
        loadData()
        loadLanguages()
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

End Class
