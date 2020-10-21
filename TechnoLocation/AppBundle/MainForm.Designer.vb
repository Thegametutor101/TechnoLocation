<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.p_Main = New System.Windows.Forms.Panel()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.btHome = New System.Windows.Forms.Button()
        Me.btAlert = New System.Windows.Forms.Button()
        Me.btBorrow = New System.Windows.Forms.Button()
        Me.btReturn = New System.Windows.Forms.Button()
        Me.btUser = New System.Windows.Forms.Button()
        Me.btCalendar = New System.Windows.Forms.Button()
        Me.btHistory = New System.Windows.Forms.Button()
        Me.btEquipment = New System.Windows.Forms.Button()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btDisconnection = New System.Windows.Forms.Button()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_Main
        '
        Me.p_Main.Location = New System.Drawing.Point(198, 1)
        Me.p_Main.Name = "p_Main"
        Me.p_Main.Size = New System.Drawing.Size(956, 647)
        Me.p_Main.TabIndex = 0
        '
        'pb_logo
        '
        Me.pb_logo.Location = New System.Drawing.Point(22, 12)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(150, 150)
        Me.pb_logo.TabIndex = 1
        Me.pb_logo.TabStop = False
        '
        'btHome
        '
        Me.btHome.Location = New System.Drawing.Point(12, 195)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(180, 36)
        Me.btHome.TabIndex = 2
        Me.btHome.Text = "Accueil"
        Me.btHome.UseVisualStyleBackColor = True
        '
        'btAlert
        '
        Me.btAlert.Location = New System.Drawing.Point(12, 237)
        Me.btAlert.Name = "btAlert"
        Me.btAlert.Size = New System.Drawing.Size(180, 36)
        Me.btAlert.TabIndex = 3
        Me.btAlert.Text = "Notifications"
        Me.btAlert.UseVisualStyleBackColor = True
        '
        'btBorrow
        '
        Me.btBorrow.Location = New System.Drawing.Point(12, 279)
        Me.btBorrow.Name = "btBorrow"
        Me.btBorrow.Size = New System.Drawing.Size(180, 36)
        Me.btBorrow.TabIndex = 4
        Me.btBorrow.Text = "Prêt"
        Me.btBorrow.UseVisualStyleBackColor = True
        '
        'btReturn
        '
        Me.btReturn.Location = New System.Drawing.Point(12, 321)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.Size = New System.Drawing.Size(180, 36)
        Me.btReturn.TabIndex = 5
        Me.btReturn.Text = "Retour"
        Me.btReturn.UseVisualStyleBackColor = True
        '
        'btUser
        '
        Me.btUser.Location = New System.Drawing.Point(12, 363)
        Me.btUser.Name = "btUser"
        Me.btUser.Size = New System.Drawing.Size(180, 36)
        Me.btUser.TabIndex = 6
        Me.btUser.Text = "Utilisateurs"
        Me.btUser.UseVisualStyleBackColor = True
        '
        'btCalendar
        '
        Me.btCalendar.Location = New System.Drawing.Point(12, 489)
        Me.btCalendar.Name = "btCalendar"
        Me.btCalendar.Size = New System.Drawing.Size(180, 36)
        Me.btCalendar.TabIndex = 9
        Me.btCalendar.Text = "Calendrier de Restrictions"
        Me.btCalendar.UseVisualStyleBackColor = True
        '
        'btHistory
        '
        Me.btHistory.Location = New System.Drawing.Point(12, 447)
        Me.btHistory.Name = "btHistory"
        Me.btHistory.Size = New System.Drawing.Size(180, 36)
        Me.btHistory.TabIndex = 8
        Me.btHistory.Text = "Historique"
        Me.btHistory.UseVisualStyleBackColor = True
        '
        'btEquipment
        '
        Me.btEquipment.Location = New System.Drawing.Point(12, 405)
        Me.btEquipment.Name = "btEquipment"
        Me.btEquipment.Size = New System.Drawing.Size(180, 36)
        Me.btEquipment.TabIndex = 7
        Me.btEquipment.Text = "Équipement"
        Me.btEquipment.UseVisualStyleBackColor = True
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(12, 601)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(180, 36)
        Me.btQuit.TabIndex = 10
        Me.btQuit.Text = "Quitter"
        Me.btQuit.UseVisualStyleBackColor = True
        '
        'btDisconnection
        '
        Me.btDisconnection.Location = New System.Drawing.Point(12, 559)
        Me.btDisconnection.Name = "btDisconnection"
        Me.btDisconnection.Size = New System.Drawing.Size(180, 36)
        Me.btDisconnection.TabIndex = 11
        Me.btDisconnection.Text = "Déconnexion"
        Me.btDisconnection.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 649)
        Me.Controls.Add(Me.btDisconnection)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btCalendar)
        Me.Controls.Add(Me.btHistory)
        Me.Controls.Add(Me.btEquipment)
        Me.Controls.Add(Me.btUser)
        Me.Controls.Add(Me.btReturn)
        Me.Controls.Add(Me.btBorrow)
        Me.Controls.Add(Me.btAlert)
        Me.Controls.Add(Me.btHome)
        Me.Controls.Add(Me.pb_logo)
        Me.Controls.Add(Me.p_Main)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p_Main As Panel
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents btHome As Button
    Friend WithEvents btAlert As Button
    Friend WithEvents btBorrow As Button
    Friend WithEvents btReturn As Button
    Friend WithEvents btUser As Button
    Friend WithEvents btCalendar As Button
    Friend WithEvents btHistory As Button
    Friend WithEvents btEquipment As Button
    Friend WithEvents btQuit As Button
    Friend WithEvents btDisconnection As Button
End Class
