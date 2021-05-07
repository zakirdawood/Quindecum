<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZakirPrizes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZakirPrizes))
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpPrizes = New System.Windows.Forms.GroupBox()
        Me.chkCineplex = New System.Windows.Forms.CheckBox()
        Me.chkWonderland = New System.Windows.Forms.CheckBox()
        Me.chkIphone = New System.Windows.Forms.CheckBox()
        Me.chkAmazon = New System.Windows.Forms.CheckBox()
        Me.chkSticker = New System.Windows.Forms.CheckBox()
        Me.chkFoodPass = New System.Windows.Forms.CheckBox()
        Me.chkPikachu = New System.Windows.Forms.CheckBox()
        Me.chkRaptors = New System.Windows.Forms.CheckBox()
        Me.chkPs4 = New System.Windows.Forms.CheckBox()
        Me.chkFidget = New System.Windows.Forms.CheckBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.lblTicketsOut = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpPrizes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInstruction.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Black
        Me.lblInstruction.Location = New System.Drawing.Point(12, 78)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(353, 25)
        Me.lblInstruction.TabIndex = 3
        Me.lblInstruction.Text = "Please select the prizes you would like to purchase through your tickets."
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(155, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(255, 47)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Prizes Selection "
        '
        'grpPrizes
        '
        Me.grpPrizes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpPrizes.Controls.Add(Me.chkCineplex)
        Me.grpPrizes.Controls.Add(Me.chkWonderland)
        Me.grpPrizes.Controls.Add(Me.chkIphone)
        Me.grpPrizes.Controls.Add(Me.chkAmazon)
        Me.grpPrizes.Controls.Add(Me.chkSticker)
        Me.grpPrizes.Controls.Add(Me.chkFoodPass)
        Me.grpPrizes.Controls.Add(Me.chkPikachu)
        Me.grpPrizes.Controls.Add(Me.chkRaptors)
        Me.grpPrizes.Controls.Add(Me.chkPs4)
        Me.grpPrizes.Controls.Add(Me.chkFidget)
        Me.grpPrizes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrizes.Location = New System.Drawing.Point(16, 115)
        Me.grpPrizes.Name = "grpPrizes"
        Me.grpPrizes.Size = New System.Drawing.Size(310, 314)
        Me.grpPrizes.TabIndex = 5
        Me.grpPrizes.TabStop = False
        Me.grpPrizes.Text = "Prizes:"
        '
        'chkCineplex
        '
        Me.chkCineplex.AutoSize = True
        Me.chkCineplex.ForeColor = System.Drawing.Color.Black
        Me.chkCineplex.Location = New System.Drawing.Point(6, 278)
        Me.chkCineplex.Name = "chkCineplex"
        Me.chkCineplex.Size = New System.Drawing.Size(247, 22)
        Me.chkCineplex.TabIndex = 9
        Me.chkCineplex.Text = "2 Cineplex Tickets - 1300"
        Me.chkCineplex.UseVisualStyleBackColor = True
        '
        'chkWonderland
        '
        Me.chkWonderland.AutoSize = True
        Me.chkWonderland.ForeColor = System.Drawing.Color.Black
        Me.chkWonderland.Location = New System.Drawing.Point(6, 250)
        Me.chkWonderland.Name = "chkWonderland"
        Me.chkWonderland.Size = New System.Drawing.Size(279, 22)
        Me.chkWonderland.TabIndex = 8
        Me.chkWonderland.Text = "2 Wonderland Tickets - 3000"
        Me.chkWonderland.UseVisualStyleBackColor = True
        '
        'chkIphone
        '
        Me.chkIphone.AutoSize = True
        Me.chkIphone.ForeColor = System.Drawing.Color.Black
        Me.chkIphone.Location = New System.Drawing.Point(6, 222)
        Me.chkIphone.Name = "chkIphone"
        Me.chkIphone.Size = New System.Drawing.Size(203, 22)
        Me.chkIphone.TabIndex = 7
        Me.chkIphone.Text = "Iphone 10R - 10000"
        Me.chkIphone.UseVisualStyleBackColor = True
        '
        'chkAmazon
        '
        Me.chkAmazon.AutoSize = True
        Me.chkAmazon.ForeColor = System.Drawing.Color.Black
        Me.chkAmazon.Location = New System.Drawing.Point(6, 194)
        Me.chkAmazon.Name = "chkAmazon"
        Me.chkAmazon.Size = New System.Drawing.Size(281, 22)
        Me.chkAmazon.TabIndex = 6
        Me.chkAmazon.Text = "$50 Amazon Gift Card - 1500"
        Me.chkAmazon.UseVisualStyleBackColor = True
        '
        'chkSticker
        '
        Me.chkSticker.AutoSize = True
        Me.chkSticker.ForeColor = System.Drawing.Color.Black
        Me.chkSticker.Location = New System.Drawing.Point(6, 166)
        Me.chkSticker.Name = "chkSticker"
        Me.chkSticker.Size = New System.Drawing.Size(187, 22)
        Me.chkSticker.TabIndex = 5
        Me.chkSticker.Text = "Sticker Book - 400"
        Me.chkSticker.UseVisualStyleBackColor = True
        '
        'chkFoodPass
        '
        Me.chkFoodPass.AutoSize = True
        Me.chkFoodPass.ForeColor = System.Drawing.Color.Black
        Me.chkFoodPass.Location = New System.Drawing.Point(6, 138)
        Me.chkFoodPass.Name = "chkFoodPass"
        Me.chkFoodPass.Size = New System.Drawing.Size(281, 22)
        Me.chkFoodPass.TabIndex = 4
        Me.chkFoodPass.Text = "Quindecum Food Pass - 2000"
        Me.chkFoodPass.UseVisualStyleBackColor = True
        '
        'chkPikachu
        '
        Me.chkPikachu.AutoSize = True
        Me.chkPikachu.ForeColor = System.Drawing.Color.Black
        Me.chkPikachu.Location = New System.Drawing.Point(6, 110)
        Me.chkPikachu.Name = "chkPikachu"
        Me.chkPikachu.Size = New System.Drawing.Size(290, 22)
        Me.chkPikachu.TabIndex = 3
        Me.chkPikachu.Text = "Pikachu Stuffed Animal - 1200"
        Me.chkPikachu.UseVisualStyleBackColor = True
        '
        'chkRaptors
        '
        Me.chkRaptors.AutoSize = True
        Me.chkRaptors.ForeColor = System.Drawing.Color.Black
        Me.chkRaptors.Location = New System.Drawing.Point(6, 82)
        Me.chkRaptors.Name = "chkRaptors"
        Me.chkRaptors.Size = New System.Drawing.Size(222, 22)
        Me.chkRaptors.TabIndex = 2
        Me.chkRaptors.Text = "Raptors Jersey - 3000"
        Me.chkRaptors.UseVisualStyleBackColor = True
        '
        'chkPs4
        '
        Me.chkPs4.AutoSize = True
        Me.chkPs4.ForeColor = System.Drawing.Color.Black
        Me.chkPs4.Location = New System.Drawing.Point(6, 54)
        Me.chkPs4.Name = "chkPs4"
        Me.chkPs4.Size = New System.Drawing.Size(123, 22)
        Me.chkPs4.TabIndex = 1
        Me.chkPs4.Text = "PS4 - 6000"
        Me.chkPs4.UseVisualStyleBackColor = True
        '
        'chkFidget
        '
        Me.chkFidget.AutoSize = True
        Me.chkFidget.ForeColor = System.Drawing.Color.Black
        Me.chkFidget.Location = New System.Drawing.Point(6, 26)
        Me.chkFidget.Name = "chkFidget"
        Me.chkFidget.Size = New System.Drawing.Size(204, 22)
        Me.chkFidget.TabIndex = 0
        Me.chkFidget.Text = "Fidget Spinner - 400"
        Me.chkFidget.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(399, 309)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(130, 38)
        Me.btnCheckOut.TabIndex = 6
        Me.btnCheckOut.Text = "Checkout"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'lblTickets
        '
        Me.lblTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTickets.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.ForeColor = System.Drawing.Color.Black
        Me.lblTickets.Location = New System.Drawing.Point(399, 154)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(130, 37)
        Me.lblTickets.TabIndex = 7
        Me.lblTickets.Text = "Tickets:"
        Me.lblTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTicketsOut
        '
        Me.lblTicketsOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTicketsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTicketsOut.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsOut.ForeColor = System.Drawing.Color.Black
        Me.lblTicketsOut.Location = New System.Drawing.Point(399, 191)
        Me.lblTicketsOut.Name = "lblTicketsOut"
        Me.lblTicketsOut.Size = New System.Drawing.Size(130, 70)
        Me.lblTicketsOut.TabIndex = 8
        Me.lblTicketsOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(399, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 38)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmZakirPrizes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.DawoodZ_FinalProject.My.Resources.Resources.Arcade1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTicketsOut)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.grpPrizes)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInstruction)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmZakirPrizes"
        Me.Text = "Prizes Selection                                                                 " &
    "                                             "
        Me.grpPrizes.ResumeLayout(False)
        Me.grpPrizes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpPrizes As GroupBox
    Friend WithEvents chkCineplex As CheckBox
    Friend WithEvents chkWonderland As CheckBox
    Friend WithEvents chkIphone As CheckBox
    Friend WithEvents chkAmazon As CheckBox
    Friend WithEvents chkSticker As CheckBox
    Friend WithEvents chkFoodPass As CheckBox
    Friend WithEvents chkPikachu As CheckBox
    Friend WithEvents chkRaptors As CheckBox
    Friend WithEvents chkPs4 As CheckBox
    Friend WithEvents chkFidget As CheckBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents lblTickets As Label
    Friend WithEvents lblTicketsOut As Label
    Friend WithEvents btnExit As Button
End Class
