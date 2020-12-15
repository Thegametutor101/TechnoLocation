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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbReelDeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbSuggestedDeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labRealDeposit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labSuggestedDeposit = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labEndDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labBeginDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dateEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dateStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labEquipments = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labRenter = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbBalanceRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPhoneRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEmailRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbNameRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCodeRenter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btAddUser = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.gridSelectedEquipment = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel11.SuspendLayout()
        CType(Me.gridSelectedEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(45, 432)
        Me.Guna2Panel2.TabIndex = 66
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.tbReelDeposit)
        Me.Guna2Panel6.Controls.Add(Me.tbSuggestedDeposit)
        Me.Guna2Panel6.Controls.Add(Me.labRealDeposit)
        Me.Guna2Panel6.Controls.Add(Me.labSuggestedDeposit)
        Me.Guna2Panel6.Controls.Add(Me.labEndDate)
        Me.Guna2Panel6.Controls.Add(Me.labBeginDate)
        Me.Guna2Panel6.Controls.Add(Me.dateEnd)
        Me.Guna2Panel6.Controls.Add(Me.dateStart)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 497)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(902, 107)
        Me.Guna2Panel6.TabIndex = 70
        '
        'tbReelDeposit
        '
        Me.tbReelDeposit.BorderRadius = 2
        Me.tbReelDeposit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbReelDeposit.DefaultText = ""
        Me.tbReelDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbReelDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbReelDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbReelDeposit.DisabledState.Parent = Me.tbReelDeposit
        Me.tbReelDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbReelDeposit.Enabled = False
        Me.tbReelDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbReelDeposit.FocusedState.Parent = Me.tbReelDeposit
        Me.tbReelDeposit.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReelDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbReelDeposit.HoverState.Parent = Me.tbReelDeposit
        Me.tbReelDeposit.Location = New System.Drawing.Point(629, 62)
        Me.tbReelDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.tbReelDeposit.Name = "tbReelDeposit"
        Me.tbReelDeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReelDeposit.PlaceholderText = ""
        Me.tbReelDeposit.ReadOnly = True
        Me.tbReelDeposit.SelectedText = ""
        Me.tbReelDeposit.ShadowDecoration.Parent = Me.tbReelDeposit
        Me.tbReelDeposit.Size = New System.Drawing.Size(168, 29)
        Me.tbReelDeposit.TabIndex = 59
        Me.tbReelDeposit.TabStop = False
        '
        'tbSuggestedDeposit
        '
        Me.tbSuggestedDeposit.BorderRadius = 2
        Me.tbSuggestedDeposit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSuggestedDeposit.DefaultText = ""
        Me.tbSuggestedDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSuggestedDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSuggestedDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSuggestedDeposit.DisabledState.Parent = Me.tbSuggestedDeposit
        Me.tbSuggestedDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSuggestedDeposit.Enabled = False
        Me.tbSuggestedDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSuggestedDeposit.FocusedState.Parent = Me.tbSuggestedDeposit
        Me.tbSuggestedDeposit.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSuggestedDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSuggestedDeposit.HoverState.Parent = Me.tbSuggestedDeposit
        Me.tbSuggestedDeposit.Location = New System.Drawing.Point(629, 16)
        Me.tbSuggestedDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.tbSuggestedDeposit.Name = "tbSuggestedDeposit"
        Me.tbSuggestedDeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSuggestedDeposit.PlaceholderText = ""
        Me.tbSuggestedDeposit.ReadOnly = True
        Me.tbSuggestedDeposit.SelectedText = ""
        Me.tbSuggestedDeposit.ShadowDecoration.Parent = Me.tbSuggestedDeposit
        Me.tbSuggestedDeposit.Size = New System.Drawing.Size(168, 29)
        Me.tbSuggestedDeposit.TabIndex = 0
        Me.tbSuggestedDeposit.TabStop = False
        '
        'labRealDeposit
        '
        Me.labRealDeposit.BackColor = System.Drawing.Color.Transparent
        Me.labRealDeposit.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRealDeposit.Location = New System.Drawing.Point(484, 65)
        Me.labRealDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.labRealDeposit.Name = "labRealDeposit"
        Me.labRealDeposit.Size = New System.Drawing.Size(112, 22)
        Me.labRealDeposit.TabIndex = 58
        Me.labRealDeposit.Text = "Dépot demandé"
        '
        'labSuggestedDeposit
        '
        Me.labSuggestedDeposit.BackColor = System.Drawing.Color.Transparent
        Me.labSuggestedDeposit.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSuggestedDeposit.Location = New System.Drawing.Point(484, 24)
        Me.labSuggestedDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.labSuggestedDeposit.Name = "labSuggestedDeposit"
        Me.labSuggestedDeposit.Size = New System.Drawing.Size(102, 22)
        Me.labSuggestedDeposit.TabIndex = 57
        Me.labSuggestedDeposit.Text = "Dépot suggéré"
        '
        'labEndDate
        '
        Me.labEndDate.BackColor = System.Drawing.Color.Transparent
        Me.labEndDate.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEndDate.Location = New System.Drawing.Point(15, 65)
        Me.labEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.labEndDate.Name = "labEndDate"
        Me.labEndDate.Size = New System.Drawing.Size(20, 22)
        Me.labEndDate.TabIndex = 56
        Me.labEndDate.Text = "À :"
        '
        'labBeginDate
        '
        Me.labBeginDate.BackColor = System.Drawing.Color.Transparent
        Me.labBeginDate.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labBeginDate.Location = New System.Drawing.Point(15, 20)
        Me.labBeginDate.Margin = New System.Windows.Forms.Padding(2)
        Me.labBeginDate.Name = "labBeginDate"
        Me.labBeginDate.Size = New System.Drawing.Size(29, 22)
        Me.labBeginDate.TabIndex = 55
        Me.labBeginDate.Text = "De :"
        '
        'dateEnd
        '
        Me.dateEnd.CheckedState.Parent = Me.dateEnd
        Me.dateEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateEnd.HoverState.Parent = Me.dateEnd
        Me.dateEnd.Location = New System.Drawing.Point(133, 62)
        Me.dateEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.dateEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.ShadowDecoration.Parent = Me.dateEnd
        Me.dateEnd.Size = New System.Drawing.Size(237, 29)
        Me.dateEnd.TabIndex = 54
        Me.dateEnd.Value = New Date(2020, 12, 9, 20, 49, 6, 542)
        '
        'dateStart
        '
        Me.dateStart.CheckedState.Parent = Me.dateStart
        Me.dateStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateStart.HoverState.Parent = Me.dateStart
        Me.dateStart.Location = New System.Drawing.Point(133, 16)
        Me.dateStart.Margin = New System.Windows.Forms.Padding(2)
        Me.dateStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.ShadowDecoration.Parent = Me.dateStart
        Me.dateStart.Size = New System.Drawing.Size(237, 29)
        Me.dateStart.TabIndex = 53
        Me.dateStart.Value = New Date(2020, 12, 9, 20, 49, 5, 629)
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(902, 65)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(45, 539)
        Me.Guna2Panel3.TabIndex = 68
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btCancel)
        Me.Guna2Panel1.Controls.Add(Me.btSave)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(947, 65)
        Me.Guna2Panel1.TabIndex = 65
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
        Me.btSave.Location = New System.Drawing.Point(6, 8)
        Me.btSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btSave.Name = "btSave"
        Me.btSave.ShadowDecoration.Parent = Me.btSave
        Me.btSave.Size = New System.Drawing.Size(138, 49)
        Me.btSave.TabIndex = 52
        Me.btSave.Text = "Sauvegarder"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Controls.Add(Me.labEquipments)
        Me.Guna2Panel7.Controls.Add(Me.labRenter)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel7.Location = New System.Drawing.Point(45, 65)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(857, 35)
        Me.Guna2Panel7.TabIndex = 78
        '
        'labEquipments
        '
        Me.labEquipments.BackColor = System.Drawing.Color.Transparent
        Me.labEquipments.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEquipments.Location = New System.Drawing.Point(200, 5)
        Me.labEquipments.Margin = New System.Windows.Forms.Padding(2)
        Me.labEquipments.Name = "labEquipments"
        Me.labEquipments.Size = New System.Drawing.Size(89, 22)
        Me.labEquipments.TabIndex = 59
        Me.labEquipments.Text = "Équipements"
        '
        'labRenter
        '
        Me.labRenter.BackColor = System.Drawing.Color.Transparent
        Me.labRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRenter.Location = New System.Drawing.Point(7, 5)
        Me.labRenter.Margin = New System.Windows.Forms.Padding(2)
        Me.labRenter.Name = "labRenter"
        Me.labRenter.Size = New System.Drawing.Size(80, 22)
        Me.labRenter.TabIndex = 58
        Me.labRenter.Text = "Emprunteur"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.tbBalanceRenter)
        Me.Guna2Panel9.Controls.Add(Me.tbPhoneRenter)
        Me.Guna2Panel9.Controls.Add(Me.tbEmailRenter)
        Me.Guna2Panel9.Controls.Add(Me.tbNameRenter)
        Me.Guna2Panel9.Controls.Add(Me.tbCodeRenter)
        Me.Guna2Panel9.Controls.Add(Me.Guna2Panel11)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel9.Location = New System.Drawing.Point(45, 100)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(179, 397)
        Me.Guna2Panel9.TabIndex = 79
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
        Me.tbBalanceRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalanceRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBalanceRenter.HoverState.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.Location = New System.Drawing.Point(8, 312)
        Me.tbBalanceRenter.Name = "tbBalanceRenter"
        Me.tbBalanceRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbBalanceRenter.PlaceholderText = ""
        Me.tbBalanceRenter.ReadOnly = True
        Me.tbBalanceRenter.SelectedText = ""
        Me.tbBalanceRenter.ShadowDecoration.Parent = Me.tbBalanceRenter
        Me.tbBalanceRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbBalanceRenter.TabIndex = 59
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
        Me.tbPhoneRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPhoneRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhoneRenter.HoverState.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.Location = New System.Drawing.Point(8, 247)
        Me.tbPhoneRenter.Name = "tbPhoneRenter"
        Me.tbPhoneRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPhoneRenter.PlaceholderText = ""
        Me.tbPhoneRenter.ReadOnly = True
        Me.tbPhoneRenter.SelectedText = ""
        Me.tbPhoneRenter.ShadowDecoration.Parent = Me.tbPhoneRenter
        Me.tbPhoneRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbPhoneRenter.TabIndex = 58
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
        Me.tbEmailRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmailRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmailRenter.HoverState.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.Location = New System.Drawing.Point(7, 181)
        Me.tbEmailRenter.Name = "tbEmailRenter"
        Me.tbEmailRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmailRenter.PlaceholderText = ""
        Me.tbEmailRenter.ReadOnly = True
        Me.tbEmailRenter.SelectedText = ""
        Me.tbEmailRenter.ShadowDecoration.Parent = Me.tbEmailRenter
        Me.tbEmailRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbEmailRenter.TabIndex = 57
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
        Me.tbNameRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNameRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNameRenter.HoverState.Parent = Me.tbNameRenter
        Me.tbNameRenter.Location = New System.Drawing.Point(8, 127)
        Me.tbNameRenter.Name = "tbNameRenter"
        Me.tbNameRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNameRenter.PlaceholderText = ""
        Me.tbNameRenter.ReadOnly = True
        Me.tbNameRenter.SelectedText = ""
        Me.tbNameRenter.ShadowDecoration.Parent = Me.tbNameRenter
        Me.tbNameRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbNameRenter.TabIndex = 56
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
        Me.tbCodeRenter.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodeRenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCodeRenter.HoverState.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.Location = New System.Drawing.Point(8, 71)
        Me.tbCodeRenter.Name = "tbCodeRenter"
        Me.tbCodeRenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCodeRenter.PlaceholderText = ""
        Me.tbCodeRenter.ReadOnly = True
        Me.tbCodeRenter.SelectedText = ""
        Me.tbCodeRenter.ShadowDecoration.Parent = Me.tbCodeRenter
        Me.tbCodeRenter.Size = New System.Drawing.Size(152, 36)
        Me.tbCodeRenter.TabIndex = 55
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.Controls.Add(Me.btAddUser)
        Me.Guna2Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.ShadowDecoration.Parent = Me.Guna2Panel11
        Me.Guna2Panel11.Size = New System.Drawing.Size(179, 53)
        Me.Guna2Panel11.TabIndex = 0
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
        Me.btAddUser.Location = New System.Drawing.Point(8, 9)
        Me.btAddUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_person_black_18dp
        Me.btAddUser.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btAddUser.PressedState.Parent = Me.btAddUser
        Me.btAddUser.Size = New System.Drawing.Size(32, 34)
        Me.btAddUser.TabIndex = 54
        '
        'gridSelectedEquipment
        '
        Me.gridSelectedEquipment.AllowUserToAddRows = False
        Me.gridSelectedEquipment.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSelectedEquipment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gridSelectedEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridSelectedEquipment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridSelectedEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridSelectedEquipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSelectedEquipment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridSelectedEquipment.ColumnHeadersHeight = 30
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridSelectedEquipment.DefaultCellStyle = DataGridViewCellStyle7
        Me.gridSelectedEquipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridSelectedEquipment.EnableHeadersVisualStyles = False
        Me.gridSelectedEquipment.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridSelectedEquipment.Location = New System.Drawing.Point(224, 100)
        Me.gridSelectedEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.gridSelectedEquipment.Name = "gridSelectedEquipment"
        Me.gridSelectedEquipment.RowHeadersVisible = False
        Me.gridSelectedEquipment.RowHeadersWidth = 10
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSelectedEquipment.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.gridSelectedEquipment.RowTemplate.Height = 24
        Me.gridSelectedEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSelectedEquipment.Size = New System.Drawing.Size(678, 397)
        Me.gridSelectedEquipment.TabIndex = 80
        Me.gridSelectedEquipment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gridSelectedEquipment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gridSelectedEquipment.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gridSelectedEquipment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gridSelectedEquipment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gridSelectedEquipment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gridSelectedEquipment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.gridSelectedEquipment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gridSelectedEquipment.ThemeStyle.HeaderStyle.Height = 30
        Me.gridSelectedEquipment.ThemeStyle.ReadOnly = False
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.Height = 24
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridSelectedEquipment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.btCancel.Location = New System.Drawing.Point(150, 8)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.ShadowDecoration.Parent = Me.btCancel
        Me.btCancel.Size = New System.Drawing.Size(138, 49)
        Me.btCancel.TabIndex = 81
        Me.btCancel.Text = "Annuler"
        '
        'UCRentMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridSelectedEquipment)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "UCRentMod"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel11.ResumeLayout(False)
        CType(Me.gridSelectedEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbReelDeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSuggestedDeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labRealDeposit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labSuggestedDeposit As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labEndDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labBeginDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dateEnd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dateStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labEquipments As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labRenter As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbBalanceRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPhoneRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEmailRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbNameRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCodeRenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btAddUser As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents gridSelectedEquipment As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2Button
End Class
