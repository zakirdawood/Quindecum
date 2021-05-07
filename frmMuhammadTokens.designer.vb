<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuhammadTokens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMuhammadTokens))
        Me.grpPeople = New System.Windows.Forms.GroupBox()
        Me.rdb8OrMorePeople = New System.Windows.Forms.RadioButton()
        Me.rdb5To7People = New System.Windows.Forms.RadioButton()
        Me.rdb2To4People = New System.Windows.Forms.RadioButton()
        Me.rdb1person = New System.Windows.Forms.RadioButton()
        Me.lblTitleRecommeded = New System.Windows.Forms.Label()
        Me.lblRecommended = New System.Windows.Forms.Label()
        Me.grpPricing = New System.Windows.Forms.GroupBox()
        Me.lbl100PlusTokens = New System.Windows.Forms.Label()
        Me.lbl50To99Tokens = New System.Windows.Forms.Label()
        Me.lbl20PlusTokens = New System.Windows.Forms.Label()
        Me.lbl10PlusTokens = New System.Windows.Forms.Label()
        Me.lbl1token = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTokens = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpPeople.SuspendLayout()
        Me.grpPricing.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPeople
        '
        Me.grpPeople.BackColor = System.Drawing.Color.Transparent
        Me.grpPeople.Controls.Add(Me.rdb8OrMorePeople)
        Me.grpPeople.Controls.Add(Me.rdb5To7People)
        Me.grpPeople.Controls.Add(Me.rdb2To4People)
        Me.grpPeople.Controls.Add(Me.rdb1person)
        Me.grpPeople.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPeople.Location = New System.Drawing.Point(9, 10)
        Me.grpPeople.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPeople.Name = "grpPeople"
        Me.grpPeople.Padding = New System.Windows.Forms.Padding(2)
        Me.grpPeople.Size = New System.Drawing.Size(286, 232)
        Me.grpPeople.TabIndex = 0
        Me.grpPeople.TabStop = False
        Me.grpPeople.Text = "How many people are with you? (optional)"
        '
        'rdb8OrMorePeople
        '
        Me.rdb8OrMorePeople.AutoSize = True
        Me.rdb8OrMorePeople.Location = New System.Drawing.Point(4, 181)
        Me.rdb8OrMorePeople.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb8OrMorePeople.Name = "rdb8OrMorePeople"
        Me.rdb8OrMorePeople.Size = New System.Drawing.Size(111, 28)
        Me.rdb8OrMorePeople.TabIndex = 3
        Me.rdb8OrMorePeople.TabStop = True
        Me.rdb8OrMorePeople.Text = "8+ People"
        Me.rdb8OrMorePeople.UseVisualStyleBackColor = True
        '
        'rdb5To7People
        '
        Me.rdb5To7People.AutoSize = True
        Me.rdb5To7People.Location = New System.Drawing.Point(4, 136)
        Me.rdb5To7People.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb5To7People.Name = "rdb5To7People"
        Me.rdb5To7People.Size = New System.Drawing.Size(141, 28)
        Me.rdb5To7People.TabIndex = 2
        Me.rdb5To7People.TabStop = True
        Me.rdb5To7People.Text = "5 to 7 People"
        Me.rdb5To7People.UseVisualStyleBackColor = True
        '
        'rdb2To4People
        '
        Me.rdb2To4People.AutoSize = True
        Me.rdb2To4People.Location = New System.Drawing.Point(4, 93)
        Me.rdb2To4People.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb2To4People.Name = "rdb2To4People"
        Me.rdb2To4People.Size = New System.Drawing.Size(141, 28)
        Me.rdb2To4People.TabIndex = 1
        Me.rdb2To4People.TabStop = True
        Me.rdb2To4People.Text = "2 to 4 People"
        Me.rdb2To4People.UseVisualStyleBackColor = True
        '
        'rdb1person
        '
        Me.rdb1person.AutoSize = True
        Me.rdb1person.Location = New System.Drawing.Point(4, 54)
        Me.rdb1person.Margin = New System.Windows.Forms.Padding(2)
        Me.rdb1person.Name = "rdb1person"
        Me.rdb1person.Size = New System.Drawing.Size(96, 28)
        Me.rdb1person.TabIndex = 0
        Me.rdb1person.TabStop = True
        Me.rdb1person.Text = "Just me"
        Me.rdb1person.UseVisualStyleBackColor = True
        '
        'lblTitleRecommeded
        '
        Me.lblTitleRecommeded.AutoSize = True
        Me.lblTitleRecommeded.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleRecommeded.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleRecommeded.Location = New System.Drawing.Point(50, 274)
        Me.lblTitleRecommeded.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleRecommeded.Name = "lblTitleRecommeded"
        Me.lblTitleRecommeded.Size = New System.Drawing.Size(222, 24)
        Me.lblTitleRecommeded.TabIndex = 5
        Me.lblTitleRecommeded.Text = "We recommend you buy:"
        '
        'lblRecommended
        '
        Me.lblRecommended.BackColor = System.Drawing.Color.Transparent
        Me.lblRecommended.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecommended.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecommended.Location = New System.Drawing.Point(28, 308)
        Me.lblRecommended.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRecommended.Name = "lblRecommended"
        Me.lblRecommended.Size = New System.Drawing.Size(248, 37)
        Me.lblRecommended.TabIndex = 6
        '
        'grpPricing
        '
        Me.grpPricing.BackColor = System.Drawing.Color.Transparent
        Me.grpPricing.Controls.Add(Me.lbl100PlusTokens)
        Me.grpPricing.Controls.Add(Me.lbl50To99Tokens)
        Me.grpPricing.Controls.Add(Me.lbl20PlusTokens)
        Me.grpPricing.Controls.Add(Me.lbl10PlusTokens)
        Me.grpPricing.Controls.Add(Me.lbl1token)
        Me.grpPricing.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPricing.Location = New System.Drawing.Point(299, 10)
        Me.grpPricing.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPricing.Name = "grpPricing"
        Me.grpPricing.Padding = New System.Windows.Forms.Padding(2)
        Me.grpPricing.Size = New System.Drawing.Size(334, 198)
        Me.grpPricing.TabIndex = 4
        Me.grpPricing.TabStop = False
        Me.grpPricing.Text = "Pricing"
        '
        'lbl100PlusTokens
        '
        Me.lbl100PlusTokens.AutoSize = True
        Me.lbl100PlusTokens.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl100PlusTokens.Location = New System.Drawing.Point(4, 165)
        Me.lbl100PlusTokens.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl100PlusTokens.Name = "lbl100PlusTokens"
        Me.lbl100PlusTokens.Size = New System.Drawing.Size(244, 24)
        Me.lbl100PlusTokens.TabIndex = 11
        Me.lbl100PlusTokens.Text = "500+ tokens = 40% discount"
        '
        'lbl50To99Tokens
        '
        Me.lbl50To99Tokens.AutoSize = True
        Me.lbl50To99Tokens.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50To99Tokens.Location = New System.Drawing.Point(4, 128)
        Me.lbl50To99Tokens.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl50To99Tokens.Name = "lbl50To99Tokens"
        Me.lbl50To99Tokens.Size = New System.Drawing.Size(244, 24)
        Me.lbl50To99Tokens.TabIndex = 10
        Me.lbl50To99Tokens.Text = "200+ tokens = 25% discount"
        '
        'lbl20PlusTokens
        '
        Me.lbl20PlusTokens.AutoSize = True
        Me.lbl20PlusTokens.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20PlusTokens.Location = New System.Drawing.Point(4, 93)
        Me.lbl20PlusTokens.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl20PlusTokens.Name = "lbl20PlusTokens"
        Me.lbl20PlusTokens.Size = New System.Drawing.Size(244, 24)
        Me.lbl20PlusTokens.TabIndex = 9
        Me.lbl20PlusTokens.Text = "100+ tokens = 15% discount"
        '
        'lbl10PlusTokens
        '
        Me.lbl10PlusTokens.AutoSize = True
        Me.lbl10PlusTokens.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10PlusTokens.Location = New System.Drawing.Point(4, 57)
        Me.lbl10PlusTokens.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl10PlusTokens.Name = "lbl10PlusTokens"
        Me.lbl10PlusTokens.Size = New System.Drawing.Size(234, 24)
        Me.lbl10PlusTokens.TabIndex = 8
        Me.lbl10PlusTokens.Text = "50+ tokens = 10% discount"
        '
        'lbl1token
        '
        Me.lbl1token.AutoSize = True
        Me.lbl1token.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1token.Location = New System.Drawing.Point(4, 24)
        Me.lbl1token.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1token.Name = "lbl1token"
        Me.lbl1token.Size = New System.Drawing.Size(142, 24)
        Me.lbl1token.TabIndex = 7
        Me.lbl1token.Text = "1 token = $0.50"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 210)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 58)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "How many tokens would you like?"
        '
        'txtTokens
        '
        Me.txtTokens.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTokens.Location = New System.Drawing.Point(536, 222)
        Me.txtTokens.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTokens.Name = "txtTokens"
        Me.txtTokens.Size = New System.Drawing.Size(76, 33)
        Me.txtTokens.TabIndex = 8
        Me.txtTokens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(400, 306)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 35)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total: "
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(360, 346)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(226, 45)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Let's Get Gaming!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(388, 271)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(156, 33)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmMuhammadTokens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.DawoodZ_FinalProject.My.Resources.Resources.frmtokenpurchasebackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 392)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTokens)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpPricing)
        Me.Controls.Add(Me.lblRecommended)
        Me.Controls.Add(Me.lblTitleRecommeded)
        Me.Controls.Add(Me.grpPeople)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMuhammadTokens"
        Me.Text = "Token Purchase"
        Me.grpPeople.ResumeLayout(False)
        Me.grpPeople.PerformLayout()
        Me.grpPricing.ResumeLayout(False)
        Me.grpPricing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPeople As GroupBox
    Friend WithEvents rdb8OrMorePeople As RadioButton
    Friend WithEvents rdb5To7People As RadioButton
    Friend WithEvents rdb2To4People As RadioButton
    Friend WithEvents rdb1person As RadioButton
    Friend WithEvents lblTitleRecommeded As Label
    Friend WithEvents lblRecommended As Label
    Friend WithEvents grpPricing As GroupBox
    Friend WithEvents lbl50To99Tokens As Label
    Friend WithEvents lbl20PlusTokens As Label
    Friend WithEvents lbl10PlusTokens As Label
    Friend WithEvents lbl1token As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTokens As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lbl100PlusTokens As Label
End Class
