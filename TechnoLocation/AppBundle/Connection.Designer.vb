<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Connection
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connection))
        Me.labUsername = New System.Windows.Forms.Label()
        Me.labPassword = New System.Windows.Forms.Label()
        Me.linklabPasswordForget = New System.Windows.Forms.LinkLabel()
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.labLang = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btConnect = New Guna.UI2.WinForms.Guna2Button()
        Me.tbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labUsername
        '
        Me.labUsername.AutoSize = True
        Me.labUsername.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUsername.Location = New System.Drawing.Point(65, 93)
        Me.labUsername.Name = "labUsername"
        Me.labUsername.Size = New System.Drawing.Size(77, 20)
        Me.labUsername.TabIndex = 6
        Me.labUsername.Text = "Identifiant"
        '
        'labPassword
        '
        Me.labPassword.AutoSize = True
        Me.labPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPassword.Location = New System.Drawing.Point(65, 135)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(98, 20)
        Me.labPassword.TabIndex = 6
        Me.labPassword.Text = "Mot de passe"
        '
        'linklabPasswordForget
        '
        Me.linklabPasswordForget.AutoSize = True
        Me.linklabPasswordForget.Font = New System.Drawing.Font("Segoe UI Symbol", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklabPasswordForget.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linklabPasswordForget.Location = New System.Drawing.Point(67, 167)
        Me.linklabPasswordForget.Name = "linklabPasswordForget"
        Me.linklabPasswordForget.Size = New System.Drawing.Size(98, 12)
        Me.linklabPasswordForget.TabIndex = 2
        Me.linklabPasswordForget.TabStop = True
        Me.linklabPasswordForget.Text = "Mot de passe oublié?"
        '
        'panelHeaderBar
        '
        Me.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelHeaderBar.Controls.Add(Me.labLang)
        Me.panelHeaderBar.Controls.Add(Me.Guna2VSeparator1)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMinimize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderClose)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(402, 45)
        Me.panelHeaderBar.TabIndex = 8
        '
        'labLang
        '
        Me.labLang.AutoSize = False
        Me.labLang.BackColor = System.Drawing.Color.Transparent
        Me.labLang.Dock = System.Windows.Forms.DockStyle.Right
        Me.labLang.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLang.ForeColor = System.Drawing.Color.White
        Me.labLang.Location = New System.Drawing.Point(280, 0)
        Me.labLang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.labLang.Name = "labLang"
        Me.labLang.Size = New System.Drawing.Size(34, 45)
        Me.labLang.TabIndex = 10
        Me.labLang.Text = "EN"
        Me.labLang.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(49, 10)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(8, 27)
        Me.Guna2VSeparator1.TabIndex = 9
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(314, 0)
        Me.btHeaderMinimize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btHeaderMinimize.Name = "btHeaderMinimize"
        Me.btHeaderMinimize.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderMinimize.PressedState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Size = New System.Drawing.Size(44, 45)
        Me.btHeaderMinimize.TabIndex = 4
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
        Me.btHeaderClose.Location = New System.Drawing.Point(358, 0)
        Me.btHeaderClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btHeaderClose.Name = "btHeaderClose"
        Me.btHeaderClose.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_clear_light_main_18dp
        Me.btHeaderClose.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderClose.PressedState.Parent = Me.btHeaderClose
        Me.btHeaderClose.Size = New System.Drawing.Size(44, 45)
        Me.btHeaderClose.TabIndex = 5
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
        'btConnect
        '
        Me.btConnect.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btConnect.BorderRadius = 12
        Me.btConnect.BorderThickness = 1
        Me.btConnect.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConnect.CheckedState.Parent = Me.btConnect
        Me.btConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConnect.CustomImages.Parent = Me.btConnect
        Me.btConnect.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btConnect.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btConnect.ForeColor = System.Drawing.Color.White
        Me.btConnect.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btConnect.HoverState.Parent = Me.btConnect
        Me.btConnect.Location = New System.Drawing.Point(123, 206)
        Me.btConnect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btConnect.Name = "btConnect"
        Me.btConnect.PressedColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btConnect.PressedDepth = 45
        Me.btConnect.ShadowDecoration.Parent = Me.btConnect
        Me.btConnect.Size = New System.Drawing.Size(135, 37)
        Me.btConnect.TabIndex = 3
        Me.btConnect.Text = "Connexion"
        '
        'tbUsername
        '
        Me.tbUsername.BorderRadius = 2
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.DisabledState.Parent = Me.tbUsername
        Me.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.FocusedState.Parent = Me.tbUsername
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.HoverState.Parent = Me.tbUsername
        Me.tbUsername.Location = New System.Drawing.Point(181, 84)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.PlaceholderText = "Matricule"
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.ShadowDecoration.Parent = Me.tbUsername
        Me.tbUsername.Size = New System.Drawing.Size(150, 29)
        Me.tbUsername.TabIndex = 0
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
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.HoverState.Parent = Me.tbPassword
        Me.tbPassword.Location = New System.Drawing.Point(181, 126)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.ShadowDecoration.Parent = Me.tbPassword
        Me.tbPassword.Size = New System.Drawing.Size(150, 29)
        Me.tbPassword.TabIndex = 1
        '
        'Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 278)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.btConnect)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.Controls.Add(Me.linklabPasswordForget)
        Me.Controls.Add(Me.labPassword)
        Me.Controls.Add(Me.labUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labUsername As Label
    Friend WithEvents labPassword As Label
    Friend WithEvents linklabPasswordForget As LinkLabel
    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btConnect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents labLang As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
