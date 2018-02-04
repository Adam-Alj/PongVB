Public Class GameMenu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Show()
        Cursor.Clip = Screen.PrimaryScreen.Bounds
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub resumeBtn_Click(sender As Object, e As EventArgs) Handles resumeBtn.Click
        playArea.Enabled = True
        Cursor.Hide()
        Me.Close()
        playArea.gameTimer.Start()
    End Sub

    Private Sub newGameBtn_Click(sender As Object, e As EventArgs) Handles newGameBtn.Click
        playArea.Enabled = True
        playArea.initializeNewGame()
        Me.Close()
        playArea.gameTimer.Start()
    End Sub
End Class