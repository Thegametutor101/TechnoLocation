Public Class AddKit

    Private Sub btKitCancel_Click(sender As Object, e As EventArgs) Handles btKitCancel.Click
        Me.Close()
    End Sub

    Private Sub btKitAdd_Click(sender As Object, e As EventArgs) Handles btKitAdd.Click
        If Not String.IsNullOrEmpty(Trim(tbNameKitAdd.Text)) Then
            ModelKit.getInstance().addKit(tbNameKitAdd.Text)
            Me.Close()
        Else
            'MsgBox(Msg.getMsgKitNameEmpty, vbOKOnly, Msg.getMsgWarning)
        End If
    End Sub
End Class