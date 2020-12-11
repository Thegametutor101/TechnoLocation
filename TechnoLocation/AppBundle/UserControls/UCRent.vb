Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class UCRent


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim datePick As Boolean = True
    Dim table As DataTable
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

    Private Sub tbSearchEquipment_TextChanged(sender As Object, e As EventArgs) Handles tbSearchEquipment.TextChanged
        searchEquipment()
    End Sub

    Private Sub gridItemSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAllEquipment.CellDoubleClick
        If gridAllEquipment.CurrentRow.Cells(4).Value = True Then
            gridSelectedEquipment.Rows.Add(New String() {gridAllEquipment.CurrentRow.Cells(0).Value,
                                                         gridAllEquipment.CurrentRow.Cells(1).Value,
                                                         gridAllEquipment.CurrentRow.Cells(2).Value,
                                                         gridAllEquipment.CurrentRow.Cells(3).Value,
                                                         gridAllEquipment.CurrentRow.Cells(5).Value,
                                                         gridAllEquipment.CurrentRow.Cells(6).Value})
            '==================================================
            gridSelectedEquipment.Rows.Add(gridAllEquipment.CurrentRow)
            gridAllEquipment.CurrentRow.Cells(4).Value = 0
            ModelEquipment.getInstance().setAvailable(gridAllEquipment.CurrentRow.Cells(0).Value, 0)
            searchEquipment()
        Else
            MsgBox(Lang.getInstance().getLang()("MsgEquimentAlreadyUse"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If
        changeDeposit()
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSelectedEquipment.CellDoubleClick
        ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.CurrentRow.Cells(0).Value, 1)
        gridSelectedEquipment.Rows.Remove(gridSelectedEquipment.CurrentRow)
        changeDeposit()
        searchEquipment()
    End Sub
    'TODO
    'Private Sub tbBeginDate_TextChanged(sender As Object, e As EventArgs) Handles tbBeginDate.TextChanged
    '    If loadEquipment() Then
    '        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
    '        table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
    '    End If
    '    checkEquipmentAvailable()
    '    checkEquipmentSelected()
    'End Sub
    'TODO
    'Private Sub tbEndDate_TextChanged(sender As Object, e As EventArgs) Handles tbEndDate.TextChanged
    '    If loadEquipment() Then
    '        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
    '        table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
    '    End If
    '    checkEquipmentAvailable()
    '    checkEquipmentSelected()
    'End Sub
    'TODO
    'Private Sub calendarRent_DateChanged(sender As Object, e As DateRangeEventArgs)
    '    If datePick Then
    '        tbBeginDate.Text = calendarRent.SelectionStart
    '    Else
    '        tbEndDate.Text = calendarRent.SelectionStart
    '    End If
    '    If Not (String.IsNullOrEmpty(tbBeginDate.Text) Or String.IsNullOrEmpty(tbEndDate.Text)) Then
    '        table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)
    '    End If
    'End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    Private Sub checkEquipmentAvailable()
        If loadEquipment() Then
            For Each rowRent As DataRow In table.Rows
                For Each rowEquip As DataGridViewRow In gridAllEquipment.Rows
                    If rowRent.Item(3).ToString = rowEquip.Cells(0).Value Then
                        rowEquip.Cells(4).Value = 0
                    End If
                Next
            Next
        End If
    End Sub

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
        If gridSelectedEquipment.Rows.Count < 1 Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgNoEquipementSelected"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If
        If complete Then
            If MsgBox(Lang.getInstance().getLang()("MsgAddRent"), vbYesNo) = vbYes Then
                For Each row As DataGridViewRow In gridSelectedEquipment.Rows
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

    Private Function loadEquipment() As Boolean
        'If Not String.IsNullOrEmpty(tbBeginDate.Text) Then
        '    If Not String.IsNullOrEmpty(tbEndDate.Text) Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Else
        '    Return False
        'End If
    End Function

    Private Sub checkEquipmentSelected()
        Dim i As Integer = -1
        If Not IsNothing(table) Then
            For Each rowRent As DataRow In table.Rows
                For Each rowEquip As DataGridViewRow In gridSelectedEquipment.Rows
                    i += 1
                    If rowRent.Item(3).ToString = rowEquip.Cells(0).Value Then
                        MsgBox(Lang.getInstance().getLang()("MsgEquipmentDateChange"),
                               vbOKOnly,
                               Lang.getInstance().getLang()("MsgWarning"))
                        ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.Rows(i).Cells(0).Value, 1)
                        gridSelectedEquipment.Rows.RemoveAt(i)
                        searchEquipment()
                    End If
                Next
            Next
        End If
    End Sub


    Private Sub searchEquipment()
        If loadEquipment() Then
            Select Case dropSearchEquipment.SelectedIndex
                Case 0
                    If IsNumeric(tbSearchEquipment.Text) Then
                        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentCodeSearch(tbSearchEquipment.Text, 1)
                    Else
                        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    End If
                Case 1
                    gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentName(tbSearchEquipment.Text, 1)
                Case 2
                    If IsNumeric(tbSearchEquipment.Text) Then
                        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentKit(tbSearchEquipment.Text, 1)
                    Else
                        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    End If
                Case 3
                    gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentState(tbSearchEquipment.Text, 1)
                Case 4
                    gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentComment(tbSearchEquipment.Text, 1)
                Case Else
                    gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
            End Select

            'table = EntityRent.getInstance.getRentBetweenDate(tbBeginDate.Text, tbEndDate.Text)

            checkEquipmentAvailable()
        End If
    End Sub

End Class
