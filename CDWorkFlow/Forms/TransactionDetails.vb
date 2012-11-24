Imports System.Data.SqlClient
Public Class TransactionDetails
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Private Sub TransactionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Home
        dr = db.reader("select  c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where t.id=" & ViewInventory.getCellContent & " and c.customerid=t.customerid")
        dr.Read()
        If dr.HasRows = True Then
           
            Dim _shortDate As Date = dr(7)
            _shortDate = _shortDate.Date.ToShortDateString

            'MsgBox(ViewInventory.getCellContent)
            'Label10.Text = ViewInventory.getCellContent
            'Label12.Text = dr(0)
            GridviewDetails.Rows.Add(10)
            GridviewDetails.Item(columnIndex:=0, rowIndex:=0).Value = "Transaction Id"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=0).Value = dr(10)

            GridviewDetails.Item(columnIndex:=0, rowIndex:=2).Value = "Date"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=2).Value = _shortDate.Date.ToShortDateString
            GridviewDetails.Item(columnIndex:=0, rowIndex:=3).Value = "Customer Name"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=3).Value = dr(0)
            GridviewDetails.Item(columnIndex:=0, rowIndex:=4).Value = "Mobile Number"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=4).Value = Trim(dr(1))
            GridviewDetails.Item(columnIndex:=0, rowIndex:=5).Value = "Inbound Cardamom"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=5).Value = dr(2)
            GridviewDetails.Item(columnIndex:=0, rowIndex:=6).Value = "Outbound Cardamom"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=6).Value = dr(3)
            GridviewDetails.Item(columnIndex:=0, rowIndex:=7).Value = "Rate Rs ."
            GridviewDetails.Item(columnIndex:=1, rowIndex:=7).Value = dr(5)
            GridviewDetails.Item(columnIndex:=0, rowIndex:=8).Value = "Total Rs ."
            GridviewDetails.Item(columnIndex:=1, rowIndex:=8).Value = Val(dr(2)) * Val(dr(5))
            GridviewDetails.Item(columnIndex:=0, rowIndex:=9).Value = "Advance Rs."
            GridviewDetails.Item(columnIndex:=1, rowIndex:=9).Value = dr(4)

            Dim dr1 As SqlDataReader
            dr1 = db.reader("select u.name,u.loginid,t.loginid from TABLEUSER u,TABLETRANSACTION t where t.loginid=u.loginid")
            dr1.Read()
            GridviewDetails.Item(columnIndex:=0, rowIndex:=1).Value = "Sales Person"
            GridviewDetails.Item(columnIndex:=1, rowIndex:=1).Value = dr1(0)
        End If
       
       
    End Sub
End Class