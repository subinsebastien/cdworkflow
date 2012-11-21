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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.totavg = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.totdried = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.totfresh = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.ViewButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dates, Me.Cust_name, Me.inkg, Me.outkg, Me.credit, Me.rate, Me.runbalance, Me.tid})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(700, 218)
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
        Me.inkg.HeaderText = "Inbound Cardamom (Kg.)"
        Me.inkg.Name = "inkg"
        Me.inkg.ReadOnly = True
        Me.inkg.Width = 98
        '
        'outkg
        '
        Me.outkg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.outkg.DefaultCellStyle = DataGridViewCellStyle4
        Me.outkg.HeaderText = "Outbound Cardamom (Kg.)"
        Me.outkg.Name = "outkg"
        Me.outkg.ReadOnly = True
        Me.outkg.Width = 98
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
        Me.credit.Width = 72
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
        Me.runbalance.Width = 87
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
        Me.FiltrButton.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrButton.Location = New System.Drawing.Point(612, 222)
        Me.FiltrButton.Name = "FiltrButton"
        Me.FiltrButton.Size = New System.Drawing.Size(100, 32)
        Me.FiltrButton.TabIndex = 60
        Me.FiltrButton.Text = "Filter"
        Me.FiltrButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(917, 100)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkbox_sort)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(253, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 153)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'chkbox_sort
        '
        Me.chkbox_sort.AutoSize = True
        Me.chkbox_sort.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbox_sort.Location = New System.Drawing.Point(6, 0)
        Me.chkbox_sort.Name = "chkbox_sort"
        Me.chkbox_sort.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkbox_sort.Size = New System.Drawing.Size(101, 20)
        Me.chkbox_sort.TabIndex = 51
        Me.chkbox_sort.Text = "Sort Order By"
        Me.chkbox_sort.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(26, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(85, 20)
        Me.RadioButton3.TabIndex = 54
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Due Amount"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(26, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(121, 20)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Inbound Cardamom"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(26, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 20)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Outbound Cardamom"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(26, 102)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(104, 20)
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 84)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        '
        'to_date
        '
        Me.to_date.CustomFormat = ""
        Me.to_date.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.to_date.Location = New System.Drawing.Point(106, 49)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(112, 20)
        Me.to_date.TabIndex = 71
        '
        'CheckBoxdate
        '
        Me.CheckBoxdate.AutoSize = True
        Me.CheckBoxdate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxdate.Location = New System.Drawing.Point(6, 0)
        Me.CheckBoxdate.Name = "CheckBoxdate"
        Me.CheckBoxdate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.CheckBoxdate.Size = New System.Drawing.Size(90, 20)
        Me.CheckBoxdate.TabIndex = 67
        Me.CheckBoxdate.Text = "Time Period"
        Me.CheckBoxdate.UseVisualStyleBackColor = True
        '
        'from_date
        '
        Me.from_date.CustomFormat = ""
        Me.from_date.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from_date.Location = New System.Drawing.Point(106, 23)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(112, 20)
        Me.from_date.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "From Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkboxcustomer)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbcname)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 63)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'chkboxcustomer
        '
        Me.chkboxcustomer.AutoSize = True
        Me.chkboxcustomer.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxcustomer.Location = New System.Drawing.Point(6, 0)
        Me.chkboxcustomer.Name = "chkboxcustomer"
        Me.chkboxcustomer.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkboxcustomer.Size = New System.Drawing.Size(117, 20)
        Me.chkboxcustomer.TabIndex = 59
        Me.chkboxcustomer.Text = "Customer Details"
        Me.chkboxcustomer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Customer Name"
        '
        'cmbcname
        '
        Me.cmbcname.Enabled = False
        Me.cmbcname.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcname.FormattingEnabled = True
        Me.cmbcname.Location = New System.Drawing.Point(106, 23)
        Me.cmbcname.Name = "cmbcname"
        Me.cmbcname.Size = New System.Drawing.Size(112, 24)
        Me.cmbcname.TabIndex = 50
        Me.cmbcname.Text = "---Select Name---"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.totavg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.totdried)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.totfresh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(479, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 96)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'totavg
        '
        Me.totavg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totavg.AutoSize = True
        Me.totavg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totavg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatAppearance.BorderSize = 0
        Me.totavg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totavg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totavg.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totavg.Location = New System.Drawing.Point(169, 60)
        Me.totavg.Name = "totavg"
        Me.totavg.Size = New System.Drawing.Size(58, 26)
        Me.totavg.TabIndex = 91
        Me.totavg.Text = "Button3"
        Me.totavg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totavg.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Average"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Fresh Cardamom"
        '
        'totdried
        '
        Me.totdried.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totdried.AutoSize = True
        Me.totdried.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totdried.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatAppearance.BorderSize = 0
        Me.totdried.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totdried.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totdried.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totdried.Location = New System.Drawing.Point(169, 37)
        Me.totdried.Name = "totdried"
        Me.totdried.Size = New System.Drawing.Size(58, 26)
        Me.totdried.TabIndex = 90
        Me.totdried.Text = "Button2"
        Me.totdried.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totdried.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Dried Cardamom"
        '
        'totfresh
        '
        Me.totfresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totfresh.AutoSize = True
        Me.totfresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.totfresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatAppearance.BorderSize = 0
        Me.totfresh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.totfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totfresh.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totfresh.Location = New System.Drawing.Point(169, 12)
        Me.totfresh.Name = "totfresh"
        Me.totfresh.Size = New System.Drawing.Size(58, 26)
        Me.totfresh.TabIndex = 89
        Me.totfresh.Text = "Button1"
        Me.totfresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.totfresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = ":"
        '
        'DeleteButton
        '
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Location = New System.Drawing.Point(684, 484)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(28, 26)
        Me.DeleteButton.TabIndex = 79
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Image = CType(resources.GetObject("ViewButton.Image"), System.Drawing.Image)
        Me.ViewButton.Location = New System.Drawing.Point(650, 484)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(28, 26)
        Me.ViewButton.TabIndex = 80
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.Location = New System.Drawing.Point(616, 484)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(28, 26)
        Me.PrintButton.TabIndex = 81
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(721, 537)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FiltrButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ViewInventory"
        Me.Text = "View Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
End Class
