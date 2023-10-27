<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.EditionBox = New System.Windows.Forms.GroupBox()
        Me.rbStuButton = New System.Windows.Forms.RadioButton()
        Me.rbProButton = New System.Windows.Forms.RadioButton()
        Me.rbUltButton = New System.Windows.Forms.RadioButton()
        Me.rbNoDisButton = New System.Windows.Forms.RadioButton()
        Me.rbStuDisButton = New System.Windows.Forms.RadioButton()
        Me.rbUltDisButton = New System.Windows.Forms.RadioButton()
        Me.btnGetButton = New System.Windows.Forms.Button()
        Me.btnExitButton = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.EditionBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditionBox
        '
        Me.EditionBox.Controls.Add(Me.rbStuButton)
        Me.EditionBox.Controls.Add(Me.rbProButton)
        Me.EditionBox.Controls.Add(Me.rbUltButton)
        Me.EditionBox.Location = New System.Drawing.Point(57, 62)
        Me.EditionBox.Name = "EditionBox"
        Me.EditionBox.Size = New System.Drawing.Size(98, 93)
        Me.EditionBox.TabIndex = 0
        Me.EditionBox.TabStop = False
        Me.EditionBox.Text = "Edition"
        '
        'rbStuButton
        '
        Me.rbStuButton.AutoSize = True
        Me.rbStuButton.Location = New System.Drawing.Point(6, 67)
        Me.rbStuButton.Name = "rbStuButton"
        Me.rbStuButton.Size = New System.Drawing.Size(62, 17)
        Me.rbStuButton.TabIndex = 1
        Me.rbStuButton.Text = "Student"
        Me.rbStuButton.UseVisualStyleBackColor = True
        '
        'rbProButton
        '
        Me.rbProButton.AutoSize = True
        Me.rbProButton.Location = New System.Drawing.Point(7, 44)
        Me.rbProButton.Name = "rbProButton"
        Me.rbProButton.Size = New System.Drawing.Size(82, 17)
        Me.rbProButton.TabIndex = 1
        Me.rbProButton.Text = "Professional"
        Me.rbProButton.UseVisualStyleBackColor = True
        '
        'rbUltButton
        '
        Me.rbUltButton.AutoSize = True
        Me.rbUltButton.Checked = True
        Me.rbUltButton.Location = New System.Drawing.Point(7, 20)
        Me.rbUltButton.Name = "rbUltButton"
        Me.rbUltButton.Size = New System.Drawing.Size(63, 17)
        Me.rbUltButton.TabIndex = 0
        Me.rbUltButton.TabStop = True
        Me.rbUltButton.Text = "Ultimate"
        Me.rbUltButton.UseVisualStyleBackColor = True
        '
        'rbNoDisButton
        '
        Me.rbNoDisButton.AutoSize = True
        Me.rbNoDisButton.Checked = True
        Me.rbNoDisButton.Location = New System.Drawing.Point(176, 62)
        Me.rbNoDisButton.Name = "rbNoDisButton"
        Me.rbNoDisButton.Size = New System.Drawing.Size(82, 17)
        Me.rbNoDisButton.TabIndex = 0
        Me.rbNoDisButton.TabStop = True
        Me.rbNoDisButton.Text = "No discount"
        Me.rbNoDisButton.UseVisualStyleBackColor = True
        '
        'rbStuDisButton
        '
        Me.rbStuDisButton.AutoSize = True
        Me.rbStuDisButton.Location = New System.Drawing.Point(176, 105)
        Me.rbStuDisButton.Name = "rbStuDisButton"
        Me.rbStuDisButton.Size = New System.Drawing.Size(139, 17)
        Me.rbStuDisButton.TabIndex = 1
        Me.rbStuDisButton.Text = "Student edition discount"
        Me.rbStuDisButton.UseVisualStyleBackColor = True
        '
        'rbUltDisButton
        '
        Me.rbUltDisButton.AutoSize = True
        Me.rbUltDisButton.Location = New System.Drawing.Point(176, 82)
        Me.rbUltDisButton.Name = "rbUltDisButton"
        Me.rbUltDisButton.Size = New System.Drawing.Size(140, 17)
        Me.rbUltDisButton.TabIndex = 0
        Me.rbUltDisButton.Text = "Ultimate edition discount"
        Me.rbUltDisButton.UseVisualStyleBackColor = True
        '
        'btnGetButton
        '
        Me.btnGetButton.Location = New System.Drawing.Point(339, 62)
        Me.btnGetButton.Name = "btnGetButton"
        Me.btnGetButton.Size = New System.Drawing.Size(75, 23)
        Me.btnGetButton.TabIndex = 2
        Me.btnGetButton.Text = "Get Price"
        Me.btnGetButton.UseVisualStyleBackColor = True
        '
        'btnExitButton
        '
        Me.btnExitButton.Location = New System.Drawing.Point(339, 91)
        Me.btnExitButton.Name = "btnExitButton"
        Me.btnExitButton.Size = New System.Drawing.Size(75, 23)
        Me.btnExitButton.TabIndex = 2
        Me.btnExitButton.Text = "Exit"
        Me.btnExitButton.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(176, 129)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price:"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalPrice.Location = New System.Drawing.Point(176, 152)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(2, 15)
        Me.lblFinalPrice.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 201)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnExitButton)
        Me.Controls.Add(Me.btnGetButton)
        Me.Controls.Add(Me.rbStuDisButton)
        Me.Controls.Add(Me.EditionBox)
        Me.Controls.Add(Me.rbUltDisButton)
        Me.Controls.Add(Me.rbNoDisButton)
        Me.Name = "frmMain"
        Me.Text = "Software Haven"
        Me.EditionBox.ResumeLayout(False)
        Me.EditionBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditionBox As GroupBox
    Friend WithEvents rbStuButton As RadioButton
    Friend WithEvents rbProButton As RadioButton
    Friend WithEvents rbUltButton As RadioButton
    Friend WithEvents rbNoDisButton As RadioButton
    Friend WithEvents rbStuDisButton As RadioButton
    Friend WithEvents rbUltDisButton As RadioButton
    Friend WithEvents btnGetButton As Button
    Friend WithEvents btnExitButton As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblFinalPrice As Label
End Class
