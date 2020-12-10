Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class UCRent


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim code As String
    Dim datePick As Boolean = True
    Dim mainForm As New MainForm(code)
    Dim table As DataTable
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd()
        iUserAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers()
    Dim WithEvents mainForm As MainForm
    Dim table As DataTable

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm)
    Sub New(main As MainForm, matricule As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        code = matricule
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUsers.DataSource = EntityUser.getInstance.getUsers
        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
        gridSelectedEquipment.ColumnCount = 6
        gridSelectedEquipment.Columns(0).Name = "Code"
        gridSelectedEquipment.Columns(1).Name = "Nom"
        gridSelectedEquipment.Columns(2).Name = "kit"
        gridSelectedEquipment.Columns(3).Name = "État"
        gridSelectedEquipment.Columns(4).Name = "Commentaire"
        gridSelectedEquipment.Columns(5).Name = "Dépôt sugéré"
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd(mainForm, New UCUser(mainForm, code), code)
        iUserAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub tbSearchUser_TextChanged(sender As Object, e As EventArgs) Handles tbSearchUser.TextChanged
        If (Not String.IsNullOrEmpty(tbSearchUser.Text)) Then
            Dim recherche As String = tbSearchUser.Text
            Dim entityUser As EntityUser = EntityUser.getInstance()
            Select Case dropSearchUser.SelectedIndex
                Case 0
                    If (Regex.IsMatch(recherche, "^[0-9]*$")) Then
                        gridUsers.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
                    Else
                        gridUsers.DataSource = entityUser.getUsers()
                    End If
                Case 1
                    gridUsers.DataSource = entityUser.getUsersFirstName(recherche)
                Case 2
                    gridUsers.DataSource = entityUser.getUsersLastName(recherche)
                Case 3
                    gridUsers.DataSource = entityUser.getUsersEmail(recherche)
                Case 4
                    gridUsers.DataSource = entityUser.getUsersPhone(recherche)
                Case 5
                    gridUsers.DataSource = entityUser.getUsersJob(recherche)
            End Select
        End If
    End Sub
    Private Sub UCRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers
        gridItemAdd.ColumnCount = 6
        gridItemAdd.Columns(0).Name = "Code"
        gridItemAdd.Columns(1).Name = "Nom"
        gridItemAdd.Columns(2).Name = "kit"
        gridItemAdd.Columns(3).Name = "État"
        gridItemAdd.Columns(4).Name = "Commentaire"
        gridItemAdd.Columns(5).Name = "Dépôt sugéré"
    End Sub

    Private Sub tbItemSearch_TextChanged(sender As Object, e As EventArgs) Handles tbItemSearch.TextChanged
        searchEquipment()
    End Sub

    Private Sub gridItemSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItemSearch.CellDoubleClick
        If gridItemSearch.CurrentRow.Cells(4).Value = True Then
            gridItemAdd.Rows.Add(New String() {gridItemSearch.CurrentRow.Cells(0).Value,
                                 gridItemSearch.CurrentRow.Cells(1).Value,
                                 gridItemSearch.CurrentRow.Cells(2).Value,
                                 gridItemSearch.CurrentRow.Cells(3).Value,
                                 gridItemSearch.CurrentRow.Cells(5).Value,
                                 gridItemSearch.CurrentRow.Cells(6).Value})
            gridItemSearch.CurrentRow.Cells(4).Value = 0
            ModelEquipment.getInstance().AvailableEquipment(gridItemSearch.CurrentRow.Cells(0).Value, 0)
            searchEquipment()
        Else
            MsgBox(Lang.getInstance().getLang()("MsgEquimentAlreadyUse"), vbOKOnly, Lang.getInstance().getLang()("MsgWarning"))
        End If
        changeDeposit()
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItemAdd.CellDoubleClick
        ModelEquipment.getInstance().AvailableEquipment(gridItemAdd.CurrentRow.Cells(0).Value, 1)
        gridItemAdd.Rows.Remove(gridItemAdd.CurrentRow)
        changeDeposit()
        searchEquipment()
    End Sub

    Private Sub tbBeginDate_Click(sender As Object, e As EventArgs)
        datePick = True
    End Sub

    Private Sub tbEndDate_Click(sender As Object, e As EventArgs)
        datePick = False
    End Sub

    Private Sub calendarRent_DateChanged(sender As Object, e As DateRangeEventArgs)
        'If datePick Then
        '    tbBeginDate.Text = calendarRent.SelectionStart
        'Else
        '    tbEndDate.Text = calendarRent.SelectionStart
        'End If
        'If Not (String.IsNullOrEmpty(tbBeginDate.Text) Or String.IsNullOrEmpty(tbEndDate.Text)) Then
        '    table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
        'End If
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

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd(mainForm, New UCUser(mainForm))
        iUserAdd.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUsers.DataSource = EntityUser.getInstance.getUsers()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim complete As Boolean = True
        If gridItemAdd.Rows.Count < 1 Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgNoEquipementSelected"), vbOKOnly, Lang.getInstance().getLang()("MsgWarning"))
        End If
        If String.IsNullOrEmpty(Trim(numRealDeposit.Value)) And complete Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyDeposit"), vbOKOnly, Lang.getInstance().getLang()("MsgWarning"))
        Else
            If numRealDeposit.Text < 0 And complete Then
                complete = False
                MsgBox(Lang.getInstance().getLang()("MsgNegatifDeposit"), vbOKOnly, Lang.getInstance().getLang()("MsgWarning"))
            End If
        End If
        If complete Then
            If MsgBox(Lang.getInstance().getLang()("MsgAddRent"), vbYesNo) = vbYes Then
                For Each row As DataGridViewRow In gridItemAdd.Rows
                    ''Faire l'ajout dans la bd
                Next
            End If
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub changeDeposit()
        Dim deposit As Integer = 0
        For Each row As DataGridViewRow In gridSelectedEquipment.Rows
            deposit += row.Cells(5).Value
        Next
        tbSuggestedDeposit.Text = deposit
    End Sub

    Private Sub calendarRent_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarRent.DateChanged
        If datePick Then
            tbBeginDate.Text = calendarRent.SelectionStart
        Else
            tbEndDate.Text = calendarRent.SelectionStart
        End If

        If loadEquipment() Then
            table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
        End If
    End Sub

    Private Sub tbBeginDate_TextChanged(sender As Object, e As EventArgs) Handles tbBeginDate.TextChanged
        If loadEquipment() Then
            gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
            table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
        End If
        checkEquipmentAvailable()
        checkEquipmentSelected()
    End Sub

    Private Sub tbEndDate_TextChanged(sender As Object, e As EventArgs) Handles tbEndDate.TextChanged
        If loadEquipment() Then
            gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
            table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
        End If
        checkEquipmentAvailable()
        checkEquipmentSelected()
    End Sub
    Private Function loadEquipment() As Boolean
        If Not String.IsNullOrEmpty(tbBeginDate.Text) Then
            If Not String.IsNullOrEmpty(tbEndDate.Text) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub checkEquipmentSelected()
        Dim i As Integer = -1
        If Not IsNothing(table) Then
            For Each rowRent As DataRow In table.Rows
                For Each rowEquip As DataGridViewRow In gridItemAdd.Rows
                    i += 1
                    If rowRent.Item(3).ToString = rowEquip.Cells(0).Value Then
                        MsgBox(Lang.getInstance().getLang()("MsgEquipmentDateChange"), vbOKOnly, Lang.getInstance().getLang()("MsgWarning"))
                        ModelEquipment.getInstance().AvailableEquipment(gridItemAdd.Rows(i).Cells(0).Value, 1)
                        gridItemAdd.Rows.RemoveAt(i)
                        searchEquipment()
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub checkEquipmentAvailable()
        If loadEquipment() Then
            For Each rowRent As DataRow In table.Rows
                For Each rowEquip As DataGridViewRow In gridItemSearch.Rows
                    If rowRent.Item(3).ToString = rowEquip.Cells(0).Value Then
                        rowEquip.Cells(4).Value = 0
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub searchEquipment()
        If loadEquipment() Then
            Select Case dropSearchEquip.SelectedIndex
                Case 0
                    If IsNumeric(tbItemSearch.Text) Then
                        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentCodeSearch(tbItemSearch.Text, 1)
                    Else
                        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    End If
                Case 1
                    gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentName(tbItemSearch.Text, 1)
                Case 2
                    If IsNumeric(tbItemSearch.Text) Then
                        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentKit(tbItemSearch.Text, 1)
                    Else
                        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    End If
                Case 3
                    gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentState(tbItemSearch.Text, 1)
                Case 4
                    gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentComment(tbItemSearch.Text, 1)
                Case Else
                    gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
            End Select

            table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)

            checkEquipmentAvailable()
        End If
    End Sub

    Private Sub UCRent_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub
End Class
