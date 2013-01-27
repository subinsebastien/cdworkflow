Public Class Expense_Tracker
    Dim row_index As Integer = -1
    Dim k As Integer = 0
    Private Sub ButtonSalaryExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalaryExp.Click
        SalaryExpense.ShowDialog()
    End Sub

    Private Sub ButtonOtherExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOtherExp.Click
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
        Try
            ExpenseView.SelectAll()
            Dim FirstValue As Boolean = True
            Dim cell As DataGridViewCell
            Dim roow As DataGridViewRow
            For Each roow In ExpenseView.Rows

                k += 1
                For Each cell In ExpenseView.SelectedCells
                    'If Not FirstValue Then

                    'End If
                    If cell.Value.ToString <> "" Then
                        MsgBox(cell.Value.ToString())
                        'FirstValue = False
                    End If

                Next

                Exit For


            Next




        Catch ex As Exception
            MsgBox("select an item")
        End Try
    End Sub
End Class