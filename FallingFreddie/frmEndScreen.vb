Public Class frmEndScreen

    Dim time As Integer

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click

        Application.Exit()      'Uses the application class and the exit method to terminate the program

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click

        frmTitleScreen.radEasy.Checked = False      '
        frmTitleScreen.radMedium.Checked = False    'Unchecks all the radio buttons in the first form (frmTitleScreen)
        frmTitleScreen.radHard.Checked = False      '

        Me.Close()                      'Closes the end screen form
        frmGameScreen.Close()           'Closes the game form
        frmTitleScreen.Visible = True   'Makes the title screen visible to allow the user to start a new game

    End Sub

    Private Sub frmEndScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblScore.Text = "Your score:  " & (frmGameScreen.intCorrect) * 100   'Displays the score

        lblTime.Text = "You lasted:  " & (frmGameScreen.intClock) & " s"     'Displays the time in seconds the user achieved

        lblPercent.Text = "Percantage correct:  " & FormatPercent((frmGameScreen.intCorrect / (frmGameScreen.intCorrect + frmGameScreen.intIncorrect)))      'Displays the percent correct

    End Sub

End Class