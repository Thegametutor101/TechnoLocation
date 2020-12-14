<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCEquipment))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btPrintBarcodeEquip = New Guna.UI2.WinForms.Guna2Button()
        Me.btDelEquipment = New Guna.UI2.WinForms.Guna2Button()
        Me.btNewEquipment = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labAvailableOnlyName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkSelectAllEquipment = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.checkAvailableEquip = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.gridEquipment = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btPrintBarcodeEquip)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btDelEquipment)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btNewEquipment)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(947, 81)
        Me.Guna2CustomGradientPanel1.TabIndex = 11
        '
        'btPrintBarcodeEquip
        '
        Me.btPrintBarcodeEquip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btPrintBarcodeEquip.BorderRadius = 15
        Me.btPrintBarcodeEquip.BorderThickness = 2
        Me.btPrintBarcodeEquip.CheckedState.Parent = Me.btPrintBarcodeEquip
        Me.btPrintBarcodeEquip.CustomImages.Parent = Me.btPrintBarcodeEquip
        Me.btPrintBarcodeEquip.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btPrintBarcodeEquip.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btPrintBarcodeEquip.ForeColor = System.Drawing.Color.Black
        Me.btPrintBarcodeEquip.HoverState.Parent = Me.btPrintBarcodeEquip
        Me.btPrintBarcodeEquip.Location = New System.Drawing.Point(340, 8)
        Me.btPrintBarcodeEquip.Margin = New System.Windows.Forms.Padding(2)
        Me.btPrintBarcodeEquip.Name = "btPrintBarcodeEquip"
        Me.btPrintBarcodeEquip.ShadowDecoration.Parent = Me.btPrintBarcodeEquip
        Me.btPrintBarcodeEquip.Size = New System.Drawing.Size(224, 65)
        Me.btPrintBarcodeEquip.TabIndex = 2
        Me.btPrintBarcodeEquip.Text = "Imprimer codes barres"
        '
        'btDelEquipment
        '
        Me.btDelEquipment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btDelEquipment.BorderRadius = 15
        Me.btDelEquipment.BorderThickness = 2
        Me.btDelEquipment.CheckedState.Parent = Me.btDelEquipment
        Me.btDelEquipment.CustomImages.Parent = Me.btDelEquipment
        Me.btDelEquipment.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btDelEquipment.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btDelEquipment.ForeColor = System.Drawing.Color.Black
        Me.btDelEquipment.HoverState.Parent = Me.btDelEquipment
        Me.btDelEquipment.Location = New System.Drawing.Point(179, 8)
        Me.btDelEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.btDelEquipment.Name = "btDelEquipment"
        Me.btDelEquipment.ShadowDecoration.Parent = Me.btDelEquipment
        Me.btDelEquipment.Size = New System.Drawing.Size(138, 65)
        Me.btDelEquipment.TabIndex = 1
        Me.btDelEquipment.Text = "Supprimer"
        '
        'btNewEquipment
        '
        Me.btNewEquipment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btNewEquipment.BorderRadius = 15
        Me.btNewEquipment.BorderThickness = 2
        Me.btNewEquipment.CheckedState.Parent = Me.btNewEquipment
        Me.btNewEquipment.CustomImages.Parent = Me.btNewEquipment
        Me.btNewEquipment.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btNewEquipment.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btNewEquipment.ForeColor = System.Drawing.Color.Black
        Me.btNewEquipment.HoverState.Parent = Me.btNewEquipment
        Me.btNewEquipment.Location = New System.Drawing.Point(18, 8)
        Me.btNewEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.btNewEquipment.Name = "btNewEquipment"
        Me.btNewEquipment.ShadowDecoration.Parent = Me.btNewEquipment
        Me.btNewEquipment.Size = New System.Drawing.Size(138, 65)
        Me.btNewEquipment.TabIndex = 0
        Me.btNewEquipment.Text = "Nouveau"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.labAvailableOnlyName)
        Me.Guna2Panel1.Controls.Add(Me.checkSelectAllEquipment)
        Me.Guna2Panel1.Controls.Add(Me.checkAvailableEquip)
        Me.Guna2Panel1.Controls.Add(Me.tbSearch)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(947, 65)
        Me.Guna2Panel1.TabIndex = 12
        '
        'labAvailableOnlyName
        '
        Me.labAvailableOnlyName.BackColor = System.Drawing.Color.Transparent
        Me.labAvailableOnlyName.Location = New System.Drawing.Point(361, 12)
        Me.labAvailableOnlyName.Margin = New System.Windows.Forms.Padding(2)
        Me.labAvailableOnlyName.Name = "labAvailableOnlyName"
        Me.labAvailableOnlyName.Size = New System.Drawing.Size(105, 15)
        Me.labAvailableOnlyName.TabIndex = 23
        Me.labAvailableOnlyName.Text = "Disponible Seulement"
        '
        'checkSelectAllEquipment
        '
        Me.checkSelectAllEquipment.CheckedState.Image = CType(resources.GetObject("checkSelectAllEquipment.CheckedState.Image"), System.Drawing.Image)
        Me.checkSelectAllEquipment.CheckedState.Parent = Me.checkSelectAllEquipment
        Me.checkSelectAllEquipment.HoverState.Parent = Me.checkSelectAllEquipment
        Me.checkSelectAllEquipment.Image = CType(resources.GetObject("checkSelectAllEquipment.Image"), System.Drawing.Image)
        Me.checkSelectAllEquipment.IndicateFocus = False
        Me.checkSelectAllEquipment.Location = New System.Drawing.Point(45, 43)
        Me.checkSelectAllEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.checkSelectAllEquipment.Name = "checkSelectAllEquipment"
        Me.checkSelectAllEquipment.PressedState.Parent = Me.checkSelectAllEquipment
        Me.checkSelectAllEquipment.Size = New System.Drawing.Size(22, 20)
        Me.checkSelectAllEquipment.TabIndex = 22
        '
        'checkAvailableEquip
        '
        Me.checkAvailableEquip.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailableEquip.CheckedState.BorderRadius = 2
        Me.checkAvailableEquip.CheckedState.BorderThickness = 2
        Me.checkAvailableEquip.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailableEquip.CheckedState.Parent = Me.checkAvailableEquip
        Me.checkAvailableEquip.Location = New System.Drawing.Point(341, 11)
        Me.checkAvailableEquip.Margin = New System.Windows.Forms.Padding(2)
        Me.checkAvailableEquip.Name = "checkAvailableEquip"
        Me.checkAvailableEquip.ShadowDecoration.Parent = Me.checkAvailableEquip
        Me.checkAvailableEquip.Size = New System.Drawing.Size(15, 16)
        Me.checkAvailableEquip.TabIndex = 21
        Me.checkAvailableEquip.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkAvailableEquip.UncheckedState.BorderRadius = 2
        Me.checkAvailableEquip.UncheckedState.BorderThickness = 2
        Me.checkAvailableEquip.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkAvailableEquip.UncheckedState.Parent = Me.checkAvailableEquip
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
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.HoverState.Parent = Me.tbSearch
        Me.tbSearch.Location = New System.Drawing.Point(18, 6)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = "Recherche"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.ShadowDecoration.Parent = Me.tbSearch
        Me.tbSearch.Size = New System.Drawing.Size(310, 29)
        Me.tbSearch.TabIndex = 19
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.gridEquipment)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2Panel2)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 146)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(947, 458)
        Me.Guna2CustomGradientPanel2.TabIndex = 13
        '
        'gridEquipment
        '
        Me.gridEquipment.AllowUserToAddRows = False
        Me.gridEquipment.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridEquipment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gridEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridEquipment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridEquipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridEquipment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridEquipment.ColumnHeadersHeight = 30
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridEquipment.DefaultCellStyle = DataGridViewCellStyle7
        Me.gridEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEquipment.EnableHeadersVisualStyles = False
        Me.gridEquipment.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridEquipment.Location = New System.Drawing.Point(45, 0)
        Me.gridEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.gridEquipment.Name = "gridEquipment"
        Me.gridEquipment.ReadOnly = True
        Me.gridEquipment.RowHeadersVisible = False
        Me.gridEquipment.RowHeadersWidth = 10
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridEquipment.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gridEquipment.RowTemplate.Height = 24
        Me.gridEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEquipment.Size = New System.Drawing.Size(857, 409)
        Me.gridEquipment.TabIndex = 16
        Me.gridEquipment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridEquipment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridEquipment.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridEquipment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridEquipment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridEquipment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridEquipment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridEquipment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridEquipment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridEquipment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridEquipment.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridEquipment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridEquipment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridEquipment.ThemeStyle.HeaderStyle.Height = 30
        Me.gridEquipment.ThemeStyle.ReadOnly = True
        Me.gridEquipment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridEquipment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridEquipment.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridEquipment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridEquipment.ThemeStyle.RowsStyle.Height = 24
        Me.gridEquipment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridEquipment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(45, 409)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(857, 49)
        Me.Guna2Panel4.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(902, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(45, 458)
        Me.Guna2Panel3.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(45, 458)
        Me.Guna2Panel2.TabIndex = 0
        '
        'UCEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Name = "UCEquipment"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btNewEquipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents gridEquipment As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btPrintBarcodeEquip As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btDelEquipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labAvailableOnlyName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkSelectAllEquipment As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents checkAvailableEquip As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
