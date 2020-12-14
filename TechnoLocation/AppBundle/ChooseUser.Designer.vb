<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseUser
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSearchUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gridUserSearch = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearchUser
        '
        Me.tbSearchUser.BorderRadius = 2
        Me.tbSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearchUser.DefaultText = ""
        Me.tbSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchUser.DisabledState.Parent = Me.tbSearchUser
        Me.tbSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearchUser.FocusedState.Parent = Me.tbSearchUser
        Me.tbSearchUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearchUser.HoverState.Parent = Me.tbSearchUser
        Me.tbSearchUser.Location = New System.Drawing.Point(12, 12)
        Me.tbSearchUser.Name = "tbSearchUser"
        Me.tbSearchUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchUser.PlaceholderText = ""
        Me.tbSearchUser.SelectedText = ""
        Me.tbSearchUser.ShadowDecoration.Parent = Me.tbSearchUser
        Me.tbSearchUser.Size = New System.Drawing.Size(240, 36)
        Me.tbSearchUser.TabIndex = 0
        '
        'gridUserSearch
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gridUserSearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridUserSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridUserSearch.BackgroundColor = System.Drawing.Color.White
        Me.gridUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridUserSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridUserSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUserSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridUserSearch.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridUserSearch.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridUserSearch.EnableHeadersVisualStyles = False
        Me.gridUserSearch.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUserSearch.Location = New System.Drawing.Point(12, 54)
        Me.gridUserSearch.Name = "gridUserSearch"
        Me.gridUserSearch.RowHeadersVisible = False
        Me.gridUserSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridUserSearch.Size = New System.Drawing.Size(834, 439)
        Me.gridUserSearch.TabIndex = 1
        Me.gridUserSearch.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridUserSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridUserSearch.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridUserSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridUserSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridUserSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridUserSearch.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gridUserSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUserSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUserSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gridUserSearch.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridUserSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridUserSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridUserSearch.ThemeStyle.HeaderStyle.Height = 4
        Me.gridUserSearch.ThemeStyle.ReadOnly = False
        Me.gridUserSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridUserSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridUserSearch.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridUserSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridUserSearch.ThemeStyle.RowsStyle.Height = 22
        Me.gridUserSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridUserSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ChooseUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 513)
        Me.Controls.Add(Me.gridUserSearch)
        Me.Controls.Add(Me.tbSearchUser)
        Me.Name = "ChooseUser"
        Me.Text = "ChooseUser"
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbSearchUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gridUserSearch As Guna.UI2.WinForms.Guna2DataGridView
End Class
