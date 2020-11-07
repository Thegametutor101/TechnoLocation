<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserAdd
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
        Me.btAddUser = New System.Windows.Forms.Button()
        Me.btCancelUser = New System.Windows.Forms.Button()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbPhone1 = New System.Windows.Forms.TextBox()
        Me.tbPhone2 = New System.Windows.Forms.TextBox()
        Me.tbJob = New System.Windows.Forms.TextBox()
        Me.tbPermissions = New System.Windows.Forms.TextBox()
        Me.labCodeUser = New System.Windows.Forms.Label()
        Me.labFirstNameUser = New System.Windows.Forms.Label()
        Me.labLastNameUser = New System.Windows.Forms.Label()
        Me.labPasswordUser = New System.Windows.Forms.Label()
        Me.labEmailUser = New System.Windows.Forms.Label()
        Me.labPhoneUser = New System.Windows.Forms.Label()
        Me.labPhone2User = New System.Windows.Forms.Label()
        Me.labJobUser = New System.Windows.Forms.Label()
        Me.labPermissionsUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btAddUser
        '
        Me.btAddUser.Location = New System.Drawing.Point(428, 580)
        Me.btAddUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAddUser.Name = "btAddUser"
        Me.btAddUser.Size = New System.Drawing.Size(153, 60)
        Me.btAddUser.TabIndex = 0
        Me.btAddUser.Text = "Ajouter"
        Me.btAddUser.UseVisualStyleBackColor = True
        '
        'btCancelUser
        '
        Me.btCancelUser.Location = New System.Drawing.Point(647, 580)
        Me.btCancelUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btCancelUser.Name = "btCancelUser"
        Me.btCancelUser.Size = New System.Drawing.Size(153, 60)
        Me.btCancelUser.TabIndex = 1
        Me.btCancelUser.Text = "Annuler"
        Me.btCancelUser.UseVisualStyleBackColor = True
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(277, 89)
        Me.tbCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(227, 22)
        Me.tbCode.TabIndex = 2
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(277, 167)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(227, 22)
        Me.tbFirstName.TabIndex = 3
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(715, 167)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(227, 22)
        Me.tbLastName.TabIndex = 4
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(715, 89)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(227, 22)
        Me.tbPassword.TabIndex = 6
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(277, 251)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(227, 22)
        Me.tbEmail.TabIndex = 7
        '
        'tbPhone1
        '
        Me.tbPhone1.Location = New System.Drawing.Point(277, 337)
        Me.tbPhone1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPhone1.Name = "tbPhone1"
        Me.tbPhone1.Size = New System.Drawing.Size(227, 22)
        Me.tbPhone1.TabIndex = 8
        '
        'tbPhone2
        '
        Me.tbPhone2.Location = New System.Drawing.Point(715, 337)
        Me.tbPhone2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.Size = New System.Drawing.Size(227, 22)
        Me.tbPhone2.TabIndex = 9
        '
        'tbJob
        '
        Me.tbJob.Location = New System.Drawing.Point(277, 427)
        Me.tbJob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbJob.Name = "tbJob"
        Me.tbJob.Size = New System.Drawing.Size(227, 22)
        Me.tbJob.TabIndex = 10
        '
        'tbPermissions
        '
        Me.tbPermissions.Location = New System.Drawing.Point(715, 427)
        Me.tbPermissions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPermissions.Name = "tbPermissions"
        Me.tbPermissions.Size = New System.Drawing.Size(227, 22)
        Me.tbPermissions.TabIndex = 11
        '
        'labCodeUser
        '
        Me.labCodeUser.AutoSize = True
        Me.labCodeUser.Location = New System.Drawing.Point(227, 92)
        Me.labCodeUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCodeUser.Name = "labCodeUser"
        Me.labCodeUser.Size = New System.Drawing.Size(45, 17)
        Me.labCodeUser.TabIndex = 12
        Me.labCodeUser.Text = "Code:"
        '
        'labFirstNameUser
        '
        Me.labFirstNameUser.AutoSize = True
        Me.labFirstNameUser.Location = New System.Drawing.Point(212, 171)
        Me.labFirstNameUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFirstNameUser.Name = "labFirstNameUser"
        Me.labFirstNameUser.Size = New System.Drawing.Size(61, 17)
        Me.labFirstNameUser.TabIndex = 13
        Me.labFirstNameUser.Text = "Prénom:"
        '
        'labLastNameUser
        '
        Me.labLastNameUser.AutoSize = True
        Me.labLastNameUser.Location = New System.Drawing.Point(668, 171)
        Me.labLastNameUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labLastNameUser.Name = "labLastNameUser"
        Me.labLastNameUser.Size = New System.Drawing.Size(41, 17)
        Me.labLastNameUser.TabIndex = 14
        Me.labLastNameUser.Text = "Nom:"
        '
        'labPasswordUser
        '
        Me.labPasswordUser.AutoSize = True
        Me.labPasswordUser.Location = New System.Drawing.Point(611, 92)
        Me.labPasswordUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPasswordUser.Name = "labPasswordUser"
        Me.labPasswordUser.Size = New System.Drawing.Size(98, 17)
        Me.labPasswordUser.TabIndex = 15
        Me.labPasswordUser.Text = "Mot de Passe:"
        '
        'labEmailUser
        '
        Me.labEmailUser.AutoSize = True
        Me.labEmailUser.Location = New System.Drawing.Point(227, 255)
        Me.labEmailUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmailUser.Name = "labEmailUser"
        Me.labEmailUser.Size = New System.Drawing.Size(46, 17)
        Me.labEmailUser.TabIndex = 16
        Me.labEmailUser.Text = "Email:"
        '
        'labPhoneUser
        '
        Me.labPhoneUser.AutoSize = True
        Me.labPhoneUser.Location = New System.Drawing.Point(192, 341)
        Me.labPhoneUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPhoneUser.Name = "labPhoneUser"
        Me.labPhoneUser.Size = New System.Drawing.Size(80, 17)
        Me.labPhoneUser.TabIndex = 17
        Me.labPhoneUser.Text = "Téléphone:"
        '
        'labPhone2User
        '
        Me.labPhone2User.AutoSize = True
        Me.labPhone2User.Location = New System.Drawing.Point(617, 341)
        Me.labPhone2User.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPhone2User.Name = "labPhone2User"
        Me.labPhone2User.Size = New System.Drawing.Size(92, 17)
        Me.labPhone2User.TabIndex = 18
        Me.labPhone2User.Text = "Téléphone 2:"
        '
        'labJobUser
        '
        Me.labJobUser.AutoSize = True
        Me.labJobUser.Location = New System.Drawing.Point(237, 431)
        Me.labJobUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labJobUser.Name = "labJobUser"
        Me.labJobUser.Size = New System.Drawing.Size(35, 17)
        Me.labJobUser.TabIndex = 19
        Me.labJobUser.Text = "Job:"
        '
        'labPermissionsUser
        '
        Me.labPermissionsUser.AutoSize = True
        Me.labPermissionsUser.Location = New System.Drawing.Point(624, 431)
        Me.labPermissionsUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPermissionsUser.Name = "labPermissionsUser"
        Me.labPermissionsUser.Size = New System.Drawing.Size(88, 17)
        Me.labPermissionsUser.TabIndex = 20
        Me.labPermissionsUser.Text = "Permissions:"
        '
        'UCUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
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
        Me.Controls.Add(Me.btAddUser)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UCUserAdd"
        Me.Size = New System.Drawing.Size(1263, 744)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAddUser As Button
    Friend WithEvents btCancelUser As Button
    Friend WithEvents tbCode As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbPhone1 As TextBox
    Friend WithEvents tbPhone2 As TextBox
    Friend WithEvents tbJob As TextBox
    Friend WithEvents tbPermissions As TextBox
    Friend WithEvents labCodeUser As Label
    Friend WithEvents labFirstNameUser As Label
    Friend WithEvents labLastNameUser As Label
    Friend WithEvents labPasswordUser As Label
    Friend WithEvents labEmailUser As Label
    Friend WithEvents labPhoneUser As Label
    Friend WithEvents labPhone2User As Label
    Friend WithEvents labJobUser As Label
    Friend WithEvents labPermissionsUser As Label
End Class
