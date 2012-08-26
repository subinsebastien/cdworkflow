Imports System.Windows.Forms
Imports System.Data.SqlClient



Public Class drier_name
    Dim db As New Class1
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim str As String
    Public logid As Integer
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
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
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

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub drier_name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Height = 530
        Me.Width = 750
        Me.MaximizeBox = True
        MenuStrip.Visible = False
        ToolStrip.Visible = False
        StatusStrip.Visible = False
        IsMdiContainer = False


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click




        New_Transaction .Show 

    End Sub

    

    

    
    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        txtuname.Focus()
    End Sub



    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        Dim user_name As String
        user_name = txtfirstnmae.Text + " " + txtlastname.Text

        Dim passwd_ok As Integer

        Dim temp_passwd As String
        Dim temp_confirm_passwd As String

        temp_passwd = getSHA1Hash(txtpassword.Text)
        temp_confirm_passwd = getSHA1Hash(txtconfirm_passwd.Text)
        If Trim(txtmasterpswd.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter master password"
            txtmasterpswd.Clear()
            txtmasterpswd.Focus()
        ElseIf Trim(txtfirstnmae.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter first name"
            txtfirstnmae.Clear()
            txtfirstnmae.Focus()
        ElseIf Trim(txtlastname.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter last name"
            txtlastname.Clear()
            txtlastname.Focus()
        ElseIf Trim(txtadddress.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter Adress name"
            txtadddress.Clear()
            txtadddress.Focus()
        ElseIf Trim(txtmobile.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enterphone number"
            txtmobile.Clear()
            txtmobile.Focus()
        ElseIf Trim(txtusername.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter user name"
            txtusername.Clear()
            txtusername.Focus()
        ElseIf Trim(txtpassword.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter password"
            txtpassword.Clear()
            txtpassword.Focus()
        ElseIf Trim(txtconfirm_passwd.Text) = "" Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "enter password"
            txtconfirm_passwd.Clear()
            txtconfirm_passwd.Focus()
        ElseIf temp_confirm_passwd <> temp_passwd Then
            passwd_ok = 1
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "password wronf"
            txtconfirm_passwd.Clear()
            txtconfirm_passwd.Focus()
        Else
            'MsgBox("wrmg")

            ''passwd_ok = 0
            str = "insert into TABLEUSER values('" & Trim(txtusername.Text) & "','" & user_name & "', '" & temp_confirm_passwd & "'," & txtmobile.Text & ",'" & txtadddress.Text & "')"
            db.manipulate(str)
            StatusStrip.Visible = True
            Me.tssldefault.Visible = True
            Me.tsslerror.Visible = False
            Me.tsslwarning.Visible = False
            MsgBox("user added")
            Me.tssldefault.Text = "registered successfully"
            GroupBox2.Visible = False
            GroupBox1.Visible = True
            txtuname.Focus()

        End If
    End Sub
    'MsgBox(user_name)






    Private Sub txtfirstnmae_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfirstnmae.KeyPress

        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8 Then
            'ErrorProvider1.Clear()
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then

            txtfirstnmae.Focus()
        Else
            e.KeyChar = ""
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "characters only"


            'MsgBox("Enter character")
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
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "characters only"


            'MsgBox("Enter character")
        End If
        If Asc(e.KeyChar) = 13 Then
            txtlastname.Focus()
        End If
    End Sub

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
        If InStr("0123456789", e.KeyChar) > 0 Or Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar
            StatusStrip.Visible = False
        ElseIf Asc(e.KeyChar) = 13 Then
            txtmobile.Focus()
        Else
            e.KeyChar = ""
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = False
            Me.tsslwarning.Text = "numerals only"
            Me.tsslwarning.Visible = True
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
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "no special char"


            'MsgBox("Enter character")


        End If
    End Sub

    Private Sub txtmasterpswd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmasterpswd.LostFocus

        If txtmasterpswd.Text <> "joseph" Then

            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "please enter correct password"
            txtmasterpswd.Focus()
        Else
            StatusStrip.Visible = False
        End If

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtusername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.LostFocus

        str = "select   count(name) from TABLEUSER where username='" & Trim(txtusername.Text) & "' "
        dr = db.reader(str)
        dr.Read()
        If dr(0) = 1 Then
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "username exists"
            txtusername.Focus()

        End If

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        'IsMdiContainer = True
        'GroupBox1.Visible = False
        'MenuStrip.Visible = True
        'ToolStrip.Visible = True
        'StatusStrip.Visible = True
        'tsslerror.Visible = False
        'tsslwarning.Visible = False
        'tssldefault.Visible = True
        'Me.Width = 1000
        'Me.Height = 640

        str = "select password,loginid,name from TABLEUSER where username='" & Trim(txtuname.Text) & "' "
        dr = db.reader(str)
        dr.Read()
        Dim chek_passwd As String
        If dr.HasRows Then
            chek_passwd = getSHA1Hash(txtpswd.Text)
            If dr(0) = chek_passwd Then

                Dim usr_name As String

                usr_name = dr(2)
                logid = dr(1)
                label18.Text = usr_name
                'LinkLabel3.Text = txtuname.Text
                IsMdiContainer = True
                GroupBox1.Visible = False
                MenuStrip.Visible = True
                ToolStrip.Visible = True
                StatusStrip.Visible = True
                tsslerror.Visible = False
                tsslwarning.Visible = False
                tssldefault.Visible = True
                Me.Width = 1000
                Me.Height = 640
            Else

                StatusStrip.Visible = True
                Me.tssldefault.Visible = False
                Me.tsslerror.Visible = True
                Me.tsslwarning.Visible = False
                Me.tsslerror.Text = "please enter correct password"
                txtpswd.Clear()
                txtpswd.Focus()

            End If

        Else
            StatusStrip.Visible = True
            Me.tssldefault.Visible = False
            Me.tsslerror.Visible = True
            Me.tsslwarning.Visible = False
            Me.tsslerror.Text = "user does not exist"
            txtuname.Clear()
            txtuname.Focus()



        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        hhhh.Show()

    End Sub
End Class
