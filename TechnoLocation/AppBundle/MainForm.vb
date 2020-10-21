Public Class MainForm
    Dim Msg As FR_CA = New FR_CA

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim dashboard As New UCDashboard()
        dashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(dashboard)
        dashboard.BringToFront()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Dim iDashboard As New UCDashboard()
        iDashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(iDashboard)
        iDashboard.BringToFront()
    End Sub

    Private Sub btAlert_Click(sender As Object, e As EventArgs) Handles btAlert.Click

    End Sub

    Private Sub btBorrow_Click(sender As Object, e As EventArgs) Handles btBorrow.Click
        Dim iRent As New UCRent()
        iRent.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRent)
        iRent.BringToFront()
    End Sub

    Private Sub btReturn_Click(sender As Object, e As EventArgs) Handles btReturn.Click
        Dim iReturn As New UCReturn()
        iReturn.Dock = DockStyle.Fill
        p_Main.Controls.Add(iReturn)
        iReturn.BringToFront()
    End Sub

    Private Sub btUser_Click(sender As Object, e As EventArgs) Handles btUser.Click
        Dim iUser As New UCUser()
        iUser.Dock = DockStyle.Fill
        p_Main.Controls.Add(iUser)
        iUser.BringToFront()
    End Sub

    Private Sub btEquipment_Click(sender As Object, e As EventArgs) Handles btEquipment.Click
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        p_Main.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub

    Private Sub btHistory_Click(sender As Object, e As EventArgs) Handles btHistory.Click
        Dim iHistory As New UCHistory()
        iHistory.Dock = DockStyle.Fill
        p_Main.Controls.Add(iHistory)
        iHistory.BringToFront()
    End Sub

    Private Sub btCalendar_Click(sender As Object, e As EventArgs) Handles btCalendar.Click
        Dim iRestriction As New UCRestriction()
        iRestriction.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRestriction)
        iRestriction.BringToFront()
    End Sub

    Private Sub btQuit_Click(sender As Object, e As EventArgs) Handles btQuit.Click
        Dim style = vbYesNo + vbDefaultButton2
        Dim response = MsgBox(Msg.getMsgQuit, style, Msg.getMsgQuitTitle)

        If response = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btDisconnection_Click(sender As Object, e As EventArgs) Handles btDisconnection.Click
        Dim style = vbYesNo + vbDefaultButton2
        Dim response = MsgBox(Msg.getMsgDisconnection, style, Msg.getMsgDisconnecTitle)

        If response = vbYes Then
            Connection.Show()
            Me.Close()
        End If
    End Sub
End Class
