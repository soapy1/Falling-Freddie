Public Class frmGameScreen

    'TODO:
    'Add help/instructions 
    'Add music + sound effects
    'End Game, ultimate goal
    'Easter eggs

    Dim intDiff As Integer = frmTitleScreen.intDiff
    Public intCorrect As Integer
    Public intIncorrect As Integer
    Public dblAnswer As Decimal
    Public dblUserInput As Double
    Public intAltitude As Integer = 100
    Public intClock As Integer

    Private Sub frmGameScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call OperationSelection()       'Starts to run the program
        tmrFreddie.Enabled = True       'Enables the timer tmrFreddie which will make an animation
        tmrClock.Enabled = True         'Enables the timer tmrClock which tracks the time elapsed

    End Sub


    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click

        Application.Exit()      'Uses the application class and the exit method to terminate the application

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click

        frmTitleScreen.radEasy.Checked = False
        frmTitleScreen.radMedium.Checked = False
        frmTitleScreen.radHard.Checked = False

        intCorrect = 0                  '
        intIncorrect = 0                'Resets all the variables
        dblAnswer = 0                   '
        dblUserInput = 0                '

        Me.Close()                      'Closes the game form
        frmTitleScreen.Visible = True   'Makes the title screen visible to allow the user to start a new game

        '-----------------------------------------------------------------
        'TODO:  set all the variables in the program back to default
        '-----------------------------------------------------------------

    End Sub

    '-------------------------------------------------------------------------------------------------------------------
    '
    'Randomly creates a number between 1 and 4
    'Number 1 coresponds to addition, number 2 to subtration, number 3 to multiplication and number 4 to division
    '
    'Pre:  an operation for the math problem is unknown
    'Post:  an operation for the math problem is randomly selected
    '
    '-------------------------------------------------------------------------------------------------------------------
    Sub OperationSelection()

        Randomize()                         'Allows random numbers to be created

        Dim intOperation As Integer         'Creates a variable which will be reffered to when choosing an operation

        intOperation = (4) * Rnd() + 1      'Randomly selects the operation

        If intOperation = 1 Then
            Call OperationAddition()            'An addition question will be created according to the sub procedure OpartaionAddition
        ElseIf intOperation = 2 Then
            Call OperationSubtraction()         'A subtraction question will be created according to the sub procedure OpartaionSubtraction
        ElseIf intOperation = 3 Then
            Call OperationMultiplication()      'A multiplication question will be created according to the sub procedure OpartaionMultiplication
        ElseIf intOperation = 4 Then
            Call OperationDivision()            'A division question will be created according to the sub procedure OpartaionDivision
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------------------
    '
    'Creates addition questions for the Easy, Medium and Hard levels.
    '
    'Pre:  an operation is known but no question has been creates
    'Post:  an addition question has been created for the user
    '
    '-------------------------------------------------------------------------------------------------------------
    Sub OperationAddition()

        Dim numOne As Integer, numTwo As Integer

        Randomize()         'Allows random numbers to be created

        If intDiff = 1 Then                                 'Easy level: two random numbers between 1 and 50 are created 
            numOne = (50) * Rnd() + 1
            numTwo = 50 * Rnd() + 1

            dblAnswer = numOne + numTwo

            lblQuestion.Text = numOne & " + " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 2 Then                             'Medium level:  two random numbers between 1 and 500 are created
            numOne = (500) * Rnd() + 1
            numTwo = (500) * Rnd() + 1

            dblAnswer = numOne + numTwo

            lblQuestion.Text = numOne & " + " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 3 Then                             'Hard level:  two random numbers between 1 and 5000 are created
            numOne = (5000) * Rnd() + 1
            numTwo = (5000) * Rnd() + 1

            dblAnswer = numOne + numTwo

            lblQuestion.Text = numOne & " + " & numTwo      'The question is displayed for the user

        End If

    End Sub

    '-----------------------------------------------------------------------------------------------------------
    '
    'Creates subtraction questions for the Easy, Medium and Hard levels.
    '
    'Pre:  an operation is known but no question has been creates
    'Post:  a subtraction question has been created for the user
    '
    '-------------------------------------------------------------------------------------------------------------
    Sub OperationSubtraction()

        Dim numOne As Integer, numTwo As Integer

        Randomize()         'Allows random numbers to be created

        If intDiff = 1 Then                                 'Easy level: two random numbers between 1 and 20 are created 
            numOne = (20) * Rnd() + 1
            numTwo = (20) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 2 Then                             'Medium level:  two random numbers between 1 and 100 are created
            numOne = (100) * Rnd() + 1
            numTwo = (100) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 3 Then                             'Hard level:  two random numbers between 1 and 1000 are created
            numOne = (1000) * Rnd() + 1
            numTwo = (1000) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        End If

    End Sub


    '-----------------------------------------------------------------------------------------------------------
    '
    'Creates multiplication questions for the Easy, Medium and Hard levels.
    '
    'Pre:  an operation is known but no question has been creates
    'Post:  a multiplication question has been created for the user
    '
    '-------------------------------------------------------------------------------------------------------------
    Sub OperationMultiplication()

        Dim numOne As Integer, numTwo As Integer

        Randomize()         'Allows random numbers to be created

        If intDiff = 1 Then                                 'Easy level: two random numbers between 1 and 5 are created 
            numOne = (5) * Rnd() + 1
            numTwo = (5) * Rnd() + 1

            dblAnswer = numOne * numTwo

            lblQuestion.Text = numOne & " x " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 2 Then                             'Medium level:  two random numbers between 1 and 10 are created
            numOne = (10) * Rnd() + 1
            numTwo = (10) * Rnd() + 1

            dblAnswer = numOne * numTwo

            lblQuestion.Text = numOne & " x " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 3 Then                             'Hard level:  two random numbers between 1 and 12 are created
            numOne = (12) * Rnd() + 1
            numTwo = (12) * Rnd() + 1

            dblAnswer = numOne * numTwo

            lblQuestion.Text = numOne & " x " & numTwo      'The question is displayed for the user

        End If

    End Sub


    '-----------------------------------------------------------------------------------------------------------
    '
    'Creates division questions for the Easy, Medium and Hard levels.
    '
    'Pre:  an operation is known but no question has been creates
    'Post:  a division question has been created for the user
    '
    '-------------------------------------------------------------------------------------------------------------
    Sub OperationDivision()

        Dim numOne As Integer, numTwo As Integer

        Randomize()             'Allows random numbers to be created

        If intDiff = 1 Then                     'Easy level: A number is multiplied by 2 and the divisor is 2, so the quotient is always the initial number
            numOne = (10) * Rnd()
            numTwo = 2
            numOne = numOne * 2

            dblAnswer = numOne / numTwo

            lblQuestion.Text = numOne & " / " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 2 Then                 'Medium level:  A number is multiplied by 8 or 5 and the divisor is 8 or 5, so the quotient is always the initial number

            Dim dblDiv As Double                'Creates a variable which will be used to determine what the divisor will be

            Randomize()

            dblDiv = Rnd()                      'Creates a random number

            If dblDiv < 0.5 Then                'Determines what the divisor will be.  If the random number is 
                numOne = (50) * Rnd()           'less than 0.5, the divisor will be 8 or else the divisor will be 5
                numTwo = 8
                numOne = numOne * 8

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            Else
                numOne = (50) * Rnd()
                numTwo = 5
                numOne = numOne * 5

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            End If

            lblQuestion.Text = numOne & " / " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 3 Then             'Hard level: A number is between 0 and 100 is multiplied by 13, 14, 15 or 9 and the divisor is 13, 14, 15 or 9 so the quotient is always the initial number

            Dim dblDiv As Double            'Creates a variable which will be used to determine what the divisor will be

            Randomize()

            dblDiv = Rnd()                  'Creates a random number

            If dblDiv < 0.25 Then            'Determines what the divisor will be.  If the random number is
                numOne = (50) * Rnd()        'less than 0.25, the divisor will be 13; if it is between 0.25 and
                numTwo = 13                  '0.5, the divisor will be 14; if it is between 0.5 and 0.75 
                numOne = numOne * 13         'the divisor will be 14, or else the divisor will 9

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            ElseIf 0.25 < dblDiv < 0.5 Then
                numOne = (50) * Rnd()
                numTwo = 14
                numOne = numOne * 14

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            ElseIf 0.5 < dblDiv < 0.75 Then
                numOne = (50) * Rnd()
                numTwo = 15
                numOne = numOne * 15

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            Else
                numOne = (50) * Rnd()
                numTwo = 9
                numOne = numOne * 9

                dblAnswer = numOne / numTwo
                lblQuestion.Text = numOne & " / " & numTwo
            End If

            lblQuestion.Text = numOne & " / " & numTwo      'The question is displayed for the user

        End If

    End Sub

    '--------------------------------------------------------------------------------------------------------
    '
    'Checks the user input versus the true answer to the generated question
    '
    'Pre:  the user has input data according to the question displayed in a label
    'Post:  the user input and the true answer to the question displayed are compared.  If they are the same
    '       the user gets plus one correct, if they are different they get plus one incorrect
    '
    '--------------------------------------------------------------------------------------------------------
    Sub CheckAns()

        If IsNumeric(dblUserInput) = True Then  'Makes sure the user input is of numeric value
            If dblUserInput = dblAnswer Then
                intCorrect += 1                 'If the user is correct they get plus 1 correct
                lblStatus.Text = "Correct"
                Me.txtAns.Text = ""             'The text box is cleared for new input

                tmrFreddie.Enabled = False      'Turns off Freddie Falling animation
                tmrJetPack.Enabled = True       'Turns on the jet pack animation

                Call OperationSelection()
            Else
                intIncorrect += 1               'If the user is incorrect they get plus 1 incorrect
                lblStatus.Text = "Wrong"
                Me.txtAns.Text = ""             'The text box is cleared for new input
                Call OperationSelection()
            End If
        Else
            lblStatus.Text = "Not a valid answer dum dum"     'If the user input is not of numeric value a mesage is displayed
        End If

    End Sub

    Sub txtAns_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAns.KeyPress

        If Asc(e.KeyChar) = 13 Then             'Checks if the Enter key has been pressed down

            dblUserInput = Val(Me.txtAns.Text)  'Retrives value form the user

            Call CheckAns()     'Calls the CheckAns sub routine to determine if the users input is correct
        End If

    End Sub

    Private Sub tmrFreddie_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFreddie.Tick

        Const VELOCITY As Integer = 10      'The speed at which Freddie falls
        Const NUM_PIC As Integer = 3        'The number of pictures in the animation    
        Static pic As Integer

        Select Case pic                     'Loops pictures in order to create an animation
            Case 0
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFall1
            Case 1
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFall2
            Case 2
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFall3
        End Select

        pic = (pic + 1) Mod NUM_PIC         'Displays the pictures in order to create a fluid animation

        intAltitude -= VELOCITY                 'Calaulates Freddie's altitude
        lblAltitude.Text = intAltitude & "m"    'Displays Freddie's altitude

        If intAltitude = 0 Then             'When Freddie's altitude is 0 a black screen is created and the game is stopped

            tmrFreddie.Enabled = False      'Turns off the timers
            tmrJetPack.Enabled = False      '

            Me.Visible = False              'Moves to the from frmEndScreen
            frmBlackScreen.Visible = True     '

        End If
    End Sub

    Private Sub tmrJetPack_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJetPack.Tick

        Const VELOCITY As Integer = 10      'The speed at which Freddie flys up
        Const NUM_PIC As Integer = 7        'The number of pictures in the animation 
        Static pic As Integer

        Select Case pic                         'Loops pictures in order to create an animation
            Case 0 Or 2
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFly1
            Case 1 Or 3
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFly2
            Case 4
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFly1
            Case 5
                Me.picAnimation.Image = My.Resources.fallingFreddiePictureFly2
            Case 6
                tmrJetPack.Enabled = False        'Stops the jet pack animation
                tmrFreddie.Enabled = True         'Starts the  Freddie falling animation
        End Select

        pic = (pic + 1) Mod NUM_PIC       'Displays the pictures in order to create a fluid animation

        intAltitude += VELOCITY                 'Determines Freddie's altitude
        lblAltitude.Text = intAltitude & " m"    'Displays Freddie's altitude

        If intAltitude = 0 Then             'When Freddie's altitude is 0 a black screen is created and the game is stopped

            tmrFreddie.Enabled = False      'Turns off the timers
            tmrJetPack.Enabled = False      '

            Me.Visible = False              'Moves to the from frmEndScreen
            frmBlackScreen.Visible = True   '

        End If

    End Sub

    Private Sub tmrClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick

        intClock += 1

        lblClock.Text = intClock & " s"

    End Sub

End Class
