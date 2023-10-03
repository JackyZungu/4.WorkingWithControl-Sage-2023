Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' MsgBox("The sum is = " & Val(txtEnterNumber.Text) + Val(txtEnterNumber2.Text))
        txtAnswer.Text = Val(txtEnterNumber.Text) + Val(txtEnterNumber2.Text)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'MsgBox("The subtraction is = " & Val(txtEnterNumber.Text) - Val(txtEnterNumber2.Text))
        txtAnswer.Text = Val(txtEnterNumber.Text) - Val(txtEnterNumber2.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'MsgBox("The division is = " & Val(txtEnterNumber.Text) / Val(txtEnterNumber2.Text))
        txtAnswer.Text = Val(txtEnterNumber.Text) / Val(txtEnterNumber2.Text)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'MsgBox("The multiplication is = " & Val(txtEnterNumber.Text) * Val(txtEnterNumber2.Text))
        txtAnswer.Text = Val(txtEnterNumber.Text) * Val(txtEnterNumber2.Text)
    End Sub

End Class
