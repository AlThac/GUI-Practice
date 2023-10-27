Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetButton.Click
        Dim dblUltPrice As Double = 899.99
        Dim dblProPrice As Double = 599.99
        Dim dblStuPrice As Double = 99.99

        If rbUltButton.Checked Then
            lblFinalPrice.Text = "$" & 899.99
        ElseIf rbProButton.Checked Then
            lblFinalPrice.Text = "$" & 599.99
        ElseIf rbStuButton.Checked Then
            lblFinalPrice.Text = "$" & 99.99
        End If

        If rbUltDisButton.Checked Then
            lblFinalPrice.Text *= "$" & 0.9
        End If
        If rbStuDisButton.Checked Then
            lblFinalPrice.Text *= "$" & 0.8
        End If

    End Sub
    Private Sub rbUltButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbUltButton.CheckedChanged
        If rbUltButton.Checked = True Then
            lblFinalPrice.Text = "$" & 899.99
        End If
    End Sub
    Private Sub rbProButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbProButton.CheckedChanged
        If rbProButton.Checked Then
            lblFinalPrice.Text = "$" & 599.99
        End If
    End Sub

    Private Sub rbStuButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbStuButton.CheckedChanged
        If rbStuButton.Checked Then
            lblFinalPrice.Text = "$" & 99.99
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click
        Me.Close()
    End Sub
End Class
