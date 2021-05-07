Public Class frmZakirPrizes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim cost As Integer
        Dim count As Integer

        If chkFidget.Checked = True Then
            cost += 400
            count += 1
        End If

        If chkPs4.Checked = True Then
            cost += 6000
            count += 1
        End If

        If chkRaptors.Checked = True Then
            cost += 3000
            count += 1
        End If

        If chkPikachu.Checked = True Then
            cost += 1200
            count += 1
        End If

        If chkFoodPass.Checked = True Then
            cost += 2000
            count += 1
        End If

        If chkSticker.Checked = True Then
            cost += 400
            count += 1
        End If

        If chkAmazon.Checked = True Then
            cost += 1500
              count += 1
        End If

        If chkIphone.Checked = True Then
            cost += 10000
            count += 1
        End If

        If chkWonderland.Checked = True Then
            cost += 3000
            count += 1
        End If

        If chkCineplex.Checked = True Then
            cost += 1300
            count += 1
        End If

        'If no checkboxes have been checked, this error will pop up.
        If count = 0 Then
            MessageBox.Show("Please select a prize to take home.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cost > ticketsTotal Then
                MessageBox.Show("You do not have enough tickets to purchase this.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ticketsTotal -= cost
                MessageBox.Show("Your items will be delivered to you in 7-10 business days. Enjoy your day.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        lblTicketsOut.Text = ticketsTotal
        count = 0
        chkAmazon.Checked = False
        chkCineplex.Checked = False
        chkFidget.Checked = False
        chkFoodPass.Checked = False
        chkIphone.Checked = False
        chkPikachu.Checked = False
        chkPs4.Checked = False
        chkRaptors.Checked = False
        chkSticker.Checked = False
        chkWonderland.Checked = False
    End Sub

    Private Sub frmZakirPrizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTicketsOut.Text = ticketsTotal
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class