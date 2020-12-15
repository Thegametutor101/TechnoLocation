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
        Me.labTitre = New System.Windows.Forms.Label()
        Me.btSaveModifications = New System.Windows.Forms.Button()
        Me.btDeleteAccount = New System.Windows.Forms.Button()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.labPassword = New System.Windows.Forms.Label()
        Me.checkPassword = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.labSetPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labExt2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkExt2 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.numExtension2 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.labExt1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkExt1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.numExtension1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.dropStatus = New System.Windows.Forms.ComboBox()
        Me.dropPermissions = New System.Windows.Forms.ComboBox()
        Me.labStatus = New System.Windows.Forms.Label()
        Me.labPermissions = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        CType(Me.numExtension2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExtension1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labCode
        '
        Me.labCode.AutoSize = True
        Me.labCode.Location = New System.Drawing.Point(345, 60)
        Me.labCode.Name = "labCode"
        Me.labCode.Size = New System.Drawing.Size(35, 13)
        Me.labCode.TabIndex = 0
        Me.labCode.Text = "Code:"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(386, 103)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(173, 20)
        Me.tbFirstName.TabIndex = 3
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.Location = New System.Drawing.Point(334, 106)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(46, 13)
        Me.labName.TabIndex = 2
        Me.labName.Text = "Prénom:"
        '
        'tbPhone1
        '
        Me.tbPhone1.Location = New System.Drawing.Point(386, 194)
        Me.tbPhone1.Name = "tbPhone1"
        Me.tbPhone1.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone1.TabIndex = 7
        '
        'labTelephone
        '
        Me.labTelephone.AutoSize = True
        Me.labTelephone.Location = New System.Drawing.Point(319, 197)
        Me.labTelephone.Name = "labTelephone"
        Me.labTelephone.Size = New System.Drawing.Size(61, 13)
        Me.labTelephone.TabIndex = 6
        Me.labTelephone.Text = "Téléphone:"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(386, 168)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(173, 20)
        Me.tbEmail.TabIndex = 5
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(345, 171)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(35, 13)
        Me.labEmail.TabIndex = 4
        Me.labEmail.Text = "Email:"
        '
        'tbPhone2
        '
        Me.tbPhone2.Location = New System.Drawing.Point(386, 240)
        Me.tbPhone2.Name = "tbPhone2"
        Me.tbPhone2.Size = New System.Drawing.Size(173, 20)
        Me.tbPhone2.TabIndex = 9
        '
        'labTelephone2
        '
        Me.labTelephone2.AutoSize = True
        Me.labTelephone2.Location = New System.Drawing.Point(310, 243)
        Me.labTelephone2.Name = "labTelephone2"
        Me.labTelephone2.Size = New System.Drawing.Size(70, 13)
        Me.labTelephone2.TabIndex = 8
        Me.labTelephone2.Text = "Téléphone 2:"
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
        'btSaveModifications
        '
        Me.btSaveModifications.Location = New System.Drawing.Point(402, 473)
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
        Me.tbLastName.Location = New System.Drawing.Point(386, 136)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(173, 20)
        Me.tbLastName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nom:"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(386, 437)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(173, 20)
        Me.tbPassword.TabIndex = 18
        Me.tbPassword.Visible = False
        '
        'labPassword
        '
        Me.labPassword.AutoSize = True
        Me.labPassword.Location = New System.Drawing.Point(306, 440)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(74, 13)
        Me.labPassword.TabIndex = 17
        Me.labPassword.Text = "Mot de passe:"
        Me.labPassword.Visible = False
        '
        'checkPassword
        '
        Me.checkPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkPassword.CheckedState.BorderRadius = 2
        Me.checkPassword.CheckedState.BorderThickness = 2
        Me.checkPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkPassword.CheckedState.Parent = Me.checkPassword
        Me.checkPassword.Location = New System.Drawing.Point(365, 409)
        Me.checkPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.checkPassword.Name = "checkPassword"
        Me.checkPassword.ShadowDecoration.Parent = Me.checkPassword
        Me.checkPassword.Size = New System.Drawing.Size(15, 16)
        Me.checkPassword.TabIndex = 40
        Me.checkPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkPassword.UncheckedState.BorderRadius = 2
        Me.checkPassword.UncheckedState.BorderThickness = 2
        Me.checkPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkPassword.UncheckedState.Parent = Me.checkPassword
        '
        'labSetPassword
        '
        Me.labSetPassword.BackColor = System.Drawing.Color.Transparent
        Me.labSetPassword.Location = New System.Drawing.Point(386, 409)
        Me.labSetPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.labSetPassword.Name = "labSetPassword"
        Me.labSetPassword.Size = New System.Drawing.Size(134, 15)
        Me.labSetPassword.TabIndex = 68
        Me.labSetPassword.Text = "Enregistrer un mot de passe"
        '
        'labExt2
        '
        Me.labExt2.BackColor = System.Drawing.Color.Transparent
        Me.labExt2.Location = New System.Drawing.Point(584, 225)
        Me.labExt2.Margin = New System.Windows.Forms.Padding(2)
        Me.labExt2.Name = "labExt2"
        Me.labExt2.Size = New System.Drawing.Size(111, 15)
        Me.labExt2.TabIndex = 80
        Me.labExt2.Text = "Cochez pour extension"
        '
        'checkExt2
        '
        Me.checkExt2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt2.CheckedState.BorderRadius = 2
        Me.checkExt2.CheckedState.BorderThickness = 2
        Me.checkExt2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt2.CheckedState.Parent = Me.checkExt2
        Me.checkExt2.Location = New System.Drawing.Point(564, 224)
        Me.checkExt2.Margin = New System.Windows.Forms.Padding(2)
        Me.checkExt2.Name = "checkExt2"
        Me.checkExt2.ShadowDecoration.Parent = Me.checkExt2
        Me.checkExt2.Size = New System.Drawing.Size(15, 16)
        Me.checkExt2.TabIndex = 79
        Me.checkExt2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkExt2.UncheckedState.BorderRadius = 2
        Me.checkExt2.UncheckedState.BorderThickness = 2
        Me.checkExt2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkExt2.UncheckedState.Parent = Me.checkExt2
        '
        'numExtension2
        '
        Me.numExtension2.BackColor = System.Drawing.Color.Transparent
        Me.numExtension2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numExtension2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numExtension2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numExtension2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numExtension2.DisabledState.Parent = Me.numExtension2
        Me.numExtension2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numExtension2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numExtension2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numExtension2.FocusedState.Parent = Me.numExtension2
        Me.numExtension2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numExtension2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numExtension2.Location = New System.Drawing.Point(562, 244)
        Me.numExtension2.Margin = New System.Windows.Forms.Padding(2)
        Me.numExtension2.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numExtension2.Name = "numExtension2"
        Me.numExtension2.ShadowDecoration.Parent = Me.numExtension2
        Me.numExtension2.Size = New System.Drawing.Size(110, 29)
        Me.numExtension2.TabIndex = 78
        '
        'labExt1
        '
        Me.labExt1.BackColor = System.Drawing.Color.Transparent
        Me.labExt1.Location = New System.Drawing.Point(586, 171)
        Me.labExt1.Margin = New System.Windows.Forms.Padding(2)
        Me.labExt1.Name = "labExt1"
        Me.labExt1.Size = New System.Drawing.Size(111, 15)
        Me.labExt1.TabIndex = 83
        Me.labExt1.Text = "Cochez pour extension"
        '
        'checkExt1
        '
        Me.checkExt1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt1.CheckedState.BorderRadius = 2
        Me.checkExt1.CheckedState.BorderThickness = 2
        Me.checkExt1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkExt1.CheckedState.Parent = Me.checkExt1
        Me.checkExt1.Location = New System.Drawing.Point(566, 170)
        Me.checkExt1.Margin = New System.Windows.Forms.Padding(2)
        Me.checkExt1.Name = "checkExt1"
        Me.checkExt1.ShadowDecoration.Parent = Me.checkExt1
        Me.checkExt1.Size = New System.Drawing.Size(15, 16)
        Me.checkExt1.TabIndex = 82
        Me.checkExt1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkExt1.UncheckedState.BorderRadius = 2
        Me.checkExt1.UncheckedState.BorderThickness = 2
        Me.checkExt1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.checkExt1.UncheckedState.Parent = Me.checkExt1
        '
        'numExtension1
        '
        Me.numExtension1.BackColor = System.Drawing.Color.Transparent
        Me.numExtension1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numExtension1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numExtension1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numExtension1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numExtension1.DisabledState.Parent = Me.numExtension1
        Me.numExtension1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numExtension1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numExtension1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numExtension1.FocusedState.Parent = Me.numExtension1
        Me.numExtension1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numExtension1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numExtension1.Location = New System.Drawing.Point(564, 190)
        Me.numExtension1.Margin = New System.Windows.Forms.Padding(2)
        Me.numExtension1.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numExtension1.Name = "numExtension1"
        Me.numExtension1.ShadowDecoration.Parent = Me.numExtension1
        Me.numExtension1.Size = New System.Drawing.Size(110, 29)
        Me.numExtension1.TabIndex = 81
        '
        'dropStatus
        '
        Me.dropStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropStatus.FormattingEnabled = True
        Me.dropStatus.Items.AddRange(New Object() {"0 - Étudiant", "1 - Professeur", "2 - Employé"})
        Me.dropStatus.Location = New System.Drawing.Point(386, 331)
        Me.dropStatus.Name = "dropStatus"
        Me.dropStatus.Size = New System.Drawing.Size(173, 21)
        Me.dropStatus.TabIndex = 85
        '
        'dropPermissions
        '
        Me.dropPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropPermissions.FormattingEnabled = True
        Me.dropPermissions.Items.AddRange(New Object() {"0 - Utilisateur de base", "1 - Utilisateur pouvant prêter", "2 - Professeur", "3 - Admin"})
        Me.dropPermissions.Location = New System.Drawing.Point(386, 374)
        Me.dropPermissions.Name = "dropPermissions"
        Me.dropPermissions.Size = New System.Drawing.Size(173, 21)
        Me.dropPermissions.TabIndex = 86
        '
        'labStatus
        '
        Me.labStatus.AutoSize = True
        Me.labStatus.Location = New System.Drawing.Point(345, 334)
        Me.labStatus.Name = "labStatus"
        Me.labStatus.Size = New System.Drawing.Size(40, 13)
        Me.labStatus.TabIndex = 87
        Me.labStatus.Text = "Status:"
        '
        'labPermissions
        '
        Me.labPermissions.AutoSize = True
        Me.labPermissions.Location = New System.Drawing.Point(320, 377)
        Me.labPermissions.Name = "labPermissions"
        Me.labPermissions.Size = New System.Drawing.Size(65, 13)
        Me.labPermissions.TabIndex = 88
        Me.labPermissions.Text = "Permissions:"
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(386, 57)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.ReadOnly = True
        Me.tbCode.Size = New System.Drawing.Size(173, 20)
        Me.tbCode.TabIndex = 89
        '
        'UCProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.labPermissions)
        Me.Controls.Add(Me.labStatus)
        Me.Controls.Add(Me.dropPermissions)
        Me.Controls.Add(Me.dropStatus)
        Me.Controls.Add(Me.labExt1)
        Me.Controls.Add(Me.checkExt1)
        Me.Controls.Add(Me.numExtension1)
        Me.Controls.Add(Me.labExt2)
        Me.Controls.Add(Me.checkExt2)
        Me.Controls.Add(Me.numExtension2)
        Me.Controls.Add(Me.labSetPassword)
        Me.Controls.Add(Me.checkPassword)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.labPassword)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btDeleteAccount)
        Me.Controls.Add(Me.btSaveModifications)
        Me.Controls.Add(Me.labTitre)
        Me.Controls.Add(Me.tbPhone2)
        Me.Controls.Add(Me.labTelephone2)
        Me.Controls.Add(Me.tbPhone1)
        Me.Controls.Add(Me.labTelephone)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.labName)
        Me.Controls.Add(Me.labCode)
        Me.Name = "UCProfile"
        Me.Size = New System.Drawing.Size(947, 604)
        CType(Me.numExtension2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExtension1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents labTitre As Label
    Friend WithEvents btSaveModifications As Button
    Friend WithEvents btDeleteAccount As Button
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents labPassword As Label
    Friend WithEvents checkPassword As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents labSetPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents labExt2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkExt2 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents numExtension2 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents labExt1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkExt1 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents numExtension1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents dropStatus As ComboBox
    Friend WithEvents dropPermissions As ComboBox
    Friend WithEvents labStatus As Label
    Friend WithEvents labPermissions As Label
    Friend WithEvents tbCode As TextBox
End Class
