﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btNewRent = New System.Windows.Forms.Button()
        Me.btModRent = New System.Windows.Forms.Button()
        Me.btDelRent = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btBarCode = New System.Windows.Forms.Button()
        Me.btAddUser = New System.Windows.Forms.Button()
        Me.tbUserSearch = New System.Windows.Forms.TextBox()
        Me.gridUserSearch = New System.Windows.Forms.DataGridView()
        Me.calendarRent = New System.Windows.Forms.MonthCalendar()
        Me.labBeginDate = New System.Windows.Forms.Label()
        Me.tbBeginDate = New System.Windows.Forms.TextBox()
        Me.tbEndDate = New System.Windows.Forms.TextBox()
        Me.labEndDate = New System.Windows.Forms.Label()
        Me.gridItemSeach = New System.Windows.Forms.DataGridView()
        Me.tbItemSearch = New System.Windows.Forms.TextBox()
        Me.tbSuggDeposit = New System.Windows.Forms.TextBox()
        Me.tbRealDeposit = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.labSuggDeposit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSavNewRent = New System.Windows.Forms.Button()
        Me.btCancelRent = New System.Windows.Forms.Button()
        Me.btResetRent = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemSeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btNewRent
        '
        Me.btNewRent.Location = New System.Drawing.Point(3, -1)
        Me.btNewRent.Name = "btNewRent"
        Me.btNewRent.Size = New System.Drawing.Size(147, 54)
        Me.btNewRent.TabIndex = 0
        Me.btNewRent.Text = "Nouveau"
        Me.btNewRent.UseVisualStyleBackColor = True
        '
        'btModRent
        '
        Me.btModRent.Location = New System.Drawing.Point(156, -1)
        Me.btModRent.Name = "btModRent"
        Me.btModRent.Size = New System.Drawing.Size(149, 54)
        Me.btModRent.TabIndex = 1
        Me.btModRent.Text = "Modifier"
        Me.btModRent.UseVisualStyleBackColor = True
        '
        'btDelRent
        '
        Me.btDelRent.Location = New System.Drawing.Point(311, -1)
        Me.btDelRent.Name = "btDelRent"
        Me.btDelRent.Size = New System.Drawing.Size(147, 54)
        Me.btDelRent.TabIndex = 2
        Me.btDelRent.Text = "Supprimer"
        Me.btDelRent.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btNewRent)
        Me.Panel1.Controls.Add(Me.btDelRent)
        Me.Panel1.Controls.Add(Me.btModRent)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 54)
        Me.Panel1.TabIndex = 3
        '
        'btBarCode
        '
        Me.btBarCode.Location = New System.Drawing.Point(4, 60)
        Me.btBarCode.Name = "btBarCode"
        Me.btBarCode.Size = New System.Drawing.Size(120, 23)
        Me.btBarCode.TabIndex = 4
        Me.btBarCode.Text = "Code barre article"
        Me.btBarCode.UseVisualStyleBackColor = True
        '
        'btAddUser
        '
        Me.btAddUser.Location = New System.Drawing.Point(130, 60)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.Size = New System.Drawing.Size(120, 23)
        Me.btAddUser.TabIndex = 5
        Me.btAddUser.Text = "Nouvelle personne"
        Me.btAddUser.UseVisualStyleBackColor = True
        '
        'tbUserSearch
        '
        Me.tbUserSearch.Location = New System.Drawing.Point(4, 92)
        Me.tbUserSearch.Name = "tbUserSearch"
        Me.tbUserSearch.Size = New System.Drawing.Size(246, 20)
        Me.tbUserSearch.TabIndex = 6
        Me.tbUserSearch.Text = "Rechercher un utilisateur"
        '
        'gridUserSearch
        '
        Me.gridUserSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUserSearch.Location = New System.Drawing.Point(4, 118)
        Me.gridUserSearch.Name = "gridUserSearch"
        Me.gridUserSearch.Size = New System.Drawing.Size(455, 231)
        Me.gridUserSearch.TabIndex = 7
        '
        'calendarRent
        '
        Me.calendarRent.Location = New System.Drawing.Point(121, 361)
        Me.calendarRent.Name = "calendarRent"
        Me.calendarRent.TabIndex = 8
        '
        'labBeginDate
        '
        Me.labBeginDate.AutoSize = True
        Me.labBeginDate.Location = New System.Drawing.Point(127, 538)
        Me.labBeginDate.Name = "labBeginDate"
        Me.labBeginDate.Size = New System.Drawing.Size(27, 13)
        Me.labBeginDate.TabIndex = 9
        Me.labBeginDate.Text = "De :"
        '
        'tbBeginDate
        '
        Me.tbBeginDate.Location = New System.Drawing.Point(160, 531)
        Me.tbBeginDate.Name = "tbBeginDate"
        Me.tbBeginDate.ReadOnly = True
        Me.tbBeginDate.Size = New System.Drawing.Size(153, 20)
        Me.tbBeginDate.TabIndex = 10
        '
        'tbEndDate
        '
        Me.tbEndDate.Location = New System.Drawing.Point(160, 569)
        Me.tbEndDate.Name = "tbEndDate"
        Me.tbEndDate.ReadOnly = True
        Me.tbEndDate.Size = New System.Drawing.Size(153, 20)
        Me.tbEndDate.TabIndex = 12
        '
        'labEndDate
        '
        Me.labEndDate.AutoSize = True
        Me.labEndDate.Location = New System.Drawing.Point(127, 576)
        Me.labEndDate.Name = "labEndDate"
        Me.labEndDate.Size = New System.Drawing.Size(20, 13)
        Me.labEndDate.TabIndex = 11
        Me.labEndDate.Text = "À :"
        '
        'gridItemSeach
        '
        Me.gridItemSeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridItemSeach.Location = New System.Drawing.Point(498, 92)
        Me.gridItemSeach.Name = "gridItemSeach"
        Me.gridItemSeach.Size = New System.Drawing.Size(455, 231)
        Me.gridItemSeach.TabIndex = 14
        '
        'tbItemSearch
        '
        Me.tbItemSearch.Location = New System.Drawing.Point(498, 62)
        Me.tbItemSearch.Name = "tbItemSearch"
        Me.tbItemSearch.Size = New System.Drawing.Size(246, 20)
        Me.tbItemSearch.TabIndex = 13
        Me.tbItemSearch.Text = "Rechercher un utilisateur"
        '
        'tbSuggDeposit
        '
        Me.tbSuggDeposit.Location = New System.Drawing.Point(498, 550)
        Me.tbSuggDeposit.Name = "tbSuggDeposit"
        Me.tbSuggDeposit.ReadOnly = True
        Me.tbSuggDeposit.Size = New System.Drawing.Size(171, 20)
        Me.tbSuggDeposit.TabIndex = 15
        '
        'tbRealDeposit
        '
        Me.tbRealDeposit.Location = New System.Drawing.Point(775, 550)
        Me.tbRealDeposit.Name = "tbRealDeposit"
        Me.tbRealDeposit.Size = New System.Drawing.Size(171, 20)
        Me.tbRealDeposit.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(498, 329)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(455, 198)
        Me.DataGridView1.TabIndex = 17
        '
        'labSuggDeposit
        '
        Me.labSuggDeposit.AutoSize = True
        Me.labSuggDeposit.Location = New System.Drawing.Point(495, 534)
        Me.labSuggDeposit.Name = "labSuggDeposit"
        Me.labSuggDeposit.Size = New System.Drawing.Size(83, 13)
        Me.labSuggDeposit.TabIndex = 18
        Me.labSuggDeposit.Text = "Dépôt suggéré :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(772, 534)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Dépôt demandé :"
        '
        'btSavNewRent
        '
        Me.btSavNewRent.Location = New System.Drawing.Point(498, 585)
        Me.btSavNewRent.Name = "btSavNewRent"
        Me.btSavNewRent.Size = New System.Drawing.Size(147, 54)
        Me.btSavNewRent.TabIndex = 3
        Me.btSavNewRent.Text = "Sauvegarder"
        Me.btSavNewRent.UseVisualStyleBackColor = True
        '
        'btCancelRent
        '
        Me.btCancelRent.Location = New System.Drawing.Point(806, 585)
        Me.btCancelRent.Name = "btCancelRent"
        Me.btCancelRent.Size = New System.Drawing.Size(147, 54)
        Me.btCancelRent.TabIndex = 5
        Me.btCancelRent.Text = "Annuler"
        Me.btCancelRent.UseVisualStyleBackColor = True
        '
        'btResetRent
        '
        Me.btResetRent.Location = New System.Drawing.Point(651, 585)
        Me.btResetRent.Name = "btResetRent"
        Me.btResetRent.Size = New System.Drawing.Size(149, 54)
        Me.btResetRent.TabIndex = 4
        Me.btResetRent.Text = "Réinitialiser"
        Me.btResetRent.UseVisualStyleBackColor = True
        '
        'UCRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btSavNewRent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCancelRent)
        Me.Controls.Add(Me.labSuggDeposit)
        Me.Controls.Add(Me.btResetRent)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbRealDeposit)
        Me.Controls.Add(Me.tbSuggDeposit)
        Me.Controls.Add(Me.gridItemSeach)
        Me.Controls.Add(Me.tbItemSearch)
        Me.Controls.Add(Me.tbEndDate)
        Me.Controls.Add(Me.labEndDate)
        Me.Controls.Add(Me.tbBeginDate)
        Me.Controls.Add(Me.labBeginDate)
        Me.Controls.Add(Me.calendarRent)
        Me.Controls.Add(Me.gridUserSearch)
        Me.Controls.Add(Me.tbUserSearch)
        Me.Controls.Add(Me.btAddUser)
        Me.Controls.Add(Me.btBarCode)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCRent"
        Me.Size = New System.Drawing.Size(956, 647)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gridUserSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemSeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btNewRent As Button
    Friend WithEvents btModRent As Button
    Friend WithEvents btDelRent As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btBarCode As Button
    Friend WithEvents btAddUser As Button
    Friend WithEvents tbUserSearch As TextBox
    Friend WithEvents gridUserSearch As DataGridView
    Friend WithEvents calendarRent As MonthCalendar
    Friend WithEvents labBeginDate As Label
    Friend WithEvents tbBeginDate As TextBox
    Friend WithEvents tbEndDate As TextBox
    Friend WithEvents labEndDate As Label
    Friend WithEvents gridItemSeach As DataGridView
    Friend WithEvents tbItemSearch As TextBox
    Friend WithEvents tbSuggDeposit As TextBox
    Friend WithEvents tbRealDeposit As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labSuggDeposit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btSavNewRent As Button
    Friend WithEvents btCancelRent As Button
    Friend WithEvents btResetRent As Button
End Class
