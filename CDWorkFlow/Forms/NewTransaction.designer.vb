﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Transaction
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Transaction))
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbcname = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtmobile = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdue = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtinkg = New System.Windows.Forms.TextBox
        Me.txtoutkg = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcredit = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmburate = New System.Windows.Forms.ComboBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbluname = New System.Windows.Forms.LinkLabel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.indate = New System.Windows.Forms.DateTimePicker
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbprintonexit = New System.Windows.Forms.CheckBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.label18 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Name"
        '
        'cmbcname
        '
        Me.cmbcname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcname.FormattingEnabled = True
        Me.cmbcname.Location = New System.Drawing.Point(86, 115)
        Me.cmbcname.MaxLength = 25
        Me.cmbcname.Name = "cmbcname"
        Me.cmbcname.Size = New System.Drawing.Size(146, 23)
        Me.cmbcname.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Mobile No."
        '
        'txtmobile
        '
        Me.txtmobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtmobile.Enabled = False
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(86, 144)
        Me.txtmobile.MaxLength = 11
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(146, 23)
        Me.txtmobile.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Due Rs."
        '
        'txtdue
        '
        Me.txtdue.BackColor = System.Drawing.SystemColors.Window
        Me.txtdue.Enabled = False
        Me.txtdue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdue.Location = New System.Drawing.Point(86, 173)
        Me.txtdue.MaxLength = 7
        Me.txtdue.Name = "txtdue"
        Me.txtdue.Size = New System.Drawing.Size(146, 23)
        Me.txtdue.TabIndex = 130
        Me.txtdue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Fresh (kg)"
        '
        'txtinkg
        '
        Me.txtinkg.Enabled = False
        Me.txtinkg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinkg.Location = New System.Drawing.Point(86, 208)
        Me.txtinkg.MaxLength = 8
        Me.txtinkg.Name = "txtinkg"
        Me.txtinkg.Size = New System.Drawing.Size(146, 23)
        Me.txtinkg.TabIndex = 140
        Me.txtinkg.Text = "0.000"
        Me.txtinkg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtoutkg
        '
        Me.txtoutkg.Enabled = False
        Me.txtoutkg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutkg.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtoutkg.Location = New System.Drawing.Point(330, 237)
        Me.txtoutkg.MaxLength = 8
        Me.txtoutkg.Name = "txtoutkg"
        Me.txtoutkg.Size = New System.Drawing.Size(146, 23)
        Me.txtoutkg.TabIndex = 155
        Me.txtoutkg.Text = "0.000"
        Me.txtoutkg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(240, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Processed (kg)"
        '
        'txtcredit
        '
        Me.txtcredit.Enabled = False
        Me.txtcredit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcredit.Location = New System.Drawing.Point(86, 237)
        Me.txtcredit.MaxLength = 7
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(146, 23)
        Me.txtcredit.TabIndex = 150
        Me.txtcredit.Text = "0.00"
        Me.txtcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 15)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Credit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(240, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 15)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Rate"
        '
        'cmburate
        '
        Me.cmburate.AutoCompleteCustomSource.AddRange(New String() {"8.5", "9.0"})
        Me.cmburate.Enabled = False
        Me.cmburate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmburate.FormattingEnabled = True
        Me.cmburate.Items.AddRange(New Object() {"9.00", "10.00"})
        Me.cmburate.Location = New System.Drawing.Point(330, 208)
        Me.cmburate.MaxLength = 6
        Me.cmburate.Name = "cmburate"
        Me.cmburate.Size = New System.Drawing.Size(146, 23)
        Me.cmburate.TabIndex = 145
        Me.cmburate.Text = "10.00"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(330, 115)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(146, 81)
        Me.txtaddress.TabIndex = 135
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbluname)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 68)
        Me.Panel1.TabIndex = 5
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Enabled = False
        Me.lbluname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.Location = New System.Drawing.Point(136, 28)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(111, 15)
        Me.lbluname.TabIndex = 0
        Me.lbluname.TabStop = True
        Me.lbluname.Text = "Sale Person Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(160, 9)
        Me.Label16.MaximumSize = New System.Drawing.Size(55, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "00"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(46, 47)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Sales Person :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 22)
        Me.Label2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Sales Invoice: #"
        '
        'indate
        '
        Me.indate.Checked = False
        Me.indate.CustomFormat = ""
        Me.indate.Enabled = False
        Me.indate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.indate.Location = New System.Drawing.Point(380, 12)
        Me.indate.MinDate = New Date(2000, 11, 11, 0, 0, 0, 0)
        Me.indate.Name = "indate"
        Me.indate.Size = New System.Drawing.Size(100, 23)
        Me.indate.TabIndex = 45
        Me.indate.Value = New Date(2012, 12, 5, 0, 0, 0, 0)
        '
        'PrintDocument1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.Panel3.Controls.Add(Me.cbprintonexit)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Location = New System.Drawing.Point(-4, 277)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(550, 59)
        Me.Panel3.TabIndex = 50
        '
        'cbprintonexit
        '
        Me.cbprintonexit.AutoSize = True
        Me.cbprintonexit.BackColor = System.Drawing.Color.Transparent
        Me.cbprintonexit.Checked = True
        Me.cbprintonexit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbprintonexit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbprintonexit.Location = New System.Drawing.Point(19, 19)
        Me.cbprintonexit.Name = "cbprintonexit"
        Me.cbprintonexit.Size = New System.Drawing.Size(89, 19)
        Me.cbprintonexit.TabIndex = 157
        Me.cbprintonexit.Text = "Print on Exit"
        Me.cbprintonexit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(380, 12)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 32)
        Me.btnsave.TabIndex = 156
        Me.btnsave.Text = "Save/Exit"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'label18
        '
        Me.label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label18.AutoSize = True
        Me.label18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.label18.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.label18.FlatAppearance.BorderSize = 0
        Me.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(346, 60)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(140, 31)
        Me.label18.TabIndex = 50
        Me.label18.Text = "Balance Rs. 0.00"
        Me.label18.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.Label15.Location = New System.Drawing.Point(343, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 100)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'New_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(491, 333)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.indate)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmburate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcredit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtoutkg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtinkg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbcname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "New_Transaction"
        Me.Text = "New Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbcname As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtinkg As System.Windows.Forms.TextBox
    Friend WithEvents txtoutkg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcredit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmburate As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbprintonexit As System.Windows.Forms.CheckBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents label18 As System.Windows.Forms.Button
    Friend WithEvents indate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbluname As System.Windows.Forms.LinkLabel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
