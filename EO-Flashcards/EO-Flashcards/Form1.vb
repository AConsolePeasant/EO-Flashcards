﻿' Esperanto Flash Cards
' Author - AConsolePeasant
' Last modified - Check on the git page, I shouldn't have to update this for you.
' https://github.com/AConsolePeasant/EO-Flashcards


'Can't rename this form, or it will break on me
Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMenu.Show() 'Open main menu
        Me.Close() 'Close myself
    End Sub
End Class