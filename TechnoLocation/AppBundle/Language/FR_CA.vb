Public Class FR_CA
    Dim MsgQuit = "Voulez-vous vraiment quitter le programme?"
    Dim MsgQuitTitle = "Quitter"

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
End Class
