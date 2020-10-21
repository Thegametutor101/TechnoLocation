<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDashboard
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.labLoan = New System.Windows.Forms.Label()
        Me.labUser = New System.Windows.Forms.Label()
        Me.labInactive = New System.Windows.Forms.Label()
        Me.labAmount = New System.Windows.Forms.Label()
        Me.pbGraph = New System.Windows.Forms.PictureBox()
        Me.gridLate = New System.Windows.Forms.DataGridView()
        Me.lab_late = New System.Windows.Forms.Label()
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(656, 228)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'labLoan
        '
        Me.labLoan.AutoSize = True
        Me.labLoan.BackColor = System.Drawing.Color.White
        Me.labLoan.Location = New System.Drawing.Point(65, 40)
        Me.labLoan.MinimumSize = New System.Drawing.Size(200, 120)
        Me.labLoan.Name = "labLoan"
        Me.labLoan.Size = New System.Drawing.Size(200, 120)
        Me.labLoan.TabIndex = 1
        Me.labLoan.Text = "# emprunts"
        Me.labLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labUser
        '
        Me.labUser.AutoSize = True
        Me.labUser.BackColor = System.Drawing.Color.White
        Me.labUser.Location = New System.Drawing.Point(271, 40)
        Me.labUser.MinimumSize = New System.Drawing.Size(200, 120)
        Me.labUser.Name = "labUser"
        Me.labUser.Size = New System.Drawing.Size(200, 120)
        Me.labUser.TabIndex = 2
        Me.labUser.Text = "# utilisateurs"
        Me.labUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labInactive
        '
        Me.labInactive.AutoSize = True
        Me.labInactive.BackColor = System.Drawing.Color.White
        Me.labInactive.Location = New System.Drawing.Point(477, 40)
        Me.labInactive.MinimumSize = New System.Drawing.Size(200, 120)
        Me.labInactive.Name = "labInactive"
        Me.labInactive.Size = New System.Drawing.Size(200, 120)
        Me.labInactive.TabIndex = 3
        Me.labInactive.Text = "# Utilisateurs Inactifs"
        Me.labInactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labAmount
        '
        Me.labAmount.AutoSize = True
        Me.labAmount.BackColor = System.Drawing.Color.White
        Me.labAmount.Location = New System.Drawing.Point(683, 40)
        Me.labAmount.MinimumSize = New System.Drawing.Size(200, 120)
        Me.labAmount.Name = "labAmount"
        Me.labAmount.Size = New System.Drawing.Size(200, 120)
        Me.labAmount.TabIndex = 4
        Me.labAmount.Text = "Montant dépôt"
        Me.labAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbGraph
        '
        Me.pbGraph.Location = New System.Drawing.Point(68, 228)
        Me.pbGraph.Name = "pbGraph"
        Me.pbGraph.Size = New System.Drawing.Size(519, 251)
        Me.pbGraph.TabIndex = 5
        Me.pbGraph.TabStop = False
        '
        'gridLate
        '
        Me.gridLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLate.Location = New System.Drawing.Point(68, 518)
        Me.gridLate.Name = "gridLate"
        Me.gridLate.Size = New System.Drawing.Size(815, 129)
        Me.gridLate.TabIndex = 6
        '
        'lab_late
        '
        Me.lab_late.AutoSize = True
        Me.lab_late.Location = New System.Drawing.Point(450, 502)
        Me.lab_late.Name = "lab_late"
        Me.lab_late.Size = New System.Drawing.Size(79, 13)
        Me.lab_late.TabIndex = 7
        Me.lab_late.Text = "Alertes Retards"
        '
        'UCDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lab_late)
        Me.Controls.Add(Me.gridLate)
        Me.Controls.Add(Me.pbGraph)
        Me.Controls.Add(Me.labAmount)
        Me.Controls.Add(Me.labInactive)
        Me.Controls.Add(Me.labUser)
        Me.Controls.Add(Me.labLoan)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "UCDashboard"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents labLoan As Label
    Friend WithEvents labUser As Label
    Friend WithEvents labInactive As Label
    Friend WithEvents labAmount As Label
    Friend WithEvents pbGraph As PictureBox
    Friend WithEvents gridLate As DataGridView
    Friend WithEvents lab_late As Label
End Class
