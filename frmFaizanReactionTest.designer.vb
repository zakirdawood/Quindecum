<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFaizanReactionTest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaizanReactionTest))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnLetsPlay = New System.Windows.Forms.Button()
        Me.tmrReactionTime = New System.Windows.Forms.Timer(Me.components)
        Me.picSpeedy = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRewards = New System.Windows.Forms.Button()
        CType(Me.picSpeedy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Turquoise
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(16, 409)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(209, 37)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time: 0.000 m/s"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLetsPlay
        '
        Me.btnLetsPlay.BackColor = System.Drawing.Color.Black
        Me.btnLetsPlay.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLetsPlay.ForeColor = System.Drawing.Color.Red
        Me.btnLetsPlay.Location = New System.Drawing.Point(264, 273)
        Me.btnLetsPlay.Name = "btnLetsPlay"
        Me.btnLetsPlay.Size = New System.Drawing.Size(227, 79)
        Me.btnLetsPlay.TabIndex = 6
        Me.btnLetsPlay.Text = "LET'S PLAY!"
        Me.btnLetsPlay.UseVisualStyleBackColor = False
        '
        'tmrReactionTime
        '
        Me.tmrReactionTime.Interval = 1
        '
        'picSpeedy
        '
        Me.picSpeedy.BackColor = System.Drawing.Color.Transparent
        Me.picSpeedy.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.SpeedyGonzales
        Me.picSpeedy.Location = New System.Drawing.Point(12, 12)
        Me.picSpeedy.Name = "picSpeedy"
        Me.picSpeedy.Size = New System.Drawing.Size(161, 239)
        Me.picSpeedy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpeedy.TabIndex = 9
        Me.picSpeedy.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(179, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(395, 55)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Speedy's Reaction Test"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Black
        Me.lblInstructions.Font = New System.Drawing.Font("Kristen ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Red
        Me.lblInstructions.Location = New System.Drawing.Point(235, 100)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(279, 151)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Step right up and test your reaction time to see if your qualified to be an emplo" &
    "yee at Speedy's Pizzaria."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(283, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(193, 65)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "EXIT!"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRewards
        '
        Me.btnRewards.BackColor = System.Drawing.Color.Red
        Me.btnRewards.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRewards.ForeColor = System.Drawing.Color.White
        Me.btnRewards.Location = New System.Drawing.Point(561, 100)
        Me.btnRewards.Name = "btnRewards"
        Me.btnRewards.Size = New System.Drawing.Size(131, 74)
        Me.btnRewards.TabIndex = 12
        Me.btnRewards.Text = "Rewards!"
        Me.btnRewards.UseVisualStyleBackColor = False
        '
        'frmFaizanReactionTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DawoodZ_FinalProject.My.Resources.Resources.ReationBackground
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.btnRewards)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picSpeedy)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnLetsPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaizanReactionTest"
        Me.Text = "Reaction Test"
        CType(Me.picSpeedy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents btnLetsPlay As Button
    Friend WithEvents tmrReactionTime As Timer
    Friend WithEvents picSpeedy As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRewards As Button
End Class
