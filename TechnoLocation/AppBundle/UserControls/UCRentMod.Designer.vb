<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRentMod
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbBalanceRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPhoneRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEmailRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNameRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCodeRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btAddUser = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'tbBalanceRenter
        '
        Me.tbBalanceRenter.BorderRadius = 2
        Me.tbBalanceRenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbBalanceRenter.DefaultText = ""
        Me.tbBalanceRenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbBalanceRenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbBalanceRenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbBalanceRenter.DisabledState.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbBalanceRenter.Enabled = False
        Me.tbBalanceRenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBalanceRenter.FocusedState.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbBalanceRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBalanceRenter.HoverState.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.Location = New System.Drawing.Point(38, 279)
        Me.tbBalanceRenter.Name = "tbBalanceRenter"
        Me.tbBalanceRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbBalanceRenter.PlaceholderText = ""
        Me.tbBalanceRenter.ReadOnly = True
        Me.tbBalanceRenter.SelectedText = ""
        Me.tbBalanceRenter.ShadowDecoration.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbBalanceRenter.TabIndex = 64
        '
        'tbPhoneRenter
        '
        Me.tbPhoneRenter.BorderRadius = 2
        Me.tbPhoneRenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPhoneRenter.DefaultText = ""
        Me.tbPhoneRenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPhoneRenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPhoneRenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhoneRenter.DisabledState.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhoneRenter.Enabled = False
        Me.tbPhoneRenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhoneRenter.FocusedState.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPhoneRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhoneRenter.HoverState.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.Location = New System.Drawing.Point(38, 237)
        Me.tbPhoneRenter.Name = "tbPhoneRenter"
        Me.tbPhoneRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPhoneRenter.PlaceholderText = ""
        Me.tbPhoneRenter.ReadOnly = True
        Me.tbPhoneRenter.SelectedText = ""
        Me.tbPhoneRenter.ShadowDecoration.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbPhoneRenter.TabIndex = 63
        '
        'tbEmailRenter
        '
        Me.tbEmailRenter.BorderRadius = 2
        Me.tbEmailRenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmailRenter.DefaultText = ""
        Me.tbEmailRenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmailRenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmailRenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmailRenter.DisabledState.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmailRenter.Enabled = False
        Me.tbEmailRenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmailRenter.FocusedState.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbEmailRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmailRenter.HoverState.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.Location = New System.Drawing.Point(38, 195)
        Me.tbEmailRenter.Name = "tbEmailRenter"
        Me.tbEmailRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmailRenter.PlaceholderText = ""
        Me.tbEmailRenter.ReadOnly = True
        Me.tbEmailRenter.SelectedText = ""
        Me.tbEmailRenter.ShadowDecoration.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbEmailRenter.TabIndex = 62
        '
        'tbNameRenter
        '
        Me.tbNameRenter.BorderRadius = 2
        Me.tbNameRenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNameRenter.DefaultText = ""
        Me.tbNameRenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNameRenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNameRenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNameRenter.DisabledState.Parent = Me.tbNameRenter
        Me.tbNameRenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNameRenter.Enabled = False
        Me.tbNameRenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNameRenter.FocusedState.Parent = Me.tbNameRenter
        Me.tbNameRenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbNameRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNameRenter.HoverState.Parent = Me.tbNameRenter
        Me.tbNameRenter.Location = New System.Drawing.Point(38, 153)
        Me.tbNameRenter.Name = "tbNameRenter"
        Me.tbNameRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNameRenter.PlaceholderText = ""
        Me.tbNameRenter.ReadOnly = True
        Me.tbNameRenter.SelectedText = ""
        Me.tbNameRenter.ShadowDecoration.Parent = Me.tbNameRenter
        Me.tbNameRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbNameRenter.TabIndex = 61
        '
        'tbCodeRenter
        '
        Me.tbCodeRenter.BorderRadius = 2
        Me.tbCodeRenter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCodeRenter.DefaultText = ""
        Me.tbCodeRenter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCodeRenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCodeRenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCodeRenter.DisabledState.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCodeRenter.Enabled = False
        Me.tbCodeRenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCodeRenter.FocusedState.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbCodeRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCodeRenter.HoverState.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.Location = New System.Drawing.Point(38, 111)
        Me.tbCodeRenter.Name = "tbCodeRenter"
        Me.tbCodeRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCodeRenter.PlaceholderText = ""
        Me.tbCodeRenter.ReadOnly = True
        Me.tbCodeRenter.SelectedText = ""
        Me.tbCodeRenter.ShadowDecoration.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbCodeRenter.TabIndex = 60
        '
        'btAddUser
        '
        Me.btAddUser.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btAddUser.CheckedState.Parent = Me.btAddUser
        Me.btAddUser.HoverState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_person_black_18dp
        Me.btAddUser.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btAddUser.HoverState.Parent = Me.btAddUser
        Me.btAddUser.Image = Global.TechnoLocation.My.Resources.Resources.baseline_person_black_18dp
        Me.btAddUser.ImageRotate = 0!
        Me.btAddUser.ImageSize = New System.Drawing.Size(30, 30)
        Me.btAddUser.Location = New System.Drawing.Point(38, 72)
        Me.btAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_person_black_18dp
        Me.btAddUser.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btAddUser.PressedState.Parent = Me.btAddUser
        Me.btAddUser.Size = New System.Drawing.Size(32, 34)
        Me.btAddUser.TabIndex = 65
        '
        'UCRentMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btAddUser)
        Me.Controls.Add(Me.tbBalanceRenter)
        Me.Controls.Add(Me.tbPhoneRenter)
        Me.Controls.Add(Me.tbEmailRenter)
        Me.Controls.Add(Me.tbNameRenter)
        Me.Controls.Add(Me.tbCodeRenter)
        Me.Name = "UCRentMod"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbBalanceRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPhoneRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEmailRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNameRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCodeRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btAddUser As Guna.UI2.WinForms.Guna2ImageButton
End Class
