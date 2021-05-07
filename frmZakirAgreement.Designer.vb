<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZakirAgreement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZakirAgreement))
        Me.chkAge = New System.Windows.Forms.CheckBox()
        Me.chkTerms = New System.Windows.Forms.CheckBox()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.btnNextOne = New System.Windows.Forms.Button()
        Me.btnTOS = New System.Windows.Forms.Button()
        Me.lblTOS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkAge
        '
        Me.chkAge.AutoSize = True
        Me.chkAge.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAge.Location = New System.Drawing.Point(22, 147)
        Me.chkAge.Name = "chkAge"
        Me.chkAge.Size = New System.Drawing.Size(413, 22)
        Me.chkAge.TabIndex = 1
        Me.chkAge.Text = "I am over 16 or I am accompanied by an adult."
        Me.chkAge.UseVisualStyleBackColor = True
        '
        'chkTerms
        '
        Me.chkTerms.AutoSize = True
        Me.chkTerms.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTerms.Location = New System.Drawing.Point(22, 175)
        Me.chkTerms.Name = "chkTerms"
        Me.chkTerms.Size = New System.Drawing.Size(430, 22)
        Me.chkTerms.TabIndex = 2
        Me.chkTerms.Text = "I agree to the terms and conditons of Quindecum"
        Me.chkTerms.UseVisualStyleBackColor = True
        '
        'lblTerms
        '
        Me.lblTerms.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms.Location = New System.Drawing.Point(17, 9)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(571, 127)
        Me.lblTerms.TabIndex = 3
        Me.lblTerms.Text = "Welcome to QUINDECUM! Please read through the terms and conditions and confirm th" &
    "at you are over 16 or are accompanied by and adult over 16."
        Me.lblTerms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNextOne
        '
        Me.btnNextOne.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextOne.Location = New System.Drawing.Point(255, 235)
        Me.btnNextOne.Name = "btnNextOne"
        Me.btnNextOne.Size = New System.Drawing.Size(139, 36)
        Me.btnNextOne.TabIndex = 4
        Me.btnNextOne.Text = "Next"
        Me.btnNextOne.UseVisualStyleBackColor = True
        '
        'btnTOS
        '
        Me.btnTOS.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTOS.Location = New System.Drawing.Point(550, 197)
        Me.btnTOS.Name = "btnTOS"
        Me.btnTOS.Size = New System.Drawing.Size(82, 28)
        Me.btnTOS.TabIndex = 5
        Me.btnTOS.Text = "TOS"
        Me.btnTOS.UseVisualStyleBackColor = True
        '
        'lblTOS
        '
        Me.lblTOS.AutoSize = True
        Me.lblTOS.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOS.Location = New System.Drawing.Point(36, 200)
        Me.lblTOS.Name = "lblTOS"
        Me.lblTOS.Size = New System.Drawing.Size(498, 22)
        Me.lblTOS.TabIndex = 6
        Me.lblTOS.Text = "(Click the button on the right to view the terms and conditions.)"
        '
        'frmZakirAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 283)
        Me.Controls.Add(Me.lblTOS)
        Me.Controls.Add(Me.btnTOS)
        Me.Controls.Add(Me.btnNextOne)
        Me.Controls.Add(Me.lblTerms)
        Me.Controls.Add(Me.chkTerms)
        Me.Controls.Add(Me.chkAge)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmZakirAgreement"
        Me.Text = "Welcome to Quindecum "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAge As CheckBox
    Friend WithEvents chkTerms As CheckBox
    Friend WithEvents lblTerms As Label
    Friend WithEvents btnNextOne As Button
    Private WithEvents btnTOS As Button
    Friend WithEvents lblTOS As Label
End Class
