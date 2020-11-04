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
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderMaximize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelOptions = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.btRent = New Guna.UI2.WinForms.Guna2Button()
        Me.btAlert = New Guna.UI2.WinForms.Guna2Button()
        Me.btHome = New Guna.UI2.WinForms.Guna2Button()
        Me.labPersonConnected = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btDisconnection = New System.Windows.Forms.Button()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btCalendar = New System.Windows.Forms.Button()
        Me.btHistory = New System.Windows.Forms.Button()
        Me.btEquipment = New System.Windows.Forms.Button()
        Me.panelMain = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeaderBar
        '
        Me.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelHeaderBar.Controls.Add(Me.Guna2VSeparator1)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMinimize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMaximize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderClose)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(1155, 45)
        Me.panelHeaderBar.TabIndex = 12
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(49, 10)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(8, 27)
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
        Me.btHeaderMinimize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btHeaderMaximize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btHeaderClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.PictureBox1.Location = New System.Drawing.Point(9, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelOptions
        '
        Me.panelOptions.BackColor = System.Drawing.Color.Transparent
        Me.panelOptions.Controls.Add(Me.btUser)
        Me.panelOptions.Controls.Add(Me.btReturn)
        Me.panelOptions.Controls.Add(Me.btRent)
        Me.panelOptions.Controls.Add(Me.btAlert)
        Me.panelOptions.Controls.Add(Me.btHome)
        Me.panelOptions.Controls.Add(Me.labPersonConnected)
        Me.panelOptions.Controls.Add(Me.btDisconnection)
        Me.panelOptions.Controls.Add(Me.btQuit)
        Me.panelOptions.Controls.Add(Me.btCalendar)
        Me.panelOptions.Controls.Add(Me.btHistory)
        Me.panelOptions.Controls.Add(Me.btEquipment)
        Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOptions.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.panelOptions.Location = New System.Drawing.Point(0, 45)
        Me.panelOptions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelOptions.Name = "panelOptions"
        Me.panelOptions.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.panelOptions.ShadowDepth = 200
        Me.panelOptions.ShadowShift = 6
        Me.panelOptions.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.panelOptions.Size = New System.Drawing.Size(208, 604)
        Me.panelOptions.TabIndex = 13
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
        Me.btUser.Location = New System.Drawing.Point(6, 207)
        Me.btUser.Margin = New System.Windows.Forms.Padding(2, 11, 8, 2)
        Me.btUser.MaximumSize = New System.Drawing.Size(202, 37)
        Me.btUser.Name = "btUser"
        Me.btUser.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btUser.PressedDepth = 45
        Me.btUser.ShadowDecoration.Parent = Me.btUser
        Me.btUser.Size = New System.Drawing.Size(190, 37)
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
        Me.btReturn.Location = New System.Drawing.Point(6, 167)
        Me.btReturn.Margin = New System.Windows.Forms.Padding(2, 11, 8, 2)
        Me.btReturn.MaximumSize = New System.Drawing.Size(202, 37)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btReturn.PressedDepth = 45
        Me.btReturn.ShadowDecoration.Parent = Me.btReturn
        Me.btReturn.Size = New System.Drawing.Size(190, 37)
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
        Me.btRent.Location = New System.Drawing.Point(6, 126)
        Me.btRent.Margin = New System.Windows.Forms.Padding(2, 11, 8, 2)
        Me.btRent.MaximumSize = New System.Drawing.Size(202, 37)
        Me.btRent.Name = "btRent"
        Me.btRent.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btRent.PressedDepth = 45
        Me.btRent.ShadowDecoration.Parent = Me.btRent
        Me.btRent.Size = New System.Drawing.Size(190, 37)
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
        Me.btAlert.Location = New System.Drawing.Point(6, 85)
        Me.btAlert.Margin = New System.Windows.Forms.Padding(2, 11, 8, 2)
        Me.btAlert.MaximumSize = New System.Drawing.Size(202, 37)
        Me.btAlert.Name = "btAlert"
        Me.btAlert.PressedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btAlert.PressedDepth = 45
        Me.btAlert.ShadowDecoration.Parent = Me.btAlert
        Me.btAlert.Size = New System.Drawing.Size(190, 37)
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
        Me.btHome.Margin = New System.Windows.Forms.Padding(2, 11, 8, 2)
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
        Me.labPersonConnected.Location = New System.Drawing.Point(9, 0)
        Me.labPersonConnected.Margin = New System.Windows.Forms.Padding(2, 2, 2, 8)
        Me.labPersonConnected.MaximumSize = New System.Drawing.Size(202, 37)
        Me.labPersonConnected.Name = "labPersonConnected"
        Me.labPersonConnected.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.labPersonConnected.Size = New System.Drawing.Size(184, 37)
        Me.labPersonConnected.TabIndex = 22
        Me.labPersonConnected.Text = "Bonjour, "
        '
        'btDisconnection
        '
        Me.btDisconnection.Location = New System.Drawing.Point(14, 445)
        Me.btDisconnection.Name = "btDisconnection"
        Me.btDisconnection.Size = New System.Drawing.Size(180, 36)
        Me.btDisconnection.TabIndex = 21
        Me.btDisconnection.Text = "Déconnexion"
        Me.btDisconnection.UseVisualStyleBackColor = True
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(14, 488)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(180, 36)
        Me.btQuit.TabIndex = 20
        Me.btQuit.Text = "Quitter"
        Me.btQuit.UseVisualStyleBackColor = True
        '
        'btCalendar
        '
        Me.btCalendar.Location = New System.Drawing.Point(14, 389)
        Me.btCalendar.Name = "btCalendar"
        Me.btCalendar.Size = New System.Drawing.Size(180, 36)
        Me.btCalendar.TabIndex = 19
        Me.btCalendar.Text = "Calendrier de Restrictions"
        Me.btCalendar.UseVisualStyleBackColor = True
        '
        'btHistory
        '
        Me.btHistory.Location = New System.Drawing.Point(14, 347)
        Me.btHistory.Name = "btHistory"
        Me.btHistory.Size = New System.Drawing.Size(180, 36)
        Me.btHistory.TabIndex = 18
        Me.btHistory.Text = "Historique"
        Me.btHistory.UseVisualStyleBackColor = True
        '
        'btEquipment
        '
        Me.btEquipment.Location = New System.Drawing.Point(14, 305)
        Me.btEquipment.Name = "btEquipment"
        Me.btEquipment.Size = New System.Drawing.Size(180, 36)
        Me.btEquipment.TabIndex = 17
        Me.btEquipment.Text = "Équipement"
        Me.btEquipment.UseVisualStyleBackColor = True
        '
        'panelMain
        '
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panelMain.Location = New System.Drawing.Point(208, 45)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderMaximize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelOptions As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btDisconnection As Button
    Friend WithEvents btQuit As Button
    Friend WithEvents btCalendar As Button
    Friend WithEvents btHistory As Button
    Friend WithEvents btEquipment As Button
    Friend WithEvents panelMain As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents labPersonConnected As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btAlert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btRent As Guna.UI2.WinForms.Guna2Button
End Class
