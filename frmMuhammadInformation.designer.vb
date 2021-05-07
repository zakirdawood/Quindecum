<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuhammadInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuhammadInformation))
        Me.lblTitleFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblTitleLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblTitlePostalCode = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblTitlePhoneNumber = New System.Windows.Forms.Label()
        Me.lblTitleCreditCard = New System.Windows.Forms.Label()
        Me.btnNextTwo = New System.Windows.Forms.Button()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitleFirstName
        '
        Me.lblTitleFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleFirstName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFirstName.Location = New System.Drawing.Point(12, 28)
        Me.lblTitleFirstName.Name = "lblTitleFirstName"
        Me.lblTitleFirstName.Size = New System.Drawing.Size(234, 31)
        Me.lblTitleFirstName.TabIndex = 0
        Me.lblTitleFirstName.Text = "First name:"
        Me.lblTitleFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(252, 28)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(235, 31)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitleLastName
        '
        Me.lblTitleLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleLastName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLastName.Location = New System.Drawing.Point(12, 68)
        Me.lblTitleLastName.Name = "lblTitleLastName"
        Me.lblTitleLastName.Size = New System.Drawing.Size(234, 31)
        Me.lblTitleLastName.TabIndex = 2
        Me.lblTitleLastName.Text = "Last name:"
        Me.lblTitleLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(252, 68)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(235, 31)
        Me.txtLastName.TabIndex = 2
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitlePostalCode
        '
        Me.lblTitlePostalCode.BackColor = System.Drawing.Color.Transparent
        Me.lblTitlePostalCode.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePostalCode.Location = New System.Drawing.Point(12, 113)
        Me.lblTitlePostalCode.Name = "lblTitlePostalCode"
        Me.lblTitlePostalCode.Size = New System.Drawing.Size(234, 31)
        Me.lblTitlePostalCode.TabIndex = 4
        Me.lblTitlePostalCode.Text = "Postal code:"
        Me.lblTitlePostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(252, 113)
        Me.txtPostalCode.Multiline = True
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(235, 31)
        Me.txtPostalCode.TabIndex = 3
        Me.txtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitlePhoneNumber
        '
        Me.lblTitlePhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblTitlePhoneNumber.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePhoneNumber.Location = New System.Drawing.Point(12, 155)
        Me.lblTitlePhoneNumber.Name = "lblTitlePhoneNumber"
        Me.lblTitlePhoneNumber.Size = New System.Drawing.Size(231, 31)
        Me.lblTitlePhoneNumber.TabIndex = 6
        Me.lblTitlePhoneNumber.Text = "Phone number:"
        Me.lblTitlePhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitleCreditCard
        '
        Me.lblTitleCreditCard.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleCreditCard.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCreditCard.Location = New System.Drawing.Point(12, 238)
        Me.lblTitleCreditCard.Name = "lblTitleCreditCard"
        Me.lblTitleCreditCard.Size = New System.Drawing.Size(231, 31)
        Me.lblTitleCreditCard.TabIndex = 8
        Me.lblTitleCreditCard.Text = "Credit Card Number:"
        Me.lblTitleCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNextTwo
        '
        Me.btnNextTwo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextTwo.Location = New System.Drawing.Point(191, 331)
        Me.btnNextTwo.Name = "btnNextTwo"
        Me.btnNextTwo.Size = New System.Drawing.Size(116, 35)
        Me.btnNextTwo.TabIndex = 7
        Me.btnNextTwo.Text = "Next"
        Me.btnNextTwo.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(252, 155)
        Me.txtPhoneNumber.Multiline = True
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(235, 31)
        Me.txtPhoneNumber.TabIndex = 4
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiryDate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiryDate.Location = New System.Drawing.Point(12, 284)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(231, 31)
        Me.lblExpiryDate.TabIndex = 12
        Me.lblExpiryDate.Text = "Expiry Date:"
        Me.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.Location = New System.Drawing.Point(249, 285)
        Me.txtExpiryDate.Multiline = True
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(235, 31)
        Me.txtExpiryDate.TabIndex = 6
        Me.txtExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(249, 238)
        Me.txtCreditCard.Multiline = True
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(235, 31)
        Me.txtCreditCard.TabIndex = 5
        Me.txtCreditCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMuhammadInformation
        '
        Me.AcceptButton = Me.btnNextTwo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.DawoodZ_FinalProject.My.Resources.Resources.frmInformationBackground
        Me.ClientSize = New System.Drawing.Size(505, 378)
        Me.Controls.Add(Me.txtCreditCard)
        Me.Controls.Add(Me.txtExpiryDate)
        Me.Controls.Add(Me.lblExpiryDate)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.btnNextTwo)
        Me.Controls.Add(Me.lblTitleCreditCard)
        Me.Controls.Add(Me.lblTitlePhoneNumber)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.lblTitlePostalCode)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblTitleLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblTitleFirstName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMuhammadInformation"
        Me.Text = "Welcome to Quindecum!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitleFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblTitleLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblTitlePostalCode As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents lblTitlePhoneNumber As Label
    Friend WithEvents lblTitleCreditCard As Label
    Friend WithEvents btnNextTwo As Button
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents txtExpiryDate As TextBox
    Friend WithEvents txtCreditCard As TextBox
End Class
