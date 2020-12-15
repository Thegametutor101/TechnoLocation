Public Class UCNotif

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim WithEvents mainForm As New MainForm(0)

    Dim liste As New List(Of String)
    Dim listeInfos As New List(Of DataRow)

    Dim table As DataTable


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
        table = EntityRent.getInstance().getRentalsForNotif()
    End Sub


    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub UCNotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each row As DataRow In table.Rows
            If Convert.ToDateTime(row.Item(5).ToString).DayOfYear = Today.DayOfYear Then
                liste.Add(row.Item(1).ToString)
                listeInfos.Add(row)
            End If
        Next
        cbNotifs.DataSource = liste
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________


    Private Sub cbNotifs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNotifs.SelectedIndexChanged
        tbEquipNum.Text = listeInfos(cbNotifs.SelectedIndex)(3)
        tbRentDate.Text = listeInfos(cbNotifs.SelectedIndex)(4)
        tbDepositAmount.Text = listeInfos(cbNotifs.SelectedIndex)(6)
    End Sub


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
