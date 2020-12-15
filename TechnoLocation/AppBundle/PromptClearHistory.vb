Public Class PromptClearHistory


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim history As New UCHistory(New MainForm(0))
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, his As UCHistory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        history = his
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        history.action = False
        dateDelete.Value = Today
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

    Private Sub checkDeleteAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkDeleteAll.CheckedChanged
        If checkDeleteAll.Checked Then
            dateDelete.Enabled = False
        Else
            dateDelete.Enabled = True
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

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Dim json = Lang.getInstance().getLang()
        If checkDeleteAll.Checked Then
            Dim title As String = json("MsgWarning")
            Dim message As String = json("PromptClearHistory2CheckedDeleteAll")
            If MessageBox.Show(Message,
                               title,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                ModelHistory.getInstance().removeAllHistory()
            End If
        Else
            Dim title As String = json("MsgWarning")
            Dim message As String = json("PromptClearHistory2BeforeMessage1").ToString() +
                                    dateDelete.Value +
                                    json("PromptClearHistory2BeforeMessage2").ToString()
            If MessageBox.Show(message,
                               title,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning) = DialogResult.Yes Then
                ModelHistory.getInstance().removeHistoryBeforeDate(dateDelete.Value)
            End If
        End If
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click,
                                                                            btHeaderClose.Click, btCancel.Click
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btSubmit.Text = json("Submit")
        btCancel.Text = json("CancelButton")
        labMessage.Text = json("PromptClearHistory2LabMessage")
        labDeleteAll.Text = json("PromptClearHistory2LabCheck")
    End Sub

End Class