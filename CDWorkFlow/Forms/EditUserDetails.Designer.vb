<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.txtconfirmpswd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnewpswd = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpasswd = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkboxpasswd = New System.Windows.Forms.CheckBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmobno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 94)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(403, 15)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 30
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(484, 15)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 31
        Me.ButtonUpdate.Text = "Save"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'txtconfirmpswd
        '
        Me.txtconfirmpswd.Enabled = False
        Me.txtconfirmpswd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpswd.Location = New System.Drawing.Point(443, 223)
        Me.txtconfirmpswd.Name = "txtconfirmpswd"
        Me.txtconfirmpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpswd.Size = New System.Drawing.Size(116, 23)
        Me.txtconfirmpswd.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Confirm Password"
        '
        'txtnewpswd
        '
        Me.txtnewpswd.Enabled = False
        Me.txtnewpswd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpswd.Location = New System.Drawing.Point(443, 194)
        Me.txtnewpswd.Name = "txtnewpswd"
        Me.txtnewpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpswd.Size = New System.Drawing.Size(116, 23)
        Me.txtnewpswd.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "New Password"
        '
        'txtpasswd
        '
        Me.txtpasswd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswd.Location = New System.Drawing.Point(121, 194)
        Me.txtpasswd.Name = "txtpasswd"
        Me.txtpasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswd.Size = New System.Drawing.Size(135, 23)
        Me.txtpasswd.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Current Password"
        '
        'chkboxpasswd
        '
        Me.chkboxpasswd.AutoSize = True
        Me.chkboxpasswd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxpasswd.Location = New System.Drawing.Point(326, 171)
        Me.chkboxpasswd.Name = "chkboxpasswd"
        Me.chkboxpasswd.Size = New System.Drawing.Size(120, 19)
        Me.chkboxpasswd.TabIndex = 66
        Me.chkboxpasswd.Text = "Change Password"
        Me.chkboxpasswd.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(326, 107)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(233, 52)
        Me.txtaddress.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Address"
        '
        'txtmobno
        '
        Me.txtmobno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.Location = New System.Drawing.Point(121, 165)
        Me.txtmobno.MaxLength = 11
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(135, 23)
        Me.txtmobno.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Mobile No."
        '
        'txtcustname
        '
        Me.txtcustname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(121, 136)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(135, 23)
        Me.txtcustname.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Customer Name"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(121, 107)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(135, 23)
        Me.txtusername.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "User Name"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.Panel3.Controls.Add(Me.ButtonCancel)
        Me.Panel3.Controls.Add(Me.ButtonUpdate)
        Me.Panel3.Location = New System.Drawing.Point(0, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 54)
        Me.Panel3.TabIndex = 72
        '
        'EditUserDetails
        '
        Me.AcceptButton = Me.ButtonUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(571, 311)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtconfirmpswd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnewpswd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpasswd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkboxpasswd)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "EditUserDetails"
        Me.Text = "Edit User Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents txtconfirmpswd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnewpswd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpasswd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkboxpasswd As System.Windows.Forms.CheckBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmobno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
