Imports Newtonsoft.Json.Linq
Public Class UCEquipment

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim mainForm As New MainForm
    Dim json As JObject

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
        dropSearch.SelectedIndex() = 0
        loadLanguage()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub gridEquipment_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridEquipment.CellMouseDoubleClick
        Dim iEquipmentMod = New UCEquipmentMod(gridEquipment.CurrentRow, Me)
        iEquipmentMod.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iEquipmentMod)
        iEquipmentMod.BringToFront()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        search()
    End Sub

    Private Sub dropSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearch.SelectedIndexChanged
        loadDataGridView()
    End Sub

    Private Sub checkAvailableEquip_CheckedChanged(sender As Object, e As EventArgs) Handles checkAvailableEquip.CheckedChanged
        search()
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
        Dim iEquipmentAdd As New UCEquipmentAdd(Me)
        iEquipmentAdd.Dock = DockStyle.Fill
        mainForm.panelMain.Controls.Add(iEquipmentAdd)
        iEquipmentAdd.BringToFront()
    End Sub


    Private Sub checkSelectAllEquipment_CheckedChanged(sender As Object, e As EventArgs) Handles checkSelectAllEquipment.CheckedChanged
        If gridEquipment.SelectedRows.Count = gridEquipment.Rows.Count Then
            gridEquipment.ClearSelection()
        Else
            gridEquipment.SelectAll()
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

    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipment()
        gridEquipment.Columns("code").HeaderText = Lang.getInstance().getLang()("EquipGridCode")
        gridEquipment.Columns("name").HeaderText = Lang.getInstance().getLang()("EquipGridName")
        gridEquipment.Columns("kit").HeaderText = Lang.getInstance().getLang()("EquipGridKit")
        gridEquipment.Columns("state").HeaderText = Lang.getInstance().getLang()("EquipGridState")
        gridEquipment.Columns("available").HeaderText = Lang.getInstance().getLang()("EquipGridAvailable")
        gridEquipment.Columns("comments").HeaderText = Lang.getInstance().getLang()("EquipGridComments")
        gridEquipment.Columns("available").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub search()
        Select Case dropSearch.SelectedIndex
            Case 0
                If IsNumeric(tbSearch.Text) Then
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentCodeSearch(tbSearch.Text, 1)
                    Else
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentCodeSearch(tbSearch.Text)
                    End If
                Else
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentAvailable(1)
                    Else
                        loadDataGridView()
                    End If
                End If
            Case 1
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentName(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentName(tbSearch.Text)
                End If
            Case 2
                If IsNumeric(tbSearch.Text) Then
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentKit(tbSearch.Text, 1)
                    Else
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentKit(tbSearch.Text)
                    End If
                Else
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentAvailable(1)
                    Else
                        loadDataGridView()
                    End If
                End If
            Case 3
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentState(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentState(tbSearch.Text)
                End If
            Case 4
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentComment(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance().getEquipmentComment(tbSearch.Text)
                End If
        End Select
    End Sub

    Private Sub loadLanguage()
        btNewEquipment.Text = Lang.getInstance().getLang()("NewItem")
        btDelEquipment.Text = Lang.getInstance().getLang()("DeleteItem")
        btPrintBarcodeEquip.Text = Lang.getInstance().getLang()("PrintBarCode")
        labAvailableOnlyName.Text = Lang.getInstance().getLang()("AvailableOnly")
        tbSearch.PlaceholderText = Lang.getInstance().getLang()("SearchPlaceholder")
    End Sub
End Class
