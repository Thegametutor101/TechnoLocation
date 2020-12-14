Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class UCRent


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim datePick As Boolean = True
    Dim table As DataTable
    Dim WithEvents mainForm As New MainForm(0)
    Dim showAllEquipment As Integer = 1
    Dim dateBegin As Date
    Dim dateFinish As Date

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

        gridSelectedEquipment.ColumnCount = 6
        gridSelectedEquipment.Columns(0).Name = "Code"
        gridSelectedEquipment.Columns(1).Name = "Nom"
        gridSelectedEquipment.Columns(2).Name = "kit"
        gridSelectedEquipment.Columns(3).Name = "État"
        gridSelectedEquipment.Columns(4).Name = "Commentaire"
        gridSelectedEquipment.Columns(5).Name = "Dépôt sugéré"
        tbCodeRenter.Text = Lang.getInstance().getLang()("TBCodeFill")
        tbNameRenter.Text = Lang.getInstance().getLang()("TBNameFill")
        tbEmailRenter.Text = Lang.getInstance().getLang()("TBEmailFill")
        tbPhoneRenter.Text = Lang.getInstance().getLang()("TBPhoneFill")
        tbBalanceRenter.Text = Lang.getInstance().getLang()("TBBalanceFill")
        checkShowAllEquipment.Text = Lang.getInstance().getLang()("CheckAllEquipmentShow")
        dateBegin = dateStart.Value
        DateFinish = dateEnd.Value
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    'Private Sub tbSearchUser_TextChanged(sender As Object, e As EventArgs)
    '    If (Not String.IsNullOrEmpty(tbSearchUser.Text)) Then
    '        Dim recherche As String = tbSearchUser.Text
    '        Dim entityUser As EntityUser = EntityUser.getInstance()
    '        Select Case dropSearchUser.SelectedIndex
    '            Case 0
    '                If (Regex.IsMatch(recherche, "^[0-9]*$")) Then
    '                    gridUsers.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
    '                Else
    '                    gridUsers.DataSource = entityUser.getUsers()
    '                End If
    '            Case 1
    '                gridUsers.DataSource = entityUser.getUsersFirstName(recherche)
    '            Case 2
    '                gridUsers.DataSource = entityUser.getUsersLastName(recherche)
    '            Case 3
    '                gridUsers.DataSource = entityUser.getUsersEmail(recherche)
    '            Case 4
    '                gridUsers.DataSource = entityUser.getUsersPhone(recherche)
    '            Case 5
    '                gridUsers.DataSource = entityUser.getUsersJob(recherche)
    '        End Select
    '    End If
    'End Sub

    Private Sub tbSearchEquipment_TextChanged(sender As Object, e As EventArgs) Handles tbSearchEquipment.TextChanged
        searchEquipment()
    End Sub

    Private Sub gridItemSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAllEquipment.CellDoubleClick
        If EntityEquipment.getInstance.getAvailability(gridAllEquipment.CurrentRow.Cells(0).Value) Then
            gridSelectedEquipment.Rows.Add(New String() {gridAllEquipment.CurrentRow.Cells(0).Value,
                                                         gridAllEquipment.CurrentRow.Cells(1).Value,
                                                         gridAllEquipment.CurrentRow.Cells(2).Value,
                                                         gridAllEquipment.CurrentRow.Cells(3).Value,
                                                         gridAllEquipment.CurrentRow.Cells(4).Value,
                                                         gridAllEquipment.CurrentRow.Cells(5).Value})
            gridAllEquipment.CurrentRow.Cells(4).Value = 0
            ModelEquipment.getInstance().setAvailable(gridAllEquipment.CurrentRow.Cells(0).Value, 0)
            searchEquipment()
            changeDeposit()
        Else
            MsgBox(Lang.getInstance().getLang()("MsgEquimentAlreadyUse"))
        End If
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSelectedEquipment.CellDoubleClick
        ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.CurrentRow.Cells(0).Value, 1)
        gridSelectedEquipment.Rows.Remove(gridSelectedEquipment.CurrentRow)
        changeDeposit()
        searchEquipment()
    End Sub

    Private Sub dateStart_ValueChanged(sender As Object, e As EventArgs) Handles dateStart.ValueChanged
        If Not dateBegin = "0001-01-01" Then
            If dateStart.Value > dateEnd.Value Then
                dateStart.Value = dateBegin
            Else
                dateBegin = dateStart.Value
                searchEquipment()
                checkEquipmentSelected()
                changeDeposit()
            End If
        End If

    End Sub

    Private Sub loadDataGridView()
        gridAllEquipment.DataSource = EntityEquipment.getInstance.getEquipmentsBySearchRent("", True, dateStart.Value, dateEnd.Value)
    End Sub

    Private Sub dateEnd_ValueChanged(sender As Object, e As EventArgs) Handles dateEnd.ValueChanged
        If Not dateFinish = "0001-01-01" Then
            If dateEnd.Value < dateStart.Value Then
                dateEnd.Value = dateFinish
            Else
                dateFinish = dateEnd.Value
                searchEquipment()
                checkEquipmentSelected()
                changeDeposit()
            End If
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Sub checkEquipmentSelected() 'Il faut que je change sa vu qu'on a enlever le check available
        Dim i As Integer
        Dim getMsg As Boolean = False
        If Not IsNothing(table) Then
            For Each rowRent As DataRow In table.Rows
                i = -1
                For Each rowEquip As DataGridViewRow In gridSelectedEquipment.Rows
                    i += 1
                    If rowRent.Item(0).ToString = rowEquip.Cells(0).Value Then
                        getMsg = True
                        ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.Rows(i).Cells(0).Value, 1)
                        gridSelectedEquipment.Rows.RemoveAt(i)
                        searchEquipment()
                    End If
                Next
            Next
            If getMsg Then
                MsgBox(Lang.getInstance().getLang()("MsgEquipmentDateChange"),
                               vbOKOnly,
                               Lang.getInstance().getLang()("MsgWarning"))
            End If
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        'Faire l'ouverture d'un nouveau form pour la recherche de user
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




    Private Sub searchEquipment()
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearchEquipment.BorderColor = grey
        tbSearchEquipment.FocusedState.BorderColor = blue
        tbSearchEquipment.Text = tbSearchEquipment.Text.Trim()
        If tbSearchEquipment.Text.Length > 0 Then
            If checkShowAllEquipment.Checked Then
                gridAllEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearchRent(tbSearchEquipment.Text,
                                                                                           False,
                                                                                           dateStart.Value,
                                                                                           dateEnd.Value)
            Else
                gridAllEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearchRent(tbSearchEquipment.Text,
                                                                                           True,
                                                                                           dateStart.Value,
                                                                                           dateEnd.Value)
            End If
            If gridAllEquipment.Rows.Count = 0 Then
                tbSearchEquipment.BorderColor = red
                tbSearchEquipment.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            If checkShowAllEquipment.Checked Then
                gridAllEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearchRent(tbSearchEquipment.Text,
                                                                                           False,
                                                                                           dateStart.Value,
                                                                                           dateEnd.Value)
            Else
                gridAllEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearchRent(tbSearchEquipment.Text,
                                                                                           True,
                                                                                           dateStart.Value,
                                                                                           dateEnd.Value)
            End If
        End If

        table = EntityRent.getInstance.getRentBetweenDate(dateStart.Value.ToString, dateEnd.Value.ToString)

    End Sub

    Private Sub gridAllEquipment_DragDrop(sender As Object, e As DragEventArgs) Handles gridAllEquipment.DragDrop

    End Sub

    Private Sub UCRent_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged, Me.HandleDestroyed
        For Each row As DataGridViewRow In gridSelectedEquipment.Rows
            ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.CurrentRow.Cells(0).Value, 1)
            gridSelectedEquipment.Rows.Remove(gridSelectedEquipment.CurrentRow)
        Next
    End Sub

    Private Sub checkShowAllEquipment_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAllEquipment.CheckedChanged
        searchEquipment()
    End Sub

End Class
