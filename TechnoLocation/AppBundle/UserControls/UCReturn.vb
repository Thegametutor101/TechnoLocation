Imports System.Text.RegularExpressions

Public Class UCReturn

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)

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
        tbSearch.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged
        If checkAll.Checked Then
            gridReturn.DataSource = EntityRent.getInstance().getLateRentals()
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
            gridReturn.DataSource = EntityRent.getInstance().getRentalsBySearch(tbSearch.Text)
            If gridReturn.Rows.Count = 0 Then
                tbSearch.BorderColor = red
                tbSearch.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            loadDataGridView()
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



    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadDataGridView()
        gridReturn.DataSource = EntityRent.getInstance().getRentals()
    End Sub

End Class
