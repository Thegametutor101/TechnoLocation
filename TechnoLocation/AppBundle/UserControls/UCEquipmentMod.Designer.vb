<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEquipmentMod
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btBack = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbComment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbState = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labComment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labState = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labAvailable = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkAvailable = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gridKit = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labKitName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btNoKit = New Guna.UI2.WinForms.Guna2Button()
        Me.btAddKit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        CType(Me.gridKit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btBack)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(75, 744)
        Me.Guna2Panel1.TabIndex = 32
        '
        'btBack
        '
        Me.btBack.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.CheckedState.Parent = Me.btBack
        Me.btBack.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.HoverState.Parent = Me.btBack
        Me.btBack.Image = Global.TechnoLocation.My.Resources.Resources.baseline_navigate_before_black_18dp
        Me.btBack.ImageRotate = 0!
        Me.btBack.Location = New System.Drawing.Point(6, 17)
        Me.btBack.Name = "btBack"
        Me.btBack.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.PressedState.Parent = Me.btBack
        Me.btBack.Size = New System.Drawing.Size(64, 54)
        Me.btBack.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(1211, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(52, 744)
        Me.Guna2Panel2.TabIndex = 33
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(75, 689)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1136, 55)
        Me.Guna2Panel3.TabIndex = 34
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(75, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(646, 689)
        Me.Guna2Panel4.TabIndex = 35
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.tbComment)
        Me.Guna2Panel6.Controls.Add(Me.tbState)
        Me.Guna2Panel6.Controls.Add(Me.tbName)
        Me.Guna2Panel6.Controls.Add(Me.labComment)
        Me.Guna2Panel6.Controls.Add(Me.labState)
        Me.Guna2Panel6.Controls.Add(Me.labName)
        Me.Guna2Panel6.Controls.Add(Me.labAvailable)
        Me.Guna2Panel6.Controls.Add(Me.checkAvailable)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(646, 589)
        Me.Guna2Panel6.TabIndex = 1
        '
        'tbComment
        '
        Me.tbComment.BorderRadius = 2
        Me.tbComment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbComment.DefaultText = ""
        Me.tbComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbComment.DisabledState.Parent = Me.tbComment
        Me.tbComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbComment.FocusedState.Parent = Me.tbComment
        Me.tbComment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbComment.HoverState.Parent = Me.tbComment
        Me.tbComment.Location = New System.Drawing.Point(231, 186)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbComment.PlaceholderText = ""
        Me.tbComment.SelectedText = ""
        Me.tbComment.ShadowDecoration.Parent = Me.tbComment
        Me.tbComment.Size = New System.Drawing.Size(356, 241)
        Me.tbComment.TabIndex = 49
        '
        'tbState
        '
        Me.tbState.BorderRadius = 2
        Me.tbState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbState.DefaultText = ""
        Me.tbState.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbState.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbState.DisabledState.Parent = Me.tbState
        Me.tbState.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbState.FocusedState.Parent = Me.tbState
        Me.tbState.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbState.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbState.HoverState.Parent = Me.tbState
        Me.tbState.Location = New System.Drawing.Point(231, 116)
        Me.tbState.Name = "tbState"
        Me.tbState.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbState.PlaceholderText = "Nouveau ; Endommagé ; etc"
        Me.tbState.SelectedText = ""
        Me.tbState.ShadowDecoration.Parent = Me.tbState
        Me.tbState.Size = New System.Drawing.Size(356, 36)
        Me.tbState.TabIndex = 48
        '
        'tbName
        '
        Me.tbName.BorderRadius = 2
        Me.tbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbName.DefaultText = ""
        Me.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.DisabledState.Parent = Me.tbName
        Me.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbName.FocusedState.Parent = Me.tbName
        Me.tbName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbName.HoverState.Parent = Me.tbName
        Me.tbName.Location = New System.Drawing.Point(231, 55)
        Me.tbName.Name = "tbName"
        Me.tbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbName.PlaceholderText = ""
        Me.tbName.SelectedText = ""
        Me.tbName.ShadowDecoration.Parent = Me.tbName
        Me.tbName.Size = New System.Drawing.Size(356, 36)
        Me.tbName.TabIndex = 47
        '
        'labComment
        '
        Me.labComment.BackColor = System.Drawing.Color.Transparent
        Me.labComment.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labComment.Location = New System.Drawing.Point(30, 190)
        Me.labComment.Name = "labComment"
        Me.labComment.Size = New System.Drawing.Size(118, 27)
        Me.labComment.TabIndex = 46
        Me.labComment.Text = "Commentaires"
        '
        'labState
        '
        Me.labState.BackColor = System.Drawing.Color.Transparent
        Me.labState.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labState.Location = New System.Drawing.Point(30, 120)
        Me.labState.Name = "labState"
        Me.labState.Size = New System.Drawing.Size(166, 27)
        Me.labState.TabIndex = 45
        Me.labState.Text = "État de l'équipement"
        '
        'labName
        '
        Me.labName.BackColor = System.Drawing.Color.Transparent
        Me.labName.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labName.Location = New System.Drawing.Point(30, 59)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(158, 27)
        Me.labName.TabIndex = 44
        Me.labName.Text = "Nom d'équipement"
        '
        'labAvailable
        '
        Me.labAvailable.BackColor = System.Drawing.Color.Transparent
        Me.labAvailable.Location = New System.Drawing.Point(257, 456)
        Me.labAvailable.Name = "labAvailable"
        Me.labAvailable.Size = New System.Drawing.Size(106, 18)
        Me.labAvailable.TabIndex = 43
        Me.labAvailable.Text = "Mettre disponible"
        '
        'checkAvailable
        '
        Me.checkAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailable.CheckedState.BorderRadius = 2
        Me.checkAvailable.CheckedState.BorderThickness = 2
        Me.checkAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailable.CheckedState.Parent = Me.checkAvailable
        Me.checkAvailable.Location = New System.Drawing.Point(231, 455)
        Me.checkAvailable.Name = "checkAvailable"
        Me.checkAvailable.ShadowDecoration.Parent = Me.checkAvailable
        Me.checkAvailable.Size = New System.Drawing.Size(20, 20)
        Me.checkAvailable.TabIndex = 42
        Me.checkAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkAvailable.UncheckedState.BorderRadius = 2
        Me.checkAvailable.UncheckedState.BorderThickness = 2
        Me.checkAvailable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkAvailable.UncheckedState.Parent = Me.checkAvailable
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.btCancel)
        Me.Guna2Panel5.Controls.Add(Me.btSave)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(646, 100)
        Me.Guna2Panel5.TabIndex = 0
        '
        'btCancel
        '
        Me.btCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btCancel.BorderRadius = 15
        Me.btCancel.BorderThickness = 2
        Me.btCancel.CheckedState.Parent = Me.btCancel
        Me.btCancel.CustomImages.Parent = Me.btCancel
        Me.btCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btCancel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btCancel.ForeColor = System.Drawing.Color.Black
        Me.btCancel.HoverState.Parent = Me.btCancel
        Me.btCancel.Location = New System.Drawing.Point(231, 10)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.ShadowDecoration.Parent = Me.btCancel
        Me.btCancel.Size = New System.Drawing.Size(184, 80)
        Me.btCancel.TabIndex = 2
        Me.btCancel.Text = "Annuler"
        '
        'btSave
        '
        Me.btSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btSave.BorderRadius = 15
        Me.btSave.BorderThickness = 2
        Me.btSave.CheckedState.Parent = Me.btSave
        Me.btSave.CustomImages.Parent = Me.btSave
        Me.btSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btSave.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btSave.ForeColor = System.Drawing.Color.Black
        Me.btSave.HoverState.Parent = Me.btSave
        Me.btSave.Location = New System.Drawing.Point(30, 10)
        Me.btSave.Name = "btSave"
        Me.btSave.ShadowDecoration.Parent = Me.btSave
        Me.btSave.Size = New System.Drawing.Size(184, 80)
        Me.btSave.TabIndex = 1
        Me.btSave.Text = "Sauvegarder"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel7.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(721, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(490, 689)
        Me.Guna2Panel7.TabIndex = 36
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.gridKit)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 136)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(490, 553)
        Me.Guna2Panel9.TabIndex = 37
        '
        'gridKit
        '
        Me.gridKit.AllowUserToAddRows = False
        Me.gridKit.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridKit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gridKit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridKit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridKit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridKit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridKit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridKit.ColumnHeadersHeight = 30
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridKit.DefaultCellStyle = DataGridViewCellStyle7
        Me.gridKit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridKit.EnableHeadersVisualStyles = False
        Me.gridKit.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridKit.Location = New System.Drawing.Point(0, 0)
        Me.gridKit.MultiSelect = False
        Me.gridKit.Name = "gridKit"
        Me.gridKit.ReadOnly = True
        Me.gridKit.RowHeadersVisible = False
        Me.gridKit.RowHeadersWidth = 10
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridKit.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gridKit.RowTemplate.Height = 24
        Me.gridKit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridKit.Size = New System.Drawing.Size(490, 553)
        Me.gridKit.TabIndex = 38
        Me.gridKit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridKit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridKit.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridKit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridKit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridKit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridKit.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridKit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridKit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridKit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridKit.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridKit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridKit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridKit.ThemeStyle.HeaderStyle.Height = 30
        Me.gridKit.ThemeStyle.ReadOnly = True
        Me.gridKit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridKit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridKit.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridKit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridKit.ThemeStyle.RowsStyle.Height = 24
        Me.gridKit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridKit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Controls.Add(Me.labKitName)
        Me.Guna2Panel8.Controls.Add(Me.btNoKit)
        Me.Guna2Panel8.Controls.Add(Me.btAddKit)
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(490, 136)
        Me.Guna2Panel8.TabIndex = 36
        '
        'labKitName
        '
        Me.labKitName.BackColor = System.Drawing.Color.Transparent
        Me.labKitName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labKitName.Location = New System.Drawing.Point(17, 107)
        Me.labKitName.Name = "labKitName"
        Me.labKitName.Size = New System.Drawing.Size(227, 22)
        Me.labKitName.TabIndex = 42
        Me.labKitName.Text = "Choix de kit pour l'équipement"
        '
        'btNoKit
        '
        Me.btNoKit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btNoKit.BorderRadius = 15
        Me.btNoKit.BorderThickness = 2
        Me.btNoKit.CheckedState.Parent = Me.btNoKit
        Me.btNoKit.CustomImages.Parent = Me.btNoKit
        Me.btNoKit.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btNoKit.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btNoKit.ForeColor = System.Drawing.Color.Black
        Me.btNoKit.HoverState.Parent = Me.btNoKit
        Me.btNoKit.Location = New System.Drawing.Point(220, 10)
        Me.btNoKit.Name = "btNoKit"
        Me.btNoKit.ShadowDecoration.Parent = Me.btNoKit
        Me.btNoKit.Size = New System.Drawing.Size(153, 80)
        Me.btNoKit.TabIndex = 4
        Me.btNoKit.Text = "Aucun kit"
        '
        'btAddKit
        '
        Me.btAddKit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btAddKit.BorderRadius = 15
        Me.btAddKit.BorderThickness = 2
        Me.btAddKit.CheckedState.Parent = Me.btAddKit
        Me.btAddKit.CustomImages.Parent = Me.btAddKit
        Me.btAddKit.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btAddKit.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btAddKit.ForeColor = System.Drawing.Color.Black
        Me.btAddKit.HoverState.Parent = Me.btAddKit
        Me.btAddKit.Location = New System.Drawing.Point(19, 10)
        Me.btAddKit.Name = "btAddKit"
        Me.btAddKit.ShadowDecoration.Parent = Me.btAddKit
        Me.btAddKit.Size = New System.Drawing.Size(186, 80)
        Me.btAddKit.TabIndex = 3
        Me.btAddKit.Text = "Ajouter un nouveau kit"
        '
        'UCEquipmentMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCEquipmentMod"
        Me.Size = New System.Drawing.Size(1263, 744)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        CType(Me.gridKit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labKitName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btNoKit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAddKit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbState As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labComment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labState As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labAvailable As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkAvailable As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gridKit As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btBack As Guna.UI2.WinForms.Guna2ImageButton
End Class
