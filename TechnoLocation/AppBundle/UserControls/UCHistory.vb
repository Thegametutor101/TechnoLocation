﻿Public Class UCHistory

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim codesBarres As New BarCodes


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________

    Private Sub UCHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    Private Sub checkAll_CheckedChanged(sender As Object, e As EventArgs) Handles checkAll.CheckedChanged

    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

    End Sub
    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        If e.KeyCode = Keys.V Then
            If tbSearch.Text.Length = 8 Then
                tbSearch.Text = codesBarres.isBarcodeEquip(tbSearch.Text)
            Else
                tbSearch.Text = codesBarres.isBarcodeUser(tbSearch.Text)
            End If
        End If
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