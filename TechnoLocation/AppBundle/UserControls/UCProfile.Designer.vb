<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProfile
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
        Me.labCode = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.labName = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.labTelephone = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.tbPhone2 = New System.Windows.Forms.TextBox()
        Me.labTelephone2 = New System.Windows.Forms.Label()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.labJob = New System.Windows.Forms.Label()
        Me.labTitre = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'labCode
        '
        Me.labCode.AutoSize = True
        Me.labCode.Location = New System.Drawing.Point(353, 147)
        Me.labCode.Name = "labCode"
        Me.labCode.Size = New System.Drawing.Size(35, 13)
        Me.labCode.TabIndex = 0
        Me.labCode.Text = "Code:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(394, 190)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(173, 20)
        Me.tbName.TabIndex = 3
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(356, 193)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(32, 13)
        Me.labName.TabIndex = 2
        Me.labName.Text = "Nom:"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(394, 281)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone.TabIndex = 7
        '
        'labTelephone
        '
        Me.labTelephone.AutoSize = True
        Me.labTelephone.Location = New System.Drawing.Point(327, 284)
        Me.labTelephone.Name = "labTelephone"
        Me.labTelephone.Size = New System.Drawing.Size(61, 13)
        Me.labTelephone.TabIndex = 6
        Me.labTelephone.Text = "Téléphone:"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(394, 235)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(173, 20)
        Me.tbEmail.TabIndex = 5
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(353, 238)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(35, 13)
        Me.labEmail.TabIndex = 4
        Me.labEmail.Text = "Email:"
        '
        'tbPhone2
        '
        Me.tbPhone2.Location = New System.Drawing.Point(394, 325)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone2.TabIndex = 9
        '
        'labTelephone2
        '
        Me.labTelephone2.AutoSize = True
        Me.labTelephone2.Location = New System.Drawing.Point(318, 328)
        Me.labTelephone2.Name = "labTelephone2"
        Me.labTelephone2.Size = New System.Drawing.Size(70, 13)
        Me.labTelephone2.TabIndex = 8
        Me.labTelephone2.Text = "Téléphone 2:"
        '
        'tbJob
        '
        Me.tbJob.Location = New System.Drawing.Point(394, 370)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(173, 20)
        Me.tbJob.TabIndex = 11
        '
        'labJob
        '
        Me.labJob.AutoSize = True
        Me.labJob.Location = New System.Drawing.Point(361, 373)
        Me.labJob.Name = "labJob"
        Me.labJob.Size = New System.Drawing.Size(27, 13)
        Me.labJob.TabIndex = 10
        Me.labJob.Text = "Job:"
        '
        'labTitre
        '
        Me.labTitre.AutoSize = True
        Me.labTitre.Location = New System.Drawing.Point(427, 99)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(30, 13)
        Me.labTitre.TabIndex = 12
        Me.labTitre.Text = "Profil"
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(394, 144)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(173, 20)
        Me.tbCode.TabIndex = 1
        '
        'UCProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labTitre)
        Me.Controls.Add(Me.tbJob)
        Me.Controls.Add(Me.labJob)
        Me.Controls.Add(Me.tbPhone2)
        Me.Controls.Add(Me.labTelephone2)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.labTelephone)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.labCode)
        Me.Name = "UCProfile"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labCode As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents labName As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents labTelephone As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents labEmail As Label
    Friend WithEvents tbPhone2 As TextBox
    Friend WithEvents labTelephone2 As Label
    Friend WithEvents tbJob As TextBox
    Friend WithEvents labJob As Label
    Friend WithEvents labTitre As Label
    Friend WithEvents tbCode As TextBox
End Class
