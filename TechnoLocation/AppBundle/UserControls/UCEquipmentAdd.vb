Public Class UCEquipmentAdd
    Dim Msg As FR_CA = New FR_CA

    Private Sub btAddNewEquip_Click(sender As Object, e As EventArgs) Handles btAddNewEquip.Click
        verificationAdd()
    End Sub

    Private Function verificationAdd() As Boolean
        Dim complete = True
        If String.IsNullOrEmpty(Trim(tbNameEquipmentAdd.Text)) Then
            complete = False
            MsgBox(Msg.getMsgEmptyName, vbOKOnly, Msg.getMsgWarning)
        End If

        If String.IsNullOrEmpty(Trim(tbComment.Text)) And complete Then
            complete = False
            MsgBox(Msg.getMsgEmptyComment, vbOKOnly, Msg.getMsgWarning)
        End If

        If String.IsNullOrEmpty(Trim(tbState.Text)) And complete Then
            complete = False
            MsgBox(Msg.getMsgEmptyState, vbOKOnly, Msg.getMsgWarning)
        End If

        Return complete
    End Function

End Class
