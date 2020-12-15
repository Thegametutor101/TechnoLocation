Public Class PromptClearHistoryOptions


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim history As New UCHistory(New MainForm(0))
    Dim rows As DataGridViewSelectedRowCollection
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, his As UCHistory, data As DataGridViewSelectedRowCollection)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        history = his
        rows = data
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        history.action = False
        labMessage.AutoSize = False
        labMessage.Location = New Point(0, 0)
        labMessage.TextAlignment = ContentAlignment.MiddleCenter
        labMessage.Font = New Font("Segoe UI Symbol", 11.0!)
        labMessage.Size = New Size(Guna2Panel1.Width, 75)
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

    Private Sub btSelected_Click(sender As Object, e As EventArgs) Handles btSelected.Click
        Dim title As String = Lang.getInstance().getLang()("MsgWarning")
        Dim message As String = Lang.getInstance().getLang()("PromptClearHistory1SelectedConfirm1").ToString() +
                                rows.Count.ToString() +
                                Lang.getInstance().getLang()("PromptClearHistory1SelectedConfirm2").ToString()
        If MessageBox.Show(message,
                           title,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each row As DataGridViewRow In rows
                ModelHistory.getInstance().removeHistory(row.Cells(0).Value)
            Next
        End If
        Me.Close()
    End Sub

    Private Sub btMore_Click(sender As Object, e As EventArgs) Handles btMore.Click
        Dim clear = New PromptClearHistory(mainForm, history)
        clear.ShowDialog()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btSelected.Text = json("PromptClearHistory1Selected")
        btMore.Text = json("PromptClearHistory1More")
        btCancel.Text = json("CancelButton")
        labMessage.Text = json("PromptClearHistory1Message")
    End Sub

End Class