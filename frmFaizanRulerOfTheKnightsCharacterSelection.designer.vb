<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFaizanRulerOfTheKnightsCharacterSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaizanRulerOfTheKnightsCharacterSelection))
        Me.lblKnight1 = New System.Windows.Forms.Label()
        Me.lblKnight2 = New System.Windows.Forms.Label()
        Me.lblKnight3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSirLancelotInfo = New System.Windows.Forms.Label()
        Me.lblTips = New System.Windows.Forms.Label()
        Me.lblArthurLeBlancInfo = New System.Windows.Forms.Label()
        Me.lblGarethBaleInfo = New System.Windows.Forms.Label()
        Me.picGarethBale = New System.Windows.Forms.PictureBox()
        Me.picArthurLeBlanc = New System.Windows.Forms.PictureBox()
        Me.picSirLancelot = New System.Windows.Forms.PictureBox()
        CType(Me.picGarethBale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArthurLeBlanc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSirLancelot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKnight1
        '
        Me.lblKnight1.BackColor = System.Drawing.Color.Red
        Me.lblKnight1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKnight1.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnight1.Location = New System.Drawing.Point(30, 18)
        Me.lblKnight1.Name = "lblKnight1"
        Me.lblKnight1.Size = New System.Drawing.Size(188, 38)
        Me.lblKnight1.TabIndex = 3
        Me.lblKnight1.Text = "Sir Lancelot"
        Me.lblKnight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKnight2
        '
        Me.lblKnight2.BackColor = System.Drawing.Color.Blue
        Me.lblKnight2.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnight2.ForeColor = System.Drawing.Color.White
        Me.lblKnight2.Location = New System.Drawing.Point(341, 18)
        Me.lblKnight2.Name = "lblKnight2"
        Me.lblKnight2.Size = New System.Drawing.Size(188, 38)
        Me.lblKnight2.TabIndex = 4
        Me.lblKnight2.Text = "Arthur LeBlanc"
        Me.lblKnight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKnight3
        '
        Me.lblKnight3.BackColor = System.Drawing.Color.Green
        Me.lblKnight3.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKnight3.ForeColor = System.Drawing.Color.Yellow
        Me.lblKnight3.Location = New System.Drawing.Point(641, 18)
        Me.lblKnight3.Name = "lblKnight3"
        Me.lblKnight3.Size = New System.Drawing.Size(188, 38)
        Me.lblKnight3.TabIndex = 5
        Me.lblKnight3.Text = "Gareth Bale"
        Me.lblKnight3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(694, 417)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(135, 47)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblSirLancelotInfo
        '
        Me.lblSirLancelotInfo.BackColor = System.Drawing.Color.Red
        Me.lblSirLancelotInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSirLancelotInfo.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSirLancelotInfo.Location = New System.Drawing.Point(224, 18)
        Me.lblSirLancelotInfo.Name = "lblSirLancelotInfo"
        Me.lblSirLancelotInfo.Size = New System.Drawing.Size(349, 349)
        Me.lblSirLancelotInfo.TabIndex = 7
        Me.lblSirLancelotInfo.Text = "Name: Sir Lancelot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Age: 35" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Moves:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Fury Slash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Do 30 damage to opponen" &
    "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•  Potion of Health" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Receive 40 health health back" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Knight Slayer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " &
    "    - Do 50 damage to opponent"
        Me.lblSirLancelotInfo.Visible = False
        '
        'lblTips
        '
        Me.lblTips.BackColor = System.Drawing.Color.White
        Me.lblTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTips.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTips.Location = New System.Drawing.Point(30, 381)
        Me.lblTips.Name = "lblTips"
        Me.lblTips.Size = New System.Drawing.Size(635, 83)
        Me.lblTips.TabIndex = 8
        Me.lblTips.Text = "*Hover cursor over image of the character to reveal information"
        Me.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArthurLeBlancInfo
        '
        Me.lblArthurLeBlancInfo.BackColor = System.Drawing.Color.Blue
        Me.lblArthurLeBlancInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArthurLeBlancInfo.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArthurLeBlancInfo.ForeColor = System.Drawing.Color.White
        Me.lblArthurLeBlancInfo.Location = New System.Drawing.Point(580, 18)
        Me.lblArthurLeBlancInfo.Name = "lblArthurLeBlancInfo"
        Me.lblArthurLeBlancInfo.Size = New System.Drawing.Size(350, 349)
        Me.lblArthurLeBlancInfo.TabIndex = 9
        Me.lblArthurLeBlancInfo.Text = resources.GetString("lblArthurLeBlancInfo.Text")
        Me.lblArthurLeBlancInfo.Visible = False
        '
        'lblGarethBaleInfo
        '
        Me.lblGarethBaleInfo.BackColor = System.Drawing.Color.Green
        Me.lblGarethBaleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGarethBaleInfo.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGarethBaleInfo.ForeColor = System.Drawing.Color.Yellow
        Me.lblGarethBaleInfo.Location = New System.Drawing.Point(274, 18)
        Me.lblGarethBaleInfo.Name = "lblGarethBaleInfo"
        Me.lblGarethBaleInfo.Size = New System.Drawing.Size(350, 349)
        Me.lblGarethBaleInfo.TabIndex = 10
        Me.lblGarethBaleInfo.Text = resources.GetString("lblGarethBaleInfo.Text")
        Me.lblGarethBaleInfo.Visible = False
        '
        'picGarethBale
        '
        Me.picGarethBale.BackColor = System.Drawing.Color.OrangeRed
        Me.picGarethBale.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.GarethBale
        Me.picGarethBale.Location = New System.Drawing.Point(641, 59)
        Me.picGarethBale.Name = "picGarethBale"
        Me.picGarethBale.Size = New System.Drawing.Size(188, 299)
        Me.picGarethBale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGarethBale.TabIndex = 2
        Me.picGarethBale.TabStop = False
        '
        'picArthurLeBlanc
        '
        Me.picArthurLeBlanc.BackColor = System.Drawing.Color.OrangeRed
        Me.picArthurLeBlanc.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.ArthurLeBlanc
        Me.picArthurLeBlanc.Location = New System.Drawing.Point(341, 59)
        Me.picArthurLeBlanc.Name = "picArthurLeBlanc"
        Me.picArthurLeBlanc.Size = New System.Drawing.Size(188, 299)
        Me.picArthurLeBlanc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArthurLeBlanc.TabIndex = 1
        Me.picArthurLeBlanc.TabStop = False
        '
        'picSirLancelot
        '
        Me.picSirLancelot.BackColor = System.Drawing.Color.OrangeRed
        Me.picSirLancelot.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.SirLancelot
        Me.picSirLancelot.Location = New System.Drawing.Point(30, 59)
        Me.picSirLancelot.Name = "picSirLancelot"
        Me.picSirLancelot.Size = New System.Drawing.Size(188, 299)
        Me.picSirLancelot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSirLancelot.TabIndex = 0
        Me.picSirLancelot.TabStop = False
        '
        'frmFaizanRulerOfTheKnightsCharacterSelection
        '
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(959, 486)
        Me.Controls.Add(Me.lblSirLancelotInfo)
        Me.Controls.Add(Me.lblArthurLeBlancInfo)
        Me.Controls.Add(Me.lblGarethBaleInfo)
        Me.Controls.Add(Me.lblTips)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblKnight3)
        Me.Controls.Add(Me.lblKnight2)
        Me.Controls.Add(Me.lblKnight1)
        Me.Controls.Add(Me.picGarethBale)
        Me.Controls.Add(Me.picArthurLeBlanc)
        Me.Controls.Add(Me.picSirLancelot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaizanRulerOfTheKnightsCharacterSelection"
        Me.Text = "Select Your Character"
        CType(Me.picGarethBale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArthurLeBlanc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSirLancelot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSirLancelot As PictureBox
    Friend WithEvents picArthurLeBlanc As PictureBox
    Friend WithEvents picGarethBale As PictureBox
    Friend WithEvents lblKnight1 As Label
    Friend WithEvents lblKnight2 As Label
    Friend WithEvents lblKnight3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSirLancelotInfo As Label
    Friend WithEvents lblTips As Label
    Friend WithEvents lblArthurLeBlancInfo As Label
    Friend WithEvents lblGarethBaleInfo As Label
End Class
