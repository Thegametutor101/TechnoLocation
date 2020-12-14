Public Class PromptReturnEquipmentComment

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As New MainForm(0)
    Dim returnEquipment As New ReturnEquipment(New MainForm(0),
                                               0,
                                               New DataGridViewRow())
    Dim equipment As DataGridViewRow
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Sub New(main As MainForm, returnForm As ReturnEquipment, equip As DataGridViewRow)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        returnEquipment = returnForm
        equipment = equip
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub PromptReturnEquipmentComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Me.Location.X + 60, Me.Location.Y + 30)
        checkAvailable.Checked = True
        returnEquipment.newComment = "no"
        labMessage.AutoSize = False
        labMessage.Location = New Point(0, 0)
        labMessage.TextAlignment = ContentAlignment.MiddleCenter
        labMessage.Font = New Font("Segoe UI Symbol", 11.0!)
        labMessage.Size = New Size(Guna2Panel1.Width, 75)
        tbComment.Text = EntityEquipment.getInstance().getEquipmentByCode(equipment.Cells(0).Value).Rows(0).Item(5)
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

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click
        returnEquipment.newComment = tbComment.Text
        If checkAvailable.Checked Then
            returnEquipment.isAvailable = 1
        Else
            returnEquipment.isAvailable = 0
        End If
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


    Private Sub loadLanguages()
        Dim json = Lang.getInstance().getLang()
        btKitAdd.Text = json("Submit")
        labMessage.Text = json("MsgChangeComment").ToString() + equipment.Cells(1).Value
        labAvailable.Text = json("labSetAsAvailable")
    End Sub

End Class