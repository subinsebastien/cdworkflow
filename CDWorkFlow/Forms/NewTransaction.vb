Imports System.Data.SqlClient
Imports System.Drawing.Graphics
Module mod1
    Public prebal As New Decimal
End Module
Public Class New_Transaction
    Dim _prebal As Decimal
    Dim db As New DataBaseInterface
    Dim globalDataReader As SqlDataReader
    Dim checkForNewEntry As Integer = 0
    Dim customerId As Integer
    Dim tempSum As Decimal
    Dim ProcessedTotal As Decimal
    Dim chk_insert As Integer = 0

    Public Function claculateSum()
        Dim _getfraction As Decimal
        Dim _uRate As Decimal
        Dim _credit As Decimal
        Dim _freshcardamom As Decimal = 0
       
        Try
            If txtdue.Text <> "" Then

                tempSum = Convert.ToDecimal(txtdue.Text)
            End If
        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("plese enter in correct format", 1)
            txtdue.Clear()
            txtdue.Text = "0.00"

        End Try
      
        Try
            If txtcredit.Text <> "" Then

                _credit = Convert.ToDecimal(txtcredit.Text)
            End If
        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("plese enter in correct format", 1)
            txtcredit.Clear()
            txtcredit.Text = "0.00"

        End Try
        Try
            If txtinkg.Text <> "" Then

                _freshcardamom = Convert.ToDecimal(txtinkg.Text)
            End If

        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("plese enter in correct format", 1)
            txtinkg.Clear()
            txtinkg.Text = "0.00"
        End Try

        Try
            If cmburate.Text <> "" Then
                _uRate = Convert.ToDecimal(cmburate.Text)
            End If
        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("plese enter in correct format", 1)
            cmburate.Focus()

        End Try



        Try
            If txtoutkg.Text <> "" Then

            End If
        Catch ex As Exception
            StatusBarUpdater.updateStatusBar("plese enter in correct format", 1)
            txtoutkg.Focus()

        End Try

        tempSum = tempSum + _freshcardamom * _uRate - _credit
        _getfraction = tempSum Mod 1
        If _getfraction <= 0.5 And _getfraction <> 0 Then
            Dim _findRoundValue As Decimal
            If _getfraction < 0 Then
                _findRoundValue = 0.5 + _getfraction
            Else
                _findRoundValue = 0.5 - _getfraction
            End If

            tempSum += _findRoundValue
            'MsgBox(_findRoundValue)
        Else
            tempSum = System.Math.Round(tempSum)

        End If
        'MsgBox(System.Math.Round(tempSum, ))
        Return tempSum
        'label18.Text = tempSum
        'Return (tempSum + _freshcardamom * _uRate - _credit)

    End Function

    Function fieldvalidation(ByVal tbox As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("0123456789.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            tbox.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Numerals only", 1)
            tbox.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            tbox.Focus()
        End If
        Return 0
    End Function

    Private Sub New_Transaction_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        StatusBarUpdater.updateStatusBar("", 4)
    End Sub

    Private Sub New_Transaction_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub New_Transaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        
    End Sub

    Private Sub New_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.tsslok.Visible = False
        prebal = 0.0
        indate.Value = Date.Today
        lbluname.Text = Home.userName
        If chk_insert = 1 Then
            cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
            globalDataReader = db.reader("select name from TABLECUSTOMER")
            If globalDataReader.HasRows Then
                While globalDataReader.Read
                    cmbcname.Items.Add(Trim(globalDataReader(0)))
                End While
            End If
        Else
            StatusBarUpdater.updateStatusBar("", 4)
            txtaddress.Enabled = False
            txtmobile.Enabled = False
            txtdue.Enabled = False
            MdiParent = Home
            globalDataReader = db.reader("select MAX(ID) from TABLETRANSACTION")
            Dim c As Integer = 0
            globalDataReader.Read()
            If (globalDataReader.IsDBNull(0)) Then
                Label16.Text = "_"
            Else
                Label16.Text = Val(globalDataReader(0)) + 1
            End If
            cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
            globalDataReader = db.reader("select name from TABLECUSTOMER")
            If globalDataReader.HasRows Then
                While globalDataReader.Read
                    cmbcname.Items.Add(Trim(globalDataReader(0)))
                End While
            Else

            End If
            cmbcname.Focus()
        End If
    End Sub

    Private Sub cmbcname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcname.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txtmobile.Focus()
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub cmbcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcname.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            Home.tssldefault.Visible = True
            Home.tsslwarning.Visible = False
            Home.tsslerror.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            cmbcname.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Characters only", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            cmbcname.Focus()
        End If
    End Sub

    Private Sub cmbcname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcname.TextChanged
        globalDataReader = db.reader("select * from TABLECUSTOMER where name = '" & Trim(cmbcname.Text) & "' ")
        globalDataReader.Read()
        If globalDataReader.HasRows Or Trim(cmbcname.Text) = "" Then
            checkForNewEntry = 0
            txtaddress.Enabled = False
            txtmobile.Enabled = False
            txtdue.Enabled = False
        Else
            checkForNewEntry = 1
            txtaddress.Text = ""
            txtmobile.Text = ""
            txtdue.Text = ""
            txtinkg.Text = "0.00"
            txtcredit.Text = "0.00"
            txtdue.Text = "0.00"
            txtaddress.Enabled = True
            txtmobile.Enabled = True
            txtdue.Enabled = True
            txtcredit.Enabled = True
            txtinkg.Enabled = True
            txtoutkg.Enabled = True
            cmburate.Enabled = True

        End If
    End Sub

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged

        txtcredit.Enabled = True
        txtinkg.Enabled = True
        txtoutkg.Enabled = True
        cmburate.Enabled = True
        Dim dataReader As SqlDataReader
        globalDataReader = db.reader("select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' ")
        globalDataReader.Read()
        customerId = globalDataReader(0)


        If globalDataReader.HasRows Then

            If IsDBNull(globalDataReader(2)) Then
                txtmobile.Text = "null"
                txtaddress.Text = globalDataReader(3)
            Else
                txtmobile.Text = globalDataReader(2)
                txtaddress.Text = globalDataReader(3)
            End If
            dataReader = db.reader("select runbalance from TABLETRANSACTION where customerid=" & customerId & " order by id desc")
            dataReader.Read()

            If dataReader.HasRows Then
                txtdue.Text = Val(dataReader(0)).ToString("#,##0.00")
                tempSum = dataReader(0)
                txtinkg.Focus()
                label18.Text = "Balance Rs. " + Val(dataReader(0)).ToString("#,##0.00")
                prebal = Val(dataReader(0))

            Else
                prebal = 0.0
                txtinkg.Focus()
                label18.Text = "Balance Rs. 0.00"

                txtdue.Text = "0.00"
            End If
            


        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
       

        If checkForNewEntry = 1 And chk_insert = 0 Then


            If Trim(cmbcname.Text) = "" Then
                StatusBarUpdater.updateStatusBar("Please select name", 1)
                cmbcname.Focus()
            ElseIf Trim(txtaddress.Text) = "" Then
                StatusBarUpdater.updateStatusBar("enter adress", 1)
                txtaddress.Focus()
            ElseIf Trim(txtmobile.Text) = "" Then
                StatusBarUpdater.updateStatusBar("Enter mobile No", 1)
                txtmobile.Focus()
            Else
                db.manipulate("insert into TABLECUSTOMER values('" & cmbcname.Text & "'," & txtmobile.Text & ",'" & txtaddress.Text & "') ")

                chk_insert = 1
                New_Transaction_Load(Me, New System.EventArgs)

            End If


        End If

        If checkForNewEntry = 0 Or chk_insert = 1 Then
            Dim instatus As Boolean
            Dim outstatus As Boolean
            Dim creditstatus As Boolean
            outstatus = txtoutkg.Text = "0.0" Or Val(txtoutkg.Text) = 0
            instatus = txtinkg.Text = "0.0" Or Val(txtinkg.Text) = 0
            creditstatus = txtcredit.Text = "0.00" Or Val(txtcredit.Text) = 0

            If Trim(cmbcname.Text) = "" Then

                StatusBarUpdater.updateStatusBar("Please select name", 1)
                cmbcname.Focus()
                'ElseIf txtdue.Text <> 0 And instatus = True And outstatus = True And creditstatus = True Then
                '    MsgBox("ya working")
            ElseIf checkForNewEntry = 1 And (Val(txtinkg.Text) = 0 And Val(txtoutkg.Text) = 0 And Val(txtcredit.Text) = 0) Then

                Try
                    globalDataReader = db.reader("select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' ")
                    globalDataReader.Read()
                    customerId = globalDataReader(0)
                    Dim _inbound As Decimal = 0.0
                    Dim _outbound As Decimal = 0.0
                    Dim _advancde As Decimal = 0.0
                    Dim _ratekg As Decimal = 0.0

                    db.manipulate("insert into TABLETRANSACTION values(" & Home.logid & ",'" & indate.Text & "'," & customerId & "," & _inbound & "," & _outbound & " ," & _advancde & "," & _ratekg & "," & Val(txtdue.Text) & ")   ")
                    Me.Close()
                    StatusBarUpdater.updateStatusBar("Transaction Completed", 5)
                Catch ex As Exception
                    StatusBarUpdater.updateStatusBar("Please enter in correct format", 1)
                    txtdue.Focus()
                End Try
            ElseIf (instatus And outstatus And creditstatus) Then

                StatusBarUpdater.updateStatusBar("Enter any values", 1)
                txtinkg.Focus()

            Else

                ProcessedTotal = claculateSum()
                globalDataReader = db.reader("select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' ")
                globalDataReader.Read()
                customerId = globalDataReader(0)
                Dim _creditvalue As Decimal = txtcredit.Text
                'MsgBox(_creditvalue)
                db.manipulate("insert into TABLETRANSACTION values(" & Home.logid & ",'" & indate.Text & "'," & customerId & "," & Val(txtinkg.Text) & "," & Val(txtoutkg.Text) & " ," & _creditvalue & "," & Val(cmburate.Text) & "," & ProcessedTotal & ")   ")
                Me.Close()

                StatusBarUpdater.updateStatusBar("Transaction Completed", 5)
                If cbprintonexit.Checked = True Then
                    If checkForNewEntry = 1 Then
                        prebal = _prebal
                    End If

                    PrintDocument1.Print()
                End If

            End If
        End If



    End Sub

    Private Sub txtinkg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinkg.Click
        If txtinkg.Text = "0.00" Then
            txtinkg.Clear()
        End If
    End Sub

    Private Sub txtinkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinkg.GotFocus
        If txtinkg.Text = "0.000" Then
            txtinkg.Clear()
        End If
    End Sub

    Private Sub txtcredit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.Click
        StatusBarUpdater.updateStatusBar("", 4)
        txtcredit.Clear()
    End Sub

    Private Sub txtcredit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.GotFocus
        If txtcredit.Text = "0.00" Then
            txtcredit.Clear()
        End If

    End Sub

    Private Sub txtoutkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoutkg.GotFocus
        If txtoutkg.Text = 0.0 Then
            txtoutkg.Clear()
        End If

    End Sub

    Private Sub txtcredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtcredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcredit.KeyPress
        fieldvalidation(txtcredit, e)
    End Sub

    Private Sub txtcredit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.Leave
        Dim s As String
        Dim _txtCredit As String = txtcredit.Text
        If (Trim(txtcredit.TextLength = 0)) Then
            txtcredit.Text = "0.00"
        Else
            s = Convert.ToDecimal(_txtCredit).ToString("#,##0.00")
            txtcredit.Text = s
        End If
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")

    End Sub

    Private Sub cmburate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmburate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmburate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmburate.KeyPress
        If InStr("0123456789.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            cmburate.Focus()
        Else
            e.KeyChar = ""
        End If
        If Asc(e.KeyChar) = 13 Then
            cmburate.Focus()
        End If

    End Sub

    Private Sub cmburate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmburate.SelectedIndexChanged
        label18.Text = "Balance Rs." + (Val(claculateSum()).ToString("#,##0.00"))
    End Sub

    Private Sub txtdue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdue.GotFocus
        txtdue.Clear()
    End Sub

    Private Sub txtdue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdue.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdue.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
        fieldvalidation(txtdue, e)
    End Sub

    Private Sub txtdue_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdue.Leave
        Dim _due As String = txtdue.Text
        Dim s As String
        If (Trim(txtdue.TextLength = 0)) Then
            txtdue.Text = "0.000"
        Else
            s = Convert.ToDecimal(_due).ToString("#,##0.00")
            txtdue.Text = s
        End If
        If checkForNewEntry = 1 Then
            _prebal = (Val(txtdue.Text))
        End If

    End Sub

    Private Sub txtdue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdue.TextChanged
        label18.Text = "Balance Rs." + (Val(txtdue.Text).ToString("#,##0.00"))
    End Sub

    Private Sub txtinkg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinkg.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtinkg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinkg.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
        fieldvalidation(txtinkg, e)
    End Sub

    Private Sub txtinkg_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinkg.Leave
        Dim _inKg As String = txtinkg.Text
        Dim s As String
        If (Trim(txtinkg.TextLength = 0)) Then
            txtinkg.Text = "0.000"
        Else
            s = Convert.ToDecimal(_inKg).ToString("#,##0.000")
            txtinkg.Text = s
        End If
      
        'If Val(txtinkg.Text) <> 0 Then
        '    s = Convert.ToDecimal(_inKg).ToString("#,##0.000")
        '    MsgBox(s)
        'End If
    End Sub

    Private Sub txtinkg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinkg.TextChanged

        label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")
        'txtinkg.Text = Convert.ToDecimal(_inKg).ToString("#,##0.000")

    End Sub

    Private Sub cmburate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmburate.TextChanged
        'label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")
        label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")
    End Sub

    Private Sub txtmobile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmobile.KeyDown
        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Enter Numerals", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        End If
    End Sub

    Private Sub txtoutkg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtoutkg.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtoutkg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoutkg.KeyPress
        fieldvalidation(txtoutkg, e)
    End Sub

    Private Sub lbluname_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbluname.LinkClicked
        EditUserDetails.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        ViewInventory.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        PrinterInterface.printLastTransaction(e)
    End Sub

    

   
    Private Sub txtoutkg_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoutkg.Leave
        Dim s As String
        Dim _outKg As String = txtoutkg.Text
        Try
            If (Trim(txtoutkg.TextLength = 0)) Then
                txtoutkg.Text = "0.000"
            Else
                s = Convert.ToDecimal(_outKg).ToString("#,##0.000")
                txtoutkg.Text = s
            End If

        Catch ex As Exception
            txtoutkg.Focus()
        End Try
        
       
    End Sub

    Private Sub txtmobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.LostFocus
        If Trim(txtmobile.TextLength) < 10 Then
            StatusBarUpdater.updateStatusBar("enter Valid Number", 1)
            txtmobile.Focus()

        End If
    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewDeleteLog.Show()
    End Sub
End Class