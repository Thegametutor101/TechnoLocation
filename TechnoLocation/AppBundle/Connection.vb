Imports System.Text.RegularExpressions

Public Class Connection

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim Msg As FR_CA = New FR_CA

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        testConnection()
        'testConnection()
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________

    Public Function testConnection()
        If Not EntityUser.getInstance().testConnection() Then
            MessageBox.Show($"Impossible de trouver la base de donnée associée à: {Environment.NewLine}{Environment.NewLine}{MainForm.getInstance().connectionString}")
            Me.Close()
        End If
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________

    Private Sub btQuitConnection_Click(sender As Object, e As EventArgs) Handles btQuitConnection.Click
        If MessageBox.Show("Voulez-vous quitter le programme ?",
                           "Attention",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btConnection_Click(sender As Object, e As EventArgs) Handles btConnection.Click

    End Sub

    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________


End Class