﻿Public Class frmTitleScreen

    Public intDiff As Integer

    Private Sub frmTitleScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With Me.btnStart    'Sets the settings for btnStart when the form loads.  Will make btnStart appear above btnExit
            .Top = 400      'Top of button is 400 pixles from top of form
            .Left = 70      'Left side of button is 70 pixles from lef of form
        End With

        Me.grpDifficulty.Visible = False   'Hides the object grpDifficulty 

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Me.btnStart.Top = 250               'moves btnStart up in order to expose the object grpDifficulty
        Me.grpDifficulty.Visible = True     'Shows object grpDifficulty so the user can choose perfered difficulty

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Application.Exit()  'Calls upon the application class and Exit() method to terminate the program

    End Sub

    Private Sub btnStart_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseHover

        Me.btnStart.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)     'Enlarges font when mouse hovers over it

    End Sub

    Private Sub btnStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.MouseLeave

        Me.btnStart.Font = New Font("Microsoft Sans Serif", 12)     'Shrinks font when mouse leaves it

    End Sub

    Private Sub btnExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseHover

        Me.btnExit.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)     'Enlarges font when mouse hovers over it

    End Sub

    Private Sub btnExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave

        Me.btnExit.Font = New Font("Microsoft Sans Serif", 12)     'Shrinks font when mouse leaves it

    End Sub

    Private Sub radEasy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEasy.CheckedChanged

        intDiff = 1     'Sets the difficulty to Easy

        Me.Visible = False              'Closes the current form
        frmGameScreen.Visible = True    'Opens the game screen

    End Sub

    Private Sub radMedium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMedium.CheckedChanged

        intDiff = 2     'Sets the difficulty to Medium

        Me.Visible = False              'Closes the current form
        frmGameScreen.Visible = True    'Opens the game screen

    End Sub

    Private Sub radHard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHard.CheckedChanged

        intDiff = 3     'Sets the difficulty to Hard

        Me.Visible = False              'Closes the current form
        frmGameScreen.Visible = True    'Opens the game screen

    End Sub
End Class