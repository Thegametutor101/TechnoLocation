Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module loadLang
    Function Load(type As String) As JObject
        Dim json As String
        Select Case type.ToLower()
            Case "fr_ca"
                json = File.ReadAllText("..\..\AppBundle\Language\FR_CA.json")
            Case "en_us"
                json = File.ReadAllText("..\..\AppBundle\Language\EN_US.json")
            Case Else
                json = File.ReadAllText("..\..\AppBundle\Language\FR_CA.json")
        End Select
        Return Newtonsoft.Json.Linq.JObject.Parse(json)
    End Function
    Public Class Lang

        Dim list As JObject

        Sub New(type As String)
            list = Load(type)
        End Sub

        Public ReadOnly Property ListProperty As JObject
            Get
                Return list
            End Get
        End Property

    End Class
End Module
