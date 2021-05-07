Public Class frmFaizanGameSelection
    Private Sub btnOldTownDerby_Click(sender As Object, e As EventArgs) Handles btnOldTownDerby.Click
        If tokensLeft < 1 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmMuhammadRace.Show()
    End Sub

    Private Sub btnSpotIt_Click(sender As Object, e As EventArgs) Handles btnSpotIt.Click
        If tokensLeft < 3 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmZakirSpotIt.Show()
    End Sub

    Private Sub btnMagicMemory_Click(sender As Object, e As EventArgs) Handles btnMagicMemory.Click
        If tokensLeft < 3 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmMuhammadMemoryGame.Show()
    End Sub

    Private Sub btnSpeedys_Click(sender As Object, e As EventArgs) Handles btnSpeedys.Click
        If tokensLeft < 1 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmFaizanReactionTest.Show()
    End Sub

    Private Sub btnTakeOrRisk_Click(sender As Object, e As EventArgs) Handles btnTakeOrRisk.Click
        If tokensLeft < 5 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmZakirTakeOrRisk.Show()
    End Sub

    Private Sub btnRulerOfTheKnights_Click(sender As Object, e As EventArgs) Handles btnRulerOfTheKnights.Click
        If tokensLeft < 6 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Hide()
        frmFaizanRulerOfTheKnightsMenu.Show()
    End Sub

    Private Sub btnPrizes_Click(sender As Object, e As EventArgs) Handles btnPrizes.Click
        Me.Close()
        frmZakirPrizes.Show()
    End Sub
End Class
