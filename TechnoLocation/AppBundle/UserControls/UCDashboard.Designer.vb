<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCDashboard
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
        Me.panelUC = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelMiddle = New Guna.UI2.WinForms.Guna2Panel()
        Me.lab_late = New System.Windows.Forms.Label()
        Me.panelBottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.gridLate = New System.Windows.Forms.DataGridView()
        Me.panelTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelDepositCount = New Guna.UI2.WinForms.Guna2Panel()
        Me.labDepositCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labDepositName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelBetweenTop3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelInactiveUsers = New Guna.UI2.WinForms.Guna2Panel()
        Me.labInactiveUserCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labInactiveUserName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelBetweenTop2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelTotalUsers = New Guna.UI2.WinForms.Guna2Panel()
        Me.labTotalUserCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labTotalUserName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelBetweenTop1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelRentCount = New Guna.UI2.WinForms.Guna2Panel()
        Me.labRentCountCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labRentCountName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelUC.SuspendLayout()
        Me.panelMiddle.SuspendLayout()
        Me.panelBottom.SuspendLayout()
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.panelDepositCount.SuspendLayout()
        Me.panelInactiveUsers.SuspendLayout()
        Me.panelTotalUsers.SuspendLayout()
        Me.panelRentCount.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUC
        '
        Me.panelUC.Controls.Add(Me.panelMiddle)
        Me.panelUC.Controls.Add(Me.panelBottom)
        Me.panelUC.Controls.Add(Me.panelTop)
        Me.panelUC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUC.Location = New System.Drawing.Point(0, 0)
        Me.panelUC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelUC.Name = "panelUC"
        Me.panelUC.ShadowDecoration.Parent = Me.panelUC
        Me.panelUC.Size = New System.Drawing.Size(1263, 743)
        Me.panelUC.TabIndex = 0
        '
        'panelMiddle
        '
        Me.panelMiddle.Controls.Add(Me.lab_late)
        Me.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMiddle.Location = New System.Drawing.Point(0, 180)
        Me.panelMiddle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelMiddle.Name = "panelMiddle"
        Me.panelMiddle.ShadowDecoration.Parent = Me.panelMiddle
        Me.panelMiddle.Size = New System.Drawing.Size(1263, 380)
        Me.panelMiddle.TabIndex = 2
        '
        'lab_late
        '
        Me.lab_late.AutoSize = True
        Me.lab_late.Location = New System.Drawing.Point(572, 361)
        Me.lab_late.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_late.Name = "lab_late"
        Me.lab_late.Size = New System.Drawing.Size(106, 17)
        Me.lab_late.TabIndex = 15
        Me.lab_late.Text = "Alertes Retards"
        '
        'panelBottom
        '
        Me.panelBottom.Controls.Add(Me.gridLate)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 560)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.ShadowDecoration.Parent = Me.panelBottom
        Me.panelBottom.Size = New System.Drawing.Size(1263, 183)
        Me.panelBottom.TabIndex = 1
        '
        'gridLate
        '
        Me.gridLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridLate.Location = New System.Drawing.Point(0, 0)
        Me.gridLate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridLate.Name = "gridLate"
        Me.gridLate.RowHeadersWidth = 51
        Me.gridLate.Size = New System.Drawing.Size(1263, 183)
        Me.gridLate.TabIndex = 14
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.panelDepositCount)
        Me.panelTop.Controls.Add(Me.panelBetweenTop3)
        Me.panelTop.Controls.Add(Me.panelInactiveUsers)
        Me.panelTop.Controls.Add(Me.panelBetweenTop2)
        Me.panelTop.Controls.Add(Me.panelTotalUsers)
        Me.panelTop.Controls.Add(Me.panelBetweenTop1)
        Me.panelTop.Controls.Add(Me.panelRentCount)
        Me.panelTop.Controls.Add(Me.Guna2Panel2)
        Me.panelTop.Controls.Add(Me.Guna2Panel4)
        Me.panelTop.Controls.Add(Me.Guna2Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.ShadowDecoration.Parent = Me.panelTop
        Me.panelTop.Size = New System.Drawing.Size(1263, 180)
        Me.panelTop.TabIndex = 0
        '
        'panelDepositCount
        '
        Me.panelDepositCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelDepositCount.BorderRadius = 10
        Me.panelDepositCount.Controls.Add(Me.labDepositCount)
        Me.panelDepositCount.Controls.Add(Me.labDepositName)
        Me.panelDepositCount.Controls.Add(Me.Guna2Panel13)
        Me.panelDepositCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelDepositCount.Location = New System.Drawing.Point(937, 20)
        Me.panelDepositCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelDepositCount.Name = "panelDepositCount"
        Me.panelDepositCount.ShadowDecoration.Parent = Me.panelDepositCount
        Me.panelDepositCount.Size = New System.Drawing.Size(275, 160)
        Me.panelDepositCount.TabIndex = 27
        '
        'labDepositCount
        '
        Me.labDepositCount.BackColor = System.Drawing.Color.Transparent
        Me.labDepositCount.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDepositCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.labDepositCount.Location = New System.Drawing.Point(29, 18)
        Me.labDepositCount.Margin = New System.Windows.Forms.Padding(0)
        Me.labDepositCount.Name = "labDepositCount"
        Me.labDepositCount.Size = New System.Drawing.Size(278, 91)
        Me.labDepositCount.TabIndex = 10
        Me.labDepositCount.Text = "9999.99$"
        Me.labDepositCount.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labDepositName
        '
        Me.labDepositName.BackColor = System.Drawing.Color.Transparent
        Me.labDepositName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDepositName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.labDepositName.Location = New System.Drawing.Point(29, 123)
        Me.labDepositName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.labDepositName.Name = "labDepositName"
        Me.labDepositName.Size = New System.Drawing.Size(175, 25)
        Me.labDepositName.TabIndex = 9
        Me.labDepositName.Text = "Montant des dépots"
        Me.labDepositName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.BackColor = System.Drawing.Color.White
        Me.Guna2Panel13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Panel13.BorderRadius = 5
        Me.Guna2Panel13.BorderThickness = 1
        Me.Guna2Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel13.FillColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.ShadowDecoration.Parent = Me.Guna2Panel13
        Me.Guna2Panel13.Size = New System.Drawing.Size(11, 160)
        Me.Guna2Panel13.TabIndex = 8
        '
        'panelBetweenTop3
        '
        Me.panelBetweenTop3.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelBetweenTop3.Location = New System.Drawing.Point(917, 20)
        Me.panelBetweenTop3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelBetweenTop3.Name = "panelBetweenTop3"
        Me.panelBetweenTop3.ShadowDecoration.Parent = Me.panelBetweenTop3
        Me.panelBetweenTop3.Size = New System.Drawing.Size(20, 160)
        Me.panelBetweenTop3.TabIndex = 26
        '
        'panelInactiveUsers
        '
        Me.panelInactiveUsers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelInactiveUsers.BorderRadius = 10
        Me.panelInactiveUsers.Controls.Add(Me.labInactiveUserCount)
        Me.panelInactiveUsers.Controls.Add(Me.labInactiveUserName)
        Me.panelInactiveUsers.Controls.Add(Me.Guna2Panel10)
        Me.panelInactiveUsers.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelInactiveUsers.Location = New System.Drawing.Point(642, 20)
        Me.panelInactiveUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelInactiveUsers.Name = "panelInactiveUsers"
        Me.panelInactiveUsers.ShadowDecoration.Parent = Me.panelInactiveUsers
        Me.panelInactiveUsers.Size = New System.Drawing.Size(275, 160)
        Me.panelInactiveUsers.TabIndex = 25
        '
        'labInactiveUserCount
        '
        Me.labInactiveUserCount.BackColor = System.Drawing.Color.Transparent
        Me.labInactiveUserCount.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labInactiveUserCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.labInactiveUserCount.Location = New System.Drawing.Point(51, 18)
        Me.labInactiveUserCount.Margin = New System.Windows.Forms.Padding(0)
        Me.labInactiveUserCount.Name = "labInactiveUserCount"
        Me.labInactiveUserCount.Size = New System.Drawing.Size(40, 91)
        Me.labInactiveUserCount.TabIndex = 10
        Me.labInactiveUserCount.Text = "9"
        Me.labInactiveUserCount.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labInactiveUserName
        '
        Me.labInactiveUserName.BackColor = System.Drawing.Color.Transparent
        Me.labInactiveUserName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labInactiveUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.labInactiveUserName.Location = New System.Drawing.Point(31, 123)
        Me.labInactiveUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.labInactiveUserName.Name = "labInactiveUserName"
        Me.labInactiveUserName.Size = New System.Drawing.Size(167, 25)
        Me.labInactiveUserName.TabIndex = 9
        Me.labInactiveUserName.Text = "Utilisateurs Inactifs"
        Me.labInactiveUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.BackColor = System.Drawing.Color.White
        Me.Guna2Panel10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2Panel10.BorderRadius = 5
        Me.Guna2Panel10.BorderThickness = 1
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel10.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.ShadowDecoration.Parent = Me.Guna2Panel10
        Me.Guna2Panel10.Size = New System.Drawing.Size(11, 160)
        Me.Guna2Panel10.TabIndex = 8
        '
        'panelBetweenTop2
        '
        Me.panelBetweenTop2.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelBetweenTop2.Location = New System.Drawing.Point(622, 20)
        Me.panelBetweenTop2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelBetweenTop2.Name = "panelBetweenTop2"
        Me.panelBetweenTop2.ShadowDecoration.Parent = Me.panelBetweenTop2
        Me.panelBetweenTop2.Size = New System.Drawing.Size(20, 160)
        Me.panelBetweenTop2.TabIndex = 24
        '
        'panelTotalUsers
        '
        Me.panelTotalUsers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelTotalUsers.BorderRadius = 10
        Me.panelTotalUsers.Controls.Add(Me.labTotalUserCount)
        Me.panelTotalUsers.Controls.Add(Me.labTotalUserName)
        Me.panelTotalUsers.Controls.Add(Me.Guna2Panel7)
        Me.panelTotalUsers.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelTotalUsers.Location = New System.Drawing.Point(347, 20)
        Me.panelTotalUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelTotalUsers.Name = "panelTotalUsers"
        Me.panelTotalUsers.ShadowDecoration.Parent = Me.panelTotalUsers
        Me.panelTotalUsers.Size = New System.Drawing.Size(275, 160)
        Me.panelTotalUsers.TabIndex = 23
        '
        'labTotalUserCount
        '
        Me.labTotalUserCount.BackColor = System.Drawing.Color.Transparent
        Me.labTotalUserCount.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalUserCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.labTotalUserCount.Location = New System.Drawing.Point(48, 18)
        Me.labTotalUserCount.Margin = New System.Windows.Forms.Padding(0)
        Me.labTotalUserCount.Name = "labTotalUserCount"
        Me.labTotalUserCount.Size = New System.Drawing.Size(77, 91)
        Me.labTotalUserCount.TabIndex = 7
        Me.labTotalUserCount.Text = "99"
        Me.labTotalUserCount.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labTotalUserName
        '
        Me.labTotalUserName.BackColor = System.Drawing.Color.Transparent
        Me.labTotalUserName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.labTotalUserName.Location = New System.Drawing.Point(28, 123)
        Me.labTotalUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.labTotalUserName.Name = "labTotalUserName"
        Me.labTotalUserName.Size = New System.Drawing.Size(199, 25)
        Me.labTotalUserName.TabIndex = 6
        Me.labTotalUserName.Text = "Utilisateurs enregistrés"
        Me.labTotalUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.White
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Guna2Panel7.BorderRadius = 5
        Me.Guna2Panel7.BorderThickness = 1
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(11, 160)
        Me.Guna2Panel7.TabIndex = 5
        '
        'panelBetweenTop1
        '
        Me.panelBetweenTop1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelBetweenTop1.Location = New System.Drawing.Point(327, 20)
        Me.panelBetweenTop1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelBetweenTop1.Name = "panelBetweenTop1"
        Me.panelBetweenTop1.ShadowDecoration.Parent = Me.panelBetweenTop1
        Me.panelBetweenTop1.Size = New System.Drawing.Size(20, 160)
        Me.panelBetweenTop1.TabIndex = 5
        '
        'panelRentCount
        '
        Me.panelRentCount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelRentCount.BorderRadius = 10
        Me.panelRentCount.Controls.Add(Me.labRentCountCount)
        Me.panelRentCount.Controls.Add(Me.labRentCountName)
        Me.panelRentCount.Controls.Add(Me.Guna2Panel3)
        Me.panelRentCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelRentCount.Location = New System.Drawing.Point(52, 20)
        Me.panelRentCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelRentCount.Name = "panelRentCount"
        Me.panelRentCount.ShadowDecoration.Parent = Me.panelRentCount
        Me.panelRentCount.Size = New System.Drawing.Size(275, 160)
        Me.panelRentCount.TabIndex = 21
        '
        'labRentCountCount
        '
        Me.labRentCountCount.BackColor = System.Drawing.Color.Transparent
        Me.labRentCountCount.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRentCountCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.labRentCountCount.Location = New System.Drawing.Point(37, 18)
        Me.labRentCountCount.Margin = New System.Windows.Forms.Padding(0)
        Me.labRentCountCount.Name = "labRentCountCount"
        Me.labRentCountCount.Size = New System.Drawing.Size(188, 91)
        Me.labRentCountCount.TabIndex = 4
        Me.labRentCountCount.Text = "99999"
        Me.labRentCountCount.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labRentCountName
        '
        Me.labRentCountName.BackColor = System.Drawing.Color.Transparent
        Me.labRentCountName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRentCountName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.labRentCountName.Location = New System.Drawing.Point(27, 123)
        Me.labRentCountName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.labRentCountName.Name = "labRentCountName"
        Me.labRentCountName.Size = New System.Drawing.Size(163, 25)
        Me.labRentCountName.TabIndex = 2
        Me.labRentCountName.Text = "Emprunts en cours"
        Me.labRentCountName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(11, 160)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(52, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1160, 20)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel4.Location = New System.Drawing.Point(1212, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(51, 180)
        Me.Guna2Panel4.TabIndex = 19
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(52, 180)
        Me.Guna2Panel1.TabIndex = 0
        '
        'UCDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.panelUC)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCDashboard"
        Me.Size = New System.Drawing.Size(1263, 743)
        Me.panelUC.ResumeLayout(False)
        Me.panelMiddle.ResumeLayout(False)
        Me.panelMiddle.PerformLayout()
        Me.panelBottom.ResumeLayout(False)
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelDepositCount.ResumeLayout(False)
        Me.panelDepositCount.PerformLayout()
        Me.panelInactiveUsers.ResumeLayout(False)
        Me.panelInactiveUsers.PerformLayout()
        Me.panelTotalUsers.ResumeLayout(False)
        Me.panelTotalUsers.PerformLayout()
        Me.panelRentCount.ResumeLayout(False)
        Me.panelRentCount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelUC As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelMiddle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelBottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gridLate As DataGridView
    Friend WithEvents lab_late As Label
    Friend WithEvents panelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelTotalUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labTotalUserCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labTotalUserName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelBetweenTop1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelRentCount As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labRentCountCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labRentCountName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelInactiveUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labInactiveUserCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labInactiveUserName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelBetweenTop2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelDepositCount As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labDepositCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labDepositName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelBetweenTop3 As Guna.UI2.WinForms.Guna2Panel
End Class
