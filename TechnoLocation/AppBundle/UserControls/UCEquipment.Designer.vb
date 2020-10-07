<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEquipment
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
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.drop_search = New System.Windows.Forms.ComboBox()
        Me.cb_all = New System.Windows.Forms.CheckBox()
        Me.grid_equipment = New System.Windows.Forms.DataGridView()
        CType(Me.grid_equipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_search
        '
        Me.tb_search.Location = New System.Drawing.Point(53, 28)
        Me.tb_search.MaximumSize = New System.Drawing.Size(350, 40)
        Me.tb_search.MinimumSize = New System.Drawing.Size(350, 40)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(350, 40)
        Me.tb_search.TabIndex = 0
        '
        'drop_search
        '
        Me.drop_search.FormattingEnabled = True
        Me.drop_search.Location = New System.Drawing.Point(409, 37)
        Me.drop_search.MaximumSize = New System.Drawing.Size(200, 0)
        Me.drop_search.MinimumSize = New System.Drawing.Size(200, 0)
        Me.drop_search.Name = "drop_search"
        Me.drop_search.Size = New System.Drawing.Size(200, 21)
        Me.drop_search.TabIndex = 1
        '
        'cb_all
        '
        Me.cb_all.AutoSize = True
        Me.cb_all.Location = New System.Drawing.Point(3, 100)
        Me.cb_all.Name = "cb_all"
        Me.cb_all.Size = New System.Drawing.Size(70, 17)
        Me.cb_all.TabIndex = 2
        Me.cb_all.Text = "Check all"
        Me.cb_all.UseVisualStyleBackColor = True
        '
        'grid_equipment
        '
        Me.grid_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_equipment.Location = New System.Drawing.Point(3, 134)
        Me.grid_equipment.Name = "grid_equipment"
        Me.grid_equipment.Size = New System.Drawing.Size(950, 510)
        Me.grid_equipment.TabIndex = 3
        '
        'UCEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grid_equipment)
        Me.Controls.Add(Me.cb_all)
        Me.Controls.Add(Me.drop_search)
        Me.Controls.Add(Me.tb_search)
        Me.Name = "UCEquipment"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.grid_equipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_search As TextBox
    Friend WithEvents drop_search As ComboBox
    Friend WithEvents cb_all As CheckBox
    Friend WithEvents grid_equipment As DataGridView
End Class
