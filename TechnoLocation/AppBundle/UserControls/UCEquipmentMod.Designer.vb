<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEquipmentMod
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
        Me.btKitNullMod = New System.Windows.Forms.Button()
        Me.btKitMod = New System.Windows.Forms.Button()
        Me.labEquipmentModKit = New System.Windows.Forms.Label()
        Me.gridEquipmentMod = New System.Windows.Forms.DataGridView()
        Me.btCancelModEquip = New System.Windows.Forms.Button()
        Me.btModEquip = New System.Windows.Forms.Button()
        Me.labStateEquipMod = New System.Windows.Forms.Label()
        Me.tbStateEquipMod = New System.Windows.Forms.TextBox()
        Me.checkAvailableEquipMod = New System.Windows.Forms.CheckBox()
        Me.labCommentMod = New System.Windows.Forms.Label()
        Me.tbCommentMod = New System.Windows.Forms.RichTextBox()
        Me.tbNameEquipmentMod = New System.Windows.Forms.TextBox()
        Me.labNameEquipmentMod = New System.Windows.Forms.Label()
        CType(Me.gridEquipmentMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btKitNullMod
        '
        Me.btKitNullMod.Location = New System.Drawing.Point(744, 373)
        Me.btKitNullMod.Name = "btKitNullMod"
        Me.btKitNullMod.Size = New System.Drawing.Size(209, 23)
        Me.btKitNullMod.TabIndex = 31
        Me.btKitNullMod.Text = "Désélectionner kit"
        Me.btKitNullMod.UseVisualStyleBackColor = True
        '
        'btKitMod
        '
        Me.btKitMod.Location = New System.Drawing.Point(536, 373)
        Me.btKitMod.Name = "btKitMod"
        Me.btKitMod.Size = New System.Drawing.Size(209, 23)
        Me.btKitMod.TabIndex = 30
        Me.btKitMod.Text = "Nouveau kit"
        Me.btKitMod.UseVisualStyleBackColor = True
        '
        'labEquipmentModKit
        '
        Me.labEquipmentModKit.AutoSize = True
        Me.labEquipmentModKit.Location = New System.Drawing.Point(533, 93)
        Me.labEquipmentModKit.Name = "labEquipmentModKit"
        Me.labEquipmentModKit.Size = New System.Drawing.Size(148, 13)
        Me.labEquipmentModKit.TabIndex = 29
        Me.labEquipmentModKit.Text = "Choix de kit pour l'équipement"
        '
        'gridEquipmentMod
        '
        Me.gridEquipmentMod.AllowUserToAddRows = False
        Me.gridEquipmentMod.AllowUserToDeleteRows = False
        Me.gridEquipmentMod.AllowUserToResizeRows = False
        Me.gridEquipmentMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEquipmentMod.Location = New System.Drawing.Point(536, 116)
        Me.gridEquipmentMod.MultiSelect = False
        Me.gridEquipmentMod.Name = "gridEquipmentMod"
        Me.gridEquipmentMod.ReadOnly = True
        Me.gridEquipmentMod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEquipmentMod.Size = New System.Drawing.Size(417, 251)
        Me.gridEquipmentMod.TabIndex = 28
        '
        'btCancelModEquip
        '
        Me.btCancelModEquip.Location = New System.Drawing.Point(256, 373)
        Me.btCancelModEquip.Name = "btCancelModEquip"
        Me.btCancelModEquip.Size = New System.Drawing.Size(209, 23)
        Me.btCancelModEquip.TabIndex = 25
        Me.btCancelModEquip.Text = "Annuler"
        Me.btCancelModEquip.UseVisualStyleBackColor = True
        '
        'btModEquip
        '
        Me.btModEquip.Location = New System.Drawing.Point(48, 373)
        Me.btModEquip.Name = "btModEquip"
        Me.btModEquip.Size = New System.Drawing.Size(209, 23)
        Me.btModEquip.TabIndex = 24
        Me.btModEquip.Text = "Sauvegarder modification"
        Me.btModEquip.UseVisualStyleBackColor = True
        '
        'labStateEquipMod
        '
        Me.labStateEquipMod.AutoSize = True
        Me.labStateEquipMod.Location = New System.Drawing.Point(45, 301)
        Me.labStateEquipMod.Name = "labStateEquipMod"
        Me.labStateEquipMod.Size = New System.Drawing.Size(103, 13)
        Me.labStateEquipMod.TabIndex = 23
        Me.labStateEquipMod.Text = "État de l'équipement"
        '
        'tbStateEquipMod
        '
        Me.tbStateEquipMod.Location = New System.Drawing.Point(192, 298)
        Me.tbStateEquipMod.Name = "tbStateEquipMod"
        Me.tbStateEquipMod.Size = New System.Drawing.Size(273, 20)
        Me.tbStateEquipMod.TabIndex = 22
        '
        'checkAvailableEquipMod
        '
        Me.checkAvailableEquipMod.AutoSize = True
        Me.checkAvailableEquipMod.Location = New System.Drawing.Point(192, 324)
        Me.checkAvailableEquipMod.Name = "checkAvailableEquipMod"
        Me.checkAvailableEquipMod.Size = New System.Drawing.Size(106, 17)
        Me.checkAvailableEquipMod.TabIndex = 21
        Me.checkAvailableEquipMod.Text = "Mettre disponible"
        Me.checkAvailableEquipMod.UseVisualStyleBackColor = True
        '
        'labCommentMod
        '
        Me.labCommentMod.AutoSize = True
        Me.labCommentMod.Location = New System.Drawing.Point(45, 119)
        Me.labCommentMod.Name = "labCommentMod"
        Me.labCommentMod.Size = New System.Drawing.Size(68, 13)
        Me.labCommentMod.TabIndex = 20
        Me.labCommentMod.Text = "Commentaire"
        '
        'tbCommentMod
        '
        Me.tbCommentMod.Location = New System.Drawing.Point(192, 116)
        Me.tbCommentMod.Name = "tbCommentMod"
        Me.tbCommentMod.Size = New System.Drawing.Size(273, 176)
        Me.tbCommentMod.TabIndex = 19
        Me.tbCommentMod.Text = ""
        '
        'tbNameEquipmentMod
        '
        Me.tbNameEquipmentMod.Location = New System.Drawing.Point(192, 90)
        Me.tbNameEquipmentMod.Name = "tbNameEquipmentMod"
        Me.tbNameEquipmentMod.Size = New System.Drawing.Size(273, 20)
        Me.tbNameEquipmentMod.TabIndex = 18
        '
        'labNameEquipmentMod
        '
        Me.labNameEquipmentMod.AutoSize = True
        Me.labNameEquipmentMod.Location = New System.Drawing.Point(45, 93)
        Me.labNameEquipmentMod.Name = "labNameEquipmentMod"
        Me.labNameEquipmentMod.Size = New System.Drawing.Size(95, 13)
        Me.labNameEquipmentMod.TabIndex = 17
        Me.labNameEquipmentMod.Text = "Nom d'équipement"
        '
        'UCEquipmentMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btKitNullMod)
        Me.Controls.Add(Me.btKitMod)
        Me.Controls.Add(Me.labEquipmentModKit)
        Me.Controls.Add(Me.gridEquipmentMod)
        Me.Controls.Add(Me.btCancelModEquip)
        Me.Controls.Add(Me.btModEquip)
        Me.Controls.Add(Me.labStateEquipMod)
        Me.Controls.Add(Me.tbStateEquipMod)
        Me.Controls.Add(Me.checkAvailableEquipMod)
        Me.Controls.Add(Me.labCommentMod)
        Me.Controls.Add(Me.tbCommentMod)
        Me.Controls.Add(Me.tbNameEquipmentMod)
        Me.Controls.Add(Me.labNameEquipmentMod)
        Me.Name = "UCEquipmentMod"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.gridEquipmentMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btKitNullMod As Button
    Friend WithEvents btKitMod As Button
    Friend WithEvents labEquipmentModKit As Label
    Friend WithEvents gridEquipmentMod As DataGridView
    Friend WithEvents btCancelModEquip As Button
    Friend WithEvents btModEquip As Button
    Friend WithEvents labStateEquipMod As Label
    Friend WithEvents tbStateEquipMod As TextBox
    Friend WithEvents checkAvailableEquipMod As CheckBox
    Friend WithEvents labCommentMod As Label
    Friend WithEvents tbCommentMod As RichTextBox
    Friend WithEvents tbNameEquipmentMod As TextBox
    Friend WithEvents labNameEquipmentMod As Label
End Class
