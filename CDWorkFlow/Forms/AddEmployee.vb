Imports System.Data.SqlClient
Imports System.Drawing.Graphics
Public Class AddEmployee
    Dim globalDataReader As SqlDataReader
    Dim db As New DataBaseInterface

    Private Sub AddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
        globalDataReader = db.reader("select name from TABLEEMPLOYEE")
        If globalDataReader.HasRows Then
            While globalDataReader.Read
                cmbcname.Items.Add(Trim(globalDataReader(0)))
            End While
        End If
    End Sub
End Class