Imports System.Data.SqlClient
Public Class New_Transaction
    Dim db As New Class1
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim str As String
    Dim chk_new As Integer = 0
    Dim cust_id As Integer
    Dim temp_sum As Integer
    Dim sum1 As Integer
    Dim chk_insert As Integer = 0

    Function sumcal()
        temp_sum = Val(txtdue.Text)
        Return temp_sum + (Val(txtinkg.Text) * Val(cmburate.Text) - Val(txtcredit.Text))
        'Return sum1
    End Function
    Function fieldvalidation(ByVal tbox As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("0123456789.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            tbox.Focus()
        Else
            e.KeyChar = ""
            drier_name.tssldefault.Visible = False
            drier_name.tsslerror.Visible = False
            drier_name.tsslwarning.Text = "numerals only"
            drier_name.tsslwarning.Visible = True
            tbox.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            tbox.Focus()
        End If
        Return 0
    End Function
    Private Sub New_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        lbluname.Text = drier_name.txtuname.Text
        If chk_insert = 1 Then
            cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
            'cmbcname.Text = singleview.cmbcname.Text
            str = "select name from TABLECUSTOMER"
            dr = db.reader(str)
            If dr.HasRows Then
                While dr.Read
                    cmbcname.Items.Add(Trim(dr(0)))
                End While
            End If
        Else




            drier_name.tssldefault.Visible = True
            drier_name.tsslwarning.Visible = False
            drier_name.tsslerror.Visible = False
            txtaddress.Enabled = False
            txtmobile.Enabled = False
            txtdue.Enabled = False

            MdiParent = drier_name
            str = "select count(*) from TABLETRANSACTION"
            dr = db.reader(str)
            Dim c As Integer = 0
            dr.Read()
            If (Val(dr(0)) = 0) Then

                Label16.Text = 1

            Else
                Label16.Text = dr(0) + 1
            End If

            cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
            'cmbcname.Text = singleview.cmbcname.Text
            str = "select name from TABLECUSTOMER"
            dr = db.reader(str)
            If dr.HasRows Then
                While dr.Read
                    cmbcname.Items.Add(Trim(dr(0)))
                End While
            Else

            End If
            cmbcname.Focus()
        End If
    End Sub

    Private Sub cmbcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcname.KeyPress
        drier_name.tssldefault.Visible = True
        drier_name.tsslwarning.Visible = False
        drier_name.tsslerror.Visible = False
    End Sub

    

    Private Sub cmbcname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcname.LostFocus

        
        If Trim(cmbcname.Text) = "" Then
            drier_name.tssldefault.Visible = False
            drier_name.tsslerror.Visible = False
            drier_name.tsslwarning.Text = "please select name"
            drier_name.tsslwarning.Visible = True
            cmbcname.Focus()


        End If
    End Sub




    Private Sub cmbcname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcname.TextChanged
        'str = "select * from TABLECUSTOMER where name like '" & Trim(cmbcname.Text) & "%' "
        str = "select * from TABLECUSTOMER where name = '" & Trim(cmbcname.Text) & "' "
        dr = db.reader(str)
        dr.Read()

        If dr.HasRows Or Trim(cmbcname.Text) = "" Then

            'RichTextBox1.Visible = False
            'MsgBox(cmbcname.Text)
            chk_new = 0
            txtaddress.Enabled = False
            txtmobile.Enabled = False
            txtdue.Enabled = False

            'txtaddress.Text = ""
            'txtmobile.Text = ""
            'txtdue.Text = ""

            ' MsgBox(chk_new)
        Else

            chk_new = 1
            txtaddress.Text = ""
            txtmobile.Text = ""
            txtdue.Text = ""
            txtinkg.Text = "0.0"
            txtcredit.Text = "0.00"
            txtdue.Text = "0.00"
            ' MsgBox(chk_new)
            'MsgBox("no match")
            txtaddress.Enabled = True
            txtmobile.Enabled = True
            txtdue.Enabled = True

        End If
    End Sub



    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged
        str = "select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' "
        dr = db.reader(str)
        dr.Read()
        cust_id = dr(0)

        If dr.HasRows Then

            If IsDBNull(dr(2)) Then
                'MsgBox("sorry nuill")
                txtmobile.Text = "null"
                txtaddress.Text = dr(3)
            Else
                txtmobile.Text = dr(2)
                txtaddress.Text = dr(3)
            End If
            str = "select runbalance from TABLETRANSACTION where customerid=" & cust_id & " order by id desc"
            dr1 = db.reader(str)
            dr1.Read()

            If dr1.HasRows Then
                txtdue.Text = dr1(0)
                temp_sum = dr1(0)
                txtinkg.Focus()
            Else
                txtdue.Text = 0.0
            End If
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click



        If chk_new = 1 And chk_insert = 0 Then
            If Trim(cmbcname.Text) = "" Then

                drier_name.tssldefault.Visible = False
                drier_name.tsslerror.Visible = True
                drier_name.tsslwarning.Visible = False
                drier_name.tsslerror.Text = "please select name"
                cmbcname.Focus()
            ElseIf Trim(txtaddress.Text) = "" Then
                'MsgBox("no adress")
                drier_name.tssldefault.Visible = False
                drier_name.tsslerror.Visible = True
                drier_name.tsslwarning.Visible = False
                drier_name.tsslerror.Text = "enter adress"
                txtaddress.Focus()
            Else
                If Trim(txtmobile.Text) = "" Then
                    txtmobile.Text = "null"
                End If
                str = "insert into TABLECUSTOMER values('" & cmbcname.Text & "'," & Trim(txtmobile.Text) & ",'" & txtaddress.Text & "') "
                db.manipulate(str)
                chk_insert = 1

                New_Transaction_Load(Me, New System.EventArgs)

            End If

        End If

        If chk_new = 0 Or chk_insert = 1 Then
            Dim instatus As Boolean
            Dim outstatus As Boolean
            Dim creditstatus As Boolean
            outstatus = txtoutkg.Text = "0.0" Or Val(txtoutkg.Text) = 0
            instatus = txtinkg.Text = "0.0" Or Val(txtinkg.Text) = 0
            creditstatus = txtcredit.Text = "0.00" Or Val(txtcredit.Text) = 0
            'MsgBox(creditstatus)
            'MsgBox(instatus)
            'MsgBox(outstatus)

            If Trim(cmbcname.Text) = "" Then

                drier_name.tssldefault.Visible = False
                drier_name.tsslerror.Visible = True
                drier_name.tsslwarning.Visible = False
                drier_name.tsslerror.Text = "please select name"
                cmbcname.Focus()
            ElseIf (instatus And outstatus And creditstatus) Then

                drier_name.tssldefault.Visible = False
                drier_name.tsslerror.Visible = True
                drier_name.tsslwarning.Visible = False

                drier_name.tsslerror.Text = "enter any values"
                txtinkg.Focus()
            Else
                sum1 = sumcal()
                str = "select * from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "' "
                dr = db.reader(str)
                dr.Read()
                cust_id = dr(0)
                str = "insert into TABLETRANSACTION values(" & drier_name.logid & "," & indate.Text & "," & cust_id & "," & Val(txtinkg.Text) & "," & Val(txtoutkg.Text) & " ," & Val(txtcredit.Text) & "," & Val(cmburate.Text) & "," & sum1 & ")   "
                db.manipulate(str)
                Me.Close()

                drier_name.tssldefault.Visible = True
                drier_name.tsslerror.Visible = False
                drier_name.tsslwarning.Visible = False
                drier_name.tssldefault.Text = "transaction completed"
            End If
        End If
    End Sub

    Private Sub txtinkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtinkg.GotFocus

        txtinkg.Clear()
        label18.Text = "Balance Rs." + Val(txtdue.Text)

    End Sub



    Private Sub txtcredit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcredit.GotFocus
        txtcredit.Clear()
    End Sub

    Private Sub txtoutkg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoutkg.GotFocus
        txtoutkg.Clear()
    End Sub

    Private Sub txtcredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcredit.KeyPress
        fieldvalidation(txtcredit, e)
    End Sub

    Private Sub txtcredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcredit.TextChanged
        label18.Text = "Balance Rs." + Val(sumcal()).ToString
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
        label18.Text = "Balance Rs." + (Val(sumcal()).ToString)
    End Sub

    Private Sub txtdue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdue.GotFocus
        txtdue.Clear()
    End Sub

    Private Sub txtdue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdue.KeyPress
        fieldvalidation(txtdue, e)
    End Sub

    Private Sub txtdue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdue.LostFocus
        'Label10.Text = Val(txtdue.Text).ToString
    End Sub

    Private Sub txtdue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdue.TextChanged
        label18.Text = "Balance Rs." + (Val(txtdue.Text).ToString)
    End Sub

    Private Sub txtinkg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinkg.KeyPress
        fieldvalidation(txtinkg, e)
    End Sub

    Private Sub txtinkg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinkg.TextChanged
        label18.Text = "Balance Rs." + Val(sumcal()).ToString
    End Sub

    Private Sub cmburate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmburate.TextChanged
        label18.Text = "Balance Rs." + Val(sumcal()).ToString

        
    End Sub
    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        drier_name.tsslwarning.Visible = False
        drier_name.tsslerror.Visible = False
        drier_name.tssldefault.Visible = True
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        Else
            e.KeyChar = ""
            drier_name.tsslwarning.Text = "Enter numeric value"
            drier_name.tsslwarning.Visible = True
            drier_name.tssldefault.Visible = False
        End If
        If Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        End If


    End Sub
    Private Sub txtoutkg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoutkg.KeyPress
        fieldvalidation(txtoutkg, e)
    End Sub
End Class