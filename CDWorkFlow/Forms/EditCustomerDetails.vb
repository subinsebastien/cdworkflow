Imports System.Data.SqlClient
Public Class EditCustomerDetails
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Dim str As String
    Dim temp_name As String

    Private Sub EditCustomerDetails_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        StatusBarUpdater.updateStatusBar("", 4)
    End Sub

    Private Sub customeredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        MdiParent = Home
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

        StatusBarUpdater.updateStatusBar("Please select name", 1)
        cmbcname.Focus()
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

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcname.SelectedIndexChanged
        temp_name = cmbcname.Text
        Label6.Enabled = True
        Label8.Enabled = True
        txtmobile.Enabled = True
        txtaddress.Enabled = True
        ButtonSave.Enabled = True
        dr = db.reader("select *from TABLECUSTOMER where name='" & Trim(cmbcname.Text) & "'")
        dr.Read()
        txtaddress.Text = dr(3)
        txtmobile.Text = dr(2)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If cmbcname.Text = "" Then
            StatusBarUpdater.updateStatusBar("Select Name", 1)
        ElseIf txtmobile.Text = "" Then
            StatusBarUpdater.updateStatusBar("Please enter mobile number", 1)
        ElseIf txtaddress.Text = "" Then
            StatusBarUpdater.updateStatusBar("Enter Address", 1)
        Else
            db.manipulate("update TABLECUSTOMER set name='" & cmbcname.Text & "',mobile=" & txtmobile.Text & ",address='" & txtaddress.Text & "' where name='" & temp_name & "'")
            My.Computer.Audio.Play(My.Resources.SuccessAudio, AudioPlayMode.Background)
            ' StatusBarUpdater.updateStatusBar("Updated successfully", 1)
            Me.Close()
        End If
    End Sub

    Private Sub txtmobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.Leave
        If Trim(txtmobile.TextLength) < 10 Then
            StatusBarUpdater.updateStatusBar("enter Valid Number", 1)
            txtmobile.Focus()

        End If
    End Sub
End Class