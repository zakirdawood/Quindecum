'***************************************************************************************
' PROGRAMME	    :	FINAL PROJECT Quindecum
'  
' OUTLINE		:	This program simulates an arcade with various minigames and a prize 
'                   booth. The arcade has a token purchasing system and a ticket earning
'                   system. The user must agree and enter personal information before
'                   proceeding to the minigames.
'                   
'  PROGRAMMER	:	Muhammad Ali, Zakir Dawood, Faizan Siddiqui 
'
'  DATE		    :	June 7, 2019
' **************************************************************************************
Public Class frmZakirAgreement
    Private Sub btnNextOne_Click(sender As Object, e As EventArgs) Handles btnNextOne.Click
        If chkAge.Checked = True And chkTerms.Checked = True Then
            frmZakirTOS.Close()
            Me.Hide()
            frmMuhammadInformation.Show()
        Else
            MessageBox.Show("Please agree to the terms and conditions of Quindecum and confirm your age.", "Denied Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnTOS_Click(sender As Object, e As EventArgs) Handles btnTOS.Click
        frmZakirTOS.Show()
    End Sub
End Class
