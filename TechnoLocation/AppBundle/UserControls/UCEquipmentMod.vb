Imports Newtonsoft.Json.Linq
Public Class UCEquipmentMod
    Dim row As DataGridViewRow
    Dim json As JObject
    Dim kit As Integer
    Dim equipment As UCEquipment
    Sub New(iCode As DataGridViewRow, equip As UCEquipment)
        InitializeComponent()
        row = iCode
        equipment = equip
    End Sub

    Private Sub btModEquip_Click(sender As Object, e As EventArgs) Handles btModEquip.Click
        Dim check As Integer
        If MsgBox(json("MsgEditEquipment"), vbYesNo) = vbYes Then
            If verificationMod() Then
                If checkAvailableEquipMod.Checked Then
                    check = 1
                Else
                    check = 0
                End If

                ModelEquipment.getInstance.updateEquipment(row.Cells(0).Value, tbNameEquipmentMod.Text, kit, tbStateEquipMod.Text, check, tbCommentMod.Text, tbDepositEquipMod.Text)
                Me.SendToBack()
                equipment.loadDataGridView()
            End If
        End If
    End Sub

    Private Function verificationMod() As Boolean
        Dim complete As Boolean = True
        If String.IsNullOrEmpty(Trim(tbNameEquipmentMod.Text)) Then
            complete = False
            MsgBox(json("MsgEmptyName"), vbOKOnly, json("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbCommentMod.Text)) And complete Then
            complete = False
            MsgBox(json("MsgEmptyComment"), vbOKOnly, json("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbStateEquipMod.Text)) And complete Then
            complete = False
            MsgBox(json("MsgEmptyState"), vbOKOnly, json("MsgWarning"))
        End If

        Return complete
    End Function

    Private Sub UCEquipmentMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        json = Lang.getInstance("fr_ca").ListProperty
        loadDataGridView()
        tbNameEquipmentMod.Text = row.Cells(1).Value
        tbCommentMod.Text = row.Cells(5).Value
        tbStateEquipMod.Text = row.Cells(3).Value
        If row.Cells(4).Value = True Then
            checkAvailableEquipMod.Checked = True
        End If
        kit = row.Cells(2).Value
    End Sub

    Public Sub loadDataGridView()
        gridEquipmentMod.DataSource = EntityKit.getInstance.getKit
    End Sub

    Private Sub btKitMod_Click(sender As Object, e As EventArgs) Handles btKitMod.Click
        AddKit.ShowDialog()
        loadDataGridView()
    End Sub

    Private Sub btKitNullMod_Click(sender As Object, e As EventArgs) Handles btKitNullMod.Click
        gridEquipmentMod.ClearSelection()
        kit = 0
    End Sub

    Private Sub gridEquipmentMod_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridEquipmentMod.DataBindingComplete
        gridEquipmentMod.ClearSelection()
        For Each rowKit As DataGridViewRow In gridEquipmentMod.Rows
            If rowKit.Cells(0).Value = row.Cells(2).Value Then
                gridEquipmentMod.Rows(rowKit.Index).Selected = True
            End If
        Next
    End Sub

    Private Sub btCancelModEquip_Click(sender As Object, e As EventArgs) Handles btCancelModEquip.Click
        Me.SendToBack()
    End Sub

    Private Sub gridEquipmentMod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridEquipmentMod.CellClick
        kit = gridEquipmentMod.CurrentRow.Cells(0).Value
    End Sub
End Class
