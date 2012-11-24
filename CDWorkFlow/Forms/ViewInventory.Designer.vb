<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewInventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewInventory))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.dates = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cust_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inkg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.outkg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.runbalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FiltrButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.chkbox_sort = New System.Windows.Forms.CheckBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.to_date = New System.Windows.Forms.DateTimePicker
        Me.CheckBoxdate = New System.Windows.Forms.CheckBox
        Me.from_date = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkboxcustomer = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.totavg = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ViewButton = New System.Windows.Forms.Button
        Me.totdried = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.totfresh = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dates, Me.Cust_name, Me.inkg, Me.outkg, Me.credit, Me.rate, Me.runbalance, Me.tid})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(700, 212)
        Me.DataGridView1.TabIndex = 25
        '
        'dates
        '
        Me.dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dates.DefaultCellStyle = DataGridViewCellStyle2
        Me.dates.HeaderText = "Date"
        Me.dates.Name = "dates"
        Me.dates.ReadOnly = True
        Me.dates.Width = 55
        '
        'Cust_name
        '
        Me.Cust_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cust_name.HeaderText = "Customer Name"
        Me.Cust_name.Name = "Cust_name"
        Me.Cust_name.ReadOnly = True
        '
        'inkg
        '
        Me.inkg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        Me.inkg.DefaultCellStyle = DataGridViewCellStyle3
        Me.inkg.HeaderText = "Fresh Cardamom (Kg.)"
        Me.inkg.Name = "inkg"
        Me.inkg.ReadOnly = True
        Me.inkg.Width = 124
        '
        'outkg
        '
        Me.outkg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.outkg.DefaultCellStyle = DataGridViewCellStyle4
        Me.outkg.HeaderText = "Processed Cardamom (Kg.)"
        Me.outkg.Name = "outkg"
        Me.outkg.ReadOnly = True
        Me.outkg.Width = 126
        '
        'credit
        '
        Me.credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.credit.DefaultCellStyle = DataGridViewCellStyle5
        Me.credit.HeaderText = "Amount Paid (Rs.)"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        Me.credit.Width = 88
        '
        'rate
        '
        Me.rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.rate.DefaultCellStyle = DataGridViewCellStyle6
        Me.rate.HeaderText = "Rate/Kg."
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        Me.rate.Width = 76
        '
        'runbalance
        '
        Me.runbalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.runbalance.DefaultCellStyle = DataGridViewCellStyle7
        Me.runbalance.HeaderText = "Due Amount (Rs.)"
        Me.runbalance.Name = "runbalance"
        Me.runbalance.ReadOnly = True
        Me.runbalance.Width = 106
        '
        'tid
        '
        Me.tid.HeaderText = "TransId"
        Me.tid.Name = "tid"
        Me.tid.ReadOnly = True
        Me.tid.Visible = False
        '
        'FiltrButton
        '
        Me.FiltrButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrButton.Location = New System.Drawing.Point(616, 228)
        Me.FiltrButton.Name = "FiltrButton"
        Me.FiltrButton.Size = New System.Drawing.Size(96, 32)
        Me.FiltrButton.TabIndex = 60
        Me.FiltrButton.Text = "Filter"
        Me.FiltrButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.chkbox_sort)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 159)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Enabled = False
        Me.RadioButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(26, 22)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(49, 19)
        Me.RadioButton5.TabIndex = 56
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Date"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'chkbox_sort
        '
        Me.chkbox_sort.AutoSize = True
        Me.chkbox_sort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbox_sort.Location = New System.Drawing.Point(6, 0)
        Me.chkbox_sort.Name = "chkbox_sort"
        Me.chkbox_sort.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkbox_sort.Size = New System.Drawing.Size(89, 19)
        Me.chkbox_sort.TabIndex = 51
        Me.chkbox_sort.Text = "Sort List By"
        Me.chkbox_sort.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(26, 47)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 19)
        Me.RadioButton3.TabIndex = 54
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Due Amount"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(26, 73)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 19)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Inbound Cardamom"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(26, 98)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(143, 19)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Outbound Cardamom"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(26, 123)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(112, 19)
        Me.RadioButton4.TabIndex = 55
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Customer Name"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.to_date)
        Me.GroupBox4.Controls.Add(Me.CheckBoxdate)
        Me.GroupBox4.Controls.Add(Me.from_date)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 90)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'to_date
        '
        Me.to_date.CustomFormat = ""
        Me.to_date.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.to_date.Location = New System.Drawing.Point(140, 51)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(112, 23)
        Me.to_date.TabIndex = 71
        '
        'CheckBoxdate
        '
        Me.CheckBoxdate.AutoSize = True
        Me.CheckBoxdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxdate.Location = New System.Drawing.Point(6, 0)
        Me.CheckBoxdate.Name = "CheckBoxdate"
        Me.CheckBoxdate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.CheckBoxdate.Size = New System.Drawing.Size(95, 19)
        Me.CheckBoxdate.TabIndex = 67
        Me.CheckBoxdate.Text = "Time Period"
        Me.CheckBoxdate.UseVisualStyleBackColor = True
        '
        'from_date
        '
        Me.from_date.CustomFormat = ""
        Me.from_date.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from_date.Location = New System.Drawing.Point(140, 22)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(112, 23)
        Me.from_date.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "From Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkboxcustomer)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbcname)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 63)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'chkboxcustomer
        '
        Me.chkboxcustomer.AutoSize = True
        Me.chkboxcustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxcustomer.Location = New System.Drawing.Point(6, 0)
        Me.chkboxcustomer.Name = "chkboxcustomer"
        Me.chkboxcustomer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkboxcustomer.Size = New System.Drawing.Size(121, 19)
        Me.chkboxcustomer.TabIndex = 59
        Me.chkboxcustomer.Text = "Customer Details"
        Me.chkboxcustomer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Customer Name"
        '
        'cmbcname
        '
        Me.cmbcname.Enabled = False
        Me.cmbcname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcname.FormattingEnabled = True
        Me.cmbcname.Location = New System.Drawing.Point(140, 23)
        Me.cmbcname.Name = "cmbcname"
        Me.cmbcname.Size = New System.Drawing.Size(112, 23)
        Me.cmbcname.TabIndex = 50
        Me.cmbcname.Text = "---Select Name---"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(463, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Average"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gold
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(463, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Fresh Cardamom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(463, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Processed Cardamom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(612, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 15)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(612, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 15)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(612, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 15)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = ":"
        '
        'totavg
        '
        Me.totavg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totavg.AutoSize = True
        Me.totavg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totavg.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.totavg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatAppearance.BorderSize = 0
        Me.totavg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totavg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totavg.Location = New System.Drawing.Point(649, 63)
        Me.totavg.Name = "totavg"
        Me.totavg.Size = New System.Drawing.Size(59, 25)
        Me.totavg.TabIndex = 91
        Me.totavg.Text = "Button3"
        Me.totavg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totavg.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.Location = New System.Drawing.Point(616, 484)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(28, 26)
        Me.PrintButton.TabIndex = 81
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.Image = CType(resources.GetObject("ViewButton.Image"), System.Drawing.Image)
        Me.ViewButton.Location = New System.Drawing.Point(650, 484)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(28, 26)
        Me.ViewButton.TabIndex = 80
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'totdried
        '
        Me.totdried.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totdried.AutoSize = True
        Me.totdried.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totdried.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.totdried.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatAppearance.BorderSize = 0
        Me.totdried.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totdried.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totdried.Location = New System.Drawing.Point(649, 40)
        Me.totdried.Name = "totdried"
        Me.totdried.Size = New System.Drawing.Size(59, 25)
        Me.totdried.TabIndex = 90
        Me.totdried.Text = "Button2"
        Me.totdried.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totdried.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Location = New System.Drawing.Point(684, 484)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(28, 26)
        Me.DeleteButton.TabIndex = 79
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'totfresh
        '
        Me.totfresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totfresh.AutoSize = True
        Me.totfresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totfresh.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.totfresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatAppearance.BorderSize = 0
        Me.totfresh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totfresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totfresh.Location = New System.Drawing.Point(649, 15)
        Me.totfresh.Name = "totfresh"
        Me.totfresh.Size = New System.Drawing.Size(59, 25)
        Me.totfresh.TabIndex = 89
        Me.totfresh.Text = "Button1"
        Me.totfresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totfresh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(917, 97)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(721, 537)
        Me.Controls.Add(Me.totavg)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.totdried)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.totfresh)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FiltrButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ViewInventory"
        Me.Text = "View Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FiltrButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkbox_sort As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents to_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxdate As System.Windows.Forms.CheckBox
    Friend WithEvents from_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxcustomer As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcname As System.Windows.Forms.ComboBox
    Friend WithEvents totavg As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents totdried As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents totfresh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ViewButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents dates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cust_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inkg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outkg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents runbalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
End Class
