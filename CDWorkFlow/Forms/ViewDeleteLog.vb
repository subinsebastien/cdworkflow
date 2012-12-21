Imports System.Data.SqlClient
Public Class ViewDeleteLog
    Dim db As New DataBaseInterface
    Dim data_reader As SqlDataReader
    Private Sub ViewDeleteLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.tsslok.Visible = False
        MdiParent = Home
        Dim tot_row As Integer = 0
        data_reader = db.reader("select * from TABLEDELETELOG ")

        While (data_reader.Read())
            Dim calDate As Date
            calDate = data_reader(1)
            DataGridView1.Rows.Add()
            DataGridView1.Item(columnIndex:=0, rowIndex:=tot_row).Value = data_reader(0)
            DataGridView1.Item(columnIndex:=1, rowIndex:=tot_row).Value = calDate.Date.ToShortDateString
            DataGridView1.Item(columnIndex:=2, rowIndex:=tot_row).Value = data_reader(2)
            DataGridView1.Item(columnIndex:=3, rowIndex:=tot_row).Value = data_reader(3)
            DataGridView1.Item(columnIndex:=4, rowIndex:=tot_row).Value = data_reader(4)
            DataGridView1.Item(columnIndex:=5, rowIndex:=tot_row).Value = data_reader(5)
            DataGridView1.Item(columnIndex:=6, rowIndex:=tot_row).Value = data_reader(6)
            DataGridView1.Item(columnIndex:=7, rowIndex:=tot_row).Value = data_reader(7)
            DataGridView1.Item(columnIndex:=8, rowIndex:=tot_row).Value = data_reader(8)
            tot_row = tot_row + 1
        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If MsgBox("Do you want to delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then



            db.manipulate("delete   from TABLEDELETELOG")
            DataGridView1.Rows.Clear()

        End If
    End Sub
End Class