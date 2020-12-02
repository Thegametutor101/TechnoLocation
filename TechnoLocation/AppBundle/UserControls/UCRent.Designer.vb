<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRent
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
        Me.btModRent = New System.Windows.Forms.Button()
        Me.btDelRent = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btBarCodeUser = New System.Windows.Forms.Button()
        Me.btAddUser = New System.Windows.Forms.Button()
        Me.tbUserSearch = New System.Windows.Forms.TextBox()
        Me.gridUserSearch = New System.Windows.Forms.DataGridView()
        Me.calendarRent = New System.Windows.Forms.MonthCalendar()
        Me.labBeginDate = New System.Windows.Forms.Label()
        Me.tbBeginDate = New System.Windows.Forms.TextBox()
        Me.tbEndDate = New System.Windows.Forms.TextBox()
        Me.labEndDate = New System.Windows.Forms.Label()
        Me.gridItemSearch = New System.Windows.Forms.DataGridView()
        Me.tbItemSearch = New System.Windows.Forms.TextBox()
        Me.tbSuggDeposit = New System.Windows.Forms.TextBox()
        Me.tbRealDeposit = New System.Windows.Forms.TextBox()
        Me.gridItemAdd = New System.Windows.Forms.DataGridView()
        Me.labSuggDeposit = New System.Windows.Forms.Label()
        Me.labReelDeposit = New System.Windows.Forms.Label()
        Me.btSavNewRent = New System.Windows.Forms.Button()
        Me.btCancelRent = New System.Windows.Forms.Button()
        Me.btResetRent = New System.Windows.Forms.Button()
        Me.dropSearchEquip = New System.Windows.Forms.ComboBox()
        Me.dropSearchUser = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btModRent
        '
        Me.btModRent.Location = New System.Drawing.Point(208, -1)
        Me.btModRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btModRent.Name = "btModRent"
        Me.btModRent.Size = New System.Drawing.Size(149, 54)
        Me.btModRent.TabIndex = 1
        Me.btModRent.Text = "Modifier"
        Me.btModRent.UseVisualStyleBackColor = True
        '
        'btDelRent
        '
        Me.btDelRent.Location = New System.Drawing.Point(415, -1)
        Me.btDelRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btDelRent.Name = "btDelRent"
        Me.btDelRent.Size = New System.Drawing.Size(147, 54)
        Me.btDelRent.TabIndex = 2
        Me.btDelRent.Text = "Supprimer"
        Me.btDelRent.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btDelRent)
        Me.Panel1.Controls.Add(Me.btModRent)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 54)
        Me.Panel1.TabIndex = 3
        '
        'btBarCodeUser
        '
        Me.btBarCodeUser.Location = New System.Drawing.Point(0, 0)
        Me.btBarCodeUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBarCodeUser.Name = "btBarCodeUser"
        Me.btBarCodeUser.Size = New System.Drawing.Size(100, 28)
        Me.btBarCodeUser.TabIndex = 24
        '
        'btAddUser
        '
        Me.btAddUser.Location = New System.Drawing.Point(173, 74)
        Me.btAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.Size = New System.Drawing.Size(120, 23)
        Me.btAddUser.TabIndex = 5
        Me.btAddUser.Text = "Nouvelle personne"
        Me.btAddUser.UseVisualStyleBackColor = True
        '
        'tbUserSearch
        '
        Me.tbUserSearch.Location = New System.Drawing.Point(5, 113)
        Me.tbUserSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUserSearch.Name = "tbUserSearch"
        Me.tbUserSearch.Size = New System.Drawing.Size(246, 20)
        Me.tbUserSearch.TabIndex = 6
        Me.tbUserSearch.Text = "Rechercher un utilisateur"
        '
        'gridUserSearch
        '
        Me.gridUserSearch.AllowUserToAddRows = False
        Me.gridUserSearch.AllowUserToDeleteRows = False
        Me.gridUserSearch.AllowUserToResizeColumns = False
        Me.gridUserSearch.AllowUserToResizeRows = False
        Me.gridUserSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUserSearch.Location = New System.Drawing.Point(5, 145)
        Me.gridUserSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridUserSearch.Name = "gridUserSearch"
        Me.gridUserSearch.RowHeadersWidth = 51
        Me.gridUserSearch.Size = New System.Drawing.Size(455, 231)
        Me.gridUserSearch.TabIndex = 7
        '
        'calendarRent
        '
        Me.calendarRent.Location = New System.Drawing.Point(299, 447)
        Me.calendarRent.Margin = New System.Windows.Forms.Padding(16, 14, 16, 14)
        Me.calendarRent.MaxSelectionCount = 1
        Me.calendarRent.Name = "calendarRent"
        Me.calendarRent.TabIndex = 8
        '
        'labBeginDate
        '
        Me.labBeginDate.AutoSize = True
        Me.labBeginDate.Location = New System.Drawing.Point(22, 471)
        Me.labBeginDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labBeginDate.Name = "labBeginDate"
        Me.labBeginDate.Size = New System.Drawing.Size(27, 13)
        Me.labBeginDate.TabIndex = 9
        Me.labBeginDate.Text = "De :"
        '
        'tbBeginDate
        '
        Me.tbBeginDate.Location = New System.Drawing.Point(66, 463)
        Me.tbBeginDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbBeginDate.Name = "tbBeginDate"
        Me.tbBeginDate.ReadOnly = True
        Me.tbBeginDate.Size = New System.Drawing.Size(153, 20)
        Me.tbBeginDate.TabIndex = 10
        '
        'tbEndDate
        '
        Me.tbEndDate.Location = New System.Drawing.Point(66, 509)
        Me.tbEndDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEndDate.Name = "tbEndDate"
        Me.tbEndDate.ReadOnly = True
        Me.tbEndDate.Size = New System.Drawing.Size(153, 20)
        Me.tbEndDate.TabIndex = 12
        '
        'labEndDate
        '
        Me.labEndDate.AutoSize = True
        Me.labEndDate.Location = New System.Drawing.Point(22, 518)
        Me.labEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEndDate.Name = "labEndDate"
        Me.labEndDate.Size = New System.Drawing.Size(20, 13)
        Me.labEndDate.TabIndex = 11
        Me.labEndDate.Text = "À :"
        '
        'gridItemSearch
        '
        Me.gridItemSearch.AllowUserToAddRows = False
        Me.gridItemSearch.AllowUserToDeleteRows = False
        Me.gridItemSearch.AllowUserToResizeColumns = False
        Me.gridItemSearch.AllowUserToResizeRows = False
        Me.gridItemSearch.ColumnHeadersHeight = 29
        Me.gridItemSearch.Location = New System.Drawing.Point(610, 113)
        Me.gridItemSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridItemSearch.Name = "gridItemSearch"
        Me.gridItemSearch.ReadOnly = True
        Me.gridItemSearch.RowHeadersWidth = 51
        Me.gridItemSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridItemSearch.Size = New System.Drawing.Size(320, 185)
        Me.gridItemSearch.TabIndex = 23
        '
        'tbItemSearch
        '
        Me.tbItemSearch.Location = New System.Drawing.Point(664, 76)
        Me.tbItemSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbItemSearch.Name = "tbItemSearch"
        Me.tbItemSearch.Size = New System.Drawing.Size(246, 20)
        Me.tbItemSearch.TabIndex = 13
        Me.tbItemSearch.Text = "Rechercher un Objet"
        '
        'tbSuggDeposit
        '
        Me.tbSuggDeposit.Location = New System.Drawing.Point(628, 565)
        Me.tbSuggDeposit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSuggDeposit.Name = "tbSuggDeposit"
        Me.tbSuggDeposit.ReadOnly = True
        Me.tbSuggDeposit.Size = New System.Drawing.Size(171, 20)
        Me.tbSuggDeposit.TabIndex = 15
        '
        'tbRealDeposit
        '
        Me.tbRealDeposit.Location = New System.Drawing.Point(978, 565)
        Me.tbRealDeposit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbRealDeposit.Name = "tbRealDeposit"
        Me.tbRealDeposit.Size = New System.Drawing.Size(171, 20)
        Me.tbRealDeposit.TabIndex = 16
        '
        'gridItemAdd
        '
        Me.gridItemAdd.AllowUserToAddRows = False
        Me.gridItemAdd.AllowUserToDeleteRows = False
        Me.gridItemAdd.AllowUserToResizeColumns = False
        Me.gridItemAdd.AllowUserToResizeRows = False
        Me.gridItemAdd.ColumnHeadersHeight = 29
        Me.gridItemAdd.Location = New System.Drawing.Point(887, 264)
        Me.gridItemAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridItemAdd.Name = "gridItemAdd"
        Me.gridItemAdd.ReadOnly = True
        Me.gridItemAdd.RowHeadersWidth = 51
        Me.gridItemAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridItemAdd.Size = New System.Drawing.Size(320, 185)
        Me.gridItemAdd.TabIndex = 22
        '
        'labSuggDeposit
        '
        Me.labSuggDeposit.AutoSize = True
        Me.labSuggDeposit.Location = New System.Drawing.Point(624, 545)
        Me.labSuggDeposit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labSuggDeposit.Name = "labSuggDeposit"
        Me.labSuggDeposit.Size = New System.Drawing.Size(83, 13)
        Me.labSuggDeposit.TabIndex = 18
        Me.labSuggDeposit.Text = "Dépôt suggéré :"
        '
        'labReelDeposit
        '
        Me.labReelDeposit.AutoSize = True
        Me.labReelDeposit.Location = New System.Drawing.Point(976, 545)
        Me.labReelDeposit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labReelDeposit.Name = "labReelDeposit"
        Me.labReelDeposit.Size = New System.Drawing.Size(89, 13)
        Me.labReelDeposit.TabIndex = 19
        Me.labReelDeposit.Text = "Dépôt demandé :"
        '
        'btSavNewRent
        '
        Me.btSavNewRent.Location = New System.Drawing.Point(628, 608)
        Me.btSavNewRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btSavNewRent.Name = "btSavNewRent"
        Me.btSavNewRent.Size = New System.Drawing.Size(112, 54)
        Me.btSavNewRent.TabIndex = 3
        Me.btSavNewRent.Text = "Sauvegarder"
        Me.btSavNewRent.UseVisualStyleBackColor = True
        '
        'btCancelRent
        '
        Me.btCancelRent.Location = New System.Drawing.Point(997, 607)
        Me.btCancelRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btCancelRent.Name = "btCancelRent"
        Me.btCancelRent.Size = New System.Drawing.Size(112, 54)
        Me.btCancelRent.TabIndex = 5
        Me.btCancelRent.Text = "Annuler"
        Me.btCancelRent.UseVisualStyleBackColor = True
        '
        'btResetRent
        '
        Me.btResetRent.Location = New System.Drawing.Point(804, 607)
        Me.btResetRent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btResetRent.Name = "btResetRent"
        Me.btResetRent.Size = New System.Drawing.Size(114, 54)
        Me.btResetRent.TabIndex = 4
        Me.btResetRent.Text = "Réinitialiser"
        Me.btResetRent.UseVisualStyleBackColor = True
        '
        'dropSearchEquip
        '
        Me.dropSearchEquip.FormattingEnabled = True
        Me.dropSearchEquip.Items.AddRange(New Object() {"Code", "Nom", "Kit", "État", "Commentaire"})
        Me.dropSearchEquip.Location = New System.Drawing.Point(1022, 76)
        Me.dropSearchEquip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dropSearchEquip.Name = "dropSearchEquip"
        Me.dropSearchEquip.Size = New System.Drawing.Size(195, 24)
        Me.dropSearchEquip.TabIndex = 20
        '
        'dropSearchUser
        '
        Me.dropSearchUser.FormattingEnabled = True
        Me.dropSearchUser.Location = New System.Drawing.Point(368, 113)
        Me.dropSearchUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dropSearchUser.Name = "dropSearchUser"
        Me.dropSearchUser.Size = New System.Drawing.Size(193, 24)
        Me.dropSearchUser.TabIndex = 21
        '
        'UCRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dropSearchUser)
        Me.Controls.Add(Me.dropSearchEquip)
        Me.Controls.Add(Me.btSavNewRent)
        Me.Controls.Add(Me.labReelDeposit)
        Me.Controls.Add(Me.btCancelRent)
        Me.Controls.Add(Me.labSuggDeposit)
        Me.Controls.Add(Me.btResetRent)
        Me.Controls.Add(Me.gridItemAdd)
        Me.Controls.Add(Me.tbRealDeposit)
        Me.Controls.Add(Me.tbSuggDeposit)
        Me.Controls.Add(Me.gridItemSearch)
        Me.Controls.Add(Me.tbItemSearch)
        Me.Controls.Add(Me.tbEndDate)
        Me.Controls.Add(Me.labEndDate)
        Me.Controls.Add(Me.tbBeginDate)
        Me.Controls.Add(Me.labBeginDate)
        Me.Controls.Add(Me.calendarRent)
        Me.Controls.Add(Me.gridUserSearch)
        Me.Controls.Add(Me.tbUserSearch)
        Me.Controls.Add(Me.btAddUser)
        Me.Controls.Add(Me.btBarCodeUser)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCRent"
        Me.Size = New System.Drawing.Size(1263, 743)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btModRent As Button
    Friend WithEvents btDelRent As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btBarCodeUser As Button
    Friend WithEvents btAddUser As Button
    Friend WithEvents tbUserSearch As TextBox
    Friend WithEvents gridUserSearch As DataGridView
    Friend WithEvents calendarRent As MonthCalendar
    Friend WithEvents labBeginDate As Label
    Friend WithEvents tbBeginDate As TextBox
    Friend WithEvents tbEndDate As TextBox
    Friend WithEvents labEndDate As Label
    Friend WithEvents gridItemSearch As DataGridView
    Friend WithEvents tbItemSearch As TextBox
    Friend WithEvents tbSuggDeposit As TextBox
    Friend WithEvents tbRealDeposit As TextBox
    Friend WithEvents gridItemAdd As DataGridView
    Friend WithEvents labSuggDeposit As Label
    Friend WithEvents labReelDeposit As Label
    Friend WithEvents btSavNewRent As Button
    Friend WithEvents btCancelRent As Button
    Friend WithEvents btResetRent As Button
    Friend WithEvents dropSearchEquip As ComboBox
    Friend WithEvents dropSearchUser As ComboBox
    Friend WithEvents Button1 As Button
End Class
