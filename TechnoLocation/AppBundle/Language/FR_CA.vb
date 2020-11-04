Public Class FR_CA
    Dim MsgQuit = "Voulez-vous vraiment quitter le programme?"
    Dim MsgQuitTitle = "Quitter"
    Dim MsgDisconnection = "Voulez-vous vraiment vous déconnecter?"
    Dim MsgDisconnecTitle = "Déconnexion"
    Dim MsgWarning = "Attention!"
    Dim MsgEmptyName = "Vous devez mettre un nom!"
    Dim MsgEmptyComment = "Vous devez mettre des commentaires!"
    Dim MsgEmptyState = "Vous devez mettre un état à l'équipement!"
    Dim MsgSuccessAddEquip = "L'ajout a bien été effectuer!"
    Dim MsgSuccessAddTitle = "Ajout effectuer"
    Dim MsgKitNull = "Voulez-vous vraiment ajouter l'équipement sans kit?"
    Dim MsgKitNameEmpty = "Vous devez mettre un nom!"
    Dim MsgErrorAddEquip = "Un erreure c'est produit durant l'ajout d'équipement! Certain équipement ne se sont pas ajouter correctement"
    Dim MsgDeleteEquipment = "Voulez-vous vraiment supprimer ces équipements? Cette action est définitive et ne peut pas être annuler après."
    Dim MsgEditEquipment = "Vouslez-vous vraiment modifier cette Équipement?"
    Dim MsgSuccessEditEquip = "L'équipement à belle et bien été modifier avec succès"

    Public ReadOnly Property getMsgQuit() As String
        Get
            Return MsgQuit
        End Get
    End Property

    Public ReadOnly Property getMsgQuitTitle() As String
        Get
            Return MsgQuitTitle
        End Get
    End Property

    Public ReadOnly Property getMsgDisconnection() As String
        Get
            Return MsgDisconnection
        End Get
    End Property

    Public ReadOnly Property getMsgDisconnecTitle() As String
        Get
            Return MsgDisconnecTitle
        End Get
    End Property

    Public ReadOnly Property getMsgWarning() As String
        Get
            Return MsgWarning
        End Get
    End Property

    Public ReadOnly Property getMsgEmptyName() As String
        Get
            Return MsgEmptyName
        End Get
    End Property

    Public ReadOnly Property getMsgEmptyComment() As String
        Get
            Return MsgEmptyComment
        End Get
    End Property

    Public ReadOnly Property getMsgEmptyState() As String
        Get
            Return MsgEmptyState
        End Get
    End Property

    Public ReadOnly Property getMsgSuccessAddEquip() As String
        Get
            Return MsgSuccessAddEquip
        End Get
    End Property
    Public ReadOnly Property getMsgSuccessAddTitle() As String
        Get
            Return MsgSuccessAddTitle
        End Get
    End Property
    Public ReadOnly Property getMsgKitNull() As String
        Get
            Return MsgKitNull
        End Get
    End Property

    Public ReadOnly Property getMsgKitNameEmpty() As String
        Get
            Return MSgKitNameEmpty
        End Get
    End Property
    Public ReadOnly Property getMsgErrorAddEEquip() As String
        Get
            Return MsgErrorAddEquip
        End Get
    End Property
    Public ReadOnly Property getMsgDeleteEquipment() As String
        Get
            Return MsgDeleteEquipment
        End Get
    End Property

    Public ReadOnly Property getMsgEditEquipment() As String
        Get
            Return MsgEditEquipment
        End Get
    End Property

    Public ReadOnly Property getMsgSuccessEditEquip() As String
        Get
            Return MsgSuccessEditEquip
        End Get
    End Property
End Class
