Imports System.Threading
Public Class frmFaizanReactionTest
    Private reactionTime As Decimal = 0
    Private clicks As Integer
    Private Sub tmrReactionTime_Tick(sender As Object, e As EventArgs) Handles tmrReactionTime.Tick
        Static seconds As Decimal = 0
        Static mSeconds As Decimal = 0

        seconds += 1

        mSeconds = seconds / 60
        reactionTime = FormatNumber(mSeconds, 3)
        lblTime.Text = "Time: " & reactionTime & " ms"
    End Sub

    Private Sub btnLetsPlay_Click(sender As Object, e As EventArgs) Handles btnLetsPlay.Click
        Dim startOrExit As Integer = 0
        Dim rand As New Random
        Dim num As Integer

        If tokensLeft < 1 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        startOrExit = MessageBox.Show("Are you ready to see if you are worthy?" & vbNewLine & "Click on the screen when the colour changes to green as fast as possible!", "Speedy's Reaction Test", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If startOrExit = DialogResult.No Then
            frmFaizanGameSelection.Show()
            Me.Close()
        Else
            BackgroundImage = Nothing
            BackColor = Color.Red
            lblInstructions.Hide()
            lblTitle.Hide()
            picSpeedy.Hide()
            btnLetsPlay.Hide()
            btnExit.Hide()
            btnRewards.Hide()

            num = rand.Next(10, 20)

            Thread.Sleep(num * 500)
            BackColor = Color.Green
            tmrReactionTime.Enabled = True
        End If
    End Sub

    Private Sub frmFaizanReactionTest_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim tickets As Integer = 0
        Dim playAgain As Integer = 0

        If reactionTime = Nothing Then
            tmrReactionTime.Enabled = False
            MessageBox.Show("Be patient and success will come to you....", "What did it cost", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Try Again!", "BE PATIENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BackColor = Color.Red
            btnLetsPlay_Click(clicks, e)
        ElseIf BackColor = Color.Green And tmrReactionTime.Enabled = True Then
            tmrReactionTime.Enabled = False

            If reactionTime < 0.1 Then
                tickets = 100
            ElseIf reactionTime >= 0.1 And reactionTime < 0.2 Then
                tickets = 50
            ElseIf reactionTime >= 0.2 And reactionTime <= 0.4 Then
                tickets = 15
            Else
                tickets = 2
            End If

            ticketsTotal += tickets

            playAgain = MessageBox.Show("Your reaction time was " & reactionTime & " ms" & vbNewLine & "Reward: " & tickets & " Tickets", "Nice Job!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            frmFaizanGameSelection.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRewards_Click(sender As Object, e As EventArgs) Handles btnRewards.Click
        MessageBox.Show("Reaction Time" & vbTab & vbTab & "Rewarded Tickets" & vbNewLine & "<0.100ms" & vbTab & vbTab & vbTab & "100 Tickets" & vbNewLine & "0.100ms - 0.200ms" & vbTab & vbTab & "50 Tickets" & vbNewLine & "0.200ms - 0.400ms" & vbTab & vbTab & "15 Tickets" & vbNewLine & ">0.400ms" & vbTab & vbTab & vbTab & "2 Tickets", "REWARDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmFaizanGameSelection.Show()
        Me.Close()
    End Sub

    Private Sub frmFaizanReactionTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This game will cost you 1 Token to play", "Token Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
