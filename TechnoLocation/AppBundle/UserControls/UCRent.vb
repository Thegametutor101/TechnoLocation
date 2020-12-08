Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class UCRent

    Dim datePick As Boolean = True
    Dim mainForm As New MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub
    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim iUserAdd As New UCUserAdd(mainForm, New UCUser(mainForm))
        iUserAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iUserAdd)
        iUserAdd.BringToFront()
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers()
    End Sub

    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged
        If (Not String.IsNullOrEmpty(tbUserSearch.Text)) Then
            Dim recherche As String = tbUserSearch.Text
            Dim entityUser As EntityUser = EntityUser.getInstance()
            Select Case dropSearchUser.SelectedIndex
                Case 0
                    If (Regex.IsMatch(recherche, "^[0-9]*$")) Then
                        gridUserSearch.DataSource = entityUser.getUsersCode(Convert.ToInt32(recherche))
                    Else
                        gridUserSearch.DataSource = entityUser.getUsers()
                    End If
                Case 1
                    gridUserSearch.DataSource = entityUser.getUsersFirstName(recherche)
                Case 2
                    gridUserSearch.DataSource = entityUser.getUsersLastName(recherche)
                Case 3
                    gridUserSearch.DataSource = entityUser.getUsersEmail(recherche)
                Case 4
                    gridUserSearch.DataSource = entityUser.getUsersPhone(recherche)
                Case 5
                    gridUserSearch.DataSource = entityUser.getUsersJob(recherche)
            End Select
        End If
    End Sub
    Private Sub UCRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers
        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
        gridItemAdd.ColumnCount = 6
        gridItemAdd.Columns(0).Name = "Code"
        gridItemAdd.Columns(1).Name = "Nom"
        gridItemAdd.Columns(2).Name = "kit"
        gridItemAdd.Columns(3).Name = "État"
        gridItemAdd.Columns(4).Name = "Commentaire"
        gridItemAdd.Columns(5).Name = "Dépôt sugéré"
    End Sub

    Private Sub tbItemSearch_TextChanged(sender As Object, e As EventArgs) Handles tbItemSearch.TextChanged
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
        End Select
    End Sub

    Private Sub gridItemSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItemSearch.CellDoubleClick
        If gridItemSearch.CurrentRow.Cells(4).Value = True Then
            gridItemAdd.Rows.Add(New String() {gridItemSearch.CurrentRow.Cells(0).Value, gridItemSearch.CurrentRow.Cells(1).Value, gridItemSearch.CurrentRow.Cells(2).Value, gridItemSearch.CurrentRow.Cells(3).Value, gridItemSearch.CurrentRow.Cells(5).Value, gridItemSearch.CurrentRow.Cells(6).Value})
            gridItemSearch.CurrentRow.Cells(4).Value = 0
        End If
        changeDeposit()
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItemAdd.CellDoubleClick
        For Each row As DataGridViewRow In gridItemSearch.Rows
            If row.Cells(0).Value = gridItemAdd.CurrentRow.Cells(0).Value Then
                row.Cells(4).Value = 1
            End If
        Next
        gridItemAdd.Rows.Remove(gridItemAdd.CurrentRow)
        changeDeposit()
    End Sub

    Private Sub changeDeposit()
        Dim deposit As Integer = 0
        For Each row As DataGridViewRow In gridItemAdd.Rows
            deposit += row.Cells(5).Value
        Next
        tbSuggDeposit.Text = deposit
    End Sub

    Private Sub btSavNewRent_Click(sender As Object, e As EventArgs) Handles btSavNewRent.Click
        Dim complete As Boolean = True
        If gridItemAdd.Rows.Count < 0 Then
            complete = False
            'MsgBox(json("MsgNoEquipementSelected"), vbOKOnly, json("MsgWarning"))
        End If
        If String.IsNullOrEmpty(Trim(tbRealDeposit.Text)) Or Not IsNumeric(tbRealDeposit) And complete Then
            complete = False
            'MsgBox(json("MsgEmptyDeposit"), vbOKOnly, json("MsgWarning"))
        Else
            If tbRealDeposit.Text < 0 And complete Then
                complete = False
                'MsgBox(json("MsgNegatifDeposit"), vbOKOnly, json("MsgWarning"))
            End If
        End If
        If complete Then
            'If MsgBox(json("MsgAddRent"), vbYesNo) = vbYes Then
            '    For Each row As DataGridViewRow In gridItemAdd.Rows
            '        ''Faire l'ajout dans la bd
            '    Next
            'End If
        End If
    End Sub

    Private Sub tbBeginDate_Click(sender As Object, e As EventArgs) Handles tbBeginDate.Click
        datePick = True
    End Sub

    Private Sub tbEndDate_Click(sender As Object, e As EventArgs) Handles tbEndDate.Click
        datePick = False
    End Sub

    Private Sub calendarRent_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarRent.DateChanged
        If datePick Then
            tbBeginDate.Text = calendarRent.SelectionStart
        Else
            tbEndDate.Text = calendarRent.SelectionStart
        End If
    End Sub

    Private Sub dropSearchUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearchUser.SelectedIndexChanged

    End Sub
End Class
