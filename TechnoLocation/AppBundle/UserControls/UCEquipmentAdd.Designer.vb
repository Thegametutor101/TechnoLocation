<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCEquipmentAdd
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labNameEquipmentAdd = New System.Windows.Forms.Label()
        Me.tbNameEquipmentAdd = New System.Windows.Forms.TextBox()
        Me.tbComment = New System.Windows.Forms.RichTextBox()
        Me.labComment = New System.Windows.Forms.Label()
        Me.checkAvailableEquipAdd = New System.Windows.Forms.CheckBox()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.labStateEquipAdd = New System.Windows.Forms.Label()
        Me.btAddNewEquip = New System.Windows.Forms.Button()
        Me.btCancelNewEquip = New System.Windows.Forms.Button()
        Me.labNumberEquipAdd = New System.Windows.Forms.Label()
        Me.numEquipAdd = New System.Windows.Forms.NumericUpDown()
        Me.gridEquipmentAdd = New System.Windows.Forms.DataGridView()
        Me.labEquipmentAddKit = New System.Windows.Forms.Label()
        Me.btKitAdd = New System.Windows.Forms.Button()
        Me.btKitNull = New System.Windows.Forms.Button()
        CType(Me.numEquipAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEquipmentAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labNameEquipmentAdd
        '
        Me.labNameEquipmentAdd.AutoSize = True
        Me.labNameEquipmentAdd.Location = New System.Drawing.Point(60, 117)
        Me.labNameEquipmentAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNameEquipmentAdd.Name = "labNameEquipmentAdd"
        Me.labNameEquipmentAdd.Size = New System.Drawing.Size(126, 17)
        Me.labNameEquipmentAdd.TabIndex = 0
        Me.labNameEquipmentAdd.Text = "Nom d'équipement"
        '
        'tbNameEquipmentAdd
        '
        Me.tbNameEquipmentAdd.Location = New System.Drawing.Point(256, 113)
        Me.tbNameEquipmentAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNameEquipmentAdd.Name = "tbNameEquipmentAdd"
        Me.tbNameEquipmentAdd.Size = New System.Drawing.Size(363, 22)
        Me.tbNameEquipmentAdd.TabIndex = 1
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(256, 145)
        Me.tbComment.Margin = New System.Windows.Forms.Padding(4)
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(363, 216)
        Me.tbComment.TabIndex = 3
        Me.tbComment.Text = ""
        '
        'labComment
        '
        Me.labComment.AutoSize = True
        Me.labComment.Location = New System.Drawing.Point(60, 149)
        Me.labComment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labComment.Name = "labComment"
        Me.labComment.Size = New System.Drawing.Size(91, 17)
        Me.labComment.TabIndex = 4
        Me.labComment.Text = "Commentaire"
        '
        'checkAvailableEquipAdd
        '
        Me.checkAvailableEquipAdd.AutoSize = True
        Me.checkAvailableEquipAdd.Checked = True
        Me.checkAvailableEquipAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAvailableEquipAdd.Location = New System.Drawing.Point(256, 401)
        Me.checkAvailableEquipAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.checkAvailableEquipAdd.Name = "checkAvailableEquipAdd"
        Me.checkAvailableEquipAdd.Size = New System.Drawing.Size(138, 21)
        Me.checkAvailableEquipAdd.TabIndex = 6
        Me.checkAvailableEquipAdd.Text = "Mettre disponible"
        Me.checkAvailableEquipAdd.UseVisualStyleBackColor = True
        '
        'tbState
        '
        Me.tbState.Location = New System.Drawing.Point(256, 369)
        Me.tbState.Margin = New System.Windows.Forms.Padding(4)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(363, 22)
        Me.tbState.TabIndex = 7
        '
        'labStateEquipAdd
        '
        Me.labStateEquipAdd.AutoSize = True
        Me.labStateEquipAdd.Location = New System.Drawing.Point(60, 373)
        Me.labStateEquipAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labStateEquipAdd.Name = "labStateEquipAdd"
        Me.labStateEquipAdd.Size = New System.Drawing.Size(137, 17)
        Me.labStateEquipAdd.TabIndex = 8
        Me.labStateEquipAdd.Text = "État de l'équipement"
        '
        'btAddNewEquip
        '
        Me.btAddNewEquip.Location = New System.Drawing.Point(78, 462)
        Me.btAddNewEquip.Margin = New System.Windows.Forms.Padding(4)
        Me.btAddNewEquip.Name = "btAddNewEquip"
        Me.btAddNewEquip.Size = New System.Drawing.Size(252, 28)
        Me.btAddNewEquip.TabIndex = 9
        Me.btAddNewEquip.Text = "Ajouter"
        Me.btAddNewEquip.UseVisualStyleBackColor = True
        '
        'btCancelNewEquip
        '
        Me.btCancelNewEquip.Location = New System.Drawing.Point(355, 462)
        Me.btCancelNewEquip.Margin = New System.Windows.Forms.Padding(4)
        Me.btCancelNewEquip.Name = "btCancelNewEquip"
        Me.btCancelNewEquip.Size = New System.Drawing.Size(252, 28)
        Me.btCancelNewEquip.TabIndex = 10
        Me.btCancelNewEquip.Text = "Annuler"
        Me.btCancelNewEquip.UseVisualStyleBackColor = True
        '
        'labNumberEquipAdd
        '
        Me.labNumberEquipAdd.AutoSize = True
        Me.labNumberEquipAdd.Location = New System.Drawing.Point(60, 432)
        Me.labNumberEquipAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNumberEquipAdd.Name = "labNumberEquipAdd"
        Me.labNumberEquipAdd.Size = New System.Drawing.Size(179, 17)
        Me.labNumberEquipAdd.TabIndex = 11
        Me.labNumberEquipAdd.Text = "Nombre d'équipement créé"
        '
        'numEquipAdd
        '
        Me.numEquipAdd.Location = New System.Drawing.Point(256, 430)
        Me.numEquipAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.numEquipAdd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEquipAdd.Name = "numEquipAdd"
        Me.numEquipAdd.Size = New System.Drawing.Size(160, 22)
        Me.numEquipAdd.TabIndex = 12
        Me.numEquipAdd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gridEquipmentAdd
        '
        Me.gridEquipmentAdd.AllowUserToAddRows = False
        Me.gridEquipmentAdd.AllowUserToDeleteRows = False
        Me.gridEquipmentAdd.AllowUserToResizeRows = False
        Me.gridEquipmentAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEquipmentAdd.Location = New System.Drawing.Point(715, 145)
        Me.gridEquipmentAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.gridEquipmentAdd.MultiSelect = False
        Me.gridEquipmentAdd.Name = "gridEquipmentAdd"
        Me.gridEquipmentAdd.ReadOnly = True
        Me.gridEquipmentAdd.RowHeadersWidth = 51
        Me.gridEquipmentAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEquipmentAdd.Size = New System.Drawing.Size(515, 309)
        Me.gridEquipmentAdd.TabIndex = 13
        '
        'labEquipmentAddKit
        '
        Me.labEquipmentAddKit.AutoSize = True
        Me.labEquipmentAddKit.Location = New System.Drawing.Point(711, 117)
        Me.labEquipmentAddKit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEquipmentAddKit.Name = "labEquipmentAddKit"
        Me.labEquipmentAddKit.Size = New System.Drawing.Size(197, 17)
        Me.labEquipmentAddKit.TabIndex = 14
        Me.labEquipmentAddKit.Text = "Choix de kit pour l'équipement"
        '
        'btKitAdd
        '
        Me.btKitAdd.Location = New System.Drawing.Point(723, 462)
        Me.btKitAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btKitAdd.Name = "btKitAdd"
        Me.btKitAdd.Size = New System.Drawing.Size(222, 28)
        Me.btKitAdd.TabIndex = 15
        Me.btKitAdd.Text = "Nouveau kit"
        Me.btKitAdd.UseVisualStyleBackColor = True
        '
        'btKitNull
        '
        Me.btKitNull.Location = New System.Drawing.Point(1000, 462)
        Me.btKitNull.Margin = New System.Windows.Forms.Padding(4)
        Me.btKitNull.Name = "btKitNull"
        Me.btKitNull.Size = New System.Drawing.Size(222, 28)
        Me.btKitNull.TabIndex = 16
        Me.btKitNull.Text = "Désélectionner kit"
        Me.btKitNull.UseVisualStyleBackColor = True
        '
        'UCEquipmentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btKitNull)
        Me.Controls.Add(Me.btKitAdd)
        Me.Controls.Add(Me.labEquipmentAddKit)
        Me.Controls.Add(Me.gridEquipmentAdd)
        Me.Controls.Add(Me.numEquipAdd)
        Me.Controls.Add(Me.labNumberEquipAdd)
        Me.Controls.Add(Me.btCancelNewEquip)
        Me.Controls.Add(Me.btAddNewEquip)
        Me.Controls.Add(Me.labStateEquipAdd)
        Me.Controls.Add(Me.tbState)
        Me.Controls.Add(Me.checkAvailableEquipAdd)
        Me.Controls.Add(Me.labComment)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.tbNameEquipmentAdd)
        Me.Controls.Add(Me.labNameEquipmentAdd)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCEquipmentAdd"
        Me.Size = New System.Drawing.Size(1263, 744)
        CType(Me.numEquipAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEquipmentAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labNameEquipmentAdd As Label
    Friend WithEvents tbNameEquipmentAdd As TextBox
    Friend WithEvents tbComment As RichTextBox
    Friend WithEvents labComment As Label
    Friend WithEvents checkAvailableEquipAdd As CheckBox
    Friend WithEvents tbState As TextBox
    Friend WithEvents labStateEquipAdd As Label
    Friend WithEvents btAddNewEquip As Button
    Friend WithEvents btCancelNewEquip As Button
    Friend WithEvents labNumberEquipAdd As Label
    Friend WithEvents numEquipAdd As NumericUpDown
    Friend WithEvents gridEquipmentAdd As DataGridView
    Friend WithEvents labEquipmentAddKit As Label
    Friend WithEvents btKitAdd As Button
    Friend WithEvents btKitNull As Button
End Class
