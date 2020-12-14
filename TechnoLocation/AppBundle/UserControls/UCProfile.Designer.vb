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
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.labName = New System.Windows.Forms.Label()
        Me.tbPhone1 = New System.Windows.Forms.TextBox()
        Me.labTelephone = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.tbPhone2 = New System.Windows.Forms.TextBox()
        Me.labTelephone2 = New System.Windows.Forms.Label()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.labJob = New System.Windows.Forms.Label()
        Me.labTitre = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.btSaveModifications = New System.Windows.Forms.Button()
        Me.btDeleteAccount = New System.Windows.Forms.Button()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.labPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labCode
        '
        Me.labCode.AutoSize = True
        Me.labCode.Location = New System.Drawing.Point(345, 90)
        Me.labCode.Name = "labCode"
        Me.labCode.Size = New System.Drawing.Size(35, 13)
        Me.labCode.TabIndex = 0
        Me.labCode.Text = "Code:"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(386, 133)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(173, 20)
        Me.tbFirstName.TabIndex = 3
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(334, 136)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(46, 13)
        Me.labName.TabIndex = 2
        Me.labName.Text = "Prénom:"
        '
        'tbPhone1
        '
        Me.tbPhone1.Location = New System.Drawing.Point(386, 265)
        Me.tbPhone1.Name = "tbPhone1"
        Me.tbPhone1.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone1.TabIndex = 7
        '
        'labTelephone
        '
        Me.labTelephone.AutoSize = True
        Me.labTelephone.Location = New System.Drawing.Point(319, 268)
        Me.labTelephone.Name = "labTelephone"
        Me.labTelephone.Size = New System.Drawing.Size(61, 13)
        Me.labTelephone.TabIndex = 6
        Me.labTelephone.Text = "Téléphone:"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(386, 219)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(173, 20)
        Me.tbEmail.TabIndex = 5
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(345, 222)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(35, 13)
        Me.labEmail.TabIndex = 4
        Me.labEmail.Text = "Email:"
        '
        'tbPhone2
        '
        Me.tbPhone2.Location = New System.Drawing.Point(386, 309)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone2.TabIndex = 9
        '
        'labTelephone2
        '
        Me.labTelephone2.AutoSize = True
        Me.labTelephone2.Location = New System.Drawing.Point(310, 312)
        Me.labTelephone2.Name = "labTelephone2"
        Me.labTelephone2.Size = New System.Drawing.Size(70, 13)
        Me.labTelephone2.TabIndex = 8
        Me.labTelephone2.Text = "Téléphone 2:"
        '
        'tbJob
        '
        Me.tbJob.Location = New System.Drawing.Point(386, 354)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(173, 20)
        Me.tbJob.TabIndex = 11
        '
        'labJob
        '
        Me.labJob.AutoSize = True
        Me.labJob.Location = New System.Drawing.Point(353, 357)
        Me.labJob.Name = "labJob"
        Me.labJob.Size = New System.Drawing.Size(27, 13)
        Me.labJob.TabIndex = 10
        Me.labJob.Text = "Job:"
        '
        'labTitre
        '
        Me.labTitre.AutoSize = True
        Me.labTitre.Location = New System.Drawing.Point(419, 42)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(30, 13)
        Me.labTitre.TabIndex = 12
        Me.labTitre.Text = "Profil"
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(386, 87)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.ReadOnly = True
        Me.tbCode.Size = New System.Drawing.Size(173, 20)
        Me.tbCode.TabIndex = 1
        '
        'btSaveModifications
        '
        Me.btSaveModifications.Location = New System.Drawing.Point(402, 464)
        Me.btSaveModifications.Name = "btSaveModifications"
        Me.btSaveModifications.Size = New System.Drawing.Size(157, 23)
        Me.btSaveModifications.TabIndex = 13
        Me.btSaveModifications.Text = "Sauvegarder les modifications"
        Me.btSaveModifications.UseVisualStyleBackColor = True
        '
        'btDeleteAccount
        '
        Me.btDeleteAccount.Location = New System.Drawing.Point(402, 511)
        Me.btDeleteAccount.Name = "btDeleteAccount"
        Me.btDeleteAccount.Size = New System.Drawing.Size(157, 23)
        Me.btDeleteAccount.TabIndex = 14
        Me.btDeleteAccount.Text = "Supprimer mon Compte"
        Me.btDeleteAccount.UseVisualStyleBackColor = True
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(386, 178)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(173, 20)
        Me.tbLastName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nom:"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(386, 400)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(173, 20)
        Me.tbPassword.TabIndex = 18
        '
        'labPassword
        '
        Me.labPassword.AutoSize = True
        Me.labPassword.Location = New System.Drawing.Point(309, 403)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(74, 13)
        Me.labPassword.TabIndex = 17
        Me.labPassword.Text = "Mot de passe:"
        '
        'UCProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.labPassword)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btDeleteAccount)
        Me.Controls.Add(Me.btSaveModifications)
        Me.Controls.Add(Me.labTitre)
        Me.Controls.Add(Me.tbJob)
        Me.Controls.Add(Me.labJob)
        Me.Controls.Add(Me.tbPhone2)
        Me.Controls.Add(Me.labTelephone2)
        Me.Controls.Add(Me.tbPhone1)
        Me.Controls.Add(Me.labTelephone)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.labCode)
        Me.Name = "UCProfile"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labCode As Label
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents labName As Label
    Friend WithEvents tbPhone1 As TextBox
    Friend WithEvents labTelephone As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents labEmail As Label
    Friend WithEvents tbPhone2 As TextBox
    Friend WithEvents labTelephone2 As Label
    Friend WithEvents tbJob As TextBox
    Friend WithEvents labJob As Label
    Friend WithEvents labTitre As Label
    Friend WithEvents tbCode As TextBox
    Friend WithEvents btSaveModifications As Button
    Friend WithEvents btDeleteAccount As Button
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents labPassword As Label
End Class
