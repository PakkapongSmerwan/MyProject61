Public Class frmJob4
    Dim datetime As Date = Date.Now
    Const decR_ALLOW As Double = 0.01
    Const decR_TAX As Double = 0.07
    Const decR_BONUS As Double = 0.2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Salary, SaleYear, YearSalary, Bonus, AllIncome, Tax, Allowance As Double
        Salary = Val(txtSalary.Text)
        SaleYear = Val(txtSaleYear.Text)

        YearSalary = Salary * 12
        Bonus = SaleYear * decR_BONUS

        AllIncome = YearSalary + Bonus
        Allowance = AllIncome * decR_ALLOW

        Tax = (AllIncome - Allowance) * decR_TAX

        lblYearSalary.Text = FormatNumber(YearSalary, 2)
        lblBonus.Text = FormatNumber(Bonus, 2)
        lblAllIncome.Text = FormatNumber(AllIncome, 2)
        lblAllowance.Text = FormatNumber(Allowance, 2)
        lblTax.Text = FormatNumber(Tax, 2)

        txtSalary.Text = FormatNumber(txtSalary.Text, 2)
        txtSaleYear.Text = FormatNumber(txtSaleYear.Text, 2)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lbldate.Text = FormatDateTime(datetime, DateFormat.ShortDate)
    End Sub


    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lbldate.Text = FormatDateTime(datetime, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lbldate.Text = FormatDateTime(datetime, DateFormat.LongDate)
    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = FormatDateTime(datetime, DateFormat.GeneralDate)
    End Sub   
End Class