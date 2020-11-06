Imports MySql.Data.MySqlClient
Public Class UCEquipment
    Private Sub btNewEquipment_Click(sender As Object, e As EventArgs) Handles btNewEquipment.Click
        Dim iEquipmentAdd As New UCEquipmentAdd(Me)
        iEquipmentAdd.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iEquipmentAdd)
        iEquipmentAdd.BringToFront()
    End Sub

    Private Sub UCEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        dropSearch.SelectedIndex() = 0
    End Sub

    Public Sub loadDataGridView()
        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipment
    End Sub

    Private Sub btSelectAllEquipment_Click(sender As Object, e As EventArgs) Handles btSelectAllEquipment.Click
        If gridEquipment.SelectedRows.Count = gridEquipment.Rows.Count Then
            gridEquipment.ClearSelection()
        Else
            gridEquipment.SelectAll()
        End If
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
        Dim iEquipmentMod = New UCEquipmentMod(gridEquipment.CurrentRow, Me)
        iEquipmentMod.Dock = DockStyle.Fill
        MainForm.panelMain.Controls.Add(iEquipmentMod)
        iEquipmentMod.BringToFront()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        search()
    End Sub

    Private Sub search()
        Select Case dropSearch.SelectedIndex
            Case 0
                If IsNumeric(tbSearch.Text) Then
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentCodeSearch(tbSearch.Text, 1)
                    Else
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentCodeSearch(tbSearch.Text)
                    End If
                Else
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    Else
                        loadDataGridView()
                    End If
                End If
            Case 1
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentName(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentName(tbSearch.Text)
                End If
            Case 2
                If IsNumeric(tbSearch.Text) Then
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentKit(tbSearch.Text, 1)
                    Else
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentKit(tbSearch.Text)
                    End If
                Else
                    If checkAvailableEquip.Checked Then
                        gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentAvailable(1)
                    Else
                        loadDataGridView()
                    End If
                End If
            Case 3
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentState(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentState(tbSearch.Text)
                End If
            Case 4
                If checkAvailableEquip.Checked Then
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentComment(tbSearch.Text, 1)
                Else
                    gridEquipment.DataSource = EntityEquipment.getInstance.getEquipmentComment(tbSearch.Text)
                End If
        End Select
    End Sub

    Private Sub dropSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearch.SelectedIndexChanged
        loadDataGridView()
        tbSearch.Text = ""
    End Sub

    Private Sub checkAvailableEquip_CheckedChanged(sender As Object, e As EventArgs) Handles checkAvailableEquip.CheckedChanged
        search()
    End Sub
End Class
