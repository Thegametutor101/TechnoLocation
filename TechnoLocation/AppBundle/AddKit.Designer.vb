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
        Me.tbNameKitAdd = New System.Windows.Forms.TextBox()
        Me.LabNameKitAdd = New System.Windows.Forms.Label()
        Me.btKitAdd = New System.Windows.Forms.Button()
        Me.btKitCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNameKitAdd
        '
        Me.tbNameKitAdd.Location = New System.Drawing.Point(121, 35)
        Me.tbNameKitAdd.Name = "tbNameKitAdd"
        Me.tbNameKitAdd.Size = New System.Drawing.Size(100, 20)
        Me.tbNameKitAdd.TabIndex = 0
        '
        'LabNameKitAdd
        '
        Me.LabNameKitAdd.AutoSize = True
        Me.LabNameKitAdd.Location = New System.Drawing.Point(24, 38)
        Me.LabNameKitAdd.Name = "LabNameKitAdd"
        Me.LabNameKitAdd.Size = New System.Drawing.Size(58, 13)
        Me.LabNameKitAdd.TabIndex = 1
        Me.LabNameKitAdd.Text = "Nom du kit"
        '
        'btKitAdd
        '
        Me.btKitAdd.Location = New System.Drawing.Point(27, 69)
        Me.btKitAdd.Name = "btKitAdd"
        Me.btKitAdd.Size = New System.Drawing.Size(75, 23)
        Me.btKitAdd.TabIndex = 2
        Me.btKitAdd.Text = "Ajouter"
        Me.btKitAdd.UseVisualStyleBackColor = True
        '
        'btKitCancel
        '
        Me.btKitCancel.Location = New System.Drawing.Point(146, 69)
        Me.btKitCancel.Name = "btKitCancel"
        Me.btKitCancel.Size = New System.Drawing.Size(75, 23)
        Me.btKitCancel.TabIndex = 3
        Me.btKitCancel.Text = "Annuler"
        Me.btKitCancel.UseVisualStyleBackColor = True
        '
        'AddKit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 131)
        Me.Controls.Add(Me.btKitCancel)
        Me.Controls.Add(Me.btKitAdd)
        Me.Controls.Add(Me.LabNameKitAdd)
        Me.Controls.Add(Me.tbNameKitAdd)
        Me.Name = "AddKit"
        Me.Text = "AddKit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNameKitAdd As TextBox
    Friend WithEvents LabNameKitAdd As Label
    Friend WithEvents btKitAdd As Button
    Friend WithEvents btKitCancel As Button
End Class
