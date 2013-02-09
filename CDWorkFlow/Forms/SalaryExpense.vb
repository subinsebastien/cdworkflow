Imports System.Data.SqlClient

Public Class SalaryExpense
    Public totRow As Integer = 0
    Dim dr As SqlDataReader
    Dim db As New DataBaseInterface
    Private Sub SalaryExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcname.Items.Clear()
        cmbcname.Text = "---Select Name---"

        txtAmount.Text = "0.00"
        cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
        'cmbcname.Text = singleview.cmbcname.Text

        dr = db.reader("select Ename from TABLEEMPLOYEE")
        If dr.HasRows Then
            While dr.Read
                cmbcname.Items.Add(Trim(dr(0)))
            End While
        End If
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

    Private Sub txtAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Click
        StatusBarUpdater.updateStatusBar("", 4)
        txtAmount.Clear()
    End Sub

    Private Sub txtAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.GotFocus
        If txtAmount.Text = "0.00" Then
            txtAmount.Clear()
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If InStr("0123456789.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtAmount.Focus()
        Else
            e.KeyChar = ""
        End If
        If Asc(e.KeyChar) = 13 Then
            txtAmount.Focus()
        End If
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


    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged

    End Sub
End Class