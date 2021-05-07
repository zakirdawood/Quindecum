Public Class frmFaizanRulerOfTheKnightsMenu
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If tokensLeft < 6 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        frmFaizanRulerOfTheKnightsCharacterSelection.Show()
        Me.Hide()
    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        frmFaizanRulerOfTheKnightsHowToPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmFaizanGameSelection.Show()
        Me.Close()
    End Sub

    Private Sub frmFaizanRulerOfTheKnightsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This game will cost you 6 Tokens!", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
