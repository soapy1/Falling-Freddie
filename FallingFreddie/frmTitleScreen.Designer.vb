<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitleScreen
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
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.grpDifficulty = New System.Windows.Forms.GroupBox
        Me.radHard = New System.Windows.Forms.RadioButton
        Me.radMedium = New System.Windows.Forms.RadioButton
        Me.radEasy = New System.Windows.Forms.RadioButton
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(65, 249)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(757, 56)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(70, 464)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(757, 56)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(58, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(775, 218)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Falling Freddie"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.radHard)
        Me.grpDifficulty.Controls.Add(Me.radMedium)
        Me.grpDifficulty.Controls.Add(Me.radEasy)
        Me.grpDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDifficulty.Location = New System.Drawing.Point(65, 311)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDifficulty.Size = New System.Drawing.Size(762, 128)
        Me.grpDifficulty.TabIndex = 3
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "Choose a Difficulty"
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHard.Location = New System.Drawing.Point(340, 88)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(62, 24)
        Me.radHard.TabIndex = 2
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMedium.Location = New System.Drawing.Point(340, 58)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(83, 24)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEasy.Location = New System.Drawing.Point(340, 28)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(62, 24)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 532)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmTitleScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Falling Freddie!"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents radHard As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radEasy As System.Windows.Forms.RadioButton
End Class
