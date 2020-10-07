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
        Me.bt_home = New System.Windows.Forms.Button()
        Me.bt_alert = New System.Windows.Forms.Button()
        Me.bt_borrow = New System.Windows.Forms.Button()
        Me.bt_return = New System.Windows.Forms.Button()
        Me.bt_user = New System.Windows.Forms.Button()
        Me.bt_calendar = New System.Windows.Forms.Button()
        Me.bt_history = New System.Windows.Forms.Button()
        Me.bt_equipment = New System.Windows.Forms.Button()
        Me.bt_quit = New System.Windows.Forms.Button()
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
        'bt_home
        '
        Me.bt_home.Location = New System.Drawing.Point(12, 195)
        Me.bt_home.Name = "bt_home"
        Me.bt_home.Size = New System.Drawing.Size(180, 36)
        Me.bt_home.TabIndex = 2
        Me.bt_home.Text = "Accueil"
        Me.bt_home.UseVisualStyleBackColor = True
        '
        'bt_alert
        '
        Me.bt_alert.Location = New System.Drawing.Point(12, 237)
        Me.bt_alert.Name = "bt_alert"
        Me.bt_alert.Size = New System.Drawing.Size(180, 36)
        Me.bt_alert.TabIndex = 3
        Me.bt_alert.Text = "Notifications"
        Me.bt_alert.UseVisualStyleBackColor = True
        '
        'bt_borrow
        '
        Me.bt_borrow.Location = New System.Drawing.Point(12, 279)
        Me.bt_borrow.Name = "bt_borrow"
        Me.bt_borrow.Size = New System.Drawing.Size(180, 36)
        Me.bt_borrow.TabIndex = 4
        Me.bt_borrow.Text = "Prêt"
        Me.bt_borrow.UseVisualStyleBackColor = True
        '
        'bt_return
        '
        Me.bt_return.Location = New System.Drawing.Point(12, 321)
        Me.bt_return.Name = "bt_return"
        Me.bt_return.Size = New System.Drawing.Size(180, 36)
        Me.bt_return.TabIndex = 5
        Me.bt_return.Text = "Retour"
        Me.bt_return.UseVisualStyleBackColor = True
        '
        'bt_user
        '
        Me.bt_user.Location = New System.Drawing.Point(12, 363)
        Me.bt_user.Name = "bt_user"
        Me.bt_user.Size = New System.Drawing.Size(180, 36)
        Me.bt_user.TabIndex = 6
        Me.bt_user.Text = "Utilisateurs"
        Me.bt_user.UseVisualStyleBackColor = True
        '
        'bt_calendar
        '
        Me.bt_calendar.Location = New System.Drawing.Point(12, 489)
        Me.bt_calendar.Name = "bt_calendar"
        Me.bt_calendar.Size = New System.Drawing.Size(180, 36)
        Me.bt_calendar.TabIndex = 9
        Me.bt_calendar.Text = "Calendrier de Restrictions"
        Me.bt_calendar.UseVisualStyleBackColor = True
        '
        'bt_history
        '
        Me.bt_history.Location = New System.Drawing.Point(12, 447)
        Me.bt_history.Name = "bt_history"
        Me.bt_history.Size = New System.Drawing.Size(180, 36)
        Me.bt_history.TabIndex = 8
        Me.bt_history.Text = "History"
        Me.bt_history.UseVisualStyleBackColor = True
        '
        'bt_equipment
        '
        Me.bt_equipment.Location = New System.Drawing.Point(12, 405)
        Me.bt_equipment.Name = "bt_equipment"
        Me.bt_equipment.Size = New System.Drawing.Size(180, 36)
        Me.bt_equipment.TabIndex = 7
        Me.bt_equipment.Text = "Équipement"
        Me.bt_equipment.UseVisualStyleBackColor = True
        '
        'bt_quit
        '
        Me.bt_quit.Location = New System.Drawing.Point(12, 590)
        Me.bt_quit.Name = "bt_quit"
        Me.bt_quit.Size = New System.Drawing.Size(180, 36)
        Me.bt_quit.TabIndex = 10
        Me.bt_quit.Text = "Quitter"
        Me.bt_quit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 649)
        Me.Controls.Add(Me.bt_quit)
        Me.Controls.Add(Me.bt_calendar)
        Me.Controls.Add(Me.bt_history)
        Me.Controls.Add(Me.bt_equipment)
        Me.Controls.Add(Me.bt_user)
        Me.Controls.Add(Me.bt_return)
        Me.Controls.Add(Me.bt_borrow)
        Me.Controls.Add(Me.bt_alert)
        Me.Controls.Add(Me.bt_home)
        Me.Controls.Add(Me.pb_logo)
        Me.Controls.Add(Me.p_Main)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p_Main As Panel
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents bt_home As Button
    Friend WithEvents bt_alert As Button
    Friend WithEvents bt_borrow As Button
    Friend WithEvents bt_return As Button
    Friend WithEvents bt_user As Button
    Friend WithEvents bt_calendar As Button
    Friend WithEvents bt_history As Button
    Friend WithEvents bt_equipment As Button
    Friend WithEvents bt_quit As Button
End Class
