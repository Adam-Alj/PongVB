Public Class Welcome_Screen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playArea.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Welcome to X-TREME PONG! Can you end the undefeated masters reign?" + Chr(13) _
               + "------------------------------------" + Chr(13) _
               + "Move the paddle with the mouse." + Chr(13) _
               + "Press escape to pause and bring up the in-game menu." + Chr(13) _
               + "Bounce the ball towards the edges of your paddle for directional control!" + Chr(13) _
               + "Whoever scores 15 points first wins!" + Chr(13) _
               + "------------------------------------" + Chr(13) _
               + "The master is waiting...")
    End Sub
End Class