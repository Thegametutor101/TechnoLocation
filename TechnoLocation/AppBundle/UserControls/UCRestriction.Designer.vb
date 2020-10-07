<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRestriction
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbRestrictionSearch = New System.Windows.Forms.TextBox()
        Me.checkRestriontion = New System.Windows.Forms.CheckBox()
        Me.btDeleteRestriction = New System.Windows.Forms.Button()
        Me.labDateBegin = New System.Windows.Forms.Label()
        Me.labDateEnd = New System.Windows.Forms.Label()
        Me.gridRestriction = New System.Windows.Forms.DataGridView()
        Me.calendarRestriction = New System.Windows.Forms.MonthCalendar()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dateBegin = New System.Windows.Forms.DateTimePicker()
        Me.btSaveRestriction = New System.Windows.Forms.Button()
        Me.btCancelRestriction = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridRestriction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dateEnd)
        Me.Panel1.Controls.Add(Me.dateBegin)
        Me.Panel1.Controls.Add(Me.gridRestriction)
        Me.Panel1.Controls.Add(Me.labDateEnd)
        Me.Panel1.Controls.Add(Me.labDateBegin)
        Me.Panel1.Controls.Add(Me.btDeleteRestriction)
        Me.Panel1.Controls.Add(Me.checkRestriontion)
        Me.Panel1.Controls.Add(Me.tbRestrictionSearch)
        Me.Panel1.Location = New System.Drawing.Point(49, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 368)
        Me.Panel1.TabIndex = 0
        '
        'tbRestrictionSearch
        '
        Me.tbRestrictionSearch.Location = New System.Drawing.Point(22, 20)
        Me.tbRestrictionSearch.Name = "tbRestrictionSearch"
        Me.tbRestrictionSearch.Size = New System.Drawing.Size(162, 20)
        Me.tbRestrictionSearch.TabIndex = 0
        Me.tbRestrictionSearch.Text = "Recherche"
        '
        'checkRestriontion
        '
        Me.checkRestriontion.AutoSize = True
        Me.checkRestriontion.Location = New System.Drawing.Point(22, 101)
        Me.checkRestriontion.Name = "checkRestriontion"
        Me.checkRestriontion.Size = New System.Drawing.Size(81, 17)
        Me.checkRestriontion.TabIndex = 1
        Me.checkRestriontion.Text = "Cocher tout"
        Me.checkRestriontion.UseVisualStyleBackColor = True
        '
        'btDeleteRestriction
        '
        Me.btDeleteRestriction.Location = New System.Drawing.Point(109, 97)
        Me.btDeleteRestriction.Name = "btDeleteRestriction"
        Me.btDeleteRestriction.Size = New System.Drawing.Size(111, 23)
        Me.btDeleteRestriction.TabIndex = 2
        Me.btDeleteRestriction.Text = "Supprimer restriction"
        Me.btDeleteRestriction.UseVisualStyleBackColor = True
        '
        'labDateBegin
        '
        Me.labDateBegin.AutoSize = True
        Me.labDateBegin.Location = New System.Drawing.Point(19, 52)
        Me.labDateBegin.Name = "labDateBegin"
        Me.labDateBegin.Size = New System.Drawing.Size(78, 13)
        Me.labDateBegin.TabIndex = 1
        Me.labDateBegin.Text = "Date de début:"
        '
        'labDateEnd
        '
        Me.labDateEnd.AutoSize = True
        Me.labDateEnd.Location = New System.Drawing.Point(19, 75)
        Me.labDateEnd.Name = "labDateEnd"
        Me.labDateEnd.Size = New System.Drawing.Size(62, 13)
        Me.labDateEnd.TabIndex = 3
        Me.labDateEnd.Text = "Date de fin:"
        '
        'gridRestriction
        '
        Me.gridRestriction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRestriction.Location = New System.Drawing.Point(0, 126)
        Me.gridRestriction.Name = "gridRestriction"
        Me.gridRestriction.Size = New System.Drawing.Size(386, 242)
        Me.gridRestriction.TabIndex = 1
        '
        'calendarRestriction
        '
        Me.calendarRestriction.Location = New System.Drawing.Point(609, 328)
        Me.calendarRestriction.Name = "calendarRestriction"
        Me.calendarRestriction.TabIndex = 1
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(109, 69)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(200, 20)
        Me.dateEnd.TabIndex = 2
        '
        'dateBegin
        '
        Me.dateBegin.Location = New System.Drawing.Point(109, 46)
        Me.dateBegin.Name = "dateBegin"
        Me.dateBegin.Size = New System.Drawing.Size(200, 20)
        Me.dateBegin.TabIndex = 3
        '
        'btSaveRestriction
        '
        Me.btSaveRestriction.Location = New System.Drawing.Point(609, 591)
        Me.btSaveRestriction.Name = "btSaveRestriction"
        Me.btSaveRestriction.Size = New System.Drawing.Size(135, 43)
        Me.btSaveRestriction.TabIndex = 2
        Me.btSaveRestriction.Text = "Sauvegarder"
        Me.btSaveRestriction.UseVisualStyleBackColor = True
        '
        'btCancelRestriction
        '
        Me.btCancelRestriction.Location = New System.Drawing.Point(750, 591)
        Me.btCancelRestriction.Name = "btCancelRestriction"
        Me.btCancelRestriction.Size = New System.Drawing.Size(135, 43)
        Me.btCancelRestriction.TabIndex = 3
        Me.btCancelRestriction.Text = "Annuler"
        Me.btCancelRestriction.UseVisualStyleBackColor = True
        '
        'UCRestriction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btCancelRestriction)
        Me.Controls.Add(Me.btSaveRestriction)
        Me.Controls.Add(Me.calendarRestriction)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCRestriction"
        Me.Size = New System.Drawing.Size(956, 647)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridRestriction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents checkRestriontion As CheckBox
    Friend WithEvents tbRestrictionSearch As TextBox
    Friend WithEvents dateEnd As DateTimePicker
    Friend WithEvents dateBegin As DateTimePicker
    Friend WithEvents gridRestriction As DataGridView
    Friend WithEvents labDateEnd As Label
    Friend WithEvents labDateBegin As Label
    Friend WithEvents btDeleteRestriction As Button
    Friend WithEvents calendarRestriction As MonthCalendar
    Friend WithEvents btSaveRestriction As Button
    Friend WithEvents btCancelRestriction As Button
End Class
