<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaizanRulerOfTheKnightsHowToPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaizanRulerOfTheKnightsHowToPlay))
        Me.lblHowToPlay = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblEasterEgg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHowToPlay
        '
        Me.lblHowToPlay.BackColor = System.Drawing.Color.OliveDrab
        Me.lblHowToPlay.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToPlay.Location = New System.Drawing.Point(12, 9)
        Me.lblHowToPlay.Name = "lblHowToPlay"
        Me.lblHowToPlay.Size = New System.Drawing.Size(780, 389)
        Me.lblHowToPlay.TabIndex = 0
        Me.lblHowToPlay.Text = resources.GetString("lblHowToPlay.Text")
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(319, 412)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(161, 51)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblEasterEgg
        '
        Me.lblEasterEgg.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasterEgg.Location = New System.Drawing.Point(253, 296)
        Me.lblEasterEgg.Name = "lblEasterEgg"
        Me.lblEasterEgg.Size = New System.Drawing.Size(309, 92)
        Me.lblEasterEgg.TabIndex = 2
        Me.lblEasterEgg.Text = "Easy Right!?"
        Me.lblEasterEgg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFaizanRulerOfTheKnightsHowToPlay
        '
        Me.AcceptButton = Me.btnBack
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(804, 475)
        Me.Controls.Add(Me.lblEasterEgg)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHowToPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFaizanRulerOfTheKnightsHowToPlay"
        Me.Text = "How To Play"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHowToPlay As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblEasterEgg As Label
End Class
