Public Class UCRentList

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCRentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub loadDataGridView()
        gridListRent.DataSource = EntityRent.getInstance.getRentals(mainForm.labLang.Text)
    End Sub

    Private Sub tbSearchRent_TextChanged(sender As Object, e As EventArgs) Handles tbSearchRent.TextChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearchRent.BorderColor = grey
        tbSearchRent.FocusedState.BorderColor = blue
        tbSearchRent.Text = tbSearchRent.Text.Trim()
        If tbSearchRent.Text.Length > 0 Then
            gridListRent.DataSource = EntityRent.getInstance.getRentalsBySearch(mainForm.labLang.Text, tbSearchRent.Text)
            If gridListRent.Rows.Count = 0 Then
                tbSearchRent.BorderColor = red
                tbSearchRent.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        End If
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

    Private Sub btDelEquipment_Click(sender As Object, e As EventArgs) Handles btDelEquipment.Click
        Dim title As String = Lang.getInstance().getLang()("MsgWarning")
        Dim message As String = Lang.getInstance().getLang()("MsgDeleteEquipment")
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each selectedItem As DataGridViewRow In gridListRent.SelectedRows
                ModelRent.getInstance.delRent(selectedItem.Cells(0).Value)
            Next
            loadDataGridView()
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________
End Class
