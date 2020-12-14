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
    Dim code As Integer

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

        gridSelectedEquipment.ColumnCount = 7
        gridSelectedEquipment.Columns(0).Name = "Code"
        gridSelectedEquipment.Columns(0).ReadOnly = True
        gridSelectedEquipment.Columns(1).Name = "Nom"
        gridSelectedEquipment.Columns(1).ReadOnly = True
        gridSelectedEquipment.Columns(2).Name = "kit"
        gridSelectedEquipment.Columns(2).ReadOnly = True
        gridSelectedEquipment.Columns(3).Name = "État"
        gridSelectedEquipment.Columns(3).ReadOnly = True
        gridSelectedEquipment.Columns(4).Name = "Commentaire"
        gridSelectedEquipment.Columns(4).ReadOnly = False
        'Regarder pour voir si on change le commentaire pour un nouveau commentaire pour les prets
        gridSelectedEquipment.Columns(5).Name = "Dépôt sugéré"
        gridSelectedEquipment.Columns(5).ReadOnly = True
        gridSelectedEquipment.Columns(6).Name = "Dépôt réel"
        gridSelectedEquipment.Columns(6).ReadOnly = False
        tbCodeRenter.Text = Lang.getInstance().getLang()("TBCodeFill")
        tbNameRenter.Text = Lang.getInstance().getLang()("TBNameFill")
        tbEmailRenter.Text = Lang.getInstance().getLang()("TBEmailFill")
        tbPhoneRenter.Text = Lang.getInstance().getLang()("TBPhoneFill")
        tbBalanceRenter.Text = Lang.getInstance().getLang()("TBBalanceFill")
        checkShowAllEquipment.Text = Lang.getInstance().getLang()("CheckAllEquipmentShow")
        dateBegin = dateStart.Value
        dateFinish = dateEnd.Value
        code = mainForm.code
        searchEquipment()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

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
                                                         gridAllEquipment.CurrentRow.Cells(5).Value,
                                                         "$ 0,00"})
            gridAllEquipment.CurrentRow.Cells(4).Value = 0
            ModelEquipment.getInstance().setAvailable(gridAllEquipment.CurrentRow.Cells(0).Value, 0)
            searchEquipment()
            changeDeposit()
            changeDepositReel()
        Else
            MsgBox(Lang.getInstance().getLang()("MsgEquimentAlreadyUse"))
        End If
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSelectedEquipment.CellDoubleClick
        ModelEquipment.getInstance().setAvailable(gridSelectedEquipment.CurrentRow.Cells(0).Value, 1)
        gridSelectedEquipment.Rows.Remove(gridSelectedEquipment.CurrentRow)
        changeDeposit()
        changeDepositReel()
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
                changeDepositReel()
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
                changeDepositReel()
            End If
        End If
    End Sub

    Private Sub changeDeposit()
        Dim deposit As Double = 0
        For Each row As DataGridViewRow In gridSelectedEquipment.Rows
            deposit += row.Cells(5).Value
        Next
        tbSuggestedDeposit.Text = checkNumberMoney(deposit)
    End Sub

    Private Sub changeDepositReel()
        Dim deposit As Double = 0
        For Each row As DataGridViewRow In gridSelectedEquipment.Rows
            deposit += row.Cells(6).Value
        Next
        tbReelDeposit.Text = checkNumberMoney(deposit)
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

    Private Sub gridSelectedEquipment_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridSelectedEquipment.CellEndEdit
        Dim str As String
        Dim strBegin As String
        Dim strEnd As String

        If Regex.IsMatch(gridSelectedEquipment.CurrentCell.Value, "^([0-9]{0,4})([.,][0-9]{0,2})*$") Then
            Try
                gridSelectedEquipment.CurrentCell.Value = checkNumberMoney(Replace(gridSelectedEquipment.CurrentCell.Value, ".", ","))
                changeDepositReel()
            Catch
                gridSelectedEquipment.CurrentCell.Value = checkNumberMoney(Replace(gridSelectedEquipment.CurrentCell.Value, ",", "."))
                changeDepositReel()
            End Try
        Else
            gridSelectedEquipment.CurrentCell.Value = "$ 0,00"
            changeDepositReel()
        End If
    End Sub

    Private Function checkNumberMoney(deposit As Double) As String
        Dim str As String
        Dim strBegin As String
        Dim strEnd As String

        Try
            str = Replace(deposit, ".", ",")
            If Not str.IndexOf(",") = -1 Then
                strBegin = str.Substring(0, str.IndexOf(","))
                strEnd = str.Substring(str.IndexOf(",") + 1, str.Length - strBegin.Length - 1)
                If strBegin = "" Then
                    strBegin = "0"
                End If
                While Not strEnd.Length = 2
                    strEnd = strEnd + "0"
                End While
                str = "$ " + strBegin + "," + strEnd
                Return str
            Else
                str = "$ " + str + ",00"
                Return str
            End If
        Catch
            str = Replace(gridSelectedEquipment.CurrentCell.Value, ",", ".")
            If Not str.IndexOf(".") = -1 Then
                strBegin = str.Substring(0, str.IndexOf("."))
                strEnd = str.Substring(str.IndexOf(".") + 1, str.Length - strBegin.Length - 1)
                If strBegin = "" Then
                    strBegin = "0"
                End If
                While Not strEnd.Length = 2
                    strEnd = strEnd + "0"
                End While
                str = "$" + strBegin + "." + strEnd
                Return str
            Else
                str = "$ " + str + ".00"
                Return str
            End If
        End Try
    End Function

    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim user = New ChooseUser(mainForm, Me)
        user.ShowDialog()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim complete As Boolean = True
        If gridSelectedEquipment.Rows.Count < 1 Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgNoEquipSelected"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If
        If tbCodeRenter.Text = "Matricule" Or tbCodeRenter.Text = "Matricula" And complete Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgNoUserSelected"),
                   vbOKOnly,
                    Lang.getInstance.getLang()("MsgWarning"))
        End If
        If complete Then
            If MsgBox(Lang.getInstance().getLang()("MsgAddRent"), vbYesNo) = vbYes Then
                For Each row As DataGridViewRow In gridSelectedEquipment.Rows
                    ModelRent.getInstance().addRent(tbCodeRenter.Text,
                                                    code,
                                                    row.Cells(0).Value,
                                                    dateStart.Value,
                                                    dateEnd.Value,
                                                    row.Cells(6).Value,
                                                    row.Cells(4).Value)
                Next
                For Each row As DataGridViewRow In gridSelectedEquipment.Rows
                    ModelEquipment.getInstance().setAvailable(row.Cells(0).Value, 1)
                Next
                For i As Integer = gridSelectedEquipment.Rows.Count - 1 To 0 Step -1
                    gridSelectedEquipment.Rows.RemoveAt(i)
                Next
            End If
        End If
    End Sub

    Private Sub btViewRentals_Click(sender As Object, e As EventArgs) Handles btViewRentals.Click

    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________






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
            ModelEquipment.getInstance().setAvailable(row.Cells(0).Value, 1)
        Next
    End Sub

    Private Sub checkShowAllEquipment_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAllEquipment.CheckedChanged
        searchEquipment()
    End Sub

End Class
