<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserAdd
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btCancelUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btBack = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labExt2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkExt2 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.labExt1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkExt1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.numExtension2 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.numExtension1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.labSetPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkPassword = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dropPermissions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dropStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.labPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labPermissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbPhone2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labPhone2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbPhone1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.numCode = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labCodeUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.numExtension2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExtension1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btCancelUser)
        Me.Guna2Panel1.Controls.Add(Me.btAddUser)
        Me.Guna2Panel1.Controls.Add(Me.btBack)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1263, 100)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btCancelUser
        '
        Me.btCancelUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btCancelUser.BorderRadius = 15
        Me.btCancelUser.BorderThickness = 2
        Me.btCancelUser.CheckedState.Parent = Me.btCancelUser
        Me.btCancelUser.CustomImages.Parent = Me.btCancelUser
        Me.btCancelUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btCancelUser.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btCancelUser.ForeColor = System.Drawing.Color.Black
        Me.btCancelUser.HoverState.Parent = Me.btCancelUser
        Me.btCancelUser.Location = New System.Drawing.Point(293, 10)
        Me.btCancelUser.Name = "btCancelUser"
        Me.btCancelUser.ShadowDecoration.Parent = Me.btCancelUser
        Me.btCancelUser.Size = New System.Drawing.Size(184, 80)
        Me.btCancelUser.TabIndex = 25
        Me.btCancelUser.Text = "Annuler"
        '
        'btAddUser
        '
        Me.btAddUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btAddUser.BorderRadius = 15
        Me.btAddUser.BorderThickness = 2
        Me.btAddUser.CheckedState.Parent = Me.btAddUser
        Me.btAddUser.CustomImages.Parent = Me.btAddUser
        Me.btAddUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btAddUser.Font = New System.Drawing.Font("Segoe UI Symbol", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btAddUser.ForeColor = System.Drawing.Color.Black
        Me.btAddUser.HoverState.Parent = Me.btAddUser
        Me.btAddUser.Location = New System.Drawing.Point(92, 10)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.ShadowDecoration.Parent = Me.btAddUser
        Me.btAddUser.Size = New System.Drawing.Size(184, 80)
        Me.btAddUser.TabIndex = 24
        Me.btAddUser.Text = "Sauvegarder"
        '
        'btBack
        '
        Me.btBack.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.CheckedState.Parent = Me.btBack
        Me.btBack.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.HoverState.Parent = Me.btBack
        Me.btBack.Image = Global.TechnoLocation.My.Resources.Resources.baseline_navigate_before_black_18dp
        Me.btBack.ImageRotate = 0!
        Me.btBack.Location = New System.Drawing.Point(14, 21)
        Me.btBack.Name = "btBack"
        Me.btBack.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btBack.PressedState.Parent = Me.btBack
        Me.btBack.Size = New System.Drawing.Size(64, 54)
        Me.btBack.TabIndex = 23
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(60, 644)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(1203, 100)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(60, 644)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(60, 715)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1143, 29)
        Me.Guna2Panel4.TabIndex = 3
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.labExt2)
        Me.Guna2Panel5.Controls.Add(Me.checkExt2)
        Me.Guna2Panel5.Controls.Add(Me.labExt1)
        Me.Guna2Panel5.Controls.Add(Me.checkExt1)
        Me.Guna2Panel5.Controls.Add(Me.numExtension2)
        Me.Guna2Panel5.Controls.Add(Me.numExtension1)
        Me.Guna2Panel5.Controls.Add(Me.labSetPassword)
        Me.Guna2Panel5.Controls.Add(Me.checkPassword)
        Me.Guna2Panel5.Controls.Add(Me.tbPassword)
        Me.Guna2Panel5.Controls.Add(Me.dropPermissions)
        Me.Guna2Panel5.Controls.Add(Me.dropStatus)
        Me.Guna2Panel5.Controls.Add(Me.labPassword)
        Me.Guna2Panel5.Controls.Add(Me.labPermissions)
        Me.Guna2Panel5.Controls.Add(Me.labStatus)
        Me.Guna2Panel5.Controls.Add(Me.tbPhone2)
        Me.Guna2Panel5.Controls.Add(Me.labPhone2)
        Me.Guna2Panel5.Controls.Add(Me.tbPhone1)
        Me.Guna2Panel5.Controls.Add(Me.labPhone)
        Me.Guna2Panel5.Controls.Add(Me.numCode)
        Me.Guna2Panel5.Controls.Add(Me.tbEmail)
        Me.Guna2Panel5.Controls.Add(Me.labEmail)
        Me.Guna2Panel5.Controls.Add(Me.tbLastName)
        Me.Guna2Panel5.Controls.Add(Me.tbFirstName)
        Me.Guna2Panel5.Controls.Add(Me.labName)
        Me.Guna2Panel5.Controls.Add(Me.labCodeUser)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(60, 100)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(1143, 615)
        Me.Guna2Panel5.TabIndex = 4
        '
        'labExt2
        '
        Me.labExt2.BackColor = System.Drawing.Color.Transparent
        Me.labExt2.Location = New System.Drawing.Point(873, 310)
        Me.labExt2.Name = "labExt2"
        Me.labExt2.Size = New System.Drawing.Size(138, 18)
        Me.labExt2.TabIndex = 71
        Me.labExt2.Text = "Cochez pour extension"
        '
        'checkExt2
        '
        Me.checkExt2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt2.CheckedState.BorderRadius = 2
        Me.checkExt2.CheckedState.BorderThickness = 2
        Me.checkExt2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt2.CheckedState.Parent = Me.checkExt2
        Me.checkExt2.Location = New System.Drawing.Point(847, 309)
        Me.checkExt2.Name = "checkExt2"
        Me.checkExt2.ShadowDecoration.Parent = Me.checkExt2
        Me.checkExt2.Size = New System.Drawing.Size(20, 20)
        Me.checkExt2.TabIndex = 70
        Me.checkExt2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkExt2.UncheckedState.BorderRadius = 2
        Me.checkExt2.UncheckedState.BorderThickness = 2
        Me.checkExt2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkExt2.UncheckedState.Parent = Me.checkExt2
        '
        'labExt1
        '
        Me.labExt1.BackColor = System.Drawing.Color.Transparent
        Me.labExt1.Location = New System.Drawing.Point(873, 233)
        Me.labExt1.Name = "labExt1"
        Me.labExt1.Size = New System.Drawing.Size(138, 18)
        Me.labExt1.TabIndex = 69
        Me.labExt1.Text = "Cochez pour extension"
        '
        'checkExt1
        '
        Me.checkExt1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt1.CheckedState.BorderRadius = 2
        Me.checkExt1.CheckedState.BorderThickness = 2
        Me.checkExt1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt1.CheckedState.Parent = Me.checkExt1
        Me.checkExt1.Location = New System.Drawing.Point(847, 232)
        Me.checkExt1.Name = "checkExt1"
        Me.checkExt1.ShadowDecoration.Parent = Me.checkExt1
        Me.checkExt1.Size = New System.Drawing.Size(20, 20)
        Me.checkExt1.TabIndex = 68
        Me.checkExt1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkExt1.UncheckedState.BorderRadius = 2
        Me.checkExt1.UncheckedState.BorderThickness = 2
        Me.checkExt1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkExt1.UncheckedState.Parent = Me.checkExt1
        '
        'numExtension2
        '
        Me.numExtension2.BackColor = System.Drawing.Color.Transparent
        Me.numExtension2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numExtension2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numExtension2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numExtension2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numExtension2.DisabledState.Parent = Me.numExtension2
        Me.numExtension2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numExtension2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numExtension2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numExtension2.FocusedState.Parent = Me.numExtension2
        Me.numExtension2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numExtension2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numExtension2.Location = New System.Drawing.Point(844, 335)
        Me.numExtension2.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numExtension2.Name = "numExtension2"
        Me.numExtension2.ShadowDecoration.Parent = Me.numExtension2
        Me.numExtension2.Size = New System.Drawing.Size(146, 36)
        Me.numExtension2.TabIndex = 48
        '
        'numExtension1
        '
        Me.numExtension1.BackColor = System.Drawing.Color.Transparent
        Me.numExtension1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numExtension1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numExtension1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numExtension1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numExtension1.DisabledState.Parent = Me.numExtension1
        Me.numExtension1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numExtension1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numExtension1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numExtension1.FocusedState.Parent = Me.numExtension1
        Me.numExtension1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numExtension1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numExtension1.Location = New System.Drawing.Point(844, 266)
        Me.numExtension1.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numExtension1.Name = "numExtension1"
        Me.numExtension1.ShadowDecoration.Parent = Me.numExtension1
        Me.numExtension1.Size = New System.Drawing.Size(146, 36)
        Me.numExtension1.TabIndex = 46
        '
        'labSetPassword
        '
        Me.labSetPassword.BackColor = System.Drawing.Color.Transparent
        Me.labSetPassword.Location = New System.Drawing.Point(503, 527)
        Me.labSetPassword.Name = "labSetPassword"
        Me.labSetPassword.Size = New System.Drawing.Size(170, 18)
        Me.labSetPassword.TabIndex = 67
        Me.labSetPassword.Text = "Enregistrer un mot de passe"
        '
        'checkPassword
        '
        Me.checkPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkPassword.CheckedState.BorderRadius = 2
        Me.checkPassword.CheckedState.BorderThickness = 2
        Me.checkPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkPassword.CheckedState.Parent = Me.checkPassword
        Me.checkPassword.Location = New System.Drawing.Point(477, 526)
        Me.checkPassword.Name = "checkPassword"
        Me.checkPassword.ShadowDecoration.Parent = Me.checkPassword
        Me.checkPassword.Size = New System.Drawing.Size(20, 20)
        Me.checkPassword.TabIndex = 51
        Me.checkPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkPassword.UncheckedState.BorderRadius = 2
        Me.checkPassword.UncheckedState.BorderThickness = 2
        Me.checkPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkPassword.UncheckedState.Parent = Me.checkPassword
        '
        'tbPassword
        '
        Me.tbPassword.BorderRadius = 2
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.DisabledState.Parent = Me.tbPassword
        Me.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.FocusedState.Parent = Me.tbPassword
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.HoverState.Parent = Me.tbPassword
        Me.tbPassword.Location = New System.Drawing.Point(468, 560)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.ShadowDecoration.Parent = Me.tbPassword
        Me.tbPassword.Size = New System.Drawing.Size(356, 36)
        Me.tbPassword.TabIndex = 52
        '
        'dropPermissions
        '
        Me.dropPermissions.BackColor = System.Drawing.Color.Transparent
        Me.dropPermissions.BorderRadius = 2
        Me.dropPermissions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dropPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropPermissions.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropPermissions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropPermissions.FocusedState.Parent = Me.dropPermissions
        Me.dropPermissions.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.dropPermissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.dropPermissions.HoverState.Parent = Me.dropPermissions
        Me.dropPermissions.ItemHeight = 30
        Me.dropPermissions.ItemsAppearance.Parent = Me.dropPermissions
        Me.dropPermissions.Location = New System.Drawing.Point(468, 470)
        Me.dropPermissions.Name = "dropPermissions"
        Me.dropPermissions.ShadowDecoration.Parent = Me.dropPermissions
        Me.dropPermissions.Size = New System.Drawing.Size(356, 36)
        Me.dropPermissions.Sorted = True
        Me.dropPermissions.TabIndex = 50
        '
        'dropStatus
        '
        Me.dropStatus.BackColor = System.Drawing.Color.Transparent
        Me.dropStatus.BorderRadius = 2
        Me.dropStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dropStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropStatus.FocusedState.Parent = Me.dropStatus
        Me.dropStatus.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.dropStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.dropStatus.HoverState.Parent = Me.dropStatus
        Me.dropStatus.ItemHeight = 30
        Me.dropStatus.ItemsAppearance.Parent = Me.dropStatus
        Me.dropStatus.Location = New System.Drawing.Point(468, 401)
        Me.dropStatus.Name = "dropStatus"
        Me.dropStatus.ShadowDecoration.Parent = Me.dropStatus
        Me.dropStatus.Size = New System.Drawing.Size(356, 36)
        Me.dropStatus.Sorted = True
        Me.dropStatus.TabIndex = 49
        '
        'labPassword
        '
        Me.labPassword.BackColor = System.Drawing.Color.Transparent
        Me.labPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPassword.Location = New System.Drawing.Point(267, 560)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(111, 27)
        Me.labPassword.TabIndex = 62
        Me.labPassword.Text = "Mot de passe"
        '
        'labPermissions
        '
        Me.labPermissions.BackColor = System.Drawing.Color.Transparent
        Me.labPermissions.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPermissions.Location = New System.Drawing.Point(267, 470)
        Me.labPermissions.Name = "labPermissions"
        Me.labPermissions.Size = New System.Drawing.Size(97, 27)
        Me.labPermissions.TabIndex = 61
        Me.labPermissions.Text = "Permissions"
        '
        'labStatus
        '
        Me.labStatus.BackColor = System.Drawing.Color.Transparent
        Me.labStatus.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labStatus.Location = New System.Drawing.Point(267, 408)
        Me.labStatus.Name = "labStatus"
        Me.labStatus.Size = New System.Drawing.Size(50, 27)
        Me.labStatus.TabIndex = 60
        Me.labStatus.Text = "Statut"
        '
        'tbPhone2
        '
        Me.tbPhone2.BorderRadius = 2
        Me.tbPhone2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPhone2.DefaultText = ""
        Me.tbPhone2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPhone2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPhone2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone2.DisabledState.Parent = Me.tbPhone2
        Me.tbPhone2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone2.FocusedState.Parent = Me.tbPhone2
        Me.tbPhone2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPhone2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone2.HoverState.Parent = Me.tbPhone2
        Me.tbPhone2.Location = New System.Drawing.Point(468, 335)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPhone2.PlaceholderText = "(819) 995-5566"
        Me.tbPhone2.SelectedText = ""
        Me.tbPhone2.ShadowDecoration.Parent = Me.tbPhone2
        Me.tbPhone2.Size = New System.Drawing.Size(356, 36)
        Me.tbPhone2.TabIndex = 47
        '
        'labPhone2
        '
        Me.labPhone2.BackColor = System.Drawing.Color.Transparent
        Me.labPhone2.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPhone2.Location = New System.Drawing.Point(267, 339)
        Me.labPhone2.Name = "labPhone2"
        Me.labPhone2.Size = New System.Drawing.Size(100, 27)
        Me.labPhone2.TabIndex = 58
        Me.labPhone2.Text = "Téléphone 2"
        '
        'tbPhone1
        '
        Me.tbPhone1.BorderRadius = 2
        Me.tbPhone1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPhone1.DefaultText = ""
        Me.tbPhone1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPhone1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPhone1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone1.DisabledState.Parent = Me.tbPhone1
        Me.tbPhone1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone1.FocusedState.Parent = Me.tbPhone1
        Me.tbPhone1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPhone1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone1.HoverState.Parent = Me.tbPhone1
        Me.tbPhone1.Location = New System.Drawing.Point(468, 266)
        Me.tbPhone1.Name = "tbPhone1"
        Me.tbPhone1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPhone1.PlaceholderText = "(819) 995-5566"
        Me.tbPhone1.SelectedText = ""
        Me.tbPhone1.ShadowDecoration.Parent = Me.tbPhone1
        Me.tbPhone1.Size = New System.Drawing.Size(356, 36)
        Me.tbPhone1.TabIndex = 45
        '
        'labPhone
        '
        Me.labPhone.BackColor = System.Drawing.Color.Transparent
        Me.labPhone.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPhone.Location = New System.Drawing.Point(267, 270)
        Me.labPhone.Name = "labPhone"
        Me.labPhone.Size = New System.Drawing.Size(100, 27)
        Me.labPhone.TabIndex = 56
        Me.labPhone.Text = "Téléphone 1"
        '
        'numCode
        '
        Me.numCode.BackColor = System.Drawing.Color.Transparent
        Me.numCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numCode.DisabledState.Parent = Me.numCode
        Me.numCode.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numCode.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numCode.FocusedState.Parent = Me.numCode
        Me.numCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numCode.Location = New System.Drawing.Point(468, 50)
        Me.numCode.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numCode.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numCode.Name = "numCode"
        Me.numCode.ShadowDecoration.Parent = Me.numCode
        Me.numCode.Size = New System.Drawing.Size(356, 36)
        Me.numCode.TabIndex = 41
        Me.numCode.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'tbEmail
        '
        Me.tbEmail.BorderRadius = 2
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.DefaultText = ""
        Me.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.DisabledState.Parent = Me.tbEmail
        Me.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.FocusedState.Parent = Me.tbEmail
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.HoverState.Parent = Me.tbEmail
        Me.tbEmail.Location = New System.Drawing.Point(468, 195)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmail.PlaceholderText = "example@gmail.com"
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.ShadowDecoration.Parent = Me.tbEmail
        Me.tbEmail.Size = New System.Drawing.Size(356, 36)
        Me.tbEmail.TabIndex = 44
        '
        'labEmail
        '
        Me.labEmail.BackColor = System.Drawing.Color.Transparent
        Me.labEmail.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmail.Location = New System.Drawing.Point(267, 199)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(45, 27)
        Me.labEmail.TabIndex = 53
        Me.labEmail.Text = "Email"
        '
        'tbLastName
        '
        Me.tbLastName.BorderRadius = 2
        Me.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLastName.DefaultText = ""
        Me.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.DisabledState.Parent = Me.tbLastName
        Me.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.FocusedState.Parent = Me.tbLastName
        Me.tbLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.HoverState.Parent = Me.tbLastName
        Me.tbLastName.Location = New System.Drawing.Point(649, 124)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLastName.PlaceholderText = "Nom de famille"
        Me.tbLastName.SelectedText = ""
        Me.tbLastName.ShadowDecoration.Parent = Me.tbLastName
        Me.tbLastName.Size = New System.Drawing.Size(175, 36)
        Me.tbLastName.TabIndex = 43
        '
        'tbFirstName
        '
        Me.tbFirstName.BorderRadius = 2
        Me.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFirstName.DefaultText = ""
        Me.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.DisabledState.Parent = Me.tbFirstName
        Me.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.FocusedState.Parent = Me.tbFirstName
        Me.tbFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.HoverState.Parent = Me.tbFirstName
        Me.tbFirstName.Location = New System.Drawing.Point(468, 124)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFirstName.PlaceholderText = "Prénom"
        Me.tbFirstName.SelectedText = ""
        Me.tbFirstName.ShadowDecoration.Parent = Me.tbFirstName
        Me.tbFirstName.Size = New System.Drawing.Size(175, 36)
        Me.tbFirstName.TabIndex = 42
        '
        'labName
        '
        Me.labName.BackColor = System.Drawing.Color.Transparent
        Me.labName.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labName.Location = New System.Drawing.Point(267, 128)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(43, 27)
        Me.labName.TabIndex = 50
        Me.labName.Text = "Nom"
        '
        'labCodeUser
        '
        Me.labCodeUser.BackColor = System.Drawing.Color.Transparent
        Me.labCodeUser.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCodeUser.Location = New System.Drawing.Point(267, 50)
        Me.labCodeUser.Name = "labCodeUser"
        Me.labCodeUser.Size = New System.Drawing.Size(75, 27)
        Me.labCodeUser.TabIndex = 48
        Me.labCodeUser.Text = "Matricule"
        '
        'UCUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCUserAdd"
        Me.Size = New System.Drawing.Size(1263, 744)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        CType(Me.numExtension2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExtension1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btCancelUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btBack As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents labStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbPhone2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labPhone2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbPhone1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents numCode As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labCodeUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labPermissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dropPermissions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dropStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents labSetPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkPassword As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents numExtension2 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents numExtension1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents labExt2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkExt2 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents labExt1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkExt1 As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
