<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labLate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkLate = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.checkAll = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gridReturn = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.gridReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.labLate)
        Me.Guna2Panel3.Controls.Add(Me.checkLate)
        Me.Guna2Panel3.Controls.Add(Me.checkAll)
        Me.Guna2Panel3.Controls.Add(Me.tbSearch)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1263, 114)
        Me.Guna2Panel3.TabIndex = 9
        '
        'labLate
        '
        Me.labLate.BackColor = System.Drawing.Color.Transparent
        Me.labLate.Location = New System.Drawing.Point(541, 28)
        Me.labLate.Name = "labLate"
        Me.labLate.Size = New System.Drawing.Size(182, 18)
        Me.labLate.TabIndex = 71
        Me.labLate.Text = "Afficher les emprunts en retard"
        '
        'checkLate
        '
        Me.checkLate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkLate.CheckedState.BorderRadius = 2
        Me.checkLate.CheckedState.BorderThickness = 2
        Me.checkLate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkLate.CheckedState.Parent = Me.checkLate
        Me.checkLate.Location = New System.Drawing.Point(515, 27)
        Me.checkLate.Name = "checkLate"
        Me.checkLate.ShadowDecoration.Parent = Me.checkLate
        Me.checkLate.Size = New System.Drawing.Size(20, 20)
        Me.checkLate.TabIndex = 70
        Me.checkLate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkLate.UncheckedState.BorderRadius = 2
        Me.checkLate.UncheckedState.BorderThickness = 2
        Me.checkLate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkLate.UncheckedState.Parent = Me.checkLate
        '
        'checkAll
        '
        Me.checkAll.CheckedState.Image = CType(resources.GetObject("checkAll.CheckedState.Image"), System.Drawing.Image)
        Me.checkAll.CheckedState.Parent = Me.checkAll
        Me.checkAll.HoverState.Parent = Me.checkAll
        Me.checkAll.Image = CType(resources.GetObject("checkAll.Image"), System.Drawing.Image)
        Me.checkAll.IndicateFocus = False
        Me.checkAll.Location = New System.Drawing.Point(60, 82)
        Me.checkAll.Name = "checkAll"
        Me.checkAll.PressedState.Parent = Me.checkAll
        Me.checkAll.Size = New System.Drawing.Size(29, 24)
        Me.checkAll.TabIndex = 50
        '
        'tbSearch
        '
        Me.tbSearch.BorderRadius = 2
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.DefaultText = ""
        Me.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.DisabledState.Parent = Me.tbSearch
        Me.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.FocusedState.Parent = Me.tbSearch
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.HoverState.Parent = Me.tbSearch
        Me.tbSearch.Location = New System.Drawing.Point(29, 18)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = "Recherche"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.ShadowDecoration.Parent = Me.tbSearch
        Me.tbSearch.Size = New System.Drawing.Size(457, 36)
        Me.tbSearch.TabIndex = 48
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 114)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(60, 630)
        Me.Guna2Panel1.TabIndex = 14
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(1203, 114)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(60, 630)
        Me.Guna2CustomGradientPanel1.TabIndex = 15
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(60, 684)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1143, 60)
        Me.Guna2Panel2.TabIndex = 18
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.gridReturn)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(60, 114)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1143, 570)
        Me.Guna2Panel4.TabIndex = 19
        '
        'gridReturn
        '
        Me.gridReturn.AllowUserToAddRows = False
        Me.gridReturn.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridReturn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridReturn.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridReturn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridReturn.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridReturn.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridReturn.EnableHeadersVisualStyles = False
        Me.gridReturn.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridReturn.Location = New System.Drawing.Point(0, 0)
        Me.gridReturn.Name = "gridReturn"
        Me.gridReturn.ReadOnly = True
        Me.gridReturn.RowHeadersVisible = False
        Me.gridReturn.RowHeadersWidth = 10
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridReturn.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gridReturn.RowTemplate.Height = 24
        Me.gridReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridReturn.Size = New System.Drawing.Size(1143, 570)
        Me.gridReturn.TabIndex = 39
        Me.gridReturn.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridReturn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridReturn.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridReturn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridReturn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridReturn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridReturn.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridReturn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridReturn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridReturn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridReturn.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridReturn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridReturn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridReturn.ThemeStyle.HeaderStyle.Height = 30
        Me.gridReturn.ThemeStyle.ReadOnly = True
        Me.gridReturn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridReturn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridReturn.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridReturn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridReturn.ThemeStyle.RowsStyle.Height = 24
        Me.gridReturn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridReturn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UCReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCReturn"
        Me.Size = New System.Drawing.Size(1263, 744)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.gridReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents checkAll As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gridReturn As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents labLate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkLate As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
