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
        Me.gridHistory = New System.Windows.Forms.DataGridView()
        Me.dropHistory = New System.Windows.Forms.ComboBox()
        Me.tbHistory = New System.Windows.Forms.TextBox()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        CType(Me.gridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridHistory
        '
        Me.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridHistory.Location = New System.Drawing.Point(3, 82)
        Me.gridHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridHistory.Name = "gridHistory"
        Me.gridHistory.RowHeadersWidth = 51
        Me.gridHistory.Size = New System.Drawing.Size(1271, 700)
        Me.gridHistory.TabIndex = 7
        '
        'dropHistory
        '
        Me.dropHistory.FormattingEnabled = True
        Me.dropHistory.Location = New System.Drawing.Point(447, 12)
        Me.dropHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dropHistory.Name = "dropHistory"
        Me.dropHistory.Size = New System.Drawing.Size(179, 24)
        Me.dropHistory.TabIndex = 6
        '
        'tbHistory
        '
        Me.tbHistory.Location = New System.Drawing.Point(3, 12)
        Me.tbHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbHistory.Name = "tbHistory"
        Me.tbHistory.Size = New System.Drawing.Size(373, 22)
        Me.tbHistory.TabIndex = 5
        Me.tbHistory.Text = "Recherche"
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(4, 54)
        Me.cbAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(103, 21)
        Me.cbAll.TabIndex = 8
        Me.cbAll.Text = "Cocher tout"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'UCHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.gridHistory)
        Me.Controls.Add(Me.dropHistory)
        Me.Controls.Add(Me.tbHistory)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCHistory"
        Me.Size = New System.Drawing.Size(1263, 744)
        CType(Me.gridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridHistory As DataGridView
    Friend WithEvents dropHistory As ComboBox
    Friend WithEvents tbHistory As TextBox
    Friend WithEvents cbAll As CheckBox
End Class
