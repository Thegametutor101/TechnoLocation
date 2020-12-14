<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromptReturnEquipmentComment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromptReturnEquipmentComment))
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labAvailable = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkAvailable = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.tbComment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btKitAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeaderBar
        '
        Me.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelHeaderBar.Controls.Add(Me.Guna2VSeparator1)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMinimize)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(428, 55)
        Me.panelHeaderBar.TabIndex = 22
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(65, 12)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 33)
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(370, 0)
        Me.btHeaderMinimize.Name = "btHeaderMinimize"
        Me.btHeaderMinimize.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderMinimize.PressedState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Size = New System.Drawing.Size(58, 55)
        Me.btHeaderMinimize.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.labAvailable)
        Me.Guna2Panel1.Controls.Add(Me.checkAvailable)
        Me.Guna2Panel1.Controls.Add(Me.tbComment)
        Me.Guna2Panel1.Controls.Add(Me.labMessage)
        Me.Guna2Panel1.Controls.Add(Me.btKitAdd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(428, 381)
        Me.Guna2Panel1.TabIndex = 23
        '
        'labAvailable
        '
        Me.labAvailable.BackColor = System.Drawing.Color.Transparent
        Me.labAvailable.Location = New System.Drawing.Point(65, 93)
        Me.labAvailable.Name = "labAvailable"
        Me.labAvailable.Size = New System.Drawing.Size(182, 18)
        Me.labAvailable.TabIndex = 73
        Me.labAvailable.Text = "Afficher les emprunts en retard"
        '
        'checkAvailable
        '
        Me.checkAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailable.CheckedState.BorderRadius = 2
        Me.checkAvailable.CheckedState.BorderThickness = 2
        Me.checkAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkAvailable.CheckedState.Parent = Me.checkAvailable
        Me.checkAvailable.Location = New System.Drawing.Point(39, 92)
        Me.checkAvailable.Name = "checkAvailable"
        Me.checkAvailable.ShadowDecoration.Parent = Me.checkAvailable
        Me.checkAvailable.Size = New System.Drawing.Size(20, 20)
        Me.checkAvailable.TabIndex = 72
        Me.checkAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkAvailable.UncheckedState.BorderRadius = 2
        Me.checkAvailable.UncheckedState.BorderThickness = 2
        Me.checkAvailable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkAvailable.UncheckedState.Parent = Me.checkAvailable
        '
        'tbComment
        '
        Me.tbComment.AutoScroll = True
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
        Me.tbComment.Location = New System.Drawing.Point(34, 121)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbComment.PlaceholderText = ""
        Me.tbComment.SelectedText = ""
        Me.tbComment.ShadowDecoration.Parent = Me.tbComment
        Me.tbComment.Size = New System.Drawing.Size(356, 173)
        Me.tbComment.TabIndex = 34
        '
        'labMessage
        '
        Me.labMessage.AutoSize = False
        Me.labMessage.BackColor = System.Drawing.Color.Transparent
        Me.labMessage.Location = New System.Drawing.Point(0, 0)
        Me.labMessage.Name = "labMessage"
        Me.labMessage.Size = New System.Drawing.Size(110, 75)
        Me.labMessage.TabIndex = 27
        Me.labMessage.Text = "Guna2HtmlLabel1"
        '
        'btKitAdd
        '
        Me.btKitAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btKitAdd.BorderRadius = 15
        Me.btKitAdd.BorderThickness = 2
        Me.btKitAdd.CheckedState.Parent = Me.btKitAdd
        Me.btKitAdd.CustomImages.Parent = Me.btKitAdd
        Me.btKitAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btKitAdd.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btKitAdd.ForeColor = System.Drawing.Color.Black
        Me.btKitAdd.HoverState.Parent = Me.btKitAdd
        Me.btKitAdd.Location = New System.Drawing.Point(146, 318)
        Me.btKitAdd.Name = "btKitAdd"
        Me.btKitAdd.ShadowDecoration.Parent = Me.btKitAdd
        Me.btKitAdd.Size = New System.Drawing.Size(135, 45)
        Me.btKitAdd.TabIndex = 25
        Me.btKitAdd.Text = "Ajouter"
        '
        'PromptReturnEquipmentComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(428, 436)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PromptReturnEquipmentComment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromptReturnEquipmentComment"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btKitAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labMessage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbComment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labAvailable As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkAvailable As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
