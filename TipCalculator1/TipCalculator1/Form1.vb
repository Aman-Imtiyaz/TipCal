Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amt, tippercent, noofperson, tipperperson, totalperperson As Double
        amt = txtBillAmount.Text
        tippercent = txtTipPercent.Text
        noofperson = txtNoOfPerson.Text
        tipperperson = (txtBillAmount.Text * txtTipPercent.Text) / (100 * txtNoOfPerson.Text)
        totalperperson = (txtBillAmount.Text / txtNoOfPerson.Text) + tipperperson
        txtTipPerPerson.Text = tipperperson
        txtTotalPerPerson.Text = totalperperson


    End Sub
End Class
