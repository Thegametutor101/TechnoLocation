Public Class UCEquipmentAdd
    Dim Msg As FR_CA = New FR_CA
    Dim kit As Integer = 0

    Private Sub btAddNewEquip_Click(sender As Object, e As EventArgs) Handles btAddNewEquip.Click
        Dim check As Integer = 0

        Try
            If verificationAdd() Then
                If checkAvailableEquipAdd.Checked Then
                    check = 1
                End If

                If kit = 0 Then
                    If MsgBox(Msg.getMsgKitNull, vbYesNo, Msg.getMsgWarning) = vbYes Then
                        AddToDb(check)
                    End If
                Else
                    AddToDb(check)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub btCancelNewEquip_Click(sender As Object, e As EventArgs) Handles btCancelNewEquip.Click
        MainForm.bringToFrontEquipment()
    End Sub

    Private Sub AddToDb(check As Integer)
        For index As Integer = 1 To numEquipAdd.Value
            ModelEquipment.getInstance().addEquipment(tbNameEquipmentAdd.Text, tbState.Text, check, tbComment.Text, kit)
        Next
        MsgBox(Msg.getMsgSuccessAddEquip, vbOKOnly, Msg.getMsgSuccessAddTitle)
        tbNameEquipmentAdd.Clear()
        tbComment.Clear()
        tbState.Clear()
        checkAvailableEquipAdd.Checked = True
        numEquipAdd.Value = 1
    End Sub
End Class
