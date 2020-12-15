<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromptClearHistoryOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromptClearHistoryOptions))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btMore = New Guna.UI2.WinForms.Guna2Button()
        Me.labMessage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btSelected = New Guna.UI2.WinForms.Guna2Button()
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btMore)
        Me.Guna2Panel1.Controls.Add(Me.labMessage)
        Me.Guna2Panel1.Controls.Add(Me.btCancel)
        Me.Guna2Panel1.Controls.Add(Me.btSelected)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(359, 302)
        Me.Guna2Panel1.TabIndex = 26
        '
        'btMore
        '
        Me.btMore.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btMore.BorderRadius = 15
        Me.btMore.BorderThickness = 2
        Me.btMore.CheckedState.Parent = Me.btMore
        Me.btMore.CustomImages.Parent = Me.btMore
        Me.btMore.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btMore.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btMore.ForeColor = System.Drawing.Color.Black
        Me.btMore.HoverState.Parent = Me.btMore
        Me.btMore.Location = New System.Drawing.Point(65, 157)
        Me.btMore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btMore.Name = "btMore"
        Me.btMore.ShadowDecoration.Parent = Me.btMore
        Me.btMore.Size = New System.Drawing.Size(227, 45)
        Me.btMore.TabIndex = 30
        Me.btMore.Text = "Nouveau"
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
        Me.btCancel.Location = New System.Drawing.Point(65, 218)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.ShadowDecoration.Parent = Me.btCancel
        Me.btCancel.Size = New System.Drawing.Size(227, 45)
        Me.btCancel.TabIndex = 28
        Me.btCancel.Text = "Annuler"
        '
        'btSelected
        '
        Me.btSelected.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btSelected.BorderRadius = 15
        Me.btSelected.BorderThickness = 2
        Me.btSelected.CheckedState.Parent = Me.btSelected
        Me.btSelected.CustomImages.Parent = Me.btSelected
        Me.btSelected.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btSelected.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!)
        Me.btSelected.ForeColor = System.Drawing.Color.Black
        Me.btSelected.HoverState.Parent = Me.btSelected
        Me.btSelected.Location = New System.Drawing.Point(65, 94)
        Me.btSelected.Name = "btSelected"
        Me.btSelected.ShadowDecoration.Parent = Me.btSelected
        Me.btSelected.Size = New System.Drawing.Size(227, 45)
        Me.btSelected.TabIndex = 27
        Me.btSelected.Text = "Ajouter"
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
        Me.panelHeaderBar.Size = New System.Drawing.Size(359, 55)
        Me.panelHeaderBar.TabIndex = 25
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(243, 0)
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
        Me.btHeaderClose.Location = New System.Drawing.Point(301, 0)
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
        'PromptClearHistoryOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 357)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PromptClearHistoryOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromptClearHistoryOptions"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labMessage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btSelected As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btMore As Guna.UI2.WinForms.Guna2Button
End Class
