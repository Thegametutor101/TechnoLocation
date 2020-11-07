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
        Me.panelUC = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelMiddle = New Guna.UI2.WinForms.Guna2Panel()
        Me.pbGraph = New System.Windows.Forms.PictureBox()
        Me.panelBottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.gridLate = New System.Windows.Forms.DataGridView()
        Me.lab_late = New System.Windows.Forms.Label()
        Me.panelTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.labAmount = New System.Windows.Forms.Label()
        Me.labInactive = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TechnoLocationCustomCalendar1 = New TechnoLocation.TechnoLocationCustomCalendar()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelRentCount = New Guna.UI2.WinForms.Guna2Panel()
        Me.labRentCountNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labRentCountName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labTotalUserNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labTotalUserName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelUC.SuspendLayout()
        Me.panelMiddle.SuspendLayout()
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.panelRentCount.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelUC
        '
        Me.panelUC.Controls.Add(Me.panelMiddle)
        Me.panelUC.Controls.Add(Me.panelBottom)
        Me.panelUC.Controls.Add(Me.panelTop)
        Me.panelUC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUC.Location = New System.Drawing.Point(0, 0)
        Me.panelUC.Name = "panelUC"
        Me.panelUC.ShadowDecoration.Parent = Me.panelUC
        Me.panelUC.Size = New System.Drawing.Size(1263, 744)
        Me.panelUC.TabIndex = 0
        '
        'panelMiddle
        '
        Me.panelMiddle.Controls.Add(Me.TechnoLocationCustomCalendar1)
        Me.panelMiddle.Controls.Add(Me.pbGraph)
        Me.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMiddle.Location = New System.Drawing.Point(0, 180)
        Me.panelMiddle.Name = "panelMiddle"
        Me.panelMiddle.ShadowDecoration.Parent = Me.panelMiddle
        Me.panelMiddle.Size = New System.Drawing.Size(1263, 381)
        Me.panelMiddle.TabIndex = 2
        '
        'pbGraph
        '
        Me.pbGraph.Location = New System.Drawing.Point(90, 86)
        Me.pbGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.pbGraph.Name = "pbGraph"
        Me.pbGraph.Size = New System.Drawing.Size(664, 207)
        Me.pbGraph.TabIndex = 13
        Me.pbGraph.TabStop = False
        '
        'panelBottom
        '
        Me.panelBottom.Controls.Add(Me.gridLate)
        Me.panelBottom.Controls.Add(Me.lab_late)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 561)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.ShadowDecoration.Parent = Me.panelBottom
        Me.panelBottom.Size = New System.Drawing.Size(1263, 183)
        Me.panelBottom.TabIndex = 1
        '
        'gridLate
        '
        Me.gridLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLate.Location = New System.Drawing.Point(61, 29)
        Me.gridLate.Margin = New System.Windows.Forms.Padding(4)
        Me.gridLate.Name = "gridLate"
        Me.gridLate.RowHeadersWidth = 51
        Me.gridLate.Size = New System.Drawing.Size(1087, 127)
        Me.gridLate.TabIndex = 14
        '
        'lab_late
        '
        Me.lab_late.AutoSize = True
        Me.lab_late.Location = New System.Drawing.Point(576, 8)
        Me.lab_late.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lab_late.Name = "lab_late"
        Me.lab_late.Size = New System.Drawing.Size(106, 17)
        Me.lab_late.TabIndex = 15
        Me.lab_late.Text = "Alertes Retards"
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.Guna2Panel6)
        Me.panelTop.Controls.Add(Me.Guna2Panel5)
        Me.panelTop.Controls.Add(Me.panelRentCount)
        Me.panelTop.Controls.Add(Me.Guna2Panel2)
        Me.panelTop.Controls.Add(Me.Guna2Panel4)
        Me.panelTop.Controls.Add(Me.labAmount)
        Me.panelTop.Controls.Add(Me.labInactive)
        Me.panelTop.Controls.Add(Me.Guna2Panel1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.ShadowDecoration.Parent = Me.panelTop
        Me.panelTop.Size = New System.Drawing.Size(1263, 180)
        Me.panelTop.TabIndex = 0
        '
        'labAmount
        '
        Me.labAmount.AutoSize = True
        Me.labAmount.BackColor = System.Drawing.Color.White
        Me.labAmount.Location = New System.Drawing.Point(908, 29)
        Me.labAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labAmount.MinimumSize = New System.Drawing.Size(267, 148)
        Me.labAmount.Name = "labAmount"
        Me.labAmount.Size = New System.Drawing.Size(267, 148)
        Me.labAmount.TabIndex = 16
        Me.labAmount.Text = "Montant dépôt"
        Me.labAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labInactive
        '
        Me.labInactive.AutoSize = True
        Me.labInactive.BackColor = System.Drawing.Color.White
        Me.labInactive.Location = New System.Drawing.Point(633, 29)
        Me.labInactive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labInactive.MinimumSize = New System.Drawing.Size(267, 148)
        Me.labInactive.Name = "labInactive"
        Me.labInactive.Size = New System.Drawing.Size(267, 148)
        Me.labInactive.TabIndex = 15
        Me.labInactive.Text = "# Utilisateurs Inactifs"
        Me.labInactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(52, 180)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TechnoLocationCustomCalendar1
        '
        Me.TechnoLocationCustomCalendar1.CurrentDayColor = System.Drawing.Color.SpringGreen
        Me.TechnoLocationCustomCalendar1.Location = New System.Drawing.Point(833, 86)
        Me.TechnoLocationCustomCalendar1.Name = "TechnoLocationCustomCalendar1"
        Me.TechnoLocationCustomCalendar1.TabIndex = 16
        Me.TechnoLocationCustomCalendar1.TrailingForeColor = System.Drawing.Color.SpringGreen
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel4.Location = New System.Drawing.Point(1212, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(51, 180)
        Me.Guna2Panel4.TabIndex = 19
        '
        'panelRentCount
        '
        Me.panelRentCount.BackColor = System.Drawing.Color.White
        Me.panelRentCount.Controls.Add(Me.labRentCountNumber)
        Me.panelRentCount.Controls.Add(Me.labRentCountName)
        Me.panelRentCount.Controls.Add(Me.Guna2Panel3)
        Me.panelRentCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelRentCount.Location = New System.Drawing.Point(52, 20)
        Me.panelRentCount.Name = "panelRentCount"
        Me.panelRentCount.ShadowDecoration.Parent = Me.panelRentCount
        Me.panelRentCount.Size = New System.Drawing.Size(275, 160)
        Me.panelRentCount.TabIndex = 21
        '
        'labRentCountNumber
        '
        Me.labRentCountNumber.BackColor = System.Drawing.Color.Transparent
        Me.labRentCountNumber.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRentCountNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.labRentCountNumber.Location = New System.Drawing.Point(38, 18)
        Me.labRentCountNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.labRentCountNumber.Name = "labRentCountNumber"
        Me.labRentCountNumber.Size = New System.Drawing.Size(188, 91)
        Me.labRentCountNumber.TabIndex = 4
        Me.labRentCountNumber.Text = "99999"
        Me.labRentCountNumber.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labRentCountName
        '
        Me.labRentCountName.BackColor = System.Drawing.Color.Transparent
        Me.labRentCountName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labRentCountName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.labRentCountName.Location = New System.Drawing.Point(20, 124)
        Me.labRentCountName.Name = "labRentCountName"
        Me.labRentCountName.Size = New System.Drawing.Size(228, 25)
        Me.labRentCountName.TabIndex = 2
        Me.labRentCountName.Text = "Nombre d'emprunts en cours"
        Me.labRentCountName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(10, 160)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(52, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1160, 20)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel5.Location = New System.Drawing.Point(327, 20)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(20, 160)
        Me.Guna2Panel5.TabIndex = 5
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.White
        Me.Guna2Panel6.Controls.Add(Me.labTotalUserNumber)
        Me.Guna2Panel6.Controls.Add(Me.labTotalUserName)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel6.Location = New System.Drawing.Point(347, 20)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(275, 160)
        Me.Guna2Panel6.TabIndex = 23
        '
        'labTotalUserNumber
        '
        Me.labTotalUserNumber.BackColor = System.Drawing.Color.Transparent
        Me.labTotalUserNumber.Font = New System.Drawing.Font("Segoe UI Symbol", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalUserNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.labTotalUserNumber.Location = New System.Drawing.Point(48, 18)
        Me.labTotalUserNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.labTotalUserNumber.Name = "labTotalUserNumber"
        Me.labTotalUserNumber.Size = New System.Drawing.Size(77, 91)
        Me.labTotalUserNumber.TabIndex = 7
        Me.labTotalUserNumber.Text = "99"
        Me.labTotalUserNumber.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'labTotalUserName
        '
        Me.labTotalUserName.BackColor = System.Drawing.Color.Transparent
        Me.labTotalUserName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.labTotalUserName.Location = New System.Drawing.Point(33, 124)
        Me.labTotalUserName.Name = "labTotalUserName"
        Me.labTotalUserName.Size = New System.Drawing.Size(167, 25)
        Me.labTotalUserName.TabIndex = 6
        Me.labTotalUserName.Text = "Nombre d'utilisateurs"
        Me.labTotalUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.White
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Guna2Panel7.BorderRadius = 5
        Me.Guna2Panel7.BorderThickness = 1
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(10, 160)
        Me.Guna2Panel7.TabIndex = 5
        '
        'UCDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.panelUC)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCDashboard"
        Me.Size = New System.Drawing.Size(1263, 744)
        Me.panelUC.ResumeLayout(False)
        Me.panelMiddle.ResumeLayout(False)
        CType(Me.pbGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        CType(Me.gridLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelRentCount.ResumeLayout(False)
        Me.panelRentCount.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelUC As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelMiddle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TechnoLocationCustomCalendar1 As TechnoLocationCustomCalendar
    Friend WithEvents pbGraph As PictureBox
    Friend WithEvents panelBottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gridLate As DataGridView
    Friend WithEvents lab_late As Label
    Friend WithEvents panelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labAmount As Label
    Friend WithEvents labInactive As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labTotalUserNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labTotalUserName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelRentCount As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labRentCountNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labRentCountName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
End Class
