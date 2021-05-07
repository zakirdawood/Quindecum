Public Class frmZakirSpotIt
    Private num As Integer
    Private time As Integer = 30
    Private numArray(34) As Integer
    Private score As Integer
    Private objective As Integer
    Private tickets As Integer
    Private finalTickets As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If tokensLeft < 3 Then
            MessageBox.Show("You do not have enough tokens!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim rand As New Random
        Dim search As String = Nothing

        'Resets everything
        time = 30
        num = 1
        score = 0
        tickets = 0
        lblScoreOut.Text = 0
        lblTicketsOut.Text = 0
        lblTimeOut.Text = time
        objective = rand.Next(1, 11)

        'Assigns string for the messagebox according to integer
        Select Case objective
            Case 1
                search = "Book"
            Case 2
                search = "Car"
            Case 3
                search = "Drink"
            Case 4
                search = "Penguin"
            Case 5
                search = "phone"
            Case 6
                search = "Pikachu"
            Case 7
                search = "School"
            Case 8
                search = "Shirt"
            Case 9
                search = "Shoes"
            Case 10
                search = "Soccer Ball"
        End Select

        MessageBox.Show("The object you must spot is: " & search, "Objective", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tmrGame.Enabled = True
        btnStart.Enabled = False
        btnExit.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Tickets earned through all games: " & finalTickets, "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        frmFaizanGameSelection.Show()
    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        Dim picArr() As PictureBox = {picSquare1, picSquare2, picSquare3, picSquare4, picSquare5, picSquare6, picSquare7, picSquare8, picSquare9, picSquare10, picSquare11, picSquare12, picSquare13, picSquare14, picSquare15, picSquare16, picSquare17, picSquare18, picSquare19, picSquare20, picSquare21, picSquare22, picSquare23, picSquare24, picSquare25, picSquare26, picSquare27, picSquare28, picSquare29, picSquare30, picSquare31, picSquare32, picSquare33, picSquare34, picSquare35}
        Dim rand As New Random

        lblTimeOut.Text = time
        time -= 1
        num -= 1

        'Randomizes objects for each image.
        If num = 0 Then
            For i = 0 To picArr.Length - 1
                numArray(i) = rand.Next(1, 11)
                picArr(i).Enabled = True
            Next

            Call showAll()
            num = 4
        End If

        'Deletes all images, this is done to ensure the program does not experience difficulty in switching images quickly.
        If num = 1 Then
            For i = 0 To picArr.Length - 1
                picArr(i).Image = Nothing
            Next
        End If

        'When the time is up, this all happens.
        If time = -1 Then
            tmrGame.Enabled = False
            For i = 0 To picArr.Length - 1
                picArr(i).Image = Nothing
                picArr(i).Enabled = False
            Next
            btnStart.Enabled = True
            btnExit.Enabled = True
            ticketsTotal += tickets
            MessageBox.Show("Game over, tickets earned: " & tickets, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub picSquare1_Click(sender As Object, e As EventArgs) Handles picSquare1.Click, picSquare2.Click, picSquare3.Click, picSquare4.Click, picSquare5.Click, picSquare6.Click, picSquare7.Click, picSquare8.Click, picSquare9.Click, picSquare10.Click, picSquare11.Click, picSquare11.Click, picSquare12.Click, picSquare13.Click, picSquare14.Click, picSquare15.Click, picSquare16.Click, picSquare17.Click, picSquare18.Click, picSquare19.Click, picSquare20.Click, picSquare21.Click, picSquare22.Click, picSquare23.Click, picSquare24.Click, picSquare25.Click, picSquare26.Click, picSquare27.Click, picSquare28.Click, picSquare29.Click, picSquare30.Click, picSquare31.Click, picSquare32.Click, picSquare33.Click, picSquare34.Click, picSquare35.Click
        Dim picArr() As PictureBox = {picSquare1, picSquare2, picSquare3, picSquare4, picSquare5, picSquare6, picSquare7, picSquare8, picSquare9, picSquare10, picSquare11, picSquare12, picSquare13, picSquare14, picSquare15, picSquare16, picSquare17, picSquare18, picSquare19, picSquare20, picSquare21, picSquare22, picSquare23, picSquare24, picSquare25, picSquare26, picSquare27, picSquare28, picSquare29, picSquare30, picSquare31, picSquare32, picSquare33, picSquare34, picSquare35}
        Dim picSender As PictureBox = sender

        'For every correct click, tickets are won.
        If numArray(picSender.Tag) = objective Then
            score += 1
            tickets += 4
            finalTickets += 4
            lblTicketsOut.Text = tickets
            lblScoreOut.Text = score
        End If

        picArr(picSender.Tag).Enabled = False
    End Sub

    Private Sub showAll()
        Dim picArr() As PictureBox = {picSquare1, picSquare2, picSquare3, picSquare4, picSquare5, picSquare6, picSquare7, picSquare8, picSquare9, picSquare10, picSquare11, picSquare12, picSquare13, picSquare14, picSquare15, picSquare16, picSquare17, picSquare18, picSquare19, picSquare20, picSquare21, picSquare22, picSquare23, picSquare24, picSquare25, picSquare26, picSquare27, picSquare28, picSquare29, picSquare30, picSquare31, picSquare32, picSquare33, picSquare34, picSquare35}

        'Displays images.
        For i = 0 To numArray.Length - 1
            Select Case numArray(i)
                Case 1
                    picArr(i).Image = My.Resources.book
                Case 2
                    picArr(i).Image = My.Resources.car
                Case 3
                    picArr(i).Image = My.Resources.drink
                Case 4
                    picArr(i).Image = My.Resources.penguin
                Case 5
                    picArr(i).Image = My.Resources.phone
                Case 6
                    picArr(i).Image = My.Resources.pikachu
                Case 7
                    picArr(i).Image = My.Resources.school
                Case 8
                    picArr(i).Image = My.Resources.shirt
                Case 9
                    picArr(i).Image = My.Resources.shoes
                Case 10
                    picArr(i).Image = My.Resources.soccerball
            End Select
        Next
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instructions
        MessageBox.Show("This game will cost you 3 tokens. In this game, you must look for an object that is told to you. There are 35 objects on screen and you must click on your object. On object can appear multiple times in one phase. Click on all of them. You will get three seconds to find these objects before the pictures reset. Each object found is worth 4 tickets. You cannot exit the game once it has started. Good luck!", "Spot It", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class