Imports System.Data.SqlClient
Imports System.Drawing.Graphics



Public Class PrinterInterface

    Shared fontBold As New Font("Monaco", 10, FontStyle.Bold)
    Shared fontRegular As New Font("Monaco", 10, FontStyle.Regular)

    Private Shared Function getRightAlignX(ByVal leftX As Decimal, ByVal paramString As String) As Decimal
        Dim G As Graphics = New_Transaction.CreateGraphics
        Dim stringSize As New SizeF
        stringSize = G.MeasureString(paramString, fontRegular)
        Return leftX - stringSize.Width
    End Function

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
        Dim d As Decimal = Val(dr(8))
        Dim r As Decimal = dr(6)

        Dim _charge As Decimal = c.ToString("#,##0.00")
        Dim _runBalance As Decimal = d.ToString("#,##0.00")
        ' _runBalance = _runBalance + r - _total
        _runBalance = prebal
        Dim _amountRecivd As Decimal = r.ToString("#,##0.00")


        Dim _salesPrsn As String = dr1(0)
        Dim _custName As String = dr2(0)
        Dim _qtyOne As Decimal = dr(4)
        Dim _qtyTwo As Decimal = dr(5)


        Dim _balance As Decimal = _runBalance + _total - _amountRecivd
        Dim _getfraction As Decimal

        _getfraction = _balance Mod 1
        If _getfraction <= 0.5 And _getfraction <> 0 Then
            Dim _findRoundValue As Decimal
            If _getfraction < 0 Then
                _findRoundValue = 0.5 + _getfraction
            Else
                _findRoundValue = 0.5 - _getfraction
            End If

            _balance += _findRoundValue
            'MsgBox(_findRoundValue)
        Else
            _balance = System.Math.Round(_balance)

        End If





        
        'Dim _balance As Decimal = prebal








        Dim _transId As Integer = Val(dr(0))

        printTransaction(_transId, _date, _time, _salesPrsn, _custName, _
                            _qtyOne.ToString("#,##0.000"), _qtyTwo.ToString("#,##0.000"), _
                            _charge.ToString("#,##0.00"), _total, _amountRecivd, _runBalance.ToString("#,##0.00"), _balance.ToString("#,##0.00"), e)

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
        Dim columnTwo As Integer = columnOne + unitWidth * 3 + columnSpacing
        Dim columnThree As Integer = columnTwo + unitWidth * 3 + columnSpacing
        Dim columnFour As Integer = columnThree + unitWidth * 3 + columnSpacing
        Dim columnFive As Integer = columnFour + unitWidth * 4
        Dim recieptWidth As Integer = unitWidth * 15
        Dim recieptHeight As Integer = unitWidth * 21

        'declare pre-requisites
        Dim recieptBitmap As New Bitmap(recieptWidth, recieptHeight, Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(recieptBitmap)
        g.Clear(Color.White)
        Dim b As Brush = Brushes.Black

        'draw fixed strings

        '*****************************************************
        Dim stringLength As Decimal

        g.DrawString("Cardamom Drier", fontBold, b, columnOne, unitHeight * 1)
        g.DrawString("Receipt", fontBold, b, getRightAlignX(columnFive, "Receipt"), unitHeight * 1)
        g.DrawString("St. Joseph's Church", fontBold, b, columnOne, unitHeight * 2)
        g.DrawString("", fontRegular, b, columnTwo, unitHeight * 3)
        stringLength = getRightAlignX(columnThree, "Transaction Id : ")
        g.DrawString("Transaction Id : ", fontRegular, b, stringLength, unitHeight * 4)
        stringLength = getRightAlignX(columnThree, "Date : ")
        g.DrawString("Date : ", fontRegular, b, stringLength, unitHeight * 5)
        stringLength = getRightAlignX(columnThree, "Sales Person : ")
        g.DrawString("Sales Person : ", fontRegular, b, stringLength, unitHeight * 6)
        stringLength = getRightAlignX(columnThree, "Customer Name : ")
        g.DrawString("Customer Name : ", fontRegular, b, stringLength, unitHeight * 7)
        g.DrawString("", fontRegular, b, columnTwo, unitHeight * 8)
        g.DrawString("Description", fontBold, b, columnOne, unitHeight * 9)
        g.DrawString("Qty(Kg)", fontBold, b, getRightAlignX(columnThree, "Qty(Kg)"), unitHeight * 9)
        g.DrawString("Rate(Rs)", fontBold, b, getRightAlignX(columnFour, "Rate(Rs)"), unitHeight * 9)
        g.DrawString("Amount(Rs)", fontBold, b, getRightAlignX(columnFive, "Amount(Rs)"), unitHeight * 9)

        g.DrawString("Fresh", fontRegular, b, columnOne, unitHeight * 10)
        g.DrawString("Processed", fontRegular, b, columnOne, unitHeight * 11)
        g.DrawString("", fontRegular, b, columnOne, unitHeight * 12)

        stringLength = getRightAlignX(columnFour, "Total :")
        g.DrawString("Total :", fontRegular, b, stringLength, unitHeight * 13)
        stringLength = getRightAlignX(columnFour, "Prev Balance :")
        g.DrawString("Prev Balance :", fontRegular, b, stringLength, unitHeight * 14)
        g.DrawString("", fontRegular, b, columnThree, unitHeight * 15)
        stringLength = getRightAlignX(columnFour, "Grand Total :")
        g.DrawString("Grand Total :", fontRegular, b, stringLength, unitHeight * 16)
        stringLength = getRightAlignX(columnFour, "Amount Recived :")
        g.DrawString("Amount Recived :", fontRegular, b, stringLength, unitHeight * 17)
        stringLength = getRightAlignX(columnFour, "Balance :")
        g.DrawString("Balance :", fontRegular, b, stringLength, unitHeight * 18)

        'draw values

        g.DrawString(tId, fontRegular, b, columnThree, unitHeight * 4)
        g.DrawString(tDate, fontRegular, b, columnThree, unitHeight * 5)
        g.DrawString(salesPerson, fontRegular, b, columnThree, unitHeight * 6)
        g.DrawString(custName, fontRegular, b, columnThree, unitHeight * 7)

        g.DrawString(qtyOne, fontRegular, b, getRightAlignX(columnThree, qtyOne.ToString), unitHeight * 10)
        g.DrawString(qtyTwo, fontRegular, b, getRightAlignX(columnThree, qtyTwo.ToString), unitHeight * 11)
        g.DrawString(charge, fontRegular, b, getRightAlignX(columnFour, charge.ToString), unitHeight * 10)
        g.DrawString(total, fontRegular, b, getRightAlignX(columnFive, total.ToString), unitHeight * 10)
        g.DrawString(total, fontRegular, b, getRightAlignX(columnFive, total.ToString), unitHeight * 13)
        g.DrawString(runBalance, fontRegular, b, getRightAlignX(columnFive, runBalance.ToString), unitHeight * 14)
        g.DrawString((total + runBalance), fontRegular, b, getRightAlignX(columnFive, (total + runBalance).ToString), unitHeight * 16)
        g.DrawString(amountRecvd, fontRegular, b, getRightAlignX(columnFive, amountRecvd.ToString), unitHeight * 17)
        g.DrawString(Balance, fontRegular, b, getRightAlignX(columnFive, Balance.ToString), unitHeight * 18)
        g.DrawString(".", fontRegular, b, columnThree, unitHeight * 21)
        Dim location As New PointF(0, 0)
        e.Graphics.DrawImage(recieptBitmap, location)
        e.Graphics.Dispose()

    End Sub


End Class