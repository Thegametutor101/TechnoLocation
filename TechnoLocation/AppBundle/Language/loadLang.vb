Imports System.IO
Imports System.Runtime.InteropServices.WindowsRuntime
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
        Shared instance As Lang = Nothing

        Public Shared Function getInstance() As Lang
            If IsNothing(instance) Then
                instance = New Lang()
            End If
            Return instance
        End Function

        Public Function getLang() As JObject
            Return list
        End Function

        Public Sub setLang(type As String)
            list = Load(type)
        End Sub
    End Class
End Module
