<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.txtAns = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblStatus = New System.Windows.Forms.Label
        Me.tmrFreddie = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJetPack = New System.Windows.Forms.Timer(Me.components)
        Me.lblAltitude = New System.Windows.Forms.Label
        Me.picAnimation = New System.Windows.Forms.PictureBox
        Me.lblAltitudePrompt = New System.Windows.Forms.Label
        Me.lblQuestionPrompt = New System.Windows.Forms.Label
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClockPrompt = New System.Windows.Forms.Label
        Me.lblClock = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(751, 309)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(0, 24)
        Me.lblQuestion.TabIndex = 1
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(605, 501)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(100, 20)
        Me.txtAns.TabIndex = 2
        Me.txtAns.UseWaitCursor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(455, 503)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(118, 20)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrFreddie
        '
        Me.tmrFreddie.Interval = 200
        '
        'tmrJetPack
        '
        Me.tmrJetPack.Interval = 200
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltitude.Location = New System.Drawing.Point(751, 220)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(0, 20)
        Me.lblAltitude.TabIndex = 5
        '
        'picAnimation
        '
        Me.picAnimation.BackColor = System.Drawing.Color.White
        Me.picAnimation.Location = New System.Drawing.Point(184, 38)
        Me.picAnimation.Name = "picAnimation"
        Me.picAnimation.Size = New System.Drawing.Size(521, 457)
        Me.picAnimation.TabIndex = 0
        Me.picAnimation.TabStop = False
        '
        'lblAltitudePrompt
        '
        Me.lblAltitudePrompt.AutoSize = True
        Me.lblAltitudePrompt.Location = New System.Drawing.Point(711, 192)
        Me.lblAltitudePrompt.Name = "lblAltitudePrompt"
        Me.lblAltitudePrompt.Size = New System.Drawing.Size(69, 13)
        Me.lblAltitudePrompt.TabIndex = 6
        Me.lblAltitudePrompt.Text = "Your altitude:"
        '
        'lblQuestionPrompt
        '
        Me.lblQuestionPrompt.AutoSize = True
        Me.lblQuestionPrompt.Location = New System.Drawing.Point(711, 269)
        Me.lblQuestionPrompt.Name = "lblQuestionPrompt"
        Me.lblQuestionPrompt.Size = New System.Drawing.Size(107, 13)
        Me.lblQuestionPrompt.TabIndex = 7
        Me.lblQuestionPrompt.Text = "Answer this question:"
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'lblClockPrompt
        '
        Me.lblClockPrompt.AutoSize = True
        Me.lblClockPrompt.Location = New System.Drawing.Point(12, 192)
        Me.lblClockPrompt.Name = "lblClockPrompt"
        Me.lblClockPrompt.Size = New System.Drawing.Size(73, 13)
        Me.lblClockPrompt.TabIndex = 8
        Me.lblClockPrompt.Text = "Time elapsed:"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(35, 225)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(0, 20)
        Me.lblClock.TabIndex = 9
        '
        'frmGameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.lblClockPrompt)
        Me.Controls.Add(Me.lblQuestionPrompt)
        Me.Controls.Add(Me.lblAltitudePrompt)
        Me.Controls.Add(Me.lblAltitude)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.picAnimation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGameScreen"
        Me.Text = "Falling Freddie!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picAnimation As System.Windows.Forms.PictureBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrFreddie As System.Windows.Forms.Timer
    Friend WithEvents tmrJetPack As System.Windows.Forms.Timer
    Friend WithEvents lblAltitude As System.Windows.Forms.Label
    Friend WithEvents lblAltitudePrompt As System.Windows.Forms.Label
    Friend WithEvents lblQuestionPrompt As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents lblClockPrompt As System.Windows.Forms.Label
    Friend WithEvents lblClock As System.Windows.Forms.Label

End Class
