Public Class EndGameScreen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        playArea.initializeNewGame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub EndGameScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor.Clip = Screen.PrimaryScreen.Bounds
        My.Computer.Audio.Play(My.Resources.endSound, AudioPlayMode.Background)
        Cursor.Show()
        If (playArea.compScore = 15) Then
            Label1.Text = "YOU LOSE"
        ElseIf (playArea.playerScore = 15) Then
            Label1.Text = "YOU WIN"
        End If
    End Sub
End Class