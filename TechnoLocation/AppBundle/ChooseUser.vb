Public Class ChooseUser
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainform As New MainForm(0)
    Dim ucRent As UCRent
    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, rent As UCRent)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainform = main
        ucRent = rent
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub ChooseUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUserSearch.DataSource = EntityUser.getInstance.getUsersBySearch(mainform.labLang.Text, "")
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub tbSearchUser_TextChanged(sender As Object, e As EventArgs) Handles tbSearchUser.TextChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearchUser.BorderColor = grey
        tbSearchUser.FocusedState.BorderColor = blue
        tbSearchUser.Text = tbSearchUser.Text.Trim()
        If tbSearchUser.Text.Length > 0 Then
            gridUserSearch.DataSource = EntityUser.getInstance.getUsersBySearch(mainform.labLang.Text, tbSearchUser.Text)
            If gridUserSearch.Rows.Count = 0 Then
                tbSearchUser.BorderColor = red
                tbSearchUser.FocusedState.BorderColor = red
                gridUserSearch.DataSource = EntityUser.getInstance.getUsersBySearch(mainform.labLang.Text, "")
            End If
        Else
            gridUserSearch.DataSource = EntityUser.getInstance.getUsersBySearch(mainform.labLang.Text, tbSearchUser.Text)
        End If

        EntityUser.getInstance.getUsersBySearch(mainform.labLang.Text, tbSearchUser.Text)
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

    Private Sub gridUserSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUserSearch.CellDoubleClick
        ucRent.tbCodeRenter.Text = gridUserSearch.CurrentRow.Cells(0).Value
        ucRent.tbNameRenter.Text = String.Concat(gridUserSearch.CurrentRow.Cells(1).Value, " ", gridUserSearch.CurrentRow.Cells(2).Value)
        ucRent.tbEmailRenter.Text = gridUserSearch.CurrentRow.Cells(3).Value
        ucRent.tbPhoneRenter.Text = gridUserSearch.CurrentRow.Cells(4).Value
        ucRent.tbBalanceRenter.Text = gridUserSearch.CurrentRow.Cells(7).Value
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


End Class