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
        Me.btAddUser = New System.Windows.Forms.Button()
        Me.checkUser = New System.Windows.Forms.CheckBox()
        Me.gridUser = New System.Windows.Forms.DataGridView()
        Me.dropUserSearch = New System.Windows.Forms.ComboBox()
        Me.tbUserSearch = New System.Windows.Forms.TextBox()
        Me.btDeleteUser = New System.Windows.Forms.Button()
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAddUser
        '
        Me.btAddUser.Location = New System.Drawing.Point(90, 51)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.Size = New System.Drawing.Size(142, 23)
        Me.btAddUser.TabIndex = 9
        Me.btAddUser.Text = "Ajouter nouvel utilisateur"
        Me.btAddUser.UseVisualStyleBackColor = True
        '
        'checkUser
        '
        Me.checkUser.AutoSize = True
        Me.checkUser.Location = New System.Drawing.Point(3, 55)
        Me.checkUser.Name = "checkUser"
        Me.checkUser.Size = New System.Drawing.Size(81, 17)
        Me.checkUser.TabIndex = 8
        Me.checkUser.Text = "Cocher tout"
        Me.checkUser.UseVisualStyleBackColor = True
        '
        'gridUser
        '
        Me.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUser.Location = New System.Drawing.Point(3, 78)
        Me.gridUser.Name = "gridUser"
        Me.gridUser.Size = New System.Drawing.Size(953, 569)
        Me.gridUser.TabIndex = 7
        '
        'dropUserSearch
        '
        Me.dropUserSearch.FormattingEnabled = True
        Me.dropUserSearch.Location = New System.Drawing.Point(336, 18)
        Me.dropUserSearch.Name = "dropUserSearch"
        Me.dropUserSearch.Size = New System.Drawing.Size(135, 21)
        Me.dropUserSearch.TabIndex = 6
        '
        'tbUserSearch
        '
        Me.tbUserSearch.Location = New System.Drawing.Point(3, 18)
        Me.tbUserSearch.Name = "tbUserSearch"
        Me.tbUserSearch.Size = New System.Drawing.Size(281, 20)
        Me.tbUserSearch.TabIndex = 5
        Me.tbUserSearch.Text = "Recherche"
        '
        'btDeleteUser
        '
        Me.btDeleteUser.Location = New System.Drawing.Point(238, 51)
        Me.btDeleteUser.Name = "btDeleteUser"
        Me.btDeleteUser.Size = New System.Drawing.Size(142, 23)
        Me.btDeleteUser.TabIndex = 10
        Me.btDeleteUser.Text = "Supprimer les utilisateurs"
        Me.btDeleteUser.UseVisualStyleBackColor = True
        '
        'UCUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btDeleteUser)
        Me.Controls.Add(Me.btAddUser)
        Me.Controls.Add(Me.checkUser)
        Me.Controls.Add(Me.gridUser)
        Me.Controls.Add(Me.dropUserSearch)
        Me.Controls.Add(Me.tbUserSearch)
        Me.Name = "UCUser"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.gridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAddUser As Button
    Friend WithEvents checkUser As CheckBox
    Friend WithEvents gridUser As DataGridView
    Friend WithEvents dropUserSearch As ComboBox
    Friend WithEvents tbUserSearch As TextBox
    Friend WithEvents btDeleteUser As Button
End Class
