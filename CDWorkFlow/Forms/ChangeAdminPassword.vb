Imports System.Data.SqlClient

Public Class Password_change
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader

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

    Private Sub Password_change_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Home
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        dr = db.reader("select *from TABLEADMINLOGIN")
        dr.Read()
        Dim _adminPassword As String
        _adminPassword = getSHA1Hash(txtpasswd.Text)

        If Trim(txtpasswd.Text) = "" Then
            StatusBarUpdater.updateStatusBar("Please enter  password", 1)
            txtpasswd.Focus()
        ElseIf _adminPassword <> dr(1) Then
            StatusBarUpdater.updateStatusBar("Please enter correct  password", 1)
            txtpasswd.Focus()
        ElseIf Trim(txtnewpswd.Text) = "" Then
            StatusBarUpdater.updateStatusBar("Enter new password", 1)
            txtnewpswd.Focus()
        Else
            Dim newPassword As String
            Dim confirmPassword As String
            newPassword = getSHA1Hash(txtnewpswd.Text)
            confirmPassword = getSHA1Hash(txtconfirmpswd.Text)
            If newPassword <> confirmPassword Or Trim(txtnewpswd.Text) = "" Then
                StatusBarUpdater.updateStatusBar("Check password", 1)
                txtconfirmpswd.Focus()
            Else
                db.manipulate("update TABLEADMINLOGIN set apassword= '" & confirmPassword & "'")
                StatusBarUpdater.updateStatusBar("Enter new password", 2)
                Me.Close()
                StatusBarUpdater.updateStatusBar("St.Joseph Cardamom Drier", 3)
            End If
        End If
    End Sub
End Class