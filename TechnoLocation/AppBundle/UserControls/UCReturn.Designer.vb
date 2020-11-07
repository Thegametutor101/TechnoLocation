<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCReturn
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
        Me.tbReturnSearch = New System.Windows.Forms.TextBox()
        Me.dropReturnSearch = New System.Windows.Forms.ComboBox()
        Me.gridReturn = New System.Windows.Forms.DataGridView()
        Me.checkReturn = New System.Windows.Forms.CheckBox()
        Me.btReturn = New System.Windows.Forms.Button()
        CType(Me.gridReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbReturnSearch
        '
        Me.tbReturnSearch.Location = New System.Drawing.Point(4, 22)
        Me.tbReturnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbReturnSearch.Name = "tbReturnSearch"
        Me.tbReturnSearch.Size = New System.Drawing.Size(373, 22)
        Me.tbReturnSearch.TabIndex = 0
        Me.tbReturnSearch.Text = "Recherche"
        '
        'dropReturnSearch
        '
        Me.dropReturnSearch.FormattingEnabled = True
        Me.dropReturnSearch.Location = New System.Drawing.Point(448, 22)
        Me.dropReturnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dropReturnSearch.Name = "dropReturnSearch"
        Me.dropReturnSearch.Size = New System.Drawing.Size(179, 24)
        Me.dropReturnSearch.TabIndex = 1
        '
        'gridReturn
        '
        Me.gridReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridReturn.Location = New System.Drawing.Point(4, 96)
        Me.gridReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gridReturn.Name = "gridReturn"
        Me.gridReturn.RowHeadersWidth = 51
        Me.gridReturn.Size = New System.Drawing.Size(1271, 700)
        Me.gridReturn.TabIndex = 2
        '
        'checkReturn
        '
        Me.checkReturn.AutoSize = True
        Me.checkReturn.Location = New System.Drawing.Point(4, 68)
        Me.checkReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkReturn.Name = "checkReturn"
        Me.checkReturn.Size = New System.Drawing.Size(103, 21)
        Me.checkReturn.TabIndex = 3
        Me.checkReturn.Text = "Cocher tout"
        Me.checkReturn.UseVisualStyleBackColor = True
        '
        'btReturn
        '
        Me.btReturn.Location = New System.Drawing.Point(120, 63)
        Me.btReturn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.Size = New System.Drawing.Size(139, 28)
        Me.btReturn.TabIndex = 4
        Me.btReturn.Text = "Confirmer retour"
        Me.btReturn.UseVisualStyleBackColor = True
        '
        'UCReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btReturn)
        Me.Controls.Add(Me.checkReturn)
        Me.Controls.Add(Me.gridReturn)
        Me.Controls.Add(Me.dropReturnSearch)
        Me.Controls.Add(Me.tbReturnSearch)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCReturn"
        Me.Size = New System.Drawing.Size(1263, 744)
        CType(Me.gridReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbReturnSearch As TextBox
    Friend WithEvents dropReturnSearch As ComboBox
    Friend WithEvents gridReturn As DataGridView
    Friend WithEvents checkReturn As CheckBox
    Friend WithEvents btReturn As Button
End Class
