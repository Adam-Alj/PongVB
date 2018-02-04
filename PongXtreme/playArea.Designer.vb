<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class playArea
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(playArea))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.playerScoreLabel = New System.Windows.Forms.Label()
        Me.computerScoreLabel = New System.Windows.Forms.Label()
        Me.playerPaddle = New System.Windows.Forms.PictureBox()
        Me.computerPaddle = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.rightExplosion = New System.Windows.Forms.PictureBox()
        Me.controlTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.playerPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightExplosion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1176, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "_____________________________________________________________"
        '
        'playerScoreLabel
        '
        Me.playerScoreLabel.AutoSize = True
        Me.playerScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.playerScoreLabel.Location = New System.Drawing.Point(772, 12)
        Me.playerScoreLabel.Name = "playerScoreLabel"
        Me.playerScoreLabel.Size = New System.Drawing.Size(296, 37)
        Me.playerScoreLabel.TabIndex = 2
        Me.playerScoreLabel.Text = "PLAYER SCORE: "
        '
        'computerScoreLabel
        '
        Me.computerScoreLabel.AutoSize = True
        Me.computerScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.computerScoreLabel.Location = New System.Drawing.Point(50, 9)
        Me.computerScoreLabel.Name = "computerScoreLabel"
        Me.computerScoreLabel.Size = New System.Drawing.Size(210, 39)
        Me.computerScoreLabel.TabIndex = 3
        Me.computerScoreLabel.Text = "AI SCORE: "
        '
        'playerPaddle
        '
        Me.playerPaddle.Image = CType(resources.GetObject("playerPaddle.Image"), System.Drawing.Image)
        Me.playerPaddle.Location = New System.Drawing.Point(1056, 271)
        Me.playerPaddle.Name = "playerPaddle"
        Me.playerPaddle.Size = New System.Drawing.Size(36, 170)
        Me.playerPaddle.TabIndex = 4
        Me.playerPaddle.TabStop = False
        '
        'computerPaddle
        '
        Me.computerPaddle.Image = CType(resources.GetObject("computerPaddle.Image"), System.Drawing.Image)
        Me.computerPaddle.Location = New System.Drawing.Point(57, 271)
        Me.computerPaddle.Name = "computerPaddle"
        Me.computerPaddle.Size = New System.Drawing.Size(36, 170)
        Me.computerPaddle.TabIndex = 5
        Me.computerPaddle.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ball.Image = CType(resources.GetObject("Ball.Image"), System.Drawing.Image)
        Me.Ball.Location = New System.Drawing.Point(553, 324)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(36, 37)
        Me.Ball.TabIndex = 6
        Me.Ball.TabStop = False
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 20
        '
        'rightExplosion
        '
        Me.rightExplosion.Image = CType(resources.GetObject("rightExplosion.Image"), System.Drawing.Image)
        Me.rightExplosion.Location = New System.Drawing.Point(779, 207)
        Me.rightExplosion.Name = "rightExplosion"
        Me.rightExplosion.Size = New System.Drawing.Size(210, 280)
        Me.rightExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.rightExplosion.TabIndex = 7
        Me.rightExplosion.TabStop = False
        Me.rightExplosion.Visible = False
        '
        'controlTimer
        '
        Me.controlTimer.Interval = 20
        '
        'playArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1152, 682)
        Me.Controls.Add(Me.rightExplosion)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.computerPaddle)
        Me.Controls.Add(Me.playerPaddle)
        Me.Controls.Add(Me.computerScoreLabel)
        Me.Controls.Add(Me.playerScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "playArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.playerPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightExplosion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents playerScoreLabel As Label
    Friend WithEvents computerScoreLabel As Label
    Friend WithEvents playerPaddle As PictureBox
    Friend WithEvents computerPaddle As PictureBox
    Friend WithEvents Ball As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents rightExplosion As PictureBox
    Friend WithEvents controlTimer As Timer
End Class
