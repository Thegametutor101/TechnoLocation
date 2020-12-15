Imports Newtonsoft.Json.Linq
Public Class UCEquipment

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim mainForm As New MainForm(0)
    Dim codesBarres As New BarCodes

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguage()
        tbSearch.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub gridEquipment_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridEquipment.CellMouseDoubleClick
        Dim iEquipmentMod = New UCEquipmentMod(gridEquipment.CurrentRow, Me, mainForm)
        iEquipmentMod.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iEquipmentMod)
        iEquipmentMod.BringToFront()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged,
                                                                               checkAvailableEquip.CheckedChanged
        search()
    End Sub
    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        If e.KeyCode = Keys.V Then
            tbSearch.Text = codesBarres.isBarcodeEquip(tbSearch.Text)
        End If
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

    Private Sub btNewEquipment_Click(sender As Object, e As EventArgs) Handles btNewEquipment.Click
        Dim iEquipmentAdd As New UCEquipmentAdd(Me, mainForm)
        iEquipmentAdd.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iEquipmentAdd)
        iEquipmentAdd.BringToFront()
    End Sub


    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged
        If checkAll.Checked Then
            gridEquipment.SelectAll()
        Else
            gridEquipment.ClearSelection()
            gridEquipment.Rows(0).Selected = True
        End If
    End Sub

    Private Sub btDelEquipment_Click(sender As Object, e As EventArgs) Handles btDelEquipment.Click
        Dim title As String = Lang.getInstance().getLang()("MsgWarning")
        Dim message As String = Lang.getInstance().getLang()("MsgDeleteEquipment")
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each selectedItem As DataGridViewRow In gridEquipment.SelectedRows
                ModelEquipment.getInstance.delEquipment(selectedItem.Cells(0).Value)
            Next
            loadDataGridView()
        End If
    End Sub

    Private Sub btPrintBarcodeEquip_Click(sender As Object, e As EventArgs) Handles btPrintBarcodeEquip.Click
        Dim listeEquip As New List(Of String)
        For Each Item As DataGridViewRow In gridEquipment.SelectedRows
            listeEquip.Add(Item.Cells(0).Value.ToString())
        Next
        codesBarres.mergeImages(listeEquip)
        codesBarres.PrintBCFromFile("merge")
    End Sub

    Private Sub availableChange(sender As Object, e As DataGridViewCellEventArgs) Handles gridEquipment.CellClick
        If gridEquipment.CurrentCell.ColumnIndex = 4 Then
            Dim code = gridEquipment.CurrentRow.Cells(0).Value
            If gridEquipment.CurrentRow.Cells(4).Value Then
                ModelEquipment.getInstance().setAvailable(code, 0)
            Else
                ModelEquipment.getInstance().setAvailable(code, 1)
            End If
            loadDataGridView()
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipment()
        codesBarres.deleteAllBC()
        For Each selectedItem As DataGridViewRow In gridEquipment.Rows
            codesBarres.generateSaveBC(selectedItem.Cells(0).Value.ToString)
        Next
    End Sub

    Private Sub search()
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearch.BorderColor = grey
        tbSearch.FocusedState.BorderColor = blue
        tbSearch.Text = tbSearch.Text.Trim()
        If tbSearch.Text.Length > 0 Then
            gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearch(tbSearch.Text, checkAvailableEquip.Checked)
            If gridEquipment.Rows.Count = 0 Then
                tbSearch.BorderColor = red
                tbSearch.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentsBySearch(tbSearch.Text, checkAvailableEquip.Checked)
        End If
    End Sub

    Private Sub loadLanguage()
        Dim json = Lang.getInstance().getLang()
        btNewEquipment.Text = json("NewItem")
        btDelEquipment.Text = json("DeleteItem")
        btPrintBarcodeEquip.Text = json("PrintBarCode")
        labAvailableOnlyName.Text = json("AvailableOnly")
        tbSearch.PlaceholderText = json("SearchPlaceholder")
        gridEquipment.Columns("code").HeaderText = json("EquipGridCode")
        gridEquipment.Columns("name").HeaderText = json("EquipGridName")
        gridEquipment.Columns("kit").HeaderText = json("EquipGridKit")
        gridEquipment.Columns("state").HeaderText = json("EquipGridState")
        gridEquipment.Columns("available").HeaderText = json("EquipGridAvailable")
        gridEquipment.Columns("comments").HeaderText = json("EquipGridComments")
        gridEquipment.Columns("deposit").HeaderText = json("EquipGridDeposit")
        gridEquipment.Columns("available").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gridEquipment.Columns("available").ReadOnly = False
    End Sub



End Class
