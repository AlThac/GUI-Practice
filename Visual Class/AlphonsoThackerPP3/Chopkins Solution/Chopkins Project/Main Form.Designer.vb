<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lb12Pack = New System.Windows.Forms.Label()
        Me.lb5Pack = New System.Windows.Forms.Label()
        Me.lb2Pack = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txt12Quan = New System.Windows.Forms.TextBox()
        Me.txt5Quan = New System.Windows.Forms.TextBox()
        Me.txt2Quan = New System.Windows.Forms.TextBox()
        Me.lbTotalPrice = New System.Windows.Forms.Label()
        Me.lbTotalPack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb12Pack
        '
        Me.lb12Pack.AutoSize = True
        Me.lb12Pack.Location = New System.Drawing.Point(57, 49)
        Me.lb12Pack.Name = "lb12Pack"
        Me.lb12Pack.Size = New System.Drawing.Size(50, 13)
        Me.lb12Pack.TabIndex = 0
        Me.lb12Pack.Text = "12 Pack:"
        '
        'lb5Pack
        '
        Me.lb5Pack.AutoSize = True
        Me.lb5Pack.Location = New System.Drawing.Point(57, 95)
        Me.lb5Pack.Name = "lb5Pack"
        Me.lb5Pack.Size = New System.Drawing.Size(44, 13)
        Me.lb5Pack.TabIndex = 1
        Me.lb5Pack.Text = "5 Pack:"
        '
        'lb2Pack
        '
        Me.lb2Pack.AutoSize = True
        Me.lb2Pack.Location = New System.Drawing.Point(57, 139)
        Me.lb2Pack.Name = "lb2Pack"
        Me.lb2Pack.Size = New System.Drawing.Size(44, 13)
        Me.lb2Pack.TabIndex = 2
        Me.lb2Pack.Text = "2 Pack:"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(60, 201)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(39, 13)
        Me.lbTotal.TabIndex = 3
        Me.lbTotal.Text = "Totals:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(63, 265)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(188, 265)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txt12Quan
        '
        Me.txt12Quan.Location = New System.Drawing.Point(113, 49)
        Me.txt12Quan.Name = "txt12Quan"
        Me.txt12Quan.Size = New System.Drawing.Size(100, 20)
        Me.txt12Quan.TabIndex = 6
        '
        'txt5Quan
        '
        Me.txt5Quan.Location = New System.Drawing.Point(113, 95)
        Me.txt5Quan.Name = "txt5Quan"
        Me.txt5Quan.Size = New System.Drawing.Size(100, 20)
        Me.txt5Quan.TabIndex = 7
        '
        'txt2Quan
        '
        Me.txt2Quan.Location = New System.Drawing.Point(113, 139)
        Me.txt2Quan.Name = "txt2Quan"
        Me.txt2Quan.Size = New System.Drawing.Size(100, 20)
        Me.txt2Quan.TabIndex = 8
        '
        'lbTotalPrice
        '
        Me.lbTotalPrice.AutoSize = True
        Me.lbTotalPrice.Location = New System.Drawing.Point(110, 201)
        Me.lbTotalPrice.Name = "lbTotalPrice"
        Me.lbTotalPrice.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalPrice.TabIndex = 9
        '
        'lbTotalPack
        '
        Me.lbTotalPack.AutoSize = True
        Me.lbTotalPack.BackColor = System.Drawing.Color.Gold
        Me.lbTotalPack.Location = New System.Drawing.Point(217, 200)
        Me.lbTotalPack.Name = "lbTotalPack"
        Me.lbTotalPack.Size = New System.Drawing.Size(39, 13)
        Me.lbTotalPack.TabIndex = 10
        Me.lbTotalPack.Text = "Label1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 310)
        Me.Controls.Add(Me.lbTotalPack)
        Me.Controls.Add(Me.lbTotalPrice)
        Me.Controls.Add(Me.txt2Quan)
        Me.Controls.Add(Me.txt5Quan)
        Me.Controls.Add(Me.txt12Quan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lb2Pack)
        Me.Controls.Add(Me.lb5Pack)
        Me.Controls.Add(Me.lb12Pack)
        Me.Name = "MainForm"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb12Pack As Label
    Friend WithEvents lb5Pack As Label
    Friend WithEvents lb2Pack As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txt12Quan As TextBox
    Friend WithEvents txt5Quan As TextBox
    Friend WithEvents txt2Quan As TextBox
    Friend WithEvents lbTotalPrice As Label
    Friend WithEvents lbTotalPack As Label
End Class
