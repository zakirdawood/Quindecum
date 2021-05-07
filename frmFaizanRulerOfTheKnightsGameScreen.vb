Imports System.Threading
Public Class frmFaizanRulerOfTheKnightsGameScreen
    Private playerHealth, computerHealth, compCharacter, computerDamage, damage As Integer
    Private Sub frmFaizanRulerOfTheKnightsGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random

        MessageBox.Show("Select a move to attack your opponent with.", "Let the Fight Begin", MessageBoxButtons.OK, MessageBoxIcon.Information)
SameCharacterFix:
        If playerCharacter = 1 Then
            grpMoveSelection.Text = "What will Sir Lancelot do?"
            picPlayerCharacter.Image = My.Resources.SirLancelot
            btnMove1.Text = "Fury Slash"
            btnMove2.Text = "Potion of Health"
            btnMove3.Text = "Knight Slayer"
        ElseIf playerCharacter = 2 Then
            grpMoveSelection.Text = "What will Arthur Leblanc do?"
            picPlayerCharacter.Image = My.Resources.ArthurLeBlanc
            btnMove1.Text = "Joust"
            btnMove2.Text = "Slash of Excalibur"
            btnMove3.Text = "Second Form"
        ElseIf playerCharacter = 3 Then
            grpMoveSelection.Text = "What will Gareth Bale do?"
            picPlayerCharacter.Image = My.Resources.GarethBale
            btnMove1.Text = "Full Counter"
            btnMove2.Text = "Jajaken"
            btnMove3.Text = "Cruel Sun"
        End If

        compCharacter = rand.Next(1, 3)

        If compCharacter = 1 Then
            picComCharacter.Image = My.Resources.SirLancelot
        ElseIf compCharacter = 2 Then
            picComCharacter.Image = My.Resources.ArthurLeBlanc
        Else
            picComCharacter.Image = My.Resources.GarethBale
        End If

        If playerCharacter = compCharacter Then
            GoTo SameCharacterFix
        End If
    End Sub

    Private Sub btnMove1_Click(sender As Object, e As EventArgs) Handles btnMove1.Click
        Dim chance As Integer
        Dim chanceNeeded As Boolean
        Dim rand As New Random

        playerHealth = prgPlayerHealth.Value
        computerHealth = prgComputerHealth.Value

        'Fury Slash move for Sir Lancelot
        If btnMove1.Text = "Fury Slash" Then
            damage = 30
            Do
                If prgComputerHealth.Value = 0 Then
                    Exit Sub
                End If

                prgComputerHealth.Value -= 1
                If prgComputerHealth.Value = 0 Then
                    MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                    ticketsTotal += 100
                    frmFaizanGameSelection.Show()
                    Me.Close()
                End If
                Thread.Sleep(25)
            Loop Until computerHealth - prgComputerHealth.Value = 30

            computerHealth -= 30
        End If

        'Full Counter move for Arthur LeBlanc
        If btnMove1.Text = "Full Counter" Then
            damage = computerDamage
            Do
                If prgComputerHealth.Value = 0 Then
                    Exit Sub
                End If

                prgComputerHealth.Value -= 1
                If prgComputerHealth.Value = 0 Then
                    MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                    ticketsTotal += 100
                    frmFaizanGameSelection.Show()
                    Me.Close()
                End If
                Thread.Sleep(25)
            Loop Until computerHealth - prgComputerHealth.Value = computerDamage

            computerHealth -= computerDamage
        End If

        'Joust move for Arthur LeBlanc
        If btnMove1.Text = "Joust" Then
            chanceNeeded = True
            GoTo ChanceOfSucess
        End If

