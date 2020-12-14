<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.labLang = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labAccount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderMaximize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelOptions = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.labSide6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labSide0 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelAccountOptions = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.labDisconnect = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labProfile = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btEquipment = New Guna.UI2.WinForms.Guna2Button()
        Me.btUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.btRent = New Guna.UI2.WinForms.Guna2Button()
        Me.btAlert = New Guna.UI2.WinForms.Guna2Button()
        Me.btHome = New Guna.UI2.WinForms.Guna2Button()
        Me.labPersonConnected = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelMain = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOptions.SuspendLayout()
        Me.panelAccountOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeaderBar
        '
        Me.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelHeaderBar.Controls.Add(Me.labLang)
        Me.panelHeaderBar.Controls.Add(Me.labAccount)
        Me.panelHeaderBar.Controls.Add(Me.Guna2VSeparator1)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMinimize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMaximize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderClose)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Margin = New System.Windows.Forms.Padding(0)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(1155, 45)
        Me.panelHeaderBar.TabIndex = 12
        '
        'labLang
        '
        Me.labLang.AutoSize = False
        Me.labLang.BackColor = System.Drawing.Color.Transparent
        Me.labLang.Dock = System.Windows.Forms.DockStyle.Right
        Me.labLang.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLang.ForeColor = System.Drawing.Color.White
        Me.labLang.Location = New System.Drawing.Point(989, 0)
        Me.labLang.Margin = New System.Windows.Forms.Padding(0)
        Me.labLang.Name = "labLang"
        Me.labLang.Size = New System.Drawing.Size(34, 45)
        Me.labLang.TabIndex = 11
        Me.labLang.Text = "EN"
        Me.labLang.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labAccount
        '
        Me.labAccount.AutoSize = False
        Me.labAccount.BackColor = System.Drawing.Color.Transparent
        Me.labAccount.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAccount.ForeColor = System.Drawing.Color.White
        Me.labAccount.Location = New System.Drawing.Point(62, 0)
        Me.labAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.labAccount.Name = "labAccount"
        Me.labAccount.Size = New System.Drawing.Size(90, 63)
        Me.labAccount.TabIndex = 4
        Me.labAccount.Text = "Compte"
        Me.labAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(50, 9)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 31)
        Me.Guna2VSeparator1.TabIndex = 3
        '
        'btHeaderMinimize
        '
        Me.btHeaderMinimize.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btHeaderMinimize.CheckedState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btHeaderMinimize.HoverState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderMinimize.HoverState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.ImageRotate = 0!
        Me.btHeaderMinimize.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderMinimize.Location = New System.Drawing.Point(1023, 0)
        Me.btHeaderMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btHeaderMinimize.Name = "btHeaderMinimize"
        Me.btHeaderMinimize.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderMinimize.PressedState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Size = New System.Drawing.Size(44, 45)
        Me.btHeaderMinimize.TabIndex = 0
        '
        'btHeaderMaximize
        '
        Me.btHeaderMaximize.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btHeaderMaximize.CheckedState.Parent = Me.btHeaderMaximize
        Me.btHeaderMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btHeaderMaximize.HoverState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_maximize_2_light_main_18dp
        Me.btHeaderMaximize.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderMaximize.HoverState.Parent = Me.btHeaderMaximize
        Me.btHeaderMaximize.Image = Global.TechnoLocation.My.Resources.Resources.baseline_maximize_2_light_main_18dp
        Me.btHeaderMaximize.ImageRotate = 0!
        Me.btHeaderMaximize.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderMaximize.Location = New System.Drawing.Point(1067, 0)
        Me.btHeaderMaximize.Margin = New System.Windows.Forms.Padding(2)
        Me.btHeaderMaximize.Name = "btHeaderMaximize"
        Me.btHeaderMaximize.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_maximize_2_light_main_18dp
        Me.btHeaderMaximize.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderMaximize.PressedState.Parent = Me.btHeaderMaximize
        Me.btHeaderMaximize.Size = New System.Drawing.Size(44, 45)
        Me.btHeaderMaximize.TabIndex = 1
        '
        'btHeaderClose
        '
        Me.btHeaderClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btHeaderClose.CheckedState.Parent = Me.btHeaderClose
        Me.btHeaderClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHeaderClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btHeaderClose.HoverState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_clear_light_main_18dp
        Me.btHeaderClose.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderClose.HoverState.Parent = Me.btHeaderClose
        Me.btHeaderClose.Image = Global.TechnoLocation.My.Resources.Resources.baseline_clear_light_main_18dp
        Me.btHeaderClose.ImageRotate = 0!
        Me.btHeaderClose.ImageSize = New System.Drawing.Size(30, 30)
        Me.btHeaderClose.Location = New System.Drawing.Point(1111, 0)
        Me.btHeaderClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btHeaderClose.Name = "btHeaderClose"
        Me.btHeaderClose.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_clear_light_main_18dp
        Me.btHeaderClose.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderClose.PressedState.Parent = Me.btHeaderClose
        Me.btHeaderClose.Size = New System.Drawing.Size(44, 45)
        Me.btHeaderClose.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelOptions
        '
        Me.panelOptions.BackColor = System.Drawing.Color.Transparent
        Me.panelOptions.Controls.Add(Me.labSide6)
        Me.panelOptions.Controls.Add(Me.labSide5)
        Me.panelOptions.Controls.Add(Me.labSide4)
        Me.panelOptions.Controls.Add(Me.labSide3)
        Me.panelOptions.Controls.Add(Me.labSide2)
        Me.panelOptions.Controls.Add(Me.labSide1)
        Me.panelOptions.Controls.Add(Me.labSide0)
        Me.panelOptions.Controls.Add(Me.panelAccountOptions)
        Me.panelOptions.Controls.Add(Me.btHistory)
        Me.panelOptions.Controls.Add(Me.btEquipment)
        Me.panelOptions.Controls.Add(Me.btUser)
        Me.panelOptions.Controls.Add(Me.btReturn)
        Me.panelOptions.Controls.Add(Me.btRent)
        Me.panelOptions.Controls.Add(Me.btAlert)
        Me.panelOptions.Controls.Add(Me.btHome)
        Me.panelOptions.Controls.Add(Me.labPersonConnected)
        Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOptions.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.panelOptions.Location = New System.Drawing.Point(0, 45)
        Me.panelOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.panelOptions.Name = "panelOptions"
        Me.panelOptions.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.panelOptions.ShadowDepth = 200
        Me.panelOptions.ShadowShift = 6
        Me.panelOptions.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.panelOptions.Size = New System.Drawing.Size(208, 604)
        Me.panelOptions.TabIndex = 13
        '
        'labSide6
        '
        Me.labSide6.BackColor = System.Drawing.Color.Transparent
        Me.labSide6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide6.BorderRadius = 5
        Me.labSide6.BorderThickness = 1
        Me.labSide6.CustomizableEdges.BottomRight = False
        Me.labSide6.CustomizableEdges.TopRight = False
        Me.labSide6.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide6.Location = New System.Drawing.Point(6, 336)
        Me.labSide6.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide6.Name = "labSide6"
        Me.labSide6.ShadowDecoration.Parent = Me.labSide6
        Me.labSide6.Size = New System.Drawing.Size(8, 45)
        Me.labSide6.TabIndex = 32
        Me.labSide6.Visible = False
        '
        'labSide5
        '
        Me.labSide5.BackColor = System.Drawing.Color.Transparent
        Me.labSide5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide5.BorderRadius = 5
        Me.labSide5.BorderThickness = 1
        Me.labSide5.CustomizableEdges.BottomRight = False
        Me.labSide5.CustomizableEdges.TopRight = False
        Me.labSide5.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide5.Location = New System.Drawing.Point(6, 286)
        Me.labSide5.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide5.Name = "labSide5"
        Me.labSide5.ShadowDecoration.Parent = Me.labSide5
        Me.labSide5.Size = New System.Drawing.Size(8, 45)
        Me.labSide5.TabIndex = 35
        Me.labSide5.Visible = False
        '
        'labSide4
        '
        Me.labSide4.BackColor = System.Drawing.Color.Transparent
        Me.labSide4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide4.BorderRadius = 5
        Me.labSide4.BorderThickness = 1
        Me.labSide4.CustomizableEdges.BottomRight = False
        Me.labSide4.CustomizableEdges.TopRight = False
        Me.labSide4.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide4.Location = New System.Drawing.Point(6, 236)
        Me.labSide4.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide4.Name = "labSide4"
        Me.labSide4.ShadowDecoration.Parent = Me.labSide4
        Me.labSide4.Size = New System.Drawing.Size(8, 45)
        Me.labSide4.TabIndex = 34
        Me.labSide4.Visible = False
        '
        'labSide3
        '
        Me.labSide3.BackColor = System.Drawing.Color.Transparent
        Me.labSide3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide3.BorderRadius = 5
        Me.labSide3.BorderThickness = 1
        Me.labSide3.CustomizableEdges.BottomRight = False
        Me.labSide3.CustomizableEdges.TopRight = False
        Me.labSide3.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide3.Location = New System.Drawing.Point(6, 186)
        Me.labSide3.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide3.Name = "labSide3"
        Me.labSide3.ShadowDecoration.Parent = Me.labSide3
        Me.labSide3.Size = New System.Drawing.Size(8, 45)
        Me.labSide3.TabIndex = 33
        Me.labSide3.Visible = False
        '
        'labSide2
        '
        Me.labSide2.BackColor = System.Drawing.Color.Transparent
        Me.labSide2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide2.BorderRadius = 5
        Me.labSide2.BorderThickness = 1
        Me.labSide2.CustomizableEdges.BottomRight = False
        Me.labSide2.CustomizableEdges.TopRight = False
        Me.labSide2.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide2.Location = New System.Drawing.Point(6, 136)
        Me.labSide2.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide2.Name = "labSide2"
        Me.labSide2.ShadowDecoration.Parent = Me.labSide2
        Me.labSide2.Size = New System.Drawing.Size(8, 45)
        Me.labSide2.TabIndex = 32
        Me.labSide2.Visible = False
        '
        'labSide1
        '
        Me.labSide1.BackColor = System.Drawing.Color.Transparent
        Me.labSide1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide1.BorderRadius = 5
        Me.labSide1.BorderThickness = 1
        Me.labSide1.CustomizableEdges.BottomRight = False
        Me.labSide1.CustomizableEdges.TopRight = False
        Me.labSide1.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide1.Location = New System.Drawing.Point(6, 86)
        Me.labSide1.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide1.Name = "labSide1"
        Me.labSide1.ShadowDecoration.Parent = Me.labSide1
        Me.labSide1.Size = New System.Drawing.Size(8, 45)
        Me.labSide1.TabIndex = 31
        Me.labSide1.Visible = False
        '
        'labSide0
        '
        Me.labSide0.BackColor = System.Drawing.Color.Transparent
        Me.labSide0.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labSide0.BorderRadius = 5
        Me.labSide0.BorderThickness = 1
        Me.labSide0.CustomizableEdges.BottomRight = False
        Me.labSide0.CustomizableEdges.TopRight = False
        Me.labSide0.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.labSide0.Location = New System.Drawing.Point(6, 45)
        Me.labSide0.Margin = New System.Windows.Forms.Padding(2)
        Me.labSide0.Name = "labSide0"
        Me.labSide0.ShadowDecoration.Parent = Me.labSide0
        Me.labSide0.Size = New System.Drawing.Size(8, 37)
        Me.labSide0.TabIndex = 30
        Me.labSide0.Visible = False
        '
        'panelAccountOptions
        '
        Me.panelAccountOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelAccountOptions.Controls.Add(Me.Guna2Separator1)
        Me.panelAccountOptions.Controls.Add(Me.labDisconnect)
        Me.panelAccountOptions.Controls.Add(Me.labProfile)
        Me.panelAccountOptions.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panelAccountOptions.Location = New System.Drawing.Point(56, 0)
        Me.panelAccountOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.panelAccountOptions.Name = "panelAccountOptions"
        Me.panelAccountOptions.ShadowColor = System.Drawing.Color.Black
        Me.panelAccountOptions.Size = New System.Drawing.Size(140, 82)
        Me.panelAccountOptions.TabIndex = 0
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(10, 36)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(121, 8)
        Me.Guna2Separator1.TabIndex = 3
        '
        'labDisconnect
        '
        Me.labDisconnect.BackColor = System.Drawing.Color.Transparent
        Me.labDisconnect.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDisconnect.ForeColor = System.Drawing.Color.Black
        Me.labDisconnect.Location = New System.Drawing.Point(10, 49)
        Me.labDisconnect.Margin = New System.Windows.Forms.Padding(0)
        Me.labDisconnect.Name = "labDisconnect"
        Me.labDisconnect.Size = New System.Drawing.Size(72, 17)
        Me.labDisconnect.TabIndex = 2
        Me.labDisconnect.Text = "Déconnexion"
        Me.labDisconnect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labProfile
        '
        Me.labProfile.BackColor = System.Drawing.Color.Transparent
        Me.labProfile.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labProfile.ForeColor = System.Drawing.Color.Black
        Me.labProfile.Location = New System.Drawing.Point(10, 13)
        Me.labProfile.Margin = New System.Windows.Forms.Padding(0)
        Me.labProfile.Name = "labProfile"
        Me.labProfile.Size = New System.Drawing.Size(31, 17)
        Me.labProfile.TabIndex = 0
        Me.labProfile.Text = "Profil"
        Me.labProfile.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btHistory
        '
        Me.btHistory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btHistory.BorderRadius = 4
        Me.btHistory.BorderThickness = 1
        Me.btHistory.CheckedState.Parent = Me.btHistory
        Me.btHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHistory.CustomImages.Parent = Me.btHistory
        Me.btHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btHistory.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHistory.ForeColor = System.Drawing.Color.White
        Me.btHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btHistory.HoverState.Parent = Me.btHistory
        Me.btHistory.Location = New System.Drawing.Point(6, 336)
        Me.btHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.btHistory.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btHistory.Name = "btHistory"
        Me.btHistory.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btHistory.PressedDepth = 45
        Me.btHistory.ShadowDecoration.Parent = Me.btHistory
        Me.btHistory.Size = New System.Drawing.Size(190, 45)
        Me.btHistory.TabIndex = 28
        Me.btHistory.Text = "Historique"
        '
        'btEquipment
        '
        Me.btEquipment.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btEquipment.BorderRadius = 4
        Me.btEquipment.BorderThickness = 1
        Me.btEquipment.CheckedState.Parent = Me.btEquipment
        Me.btEquipment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEquipment.CustomImages.Parent = Me.btEquipment
        Me.btEquipment.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btEquipment.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEquipment.ForeColor = System.Drawing.Color.White
        Me.btEquipment.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btEquipment.HoverState.Parent = Me.btEquipment
        Me.btEquipment.Location = New System.Drawing.Point(6, 286)
        Me.btEquipment.Margin = New System.Windows.Forms.Padding(0)
        Me.btEquipment.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btEquipment.Name = "btEquipment"
        Me.btEquipment.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btEquipment.PressedDepth = 45
        Me.btEquipment.ShadowDecoration.Parent = Me.btEquipment
        Me.btEquipment.Size = New System.Drawing.Size(190, 45)
        Me.btEquipment.TabIndex = 27
        Me.btEquipment.Text = "Equipement"
        '
        'btUser
        '
        Me.btUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btUser.BorderRadius = 4
        Me.btUser.BorderThickness = 1
        Me.btUser.CheckedState.Parent = Me.btUser
        Me.btUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUser.CustomImages.Parent = Me.btUser
        Me.btUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btUser.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUser.ForeColor = System.Drawing.Color.White
        Me.btUser.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btUser.HoverState.Parent = Me.btUser
        Me.btUser.Location = New System.Drawing.Point(6, 236)
        Me.btUser.Margin = New System.Windows.Forms.Padding(0)
        Me.btUser.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btUser.Name = "btUser"
        Me.btUser.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btUser.PressedDepth = 45
        Me.btUser.ShadowDecoration.Parent = Me.btUser
        Me.btUser.Size = New System.Drawing.Size(190, 45)
        Me.btUser.TabIndex = 26
        Me.btUser.Text = "Utilisateurs"
        '
        'btReturn
        '
        Me.btReturn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btReturn.BorderRadius = 4
        Me.btReturn.BorderThickness = 1
        Me.btReturn.CheckedState.Parent = Me.btReturn
        Me.btReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btReturn.CustomImages.Parent = Me.btReturn
        Me.btReturn.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btReturn.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReturn.ForeColor = System.Drawing.Color.White
        Me.btReturn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btReturn.HoverState.Parent = Me.btReturn
        Me.btReturn.Location = New System.Drawing.Point(6, 186)
        Me.btReturn.Margin = New System.Windows.Forms.Padding(0)
        Me.btReturn.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btReturn.PressedDepth = 45
        Me.btReturn.ShadowDecoration.Parent = Me.btReturn
        Me.btReturn.Size = New System.Drawing.Size(190, 45)
        Me.btReturn.TabIndex = 25
        Me.btReturn.Text = "Retours"
        '
        'btRent
        '
        Me.btRent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btRent.BorderRadius = 4
        Me.btRent.BorderThickness = 1
        Me.btRent.CheckedState.Parent = Me.btRent
        Me.btRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRent.CustomImages.Parent = Me.btRent
        Me.btRent.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btRent.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRent.ForeColor = System.Drawing.Color.White
        Me.btRent.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btRent.HoverState.Parent = Me.btRent
        Me.btRent.Location = New System.Drawing.Point(6, 136)
        Me.btRent.Margin = New System.Windows.Forms.Padding(0)
        Me.btRent.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btRent.Name = "btRent"
        Me.btRent.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btRent.PressedDepth = 45
        Me.btRent.ShadowDecoration.Parent = Me.btRent
        Me.btRent.Size = New System.Drawing.Size(190, 45)
        Me.btRent.TabIndex = 24
        Me.btRent.Text = "Prêts"
        '
        'btAlert
        '
        Me.btAlert.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btAlert.BorderRadius = 4
        Me.btAlert.BorderThickness = 1
        Me.btAlert.CheckedState.Parent = Me.btAlert
        Me.btAlert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlert.CustomImages.Parent = Me.btAlert
        Me.btAlert.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btAlert.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlert.ForeColor = System.Drawing.Color.White
        Me.btAlert.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btAlert.HoverState.Parent = Me.btAlert
        Me.btAlert.Location = New System.Drawing.Point(6, 86)
        Me.btAlert.Margin = New System.Windows.Forms.Padding(0)
        Me.btAlert.MaximumSize = New System.Drawing.Size(269, 45)
        Me.btAlert.Name = "btAlert"
        Me.btAlert.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btAlert.PressedDepth = 45
        Me.btAlert.ShadowDecoration.Parent = Me.btAlert
        Me.btAlert.Size = New System.Drawing.Size(190, 45)
        Me.btAlert.TabIndex = 23
        Me.btAlert.Text = "Notifications"
        '
        'btHome
        '
        Me.btHome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btHome.BorderRadius = 4
        Me.btHome.BorderThickness = 1
        Me.btHome.CheckedState.Parent = Me.btHome
        Me.btHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHome.CustomImages.Parent = Me.btHome
        Me.btHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btHome.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHome.ForeColor = System.Drawing.Color.White
        Me.btHome.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btHome.HoverState.Parent = Me.btHome
        Me.btHome.Location = New System.Drawing.Point(6, 45)
        Me.btHome.Margin = New System.Windows.Forms.Padding(0)
        Me.btHome.MaximumSize = New System.Drawing.Size(202, 37)
        Me.btHome.Name = "btHome"
        Me.btHome.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btHome.PressedDepth = 45
        Me.btHome.ShadowDecoration.Parent = Me.btHome
        Me.btHome.Size = New System.Drawing.Size(190, 37)
        Me.btHome.TabIndex = 0
        Me.btHome.Text = "Acceuil"
        '
        'labPersonConnected
        '
        Me.labPersonConnected.AutoSize = False
        Me.labPersonConnected.BackColor = System.Drawing.Color.Transparent
        Me.labPersonConnected.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPersonConnected.ForeColor = System.Drawing.Color.White
        Me.labPersonConnected.Location = New System.Drawing.Point(6, 0)
        Me.labPersonConnected.Margin = New System.Windows.Forms.Padding(0)
        Me.labPersonConnected.MaximumSize = New System.Drawing.Size(269, 45)
        Me.labPersonConnected.Name = "labPersonConnected"
        Me.labPersonConnected.Size = New System.Drawing.Size(190, 45)
        Me.labPersonConnected.TabIndex = 22
        Me.labPersonConnected.Text = "Bonjour, "
        '
        'panelMain
        '
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panelMain.Location = New System.Drawing.Point(208, 45)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.ShadowDecoration.Parent = Me.panelMain
        Me.panelMain.Size = New System.Drawing.Size(947, 604)
        Me.panelMain.TabIndex = 14
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 649)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.panelOptions)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOptions.ResumeLayout(False)
        Me.panelAccountOptions.ResumeLayout(False)
        Me.panelAccountOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderMaximize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelOptions As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btEquipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btRent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAlert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labPersonConnected As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labAccount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labLang As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelMain As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents panelAccountOptions As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents labDisconnect As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labProfile As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labSide6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labSide0 As Guna.UI2.WinForms.Guna2Panel
End Class
