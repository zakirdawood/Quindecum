Public Class frmMuhammadRace
    Private XMelissa, XMiranda, XShadow, XJumper, XLegend, type As Integer
    Private racer, tokens As String

    Private Sub frmMuhammadRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the Old Town Derby" & vbNewLine & "Start by betting on the horse of your choice and" & vbNewLine & "betting the desired amount of tokens." & vbNewLine & "Good Luck!", "Old Town Derby", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim rand As New Random

        XMelissa = 66
        XMiranda = 61
        XShadow = 31
        XJumper = 18
        XLegend = 14
        type = 0

        Do
            racer = InputBox("Who are you going to be betting on?")

            If racer = "" Then
                Exit Sub
            End If

            racer = Trim(racer)
            racer = StrConv(racer, vbProperCase)

            If racer = "Melissa" Or racer = "Miranda" Or racer = "Shadow" Or racer = "Legend" Or racer = "Jumper" Then
                Exit Do
            End If
        Loop

        Do
            tokens = InputBox("How many tokens are you betting (1-12 tokens)?")

            If IsNumeric(tokens) = False Then
                MessageBox.Show("Non-Numberic Input!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tokens > tokensLeft Then
                MessageBox.Show("You don't have that many tokens", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tokens < 1 Or tokens > 12 Then
                MessageBox.Show("Out of the betting range!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tokensLeft -= tokens
                btnStart.Enabled = False
                btnReturn.Enabled = False
                Exit Do
            End If
        Loop

        lblTitleMelissa.Hide()
        lblTitleMiranda.Hide()
        lblTitleJumper.Hide()
        lblTitleShadow.Hide()
        lblTitleLegend.Hide()
        lblTitle.Hide()

        tmrMelissa.Interval = rand.Next(1, 100)
        tmrMelissa.Start()

        tmrMiranda.Interval = rand.Next(1, 100)
        tmrMiranda.Start()

        tmrShadow.Interval = rand.Next(1, 100)
        tmrShadow.Start()

        tmrJumper.Interval = rand.Next(1, 100)
        tmrJumper.Start()

        tmrLegend.Interval = rand.Next(1, 100)
        tmrLegend.Start()

        type = 1
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmFaizanGameSelection.Show()
    End Sub

    Private Sub tmrMelissa_Tick(sender As Object, e As EventArgs) Handles tmrMelissa.Tick
        XMelissa += 20
        picMelissa.Location = New Point(XMelissa, 39)
        Call CheckWinner(XMelissa, tmrMelissa, "Melissa", 1016)
    End Sub

    Private Sub tmrMiranda_Tick(sender As Object, e As EventArgs) Handles tmrMiranda.Tick
        XMiranda += 20
        picMiranda.Location = New Point(XMiranda, 161)
        Call CheckWinner(XMiranda, tmrMiranda, "Miranda", 1009)
    End Sub

    Private Sub tmrShadow_Tick(sender As Object, e As EventArgs) Handles tmrShadow.Tick
        XShadow += 20
        picShadow.Location = New Point(XShadow, 275)
        Call CheckWinner(XShadow, tmrShadow, "Shadow", 978)
    End Sub

    Private Sub tmrJumper_Tick(sender As Object, e As EventArgs) Handles tmrJumper.Tick
        XJumper += 20
        picJumper.Location = New Point(XJumper, 383)
        Call CheckWinner(XJumper, tmrJumper, "Jumper", 965)
    End Sub

    Private Sub tmrLegend_Tick(sender As Object, e As EventArgs) Handles tmrLegend.Tick
        XLegend += 20
        picLegend.Location = New Point(XLegend, 524)
        Call CheckWinner(XLegend, tmrLegend, "Legend", 961)
    End Sub

    'This private sub determines which racer one and whether or not you bet on the right horse
    Private Sub CheckWinner(ByRef horse As Integer, timer As Timer, winner As String, finish As Integer)
        Dim ticketsWon As Integer

        If horse > finish Then
            timer.Stop()

            If type = 1 Then
                type += 1

                If type = 2 Then
                    MessageBox.Show(winner & " is the winner", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If winner = racer Then
                        Select Case tokens
                            Case 1
                                ticketsWon = 15
                            Case 2
                                ticketsWon = 30
                            Case 3
                                ticketsWon = 45
                            Case 4
                                ticketsWon = 60
                            Case 5
                                ticketsWon = 75
                            Case 6
                                ticketsWon = 90
                            Case 7
                                ticketsWon = 105
                            Case 8
                                ticketsWon = 120
                            Case 9
                                ticketsWon = 140
                            Case 10
                                ticketsWon = 160
                            Case 11
                                ticketsWon = 180
                            Case 12
                                ticketsWon = 200
                        End Select

                        ticketsTotal += ticketsWon
                    Else
                        MessageBox.Show("Sadly you lost...", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    MessageBox.Show("You won " & ticketsWon & " tickets!" & vbNewLine & "You have " & tokensLeft & " tokens left and " & ticketsTotal & " total tickets.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lblTitleMelissa.Show()
                    lblTitleMiranda.Show()
                    lblTitleJumper.Show()
                    lblTitleShadow.Show()
                    lblTitleLegend.Show()
                    lblTitle.Show()

                    picMelissa.Location = New Point(66, 39)
                    picMiranda.Location = New Point(61, 161)
                    picShadow.Location = New Point(31, 275)
                    picJumper.Location = New Point(18, 383)
                    picLegend.Location = New Point(14, 524)
                    btnReturn.Enabled = True
                    btnStart.Enabled = True
                End If
            End If
        End If
    End Sub
End Class