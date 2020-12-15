Imports System.Text.RegularExpressions

Public Class UCUser


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim mainForm As New MainForm(0)
    Dim codesBarres As New BarCodes

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(main As MainForm)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguages()
        tbUserSearch.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged
        userSearch()
    End Sub

    Private Sub tbUserSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbUserSearch.KeyUp
        If e.KeyCode = Keys.V Then
            tbUserSearch.Text = codesBarres.isBarcodeUser(tbUserSearch.Text)
        End If
    End Sub

    Private Sub checkUser_CheckedChanged(sender As Object, e As EventArgs) Handles checkUser.CheckedChanged
        If checkUser.Checked Then
            gridUser.SelectAll()
        Else
            gridUser.ClearSelection()
            gridUser.Rows(0).Selected = True
        End If
    End Sub

    Private Sub gridUser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUser.CellDoubleClick
        Dim code As Integer = gridUser.Rows(e.RowIndex).Cells(0).Value
        Dim iUserModify As New UCUserModify(code, mainForm, Me)
        iUserModify.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iUserModify)
        iUserModify.BringToFront()
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________

    Private Function userSearch()
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbUserSearch.BorderColor = grey
        tbUserSearch.FocusedState.BorderColor = blue
        tbUserSearch.Text = tbUserSearch.Text.Trim()
        If tbUserSearch.Text.Length > 0 Then
            gridUser.DataSource = EntityUser.getInstance().getUsersBySearch(mainForm.labLang.Text, tbUserSearch.Text)
            If gridUser.Rows.Count = 0 Then
                tbUserSearch.BorderColor = red
                tbUserSearch.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            loadDataGridView()
        End If
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btDeleteUser_Click(sender As Object, e As EventArgs) Handles btDeleteUser.Click
        For Each row As DataGridViewRow In gridUser.SelectedRows
            ModelUser.getInstance().delUser(row.Cells(0).Value)
        Next
        gridUser.DataSource = EntityUser.getInstance.getUsers(mainForm.labLang.Text)
        userSearch()
    End Sub

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd(mainForm, Me)
        iUserAdd.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUser.DataSource = EntityUser.getInstance.getUsers(mainForm.labLang.Text)
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridUser.DataSource = EntityUser.getInstance.getUsers(mainForm.labLang.Text)
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btAddUser.Text = json("NewItem")
        btDeleteUser.Text = json("DeleteItem")
        tbUserSearch.PlaceholderText = json("SearchPlaceholder")
        gridUser.Columns("code").HeaderText = json("UserGridCode")
        gridUser.Columns("firstName").HeaderText = json("UserGridFirstName")
        gridUser.Columns("lastName").HeaderText = json("UserGridLastName")
        gridUser.Columns("email").HeaderText = json("UserGridEmail")
        gridUser.Columns("phoneMain").HeaderText = json("UserGridPhoneMain")
        gridUser.Columns("phone2").HeaderText = json("UserGridPhone2")
        gridUser.Columns("job").HeaderText = json("UserGridJob")
        gridUser.Columns("balance").HeaderText = json("UserGridBalance")
        gridUser.Columns("code").Width = 70
        gridUser.Columns("job").Width = 70
        gridUser.Columns("balance").Width = 80
    End Sub

End Class
