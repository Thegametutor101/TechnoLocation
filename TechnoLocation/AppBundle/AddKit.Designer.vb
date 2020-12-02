<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddKit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddKit))
        Me.panelHeaderBar = New System.Windows.Forms.Panel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.btHeaderMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btHeaderClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabNameKitAdd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbNameKitAdd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btKitAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btKitCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.panelHeaderBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelHeaderBar.Size = New System.Drawing.Size(357, 55)
        Me.panelHeaderBar.TabIndex = 9
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
        Me.btHeaderMinimize.Location = New System.Drawing.Point(241, 0)
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
        Me.btHeaderClose.Location = New System.Drawing.Point(299, 0)
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
        'LabNameKitAdd
        '
        Me.LabNameKitAdd.BackColor = System.Drawing.Color.Transparent
        Me.LabNameKitAdd.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNameKitAdd.Location = New System.Drawing.Point(20, 85)
        Me.LabNameKitAdd.Name = "LabNameKitAdd"
        Me.LabNameKitAdd.Size = New System.Drawing.Size(93, 27)
        Me.LabNameKitAdd.TabIndex = 10
        Me.LabNameKitAdd.Text = "Nom du kit"
        '
        'tbNameKitAdd
        '
        Me.tbNameKitAdd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNameKitAdd.DefaultText = ""
        Me.tbNameKitAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNameKitAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNameKitAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNameKitAdd.DisabledState.Parent = Me.tbNameKitAdd
        Me.tbNameKitAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNameKitAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNameKitAdd.FocusedState.Parent = Me.tbNameKitAdd
        Me.tbNameKitAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbNameKitAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNameKitAdd.HoverState.Parent = Me.tbNameKitAdd
        Me.tbNameKitAdd.Location = New System.Drawing.Point(135, 81)
        Me.tbNameKitAdd.Name = "tbNameKitAdd"
        Me.tbNameKitAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNameKitAdd.PlaceholderText = ""
        Me.tbNameKitAdd.SelectedText = ""
        Me.tbNameKitAdd.ShadowDecoration.Parent = Me.tbNameKitAdd
        Me.tbNameKitAdd.Size = New System.Drawing.Size(191, 36)
        Me.tbNameKitAdd.TabIndex = 11
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
        Me.btKitAdd.Location = New System.Drawing.Point(26, 143)
        Me.btKitAdd.Name = "btKitAdd"
        Me.btKitAdd.ShadowDecoration.Parent = Me.btKitAdd
        Me.btKitAdd.Size = New System.Drawing.Size(135, 45)
        Me.btKitAdd.TabIndex = 12
        Me.btKitAdd.Text = "Ajouter"
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
        Me.btKitCancel.Location = New System.Drawing.Point(183, 143)
        Me.btKitCancel.Name = "btKitCancel"
        Me.btKitCancel.ShadowDecoration.Parent = Me.btKitCancel
        Me.btKitCancel.Size = New System.Drawing.Size(135, 45)
        Me.btKitCancel.TabIndex = 13
        Me.btKitCancel.Text = "Annuler"
        '
        'AddKit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(357, 217)
        Me.Controls.Add(Me.btKitCancel)
        Me.Controls.Add(Me.btKitAdd)
        Me.Controls.Add(Me.tbNameKitAdd)
        Me.Controls.Add(Me.LabNameKitAdd)
        Me.Controls.Add(Me.panelHeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddKit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddKit"
        Me.panelHeaderBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelHeaderBar As Panel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents btHeaderMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btHeaderClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabNameKitAdd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbNameKitAdd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btKitAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btKitCancel As Guna.UI2.WinForms.Guna2Button
End Class
