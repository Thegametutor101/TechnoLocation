<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserModify
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
        Me.labPermissionsUser = New System.Windows.Forms.Label()
        Me.labJobUser = New System.Windows.Forms.Label()
        Me.labPhone2User = New System.Windows.Forms.Label()
        Me.labPhoneUser = New System.Windows.Forms.Label()
        Me.labEmailUser = New System.Windows.Forms.Label()
        Me.labLastNameUser = New System.Windows.Forms.Label()
        Me.labFirstNameUser = New System.Windows.Forms.Label()
        Me.labCodeUser = New System.Windows.Forms.Label()
        Me.tbPermissions = New System.Windows.Forms.TextBox()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.tbPhone2 = New System.Windows.Forms.TextBox()
        Me.tbPhone1 = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.btCancelUser = New System.Windows.Forms.Button()
        Me.btModifyUser = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.labPasswordUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labPermissionsUser
        '
        Me.labPermissionsUser.AutoSize = True
        Me.labPermissionsUser.Location = New System.Drawing.Point(516, 356)
        Me.labPermissionsUser.Name = "labPermissionsUser"
        Me.labPermissionsUser.Size = New System.Drawing.Size(65, 13)
        Me.labPermissionsUser.TabIndex = 40
        Me.labPermissionsUser.Text = "Permissions:"
        '
        'labJobUser
        '
        Me.labJobUser.AutoSize = True
        Me.labJobUser.Location = New System.Drawing.Point(226, 356)
        Me.labJobUser.Name = "labJobUser"
        Me.labJobUser.Size = New System.Drawing.Size(27, 13)
        Me.labJobUser.TabIndex = 39
        Me.labJobUser.Text = "Job:"
        '
        'labPhone2User
        '
        Me.labPhone2User.AutoSize = True
        Me.labPhone2User.Location = New System.Drawing.Point(511, 283)
        Me.labPhone2User.Name = "labPhone2User"
        Me.labPhone2User.Size = New System.Drawing.Size(70, 13)
        Me.labPhone2User.TabIndex = 38
        Me.labPhone2User.Text = "Téléphone 2:"
        '
        'labPhoneUser
        '
        Me.labPhoneUser.AutoSize = True
        Me.labPhoneUser.Location = New System.Drawing.Point(192, 283)
        Me.labPhoneUser.Name = "labPhoneUser"
        Me.labPhoneUser.Size = New System.Drawing.Size(61, 13)
        Me.labPhoneUser.TabIndex = 37
        Me.labPhoneUser.Text = "Téléphone:"
        '
        'labEmailUser
        '
        Me.labEmailUser.AutoSize = True
        Me.labEmailUser.Location = New System.Drawing.Point(218, 213)
        Me.labEmailUser.Name = "labEmailUser"
        Me.labEmailUser.Size = New System.Drawing.Size(35, 13)
        Me.labEmailUser.TabIndex = 36
        Me.labEmailUser.Text = "Email:"
        '
        'labLastNameUser
        '
        Me.labLastNameUser.AutoSize = True
        Me.labLastNameUser.Location = New System.Drawing.Point(549, 145)
        Me.labLastNameUser.Name = "labLastNameUser"
        Me.labLastNameUser.Size = New System.Drawing.Size(32, 13)
        Me.labLastNameUser.TabIndex = 34
        Me.labLastNameUser.Text = "Nom:"
        '
        'labFirstNameUser
        '
        Me.labFirstNameUser.AutoSize = True
        Me.labFirstNameUser.Location = New System.Drawing.Point(207, 145)
        Me.labFirstNameUser.Name = "labFirstNameUser"
        Me.labFirstNameUser.Size = New System.Drawing.Size(46, 13)
        Me.labFirstNameUser.TabIndex = 33
        Me.labFirstNameUser.Text = "Prénom:"
        '
        'labCodeUser
        '
        Me.labCodeUser.AutoSize = True
        Me.labCodeUser.Location = New System.Drawing.Point(218, 81)
        Me.labCodeUser.Name = "labCodeUser"
        Me.labCodeUser.Size = New System.Drawing.Size(35, 13)
        Me.labCodeUser.TabIndex = 32
        Me.labCodeUser.Text = "Code:"
        '
        'tbPermissions
        '
        Me.tbPermissions.Location = New System.Drawing.Point(584, 353)
        Me.tbPermissions.Name = "tbPermissions"
        Me.tbPermissions.Size = New System.Drawing.Size(171, 20)
        Me.tbPermissions.TabIndex = 31
        '
        'tbJob
        '
        Me.tbJob.Location = New System.Drawing.Point(256, 353)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(171, 20)
        Me.tbJob.TabIndex = 30
        '
        'tbPhone2
        '
        Me.tbPhone2.Location = New System.Drawing.Point(584, 280)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.Size = New System.Drawing.Size(171, 20)
        Me.tbPhone2.TabIndex = 29
        '
        'tbPhone1
        '
        Me.tbPhone1.Location = New System.Drawing.Point(256, 280)
        Me.tbPhone1.Name = "tbPhone1"
        Me.tbPhone1.Size = New System.Drawing.Size(171, 20)
        Me.tbPhone1.TabIndex = 28
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(256, 210)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(171, 20)
        Me.tbEmail.TabIndex = 27
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(584, 142)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(171, 20)
        Me.tbLastName.TabIndex = 25
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(256, 142)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(171, 20)
        Me.tbFirstName.TabIndex = 24
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(256, 78)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(171, 20)
        Me.tbCode.TabIndex = 23
        '
        'btCancelUser
        '
        Me.btCancelUser.Location = New System.Drawing.Point(533, 477)
        Me.btCancelUser.Name = "btCancelUser"
        Me.btCancelUser.Size = New System.Drawing.Size(115, 49)
        Me.btCancelUser.TabIndex = 22
        Me.btCancelUser.Text = "Annuler"
        Me.btCancelUser.UseVisualStyleBackColor = True
        '
        'btModifyUser
        '
        Me.btModifyUser.Location = New System.Drawing.Point(369, 477)
        Me.btModifyUser.Name = "btModifyUser"
        Me.btModifyUser.Size = New System.Drawing.Size(115, 49)
        Me.btModifyUser.TabIndex = 21
        Me.btModifyUser.Text = "Modifier"
        Me.btModifyUser.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(490, 428)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(171, 20)
        Me.tbPassword.TabIndex = 26
        '
        'labPasswordUser
        '
        Me.labPasswordUser.AutoSize = True
        Me.labPasswordUser.Location = New System.Drawing.Point(357, 431)
        Me.labPasswordUser.Name = "labPasswordUser"
        Me.labPasswordUser.Size = New System.Drawing.Size(133, 13)
        Me.labPasswordUser.TabIndex = 35
        Me.labPasswordUser.Text = "Entrez votre mot de passe:"
        '
        'UCUserModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labPermissionsUser)
        Me.Controls.Add(Me.labJobUser)
        Me.Controls.Add(Me.labPhone2User)
        Me.Controls.Add(Me.labPhoneUser)
        Me.Controls.Add(Me.labEmailUser)
        Me.Controls.Add(Me.labPasswordUser)
        Me.Controls.Add(Me.labLastNameUser)
        Me.Controls.Add(Me.labFirstNameUser)
        Me.Controls.Add(Me.labCodeUser)
        Me.Controls.Add(Me.tbPermissions)
        Me.Controls.Add(Me.tbJob)
        Me.Controls.Add(Me.tbPhone2)
        Me.Controls.Add(Me.tbPhone1)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.btCancelUser)
        Me.Controls.Add(Me.btModifyUser)
        Me.Name = "UCUserModify"
        Me.Size = New System.Drawing.Size(947, 604)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labPermissionsUser As Label
    Friend WithEvents labJobUser As Label
    Friend WithEvents labPhone2User As Label
    Friend WithEvents labPhoneUser As Label
    Friend WithEvents labEmailUser As Label
    Friend WithEvents labLastNameUser As Label
    Friend WithEvents labFirstNameUser As Label
    Friend WithEvents labCodeUser As Label
    Friend WithEvents tbPermissions As TextBox
    Friend WithEvents tbJob As TextBox
    Friend WithEvents tbPhone2 As TextBox
    Friend WithEvents tbPhone1 As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbCode As TextBox
    Friend WithEvents btCancelUser As Button
    Friend WithEvents btModifyUser As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents labPasswordUser As Label
End Class
