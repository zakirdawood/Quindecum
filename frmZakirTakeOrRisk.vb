Public Class frmZakirTakeOrRisk
    Private labelNum(48) As Integer
    Private tickets, tries, offer, finalTickets As Integer
    Private startEnabled As Boolean
    Private Sub Randomize()
        Dim labelArr() As Label = {lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine, lblTen, lblEleven, lblTwelve, lblThirteen, lblFourteen, lblFifteen, lblSixteen, lblSeventeen, lblEigtheen, lblNineteen, lblTwenty, lblTwentyOne, lblTwentyTwo, lblTwentyThree, lblTwentyFour, lblTwentyFive, lblTwentySix, lblTwentySeven, lblTwentyEight, lblTwentyNine, lblThirty, lblThirtyOne, lblThirtyTwo, lblThirtyThree, lblThirtyFour, lblThirtyFive, lblThirtySix, lblThirtySeven, lblThirtyEight, lblThirtyNine, lblForty, lblFortyOne, lblFortyTwo, lblFortyThree, lblFortyFour, lblFortyFive, lblFortySix, lblFortySeven, lblFortyEight, lblFortyNine}
        Dim rand As New Random
        Dim num As Integer
        Dim zeros(9) As Integer

        'Assigns random amount of tickets between 1 to 30
        For i = 0 To labelArr.Length - 1
            num = rand.Next(1, 31)
            labelNum(i) = num
        Next

        'Assigns 0 tickets to 10 labels.
        For i = 0 To zeros.Length - 1
            num = rand.Next(1, 49)
            labelNum(num) = 0
        Next

        'Assigns super bonus of 250 tickets.
        num = rand.Next(1, 49)
        labelNum(num) = 250
    End Sub

    Private Sub lblOne_Click(sender As Object, e As EventArgs) Handles lblOne.Click, lblTwo.Click, lblThree.Click, lblFour.Click, lblFive.Click, lblSix.Click, lblSeven.Click, lblEight.Click, lblNine.Click, lblTen.Click, lblEleven.Click, lblTwelve.Click, lblThirteen.Click, lblFourteen.Click, lblFifteen.Click, lblSixteen.Click, lblSeventeen.Click, lblEigtheen.Click, lblNineteen.Click, lblTwenty.Click, lblTwentyOne.Click, lblTwentyTwo.Click, lblTwentyThree.Click, lblTwentyFour.Click, lblTwentyFive.Click, lblTwentySix.Click, lblTwentySeven.Click, lblTwentyEight.Click, lblTwentyNine.Click, lblThirty.Click, lblThirtyOne.Click, lblThirtyTwo.Click, lblThirtyThree.Click, lblThirtyFour.Click, lblThirtyFive.Click, lblThirtySix.Click, lblThirtySeven.Click, lblThirtyEight.Click, lblThirtyNine.Click, lblForty.Click, lblFortyOne.Click, lblFortyTwo.Click, lblFortyThree.Click, lblFortyFour.Click, lblFortyFive.Click, lblFortySix.Click, lblFortySeven.Click, lblFortyEight.Click, lblFortyNine.Click
        Dim picSender As Label = sender
        Dim labelArr() As Label = {lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine, lblTen, lblEleven, lblTwelve, lblThirteen, lblFourteen, lblFifteen, lblSixteen, lblSeventeen, lblEigtheen, lblNineteen, lblTwenty, lblTwentyOne, lblTwentyTwo, lblTwentyThree, lblTwentyFour, lblTwentyFive, lblTwentySix, lblTwentySeven, lblTwentyEight, lblTwentyNine, lblThirty, lblThirtyOne, lblThirtyTwo, lblThirtyThree, lblThirtyFour, lblThirtyFive, lblThirtySix, lblThirtySeven, lblThirtyEight, lblThirtyNine, lblForty, lblFortyOne, lblFortyTwo, lblFortyThree, lblFortyFour, lblFortyFive, lblFortySix, lblFortySeven, lblFortyEight, lblFortyNine}
        Dim continueGame As Boolean = True

        btnTake.Enabled = False
        btnLeave.Enabled = True
        labelArr(picSender.Tag).BackColor = Nothing
        labelArr(picSender.Tag).Text = labelNum(picSender.Tag)
        labelArr(picSender.Tag).Enabled = False

        'If a you lose label is clicked, this happens.
        If labelNum(picSender.Tag) = 0 Then
            labelArr(picSender.Tag).Text = "You Lose!"
            tickets = 0
            tries = 0
            MessageBox.Show("You played yourself, no tickets earned, only tokens lost!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error)
            continueGame = False
            Call EndGame()
            GoTo StartTwo
        End If

        tries += 1
        tickets += labelNum(picSender.Tag)

        'Occurs when super bonus is clicked
        If labelNum(picSender.Tag) = 250 Then
            labelArr(picSender.Tag).Text = "250"
            tickets = 250
            tries = 0
            MessageBox.Show("Super Bonus Activated!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error)
            continueGame = False
            Call EndGame()
            GoTo StartTwo
        End If

startOne:
        If continueGame = False Then
            Call EndGame()
        End If
StartTwo:
        lblTickets.Text = tickets

        'Gives an offer after third attempt.
        If tries = 3 Then
            offer = tickets * 1.25
            tries = 0
            lblOfferOut.Text = offer & " tickets"
            btnTake.Enabled = True
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If tokensLeft < 5 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Randomizes labels.
        Call Randomize()
        Dim labelArr() As Label = {lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine, lblTen, lblEleven, lblTwelve, lblThirteen, lblFourteen, lblFifteen, lblSixteen, lblSeventeen, lblEigtheen, lblNineteen, lblTwenty, lblTwentyOne, lblTwentyTwo, lblTwentyThree, lblTwentyFour, lblTwentyFive, lblTwentySix, lblTwentySeven, lblTwentyEight, lblTwentyNine, lblThirty, lblThirtyOne, lblThirtyTwo, lblThirtyThree, lblThirtyFour, lblThirtyFive, lblThirtySix, lblThirtySeven, lblThirtyEight, lblThirtyNine, lblForty, lblFortyOne, lblFortyTwo, lblFortyThree, lblFortyFour, lblFortyFive, lblFortySix, lblFortySeven, lblFortyEight, lblFortyNine}

        For i = 0 To labelArr.Length - 1
            labelArr(i).Enabled = True
        Next

        tickets = 0
        btnStart.Enabled = False
        btnBack.Enabled = False
    End Sub

    Private Sub EndGame()
        Dim labelArr() As Label = {lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine, lblTen, lblEleven, lblTwelve, lblThirteen, lblFourteen, lblFifteen, lblSixteen, lblSeventeen, lblEigtheen, lblNineteen, lblTwenty, lblTwentyOne, lblTwentyTwo, lblTwentyThree, lblTwentyFour, lblTwentyFive, lblTwentySix, lblTwentySeven, lblTwentyEight, lblTwentyNine, lblThirty, lblThirtyOne, lblThirtyTwo, lblThirtyThree, lblThirtyFour, lblThirtyFive, lblThirtySix, lblThirtySeven, lblThirtyEight, lblThirtyNine, lblForty, lblFortyOne, lblFortyTwo, lblFortyThree, lblFortyFour, lblFortyFive, lblFortySix, lblFortySeven, lblFortyEight, lblFortyNine}

        MessageBox.Show("Game over, you earned " & tickets & " tickets", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
        startEnabled = True

        'Hides all labels again.
        For i = 0 To labelArr.Length - 1
            labelArr(i).BackColor = Color.Sienna
            labelArr(i).Text = Nothing
            labelArr(i).Enabled = False
        Next

        finalTickets += tickets

        lblOfferOut.Text = Nothing
        btnTake.Enabled = False
        btnLeave.Enabled = False
        btnStart.Enabled = True
        btnBack.Enabled = True
        tickets = 0
        tries = 0
        offer = 0

        For i = 0 To labelArr.Length - 1
            labelArr(i).Enabled = False
        Next
    End Sub

    Private Sub frmTakeOrRisk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instructions
        MessageBox.Show("Welcome to Take or Risk! This exciting minigame will cost you 5 tokens. Choose an unlimited number of boxes and try to win as many tickets as you can. There are nine cases that will result in no tickets being won. One box has the Super Bonus of 250 tickets. Quindecum will offer you a certain number of tickets every three tries. You may choose to quit the game and respectfully take your tickets at any time. Click the start button at the bottom to randomize the boxes. Good luck!", "Good Luck!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnTake_Click(sender As Object, e As EventArgs) Handles btnTake.Click
        tickets = offer
        lblTickets.Text = tickets
        Call EndGame()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ticketsTotal += finalTickets
        MessageBox.Show("You have won " & finalTickets & " tickets through your games.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        frmFaizanGameSelection.Show()
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        Call EndGame()
    End Sub
End Class
