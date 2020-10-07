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
        Me.lab_loan = New System.Windows.Forms.Label()
        Me.lab_user = New System.Windows.Forms.Label()
        Me.lab_inactive = New System.Windows.Forms.Label()
        Me.lab_amount = New System.Windows.Forms.Label()
        Me.pb_graph = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lab_late = New System.Windows.Forms.Label()
        CType(Me.pb_graph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(656, 228)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'lab_loan
        '
        Me.lab_loan.AutoSize = True
        Me.lab_loan.BackColor = System.Drawing.Color.White
        Me.lab_loan.Location = New System.Drawing.Point(65, 40)
        Me.lab_loan.MinimumSize = New System.Drawing.Size(200, 120)
        Me.lab_loan.Name = "lab_loan"
        Me.lab_loan.Size = New System.Drawing.Size(200, 120)
        Me.lab_loan.TabIndex = 1
        Me.lab_loan.Text = "# emprunts"
        Me.lab_loan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_user
        '
        Me.lab_user.AutoSize = True
        Me.lab_user.BackColor = System.Drawing.Color.White
        Me.lab_user.Location = New System.Drawing.Point(271, 40)
        Me.lab_user.MinimumSize = New System.Drawing.Size(200, 120)
        Me.lab_user.Name = "lab_user"
        Me.lab_user.Size = New System.Drawing.Size(200, 120)
        Me.lab_user.TabIndex = 2
        Me.lab_user.Text = "# utilisateurs"
        Me.lab_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_inactive
        '
        Me.lab_inactive.AutoSize = True
        Me.lab_inactive.BackColor = System.Drawing.Color.White
        Me.lab_inactive.Location = New System.Drawing.Point(477, 40)
        Me.lab_inactive.MinimumSize = New System.Drawing.Size(200, 120)
        Me.lab_inactive.Name = "lab_inactive"
        Me.lab_inactive.Size = New System.Drawing.Size(200, 120)
        Me.lab_inactive.TabIndex = 3
        Me.lab_inactive.Text = "# Utilisateurs Inactifs"
        Me.lab_inactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_amount
        '
        Me.lab_amount.AutoSize = True
        Me.lab_amount.BackColor = System.Drawing.Color.White
        Me.lab_amount.Location = New System.Drawing.Point(683, 40)
        Me.lab_amount.MinimumSize = New System.Drawing.Size(200, 120)
        Me.lab_amount.Name = "lab_amount"
        Me.lab_amount.Size = New System.Drawing.Size(200, 120)
        Me.lab_amount.TabIndex = 4
        Me.lab_amount.Text = "Montant dépôt"
        Me.lab_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_graph
        '
        Me.pb_graph.Location = New System.Drawing.Point(68, 228)
        Me.pb_graph.Name = "pb_graph"
        Me.pb_graph.Size = New System.Drawing.Size(519, 251)
        Me.pb_graph.TabIndex = 5
        Me.pb_graph.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 518)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(815, 129)
        Me.DataGridView1.TabIndex = 6
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pb_graph)
        Me.Controls.Add(Me.lab_amount)
        Me.Controls.Add(Me.lab_inactive)
        Me.Controls.Add(Me.lab_user)
        Me.Controls.Add(Me.lab_loan)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "UCDashboard"
        Me.Size = New System.Drawing.Size(956, 647)
        CType(Me.pb_graph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lab_loan As Label
    Friend WithEvents lab_user As Label
    Friend WithEvents lab_inactive As Label
    Friend WithEvents lab_amount As Label
    Friend WithEvents pb_graph As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lab_late As Label
End Class
