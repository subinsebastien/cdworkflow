Imports System.Data.SqlClient

Public Class EditUserDetails
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Dim s As String

    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Private Sub user_edit_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        StatusBarUpdater.updateStatusBar("", 4)
    End Sub

    Private Sub user_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         StatusBarUpdater.updateStatusBar("", 4)
        MdiParent = Home
        dr = db.reader("select * from TABLEUSER where loginid=" & Home.logid & " ")
        dr.Read()
        s = dr(2)
        txtusername.Text = dr(1)
        txtcustname.Text = dr(2)
        txtmobno.Text = dr(4)
        txtaddress.Text = dr(5)
    End Sub

    Private Sub txtconfirmpswd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'btnlogin.Focus()
            ButtonUpdate_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        Dim temp_passwd As String
        If Trim(txtpasswd.Text) = "" Then
            StatusBarUpdater.updateStatusBar("Enter Password", 1)
            txtpasswd.Focus()
        End If
        If chkboxpasswd.Checked = False And Trim(txtpasswd.Text) <> "" Then
            dr = db.reader("select password from TABLEUSER where loginid=" & Home.logid & "  ")
            dr.Read()
            temp_passwd = getSHA1Hash(txtpasswd.Text)
            If (temp_passwd = dr(0)) Then
                db.manipulate("update TABLEUSER set username='" & txtusername.Text & "',name='" & txtcustname.Text & "',mobile=" & txtmobno.Text & ",address='" & txtaddress.Text & "'  where loginid=" & Home.logid & "")
                StatusBarUpdater.updateStatusBar("Updated Successfully", 2)
            Else
                StatusBarUpdater.updateStatusBar("Wrong Password", 1)
                txtpasswd.Focus()
            End If
        Else
            Dim chknewpaswd As String
            Dim chkconfirmpaswd As String
            chknewpaswd = getSHA1Hash(txtnewpswd.Text)
            chkconfirmpaswd = getSHA1Hash(txtconfirmpswd.Text)
            If chknewpaswd <> chkconfirmpaswd Or Trim(txtnewpswd.Text) = "" Then
                StatusBarUpdater.updateStatusBar("Check Password", 1)
                txtconfirmpswd.Focus()
            ElseIf Trim(txtpasswd.Text) <> "" Then
                dr = db.reader("select password from TABLEUSER where loginid=" & Home.logid & "  ")
                dr.Read()
                temp_passwd = getSHA1Hash(txtpasswd.Text)
                If (temp_passwd = dr(0)) Then
                    db.manipulate("update TABLEUSER set username='" & txtusername.Text & "',name='" & txtcustname.Text & "',mobile=" & txtmobno.Text & ",address='" & txtaddress.Text & "',password='" & chkconfirmpaswd & "'   where loginid=" & Home.logid & "")
                    StatusBarUpdater.updateStatusBar("Updated Successfully", 2)
                    Me.Close()
                    Home.drier_name_Load(Me, New System.EventArgs)
                    Home.GroupBox1.Visible = True
                    Home.txtuname.Text = ""
                    Home.txtpswd.Text = ""
                Else
                    StatusBarUpdater.updateStatusBar("Wrong Password", 1)
                    txtpasswd.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Home.tsslwarning.Visible = False
        Me.Close()
    End Sub

    Private Sub chkboxpasswd_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkboxpasswd.CheckStateChanged
        If chkboxpasswd.Checked = True Then
            Label6.Enabled = True
            Label5.Enabled = True
            txtnewpswd.Enabled = True
            txtconfirmpswd.Enabled = True
        Else
            Label6.Enabled = False
            Label5.Enabled = False
            txtnewpswd.Enabled = False
            txtconfirmpswd.Enabled = False
        End If
    End Sub

    Private Sub txtcustname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustname.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            StatusBarUpdater.updateStatusBar("", 4)
        ElseIf Asc(e.KeyChar) = 13 Then
            txtcustname.Focus()
        Else
            e.KeyChar = ""
            Home.StatusStrip.Visible = True
            StatusBarUpdater.updateStatusBar("Characters only", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtcustname.Focus()
        End If
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If InStr("0123456789_.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            Home.StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            Home.StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        Else
            e.KeyChar = ""
            Home.StatusStrip.Visible = True
            StatusBarUpdater.updateStatusBar("Characters not allowed", 1)
            txtusername.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        End If
    End Sub

    Private Sub txtmobno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobno.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobno.Focus()
        Else
            e.KeyChar = ""
            Home.StatusStrip.Visible = True
            StatusBarUpdater.updateStatusBar("Enter Numerals", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtmobno.Focus()
        End If
    End Sub

End Class