<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btDeleteUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbUserSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.checkUser = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gridUser = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btDeleteUser)
        Me.Guna2Panel1.Controls.Add(Me.btAddUser)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1263, 100)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btDeleteUser
        '
        Me.btDeleteUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btDeleteUser.BorderRadius = 15
        Me.btDeleteUser.BorderThickness = 2
        Me.btDeleteUser.CheckedState.Parent = Me.btDeleteUser
        Me.btDeleteUser.CustomImages.Parent = Me.btDeleteUser
        Me.btDeleteUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btDeleteUser.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btDeleteUser.ForeColor = System.Drawing.Color.Black
        Me.btDeleteUser.HoverState.Parent = Me.btDeleteUser
        Me.btDeleteUser.Location = New System.Drawing.Point(239, 10)
        Me.btDeleteUser.Name = "btDeleteUser"
        Me.btDeleteUser.ShadowDecoration.Parent = Me.btDeleteUser
        Me.btDeleteUser.Size = New System.Drawing.Size(184, 80)
        Me.btDeleteUser.TabIndex = 18
        Me.btDeleteUser.Text = "Supprimer"
        '
        'btAddUser
        '
        Me.btAddUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btAddUser.BorderRadius = 15
        Me.btAddUser.BorderThickness = 2
        Me.btAddUser.CheckedState.Parent = Me.btAddUser
        Me.btAddUser.CustomImages.Parent = Me.btAddUser
        Me.btAddUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btAddUser.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btAddUser.ForeColor = System.Drawing.Color.Black
        Me.btAddUser.HoverState.Parent = Me.btAddUser
        Me.btAddUser.Location = New System.Drawing.Point(24, 10)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.ShadowDecoration.Parent = Me.btAddUser
        Me.btAddUser.Size = New System.Drawing.Size(184, 80)
        Me.btAddUser.TabIndex = 17
        Me.btAddUser.Text = "Nouveau"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.tbUserSearch)
        Me.Guna2Panel2.Controls.Add(Me.checkUser)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1263, 80)
        Me.Guna2Panel2.TabIndex = 1
        '
        'tbUserSearch
        '
        Me.tbUserSearch.BorderRadius = 2
        Me.tbUserSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUserSearch.DefaultText = ""
        Me.tbUserSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUserSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUserSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUserSearch.DisabledState.Parent = Me.tbUserSearch
        Me.tbUserSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUserSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUserSearch.FocusedState.Parent = Me.tbUserSearch
        Me.tbUserSearch.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.tbUserSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUserSearch.HoverState.Parent = Me.tbUserSearch
        Me.tbUserSearch.Location = New System.Drawing.Point(24, 7)
        Me.tbUserSearch.Name = "tbUserSearch"
        Me.tbUserSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUserSearch.PlaceholderText = "Recherche"
        Me.tbUserSearch.SelectedText = ""
        Me.tbUserSearch.ShadowDecoration.Parent = Me.tbUserSearch
        Me.tbUserSearch.Size = New System.Drawing.Size(472, 36)
        Me.tbUserSearch.TabIndex = 24
        '
        'checkUser
        '
        Me.checkUser.CheckedState.Image = CType(resources.GetObject("checkUser.CheckedState.Image"), System.Drawing.Image)
        Me.checkUser.CheckedState.Parent = Me.checkUser
        Me.checkUser.HoverState.Parent = Me.checkUser
        Me.checkUser.Image = CType(resources.GetObject("checkUser.Image"), System.Drawing.Image)
        Me.checkUser.IndicateFocus = False
        Me.checkUser.Location = New System.Drawing.Point(60, 53)
        Me.checkUser.Name = "checkUser"
        Me.checkUser.PressedState.Parent = Me.checkUser
        Me.checkUser.Size = New System.Drawing.Size(29, 24)
        Me.checkUser.TabIndex = 23
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 180)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(60, 563)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel4.Location = New System.Drawing.Point(1203, 180)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(60, 563)
        Me.Guna2Panel4.TabIndex = 3
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(60, 683)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(1143, 60)
        Me.Guna2Panel5.TabIndex = 4
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.gridUser)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(60, 180)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(1143, 503)
        Me.Guna2Panel6.TabIndex = 5
        '
        'gridUser
        '
        Me.gridUser.AllowUserToAddRows = False
        Me.gridUser.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridUser.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridUser.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUser.EnableHeadersVisualStyles = False
        Me.gridUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridUser.Location = New System.Drawing.Point(0, 0)
        Me.gridUser.Name = "gridUser"
        Me.gridUser.ReadOnly = True
        Me.gridUser.RowHeadersVisible = False
        Me.gridUser.RowHeadersWidth = 10
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUser.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gridUser.RowTemplate.Height = 24
        Me.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridUser.Size = New System.Drawing.Size(1143, 503)
        Me.gridUser.TabIndex = 17
        Me.gridUser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridUser.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridUser.ThemeStyle.HeaderStyle.Height = 30
        Me.gridUser.ThemeStyle.ReadOnly = True
        Me.gridUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridUser.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridUser.ThemeStyle.RowsStyle.Height = 24
        Me.gridUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UCUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UCUser"
        Me.Size = New System.Drawing.Size(1263, 743)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents checkUser As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gridUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btDeleteUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbUserSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
