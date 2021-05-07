<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaizanRulerOfTheKnightsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaizanRulerOfTheKnightsMenu))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblReward = New System.Windows.Forms.Label()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Olive
        Me.btnPlay.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(478, 192)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(290, 80)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "PLAY!"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.BackColor = System.Drawing.Color.Olive
        Me.btnHowToPlay.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHowToPlay.Location = New System.Drawing.Point(493, 278)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(260, 80)
        Me.btnHowToPlay.TabIndex = 1
        Me.btnHowToPlay.Text = "HOW TO PLAY?"
        Me.btnHowToPlay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Olive
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(508, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(230, 80)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picTitle
        '
        Me.picTitle.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.TitlePageImage
        Me.picTitle.Location = New System.Drawing.Point(26, 20)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(396, 460)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 3
        Me.picTitle.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(435, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(357, 115)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Ruler Of The       Knights"
        '
        'lblReward
        '
        Me.lblReward.BackColor = System.Drawing.Color.Crimson
        Me.lblReward.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReward.Location = New System.Drawing.Point(464, 129)
        Me.lblReward.Name = "lblReward"
        Me.lblReward.Size = New System.Drawing.Size(317, 54)
        Me.lblReward.TabIndex = 5
        Me.lblReward.Text = "Win 100 Tokens by becoming the Ruler Of The Knights"
        Me.lblReward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFaizanRulerOfTheKnightsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(804, 501)
        Me.Controls.Add(Me.lblReward)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaizanRulerOfTheKnightsMenu"
        Me.Text = "Ruler Of The Knights"
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblReward As Label
End Class