ChanceOfSucess:
        If chanceNeeded = True Then
            chance = rand.Next(1, 10)

            'Joust move for Arthur LeBlanc
            If chance > 5 Then
                damage = 45
                Do
                    If prgComputerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgComputerHealth.Value -= 1
                    If prgComputerHealth.Value = 0 Then
                        MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        ticketsTotal += 100
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until computerHealth - prgComputerHealth.Value = 45

                computerHealth -= 45

                lblComputerHealth.Text = "Health: " & computerHealth
            End If
        End If

        lblPlayerHealth.Text = "Health: " & playerHealth
        lblComputerHealth.Text = "Health: " & computerHealth
        MessageBox.Show("You dealt " & damage & " damage to opponent!", "Damage Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Thread.Sleep(100)
        Call ComputerTurn()
    End Sub

    Private Sub btnMove2_Click(sender As Object, e As EventArgs) Handles btnMove2.Click
        Dim chance As Integer
        Dim chanceNeeded As Boolean
        Dim rand As New Random

        playerHealth = prgPlayerHealth.Value
        computerHealth = prgComputerHealth.Value

        'Potion of Health move for Sir Lancelot
        If btnMove2.Text = "Potion of Health" Then
            damage = 0
            Do
                If prgPlayerHealth.Value = 100 Then
                    MessageBox.Show("You already have full health", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call ComputerTurn()
                    Exit Sub
                End If

                prgPlayerHealth.Value += 1
                Thread.Sleep(25)
            Loop Until prgPlayerHealth.Value - playerHealth = 40

            playerHealth += 40

            If playerHealth > 100 Then
                playerHealth = 100
            End If
        End If

        'Slash of Excaliber move for Arthur LeBlanc
        If btnMove2.Text = "Slash of Excalibur" Then
            damage = 35
            Do
                If prgComputerHealth.Value = 0 Then
                    Exit Sub
                End If

                prgComputerHealth.Value -= 1
                If prgComputerHealth.Value = 0 Then
                    MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                    ticketsTotal += 100
                    frmFaizanGameSelection.Show()
                    Me.Close()
                End If
                Thread.Sleep(25)
            Loop Until computerHealth - prgComputerHealth.Value = 35

            computerHealth -= 35
        End If

        'Jajaken move for Gareth Bale
        If btnMove2.Text = "Jajaken" Then
            chanceNeeded = True
            GoTo ChanceOfSucess
        End If

ChanceOfSucess:
        If chanceNeeded = True Then
            chance = rand.Next(1, 9)

            'Jajaken move
            If chance >= 1 And chance <= 3 Then
                damage = 20
                Do
                    If prgComputerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgComputerHealth.Value -= 1
                    If prgComputerHealth.Value = 0 Then
                        MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        ticketsTotal += 100
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until computerHealth - prgComputerHealth.Value = 20

                computerHealth -= 20
            ElseIf chance > 3 And chance <= 6 Then
                damage = 30
                Do
                    If prgComputerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgComputerHealth.Value -= 1
                    If prgComputerHealth.Value = 0 Then
                        MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        ticketsTotal += 100
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until computerHealth - prgComputerHealth.Value = 30

                computerHealth -= 30
            Else
                damage = 40
                Do
                    If prgComputerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgComputerHealth.Value -= 1
                    If prgComputerHealth.Value = 0 Then
                        MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        ticketsTotal += 100
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until computerHealth - prgComputerHealth.Value = 40

                computerHealth -= 40
            End If
        End If

        lblPlayerHealth.Text = "Health: " & playerHealth
        lblComputerHealth.Text = "Health: " & computerHealth
        MessageBox.Show("You dealt " & damage & " damage to opponent!", "Damage Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Thread.Sleep(100)
        Call ComputerTurn()
    End Sub

    Private Sub btnMove3_Click(sender As Object, e As EventArgs) Handles btnMove3.Click
        Dim rand As New Random

        playerHealth = prgPlayerHealth.Value
        computerHealth = prgComputerHealth.Value

        If prgComputerHealth.Value = 0 Then
            Exit Sub
        End If

        'Knight Slayer move for Sir Lancelot
        If btnMove3.Text = "Knight Slayer" Then
            damage = 50
            Do
                If prgComputerHealth.Value = 0 Then
                    Exit Sub
                End If

                prgComputerHealth.Value -= 1
                If prgComputerHealth.Value = 0 Then
                    MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                    ticketsTotal += 100
                    frmFaizanGameSelection.Show()
                    Me.Close()
                End If
                Thread.Sleep(25)
            Loop Until computerHealth - prgComputerHealth.Value = 50

            computerHealth -= 50
        End If

        'Cruel Sun move for Gareth Bale
        If btnMove3.Text = "Cruel Sun" Then
            damage = 60
            Do
                If prgComputerHealth.Value = 0 Then
                    Exit Sub
                End If

                prgComputerHealth.Value -= 1
                If prgComputerHealth.Value = 0 Then
                    MessageBox.Show("You have defeated the computer." & vbNewLine & "You receive 100 tickets.", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.None)
                    ticketsTotal += 100
                    frmFaizanGameSelection.Show()
                    Me.Close()
                End If
                Thread.Sleep(25)
            Loop Until computerHealth - prgComputerHealth.Value = 60

            computerHealth -= 60
        End If

        'Second Form move for Arthur LeBlanc
        If btnMove3.Text = "Second Form" Then
            damage += 5
        End If

        lblPlayerHealth.Text = "Health: " & playerHealth
        lblComputerHealth.Text = "Health: " & computerHealth
        MessageBox.Show("You dealt " & damage & " damage to opponent!", "Damage Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Thread.Sleep(100)
        Call ComputerTurn()
    End Sub

    'This procedure determines the Computer's Move....
    Private Sub ComputerTurn()
        Dim move, chance As Integer
        Dim rand As New Random
        Dim chanceNeeded, chanceNeededTwo As Boolean

        If compCharacter = 1 Then
            'Sir Lancelot
            move = rand.Next(1, 3)

            If move = 1 Then
                computerDamage = 30
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 30

                playerHealth -= 30
            ElseIf move = 2 Then
                computerDamage = 0
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    If prgComputerHealth.Value = 100 Then
                        Exit Sub
                    End If
                    prgComputerHealth.Value += 1
                    Thread.Sleep(25)
                Loop Until prgComputerHealth.Value - computerHealth = 40

                If computerHealth > 100 Then
                    computerHealth = 100
                End If
            Else
                computerDamage = 50
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 50

                playerHealth -= 50
            End If

        ElseIf compCharacter = 2 Then
            'Arthur LeBlanc
            move = rand.Next(1, 3)

            If move = 1 Then
                chanceNeeded = True
                GoTo ChanceOfSucess
            ElseIf move = 2 Then
                computerDamage = 35
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 35

                playerHealth -= 35
            Else
                computerDamage += 5
            End If

        Else
            'Gareth Bale
            move = rand.Next(1, 3)

            If move = 1 Then
                computerDamage = damage
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = damage

                playerHealth -= damage
            ElseIf move = 2 Then
                chanceNeededTwo = True
                GoTo ChanceOfSucessTwo
            Else
                computerDamage = 60
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 60

                playerHealth -= 60
            End If
        End If

ChanceOfSucess:
        If chanceNeeded = True Then
            chance = rand.Next(1, 10)

            'Joust move for Arthur LeBlanc
            If chance > 5 Then
                computerDamage = 45
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 45

                playerHealth -= 45

                lblComputerHealth.Text = "Health: " & computerHealth
            End If
        End If

ChanceOfSucessTwo:
        If chanceNeededTwo = True Then
            chance = rand.Next(1, 9)

            'Jajaken move
            If chance >= 1 And chance <= 3 Then
                computerDamage = 20
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 20

                playerHealth -= 20
            ElseIf chance > 3 And chance <= 6 Then
                computerDamage = 30
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 30

                playerHealth -= 30
            Else
                computerDamage = 40
                Do
                    If prgPlayerHealth.Value = 0 Then
                        Exit Sub
                    End If

                    prgPlayerHealth.Value -= 1
                    If prgPlayerHealth.Value = 0 Then
                        MessageBox.Show("You have been defeated by the computer." & vbNewLine & "You receive 0 tickets.", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None)
                        frmFaizanGameSelection.Show()
                        Me.Close()
                    End If
                    Thread.Sleep(25)
                Loop Until playerHealth - prgPlayerHealth.Value = 40

                playerHealth -= 40
            End If
        End If

        lblPlayerHealth.Text = "Health: " & playerHealth
        lblComputerHealth.Text = "Health: " & computerHealth
        MessageBox.Show("Computer dealt " & computerDamage & " damage to you!", "Damage Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
    End Sub
End Class