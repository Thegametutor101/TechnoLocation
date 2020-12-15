Public Class UCHistory

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim codesBarres As New BarCodes
    Dim WithEvents mainForm As New MainForm(0)
    Friend action As Boolean = False

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

    Private Sub UCHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguage()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        search()
    End Sub
    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        If e.KeyCode = Keys.V Then
            If tbSearch.Text.Length = 8 Then
                tbSearch.Text = codesBarres.isBarcodeEquip(tbSearch.Text)
            Else
                tbSearch.Text = codesBarres.isBarcodeUser(tbSearch.Text)
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

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        Dim options = New PromptClearHistoryOptions(mainForm, Me, gridHistory.SelectedRows)
        options.ShowDialog()
        mainForm.loadHistory()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub search()
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearch.BorderColor = grey
        tbSearch.FocusedState.BorderColor = blue
        tbSearch.Text = tbSearch.Text.Trim()
        If tbSearch.Text.Length > 0 Then
            gridHistory.DataSource = EntityHistory.getInstance().getHistoryBySearch(mainForm.labLang.Text, tbSearch.Text)
            If gridHistory.Rows.Count = 0 Then
                tbSearch.BorderColor = red
                tbSearch.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            loadDataGridView()
        End If
    End Sub

    Private Sub loadDataGridView()
        gridHistory.DataSource = EntityHistory.getInstance().getHistory(mainForm.labLang.Text)
    End Sub

    Private Sub loadLanguage()
        Dim json = Lang.getInstance().getLang()
        tbSearch.PlaceholderText = json("SearchPlaceholder")
        gridHistory.Columns.Item("code").HeaderText = json("HistoryCode")
        gridHistory.Columns.Item("returnDate").HeaderText = json("HistoryReturnDate")
        gridHistory.Columns.Item("renterName").HeaderText = json("HistoryRenterName")
        gridHistory.Columns.Item("receptorName").HeaderText = json("HistoryReceptorName")
        gridHistory.Columns.Item("state").HeaderText = json("HistoryState")
        gridHistory.Columns.Item("comments").HeaderText = json("HistoryComments")
        gridHistory.Columns.Item("code").Width = 80
    End Sub

End Class