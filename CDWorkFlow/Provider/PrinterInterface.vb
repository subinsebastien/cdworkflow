Imports System.Data.SqlClient


Public Class PrinterInterface

    Shared fontMonacoBold As New Font("Monaco", 9, FontStyle.Bold)
    Shared fontMonaco As New Font("Monaco", 9, FontStyle.Regular)

    Public Shared Sub printLastTransaction(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'find the the last transaction id and call the proper ladder
        Dim dr As SqlDataReader
        Dim db As New DataBaseInterface
        dr = db.reader("select max(id) from TABLETRANSACTION")
        dr.Read()
        If (Not (dr.IsDBNull(0))) Then
            printTransactionById(CInt(dr(0)), e)
        End If
    End Sub

    Public Shared Sub printTransactionById(ByVal tId As Integer, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'get data from different tables and call the proper ladder
        Dim dr As SqlDataReader
        Dim dr1 As SqlDataReader
        Dim dr2 As SqlDataReader
        Dim db As New DataBaseInterface
        Dim db1 As New DataBaseInterface
        Dim db2 As New DataBaseInterface
        dr = db.reader("select * from TABLETRANSACTION where id=" & tId & "")
        dr.Read()
        dr1 = db1.reader("select name from TABLEUSER where loginid=" & dr(1) & "")
        dr1.Read()
        dr2 = db2.reader("select name from TABLECUSTOMER where customerid=" & dr(3) & "")
        dr2.Read()

        'getting the values(date and time\)
        Dim _time As String = DateTime.Now.ToString("HH:mm:ss")
        Dim _date As Date = dr(2)

        'calculation of total balance...etc
        Dim _ttotal As Decimal = Val(dr(4)) * Val(dr(7))
        Dim _total As String = _ttotal.ToString("#,##0.00")

        Dim c As Decimal = dr(7)
        Dim d As Decimal = dr(8)
        Dim r As Decimal = dr(6)

        Dim _charge As Decimal = c.ToString("#,##0.00")
        Dim _runBalance As Decimal = d.ToString("#,##0.00")
        Dim _amountRecivd As Decimal = r.ToString("#,##0.00")
        Dim _balance As Decimal = Val(dr(8)) - Val(dr(6))

        Dim _salesPrsn As String = dr1(0)
        Dim _custName As String = dr2(0)
        Dim _qtyOne As Decimal = dr(4)
        Dim _qtyTwo As Decimal = dr(5)

        Dim _transId As Integer = Val(dr(0))

        printTransaction(_transId, _date, _time, _salesPrsn, _custName, _
                            _qtyOne.ToString("#,##0.000"), _qtyTwo.ToString("#,##0.000"), _
                            _charge.ToString("#,##0.00"), _total, _amountRecivd, _runBalance, _balance, e)

    End Sub

    Private Shared Sub printTransaction(ByVal tId As Integer, ByVal tDate As Date, ByVal tTime As String, _
                                        ByVal salesPerson As String, ByVal custName As String, _
                                        ByVal qtyOne As Decimal, ByVal qtyTwo As Decimal, ByVal charge As Decimal, _
                                        ByVal total As Decimal, ByVal amountRecvd As Decimal, _
                                        ByVal runBalance As Decimal, ByVal Balance As Decimal, _
                                        ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'define measures
        Dim unitWidth As Integer = 26
        Dim unitHeight As Integer = 20

        Dim columnSpacing = 10

        Dim columnOne As Integer = unitWidth * 1 - 20
        Dim columnTwo As Integer = columnOne + unitWidth * 4 + columnSpacing
        Dim columnThree As Integer = columnTwo + unitWidth * 3 + columnSpacing
        Dim columnFour As Integer = columnThree + unitWidth * 3 + columnSpacing

        Dim recieptWidth As Integer = unitWidth * 15
        Dim recieptHeight As Integer = unitWidth * 18

        'declare pre-requisites
        Dim recieptBitmap As New Bitmap(recieptWidth, recieptHeight, Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(recieptBitmap)
        g.Clear(Color.White)
        Dim b As Brush = Brushes.Black

        'draw fixed strings


        'g.DrawString("Cardamom Drier", fontMonacoBold, b, columnOne, unitHeight * 1)
        'g.DrawString("Receipt", fontMonacoBold, b, columnFour, unitHeight * 1)
        'g.DrawString("St. George's Church", fontMonacoBold, b, columnOne, unitHeight * 2)

        'g.DrawString("Description", fontMonacoBold, b, columnOne, unitHeight * 3)
        'g.DrawString("Qty(Kg)", fontMonacoBold, b, columnTwo, unitHeight * 3)
        'g.DrawString("Rate(Rs)", fontMonacoBold, b, columnThree, unitHeight * 3)
        'g.DrawString("Amount(Rs)", fontMonacoBold, b, columnFour, unitHeight * 3)

        'g.DrawString("Fresh Cardamom", fontMonaco, b, columnOne, unitHeight * 4)
        'g.DrawString(salesPerson, fontMonaco, b, columnTwo, unitHeight * 4)
        'g.DrawString(charge, fontMonaco, b, columnThree, unitHeight * 4)
        'g.DrawString(amountRecvd, fontMonaco, b, columnFour, unitHeight * 4)

        '*****************************************************


        g.DrawString("Cardamom Drier", fontMonacoBold, b, columnOne, unitHeight * 1)
        g.DrawString("Receipt", fontMonacoBold, b, columnFour, unitHeight * 1)
        g.DrawString("St. George's Church", fontMonacoBold, b, columnOne, unitHeight * 2)
        g.DrawString("Transaction Id : ", fontMonaco, b, columnTwo, unitHeight * 3)
        g.DrawString("Date : ", fontMonaco, b, columnTwo, unitHeight * 4)
        g.DrawString("Sales Person : ", fontMonaco, b, columnTwo, unitHeight * 5)
        g.DrawString("Customer Name : ", fontMonaco, b, columnTwo, unitHeight * 6)

        'g.DrawString("Description", fontMonacoBold, b, columnOne, unitHeight * 3)
        'g.DrawString("Qty(Kg)", fontMonacoBold, b, columnTwo, unitHeight * 3)
        'g.DrawString("Rate(Rs)", fontMonacoBold, b, columnThree, unitHeight * 3)
        'g.DrawString("Amount(Rs)", fontMonacoBold, b, columnFour, unitHeight * 3)

        'g.DrawString("Inbound Cardamom", fontMonaco, b, columnOne, unitHeight * 4)
        'g.DrawString("OutBound Cardamom", fontMonaco, b, columnOne, unitHeight * 5)
        'g.DrawString(salesPerson, fontMonaco, b, columnTwo, unitHeight * 4)
        'g.DrawString(charge, fontMonaco, b, columnThree, unitHeight * 4)
        'g.DrawString(amountRecvd, fontMonaco, b, columnFour, unitHeight * 4)


        Dim location As New PointF(0, 0)
        e.Graphics.DrawImage(recieptBitmap, location)
        e.Graphics.Dispose()

    End Sub

End Class