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

    Private Sub UCRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLanguages()
        dateStart.Value = Date.Now
        dateEnd.Value = Date.Now.AddDays(1)
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
    Private Sub checkEquipmentSelected()
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
        If Regex.IsMatch(gridSelectedEquipment.CurrentCell.Value, "^([\d])+(\.[\d]{1,2}|\,[\d]{1,2})*$") Then
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
                Dim lastId As Integer = EntityRent.getInstance.getLastIDRent()
                lastId += 1
                For Each row As DataGridViewRow In gridSelectedEquipment.Rows
                    ModelRent.getInstance().addRent(lastId,
                                                    tbCodeRenter.Text,
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
                MsgBox(Lang.getInstance().getLang()("MsgRentAddSucces"), vbOKOnly)
            End If
        End If
    End Sub

    Private Sub btViewRentals_Click(sender As Object, e As EventArgs) Handles btViewRentals.Click
        Dim iRentList As New UCRentList(mainForm)
        iRentList.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iRentList)
        iRentList.BringToFront()
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
            If checkShowAllEquipments.Checked Then
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
            If checkShowAllEquipments.Checked Then
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

    Private Sub UCRent_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged, Me.HandleDestroyed
        For Each row As DataGridViewRow In gridSelectedEquipment.Rows
            ModelEquipment.getInstance().setAvailable(row.Cells(0).Value, 1)
        Next
    End Sub

    Private Sub checkShowAllEquipments_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowAllEquipments.CheckedChanged
        searchEquipment()
    End Sub

    Private Sub tbCodeRenter_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles tbCodeRenter.KeyUp
        If e.KeyCode = Keys.V Then
            tbCodeRenter.Text = codesBarres.isBarcodeUser(tbCodeRenter.Text)
        End If
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        gridSelectedEquipment.ColumnCount = 7
        gridSelectedEquipment.Columns(0).HeaderText = json("EquipGridCode")
        gridSelectedEquipment.Columns(1).HeaderText = json("EquipGridName")
        gridSelectedEquipment.Columns(2).HeaderText = json("EquipGridKit")
        gridSelectedEquipment.Columns(3).HeaderText = json("EquipGridState")
        gridSelectedEquipment.Columns(4).HeaderText = json("EquipGridComments")
        gridSelectedEquipment.Columns(5).HeaderText = json("EquipGridDeposit")
        gridSelectedEquipment.Columns(6).HeaderText = json("EquipGridRentDeposit")
        gridAllEquipment.Columns("code").HeaderText = json("EquipGridCode")
        gridAllEquipment.Columns("name").HeaderText = json("EquipGridName")
        gridAllEquipment.Columns("kit").HeaderText = json("EquipGridKit")
        gridAllEquipment.Columns("state").HeaderText = json("EquipGridState")
        gridAllEquipment.Columns("comments").HeaderText = json("EquipGridComments")
        gridAllEquipment.Columns("deposit").HeaderText = json("EquipGridDeposit")
        tbSearchEquipment.PlaceholderText = json("SearchPlaceholder")
        tbCodeRenter.PlaceholderText = json("TBCodeFill")
        tbNameRenter.PlaceholderText = json("TBNameFill")
        tbEmailRenter.PlaceholderText = json("TBEmailFill")
        tbPhoneRenter.PlaceholderText = json("TBPhoneFill")
        tbBalanceRenter.PlaceholderText = json("TBBalanceFill")
        labShowAllEquipments.Text = json("CheckAllEquipmentShow")
        btViewRentals.Text = json("RentBtViewRentals")
        btSave.Text = json("SaveItem")
        labRenter.Text = json("RentLabRenter")
        labEquipments.Text = json("RentLabEquipments")
        labBeginDate.Text = json("RentLabBeginDate")
        labEndDate.Text = json("RentLabEndDate")
        labSuggestedDeposit.Text = json("RentLabSuggestedDeposit")
        labRealDeposit.Text = json("RentLabRealDeposit")
        gridSelectedEquipment.Columns(0).ReadOnly = True
        gridSelectedEquipment.Columns(1).ReadOnly = True
        gridSelectedEquipment.Columns(2).ReadOnly = True
        gridSelectedEquipment.Columns(3).ReadOnly = True
        gridSelectedEquipment.Columns(4).ReadOnly = False
        gridSelectedEquipment.Columns(5).ReadOnly = True
        gridSelectedEquipment.Columns(6).ReadOnly = False
    End Sub

End Class
