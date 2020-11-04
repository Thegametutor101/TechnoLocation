Imports MySql.Data.MySqlClient
Public Class UCEquipmentMod
    Dim row As DataGridViewRow
    Sub New(iCode As DataGridViewRow)
        InitializeComponent()
        row = iCode
    End Sub

    Private Sub btModEquip_Click(sender As Object, e As EventArgs) Handles btModEquip.Click

    End Sub

    Private Sub UCEquipmentMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        tbNameEquipmentMod.Text = row.Cells(1).Value
        tbCommentMod.Text = row.Cells(5).Value
        tbStateEquipMod.Text = row.Cells(3).Value
        If row.Cells(4).Value = 1 Then
            checkAvailableEquipMod.Checked = True
        End If
    End Sub

    Public Sub loadDataGridView()
        gridEquipmentMod.DataSource = Nothing
        gridEquipmentMod.Rows.Clear()
        Dim con As New MySqlConnection(MainForm.getInstance().connectionString)
        Dim ds As DataSet
        Dim da As MySqlDataAdapter

        da = New MySqlDataAdapter("Select * from kit order by code", con)
        ds = New DataSet("technolocation")
        da.Fill(ds, "Kit")

        gridEquipmentMod.DataSource = ds.Tables("kit")
    End Sub

    Private Sub btKitMod_Click(sender As Object, e As EventArgs) Handles btKitMod.Click
        AddKit.ShowDialog()
        loadDataGridView()
    End Sub

    Private Sub btKitNullMod_Click(sender As Object, e As EventArgs) Handles btKitNullMod.Click
        gridEquipmentMod.ClearSelection()
    End Sub

    Private Sub gridEquipmentMod_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridEquipmentMod.DataBindingComplete
        gridEquipmentMod.ClearSelection()
        For Each rowtest As DataGridViewRow In gridEquipmentMod.Rows
            If rowtest.Cells(0).Value = row.Cells(2).Value Then
                gridEquipmentMod.Rows(row.Index - 1).Selected = True
            End If
        Next
    End Sub
End Class
