﻿Public Class UCProfile


    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________

    Dim WithEvents mainForm As MainForm

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________

    Public Sub New(main As MainForm)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataRow = EntityUser.getInstance().getUsersCode(mainForm.code).Rows(0)
        tbCode.Text = mainForm.code
        tbName.Text = data.Item("firstName") + " " + data.Item("lastName")
        tbEmail.Text = data.Item("email")
        tbPhone.Text = data.Item("phoneMain")
        tbPhone2.Text = data.Item("phone2")
        tbJob.Text = data.Item("job")
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Buttons
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Other
    '__________________________________________________________________________________________________________



End Class
