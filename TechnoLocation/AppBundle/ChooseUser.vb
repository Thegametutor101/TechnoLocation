Public Class ChooseUser

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainform As New MainForm(0)
    Dim ucRent As UCRent
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, rent As UCRent)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainform = main
        ucRent = rent
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub ChooseUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataGridView()
        loadLanguages()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub HeaderBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Window Position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Left Mouse Button has been pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub HeaderBar_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Obtain new Window Position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub HeaderBar_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeaderBar.MouseUp
        If e.Button = MouseButtons.Left Then
            'Left Mouse Button has been released
            isMouseDown = False
        End If
    End Sub

    Private Sub tbSearchUser_TextChanged(sender As Object, e As EventArgs) Handles tbSearchUser.TextChanged
        Dim grey = Color.FromArgb(1, 213, 218, 223)
        Dim red = Color.FromArgb(0.8, 224, 70, 70)
        Dim blue = Color.FromArgb(0.8, 94, 148, 255)
        tbSearchUser.BorderColor = grey
        tbSearchUser.FocusedState.BorderColor = blue
        tbSearchUser.Text = tbSearchUser.Text.Trim()
        If tbSearchUser.Text.Length > 0 Then
            gridUserSearch.DataSource = EntityUser.getInstance().getUsersBySearch(mainform.labLang.Text, tbSearchUser.Text)
            If gridUserSearch.Rows.Count = 0 Then
                tbSearchUser.BorderColor = red
                tbSearchUser.FocusedState.BorderColor = red
                loadDataGridView()
            End If
        Else
            loadDataGridView()
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

    Private Sub gridUserSearch_CellMouseDoubleClick(sender As Object,
                                                    e As DataGridViewCellMouseEventArgs) Handles gridUserSearch.CellMouseDoubleClick
        ucRent.tbCodeRenter.Text = gridUserSearch.CurrentRow.Cells(0).Value
        ucRent.tbNameRenter.Text = String.Concat(gridUserSearch.CurrentRow.Cells(2).Value,
                                                 ", ",
                                                 gridUserSearch.CurrentRow.Cells(1).Value)
        ucRent.tbEmailRenter.Text = gridUserSearch.CurrentRow.Cells(3).Value
        ucRent.tbPhoneRenter.Text = gridUserSearch.CurrentRow.Cells(4).Value
        ucRent.tbBalanceRenter.Text = gridUserSearch.CurrentRow.Cells(7).Value
        Me.Close()
    End Sub

    Private Sub btHeaderClose_btQuit_Click(sender As Object, e As EventArgs) Handles btHeaderClose.Click
        Me.Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Public Sub loadDataGridView()
        gridUserSearch.DataSource = EntityUser.getInstance.getUsers(mainform.labLang.Text)
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        tbSearchUser.PlaceholderText = json("SearchPlaceholder")
        gridUserSearch.Columns("code").HeaderText = json("UserGridCode")
        gridUserSearch.Columns("firstName").HeaderText = json("UserGridFirstName")
        gridUserSearch.Columns("lastName").HeaderText = json("UserGridLastName")
        gridUserSearch.Columns("email").HeaderText = json("UserGridEmail")
        gridUserSearch.Columns("phoneMain").HeaderText = json("UserGridPhoneMain")
        gridUserSearch.Columns("phone2").HeaderText = json("UserGridPhone2")
        gridUserSearch.Columns("job").HeaderText = json("UserGridJob")
        gridUserSearch.Columns("balance").HeaderText = json("UserGridBalance")
        gridUserSearch.Columns("code").Width = 70
        gridUserSearch.Columns("job").Width = 70
        gridUserSearch.Columns("balance").Width = 80
    End Sub
End Class