Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq
Public Class UCEquipmentAdd
    Dim kit As Integer = 0
    Dim rowSelected As Boolean = False
    Dim equipment As UCEquipment
    Private json As JObject

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
                    If MsgBox(json("MsgKitNull"), vbYesNo, json("MsgWarning")) = vbYes Then
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
            MsgBox(json("MsgEmptyName"), vbOKOnly, json("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbComment.Text)) And complete Then
            complete = False
            MsgBox(json("MsgEmptyComment"), vbOKOnly, json("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbState.Text)) And complete Then
            complete = False
            MsgBox(json("MsgEmptyState"), vbOKOnly, json("MsgWarning"))
        End If

        If String.IsNullOrEmpty(Trim(tbDepositEquipAdd.Text)) Or Not IsNumeric(tbDepositEquipAdd.Text) And complete Then
            complete = False
            MsgBox(json("MsgEmptyDeposit"), vbOKOnly, json("MsgWarning"))
        Else
            If tbDepositEquipAdd.Text < 0 And complete Then
                complete = False
                MsgBox(json("MsgNegatifDeposit"), vbOKOnly, json("MsgWarning"))
            End If
        End If

        Return complete
    End Function

    Private Sub btCancelNewEquip_Click(sender As Object, e As EventArgs) Handles btCancelNewEquip.Click
        Me.SendToBack()
    End Sub

    Private Sub AddToDb(check As Integer)
        Dim numAdd As Integer = 0
        For index As Integer = 1 To numEquipAdd.Value
            If ModelEquipment.getInstance().addEquipment(tbNameEquipmentAdd.Text, kit, tbState.Text, check, tbComment.Text, tbDepositEquipAdd.Text) Then
                numAdd += 1
            End If
        Next
        If numAdd = numEquipAdd.Value Then
            MsgBox(json("MsgSuccessAddEquip"), vbOKOnly, json("MsgSuccessAddTitle"))
            tbNameEquipmentAdd.Clear()
            tbComment.Clear()
            tbState.Clear()
            checkAvailableEquipAdd.Checked = True
            numEquipAdd.Value = 1
            Me.SendToBack()
            equipment.loadDataGridView()
        Else
            MsgBox(json("MsgErrorAddEEquip"), vbOKOnly, json("MsgWarning"))
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
