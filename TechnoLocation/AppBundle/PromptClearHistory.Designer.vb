<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromptClearHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromptClearHistory))
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labDeleteAll = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkDeleteAll = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.dateDelete = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.labMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btSubmit = New Guna.UI2.WinForms.Guna2Button()
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
        Me.panelHeaderBar.Controls.Add(Me.btHeaderClose)
        Me.panelHeaderBar.Controls.Add(Me.PictureBox1)
        Me.panelHeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.panelHeaderBar.Name = "panelHeaderBar"
        Me.panelHeaderBar.Size = New System.Drawing.Size(393, 55)
        Me.panelHeaderBar.TabIndex = 23
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(277, 0)
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
        Me.btHeaderClose.Location = New System.Drawing.Point(335, 0)
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
        Me.Guna2Panel1.Controls.Add(Me.labDeleteAll)
        Me.Guna2Panel1.Controls.Add(Me.checkDeleteAll)
        Me.Guna2Panel1.Controls.Add(Me.dateDelete)
        Me.Guna2Panel1.Controls.Add(Me.labMessage)
        Me.Guna2Panel1.Controls.Add(Me.btCancel)
        Me.Guna2Panel1.Controls.Add(Me.btSubmit)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(393, 249)
        Me.Guna2Panel1.TabIndex = 24
        '
        'labDeleteAll
        '
        Me.labDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.labDeleteAll.Location = New System.Drawing.Point(78, 85)
        Me.labDeleteAll.Name = "labDeleteAll"
        Me.labDeleteAll.Size = New System.Drawing.Size(182, 18)
        Me.labDeleteAll.TabIndex = 75
        Me.labDeleteAll.Text = "Afficher les emprunts en retard"
        '
        'checkDeleteAll
        '
        Me.checkDeleteAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkDeleteAll.CheckedState.BorderRadius = 2
        Me.checkDeleteAll.CheckedState.BorderThickness = 2
        Me.checkDeleteAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkDeleteAll.CheckedState.Parent = Me.checkDeleteAll
        Me.checkDeleteAll.Location = New System.Drawing.Point(52, 84)
        Me.checkDeleteAll.Name = "checkDeleteAll"
        Me.checkDeleteAll.ShadowDecoration.Parent = Me.checkDeleteAll
        Me.checkDeleteAll.Size = New System.Drawing.Size(20, 20)
        Me.checkDeleteAll.TabIndex = 74
        Me.checkDeleteAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkDeleteAll.UncheckedState.BorderRadius = 2
        Me.checkDeleteAll.UncheckedState.BorderThickness = 2
        Me.checkDeleteAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkDeleteAll.UncheckedState.Parent = Me.checkDeleteAll
        '
        'dateDelete
        '
        Me.dateDelete.CheckedState.Parent = Me.dateDelete
        Me.dateDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateDelete.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateDelete.HoverState.Parent = Me.dateDelete
        Me.dateDelete.Location = New System.Drawing.Point(50, 115)
        Me.dateDelete.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateDelete.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateDelete.Name = "dateDelete"
        Me.dateDelete.ShadowDecoration.Parent = Me.dateDelete
        Me.dateDelete.Size = New System.Drawing.Size(292, 36)
        Me.dateDelete.TabIndex = 30
        Me.dateDelete.Value = New Date(2020, 12, 14, 17, 38, 54, 230)
        '
        'labMessage
        '
        Me.labMessage.AutoSize = False
        Me.labMessage.BackColor = System.Drawing.Color.Transparent
        Me.labMessage.Location = New System.Drawing.Point(0, 0)
        Me.labMessage.Name = "labMessage"
        Me.labMessage.Size = New System.Drawing.Size(110, 75)
        Me.labMessage.TabIndex = 29
        Me.labMessage.Text = "Guna2HtmlLabel1"
        '
        'btCancel
        '
        Me.btCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btCancel.BorderRadius = 15
        Me.btCancel.BorderThickness = 2
        Me.btCancel.CheckedState.Parent = Me.btCancel
        Me.btCancel.CustomImages.Parent = Me.btCancel
        Me.btCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btCancel.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btCancel.ForeColor = System.Drawing.Color.Black
        Me.btCancel.HoverState.Parent = Me.btCancel
        Me.btCancel.Location = New System.Drawing.Point(207, 189)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.ShadowDecoration.Parent = Me.btCancel
        Me.btCancel.Size = New System.Drawing.Size(135, 45)
        Me.btCancel.TabIndex = 28
        Me.btCancel.Text = "Annuler"
        '
        'btSubmit
        '
        Me.btSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btSubmit.BorderRadius = 15
        Me.btSubmit.BorderThickness = 2
        Me.btSubmit.CheckedState.Parent = Me.btSubmit
        Me.btSubmit.CustomImages.Parent = Me.btSubmit
        Me.btSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btSubmit.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btSubmit.ForeColor = System.Drawing.Color.Black
        Me.btSubmit.HoverState.Parent = Me.btSubmit
        Me.btSubmit.Location = New System.Drawing.Point(50, 189)
        Me.btSubmit.Name = "btSubmit"
        Me.btSubmit.ShadowDecoration.Parent = Me.btSubmit
        Me.btSubmit.Size = New System.Drawing.Size(135, 45)
        Me.btSubmit.TabIndex = 27
        Me.btSubmit.Text = "Ajouter"
        '
        'PromptClearHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 304)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PromptClearHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromptClearHistory"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labMessage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dateDelete As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents labDeleteAll As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkDeleteAll As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
