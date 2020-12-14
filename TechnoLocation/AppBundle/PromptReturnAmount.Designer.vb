<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromptReturnAmount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromptReturnAmount))
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.numValue = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.labMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btKitCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btKitAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHeaderBar
        '
        Me.panelHeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.panelHeaderBar.Controls.Add(Me.Guna2VSeparator1)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderMinimize)
        Me.panelHeaderBar.Controls.Add(Me.btHeaderClose)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(477, 55)
        Me.panelHeaderBar.TabIndex = 15
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(361, 0)
        Me.btHeaderMinimize.Name = "btHeaderMinimize"
        Me.btHeaderMinimize.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_minimize_light_main_18dp
        Me.btHeaderMinimize.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderMinimize.PressedState.Parent = Me.btHeaderMinimize
        Me.btHeaderMinimize.Size = New System.Drawing.Size(58, 55)
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
        Me.btHeaderClose.Location = New System.Drawing.Point(419, 0)
        Me.btHeaderClose.Name = "btHeaderClose"
        Me.btHeaderClose.PressedState.Image = Global.TechnoLocation.My.Resources.Resources.baseline_clear_light_main_18dp
        Me.btHeaderClose.PressedState.ImageSize = New System.Drawing.Size(28, 28)
        Me.btHeaderClose.PressedState.Parent = Me.btHeaderClose
        Me.btHeaderClose.Size = New System.Drawing.Size(58, 55)
        Me.btHeaderClose.TabIndex = 5
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
        Me.Guna2Panel1.Controls.Add(Me.numValue)
        Me.Guna2Panel1.Controls.Add(Me.labMessage)
        Me.Guna2Panel1.Controls.Add(Me.btKitCancel)
        Me.Guna2Panel1.Controls.Add(Me.btKitAdd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(477, 248)
        Me.Guna2Panel1.TabIndex = 16
        '
        'numValue
        '
        Me.numValue.BackColor = System.Drawing.Color.Transparent
        Me.numValue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numValue.DecimalPlaces = 2
        Me.numValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numValue.DisabledState.Parent = Me.numValue
        Me.numValue.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numValue.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numValue.FocusedState.Parent = Me.numValue
        Me.numValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numValue.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numValue.Location = New System.Drawing.Point(92, 95)
        Me.numValue.Name = "numValue"
        Me.numValue.ShadowDecoration.Parent = Me.numValue
        Me.numValue.Size = New System.Drawing.Size(292, 36)
        Me.numValue.TabIndex = 23
        '
        'labMessage
        '
        Me.labMessage.AutoSize = False
        Me.labMessage.BackColor = System.Drawing.Color.Transparent
        Me.labMessage.Location = New System.Drawing.Point(0, 0)
        Me.labMessage.Name = "labMessage"
        Me.labMessage.Size = New System.Drawing.Size(110, 75)
        Me.labMessage.TabIndex = 22
        Me.labMessage.Text = "Guna2HtmlLabel1"
        '
        'btKitCancel
        '
        Me.btKitCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btKitCancel.BorderRadius = 15
        Me.btKitCancel.BorderThickness = 2
        Me.btKitCancel.CheckedState.Parent = Me.btKitCancel
        Me.btKitCancel.CustomImages.Parent = Me.btKitCancel
        Me.btKitCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btKitCancel.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btKitCancel.ForeColor = System.Drawing.Color.Black
        Me.btKitCancel.HoverState.Parent = Me.btKitCancel
        Me.btKitCancel.Location = New System.Drawing.Point(249, 179)
        Me.btKitCancel.Name = "btKitCancel"
        Me.btKitCancel.ShadowDecoration.Parent = Me.btKitCancel
        Me.btKitCancel.Size = New System.Drawing.Size(135, 45)
        Me.btKitCancel.TabIndex = 21
        Me.btKitCancel.Text = "Annuler"
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
        Me.btKitAdd.Location = New System.Drawing.Point(92, 179)
        Me.btKitAdd.Name = "btKitAdd"
        Me.btKitAdd.ShadowDecoration.Parent = Me.btKitAdd
        Me.btKitAdd.Size = New System.Drawing.Size(135, 45)
        Me.btKitAdd.TabIndex = 20
        Me.btKitAdd.Text = "Ajouter"
        '
        'PromptReturnAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(477, 303)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PromptReturnAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromptReturnAmount"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents numValue As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents labMessage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btKitCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btKitAdd As Guna.UI2.WinForms.Guna2Button
End Class
