Imports System.Text.RegularExpressions
Public Class UCRentMod

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim row As DataGridViewRow
    Dim ucRentList As UCRentList
    Dim mainForm As MainForm
    Dim successDeposit = False
    Dim reelDeposit As New List(Of Double)
    Dim depositProvisional As Double
    Dim oldUser As Integer
    Dim dateBegin As Date
    Dim dateFinish As Date

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(dataRow As DataGridViewRow, ucListRent As UCRentList, main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        row = dataRow
        ucRentList = ucListRent
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCRentMod_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataGridView()
        loadLang()
        loadUser()
        For Each rows As DataGridViewRow In gridEquipmentRent.Rows
            reelDeposit.Add(rows.Cells(6).Value)
        Next
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub dateStart_ValueChanged(sender As Object, e As EventArgs) Handles dateStart.ValueChanged
        If Not dateBegin = "0001-01-01" Then
            If dateStart.Value > dateEnd.Value Then
                dateStart.Value = dateBegin
            Else
                dateBegin = dateStart.Value

            End If
        End If
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

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    Private Sub changeDepositReel()
        Dim deposit As Double = 0
        For Each row As DataGridViewRow In gridEquipmentRent.Rows
            deposit += row.Cells(6).Value
        Next
        tbReelDeposit.Text = checkNumberMoney(deposit)
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
            str = Replace(gridEquipmentRent.CurrentCell.Value, ",", ".")
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

    Private Sub btDelEquipment_Click(sender As Object, e As EventArgs) Handles btDelEquipment.Click
        Dim title As String = Lang.getInstance().getLang()("MsgWarning")
        Dim message As String = Lang.getInstance().getLang()("MsgDeleteEquipmentRent")
        successDeposit = False
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            depositProvisional = 0
            For Each selectedItem As DataGridViewRow In gridEquipmentRent.SelectedRows
                depositProvisional += reelDeposit.Item(selectedItem.Index.ToString).ToString
            Next
            Dim prompReturnAmount = New PromptReturnAmount(mainForm, Me, depositProvisional)
            prompReturnAmount.ShowDialog()
            If successDeposit Then
                For Each selectedItem As DataGridViewRow In gridEquipmentRent.SelectedRows
                    reelDeposit.RemoveAt(selectedItem.Index.ToString)
                    ModelRent.getInstance.removeRental(row.Cells(0).Value, selectedItem.Cells(0).Value)
                Next
                ModelUser.getInstance.updateUserBalance(oldUser, tbBalanceRenter.Text - tbReelDeposit.Text)
            End If
            loadDataGridView()
            loadUser()
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If mainForm.isEditing Then
            If MessageBox.Show(message,
                               title,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                mainForm.isEditing = False
                Me.SendToBack()
            End If
        Else
            Me.SendToBack()
        End If
    End Sub

    Private Sub btAddUser_Click(sender As Object, e As EventArgs) Handles btAddUser.Click
        Dim user = New ChooseUser(mainForm, Me, oldUser)
        user.ShowDialog()
        oldUser = tbCodeRenter.Text
        For Each rows As DataGridViewRow In gridEquipmentRent.Rows
            ModelRent.getInstance.updateRentForRent(row.Cells(0).Value,
                                             oldUser,
                                             mainForm.code,
                                             rows.Cells(0).Value)
        Next
    End Sub

    Private Sub gridEquipmentRent_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridEquipmentRent.CellEndEdit
        If Not String.IsNullOrEmpty(gridEquipmentRent.CurrentCell.Value) Then
            If Regex.IsMatch(gridEquipmentRent.CurrentCell.Value, "^([\d])*(\.[\d]{0,2}|\,[\d]{0,2})*$") Then
                changeDepositReel()
                Try
                    gridEquipmentRent.CurrentCell.Value = checkNumberMoney(Replace(gridEquipmentRent.CurrentCell.Value, ",", "."))
                Catch ex As Exception
                    gridEquipmentRent.CurrentCell.Value = checkNumberMoney(Replace(gridEquipmentRent.CurrentCell.Value, ".", ","))
                End Try
            Else
                gridEquipmentRent.CurrentCell.Value = "$ 0,00"
                changeDepositReel()
            End If
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadDataGridView()
        Dim nbr As Double = 0
        gridEquipmentRent.DataSource = EntityEquipment.getInstance.getEquipmentsByRentalForMod(row.Cells(0).Value)
        For Each row As DataGridViewRow In gridEquipmentRent.Rows
            nbr += row.Cells(6).Value
        Next
        tbReelDeposit.Text = nbr
    End Sub

    Private Sub loadUser()
        Dim table As DataTable = EntityUser.getInstance.getUserByRentalForRent(row.Cells(0).Value)
        tbCodeRenter.Text = table.Rows(0).Item(0).ToString
        oldUser = tbCodeRenter.Text
        tbNameRenter.Text = table.Rows(0).Item(1).ToString + " " + table.Rows(0).Item(2).ToString
        tbEmailRenter.Text = table.Rows(0).Item(3).ToString
        tbPhoneRenter.Text = table.Rows(0).Item(4).ToString
        tbBalanceRenter.Text = table.Rows(0).Item(5).ToString
        dateStart.Value = row.Cells(4).Value
        dateEnd.Value = row.Cells(5).Value
    End Sub

    Private Sub loadLang()
        Dim json = Lang.getInstance().getLang()
        gridEquipmentRent.Columns("code").HeaderText = json("EquipGridCode")
        gridEquipmentRent.Columns("code").ReadOnly = True
        gridEquipmentRent.Columns("name").HeaderText = json("EquipGridName")
        gridEquipmentRent.Columns("name").ReadOnly = True
        gridEquipmentRent.Columns("kit").HeaderText = json("EquipGridKit")
        gridEquipmentRent.Columns("kit").ReadOnly = True
        gridEquipmentRent.Columns("state").HeaderText = json("EquipGridState")
        gridEquipmentRent.Columns("state").ReadOnly = True
        gridEquipmentRent.Columns("comments").HeaderText = json("EquipGridComments")
        gridEquipmentRent.Columns("comments").ReadOnly = True
        gridEquipmentRent.Columns("depositSuggest").HeaderText = json("RentLabSuggestedDeposit")
        gridEquipmentRent.Columns("depositSuggest").ReadOnly = True
        gridEquipmentRent.Columns("depositReel").HeaderText = json("RentLabRealDeposit")
        gridEquipmentRent.Columns("depositReel").ReadOnly = False
        tbCodeRenter.PlaceholderText = json("TBCodeFill")
        tbNameRenter.PlaceholderText = json("TBNameFill")
        tbEmailRenter.PlaceholderText = json("TBEmailFill")
        tbPhoneRenter.PlaceholderText = json("TBPhoneFill")
        tbBalanceRenter.PlaceholderText = json("TBBalanceFill")
        btSave.Text = json("SaveItem")
        btCancel.Text = json("CancelButton")
        btDelEquipment.Text = json("DeleteItem")
        labRenter.Text = json("RentLabRenter")
        labEquipments.Text = json("RentLabEquipments")
        labBeginDate.Text = json("RentLabBeginDate")
        labEndDate.Text = json("RentLabEndDate")
        labRealDeposit.Text = json("RentLabRealDeposit")
    End Sub

    Public Sub setSuccessDeposit()
        successDeposit = True
    End Sub
End Class
