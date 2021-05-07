Public Class frmMuhammadInformation
    Private Sub btnNextTwo_Click(sender As Object, e As EventArgs) Handles btnNextTwo.Click
        Dim firstName, lastName, phoneNumber, creditCard, expiryDate, postalCode As String

        firstName = txtFirstName.Text
        Trim(firstName)
        firstName = StrConv(firstName, vbProperCase)

        lastName = txtLastName.Text
        Trim(lastName)
        lastName = StrConv(lastName, vbProperCase)

        postalCode = txtPostalCode.Text
        Trim(postalCode)

        phoneNumber = txtPhoneNumber.Text
        Trim(phoneNumber)

        creditCard = txtCreditCard.Text
        Trim(creditCard)

        expiryDate = txtExpiryDate.Text
        Trim(expiryDate)

        If ProperName(firstName) = False Then
            MessageBox.Show("Please enter a valid first name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Text = Nothing
            txtFirstName.Focus()
        ElseIf ProperName(lastName) = False Then
            MessageBox.Show("Please enter a valid last name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Text = Nothing
            txtLastName.Focus()
        ElseIf ProperPostalCode(postalCode) = False Then
            MessageBox.Show("Please enter a valid postal code (no spaces).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPostalCode.Focus()
            txtPostalCode.Text = Nothing
        ElseIf ProperNumber(phoneNumber) = False Or phoneNumber.Count <> 10 Then
            MessageBox.Show("Please enter a valid phone number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNumber.Focus()
            txtPhoneNumber.Text = Nothing
        ElseIf ProperNumber(creditCard) = False Or creditCard.Count <> 16 Then
            MessageBox.Show("Please enter a valid credit card number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCreditCard.Focus()
            txtCreditCard.Text = Nothing
        ElseIf ProperNumber(expiryDate) = False Or expiryDate.Count <> 4 Then
            MessageBox.Show("Please enter a valid expiry in MM/YY format (no spaces).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExpiryDate.Focus()
            txtExpiryDate.Text = Nothing
        Else
            frmZakirWelcome.Show()
            Me.Close()
        End If
    End Sub

    'This functions checks to see whether the input is acceptable as a name
    Private Function ProperName(inputName As String)
        Dim acceptableName As Boolean

        If inputName = Nothing Or inputName.Contains(" ") Then
            Return acceptableName
        End If

        Dim chars() As Char = inputName

        For Each c As Char In chars
            If Not Char.IsLetter(c) Then
                Return acceptableName
            Else
                acceptableName = True
                Return acceptableName
            End If
        Next
    End Function

    'This function checks to see whether the input is acceptable as a number
    Private Function ProperNumber(inputNumber As String)
        Dim acceptableNumber As Boolean

        Dim chars() As Char = inputNumber

        If inputNumber = Nothing Or inputNumber.Contains(" ") Then
            Return acceptableNumber
        End If

        For Each c As Char In chars
            If Not Char.IsLetter(c) Then
                acceptableNumber = True
                Return acceptableNumber
            Else
                Return acceptableNumber
            End If
        Next
    End Function

    'This function checks to see whether the input is acceptable as a postal code
    Private Function ProperPostalCode(inputPostal As String)
        Dim acceptablePostalCode As Boolean

        If inputPostal.Count <> 6 Or inputPostal.Contains(" ") Then
            Return acceptablePostalCode
        Else
            acceptablePostalCode = True
            Return acceptablePostalCode
        End If
    End Function
End Class