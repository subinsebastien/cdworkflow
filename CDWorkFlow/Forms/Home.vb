﻿Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Home
    Dim db As New DataBaseInterface
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim str As String
    Public logid As Integer
    Public userName As String
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

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        New_Transaction.Show()

    End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public Sub drier_name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tsslok.Visible = False
        Me.Height = 641
        Me.Width = 941
        Me.MaximizeBox = True
        MenuStrip.Visible = False
        ToolStrip.Visible = False

        StatusStrip.Visible = False
        IsMdiContainer = False
        label18.Visible = False
        txtuname.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ViewInventory.Show()
    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        txtuname.Clear()
        txtuname.Focus()
        txtpswd.Clear()
        txtmasterpswd.Clear()
        txtfirstnmae.Clear()
        txtlastname.Clear()
        txtadddress.Clear()
        txtmobile.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtconfirm_passwd.Clear()
        tsslerror.Visible = False
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        dr = db.reader("select *from TABLEADMINLOGIN")
        dr.Read()
        Dim _adminPassword As String
        _adminPassword = getSHA1Hash(txtmasterpswd.Text)
        If _adminPassword <> dr(1) Then
            StatusStrip.Visible = True
            StatusBarUpdater.updateErrorInfo("Enter correct password", txtmasterpswd)
            StatusBarUpdater.updateStatusBar("please enter correct passwor", 1)
            txtmasterpswd.Clear()
            txtmasterpswd.Focus()
        Else
            Dim _useName As String
            _useName = txtfirstnmae.Text + " " + txtlastname.Text
            Dim checkPassword As Integer
            Dim _newPassword As String
            Dim _confirmPassword As String
            _newPassword = getSHA1Hash(txtpassword.Text)
            _confirmPassword = getSHA1Hash(txtconfirm_passwd.Text)
            If Trim(txtmasterpswd.Text) = "" Then
                StatusBarUpdater.updateErrorInfo("Enter correct password", txtuname)
                StatusBarUpdater.updateStatusBar("Enter admin password", 1)

                txtmasterpswd.Focus()
            ElseIf Trim(txtfirstnmae.Text) = "" Then
                StatusBarUpdater.updateErrorInfo("Enter First Name", txtfirstnmae)
                StatusBarUpdater.updateStatusBar("enter first name", 1)
                txtfirstnmae.Clear()
                txtfirstnmae.Focus()
            ElseIf Trim(txtlastname.Text) = "" Then
                ErrorProvider1.SetError(txtlastname, "Enter Last Name")
                ErrorProvider1.SetIconAlignment(txtlastname, ErrorIconAlignment.MiddleLeft)

                StatusBarUpdater.updateErrorInfo("Enter Last Name", txtlastname)
                StatusBarUpdater.updateStatusBar("Enter last name", 1)
                txtlastname.Clear()
                txtlastname.Focus()
            ElseIf Trim(txtadddress.Text) = "" Then
                ErrorProvider1.SetError(txtadddress, "Enter Address")
                ErrorProvider1.SetIconAlignment(txtadddress, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("Enter Address", 1)
                txtadddress.Clear()
                txtadddress.Focus()
            ElseIf Trim(txtmobile.Text) = "" Then
                ErrorProvider1.SetError(txtmobile, "Enter mobile number")
                ErrorProvider1.SetIconAlignment(txtmobile, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("Enter Mobile number", 1)
                txtmobile.Clear()
                txtmobile.Focus()
            ElseIf Trim(txtusername.Text) = "" Then
                ErrorProvider1.SetError(txtusername, "enter user name")
                ErrorProvider1.SetIconAlignment(txtusername, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("enter user name", 1)
                txtusername.Clear()
                txtusername.Focus()
            ElseIf Trim(txtpassword.Text) = "" Then
                ErrorProvider1.SetError(txtpassword, "Enter new Password")
                ErrorProvider1.SetIconAlignment(txtpassword, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("Enter new Password", 1)
                txtpassword.Clear()
                txtpassword.Focus()
            ElseIf Trim(txtconfirm_passwd.Text) = "" Then
                ErrorProvider1.SetError(txtconfirm_passwd, "enter confirm password")
                ErrorProvider1.SetIconAlignment(txtconfirm_passwd, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("enter confirm password", 1)
                txtconfirm_passwd.Clear()
                txtconfirm_passwd.Focus()
            ElseIf _confirmPassword <> _newPassword Then
                checkPassword = 1
                ErrorProvider1.SetError(txtconfirm_passwd, "password does not match")
                ErrorProvider1.SetIconAlignment(txtconfirm_passwd, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("password does not match", 1)
                txtconfirm_passwd.Clear()
                txtconfirm_passwd.Focus()
            Else

                db.manipulate("insert into TABLEUSER values('" & Trim(txtusername.Text) & "','" & _useName & "', '" & _confirmPassword & "'," & txtmobile.Text & ",'" & txtadddress.Text & "')")
                StatusBarUpdater.updateStatusBar("registered successfully", 2)
                txtmasterpswd.Clear()
                txtfirstnmae.Clear()
                txtlastname.Clear()
                txtmobile.Clear()
                txtadddress.Clear()
                txtpassword.Clear()
                txtusername.Clear()
                txtconfirm_passwd.Clear()
                GroupBox2.Visible = False
                GroupBox1.Visible = True
                txtpswd.Clear()
                txtuname.Clear()
                txtuname.Focus()

            End If
        End If
    End Sub

    Private Sub txtfirstnmae_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstnmae.KeyPress

        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then

            txtfirstnmae.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Characters only", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtfirstnmae.Focus()
        End If
    End Sub

    Private Sub txtlastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlastname.KeyPress

        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            StatusStrip.Visible = False
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtlastname.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Characters only", 1)
        End If
        If Asc(e.KeyChar) = 13 Then
            txtlastname.Focus()
        End If
    End Sub

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        StatusBarUpdater.updateStatusBar("", 4)
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Numerals only", 1)
            txtmobile.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        End If
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If InStr("0123456789._", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        ElseIf Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            StatusStrip.Visible = False
            e.KeyChar = e.KeyChar
        ElseIf Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Character not allowed", 1)
        End If
    End Sub

    Private Sub txtusername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.LostFocus
        dr = db.reader("select   count(name) from TABLEUSER where username='" & Trim(txtusername.Text) & "' ")
        dr.Read()
        If dr(0) = 1 Then
            StatusBarUpdater.updateStatusBar("User name exists", 1)
            txtusername.Focus()
        End If
        ErrorProvider1.SetError(txtusername, "")
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        If Trim(txtuname.Text) = "" Then
            ErrorProvider1.SetError(txtuname, "Enter User Name")
            ErrorProvider1.SetIconAlignment(txtuname, ErrorIconAlignment.MiddleLeft)
            StatusBarUpdater.updateStatusBar("Enter User name", 1)
            txtuname.Focus()
        ElseIf txtpswd.Text = "" Then
            ErrorProvider1.SetError(txtpswd, "Enter Password")
            ErrorProvider1.SetIconAlignment(txtpswd, ErrorIconAlignment.MiddleLeft)
            StatusBarUpdater.updateStatusBar("Enter Password", 1)
            txtpswd.Focus()
        ElseIf txtuname.Text = "admin" Then
            dr = db.reader("select *from TABLEADMINLOGIN")
            dr.Read()
            Dim _adminPassword As String
            _adminPassword = getSHA1Hash(txtpswd.Text)
            If _adminPassword = dr(1) Then
                My.Computer.Audio.Play(My.Resources.SuccessAudio, AudioPlayMode.Background)
                IsMdiContainer = True
                GroupBox1.Visible = False
                MenuStrip.Visible = True
                ToolStrip.Visible = True
                StatusStrip.Visible = True
                tsslerror.Visible = False
                tsslwarning.Visible = False
                tssldefault.Visible = True
                ToolStripButton5.Visible = True
                ToolStripButton7.Visible = True
                label18.Visible = True
                label18.Text = "Admin"
            Else
                ErrorProvider1.SetError(txtpswd, "Enter Password")
                ErrorProvider1.SetIconAlignment(txtpswd, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("Enter correct Password", 1)
                txtpswd.Clear()
                txtpswd.Focus()
            End If
        Else
            dr = db.reader("select password,loginid,name from TABLEUSER where username='" & Trim(txtuname.Text) & "' ")
            dr.Read()
            Dim _checkPassword As String
            If dr.HasRows Then
                _checkPassword = getSHA1Hash(txtpswd.Text)
                If dr(0) = _checkPassword Then
                    My.Computer.Audio.Play(My.Resources.SuccessAudio, AudioPlayMode.Background)
                    label18.Visible = True
                    userName = dr(2)
                    logid = dr(1)
                    label18.Text = userName
                    IsMdiContainer = True
                    GroupBox1.Visible = False
                    MenuStrip.Visible = True
                    ToolStrip.Visible = True
                    StatusStrip.Visible = True
                    tsslerror.Visible = False
                    tsslwarning.Visible = False
                    tssldefault.Visible = True
                    ToolStripButton5.Visible = False
                    ToolStripButton7.Visible = False
                Else
                    ErrorProvider1.SetError(txtpswd, "Enter Password")
                    ErrorProvider1.SetIconAlignment(txtpswd, ErrorIconAlignment.MiddleLeft)
                    StatusBarUpdater.updateStatusBar("Enter correct Password", 1)
                    txtpswd.Clear()
                    txtpswd.Focus()
                End If
            Else
                ErrorProvider1.SetError(txtpswd, "Enter Password")
                ErrorProvider1.SetIconAlignment(txtuname, ErrorIconAlignment.MiddleLeft)
                StatusBarUpdater.updateStatusBar("User does not exists", 1)
                'StatusBarUpdater.updateErrorInfo("User does not exists", txtuname)
                txtuname.Clear()
                txtuname.Focus()
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        EditUserDetails.Show()
        'txtmasterpswd.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'txtmasterpswd.Focus()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        My.Computer.Audio.Play(My.Resources.SuccessAudio, AudioPlayMode.Background)
        drier_name_Load(Me, New System.EventArgs)
        GroupBox1.Visible = True
        txtuname.Text = ""
        txtpswd.Text = ""
        txtuname.Focus()
    End Sub

    Private Sub txtuname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuname.GotFocus

    End Sub

    Private Sub txtuname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuname.KeyPress
        If InStr("0123456789_.", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            txtuname.Focus()
        Else
            e.KeyChar = ""
            StatusBarUpdater.updateStatusBar("Character not allowed", 1)
            txtuname.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            txtuname.Focus()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        EditCustomerDetails.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Password_change.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        drier_name_Load(Me, New System.EventArgs)

        GroupBox1.Visible = True
        txtuname.Text = ""
        txtpswd.Text = ""
        txtuname.Focus()
    End Sub

    Private Sub txtpswd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpswd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnlogin.Focus()
            ' btnlogin_Click(sender, New System.EventArgs())
        End If
    End Sub


    Private Sub txtuname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuname.LostFocus
        ErrorProvider1.SetError(txtuname, "")
    End Sub

    Private Sub txtpswd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpswd.LostFocus
        ErrorProvider1.SetError(txtpswd, "")
    End Sub

    Private Sub txtmasterpswd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmasterpswd.LostFocus
        ErrorProvider1.SetError(txtmasterpswd, "")
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Password_change.Show()
    End Sub

    
    Private Sub txtlastname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlastname.LostFocus
        ErrorProvider1.SetError(txtlastname, "")
    End Sub

    Private Sub txtfirstnmae_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfirstnmae.LostFocus
        ErrorProvider1.SetError(txtfirstnmae, "")
    End Sub

    Private Sub txtadddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadddress.LostFocus
        ErrorProvider1.SetError(txtadddress, "")
    End Sub

    Private Sub txtmobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmobile.LostFocus
        If Trim(txtmobile.TextLength) < 10 Then
            StatusBarUpdater.updateStatusBar("enter Valid Number", 1)
            txtmobile.Focus()

        End If
        ErrorProvider1.SetError(txtmobile, "")
    End Sub

    Private Sub txtpassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.LostFocus
        ErrorProvider1.SetError(txtpassword, "")
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        ViewDeleteLog.Show()
    End Sub

    Private Sub ViewInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewInventoryToolStripMenuItem.Click
        ViewInventory.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutCDWorkFlow.Show()
    End Sub

    Private Sub WindowsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMenu.Click

    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Expense_Tracker.Show()

    End Sub

    Private Sub IndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexToolStripMenuItem.Click
        Other_Expense.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        AddEmployee.Show()
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        AddEmployee.Show()
    End Sub

    Private Sub AddExpenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddExpenseToolStripMenuItem.Click
        Expense_Tracker.Show()
    End Sub

    Private Sub ExpenseTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenseTypesToolStripMenuItem.Click
        AddExpenseTypes.Show()
    End Sub
End Class
