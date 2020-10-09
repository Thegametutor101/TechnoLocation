<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Connection
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labUserName = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.labPassword = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btConnection = New System.Windows.Forms.Button()
        Me.btQuitConnection = New System.Windows.Forms.Button()
        Me.linklabPasswordForget = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'labUserName
        '
        Me.labUserName.AutoSize = True
        Me.labUserName.Location = New System.Drawing.Point(56, 59)
        Me.labUserName.Name = "labUserName"
        Me.labUserName.Size = New System.Drawing.Size(53, 13)
        Me.labUserName.TabIndex = 0
        Me.labUserName.Text = "Identifiant"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(135, 56)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(117, 20)
        Me.tbUsername.TabIndex = 1
        '
        'labPassword
        '
        Me.labPassword.AutoSize = True
        Me.labPassword.Location = New System.Drawing.Point(56, 95)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(71, 13)
        Me.labPassword.TabIndex = 2
        Me.labPassword.Text = "Mot de passe"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(135, 92)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(117, 20)
        Me.tbPassword.TabIndex = 3
        '
        'btConnection
        '
        Me.btConnection.Location = New System.Drawing.Point(59, 157)
        Me.btConnection.Name = "btConnection"
        Me.btConnection.Size = New System.Drawing.Size(94, 23)
        Me.btConnection.TabIndex = 4
        Me.btConnection.Text = "Connecter"
        Me.btConnection.UseVisualStyleBackColor = True
        '
        'btQuitConnection
        '
        Me.btQuitConnection.Location = New System.Drawing.Point(159, 157)
        Me.btQuitConnection.Name = "btQuitConnection"
        Me.btQuitConnection.Size = New System.Drawing.Size(93, 23)
        Me.btQuitConnection.TabIndex = 5
        Me.btQuitConnection.Text = "Quitter"
        Me.btQuitConnection.UseVisualStyleBackColor = True
        '
        'linklabPasswordForget
        '
        Me.linklabPasswordForget.AutoSize = True
        Me.linklabPasswordForget.Location = New System.Drawing.Point(56, 128)
        Me.linklabPasswordForget.Name = "linklabPasswordForget"
        Me.linklabPasswordForget.Size = New System.Drawing.Size(111, 13)
        Me.linklabPasswordForget.TabIndex = 7
        Me.linklabPasswordForget.TabStop = True
        Me.linklabPasswordForget.Text = "Mot de passe oublier?"
        '
        'Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 219)
        Me.Controls.Add(Me.linklabPasswordForget)
        Me.Controls.Add(Me.btQuitConnection)
        Me.Controls.Add(Me.btConnection)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.labPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.labUserName)
        Me.Name = "Connection"
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labUserName As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents labPassword As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btConnection As Button
    Friend WithEvents btQuitConnection As Button
    Friend WithEvents linklabPasswordForget As LinkLabel
End Class
