Public Class frmMuhammadMemoryGame
    Private secondsLook, rightAnswer As Integer
    Private secondsHide As Integer = 10
    Private numArray(11) As Integer
    Private rand As New Random

    Private Sub frmMuhammadMemoryGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to Magic Memory" & vbNewLine & "12 images will appear when you press 'Show Items'" & vbNewLine & "The longer you take to memorize the locations of the images, the fewer tickets you could win. " & "Press hide images and you will be asked where an image is located" & vbNewLine & "Pick the correct location and you win!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}
        Dim repeats(11) As Integer

        'Checks to see if the user has enough tokens (important for when the user is playing the game again)
        If tokensLeft < 3 Then
            MessageBox.Show("You don't have enough tokens", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        btnReturn.Enabled = False

        'Assigns each picbox a number that corresponds to an images
        For i = 0 To picArray.Length - 1
            numArray(i) = rand.Next(1, 17)

            'Checks to make sure no images repeat
            Do
                If repeats.Contains(numArray(i)) Then
                    numArray(i) = rand.Next(1, 17)
                Else
                    repeats(i) = numArray(i)
                    Exit Do
                End If
            Loop

            'Gives the picturebox an images based on the number given to it earlier
            Call ShowAll()
        Next

        btnShow.Enabled = False
        btnHide.Enabled = True
        tmrLook.Start()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        btnHide.Enabled = False
        Call HideImages()

        'Checks to see if the item the user will be asked to click is 1 of the 12 generated items
        Do
            rightAnswer = rand.Next(1, 17)

            If numArray.Contains(rightAnswer) Then
                Exit Do
            End If
        Loop

        'Decides which item the user should click on to win
        Select Case rightAnswer
            Case 1
                MessageBox.Show("Where was the apple located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Where was the backpack located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("Where was the boom located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show("Where was the cookie located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                MessageBox.Show("Where was the dog located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 6
                MessageBox.Show("Where was the donut located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 7
                MessageBox.Show("Where was goku located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 8
                MessageBox.Show("Where was ironman located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 9
                MessageBox.Show("Where was the moon located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 10
                MessageBox.Show("Where was naruto located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 11
                MessageBox.Show("Where was the phone located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 12
                MessageBox.Show("Where was the shirt located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 13
                MessageBox.Show("Where was the soccer ball located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 14
                MessageBox.Show("Where was the star located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 15
                MessageBox.Show("Where was the unicorn located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 16
                MessageBox.Show("Where was the USB located?", "QUESTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        tmrGuess.Start()
    End Sub

    Private Sub picItem0_Click(sender As Object, e As EventArgs) Handles picItem0.Click, picItem1.Click, picItem2.Click, picItem3.Click, picItem4.Click, picItem5.Click, picItem6.Click, picItem7.Click, picItem8.Click, picItem9.Click, picItem10.Click, picItem11.Click
        Dim picSender As PictureBox = sender
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}
        Dim selectedImage, ticketsWon As Integer

        tmrGuess.Stop()

        'Shows the image that was hidden in the clicked picturebox
        Select Case numArray(picSender.Tag)
            Case 1
                picSender.Image = My.Resources.apple
            Case 2
                picSender.Image = My.Resources.backpack
            Case 3
                picSender.Image = My.Resources.boom
            Case 4
                picSender.Image = My.Resources.cookie
            Case 5
                picSender.Image = My.Resources.dog
            Case 6
                picSender.Image = My.Resources.donut
            Case 7
                picSender.Image = My.Resources.goku
            Case 8
                picSender.Image = My.Resources.ironman
            Case 9
                picSender.Image = My.Resources.moon
            Case 10
                picSender.Image = My.Resources.naruto
            Case 11
                picSender.Image = My.Resources.phone
            Case 12
                picSender.Image = My.Resources.shirtMuhammad
            Case 13
                picSender.Image = My.Resources.soccer
            Case 14
                picSender.Image = My.Resources.star
            Case 15
                picSender.Image = My.Resources.unicorn
            Case 16
                picSender.Image = My.Resources.usb
        End Select

        selectedImage = numArray(picSender.Tag)

        'Checks to see whether you clicked on the right image
        If selectedImage = rightAnswer Then
            MessageBox.Show("WINNER WINNER CHICKEN DINNER!", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("LOSER LOSER BEGGERS CAN'T BE CHOOSERS!", "YOU LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Call ShowAll()
        tokensLeft -= 3 'Cost of game
        btnReturn.Enabled = True

        'Awards the user points based on the time they took to memorize the location of the items
        If selectedImage = rightAnswer Then
            Select Case secondsLook
                Case 1 To 2
                    ticketsWon = 100
                Case 3 To 15
                    ticketsWon = 60
                Case 16 To 25
                    ticketsWon = 40
                Case Else
                    ticketsWon = 20
            End Select
        End If

        'Updates the user on their total tickets and tokens
        ticketsTotal += ticketsWon
        MessageBox.Show("You won " & ticketsWon & " tickets!" & vbNewLine & "You have " & tokensLeft & " tokens left and " & ticketsTotal & " total tickets.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Reset()

        For i = 0 To picArray.Length - 1
            picArray(i).Image = Nothing
            picArray(i).Enabled = False
        Next
    End Sub

    Private Sub tmrLook_Tick(sender As Object, e As EventArgs) Handles tmrLook.Tick
        secondsLook += 1
        lblLook.Text = secondsLook
    End Sub

    Private Sub tmrGuess_Tick(sender As Object, e As EventArgs) Handles tmrGuess.Tick
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}

        If secondsHide = 0 Then
            tmrGuess.Stop()
            Call ShowAll()
            MessageBox.Show("Times Up! Sadly, you won 0 tickets", "TIMES UP", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call HideImages()
            Call Reset()
            Exit Sub
        End If

        secondsHide -= 1
        lblGuess.Text = secondsHide
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmFaizanGameSelection.Show()
        Me.Close()
    End Sub

    'This procedure resets the game by resetting the scores and disabling the picBoxes until show items is clicked  
    Private Sub Reset()
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}

        btnHide.Enabled = False
        btnShow.Enabled = True
        secondsHide = 10
        secondsLook = 0
        lblLook.Text = 0
        lblGuess.Text = 10

        For i = 0 To picArray.Length - 1
            picArray(i).Enabled = False
        Next
    End Sub

    'This procedure shows the items under each picBox
    Private Sub ShowAll()
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}

        'Shows all of the images to the user
        For i = 0 To numArray.Length - 1
            Select Case numArray(i)
                Case 1
                    picArray(i).Image = My.Resources.apple
                Case 2
                    picArray(i).Image = My.Resources.backpack
                Case 3
                    picArray(i).Image = My.Resources.boom
                Case 4
                    picArray(i).Image = My.Resources.cookie
                Case 5
                    picArray(i).Image = My.Resources.dog
                Case 6
                    picArray(i).Image = My.Resources.donut
                Case 7
                    picArray(i).Image = My.Resources.goku
                Case 8
                    picArray(i).Image = My.Resources.ironman
                Case 9
                    picArray(i).Image = My.Resources.moon
                Case 10
                    picArray(i).Image = My.Resources.naruto
                Case 11
                    picArray(i).Image = My.Resources.phone
                Case 12
                    picArray(i).Image = My.Resources.shirtMuhammad
                Case 13
                    picArray(i).Image = My.Resources.soccer
                Case 14
                    picArray(i).Image = My.Resources.star
                Case 15
                    picArray(i).Image = My.Resources.unicorn
                Case 16
                    picArray(i).Image = My.Resources.usb
            End Select
        Next
    End Sub

    'This procedure hides the images and makes them enabled so that the user can click on the answer 
    Private Sub HideImages()
        Dim picArray() As PictureBox = {picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6, picItem7, picItem8, picItem9, picItem10, picItem11}

        For i = 0 To picArray.Length - 1
            picArray(i).Image = Nothing
            picArray(i).Enabled = True
            tmrLook.Stop()
        Next
    End Sub
End Class