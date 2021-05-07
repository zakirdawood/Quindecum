Public Class frmFaizanRulerOfTheKnightsHowToPlay
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmFaizanRulerOfTheKnightsMenu.Show()
    End Sub

    Private Sub lblEasterEgg_Click(sender As Object, e As EventArgs) Handles lblEasterEgg.Click
        MessageBox.Show("Wow it really was easy." & vbNewLine & "Goodjob, you earn 50 tickets as a reward", "Easter Egg Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ticketsTotal += 50
    End Sub
End Class