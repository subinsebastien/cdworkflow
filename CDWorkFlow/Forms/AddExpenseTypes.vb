Imports System.Data.SqlClient

Public Class AddExpenseTypes
    Dim globalDataReader As SqlDataReader
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Dim checkForNewEntry As Integer = 0

    Private Sub AddExpenseTypes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Home
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

    Private Sub ExpenseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenseName.SelectedIndexChanged

    End Sub

    Private Sub ExpenseName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExpenseName.TextChanged
        globalDataReader = db.reader("select * from EXPENSETYPES where ExpName = '" & Trim(ExpenseName.Text) & "' ")
        globalDataReader.Read()

        If globalDataReader.HasRows Or Trim(ExpenseName.Text) = "" Then
            checkForNewEntry = 0
        Else
            checkForNewEntry = 1
        End If
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        If checkForNewEntry = 1 Then
            db.manipulate("insert into EXPENSETYPES values('" & ExpenseName.Text & "') ")
            Me.Close()
        Else
            StatusBarUpdater.updateStatusBar("Enter New Expense", 2)
            ExpenseName.Focus()
        End If



    End Sub
End Class