<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password_change
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
        Me.btnupdate = New System.Windows.Forms.Button
        Me.txtconfirmpswd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnewpswd = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpasswd = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(159, 164)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 35
        Me.btnupdate.Text = "Save"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtconfirmpswd
        '
        Me.txtconfirmpswd.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpswd.Location = New System.Drawing.Point(109, 133)
        Me.txtconfirmpswd.Name = "txtconfirmpswd"
        Me.txtconfirmpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpswd.Size = New System.Drawing.Size(125, 20)
        Me.txtconfirmpswd.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Confirm Password"
        '
        'txtnewpswd
        '
        Me.txtnewpswd.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpswd.Location = New System.Drawing.Point(109, 107)
        Me.txtnewpswd.Name = "txtnewpswd"
        Me.txtnewpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpswd.Size = New System.Drawing.Size(125, 20)
        Me.txtnewpswd.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "New Password"
        '
        'txtpasswd
        '
        Me.txtpasswd.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswd.Location = New System.Drawing.Point(109, 81)
        Me.txtpasswd.Name = "txtpasswd"
        Me.txtpasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswd.Size = New System.Drawing.Size(125, 20)
        Me.txtpasswd.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Current Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 76)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Password_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 196)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtconfirmpswd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnewpswd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpasswd)
        Me.Controls.Add(Me.Label7)
        Me.MaximizeBox = False
        Me.Name = "Password_change"
        Me.Text = "Password_change"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents txtconfirmpswd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnewpswd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpasswd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
