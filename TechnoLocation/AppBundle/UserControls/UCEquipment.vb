Imports MySql.Data.MySqlClient
Public Class UCEquipment
    Private Sub btNewEquipment_Click(sender As Object, e As EventArgs) Handles btNewEquipment.Click
        Dim iEquipmentAdd As New UCEquipmentAdd()
        iEquipmentAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iEquipmentAdd)
        iEquipmentAdd.BringToFront()
    End Sub

    Private Sub UCEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
    End Sub

    Private Sub loadDataGridView()
        gridEquipment.DataSource = Nothing
        gridEquipment.Rows.Clear()

        Dim con As New MySqlConnection(MainForm.getInstance().connectionString)
        Dim ds As DataSet
        Dim da As MySqlDataAdapter

        da = New MySqlDataAdapter("Select * from equipment order by code", con)
        ds = New DataSet("technolocation")
        da.Fill(ds, "Equipment")

        gridEquipment.DataSource = ds.Tables("Equipment")
    End Sub

    Private Sub btSelectAllEquipment_Click(sender As Object, e As EventArgs) Handles btSelectAllEquipment.Click
        gridEquipment.SelectAll()
    End Sub

    Private Sub btDelEquipment_Click(sender As Object, e As EventArgs) Handles btDelEquipment.Click
        'Dim response = MsgBox(Msg.getMsgDeleteEquipment, vbYesNo, Msg.getMsgWarning)

        'If response = vbYes Then
        '    For Each selectedItem As DataGridViewRow In gridEquipment.SelectedRows
        '        ModelEquipment.getInstance.delEquipment(selectedItem.Cells(0).Value)
        '    Next
        '    loadDataGridView()
        'End If
    End Sub

    Private Sub gridEquipment_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridEquipment.CellMouseDoubleClick
        Dim iEquipmentMod = New UCEquipmentMod(gridEquipment.CurrentRow)
        iEquipmentMod.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iEquipmentMod)
        iEquipmentMod.BringToFront()
    End Sub
End Class
