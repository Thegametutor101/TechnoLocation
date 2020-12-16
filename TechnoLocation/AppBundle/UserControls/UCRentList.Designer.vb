<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCRentList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchRent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.checkSelectAll = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.gridListRent = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.gridListRent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearchRent
        '
        Me.tbSearchRent.BorderRadius = 2
        Me.tbSearchRent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearchRent.DefaultText = ""
        Me.tbSearchRent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearchRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearchRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchRent.DisabledState.Parent = Me.tbSearchRent
        Me.tbSearchRent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchRent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearchRent.FocusedState.Parent = Me.tbSearchRent
        Me.tbSearchRent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSearchRent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearchRent.HoverState.Parent = Me.tbSearchRent
        Me.tbSearchRent.Location = New System.Drawing.Point(15, 18)
        Me.tbSearchRent.Name = "tbSearchRent"
        Me.tbSearchRent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchRent.PlaceholderText = ""
        Me.tbSearchRent.SelectedText = ""
        Me.tbSearchRent.ShadowDecoration.Parent = Me.tbSearchRent
        Me.tbSearchRent.Size = New System.Drawing.Size(222, 36)
        Me.tbSearchRent.TabIndex = 0
        '
        'checkSelectAll
        '
        Me.checkSelectAll.AutoSize = True
        Me.checkSelectAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkSelectAll.CheckedState.BorderRadius = 0
        Me.checkSelectAll.CheckedState.BorderThickness = 0
        Me.checkSelectAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkSelectAll.Location = New System.Drawing.Point(15, 60)
        Me.checkSelectAll.Name = "checkSelectAll"
        Me.checkSelectAll.Size = New System.Drawing.Size(15, 14)
        Me.checkSelectAll.TabIndex = 2
        Me.checkSelectAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkSelectAll.UncheckedState.BorderRadius = 0
        Me.checkSelectAll.UncheckedState.BorderThickness = 0
        Me.checkSelectAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'gridListRent
        '
        Me.gridListRent.AllowUserToAddRows = False
        Me.gridListRent.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridListRent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridListRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridListRent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridListRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridListRent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridListRent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridListRent.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridListRent.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridListRent.EnableHeadersVisualStyles = False
        Me.gridListRent.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridListRent.Location = New System.Drawing.Point(15, 79)
        Me.gridListRent.Margin = New System.Windows.Forms.Padding(2)
        Me.gridListRent.Name = "gridListRent"
        Me.gridListRent.ReadOnly = True
        Me.gridListRent.RowHeadersVisible = False
        Me.gridListRent.RowHeadersWidth = 10
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridListRent.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gridListRent.RowTemplate.Height = 24
        Me.gridListRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridListRent.Size = New System.Drawing.Size(913, 498)
        Me.gridListRent.TabIndex = 18
        Me.gridListRent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridListRent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridListRent.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridListRent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridListRent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridListRent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridListRent.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridListRent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridListRent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridListRent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridListRent.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridListRent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridListRent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridListRent.ThemeStyle.HeaderStyle.Height = 30
        Me.gridListRent.ThemeStyle.ReadOnly = True
        Me.gridListRent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridListRent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridListRent.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridListRent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridListRent.ThemeStyle.RowsStyle.Height = 24
        Me.gridListRent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridListRent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UCRentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridListRent)
        Me.Controls.Add(Me.checkSelectAll)
        Me.Controls.Add(Me.tbSearchRent)
        Me.Name = "UCRentList"
        Me.Size = New System.Drawing.Size(947, 604)
        CType(Me.gridListRent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSearchRent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents checkSelectAll As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents gridListRent As Guna.UI2.WinForms.Guna2DataGridView
End Class
