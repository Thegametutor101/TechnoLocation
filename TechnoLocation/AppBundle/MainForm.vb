﻿Public Class MainForm
    Private Sub p_Main_Paint(sender As Object, e As PaintEventArgs) Handles p_Main.Paint

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim dashboard As New UCDashboard()
        dashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(dashboard)
        dashboard.BringToFront()
    End Sub

    Private Sub bt_home_Click(sender As Object, e As EventArgs) Handles bt_home.Click
        Dim iDashboard As New UCDashboard()
        iDashboard.Dock = DockStyle.Fill
        p_Main.Controls.Add(iDashboard)
        iDashboard.BringToFront()
    End Sub

    Private Sub bt_alert_Click(sender As Object, e As EventArgs) Handles bt_alert.Click

    End Sub

    Private Sub bt_borrow_Click(sender As Object, e As EventArgs) Handles bt_borrow.Click
        Dim iRent As New UCRent()
        iRent.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRent)
        iRent.BringToFront()
    End Sub

    Private Sub bt_return_Click(sender As Object, e As EventArgs) Handles bt_return.Click
        Dim iReturn As New UCReturn()
        iReturn.Dock = DockStyle.Fill
        p_Main.Controls.Add(iReturn)
        iReturn.BringToFront()
    End Sub

    Private Sub bt_user_Click(sender As Object, e As EventArgs) Handles bt_user.Click
        Dim iUser As New UCUser()
        iUser.Dock = DockStyle.Fill
        p_Main.Controls.Add(iUser)
        iUser.BringToFront()
    End Sub

    Private Sub bt_equipment_Click(sender As Object, e As EventArgs) Handles bt_equipment.Click
        Dim iEquipment As New UCEquipment()
        iEquipment.Dock = DockStyle.Fill
        p_Main.Controls.Add(iEquipment)
        iEquipment.BringToFront()
    End Sub

    Private Sub bt_history_Click(sender As Object, e As EventArgs) Handles bt_history.Click
        Dim iHistory As New UCHistory()
        iHistory.Dock = DockStyle.Fill
        p_Main.Controls.Add(iHistory)
        iHistory.BringToFront()
    End Sub

    Private Sub bt_calendar_Click(sender As Object, e As EventArgs) Handles bt_calendar.Click
        Dim iRestriction As New UCRestriction()
        iRestriction.Dock = DockStyle.Fill
        p_Main.Controls.Add(iRestriction)
        iRestriction.BringToFront()
    End Sub

    Private Sub bt_quit_Click(sender As Object, e As EventArgs) Handles bt_quit.Click
        If MessageBox.Show($"Voulez-vous vraiment quitter le gestionnaire?{Environment.NewLine}Tous vos changement non sauvegardés seront supprimés.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
