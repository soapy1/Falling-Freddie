<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndScreen
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
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblRank = New System.Windows.Forms.Label
        Me.picFreddie = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblPercent = New System.Windows.Forms.Label
        Me.tmrDancingFreddie = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        CType(Me.picFreddie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(39, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(110, 24)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Your Score:"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.Location = New System.Drawing.Point(39, 176)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(129, 24)
        Me.lblRank.TabIndex = 1
        Me.lblRank.Text = "Your Ranking:"
        '
        'picFreddie
        '
        Me.picFreddie.Location = New System.Drawing.Point(43, 223)
        Me.picFreddie.Name = "picFreddie"
        Me.picFreddie.Size = New System.Drawing.Size(801, 290)
        Me.picFreddie.TabIndex = 2
        Me.picFreddie.TabStop = False
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
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(39, 82)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(178, 24)
        Me.lblPercent.TabIndex = 4
        Me.lblPercent.Text = "Percentage Correct:"
        '
        'tmrDancingFreddie
        '
        Me.tmrDancingFreddie.Enabled = True
        Me.tmrDancingFreddie.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(39, 129)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(103, 24)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "You lasted:"
        '
        'frmEndScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.picFreddie)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEndScreen"
        Me.Text = "Falling Freddie!"
        CType(Me.picFreddie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents picFreddie As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents tmrDancingFreddie As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
