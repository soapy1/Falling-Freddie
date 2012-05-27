Public Class frmBlackScreen


    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

        Me.Close()
        frmEndScreen.Visible = True

    End Sub
End Class