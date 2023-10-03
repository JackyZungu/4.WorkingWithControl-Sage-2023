<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.lbEnterNumber = New System.Windows.Forms.Label()
        Me.txtEnterNumber2 = New System.Windows.Forms.TextBox()
        Me.lbEnterNumber2 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.lbAnswer = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lbSubtract = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(59, 392)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 38)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(208, 68)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(62, 22)
        Me.txtEnterNumber.TabIndex = 1
        '
        'lbEnterNumber
        '
        Me.lbEnterNumber.AutoSize = True
        Me.lbEnterNumber.Location = New System.Drawing.Point(56, 68)
        Me.lbEnterNumber.Name = "lbEnterNumber"
        Me.lbEnterNumber.Size = New System.Drawing.Size(98, 16)
        Me.lbEnterNumber.TabIndex = 2
        Me.lbEnterNumber.Text = "Enter Number  :"
        '
        'txtEnterNumber2
        '
        Me.txtEnterNumber2.Location = New System.Drawing.Point(208, 106)
        Me.txtEnterNumber2.Name = "txtEnterNumber2"
        Me.txtEnterNumber2.Size = New System.Drawing.Size(62, 22)
        Me.txtEnterNumber2.TabIndex = 1
        '
        'lbEnterNumber2
        '
        Me.lbEnterNumber2.AutoSize = True
        Me.lbEnterNumber2.Location = New System.Drawing.Point(56, 112)
        Me.lbEnterNumber2.Name = "lbEnterNumber2"
        Me.lbEnterNumber2.Size = New System.Drawing.Size(105, 16)
        Me.lbEnterNumber2.TabIndex = 2
        Me.lbEnterNumber2.Text = "Enter Number 2 :"
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(208, 392)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(87, 38)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(363, 392)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(82, 38)
        Me.btnDivide.TabIndex = 4
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(509, 392)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(91, 38)
        Me.btnMultiply.TabIndex = 5
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'lbAnswer
        '
        Me.lbAnswer.AutoSize = True
        Me.lbAnswer.Location = New System.Drawing.Point(59, 154)
        Me.lbAnswer.Name = "lbAnswer"
        Me.lbAnswer.Size = New System.Drawing.Size(60, 16)
        Me.lbAnswer.TabIndex = 6
        Me.lbAnswer.Text = "Answer  :"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(208, 154)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(62, 22)
        Me.txtAnswer.TabIndex = 7
        '
        'lbSubtract
        '
        Me.lbSubtract.AutoSize = True
        Me.lbSubtract.Location = New System.Drawing.Point(153, 288)
        Me.lbSubtract.Name = "lbSubtract"
        Me.lbSubtract.Size = New System.Drawing.Size(0, 16)
        Me.lbSubtract.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbSubtract)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lbAnswer)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.lbEnterNumber2)
        Me.Controls.Add(Me.lbEnterNumber)
        Me.Controls.Add(Me.txtEnterNumber2)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txtEnterNumber As TextBox
    Friend WithEvents lbEnterNumber As Label
    Friend WithEvents txtEnterNumber2 As TextBox
    Friend WithEvents lbEnterNumber2 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents lbAnswer As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lbSubtract As Label
End Class
