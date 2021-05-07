<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuhammadRace
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuhammadRace))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picMelissa = New System.Windows.Forms.PictureBox()
        Me.picLegend = New System.Windows.Forms.PictureBox()
        Me.picJumper = New System.Windows.Forms.PictureBox()
        Me.picShadow = New System.Windows.Forms.PictureBox()
        Me.picMiranda = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitleMelissa = New System.Windows.Forms.Label()
        Me.lblTitleMiranda = New System.Windows.Forms.Label()
        Me.lblTitleShadow = New System.Windows.Forms.Label()
        Me.lblTitleJumper = New System.Windows.Forms.Label()
        Me.lblTitleLegend = New System.Windows.Forms.Label()
        Me.tmrMelissa = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMiranda = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShadow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJumper = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLegend = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMelissa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJumper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShadow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiranda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(824, 622)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(284, 40)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return to Game Select"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 622)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(192, 40)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start the Race!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picMelissa
        '
        Me.picMelissa.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Melissa
        Me.picMelissa.Location = New System.Drawing.Point(66, 39)
        Me.picMelissa.Name = "picMelissa"
        Me.picMelissa.Size = New System.Drawing.Size(92, 79)
        Me.picMelissa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMelissa.TabIndex = 2
        Me.picMelissa.TabStop = False
        '
        'picLegend
        '
        Me.picLegend.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Legend
        Me.picLegend.Location = New System.Drawing.Point(14, 524)
        Me.picLegend.Name = "picLegend"
        Me.picLegend.Size = New System.Drawing.Size(147, 92)
        Me.picLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLegend.TabIndex = 3
        Me.picLegend.TabStop = False
        '
        'picJumper
        '
        Me.picJumper.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Jumper
        Me.picJumper.Location = New System.Drawing.Point(18, 383)
        Me.picJumper.Name = "picJumper"
        Me.picJumper.Size = New System.Drawing.Size(143, 96)
        Me.picJumper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJumper.TabIndex = 4
        Me.picJumper.TabStop = False
        '
        'picShadow
        '
        Me.picShadow.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Shadow
        Me.picShadow.Location = New System.Drawing.Point(31, 275)
        Me.picShadow.Name = "picShadow"
        Me.picShadow.Size = New System.Drawing.Size(130, 66)
        Me.picShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShadow.TabIndex = 5
        Me.picShadow.TabStop = False
        '
        'picMiranda
        '
        Me.picMiranda.Image = Global.DawoodZ_FinalProject.My.Resources.Resources.Miranda
        Me.picMiranda.Location = New System.Drawing.Point(61, 161)
        Me.picMiranda.Name = "picMiranda"
        Me.picMiranda.Size = New System.Drawing.Size(99, 79)
        Me.picMiranda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMiranda.TabIndex = 6
        Me.picMiranda.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(382, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(386, 35)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Welcome to Old Town Derby!"
        '
        'lblTitleMelissa
        '
        Me.lblTitleMelissa.AutoSize = True
        Me.lblTitleMelissa.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleMelissa.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMelissa.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitleMelissa.Location = New System.Drawing.Point(80, 9)
        Me.lblTitleMelissa.Name = "lblTitleMelissa"
        Me.lblTitleMelissa.Size = New System.Drawing.Size(81, 27)
        Me.lblTitleMelissa.TabIndex = 8
        Me.lblTitleMelissa.Text = "Melissa"
        '
        'lblTitleMiranda
        '
        Me.lblTitleMiranda.AutoSize = True
        Me.lblTitleMiranda.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleMiranda.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMiranda.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitleMiranda.Location = New System.Drawing.Point(71, 131)
        Me.lblTitleMiranda.Name = "lblTitleMiranda"
        Me.lblTitleMiranda.Size = New System.Drawing.Size(89, 27)
        Me.lblTitleMiranda.TabIndex = 9
        Me.lblTitleMiranda.Text = "Miranda"
        '
        'lblTitleShadow
        '
        Me.lblTitleShadow.AutoSize = True
        Me.lblTitleShadow.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleShadow.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleShadow.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitleShadow.Location = New System.Drawing.Point(71, 245)
        Me.lblTitleShadow.Name = "lblTitleShadow"
        Me.lblTitleShadow.Size = New System.Drawing.Size(86, 27)
        Me.lblTitleShadow.TabIndex = 10
        Me.lblTitleShadow.Text = "Shadow"
        '
        'lblTitleJumper
        '
        Me.lblTitleJumper.AutoSize = True
        Me.lblTitleJumper.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleJumper.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleJumper.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitleJumper.Location = New System.Drawing.Point(71, 353)
        Me.lblTitleJumper.Name = "lblTitleJumper"
        Me.lblTitleJumper.Size = New System.Drawing.Size(86, 27)
        Me.lblTitleJumper.TabIndex = 11
        Me.lblTitleJumper.Text = "Jumper"
        '
        'lblTitleLegend
        '
        Me.lblTitleLegend.AutoSize = True
        Me.lblTitleLegend.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleLegend.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLegend.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitleLegend.Location = New System.Drawing.Point(78, 494)
        Me.lblTitleLegend.Name = "lblTitleLegend"
        Me.lblTitleLegend.Size = New System.Drawing.Size(83, 27)
        Me.lblTitleLegend.TabIndex = 12
        Me.lblTitleLegend.Text = "Legend"
        '
        'tmrMelissa
        '
        Me.tmrMelissa.Tag = "1"
        '
        'tmrMiranda
        '
        Me.tmrMiranda.Tag = "1"
        '
        'tmrShadow
        '
        Me.tmrShadow.Tag = "1"
        '
        'tmrJumper
        '
        Me.tmrJumper.Tag = "1"
        '
        'tmrLegend
        '
        Me.tmrLegend.Tag = "1"
        '
        'frmMuhammadRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DawoodZ_FinalProject.My.Resources.Resources.arena
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1126, 662)
        Me.Controls.Add(Me.lblTitleLegend)
        Me.Controls.Add(Me.lblTitleJumper)
        Me.Controls.Add(Me.lblTitleShadow)
        Me.Controls.Add(Me.lblTitleMiranda)
        Me.Controls.Add(Me.lblTitleMelissa)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMiranda)
        Me.Controls.Add(Me.picShadow)
        Me.Controls.Add(Me.picJumper)
        Me.Controls.Add(Me.picLegend)
        Me.Controls.Add(Me.picMelissa)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReturn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMuhammadRace"
        Me.Text = "Old Town Derby"
        CType(Me.picMelissa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJumper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShadow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiranda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents picMelissa As PictureBox
    Friend WithEvents picLegend As PictureBox
    Friend WithEvents picJumper As PictureBox
    Friend WithEvents picShadow As PictureBox
    Friend WithEvents picMiranda As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitleMelissa As Label
    Friend WithEvents lblTitleMiranda As Label
    Friend WithEvents lblTitleShadow As Label
    Friend WithEvents lblTitleJumper As Label
    Friend WithEvents lblTitleLegend As Label
    Friend WithEvents tmrMelissa As Timer
    Friend WithEvents tmrMiranda As Timer
    Friend WithEvents tmrShadow As Timer
    Friend WithEvents tmrJumper As Timer
    Friend WithEvents tmrLegend As Timer
End Class
