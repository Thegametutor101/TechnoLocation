Public Class UCProfil
    Dim code As Integer
    Private Sub UCProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entityUser As EntityUser = EntityUser.getInstance()

        tbCode.Text = code
        tbName.Text = entityUser.getUsersCode(code).Rows(0).Item("firstName") + " " + entityUser.getUsersCode(code).Rows(0).Item("lastName")
        tbEmail.Text = entityUser.getUsersCode(code).Rows(0).Item("email")
        tbPhone.Text = entityUser.getUsersCode(code).Rows(0).Item("phoneMain")
        tbPhone2.Text = entityUser.getUsersCode(code).Rows(0).Item("phone2")
        tbJob.Text = entityUser.getUsersCode(code).Rows(0).Item("job")
    End Sub

    Public Sub New(id As Integer)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        code = id
    End Sub
End Class
