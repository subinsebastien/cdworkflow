﻿Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class ViewInventory
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Public getCellContent As String

    Function grid_viewupdate(ByVal data_reader As SqlDataReader)
        Dim tot_row As Integer = 0
        Dim total_fresh_cdm As Decimal = 0
        Dim total_dried_cdm As Decimal
        Dim average_cdm As Double
        While (data_reader.Read())
            Dim _strng As String = "Name : " + dr(0).ToString + Environment.NewLine + "Adress : " + dr(1)
            'MsgBox(_strng)
            Dim calDate As Date
            calDate = data_reader(7)
            'calDate = calDate.Date
            total_fresh_cdm += Val(data_reader(2))
            total_dried_cdm += Val(data_reader(3))
            DataGridView1.Rows.Add()
            If Val(dr(6)) > 1000 Then
                DataGridView1.Rows(tot_row).DefaultCellStyle.BackColor = Color.Wheat
            End If
            If Val(dr(6)) < 0 Then
                DataGridView1.Rows(tot_row).DefaultCellStyle.BackColor = Color.Tomato
            End If
            DataGridView1.Item(columnIndex:=0, rowIndex:=tot_row).Value = calDate.Date.ToShortDateString
            DataGridView1.Item(columnIndex:=1, rowIndex:=tot_row).Value = data_reader(0)
            DataGridView1.Item(columnIndex:=2, rowIndex:=tot_row).Value = data_reader(2)
            DataGridView1.Item(columnIndex:=3, rowIndex:=tot_row).Value = data_reader(3)
            DataGridView1.Item(columnIndex:=4, rowIndex:=tot_row).Value = data_reader(4)
            DataGridView1.Item(columnIndex:=5, rowIndex:=tot_row).Value = data_reader(5)
            DataGridView1.Item(columnIndex:=6, rowIndex:=tot_row).Value = data_reader(6)
            DataGridView1.Item(columnIndex:=7, rowIndex:=tot_row).Value = data_reader(10)
            tot_row = tot_row + 1
        End While
        If Val(total_dried_cdm) = 0 Then
            average_cdm = "0.00"
        Else
            average_cdm = total_fresh_cdm / total_dried_cdm
        End If






        ConsolidationGridview.Rows.Add(3)
        ConsolidationGridview.Item(columnIndex:=0, rowIndex:=0).Value = "Inbound Cardamom"
        ConsolidationGridview.Item(columnIndex:=0, rowIndex:=1).Value = "outbound Cardamom"
        ConsolidationGridview.Item(columnIndex:=0, rowIndex:=2).Value = "Average"
        ConsolidationGridview.Item(columnIndex:=1, rowIndex:=0).Value = ":"
        ConsolidationGridview.Item(columnIndex:=1, rowIndex:=1).Value = ":"
        ConsolidationGridview.Item(columnIndex:=1, rowIndex:=2).Value = ":"
        ConsolidationGridview.Item(columnIndex:=2, rowIndex:=0).Value = total_fresh_cdm.ToString("#,##0.000")
        ConsolidationGridview.Item(columnIndex:=2, rowIndex:=1).Value = total_dried_cdm.ToString("#,##0.000")
        ConsolidationGridview.Item(columnIndex:=2, rowIndex:=2).Value = average_cdm.ToString("#,##0.000")

        totfresh.Text = total_fresh_cdm.ToString("#,##0.000")
        totdried.Text = total_dried_cdm.ToString("#,##0.000")
        totavg.Text = average_cdm.ToString("#,##0.000")
        Return 0
    End Function

    Private Sub ViewInventory_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        StatusBarUpdater.updateStatusBar("", 4)
    End Sub

    Private Sub output_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.tssldefault.Visible = True
        Home.tsslerror.Visible = False
        Home.tsslwarning.Visible = False
        Home.tsslok.Visible = False
        Me.MaximizeBox = False
        cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
        'cmbcname.Text = singleview.cmbcname.Text
        dr = db.reader("select name from TABLECUSTOMER")
        If dr.HasRows Then
            While dr.Read
                cmbcname.Items.Add(Trim(dr(0)))
            End While
        End If
        MdiParent = Home
        dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.id desc ")
        grid_viewupdate(dr)
    End Sub

    
    Private Sub chkbox_sort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbox_sort.CheckedChanged
        If chkbox_sort.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton5.Enabled = True

            If chkboxcustomer.Checked = False Then
                RadioButton4.Enabled = True
            End If
            RadioButton5.Checked = True
        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
        End If
    End Sub

    Private Sub chkboxcustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkboxcustomer.Click
        If chkboxcustomer.Checked = True Then
            RadioButton4.Enabled = False
            cmbcname.Enabled = True
            cmbcname.Text = "---Select Name---"
        ElseIf chkbox_sort.Checked = True Then
            RadioButton4.Enabled = True
        End If
        If chkboxcustomer.Checked = False Then
            cmbcname.Enabled = False
            cmbcname.Text = "---Select Name---"
        End If
    End Sub

    Private Sub cmbcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcname.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            StatusBarUpdater.updateStatusBar("", 4)
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.RowCount <> 0 Then
            Dim getCellNumber As Integer = DataGridView1.CurrentRow.Index
            getCellContent = DataGridView1.Item(7, getCellNumber).Value
        End If
    End Sub

    
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If Val(getCellContent) = 0 Then
            StatusBarUpdater.updateStatusBar("Please Select an item", 1)
        Else
            If MsgBox("Do you want to delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim _dataReader As SqlDataReader
                _dataReader = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.id=" & getCellContent & " ")
                _dataReader.Read()
                'Dim i As Integer = 0
                'For i = 0 To 10
                '    MsgBox(dr(i))
                'Next

                db.manipulate("insert into TABLEDELETELOG values('" & Home.label18.Text & "','" & _dataReader(7).ToString & "','" & _dataReader(0) & "'," & _dataReader(10) & "," & _dataReader(2) & "," & _dataReader(3) & "," & _dataReader(4) & "," & _dataReader(5) & "," & _dataReader(6) & ") ")
                'MsgBox(dr(7))
                db.manipulate("delete  from TABLETRANSACTION where id=" & getCellContent & "")
                Dim _sen As New System.Object
                RefreshButton_Click(_sen, e)
                getCellContent = 0
            End If
        End If
    End Sub

 

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        If Val(getCellContent = 0) Then
            StatusBarUpdater.updateStatusBar("Please Select an item", 1)
        Else
            TransactionDetails.Show()
        End If
    End Sub

    
    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        Dim custName As Boolean
        Dim dates As Boolean
        Dim sortby As Boolean
        If CheckBoxdate.Checked = True Then
            dates = True
        End If
        If chkboxcustomer.Checked = True Then
            custName = True
        End If
        If chkbox_sort.Checked = True Then
            sortby = True
        End If
        DataGridView1.Rows.Clear()
        If custName = True And Trim(cmbcname.Text) = "" Then
            StatusBarUpdater.updateStatusBar("Please select name", 1)
            cmbcname.Focus()
        Else
            Home.tsslerror.Visible = False
        End If
        If RadioButton5.Checked = True Then
            dr = db.reader("select  c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.id desc ")
            grid_viewupdate(dr)
        End If
        If dates = False And custName = False And sortby = False Then
            dr = db.reader("select  c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.id desc ")
            grid_viewupdate(dr)
        ElseIf dates = False And custName = False And sortby = True Then
            If RadioButton1.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.inkg desc ")
                grid_viewupdate(dr)
            ElseIf RadioButton2.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.outkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton3.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid order by t.runbalance ")
                grid_viewupdate(dr)
            ElseIf RadioButton4.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid  order by c.name ")
                grid_viewupdate(dr)
            End If
        ElseIf dates = False And custName = True And sortby = False Then
            dr = db.reader("select  c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and c.name='" & cmbcname.Text & "' order by t.id desc")
            grid_viewupdate(dr)
        ElseIf dates = False And custName = True And sortby = True Then
            If RadioButton1.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and c.name='" & cmbcname.Text & "'  order by t.inkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton2.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and c.name='" & cmbcname.Text & "' order by t.outkg   ")
                grid_viewupdate(dr)
            ElseIf RadioButton3.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and c.name='" & cmbcname.Text & "' order by t.runbalance ")
                grid_viewupdate(dr)
            End If
        ElseIf dates = True And custName = False And sortby = False Then
            dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' ")
            grid_viewupdate(dr)
        ElseIf dates = True And custName = False And sortby = True Then
            If RadioButton1.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' order by t.inkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton2.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' order by t.outkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton3.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' order by t.runbalance ")
                grid_viewupdate(dr)
            ElseIf RadioButton4.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' order by c.name ")
                grid_viewupdate(dr)
            End If
        ElseIf dates = True And custName = True And sortby = False Then
            dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' and c.name='" & cmbcname.Text & "' ")
            grid_viewupdate(dr)
        ElseIf dates = True And custName = True And sortby = True Then
            If RadioButton1.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' and c.name='" & cmbcname.Text & "' order by t.inkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton2.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' and c.name='" & cmbcname.Text & "' order by t.outkg ")
                grid_viewupdate(dr)
            ElseIf RadioButton3.Checked = True Then
                dr = db.reader("select c.name,c.mobile,t.inkg,t.outkg,t.credit,t.rate,t.runbalance,t.tdate,c.customerid,t.customerid,t.id from TABLECUSTOMER c,TABLETRANSACTION t where c.customerid=t.customerid and t.tdate  between '" & from_date.Text & "' and  '" & to_date.Text & "' and c.name='" & cmbcname.Text & "' order by t.runbalance ")
                grid_viewupdate(dr)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class