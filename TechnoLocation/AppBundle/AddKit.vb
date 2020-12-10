Public Class AddKit

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub AddKit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNameKitAdd.Select()
        loadLanguage()
    End Sub

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

    Private Sub EnterPressed(sender As Object, e As KeyEventArgs) Handles tbNameKitAdd.KeyDown, MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            add()
        End If
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles btHeaderMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btKitCancel_Click(sender As Object, e As EventArgs) Handles btKitCancel.Click, btHeaderClose.Click
        Me.Close()
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click
        add()
    End Sub

    Private Sub add()
        If String.IsNullOrEmpty(Trim(tbNameKitAdd.Text)) Then
            MsgBox(Lang.getInstance().getLang()("MsgKitNameEmpty"),
                   vbOKOnly,
                   Lang.getInstance().getLang()("MsgWarning"))
        Else
            ModelKit.getInstance().addKit(tbNameKitAdd.Text)
            Me.Close()
        End If
    End Sub

    Private Sub loadLanguage()
        LabNameKitAdd.Text = Lang.getInstance().getLang()("AddKitLabel")
        btKitAdd.Text = Lang.getInstance().getLang()("AddItem")
        btKitCancel.Text = Lang.getInstance().getLang()("CancelButton")
    End Sub
End Class