Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq
Public Class UCEquipmentAdd


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim kit As Integer = 0
    Dim rowSelected As Boolean = False
    Dim equipment As UCEquipment
    Dim mainForm As New MainForm

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(equip As UCEquipment, main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        equipment = equip
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCEquipmentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguage()
        tbName.Focus()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub AddToDb(check As Integer)
        Dim numAdd As Integer = 0
        For index As Integer = 1 To numCount.Value
            If ModelEquipment.getInstance().addEquipment(tbName.Text,
                                                         kit,
                                                         tbState.Text,
                                                         check,
                                                         tbComment.Text,
                                                         numDeposit.Value) Then
                numAdd += 1
            End If
        Next
        If numAdd = numCount.Value Then
            MsgBox(Lang.getInstance().getLang()("MsgSuccessAdd"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgSuccessAddTitle"))
            mainForm.isEditing = False
            tbName.Clear()
            tbComment.Clear()
            tbState.Clear()
            checkAvailable.Checked = True
            numCount.Value = 1
            Me.SendToBack()
            equipment.loadDataGridView()
        Else
            MsgBox(Lang.getInstance().getLang()("MsgErrorAdd"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        End If
    End Sub

    Private Sub gridKit_DataBindingComplete(sender As Object,
                                            e As DataGridViewBindingCompleteEventArgs) Handles gridKit.DataBindingComplete
        gridKit.ClearSelection()
    End Sub

    Private Sub gridKit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridKit.CellClick
        rowSelected = True
    End Sub

    Private Sub valuesChanges(sender As Object, e As EventArgs) Handles tbName.TextChanged,
                                                                        tbState.TextChanged,
                                                                        tbComment.TextChanged,
                                                                        numDeposit.ValueChanged,
                                                                        numCount.ValueChanged
        mainForm.isEditing = True
    End Sub

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    Private Function verificationAdd() As Boolean
        Dim complete As Boolean = True
        If String.IsNullOrEmpty(Trim(tbName.Text)) Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyName"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        ElseIf String.IsNullOrEmpty(Trim(tbComment.Text)) And complete Then
            complete = False
            MsgBox(Lang.getInstance().getLang()("MsgEmptyComment"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        ElseIf String.IsNullOrEmpty(Trim(tbState.Text)) And complete Then
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

    Private Sub btAddNewEquip_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim check = 0

        If rowSelected Then
            kit = gridKit.CurrentRow.Cells(0).Value
        End If

        Try
            If verificationAdd() Then
                If checkAvailable.Checked Then
                    check = 1
                End If

                If kit = 0 Then
                    If MsgBox(Lang.getInstance().getLang()("MsgKitNull"),
                              vbYesNo,
                              Lang.getInstance().getLang()("MsgWarning")) = vbYes Then
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

    Private Sub btCancelNewEquip_Click(sender As Object, e As EventArgs) Handles btCancel.Click, btBack.Click
        Dim title As String = Lang.getInstance().getLang()("MsgCancelTitle")
        Dim message As String = Lang.getInstance().getLang()("MsgCancel")
        If Not String.IsNullOrEmpty(tbName.Text) Or
           Not String.IsNullOrEmpty(tbComment.Text) Or
           Not String.IsNullOrEmpty(tbState.Text) Then
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

    Private Sub btKitNull_Click(sender As Object, e As EventArgs) Handles btNoKit.Click
        gridKit.ClearSelection()
        rowSelected = False
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btAddKit.Click
        AddKit.ShowDialog()
        loadDataGridView()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridKit.DataSource = EntityKit.getInstance.getKit()
        gridKit.Columns("code").HeaderText = Lang.getInstance().getLang()("EquipGridCode")
        gridKit.Columns("name").HeaderText = Lang.getInstance().getLang()("EquipGridName")
    End Sub

    Private Sub loadLanguage()
        btSave.Text = Lang.getInstance().getLang()("SaveItem")
        btCancel.Text = Lang.getInstance().getLang()("CancelButton")
        btAddKit.Text = Lang.getInstance().getLang()("EquipmentModbtAddKit")
        btNoKit.Text = Lang.getInstance().getLang()("EquipmentModbtNoKit")
        labKitName.Text = Lang.getInstance().getLang()("EquipmentModlabKitName")
        labAvailable.Text = Lang.getInstance().getLang()("EquipmentModlabAvailable")
        labName.Text = Lang.getInstance().getLang()("EquipmentModlabName")
        labState.Text = Lang.getInstance().getLang()("EquipmentModlabState")
        labComment.Text = Lang.getInstance().getLang()("EquipmentModlabComment")
        labDeposit.Text = Lang.getInstance().getLang()("EquipmentModlabDeposit")
        labAddCount.Text = Lang.getInstance().getLang()("EquipmentlabCount")
        tbState.PlaceholderText = Lang.getInstance().getLang()("EquipmentModtbStatePlaceholder")
    End Sub

End Class
