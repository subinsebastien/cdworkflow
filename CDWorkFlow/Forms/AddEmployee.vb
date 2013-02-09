Imports System.Data.SqlClient
Imports System.Drawing.Graphics
Public Class AddEmployee
    Dim globalDataReader As SqlDataReader
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Dim temp_name As String
    Dim checkForNewEntry As Integer = 0

    

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If checkForNewEntry = 1 Then
            db.manipulate("insert into TABLEEMPLOYEE values('" & cmbcname.Text & "'," & txtmobile.Text & ",'" & txtaddress.Text & "') ")
            'db.manipulate("TABLECUSTOMER set name='" & cmbcname.Text & "',mobile=" & txtmobile.Text & ",address='" & txtaddress.Text & "' where name='" & temp_name & "'")
        End If
        Me.Close()
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

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        Home.tsslwarning.Visible = False
        Home.tsslerror.Visible = False
        Home.tssldefault.Visible = True
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Enter numeric value", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        End If
    End Sub

    Private Sub txtmobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.Leave
        If Trim(txtmobile.TextLength) < 10 Then
            StatusBarUpdater.updateStatusBar("enter Valid Number", 1)
            txtmobile.Focus()

        End If
    End Sub



    Private Sub AddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.tsslok.Visible = False

        MdiParent = Home
        cmbcname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbcname.AutoCompleteSource = AutoCompleteSource.ListItems
        'cmbcname.Text = singleview.cmbcname.Text

        dr = db.reader("select Ename from TABLEEMPLOYEE")
        If dr.HasRows Then
            While dr.Read
                cmbcname.Items.Add(Trim(dr(0)))
            End While
        End If
    End Sub

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged

        temp_name = cmbcname.Text
        Label6.Enabled = True
        Label8.Enabled = True
        txtmobile.Enabled = True
        txtaddress.Enabled = True
        ButtonSave.Enabled = True
        dr = db.reader("select *from TABLEEMPLOYEE where Ename='" & Trim(cmbcname.Text) & "'")
        dr.Read()
        txtaddress.Text = dr(2)
        txtmobile.Text = dr(3)

    End Sub

    Private Sub cmbcname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcname.TextChanged
        globalDataReader = db.reader("select * from TABLEEMPLOYEE where Ename = '" & Trim(cmbcname.Text) & "' ")
        globalDataReader.Read()

        If globalDataReader.HasRows Or Trim(cmbcname.Text) = "" Then
            checkForNewEntry = 0
            Label6.Enabled = True
            Label8.Enabled = True
            txtmobile.Enabled = True
            txtaddress.Enabled = True
            ButtonSave.Enabled = True

        Else
            checkForNewEntry = 1
            Label6.Enabled = True
            Label8.Enabled = True
            txtmobile.Enabled = True
            txtaddress.Enabled = True
            ButtonSave.Enabled = True
        End If
    End Sub
End Class