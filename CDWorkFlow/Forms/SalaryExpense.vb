Public Class SalaryExpense
    Public totRow As Integer = 0
    Private Sub SalaryExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAmount.Text = "0.00"
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Expense_Tracker.ExpenseView.Rows.Add()
        Expense_Tracker.ExpenseView.Item(columnIndex:=0, rowIndex:=totRow).Value = cmbcname.Text
        Expense_Tracker.ExpenseView.Item(columnIndex:=1, rowIndex:=totRow).Value = from_date.Text

        Dim _val As Decimal = Convert.ToDecimal(txtAmount.Text).ToString("#,##0.0")
        Expense_Tracker.ExpenseView.Item(columnIndex:=2, rowIndex:=totRow).Value = _val
        totRow += 1
        Me.Close()
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

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub

   
End Class