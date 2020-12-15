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


    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



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
        oldUser = tbCodeRenter.Text = table.Rows(0).Item(0).ToString
        tbNameRenter.Text = table.Rows(0).Item(1).ToString + " " + table.Rows(0).Item(2).ToString
        tbEmailRenter.Text = table.Rows(0).Item(3).ToString
        tbPhoneRenter.Text = table.Rows(0).Item(4).ToString
        tbBalanceRenter.Text = table.Rows(0).Item(5).ToString
    End Sub

    Private Sub loadLang()
        Dim json = Lang.getInstance().getLang()
        gridEquipmentRent.Columns("code").HeaderText = json("EquipGridCode")
        gridEquipmentRent.Columns("name").HeaderText = json("EquipGridName")
        gridEquipmentRent.Columns("kit").HeaderText = json("EquipGridKit")
        gridEquipmentRent.Columns("state").HeaderText = json("EquipGridState")
        gridEquipmentRent.Columns("comments").HeaderText = json("EquipGridComments")
        gridEquipmentRent.Columns("depositSuggest").HeaderText = json("RentLabSuggestedDeposit")
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
