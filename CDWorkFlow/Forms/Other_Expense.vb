Public Class Other_Expense

    
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Expense_Tracker.ExpenseView.Rows.Add()
        Expense_Tracker.ExpenseView.Item(columnIndex:=0, rowIndex:=SalaryExpense.totRow).Value = cmbcname.Text
        Expense_Tracker.ExpenseView.Item(columnIndex:=1, rowIndex:=SalaryExpense.totRow).Value = from_date.Text
        Expense_Tracker.ExpenseView.Item(columnIndex:=2, rowIndex:=SalaryExpense.totRow).Value = Date.Today.ToShortDateString
        Dim _val As Decimal = Convert.ToDecimal(txtAmount.Text).ToString("#,##0.0")
        Expense_Tracker.ExpenseView.Item(columnIndex:=3, rowIndex:=SalaryExpense.totRow).Value = _val
        SalaryExpense.totRow += 1
    End Sub

    Private Sub txtAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Leave
        Dim s As String
        Dim _txtAmount As String = txtAmount.Text
        If (Trim(txtAmount.TextLength = 0)) Then
            txtAmount.Text = "0.00"
        Else
            s = Convert.ToDecimal(_txtAmount).ToString("#,##0.00")
            txtAmount.Text = s
        End If
    End Sub

    Private Sub Buttondone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondone.Click
        Me.Close()
    End Sub
End Class