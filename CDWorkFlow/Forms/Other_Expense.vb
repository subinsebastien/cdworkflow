Imports System.Data.SqlClient

Public Class Other_Expense
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Expense_Tracker.ExpenseView.Rows.Add()
        Expense_Tracker.ExpenseView.Item(columnIndex:=0, rowIndex:=SalaryExpense.totRow).Value = ExpenseName.Text
        Expense_Tracker.ExpenseView.Item(columnIndex:=1, rowIndex:=SalaryExpense.totRow).Value = from_date.Text

        Dim _val As Decimal = Convert.ToDecimal(txtAmount.Text).ToString("#,##0.0")
        Expense_Tracker.ExpenseView.Item(columnIndex:=2, rowIndex:=SalaryExpense.totRow).Value = _val
        SalaryExpense.totRow += 1
        Me.Close()
    End Sub

    Private Sub txtAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Click
        txtAmount.Clear()
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



    Private Sub Other_Expense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAmount.Text = "0.00"
        ExpenseName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ExpenseName.AutoCompleteSource = AutoCompleteSource.ListItems
        'cmbcname.Text = singleview.cmbcname.Text

        dr = db.reader("select ExpName from EXPENSETYPES")
        If dr.HasRows Then
            While dr.Read
                ExpenseName.Items.Add(Trim(dr(0)))
            End While
        End If
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class