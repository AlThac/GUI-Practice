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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.rdbtnMother = New System.Windows.Forms.RadioButton()
        Me.rdbtnFather = New System.Windows.Forms.RadioButton()
        Me.rdbtnSister = New System.Windows.Forms.RadioButton()
        Me.rdbtnBrother = New System.Windows.Forms.RadioButton()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'rdbtnMother
        '
        Me.rdbtnMother.AutoSize = True
        Me.rdbtnMother.Location = New System.Drawing.Point(6, 19)
        Me.rdbtnMother.Name = "rdbtnMother"
        Me.rdbtnMother.Size = New System.Drawing.Size(58, 17)
        Me.rdbtnMother.TabIndex = 1
        Me.rdbtnMother.TabStop = True
        Me.rdbtnMother.Text = "Mother"
        Me.rdbtnMother.UseVisualStyleBackColor = True
        '
        'rdbtnFather
        '
        Me.rdbtnFather.AutoSize = True
        Me.rdbtnFather.Location = New System.Drawing.Point(6, 42)
        Me.rdbtnFather.Name = "rdbtnFather"
        Me.rdbtnFather.Size = New System.Drawing.Size(55, 17)
        Me.rdbtnFather.TabIndex = 1
        Me.rdbtnFather.TabStop = True
        Me.rdbtnFather.Text = "Father"
        Me.rdbtnFather.UseVisualStyleBackColor = True
        '
        'rdbtnSister
        '
        Me.rdbtnSister.AutoSize = True
        Me.rdbtnSister.Location = New System.Drawing.Point(6, 65)
        Me.rdbtnSister.Name = "rdbtnSister"
        Me.rdbtnSister.Size = New System.Drawing.Size(51, 17)
        Me.rdbtnSister.TabIndex = 1
        Me.rdbtnSister.TabStop = True
        Me.rdbtnSister.Text = "Sister"
        Me.rdbtnSister.UseVisualStyleBackColor = True
        '
        'rdbtnBrother
        '
        Me.rdbtnBrother.AutoSize = True
        Me.rdbtnBrother.Location = New System.Drawing.Point(6, 88)
        Me.rdbtnBrother.Name = "rdbtnBrother"
        Me.rdbtnBrother.Size = New System.Drawing.Size(59, 17)
        Me.rdbtnBrother.TabIndex = 1
        Me.rdbtnBrother.TabStop = True
        Me.rdbtnBrother.Text = "Brother"
        Me.rdbtnBrother.UseVisualStyleBackColor = True
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(342, 50)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(75, 23)
        Me.btnTrans.TabIndex = 2
        Me.btnTrans.Text = "Translate"
        Me.btnTrans.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(342, 80)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrans.Location = New System.Drawing.Point(167, 89)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(2, 15)
        Me.lblTrans.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnBrother)
        Me.GroupBox1.Controls.Add(Me.rdbtnSister)
        Me.GroupBox1.Controls.Add(Me.rdbtnFather)
        Me.GroupBox1.Controls.Add(Me.rdbtnMother)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 121)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "English"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 224)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTrans)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmMain"
        Me.Text = "Translator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents rdbtnMother As RadioButton
    Friend WithEvents rdbtnFather As RadioButton
    Friend WithEvents rdbtnSister As RadioButton
    Friend WithEvents rdbtnBrother As RadioButton
    Friend WithEvents btnTrans As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTrans As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
