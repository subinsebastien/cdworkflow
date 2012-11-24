Imports System.Data.SqlClient
Imports System.Drawing.Graphics
Public Class New_Transaction
    Dim db As New DataBaseInterface
    Dim globalDataReader As SqlDataReader
    Dim checkForNewEntry As Integer = 0
    Dim customerId As Integer
    Dim tempSum As Decimal
    Dim ProcessedTotal As Decimal
    Dim chk_insert As Integer = 0
    Function claculateSum()
        tempSum = Val(txtdue.Text)
        Return tempSum + (Val(txtinkg.Text) * Val(cmburate.Text) - Val(txtcredit.Text))
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

    Private Sub New_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            txtinkg.Text = "0.0"
            txtcredit.Text = "0.00"
            txtdue.Text = "0.00"
            txtaddress.Enabled = True
            txtmobile.Enabled = True
            txtdue.Enabled = True
        End If
    End Sub

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged
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
            Else
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
                StatusBarUpdater.updateStatusBar("Please Enter contact Number", 1)
                txtmobile.Focus()

            Else
                'If Trim(txtmobile.Text) = "" Then
                '    txtmobile.Text = "null"
                'End If
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
            ElseIf (instatus And outstatus And creditstatus) Then

                StatusBarUpdater.updateStatusBar("Enter any values", 1)
                txtinkg.Focus()
            Else
                ProcessedTotal = claculateSum()
                globalDataReader = db.reader("select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' ")
                globalDataReader.Read()
                customerId = globalDataReader(0)
                db.manipulate("insert into TABLETRANSACTION values(" & Home.logid & ",'" & indate.Text & "'," & customerId & "," & Val(txtinkg.Text) & "," & Val(txtoutkg.Text) & " ," & Val(txtcredit.Text) & "," & Val(cmburate.Text) & "," & ProcessedTotal & ")   ")
                Me.Close()

                StatusBarUpdater.updateStatusBar("Transaction Completed", 2)
            End If
        End If
    End Sub

    Private Sub txtinkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinkg.GotFocus
        If txtinkg.Text.ToString = "0.0" Then
            txtinkg.Clear()
        End If
    End Sub

    Private Sub txtcredit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.GotFocus
        txtcredit.Clear()
    End Sub

    Private Sub txtoutkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoutkg.GotFocus
        If txtoutkg.Text = 0.0 Then
            txtoutkg.Clear()
        End If

    End Sub

    Private Sub txtcredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcredit.KeyPress
        fieldvalidation(txtcredit, e)
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        label18.Text = "Balance Rs." + Val(claculateSum()).ToString
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
        label18.Text = "Balance Rs." + (Val(claculateSum()).ToString)
    End Sub

    Private Sub txtdue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdue.GotFocus
        txtdue.Clear()
    End Sub

    Private Sub txtdue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdue.KeyPress
        fieldvalidation(txtdue, e)
    End Sub

    Private Sub txtdue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdue.TextChanged
        label18.Text = "Balance Rs." + (Val(txtdue.Text).ToString)
    End Sub

    Private Sub txtinkg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinkg.KeyPress
        fieldvalidation(txtinkg, e)
    End Sub

    Private Sub txtinkg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinkg.TextChanged
        label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")
    End Sub

    Private Sub cmburate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmburate.TextChanged
        label18.Text = "Balance Rs." + Val(claculateSum()).ToString("#,##0.00")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
        'Dim f As System.Drawing.Printing.PrintPageEventArgs
        'PrinterInterface.printLastTransaction(f)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StatusBarUpdater.updateStatusBar("oh God", 3)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class