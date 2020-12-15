Imports ZXing
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class BarCodes

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim barCode As Image
    Dim imagePrint As Image

    Dim WithEvents printDoc As New Printing.PrintDocument()
    Dim path As String = ""
    Dim type As String = ".jpeg"

    Private Const scaleh = 100
    Private Const scalew = 140
    Private Const offset = 10
    Private Const scalehO = scaleh + offset
    Private Const scalewO = scalew + offset

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    '--genere un code barre en tant que image et le stocke dans la variable globale barCode
    Public Sub generateBC(input As String)
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_39
        If Not input = Nothing Then
            barCode = writer.Write(input)
            barCode = ResizeImage(barCode)
        Else
            MessageBox.Show("L'entrée pour le code barre n'est pas valide")
        End If
    End Sub

    '--imprime un code barre en utilisant la variable globale barCode
    Public Sub PrintBC()
        imagePrint = barCode
        Dim preview As New PrintPreviewDialog()
        printDoc.Print()
        preview.Document = printDoc
        preview.ShowDialog()
    End Sub

    '--genere un code barre et l'imprime avec les methodes plus haut
    Public Sub generatePrintBC(input As String)
        generateBC(input)
        PrintBC()
    End Sub

    '--imprime une image a partir de son numero ou nom dans le dossier des codesBarres
    Public Sub PrintBCFromFile(input As String)
        pathOk()

        Try
            imagePrint = Image.FromFile(path + input + type)

            Dim preview As New PrintPreviewDialog()
            printDoc.Print()
            preview.Document = printDoc
            preview.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(input + " image introuvable")
        End Try
    End Sub

    '--utilise la variable globale imagePrint pour imprimer l'image (utilisé par les autres methodes d'impression)

    Private Sub PrintImage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        e.Graphics.DrawImage(imagePrint, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    '--genere et sauvegarde un code barre en tand que .jpeg
    Public Sub generateSaveBC(input As String)

        pathOk()

        generateBC(input)
        barCode.Save(path + input + type, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub


    '--supprime tous les codes barres du dossier barCodeFolder
    Public Sub deleteAllBC()
        pathOk()
        Dim pathFolder, s As String

        s = path
        pathFolder = ""

        Dim words As String() = s.Split("\")

        For word As Integer = 1 To words.Length - 2
            If (words(word) IsNot "") Then
                pathFolder += "\" + words(word)
            End If
        Next

        For Each deleteFile In Directory.GetFiles(pathFolder, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next
    End Sub


    '--crée une image qui fusionne tout les codes barres indiqués dans la liste
    '--et la sauvegarde dans le dossier des codes barresavec le nom merge
    Public Sub mergeImages(liste As List(Of String))
        pathOk()

        Dim nbrErr As Integer
        Dim image, petiteI, imageCrop As Image
        Dim g, gC As Graphics
        Dim width, height, hPoint, wPoint As Integer

        nbrErr = 0

        If (liste.Count > 0) Then

            If (liste.Count > 4) Then
                width = 4 * scalewO
            Else
                width = liste.Count * scalewO
            End If
            height = Math.Ceiling(liste.Count / 4) * scalehO
            image = New Bitmap(width, height)

            g = Graphics.FromImage(image)

            For ctr As Integer = 0 To liste.Count - 1
                Try
                    petiteI = Image.FromFile(path + liste(ctr) + type)

                    hPoint = scalehO * Math.Floor((ctr - nbrErr) / 4)
                    wPoint = scalewO * Math.Floor((ctr - nbrErr) Mod 4)

                    g.DrawImage(petiteI, New Point(wPoint, hPoint))
                Catch ex As Exception
                    nbrErr += 1
                    MessageBox.Show(liste(ctr) + " ne fait pas partie des codes barre enregistres")
                End Try
            Next

            If ((liste.Count - nbrErr) > 4) Then
                width = 4 * scalewO
            Else
                width = (liste.Count - nbrErr) * scalewO
            End If
            height = Math.Ceiling((liste.Count - nbrErr) / 4) * scalehO
            imageCrop = New Bitmap(width, height)
            gC = Graphics.FromImage(imageCrop)

            gC.DrawImage(image, New Point(0, 0))
            imageCrop.Save(path + "merge" + type, ImageFormat.Jpeg)
            barCode = imageCrop

        Else
            MessageBox.Show("desoler mais la liste de codes barre fournie est vide")
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'General Functions
    '__________________________________________________________________________________________________________


    '--Lecture--
    Public Function getBarCode()
        Return barCode
    End Function

    '--recherche dans le dossier pour un code barre et le creer si ne le trouve pas
    Public Function getBarCodeFromFile(input As String) As Image
        pathOk()

        Dim result As Image
        Try
            result = Image.FromFile(path + input + type)
        Catch ex As Exception
            MessageBox.Show("code barre introuvable creation d'un nouveau")
            result = genGetBarCode(input)
        End Try
        Return result
    End Function

    '--genere et renvoie un code barre en tant qu'image
    Public Function genGetBarCode(input As String)
        generateBC(input)
        Return barCode
    End Function


    '--trouve le path du dossier barCodeFolder ert le met dans la variable globale path
    Public Function makePath()
        Dim s As String = path

        s = System.IO.Directory.GetCurrentDirectory

        Dim words As String() = s.Split("\")

        path = words(0)

        For word As Integer = 1 To words.Length - 3
            If (words(word) IsNot "") Then
                path += "\" + words(word)
            End If
        Next
        path += "\Resources\barCodeFolder\barcode"
        Return path
    End Function


    '--va chercher un .jpeg a partir dun numero ou nom de code barre
    Public Function getImageBarCodeFromFile(input As String) As Image
        pathOk()

        Dim result As Image
        result = Image.FromFile(path + input + type)
        Return result
    End Function


    '--resize une image pour la taille de 1 code barre
    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(scalew, scaleh))
    End Function


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    '--verifie si le path est vide et le remplie si c'est le cas
    Public Sub pathOk()
        If (path = "") Then
            makePath()
        End If
    End Sub

    'recoit un string et determine si c'est un nombre ou un texte et renvoie le texte
    'si c'est un nombre, enleve le dernier chiffre
    Public Function isBarcodeUser(texte As String)
        If texte = "Demo - please subscribe to full version" Then
            texte = ""
            MessageBox.Show("Veuillez scanner le code de nouveau")
            Return texte
        End If
        Try
            Dim number As Integer
            number = Integer.Parse(texte)
            If number >= 10000000 Then
                number = Math.Floor(number / 10)
            End If
            texte = number.ToString
        Catch ex As Exception

        End Try

        Return texte
    End Function

    'recoit un string et determine si c'est un nombre ou un texte et renvoie le texte
    Public Function isBarcodeEquip(texte As String)
        If texte = "Demo - please subscribe to full version" Then
            texte = ""
            MessageBox.Show("Veuillez scanner le code de nouveau")
            Return texte
        End If
        Try
            Dim number As Integer
            number = Integer.Parse(texte)
            texte = number.ToString
        Catch ex As Exception

        End Try

        Return texte
    End Function

End Class