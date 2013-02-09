Public Class Expense_Tracker
    Dim row_index As Integer = -1
    Dim k As Integer = 0
    Dim db As New DataBaseInterface
    Private Sub ButtonSalaryExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalaryExp.Click
        StatusBarUpdater.updateStatusBar(" ", 4)
        SalaryExpense.ShowDialog()
    End Sub

    Private Sub ButtonOtherExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOtherExp.Click
        StatusBarUpdater.updateStatusBar(" ", 4)
        Other_Expense.ShowDialog()
    End Sub

    Private Sub Expense_Tracker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Home
    End Sub

    Private Sub ExpenseView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ExpenseView.CellClick
        row_index = ExpenseView.CurrentCell.RowIndex
    End Sub

    Private Sub ExpenseView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ExpenseView.CellContentClick

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Try
            If row_index > -1 And ExpenseView.SelectedCells(0).Value <> "" Then
                ExpenseView.AllowUserToDeleteRows = True

                ExpenseView.Rows.RemoveAt(row_index)
                SalaryExpense.totRow = SalaryExpense.totRow - 1
                row_index = -1

            End If
        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("No items to delete", 2)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
     

        Dim name As String
        Dim dateoftransaction As Date
        Dim amount As Decimal
        Dim count As Integer = 0
        For Each row As DataGridViewRow In ExpenseView.Rows
            count += 1
        Next

        If count >= 1 Then



            For Each row As DataGridViewRow In ExpenseView.Rows
                If Not row.IsNewRow Then
                    name = row.Cells(0).Value.ToString
                    dateoftransaction = Convert.ToDateTime(row.Cells(1).Value)
                    amount = Convert.ToDecimal((row.Cells(2).Value))
                    db.manipulate("insert into TABLEEXPENSE values('" & name & "'," & dateoftransaction & "," & amount & ") ")
                    Me.Close()
                    StatusBarUpdater.updateStatusBar("Data Saved", 5)
                End If
            Next
        Else
            StatusBarUpdater.updateStatusBar("No item to save", 1)
        End If
        
    End Sub
End Class