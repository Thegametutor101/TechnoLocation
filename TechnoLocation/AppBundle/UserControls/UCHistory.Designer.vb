<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCHistory
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
        Me.grid_history = New System.Windows.Forms.DataGridView()
        Me.drop_history = New System.Windows.Forms.ComboBox()
        Me.tb_history = New System.Windows.Forms.TextBox()
        Me.cb_all = New System.Windows.Forms.CheckBox()
        CType(Me.grid_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_history
        '
        Me.grid_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_history.Location = New System.Drawing.Point(2, 67)
        Me.grid_history.Name = "grid_history"
        Me.grid_history.Size = New System.Drawing.Size(953, 569)
        Me.grid_history.TabIndex = 7
        '
        'drop_history
        '
        Me.drop_history.FormattingEnabled = True
        Me.drop_history.Location = New System.Drawing.Point(335, 10)
        Me.drop_history.Name = "drop_history"
        Me.drop_history.Size = New System.Drawing.Size(135, 21)
        Me.drop_history.TabIndex = 6
        '
        'tb_history
        '
        Me.tb_history.Location = New System.Drawing.Point(2, 10)
        Me.tb_history.Name = "tb_history"
        Me.tb_history.Size = New System.Drawing.Size(281, 20)
        Me.tb_history.TabIndex = 5
        Me.tb_history.Text = "Recherche"
        '
        'cb_all
        '
        Me.cb_all.AutoSize = True
        Me.cb_all.Location = New System.Drawing.Point(3, 44)
        Me.cb_all.Name = "cb_all"
        Me.cb_all.Size = New System.Drawing.Size(70, 17)
        Me.cb_all.TabIndex = 8
        Me.cb_all.Text = "Check all"
        Me.cb_all.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cb_all)
        Me.Controls.Add(Me.grid_history)
        Me.Controls.Add(Me.drop_history)
        Me.Controls.Add(Me.tb_history)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.grid_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_history As DataGridView
    Friend WithEvents drop_history As ComboBox
    Friend WithEvents tb_history As TextBox
    Friend WithEvents cb_all As CheckBox
End Class
