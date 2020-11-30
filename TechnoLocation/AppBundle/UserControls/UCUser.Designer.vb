<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCUser))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btDeleteUser = New System.Windows.Forms.Button()
        Me.btAddUser = New System.Windows.Forms.Button()
        Me.gridUser = New System.Windows.Forms.DataGridView()
        Me.dropUserSearch = New System.Windows.Forms.ComboBox()
        Me.tbUserSearch = New System.Windows.Forms.TextBox()
        Me.checkUser = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btDeleteUser)
        Me.Guna2Panel1.Controls.Add(Me.btAddUser)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1263, 83)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.checkUser)
        Me.Guna2Panel2.Controls.Add(Me.tbUserSearch)
        Me.Guna2Panel2.Controls.Add(Me.dropUserSearch)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 83)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1263, 90)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 173)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(60, 570)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel4.Location = New System.Drawing.Point(1203, 173)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(60, 570)
        Me.Guna2Panel4.TabIndex = 3
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(60, 683)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(1143, 60)
        Me.Guna2Panel5.TabIndex = 4
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.gridUser)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(60, 173)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(1143, 510)
        Me.Guna2Panel6.TabIndex = 5
        '
        'btDeleteUser
        '
        Me.btDeleteUser.Location = New System.Drawing.Point(308, 28)
        Me.btDeleteUser.Margin = New System.Windows.Forms.Padding(5)
        Me.btDeleteUser.Name = "btDeleteUser"
        Me.btDeleteUser.Size = New System.Drawing.Size(189, 28)
        Me.btDeleteUser.TabIndex = 16
        Me.btDeleteUser.Text = "Supprimer les utilisateurs"
        Me.btDeleteUser.UseVisualStyleBackColor = True
        '
        'btAddUser
        '
        Me.btAddUser.Location = New System.Drawing.Point(45, 28)
        Me.btAddUser.Margin = New System.Windows.Forms.Padding(5)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.Size = New System.Drawing.Size(189, 28)
        Me.btAddUser.TabIndex = 15
        Me.btAddUser.Text = "Ajouter nouvel utilisateur"
        Me.btAddUser.UseVisualStyleBackColor = True
        '
        'gridUser
        '
        Me.gridUser.AllowUserToAddRows = False
        Me.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUser.Location = New System.Drawing.Point(165, 163)
        Me.gridUser.Margin = New System.Windows.Forms.Padding(5)
        Me.gridUser.Name = "gridUser"
        Me.gridUser.ReadOnly = True
        Me.gridUser.RowHeadersWidth = 51
        Me.gridUser.Size = New System.Drawing.Size(788, 312)
        Me.gridUser.TabIndex = 13
        '
        'dropUserSearch
        '
        Me.dropUserSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropUserSearch.FormattingEnabled = True
        Me.dropUserSearch.Items.AddRange(New Object() {"Code", "Prénom", "Nom de famille", "Email", "Téléphone", "Job"})
        Me.dropUserSearch.Location = New System.Drawing.Point(454, 19)
        Me.dropUserSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.dropUserSearch.Name = "dropUserSearch"
        Me.dropUserSearch.Size = New System.Drawing.Size(179, 24)
        Me.dropUserSearch.TabIndex = 12
        '
        'tbUserSearch
        '
        Me.tbUserSearch.Location = New System.Drawing.Point(45, 19)
        Me.tbUserSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.tbUserSearch.Name = "tbUserSearch"
        Me.tbUserSearch.Size = New System.Drawing.Size(373, 22)
        Me.tbUserSearch.TabIndex = 11
        Me.tbUserSearch.Text = "Recherche"
        '
        'checkUser
        '
        Me.checkUser.CheckedState.Image = CType(resources.GetObject("checkSelectAllEquipment.CheckedState.Image"), System.Drawing.Image)
        Me.checkUser.CheckedState.Parent = Me.checkUser
        Me.checkUser.HoverState.Parent = Me.checkUser
        Me.checkUser.Image = CType(resources.GetObject("checkUser.Image"), System.Drawing.Image)
        Me.checkUser.IndicateFocus = False
        Me.checkUser.Location = New System.Drawing.Point(60, 64)
        Me.checkUser.Name = "checkUser"
        Me.checkUser.PressedState.Parent = Me.checkUser
        Me.checkUser.Size = New System.Drawing.Size(29, 24)
        Me.checkUser.TabIndex = 23
        '
        'UCUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "UCUser"
        Me.Size = New System.Drawing.Size(1263, 743)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btDeleteUser As Button
    Friend WithEvents btAddUser As Button
    Friend WithEvents gridUser As DataGridView
    Friend WithEvents dropUserSearch As ComboBox
    Friend WithEvents tbUserSearch As TextBox
    Friend WithEvents checkUser As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
