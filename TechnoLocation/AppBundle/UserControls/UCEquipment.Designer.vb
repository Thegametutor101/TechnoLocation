<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCEquipment
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
        Me.gridEquipment = New System.Windows.Forms.DataGridView()
        Me.dropSearch = New System.Windows.Forms.ComboBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btPrintBarcodeEquip = New System.Windows.Forms.Button()
        Me.btNewEquipment = New System.Windows.Forms.Button()
        Me.btDelEquipment = New System.Windows.Forms.Button()
        Me.btSelectAllEquipment = New System.Windows.Forms.Button()
        Me.checkAvailableEquip = New System.Windows.Forms.CheckBox()
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridEquipment
        '
        Me.gridEquipment.AllowUserToAddRows = False
        Me.gridEquipment.AllowUserToDeleteRows = False
        Me.gridEquipment.AllowUserToResizeColumns = False
        Me.gridEquipment.AllowUserToResizeRows = False
        Me.gridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEquipment.Location = New System.Drawing.Point(3, 123)
        Me.gridEquipment.Name = "gridEquipment"
        Me.gridEquipment.ReadOnly = True
        Me.gridEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEquipment.Size = New System.Drawing.Size(953, 524)
        Me.gridEquipment.TabIndex = 3
        '
        'dropSearch
        '
        Me.dropSearch.FormattingEnabled = True
        Me.dropSearch.Items.AddRange(New Object() {"Code", "Nom", "Kit", "État", "Commentaire"})
        Me.dropSearch.Location = New System.Drawing.Point(337, 57)
        Me.dropSearch.Name = "dropSearch"
        Me.dropSearch.Size = New System.Drawing.Size(135, 21)
        Me.dropSearch.TabIndex = 5
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(4, 57)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(281, 20)
        Me.tbSearch.TabIndex = 4
        Me.tbSearch.Text = "Recherche"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btPrintBarcodeEquip)
        Me.Panel1.Controls.Add(Me.btNewEquipment)
        Me.Panel1.Controls.Add(Me.btDelEquipment)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 54)
        Me.Panel1.TabIndex = 6
        '
        'btPrintBarcodeEquip
        '
        Me.btPrintBarcodeEquip.Location = New System.Drawing.Point(309, -1)
        Me.btPrintBarcodeEquip.Name = "btPrintBarcodeEquip"
        Me.btPrintBarcodeEquip.Size = New System.Drawing.Size(147, 54)
        Me.btPrintBarcodeEquip.TabIndex = 3
        Me.btPrintBarcodeEquip.Text = "Imprimer les codes barres"
        Me.btPrintBarcodeEquip.UseVisualStyleBackColor = True
        '
        'btNewEquipment
        '
        Me.btNewEquipment.Location = New System.Drawing.Point(3, -1)
        Me.btNewEquipment.Name = "btNewEquipment"
        Me.btNewEquipment.Size = New System.Drawing.Size(147, 54)
        Me.btNewEquipment.TabIndex = 0
        Me.btNewEquipment.Text = "Nouveau"
        Me.btNewEquipment.UseVisualStyleBackColor = True
        '
        'btDelEquipment
        '
        Me.btDelEquipment.Location = New System.Drawing.Point(156, -1)
        Me.btDelEquipment.Name = "btDelEquipment"
        Me.btDelEquipment.Size = New System.Drawing.Size(147, 54)
        Me.btDelEquipment.TabIndex = 2
        Me.btDelEquipment.Text = "Supprimer"
        Me.btDelEquipment.UseVisualStyleBackColor = True
        '
        'btSelectAllEquipment
        '
        Me.btSelectAllEquipment.Location = New System.Drawing.Point(4, 94)
        Me.btSelectAllEquipment.Name = "btSelectAllEquipment"
        Me.btSelectAllEquipment.Size = New System.Drawing.Size(95, 23)
        Me.btSelectAllEquipment.TabIndex = 4
        Me.btSelectAllEquipment.Text = "Sélectionner tout"
        Me.btSelectAllEquipment.UseVisualStyleBackColor = True
        '
        'checkAvailableEquip
        '
        Me.checkAvailableEquip.AutoSize = True
        Me.checkAvailableEquip.Location = New System.Drawing.Point(505, 59)
        Me.checkAvailableEquip.Name = "checkAvailableEquip"
        Me.checkAvailableEquip.Size = New System.Drawing.Size(133, 17)
        Me.checkAvailableEquip.TabIndex = 7
        Me.checkAvailableEquip.Text = "Disponible uniquement"
        Me.checkAvailableEquip.UseVisualStyleBackColor = True
        '
        'UCEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.checkAvailableEquip)
        Me.Controls.Add(Me.btSelectAllEquipment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dropSearch)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.gridEquipment)
        Me.Name = "UCEquipment"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.gridEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridEquipment As DataGridView
    Friend WithEvents dropSearch As ComboBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btNewEquipment As Button
    Friend WithEvents btDelEquipment As Button
    Friend WithEvents btPrintBarcodeEquip As Button
    Friend WithEvents btSelectAllEquipment As Button
    Friend WithEvents checkAvailableEquip As CheckBox
End Class
