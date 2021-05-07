Public Class frmMuhammadTokens
    Private acceptable As Boolean
    Private Sub rdb1person_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1person.CheckedChanged
        lblRecommended.Text = "20 tokens"
    End Sub
    Private Sub rdb2To4People_CheckedChanged(sender As Object, e As EventArgs) Handles rdb2To4People.CheckedChanged
        lblRecommended.Text = "50 tokens"
    End Sub
    Private Sub rdb5To7People_CheckedChanged(sender As Object, e As EventArgs) Handles rdb5To7People.CheckedChanged
        lblRecommended.Text = "110 tokens"
    End Sub
    Private Sub rdb8OrMorePeople_CheckedChanged(sender As Object, e As EventArgs) Handles rdb8OrMorePeople.CheckedChanged
        lblRecommended.Text = "140 tokens"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim tokens As Integer
        Dim total As Decimal

        If txtTokens.Text = Nothing Or IsNumeric(txtTokens.Text) = False Then
            MessageBox.Show("How many tokens do you wish to purchase?", "How many tokens?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            tokens = txtTokens.Text

            Select Case tokens
                Case 1 To 59
                    total = tokens * 0.5
                Case 49 To 99
                    total = tokens * 0.5 * 0.9
                Case 100 To 199
                    total = tokens * 0.5 * 0.85
                Case 200 To 499
                    total = tokens * 0.5 * 0.75
                Case Else
                    total = tokens * 0.5 * 0.6
            End Select

            tokensLeft = tokens
            acceptable = True
            lblTotal.Text = "Total: " & FormatCurrency(FormatNumber(total, 2))
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If acceptable = False Then
            MessageBox.Show("How many tokens do you wish to purchase?", "How many tokens?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmFaizanGameSelection.Show()
            Me.Close()
        End If
    End Sub
End Class