Public Class MainForm


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const dbl12Price As Double = 14.99
        Const dbl5Price As Double = 6.99
        Const dbl2Price As Double = 2.5

        Dim intQty12Pack, intQty5Pack, intQty2Pack As Integer
        Dim dblTotalPrice As Double

        Integer.TryParse(txt12Quan.Text, intQty12Pack)
        Integer.TryParse(txt5Quan.Text, intQty5Pack)
        Integer.TryParse(txt2Quan.Text, intQty2Pack)

        dblTotalPrice = (intQty12Pack * dbl12Price) + (intQty5Pack * dbl5Price) + (intQty2Pack * dbl2Price)

        lbTotalPack.Text = "Total Packs: " + (intQty12Pack + intQty5Pack + intQty2Pack).ToString


        lbTotalPrice.Text = "Total Price:$" + dblTotalPrice.ToString("N2")

    End Sub

End Class
