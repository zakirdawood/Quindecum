<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaizanRulerOfTheKnightsGameScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaizanRulerOfTheKnightsGameScreen))
        Me.prgPlayerHealth = New System.Windows.Forms.ProgressBar()
        Me.prgComputerHealth = New System.Windows.Forms.ProgressBar()
        Me.grpMoveSelection = New System.Windows.Forms.GroupBox()
        Me.btnMove3 = New System.Windows.Forms.Button()
        Me.btnMove2 = New System.Windows.Forms.Button()
        Me.btnMove1 = New System.Windows.Forms.Button()
        Me.lblPlayerHealth = New System.Windows.Forms.Label()
        Me.lblComputerHealth = New System.Windows.Forms.Label()
        Me.picVersusAndDice = New System.Windows.Forms.PictureBox()
        Me.picComCharacter = New System.Windows.Forms.PictureBox()
        Me.picPlayerCharacter = New System.Windows.Forms.PictureBox()
        Me.grpMoveSelection.SuspendLayout()
        CType(Me.picVersusAndDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgPlayerHealth
        '
        Me.prgPlayerHealth.Location = New System.Drawing.Point(12, 263)
        Me.prgPlayerHealth.Name = "prgPlayerHealth"
        Me.prgPlayerHealth.Size = New System.Drawing.Size(194, 23)
        Me.prgPlayerHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPlayerHealth.TabIndex = 3
        Me.prgPlayerHealth.Value = 100
        '
        'prgComputerHealth
        '
        Me.prgComputerHealth.Location = New System.Drawing.Point(546, 263)
        Me.prgComputerHealth.Name = "prgComputerHealth"
        Me.prgComputerHealth.Size = New System.Drawing.Size(194, 23)
        Me.prgComputerHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgComputerHealth.TabIndex = 4
        Me.prgComputerHealth.Value = 100
        '
        'grpMoveSelection
        '
        Me.grpMoveSelection.Controls.Add(Me.btnMove3)
        Me.grpMoveSelection.Controls.Add(Me.btnMove2)
        Me.grpMoveSelection.Controls.Add(Me.btnMove1)
        Me.grpMoveSelection.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMoveSelection.Location = New System.Drawing.Point(12, 306)
        Me.grpMoveSelection.Name = "grpMoveSelection"
        Me.grpMoveSelection.Size = New System.Drawing.Size(728, 119)
        Me.grpMoveSelection.TabIndex = 5
        Me.grpMoveSelection.TabStop = False
        '
        'btnMove3
        '
        Me.btnMove3.Location = New System.Drawing.Point(520, 39)
        Me.btnMove3.Name = "btnMove3"
        Me.btnMove3.Size = New System.Drawing.Size(179, 59)
        Me.btnMove3.TabIndex = 8
        Me.btnMove3.UseVisualStyleBackColor = True
        '
        'btnMove2
        '
        Me.btnMove2.Location = New System.Drawing.Point(270, 39)
        Me.btnMove2.Name = "btnMove2"
        Me.btnMove2.Size = New System.Drawing.Size(179, 59)
        Me.btnMove2.TabIndex = 7
        Me.btnMove2.UseVisualStyleBackColor = True
        '
        'btnMove1
        '
        Me.btnMove1.Location = New System.Drawing.Point(15, 39)
        Me.btnMove1.Name = "btnMove1"
        Me.btnMove1.Size = New System.Drawing.Size(179, 59)
        Me.btnMove1.TabIndex = 6
        Me.btnMove1.UseVisualStyleBackColor = True
        '
        'lblPlayerHealth
        '
        Me.lblPlayerHealth.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerHealth.Location = New System.Drawing.Point(212, 263)
        Me.lblPlayerHealth.Name = "lblPlayerHealth"
        Me.lblPlayerHealth.Size = New System.Drawing.Size(106, 23)
        Me.lblPlayerHealth.TabIndex = 6
        Me.lblPlayerHealth.Text = "Health: 100"
        Me.lblPlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputerHealth
        '
        Me.lblComputerHealth.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerHealth.Location = New System.Drawing.Point(436, 263)
        Me.lblComputerHealth.Name = "lblComputerHealth"
        Me.lblComputerHealth.Size = New System.Drawing.Size(104, 23)
        Me.lblComputerHealth.TabIndex = 7
        Me.lblComputerHealth.Text = "Health: 100"
        Me.lblComputerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picVersusAndDice
        '
        Me.picVersusAndDice.BackColor = System.Drawing.Color.Crimson
        Me.picVersusAndDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVersusAndDice.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Versus
        Me.picVersusAndDice.Location = New System.Drawing.Point(285, 52)
        Me.picVersusAndDice.Name = "picVersusAndDice"
        Me.picVersusAndDice.Size = New System.Drawing.Size(176, 151)
        Me.picVersusAndDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVersusAndDice.TabIndex = 2
        Me.picVersusAndDice.TabStop = False
        '
        'picComCharacter
        '
        Me.picComCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picComCharacter.Location = New System.Drawing.Point(546, 12)
        Me.picComCharacter.Name = "picComCharacter"
        Me.picComCharacter.Size = New System.Drawing.Size(194, 245)
        Me.picComCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComCharacter.TabIndex = 1
        Me.picComCharacter.TabStop = False
        '
        'picPlayerCharacter
        '
        Me.picPlayerCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayerCharacter.Location = New System.Drawing.Point(12, 12)
        Me.picPlayerCharacter.Name = "picPlayerCharacter"
        Me.picPlayerCharacter.Size = New System.Drawing.Size(194, 245)
        Me.picPlayerCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCharacter.TabIndex = 0
        Me.picPlayerCharacter.TabStop = False
        '
        'frmFaizanRulerOfTheKnightsGameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(752, 437)
        Me.Controls.Add(Me.lblComputerHealth)
        Me.Controls.Add(Me.lblPlayerHealth)
        Me.Controls.Add(Me.grpMoveSelection)
        Me.Controls.Add(Me.prgComputerHealth)
        Me.Controls.Add(Me.prgPlayerHealth)
        Me.Controls.Add(Me.picVersusAndDice)
        Me.Controls.Add(Me.picComCharacter)
        Me.Controls.Add(Me.picPlayerCharacter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaizanRulerOfTheKnightsGameScreen"
        Me.Text = "frmFaizanRulerOfTheKnightsGameScreen"
        Me.grpMoveSelection.ResumeLayout(False)
        CType(Me.picVersusAndDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayerCharacter As PictureBox
    Friend WithEvents picComCharacter As PictureBox
    Friend WithEvents picVersusAndDice As PictureBox
    Friend WithEvents prgPlayerHealth As ProgressBar
    Friend WithEvents prgComputerHealth As ProgressBar
    Friend WithEvents grpMoveSelection As GroupBox
    Friend WithEvents btnMove3 As Button
    Friend WithEvents btnMove2 As Button
    Friend WithEvents btnMove1 As Button
    Friend WithEvents lblPlayerHealth As Label
    Friend WithEvents lblComputerHealth As Label
End Class
