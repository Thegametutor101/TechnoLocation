Imports System.Text.RegularExpressions

Public Class UCReturn

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim codesBarres As New BarCodes

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguages()
        tbSearch.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged
        If checkAll.Checked Then
            gridReturn.SelectAll()
        Else
            gridReturn.ClearSelection()
            gridReturn.Rows(0).Selected = True
        End If
    End Sub

    Private Sub checkLate_CheckedChanged(sender As Object, e As EventArgs) Handles checkLate.CheckedChanged
        If checkLate.Checked Then
            gridReturn.DataSource = EntityRent.getInstance().getLateRentals(mainForm.labLang.Text)
        Else
            loadDataGridView()
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearch.BorderColor = grey
        tbSearch.FocusedState.BorderColor = blue
        tbSearch.Text = tbSearch.Text.Trim()
        If tbSearch.Text.Length > 0 Then
            gridReturn.DataSource = EntityRent.getInstance().getRentalsBySearch(mainForm.labLang.Text, tbSearch.Text)
            If gridReturn.Rows.Count = 0 Then
                tbSearch.BorderColor = red
                tbSearch.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            loadDataGridView()
        End If
    End Sub

    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        If e.KeyCode = Keys.V Then
            If tbSearch.Text.Length = 8 Then
                tbSearch.Text = codesBarres.isBarcodeEquip(tbSearch.Text)
            Else
                tbSearch.Text = codesBarres.isBarcodeUser(tbSearch.Text)
            End If
        End If
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

    Private Sub gridReturn_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridReturn.CellMouseDoubleClick
        Dim rental = gridReturn.SelectedRows.Item(0).Cells(0).Value
        Dim rentalDetails = New UCRentalDetails(mainForm, rental)
        rentalDetails.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(rentalDetails)
        rentalDetails.BringToFront()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadDataGridView()
        gridReturn.DataSource = EntityRent.getInstance().getRentals(mainForm.labLang.Text)
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        gridReturn.Columns("code").HeaderText = json("ReturnGridCode")
        gridReturn.Columns("renterName").HeaderText = json("ReturnGridRenter")
        gridReturn.Columns("lenderName").HeaderText = json("ReturnGridLender")
        gridReturn.Columns("equipmentAmount").HeaderText = json("ReturnGridEquipments")
        gridReturn.Columns("rentDate").HeaderText = json("ReturnGridRentDate")
        gridReturn.Columns("returnDate").HeaderText = json("ReturnGridReturnDate")
        gridReturn.Columns("depositAmount").HeaderText = json("ReturnGridDeposit")
        gridReturn.Columns("code").Width = 80
        gridReturn.Columns("depositAmount").Width = 90
        gridReturn.Columns("equipmentAmount").Width = 100
        tbSearch.PlaceholderText = json("SearchPlaceholder")
        labLate.Text = json("ReturnLabLate")
        btReturnAll.Text = json("ReturnbtReturnAll")
    End Sub


End Class
