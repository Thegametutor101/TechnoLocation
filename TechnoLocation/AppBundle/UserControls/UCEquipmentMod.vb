Imports Newtonsoft.Json.Linq
Public Class UCEquipmentMod


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim row As DataGridViewRow
    Dim kit As Integer
    Dim equipment As UCEquipment
    Dim mainForm As New MainForm(0)

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(iCode As DataGridViewRow, equip As UCEquipment, main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        row = iCode
        equipment = equip
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCEquipmentMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        tbName.Text = row.Cells(1).Value
        tbComment.Text = row.Cells(5).Value
        tbState.Text = row.Cells(3).Value
        Try
            tbDepositEquipMod.Value = Replace(Replace(row.Cells(6).Value,
                                                      "$ ",
                                                      ""),
                                              ",",
                                              ".")
        Catch ex As Exception
            tbDepositEquipMod.Value = Replace(row.Cells(6).Value, "$ ", "")
        End Try
        If row.Cells(4).Value = True Then
            checkAvailable.Checked = True
        End If
        kit = gridKit.SelectedRows.Item(0).Cells.Item(0).Value
        loadLanguage()
        tbName.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub gridEquipMod_DataBindComplete(sender As Object,
                    e As DataGridViewBindingCompleteEventArgs) Handles gridKit.DataBindingComplete
        gridKit.ClearSelection()
        For Each rowKit As DataGridViewRow In gridKit.Rows
            If rowKit.Cells(1).Value = row.Cells(2).Value Then
                gridKit.Rows(rowKit.Index).Selected = True
            End If
        Next
    End Sub

    Private Sub gridEquipmentMod_CellClick(sender As Object,
                                           e As DataGridViewCellEventArgs) Handles gridKit.CellClick
        kit = gridKit.CurrentRow.Cells(0).Value
    End Sub

    Private Sub valuesChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged,
                                                                        tbState.TextChanged,
                                                                        tbComment.TextChanged,
                                                                        tbDepositEquipMod.ValueChanged
        mainForm.isEditing = True
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    Private Function verificationMod() As Boolean
        Dim complete As Boolean = True
        If String.IsNullOrEmpty(Trim(tbName.Text)) Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyName"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbComment.Text)) And complete Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyComment"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbState.Text)) And complete Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyState"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If

        Return complete
    End Function

    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btModEquip_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim check As Integer
        If MsgBox(Lang.getInstance().getLang()("MsgSubmit"), vbYesNo) = vbYes Then
            If verificationMod() Then
                If checkAvailable.Checked Then
                    check = 1
                Else
                    check = 0
                End If
                ModelEquipment.getInstance.updateEquipment(row.Cells(0).Value,
                                                           tbName.Text,
                                                           kit,
                                                           tbState.Text,
                                                           check,
                                                           tbComment.Text,
                                                           tbDepositEquipMod.Value)
                mainForm.isEditing = False
                Me.SendToBack()
                equipment.loadDataGridView()
            End If
        End If
    End Sub

    Private Sub btKitMod_Click(sender As Object, e As EventArgs) Handles btAddKit.Click
        AddKit.ShowDialog()
        loadDataGridView()
    End Sub

    Private Sub btKitNullMod_Click(sender As Object, e As EventArgs) Handles btNoKit.Click
        gridKit.ClearSelection()
        kit = 0
    End Sub

    Private Sub btCancelModEquip_Click(sender As Object, e As EventArgs) Handles btCancel.Click, btBack.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If Not tbName.Text = row.Cells(1).Value Or
            Not tbComment.Text = row.Cells(5).Value Or
            Not tbState.Text = row.Cells(3).Value Then
            If MessageBox.Show(message,
                               title,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                mainForm.isEditing = False
                Me.SendToBack()
            End If
        Else
            mainForm.isEditing = False
            Me.SendToBack()
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridKit.DataSource = EntityKit.getInstance.getKit
        gridKit.Columns("code").HeaderText = Lang.getInstance().getLang()("EquipGridCode")
        gridKit.Columns("name").HeaderText = Lang.getInstance().getLang()("EquipGridName")
    End Sub

    Private Sub loadLanguage()
        Dim json = Lang.getInstance().getLang()
        btSave.Text = json("SaveItem")
        btCancel.Text = json("CancelButton")
        btAddKit.Text = json("EquipmentModbtAddKit")
        btNoKit.Text = json("EquipmentModbtNoKit")
        labKitName.Text = json("EquipmentModlabKitName")
        labAvailable.Text = json("EquipmentModlabAvailable")
        labName.Text = json("EquipmentModlabName")
        labState.Text = json("EquipmentModlabState")
        labComment.Text = json("EquipmentModlabComment")
        labDeposit.Text = json("EquipmentModlabDeposit")
        tbState.PlaceholderText = json("EquipmentModtbStatePlaceholder")
    End Sub
End Class
