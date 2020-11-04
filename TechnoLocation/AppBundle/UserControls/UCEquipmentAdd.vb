Imports MySql.Data.MySqlClient
Public Class UCEquipmentAdd
    Dim Msg As FR_CA = New FR_CA
    Dim kit As Integer = 0
    Dim rowSelected As Boolean = False
    Dim equipment As UCEquipment

    Sub New(equip As UCEquipment)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        equipment = equip
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub btAddNewEquip_Click(sender As Object, e As EventArgs) Handles btAddNewEquip.Click
        Dim check = 0

        If rowSelected Then
            kit = gridEquipmentAdd.CurrentRow.Cells(0).Value
        End If

        Try
            If verificationAdd() Then
                If checkAvailableEquipAdd.Checked Then
                    check = 1
                End If

                If kit = 0 Then
                    If MsgBox(Msg.getMsgKitNull, vbYesNo, Msg.getMsgWarning) = vbYes Then
                        AddToDb(check)
                    End If
                Else
                    AddToDb(check)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function verificationAdd() As Boolean
        Dim complete As Boolean = True
        If String.IsNullOrEmpty(Trim(tbNameEquipmentAdd.Text)) Then
            complete = False
            MsgBox(Msg.getMsgEmptyName, vbOKOnly, Msg.getMsgWarning)
        End If

        If String.IsNullOrEmpty(Trim(tbComment.Text)) And complete Then
            complete = False
            MsgBox(Msg.getMsgEmptyComment, vbOKOnly, Msg.getMsgWarning)
        End If

        If String.IsNullOrEmpty(Trim(tbState.Text)) And complete Then
            complete = False
            MsgBox(Msg.getMsgEmptyState, vbOKOnly, Msg.getMsgWarning)
        End If

        Return complete
    End Function

    Private Sub btCancelNewEquip_Click(sender As Object, e As EventArgs) Handles btCancelNewEquip.Click
        Me.SendToBack()
    End Sub

    Private Sub AddToDb(check As Integer)
        Dim numAdd As Integer = 0
        For index As Integer = 1 To numEquipAdd.Value
            If ModelEquipment.getInstance().addEquipment(tbNameEquipmentAdd.Text, kit, tbState.Text, check, tbComment.Text) Then
                numAdd += 1
            End If
        Next
        If numAdd = numEquipAdd.Value Then
            MsgBox(Msg.getMsgSuccessAddEquip, vbOKOnly, Msg.getMsgSuccessAddTitle)
            tbNameEquipmentAdd.Clear()
            tbComment.Clear()
            tbState.Clear()
            checkAvailableEquipAdd.Checked = True
            numEquipAdd.Value = 1
            Me.SendToBack()
            equipment.loadDataGridView()
        Else
            MsgBox(Msg.getMsgErrorAddEEquip, vbOKOnly, Msg.getMsgWarning)
        End If
    End Sub

    Public Sub loadDataGridView()
        gridEquipmentAdd.DataSource = EntityKit.getInstance.getKit
    End Sub

    Private Sub UCEquipmentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
    End Sub

    Private Sub btKitNull_Click(sender As Object, e As EventArgs) Handles btKitNull.Click
        gridEquipmentAdd.ClearSelection()
        rowSelected = False
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click
        AddKit.ShowDialog()
        loadDataGridView()
    End Sub

    Private Sub gridEquipmentAdd_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridEquipmentAdd.DataBindingComplete
        gridEquipmentAdd.ClearSelection()
    End Sub

    Private Sub gridEquipmentAdd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridEquipmentAdd.CellClick
        rowSelected = True
    End Sub
End Class
