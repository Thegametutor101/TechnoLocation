Imports System.Text.RegularExpressions

Public Class UCUser


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim mainForm As New MainForm(0)

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
        dropUserSearch.SelectedIndex = 0
        tbUserSearch.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged
        userSearch()
    End Sub
    Private Sub dropUserSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropUserSearch.SelectedIndexChanged
        userSearch()
    End Sub

    Private Sub checkUser_CheckedChanged(sender As Object, e As EventArgs) Handles checkUser.CheckedChanged
        If checkUser.Checked Then
            gridUser.SelectAll()
        Else
            gridUser.ClearSelection()
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
        If (Not String.IsNullOrEmpty(tbUserSearch.Text)) Then
            Dim recherche As String = tbUserSearch.Text
            Dim entityUser As EntityUser = EntityUser.getInstance()
            Select Case dropUserSearch.SelectedIndex
                Case 0
                    If (Regex.IsMatch(recherche, "^[0-9]*$")) Then
                        gridUser.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
                    Else
                        gridUser.DataSource = entityUser.getUsers()
                    End If
                Case 1
                    gridUser.DataSource = entityUser.getUsersFirstName(recherche)
                Case 2
                    gridUser.DataSource = entityUser.getUsersLastName(recherche)
                Case 3
                    gridUser.DataSource = entityUser.getUsersEmail(recherche)
                Case 4
                    gridUser.DataSource = entityUser.getUsersPhone(recherche)
                Case 5
                    gridUser.DataSource = entityUser.getUsersJob(recherche)
            End Select
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
        gridUser.DataSource = EntityUser.getInstance.getUsers()
        userSearch()
    End Sub

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd(mainForm, Me)
        iUserAdd.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUser.DataSource = EntityUser.getInstance.getUsers()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        Dim json = Lang.getInstance().getLang()
        gridUser.DataSource = EntityUser.getInstance.getUsers()
        gridUser.Columns("code").HeaderText = json("UserGridCode")
        gridUser.Columns("firstName").HeaderText = json("UserGridFirstName")
        gridUser.Columns("lastName").HeaderText = json("UserGridLastName")
        gridUser.Columns("email").HeaderText = json("UserGridEmail")
        gridUser.Columns("phoneMain").HeaderText = json("UserGridPhoneMain")
        gridUser.Columns("phone2").HeaderText = json("UserGridPhone2")
        gridUser.Columns("job").HeaderText = json("UserGridJob")
        gridUser.Columns("balance").HeaderText = json("UserGridBalance")
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btAddUser.Text = json("NewItem")
        btDeleteUser.Text = json("DeleteItem")
        tbUserSearch.PlaceholderText = json("SearchPlaceholder")
        dropUserSearch.Items.Add(json("DropMatricule"))
        dropUserSearch.Items.Add(json("DropFirstName"))
        dropUserSearch.Items.Add(json("DropLastName"))
        dropUserSearch.Items.Add(json("DropEmail"))
        dropUserSearch.Items.Add(json("DropPhone"))
        dropUserSearch.Items.Add(json("DropJob"))
    End Sub

End Class
