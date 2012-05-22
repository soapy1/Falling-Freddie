Public Class frmGameScreen

    Dim intDiff As Integer = frmTitleScreen.intDiff

    
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click

        Application.Exit()      'Uses the application class and the exit method to terminate the application

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click

        frmTitleScreen.radEasy.Checked = False
        frmTitleScreen.radMedium.Checked = False
        frmTitleScreen.radHard.Checked = False

        Me.Close()                      'Closes the game form
        frmTitleScreen.Visible = True   'Makes the title screen visible to allow the user to start a new game

        '-----------------------------------------------------------------
        'TODO:  initialize all the variables in the program to default
        '-----------------------------------------------------------------

    End Sub

    Private Sub frmGameScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblQuestion.Text = intDiff

    End Sub
End Class
