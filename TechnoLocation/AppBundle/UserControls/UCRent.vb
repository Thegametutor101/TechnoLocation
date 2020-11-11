Public Class UCRent
    Private Sub UCRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers
        loadDataGridViewEquip()
        gridItemAdd.ColumnCount = 5
        gridItemAdd.Columns(0).Name = "Code"
        gridItemAdd.Columns(1).Name = "Nom"
        gridItemAdd.Columns(2).Name = "kit"
        gridItemAdd.Columns(3).Name = "État"
        gridItemAdd.Columns(4).Name = "Commentaire"
    End Sub

    Public Sub loadDataGridViewEquip()
        gridItemSearch.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
    End Sub

    Private Sub tbUserSearch_TextChanged(sender As Object, e As EventArgs) Handles tbUserSearch.TextChanged

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
        gridItemAdd.Rows.Add(New String() {gridItemSearch.CurrentRow.Cells(0).Value, gridItemSearch.CurrentRow.Cells(1).Value, gridItemSearch.CurrentRow.Cells(2).Value, gridItemSearch.CurrentRow.Cells(3).Value, gridItemSearch.CurrentRow.Cells(5).Value})
        gridItemSearch.Rows.Remove(gridItemSearch.CurrentRow)
    End Sub

    Private Sub gridItemAdd_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridItemAdd.CellDoubleClick
        gridItemAdd.Rows.Remove(gridItemAdd.CurrentRow)
    End Sub
End Class
