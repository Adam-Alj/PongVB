Public Class playArea

    Public speed As Double
    Public rand As New Random
    Public xMov As Double
    Public yMov As Double
    Public ballBounces As Integer
    Public startingBallLocation As Point = New Point(553, 325)
    Public playerScore As Integer
    Public compScore As Integer
    Public controlTimerCondition As Integer = 0
    Public flairPerformed As Boolean = False
    Private g As Graphics

    Private Sub playArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ball.BackColor = Color.Transparent
        initializeNewGame()
        g = Me.CreateGraphics
    End Sub


    Public Sub initializeNewGame()
        playerPaddle.Enabled = False
        computerPaddle.Enabled = False
        Ball.Enabled = False
        flairPerformed = False
        Cursor.Hide()
        Cursor.Clip = New Rectangle(New Point(0, 0), Me.Size)
        speed = 7
        xMov = rand.NextDouble + 0.8
        yMov = rand.NextDouble + 0.8
        ballBounces = 1
        Ball.Location = startingBallLocation
        playerScore = 0
        compScore = 0
        playerScoreLabel.Text = "PLAYER SCORE: " + playerScore.ToString
        computerScoreLabel.Text = "AI SCORE: " + compScore.ToString
        playerPaddle.Enabled = True
        gameTimer.Start()
    End Sub

    Public Sub initialize()
        flairPerformed = False
        speed = 7
        xMov = rand.NextDouble + 0.5
        yMov = rand.NextDouble + 0.5
        ballBounces = 1
        Ball.Location = startingBallLocation
        playerScoreLabel.Text = "PLAYER SCORE: " + playerScore.ToString
        computerScoreLabel.Text = "AI SCORE: " + compScore.ToString
    End Sub

    Sub displayMenu(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) And (flairPerformed = False) Then
            gameTimer.Stop()
            GameMenu.Show()
            Me.Enabled = False
        End If
    End Sub

    Sub movePaddle(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If (e.Y - 85 < 510) And (e.Y - 85 > 72) And (flairPerformed = False) Then
            playerPaddle.Location = New Point(playerPaddle.Location.X, e.Y - 85)
        End If
        Cursor.Clip = Me.Bounds
    End Sub

    Sub controlTimerDone(sender As Object, e As EventArgs) Handles controlTimer.Tick
        If (controlTimerCondition = 1) Then
            rightExplosion.Hide()
            controlTimer.Stop()
            playerPaddle.Enabled = True
            initialize()
            gameTimer.Start()
        ElseIf (controlTimerCondition = 2) Then
            gameTimer.Start()
        ElseIf (controlTimerCondition = 3) Then
            rightExplosion.Hide()
            controlTimer.Stop()
            EndGameScreen.Show()
        End If




    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick

        Ball.Location = New Point(Ball.Location.X + (xMov * speed), Ball.Location.Y + (yMov * speed))

        If (Ball.Location.Y - 85 < 510) And (Ball.Location.Y - 85 > 72) Then
            computerPaddle.Location = New Point(computerPaddle.Location.X, Ball.Location.Y - 85)
        End If


        If (Ball.Location.X < 0) Then
            playerScore += 1
            initialize()
        ElseIf (Ball.Location.X > 1113) Then
            rightExplosion.Location = New Point(Ball.Location.X - 175, Ball.Location.Y - 100)
            rightExplosion.SendToBack()
            rightExplosion.Show()
            controlTimerCondition = 1
            controlTimer.Interval = 1000
            controlTimer.Start()
            gameTimer.Stop()
            My.Computer.Audio.Play(My.Resources.explosionSound, AudioPlayMode.Background)
            compScore += 1
        End If

        If (playerScore = 15) Or (compScore = 15) Then
            controlTimerCondition = 3
            controlTimer.Interval = 1000
            controlTimer.Start()
            gameTimer.Stop()
        End If

        Dim paddleLengthDivisions As Integer = playerPaddle.Height / 5

        If (Ball.Bounds.IntersectsWith(playerPaddle.Bounds)) And (flairPerformed = False) Then
            xMov = -xMov
            If (Ball.Location.Y + 15 > playerPaddle.Bounds.Top) And ((Ball.Location.Y + 15) <= (playerPaddle.Bounds.Top + paddleLengthDivisions)) Then
                yMov = yMov - 0.5
            ElseIf (Ball.Location.Y + 15 > playerPaddle.Bounds.Top + paddleLengthDivisions) And (Ball.Location.Y + 15 <= playerPaddle.Bounds.Top + (2 * paddleLengthDivisions)) Then
                yMov = yMov - 0.25
            ElseIf (Ball.Location.Y + 15 > playerPaddle.Bounds.Top + (2 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= playerPaddle.Bounds.Top + (3 * paddleLengthDivisions)) Then
                yMov = yMov
            ElseIf (Ball.Location.Y + 15 > playerPaddle.Bounds.Top + (3 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= playerPaddle.Bounds.Top + (4 * paddleLengthDivisions)) Then
                yMov = yMov + 0.25
            ElseIf (Ball.Location.Y + 15 > playerPaddle.Bounds.Top + (4 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= playerPaddle.Bounds.Top + (5 * paddleLengthDivisions)) Then
                yMov = yMov + 0.5
            End If
            My.Computer.Audio.Play(My.Resources.thunk, AudioPlayMode.Background)
            ballBounces += 1
            speed += 0.65
        End If

        If (Ball.Bounds.IntersectsWith(computerPaddle.Bounds)) Then
            xMov = -xMov
            If (Ball.Location.Y + 15 > computerPaddle.Bounds.Top) And ((Ball.Location.Y + 15) <= (computerPaddle.Bounds.Top + paddleLengthDivisions)) Then
                yMov = yMov - 0.5
            ElseIf (Ball.Location.Y + 15 > computerPaddle.Bounds.Top + paddleLengthDivisions) And (Ball.Location.Y + 15 <= computerPaddle.Bounds.Top + (2 * paddleLengthDivisions)) Then
                yMov = yMov - 0.25
            ElseIf (Ball.Location.Y + 15 > computerPaddle.Bounds.Top + (2 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= computerPaddle.Bounds.Top + (3 * paddleLengthDivisions)) Then
                yMov = yMov
            ElseIf (Ball.Location.Y + 15 > computerPaddle.Bounds.Top + (3 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= computerPaddle.Bounds.Top + (4 * paddleLengthDivisions)) Then
                yMov = yMov + 0.25
            ElseIf (Ball.Location.Y + 15 > computerPaddle.Bounds.Top + (4 * paddleLengthDivisions)) And (Ball.Location.Y + 15 <= computerPaddle.Bounds.Top + (5 * paddleLengthDivisions)) Then
                yMov = yMov + 0.5
            End If
            My.Computer.Audio.Play(My.Resources.thunk, AudioPlayMode.Background)
            ballBounces += 1
            speed += 0.65
        End If

        If (Ball.Location.X + 10 > playerPaddle.Location.X) And Not (Ball.Bounds.IntersectsWith(playerPaddle.Bounds)) And (flairPerformed = False) Then
            flairPerformed = True
            playerPaddle.Enabled = False
            gameTimer.Stop()
            controlTimerCondition = 2
            controlTimer.Interval = 2500
            controlTimer.Start()
            g.DrawImage(My.Resources.exclaim1, New Point(Ball.Location.X - 20, Ball.Location.Y - 120))
            My.Computer.Audio.Play(My.Resources.Metal_Gear_Solid_Alert_, AudioPlayMode.WaitToComplete)
            g.DrawImage(My.Resources.playerBbl, New Point(playerPaddle.Location.X - 150, playerPaddle.Location.Y - 20))
            My.Computer.Audio.Play(My.Resources.what, AudioPlayMode.WaitToComplete)
            g.DrawImage(My.Resources.speechBbl2, New Point(computerPaddle.Location.X + 50, computerPaddle.Location.Y - 20))
            My.Computer.Audio.Play(My.Resources.nani, AudioPlayMode.WaitToComplete)
            g.Clear(Color.Transparent)

        End If

        If (Ball.Location.Y > 637) Then
            yMov = -yMov
            If (flairPerformed = False) Then
                My.Computer.Audio.Play(My.Resources.blop, AudioPlayMode.Background)
            End If

        ElseIf (Ball.Location.Y < 73) Then
            yMov = -yMov
            If (flairPerformed = False) Then
                My.Computer.Audio.Play(My.Resources.blip, AudioPlayMode.Background)
            End If

        End If


    End Sub

    Private Sub playArea_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub
End Class
