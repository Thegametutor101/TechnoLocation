Public Class Connection
    Dim Msg As FR_CA = New FR_CA
    Private Sub btQuitConnection_Click(sender As Object, e As EventArgs) Handles btQuitConnection.Click
        Dim style = vbYesNo + vbDefaultButton2
        Dim response = MsgBox(Msg.getMsgQuit, style, Msg.getMsgQuitTitle)

        If response = vbYes Then
            Close()
        End If
    End Sub

    Private Sub btConnection_Click(sender As Object, e As EventArgs) Handles btConnection.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class