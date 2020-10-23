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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numEquipAdd = New System.Windows.Forms.NumericUpDown()
        CType(Me.numEquipAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labNameEquipmentAdd
        '
        Me.labNameEquipmentAdd.AutoSize = True
        Me.labNameEquipmentAdd.Location = New System.Drawing.Point(184, 113)
        Me.labNameEquipmentAdd.Name = "labNameEquipmentAdd"
        Me.labNameEquipmentAdd.Size = New System.Drawing.Size(95, 13)
        Me.labNameEquipmentAdd.TabIndex = 0
        Me.labNameEquipmentAdd.Text = "Nom d'équipement"
        '
        'tbNameEquipmentAdd
        '
        Me.tbNameEquipmentAdd.Location = New System.Drawing.Point(331, 110)
        Me.tbNameEquipmentAdd.Name = "tbNameEquipmentAdd"
        Me.tbNameEquipmentAdd.Size = New System.Drawing.Size(273, 20)
        Me.tbNameEquipmentAdd.TabIndex = 1
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(331, 136)
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(273, 176)
        Me.tbComment.TabIndex = 3
        Me.tbComment.Text = ""
        '
        'labComment
        '
        Me.labComment.AutoSize = True
        Me.labComment.Location = New System.Drawing.Point(184, 139)
        Me.labComment.Name = "labComment"
        Me.labComment.Size = New System.Drawing.Size(68, 13)
        Me.labComment.TabIndex = 4
        Me.labComment.Text = "Commentaire"
        '
        'checkAvailableEquipAdd
        '
        Me.checkAvailableEquipAdd.AutoSize = True
        Me.checkAvailableEquipAdd.Checked = True
        Me.checkAvailableEquipAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAvailableEquipAdd.Location = New System.Drawing.Point(331, 344)
        Me.checkAvailableEquipAdd.Name = "checkAvailableEquipAdd"
        Me.checkAvailableEquipAdd.Size = New System.Drawing.Size(106, 17)
        Me.checkAvailableEquipAdd.TabIndex = 6
        Me.checkAvailableEquipAdd.Text = "Mettre disponible"
        Me.checkAvailableEquipAdd.UseVisualStyleBackColor = True
        '
        'tbState
        '
        Me.tbState.Location = New System.Drawing.Point(331, 318)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(273, 20)
        Me.tbState.TabIndex = 7
        '
        'labStateEquipAdd
        '
        Me.labStateEquipAdd.AutoSize = True
        Me.labStateEquipAdd.Location = New System.Drawing.Point(184, 321)
        Me.labStateEquipAdd.Name = "labStateEquipAdd"
        Me.labStateEquipAdd.Size = New System.Drawing.Size(103, 13)
        Me.labStateEquipAdd.TabIndex = 8
        Me.labStateEquipAdd.Text = "État de l'équipement"
        '
        'btAddNewEquip
        '
        Me.btAddNewEquip.Location = New System.Drawing.Point(187, 393)
        Me.btAddNewEquip.Name = "btAddNewEquip"
        Me.btAddNewEquip.Size = New System.Drawing.Size(209, 23)
        Me.btAddNewEquip.TabIndex = 9
        Me.btAddNewEquip.Text = "Ajouter"
        Me.btAddNewEquip.UseVisualStyleBackColor = True
        '
        'btCancelNewEquip
        '
        Me.btCancelNewEquip.Location = New System.Drawing.Point(395, 393)
        Me.btCancelNewEquip.Name = "btCancelNewEquip"
        Me.btCancelNewEquip.Size = New System.Drawing.Size(209, 23)
        Me.btCancelNewEquip.TabIndex = 10
        Me.btCancelNewEquip.Text = "Annuler"
        Me.btCancelNewEquip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre d'équipement créé"
        '
        'numEquipAdd
        '
        Me.numEquipAdd.Location = New System.Drawing.Point(331, 367)
        Me.numEquipAdd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numEquipAdd.Name = "numEquipAdd"
        Me.numEquipAdd.Size = New System.Drawing.Size(120, 20)
        Me.numEquipAdd.TabIndex = 12
        Me.numEquipAdd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'UCEquipmentAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.numEquipAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCancelNewEquip)
        Me.Controls.Add(Me.btAddNewEquip)
        Me.Controls.Add(Me.labStateEquipAdd)
        Me.Controls.Add(Me.tbState)
        Me.Controls.Add(Me.checkAvailableEquipAdd)
        Me.Controls.Add(Me.labComment)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.tbNameEquipmentAdd)
        Me.Controls.Add(Me.labNameEquipmentAdd)
        Me.Name = "UCEquipmentAdd"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.numEquipAdd, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents numEquipAdd As NumericUpDown
End Class
