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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.checkReturn = New System.Windows.Forms.CheckBox()
        Me.btReturn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbReturnSearch
        '
        Me.tbReturnSearch.Location = New System.Drawing.Point(3, 18)
        Me.tbReturnSearch.Name = "tbReturnSearch"
        Me.tbReturnSearch.Size = New System.Drawing.Size(281, 20)
        Me.tbReturnSearch.TabIndex = 0
        Me.tbReturnSearch.Text = "Recherche"
        '
        'dropReturnSearch
        '
        Me.dropReturnSearch.FormattingEnabled = True
        Me.dropReturnSearch.Location = New System.Drawing.Point(336, 18)
        Me.dropReturnSearch.Name = "dropReturnSearch"
        Me.dropReturnSearch.Size = New System.Drawing.Size(135, 21)
        Me.dropReturnSearch.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(953, 569)
        Me.DataGridView1.TabIndex = 2
        '
        'checkReturn
        '
        Me.checkReturn.AutoSize = True
        Me.checkReturn.Location = New System.Drawing.Point(3, 55)
        Me.checkReturn.Name = "checkReturn"
        Me.checkReturn.Size = New System.Drawing.Size(15, 14)
        Me.checkReturn.TabIndex = 3
        Me.checkReturn.UseVisualStyleBackColor = True
        '
        'btReturn
        '
        Me.btReturn.Location = New System.Drawing.Point(37, 49)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.Size = New System.Drawing.Size(104, 23)
        Me.btReturn.TabIndex = 4
        Me.btReturn.Text = "Confirmer retour"
        Me.btReturn.UseVisualStyleBackColor = True
        '
        'UCReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btReturn)
        Me.Controls.Add(Me.checkReturn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dropReturnSearch)
        Me.Controls.Add(Me.tbReturnSearch)
        Me.Name = "UCReturn"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbReturnSearch As TextBox
    Friend WithEvents dropReturnSearch As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkReturn As CheckBox
    Friend WithEvents btReturn As Button
End Class
