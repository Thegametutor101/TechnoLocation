Public Class PromptReturnAmount


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim returnEquipment As New ReturnEquipment(New MainForm(0),
                                               0,
                                               New DataGridViewRow())
    Dim isStudentDept As Boolean
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, returnForm As ReturnEquipment, studentDept As Boolean)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        returnEquipment = returnForm
        isStudentDept = studentDept
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub PromptReturnAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Me.Location.X + 60, Me.Location.Y + 30)
        labMessage.AutoSize = False
        labMessage.Location = New Point(0, 0)
        labMessage.TextAlignment = ContentAlignment.MiddleCenter
        labMessage.Font = New Font("Segoe UI Symbol", 11.0!)
        labMessage.Size = New Size(Guna2Panel1.Width, 75)
        numValue.Value = Math.Abs(returnEquipment.balance)
        numValue.Minimum = 0
        numValue.Maximum = Math.Abs(returnEquipment.balance)
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
        returnEquipment.Close()
        Me.Close()
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click
        returnEquipment.returnValue = numValue.Value
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________

    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btKitAdd.Text = json("Submit")
        btKitCancel.Text = json("CancelButton")
        labMessage.Text = json("MsgPromptReturn1").ToString() +
                          Replace(Replace(("$ " + returnEquipment.balance.ToString()),
                                                    ".",
                                                    ","),
                                            "-",
                                            "") +
                          json("MsgPromptReturn2").ToString()
    End Sub

    Private Sub panelHeaderBar_Paint(sender As Object, e As PaintEventArgs) Handles panelHeaderBar.Paint

    End Sub
End Class