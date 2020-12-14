Public Class ReturnEquipment

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim equipment As DataGridViewRow
    Dim collection As DataGridViewSelectedRowCollection
    Dim isFull As Boolean
    Dim user As DataRow
    Dim balance As Double
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private PanelCount As Integer = 1
    Dim basePanelItemsWidth As Integer

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, rental As Integer, item As DataGridViewRow)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        equipment = item
        isFull = False
        getUser(rental)
    End Sub
    Sub New(main As MainForm, rental As Integer, item As DataGridViewSelectedRowCollection)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        collection = item
        isFull = True
        getUser(rental)
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub ReturnEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basePanelItemsWidth = panelItems.Width - 20
        If isFull Then
            For Each item As DataGridViewRow In collection
                Dim Card As New Guna.UI2.WinForms.Guna2Panel
                With Card
                    .Size = New Size(basePanelItemsWidth, 50)
                    .BackColor = Color.White
                    .BorderColor = Color.FromArgb(1, 213, 218, 223)
                    .BorderRadius = 10
                    .Name = "Card" + PanelCount.ToString()
                End With
                createCard(item, Card)
                panelItems.Controls.Add(Card)
                PanelCount += 1
            Next
        Else
            Dim Card As New Guna.UI2.WinForms.Guna2Panel
            With Card
                .Size = New Size(basePanelItemsWidth, 50)
                .BackColor = Color.White
                .BorderColor = Color.FromArgb(1, 213, 218, 223)
                .BorderRadius = 10
                .Name = "Card" + PanelCount.ToString()
            End With
            createCard(equipment, Card)
            panelItems.Controls.Add(Card)
            PanelCount += 1
        End If
        labRequiredAction.TextAlignment = ContentAlignment.MiddleCenter
        labRequiredAction.Size = Guna2Panel2.Size
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

    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btKitCancel_Click(sender As Object, e As EventArgs) Handles btKitCancel.Click, btHeaderClose.Click
        Me.Close()
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click

    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub createCard(row As DataGridViewRow, card As Guna.UI2.WinForms.Guna2Panel)
        Dim json = Lang.getInstance().getLang()
        Dim label = New Guna.UI2.WinForms.Guna2HtmlLabel
        With label
            .AutoSize = False
            .Location = New Point(0, 0)
            .Size = New Size(basePanelItemsWidth, 50)
            .Font = New Font("Segoe UI Symbol", 11.0!)
            .ForeColor = Color.Black
            .TextAlignment = ContentAlignment.MiddleCenter
            .Name = "cardLabel" + PanelCount.ToString()
            .Text = json("MsgReturnItemDeposit1") +
                    row.Cells(5).Value +
                    json("MsgReturnItemDeposit2") +
                    row.Cells(1).Value + "."
        End With
        card.Controls.Add(label)
        Try
            adjustBalance(Replace(Replace(row.Cells(5).Value, "$ ", ""), ",", "."))
        Catch ex As Exception
            adjustBalance(Replace(row.Cells(5).Value, "$ ", ""))
        End Try
    End Sub

    Private Sub getUser(rental As Integer)
        user = EntityUser.getInstance().getUserByRental(rental).Rows(0)
        balance = user.Item(3)
    End Sub

    Private Sub adjustBalance(value As Double)
        balance += value
    End Sub

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btKitAdd.Text = json("RentalDetailsbtReturn")
        btKitCancel.Text = json("CancelButton")
        If balance > 0 Then
            labRequiredAction.Text = json("MsgCegepDette1").ToString() +
                                     Replace(("$ " + balance.ToString()), ".", ",") + vbNewLine +
                                     json("MsgCegepDette2").ToString() +
                                     user.Item(1) + ", " + user.Item(2)
        ElseIf balance < 0 Then
            labRequiredAction.Text = user.Item(1) + ", " + user.Item(2) +
                                     json("MsgStudentDette1").ToString() +
                                     Replace(Replace(("$ " + balance.ToString()), ".", ","), "-", "") + vbNewLine +
                                     json("MsgStudentDette2").ToString()
        Else
            labRequiredAction.Text = json("MsgNoDette")
        End If
    End Sub

End Class