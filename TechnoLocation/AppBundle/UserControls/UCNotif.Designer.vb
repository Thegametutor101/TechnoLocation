<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCNotif
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbNotifs = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labDeposit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labRentDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labNbr = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbDepositAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbRentDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEquipNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbNotifs
        '
        Me.cbNotifs.BackColor = System.Drawing.Color.Transparent
        Me.cbNotifs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbNotifs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNotifs.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbNotifs.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbNotifs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbNotifs.FocusedState.Parent = Me.cbNotifs
        Me.cbNotifs.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbNotifs.ForeColor = System.Drawing.Color.White
        Me.cbNotifs.HoverState.Parent = Me.cbNotifs
        Me.cbNotifs.ItemHeight = 30
        Me.cbNotifs.ItemsAppearance.Parent = Me.cbNotifs
        Me.cbNotifs.Location = New System.Drawing.Point(3, 20)
        Me.cbNotifs.Name = "cbNotifs"
        Me.cbNotifs.ShadowDecoration.Parent = Me.cbNotifs
        Me.cbNotifs.Size = New System.Drawing.Size(243, 36)
        Me.cbNotifs.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.labDeposit)
        Me.Guna2Panel1.Controls.Add(Me.labRentDate)
        Me.Guna2Panel1.Controls.Add(Me.labNbr)
        Me.Guna2Panel1.Controls.Add(Me.tbDepositAmount)
        Me.Guna2Panel1.Controls.Add(Me.tbRentDate)
        Me.Guna2Panel1.Controls.Add(Me.tbEquipNum)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 82)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(243, 224)
        Me.Guna2Panel1.TabIndex = 1
        '
        'labDeposit
        '
        Me.labDeposit.BackColor = System.Drawing.Color.Transparent
        Me.labDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDeposit.ForeColor = System.Drawing.Color.White
        Me.labDeposit.Location = New System.Drawing.Point(4, 164)
        Me.labDeposit.Name = "labDeposit"
        Me.labDeposit.Size = New System.Drawing.Size(58, 20)
        Me.labDeposit.TabIndex = 5
        Me.labDeposit.Text = "deposit"
        '
        'labRentDate
        '
        Me.labRentDate.BackColor = System.Drawing.Color.Transparent
        Me.labRentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRentDate.ForeColor = System.Drawing.Color.White
        Me.labRentDate.Location = New System.Drawing.Point(4, 89)
        Me.labRentDate.Name = "labRentDate"
        Me.labRentDate.Size = New System.Drawing.Size(35, 20)
        Me.labRentDate.TabIndex = 4
        Me.labRentDate.Text = "date"
        '
        'labNbr
        '
        Me.labNbr.BackColor = System.Drawing.Color.Transparent
        Me.labNbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNbr.ForeColor = System.Drawing.Color.White
        Me.labNbr.Location = New System.Drawing.Point(4, 16)
        Me.labNbr.Name = "labNbr"
        Me.labNbr.Size = New System.Drawing.Size(27, 20)
        Me.labNbr.TabIndex = 3
        Me.labNbr.Text = "nbr"
        '
        'tbDepositAmount
        '
        Me.tbDepositAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDepositAmount.DefaultText = ""
        Me.tbDepositAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDepositAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDepositAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDepositAmount.DisabledState.Parent = Me.tbDepositAmount
        Me.tbDepositAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDepositAmount.Enabled = False
        Me.tbDepositAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDepositAmount.FocusedState.Parent = Me.tbDepositAmount
        Me.tbDepositAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbDepositAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDepositAmount.HoverState.Parent = Me.tbDepositAmount
        Me.tbDepositAmount.Location = New System.Drawing.Point(0, 185)
        Me.tbDepositAmount.Name = "tbDepositAmount"
        Me.tbDepositAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDepositAmount.PlaceholderText = ""
        Me.tbDepositAmount.SelectedText = ""
        Me.tbDepositAmount.ShadowDecoration.Parent = Me.tbDepositAmount
        Me.tbDepositAmount.Size = New System.Drawing.Size(240, 36)
        Me.tbDepositAmount.TabIndex = 2
        '
        'tbRentDate
        '
        Me.tbRentDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRentDate.DefaultText = ""
        Me.tbRentDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRentDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRentDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRentDate.DisabledState.Parent = Me.tbRentDate
        Me.tbRentDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRentDate.Enabled = False
        Me.tbRentDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRentDate.FocusedState.Parent = Me.tbRentDate
        Me.tbRentDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbRentDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRentDate.HoverState.Parent = Me.tbRentDate
        Me.tbRentDate.Location = New System.Drawing.Point(0, 110)
        Me.tbRentDate.Name = "tbRentDate"
        Me.tbRentDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRentDate.PlaceholderText = ""
        Me.tbRentDate.SelectedText = ""
        Me.tbRentDate.ShadowDecoration.Parent = Me.tbRentDate
        Me.tbRentDate.Size = New System.Drawing.Size(240, 36)
        Me.tbRentDate.TabIndex = 1
        '
        'tbEquipNum
        '
        Me.tbEquipNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEquipNum.DefaultText = ""
        Me.tbEquipNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEquipNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEquipNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEquipNum.DisabledState.Parent = Me.tbEquipNum
        Me.tbEquipNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEquipNum.Enabled = False
        Me.tbEquipNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEquipNum.FocusedState.Parent = Me.tbEquipNum
        Me.tbEquipNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbEquipNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEquipNum.HoverState.Parent = Me.tbEquipNum
        Me.tbEquipNum.Location = New System.Drawing.Point(0, 37)
        Me.tbEquipNum.Name = "tbEquipNum"
        Me.tbEquipNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEquipNum.PlaceholderText = ""
        Me.tbEquipNum.SelectedText = ""
        Me.tbEquipNum.ShadowDecoration.Parent = Me.tbEquipNum
        Me.tbEquipNum.Size = New System.Drawing.Size(240, 36)
        Me.tbEquipNum.TabIndex = 0
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.cbNotifs)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 3)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2ShadowPanel1.ShadowDepth = 200
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(253, 323)
        Me.Guna2ShadowPanel1.TabIndex = 2
        '
        'UCNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Name = "UCNotif"
        Me.Size = New System.Drawing.Size(255, 329)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbNotifs As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbDepositAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbRentDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEquipNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents labDeposit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labRentDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labNbr As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
