Public Class FR_CA
    Dim MsgQuit = "Voulez-vous vraiment quitter le programme?"
    Dim MsgQuitTitle = "Quitter"
    Dim MsgDisconnection = "Voulez-vous vraiment vous déconnecter?"
    Dim MsgDisconnecTitle = "Déconnexion"

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
End Class
