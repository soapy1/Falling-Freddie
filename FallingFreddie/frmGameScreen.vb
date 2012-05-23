Public Class frmGameScreen

    'TO FIX
    'Starting up is buggy

    Dim intDiff As Integer = frmTitleScreen.intDiff
    Public intCorrect As Integer
    Public intIncorrect As Integer
    Public dblAnswer As Decimal
    Public dblUserInput As Double

    Private Sub frmGameScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call OperationSelection()       'Starts to run the program

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

        Me.Close()                      'Closes the game form
        frmTitleScreen.Visible = True   'Makes the title screen visible to allow the user to start a new game

        '-----------------------------------------------------------------
        'TODO:  initialize all the variables in the program to default
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

        Dim intOperation As Integer         'Creates a variable which will be reffered to when choosing an operation

        intOperation = (4) * Rnd() + 1      'Randomly selects the operation

        If intOperation = 1 Then
            Call OperationAddition()            'An addition question will be created according to the sub procedure OpartaionAddition
        ElseIf intOperation = 2 Then
            Call OperationSubtraction()         'A subtraction question will be created according to the sub procedure OpartaionSubtraction
            'ElseIf intOperation = 3 Then
            '   Call OperationMultiplication()      'A multiplication question will be created according to the sub procedure OpartaionMultiplication
            'ElseIf intOperation = 4 Then
            '   Call OperationDivision()            'A division question will be created according to the sub procedure OpartaionDivision
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

        If intDiff = 1 Then                                 'Easy level: two random numbers between 1 and 50 are created 
            numOne = (50) * Rnd() + 1
            numTwo = (50) * Rnd() + 1

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

        If intDiff = 1 Then                                 'Easy level: two random numbers between 1 and 50 are created 
            numOne = (20) * Rnd() + 1
            numTwo = (20) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 2 Then                             'Medium level:  two random numbers between 1 and 500 are created
            numOne = (100) * Rnd() + 1
            numTwo = (100) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        ElseIf intDiff = 3 Then                             'Hard level:  two random numbers between 1 and 5000 are created
            numOne = (1000) * Rnd() + 1
            numTwo = (1000) * Rnd() + 1

            dblAnswer = numOne - numTwo

            lblQuestion.Text = numOne & " - " & numTwo      'The question is displayed for the user

        End If

    End Sub

    Sub txtAns_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAns.KeyPress

        If Asc(e.KeyChar) = 13 Then             'Checks if the Enter key has been pressed down

            dblUserInput = Val(Me.txtAns.Text)  'Retrives value form the user

            Call CheckAns()
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


End Class
