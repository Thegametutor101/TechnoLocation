Public Class FR_CA
    Dim MsgQuit = "Voulez-vous vraiment quitter le programme?"
    Dim MsgQuitTitle = "Quitter"
    Dim MsgDisconnection = "Voulez-vous vraiment vous déconnecter?"
    Dim MsgDisconnecTitle = "Déconnexion"
    Dim MsgWarning = "Attention!"
    Dim MsgEmptyName = "Vous devez mettre un nom!"
    Dim MsgEmptyComment = "Vous devez mettre des commentaires!"
    Dim MsgEmptyState = "Vous devez mettre un état à l'équipement!"

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
End Class
