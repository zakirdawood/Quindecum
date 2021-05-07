Public Class frmFaizanRulerOfTheKnightsCharacterSelection
    Private Sub picSirLancelot_MouseHover(sender As Object, e As EventArgs) Handles picSirLancelot.MouseHover
        lblSirLancelotInfo.Visible = True
    End Sub

    Private Sub picSirLancelot_MouseLeave(sender As Object, e As EventArgs) Handles picSirLancelot.MouseLeave
        lblSirLancelotInfo.Visible = False
    End Sub

    Private Sub picArthurLeBlanc_MouseHover(sender As Object, e As EventArgs) Handles picArthurLeBlanc.MouseHover
        lblArthurLeBlancInfo.Visible = True
    End Sub

    Private Sub picArthurLeBlanc_MouseLeave(sender As Object, e As EventArgs) Handles picArthurLeBlanc.MouseLeave
        lblArthurLeBlancInfo.Visible = False
    End Sub

    Private Sub picGarethBale_MouseHover(sender As Object, e As EventArgs) Handles picGarethBale.MouseHover
        lblGarethBaleInfo.Visible = True
    End Sub

    Private Sub picGarethBale_MouseLeave(sender As Object, e As EventArgs) Handles picGarethBale.MouseLeave
        lblGarethBaleInfo.Visible = False
    End Sub

    Private Sub picSirLancelot_Click(sender As Object, e As EventArgs) Handles picSirLancelot.Click
        Dim confirmCharacter As Integer

        confirmCharacter = MessageBox.Show("Select Sir Lancelot?", "Confirm Character Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmCharacter = DialogResult.Yes Then
            playerCharacter = 1
            frmFaizanRulerOfTheKnightsGameScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub picArthurLeBlanc_Click(sender As Object, e As EventArgs) Handles picArthurLeBlanc.Click
        Dim confirmCharacter As Integer

        confirmCharacter = MessageBox.Show("Select Arthur LeBlanc?", "Confirm Character Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmCharacter = DialogResult.Yes Then
            playerCharacter = 2
            frmFaizanRulerOfTheKnightsGameScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub picGarethBale_Click(sender As Object, e As EventArgs) Handles picGarethBale.Click
        Dim confirmCharacter As Integer

        confirmCharacter = MessageBox.Show("Select Gareth Bale?", "Confirm Character Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmCharacter = DialogResult.Yes Then
            playerCharacter = 3
            frmFaizanRulerOfTheKnightsGameScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmFaizanRulerOfTheKnightsMenu.Show()
        Me.Close()
    End Sub
End Class