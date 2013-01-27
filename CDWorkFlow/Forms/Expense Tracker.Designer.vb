<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expense_Tracker
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expense_Tracker))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ExpenseView = New System.Windows.Forms.DataGridView
        Me.ButtonSalaryExp = New System.Windows.Forms.Button
        Me.ButtonOtherExp = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ExpenseName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ExpenseView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpenseView
        '
        Me.ExpenseView.AllowUserToAddRows = False
        Me.ExpenseView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExpenseView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ExpenseView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpenseView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExpenseView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ExpenseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExpenseView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExpenseName, Me.Fdate, Me.Amount})
        Me.ExpenseView.Location = New System.Drawing.Point(12, 134)
        Me.ExpenseView.Name = "ExpenseView"
        Me.ExpenseView.ReadOnly = True
        Me.ExpenseView.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.ExpenseView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ExpenseView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExpenseView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ExpenseView.Size = New System.Drawing.Size(401, 133)
        Me.ExpenseView.TabIndex = 41
        '
        'ButtonSalaryExp
        '
        Me.ButtonSalaryExp.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalaryExp.Location = New System.Drawing.Point(12, 105)
        Me.ButtonSalaryExp.Name = "ButtonSalaryExp"
        Me.ButtonSalaryExp.Size = New System.Drawing.Size(110, 23)
        Me.ButtonSalaryExp.TabIndex = 40
        Me.ButtonSalaryExp.Text = "Salary Expense"
        Me.ButtonSalaryExp.UseVisualStyleBackColor = True
        '
        'ButtonOtherExp
        '
        Me.ButtonOtherExp.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOtherExp.Location = New System.Drawing.Point(128, 105)
        Me.ButtonOtherExp.Name = "ButtonOtherExp"
        Me.ButtonOtherExp.Size = New System.Drawing.Size(110, 23)
        Me.ButtonOtherExp.TabIndex = 39
        Me.ButtonOtherExp.Text = "Other Expense"
        Me.ButtonOtherExp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(538, 94)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.Location = New System.Drawing.Point(385, 272)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(28, 26)
        Me.DeleteButton.TabIndex = 81
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExpenseName
        '
        Me.ExpenseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExpenseName.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExpenseName.FillWeight = 50.0!
        Me.ExpenseName.HeaderText = "Expense Name"
        Me.ExpenseName.Name = "ExpenseName"
        Me.ExpenseName.ReadOnly = True
        Me.ExpenseName.Width = 250
        '
        'Fdate
        '
        Me.Fdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Fdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.Fdate.HeaderText = "Date"
        Me.Fdate.Name = "Fdate"
        Me.Fdate.ReadOnly = True
        Me.Fdate.Width = 81
        '
        'Amount
        '
        Me.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 68
        '
        'Expense_Tracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 313)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExpenseView)
        Me.Controls.Add(Me.ButtonSalaryExp)
        Me.Controls.Add(Me.ButtonOtherExp)
        Me.MinimizeBox = False
        Me.Name = "Expense_Tracker"
        Me.Text = "ExpenseTracker"
        CType(Me.ExpenseView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExpenseView As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSalaryExp As System.Windows.Forms.Button
    Friend WithEvents ButtonOtherExp As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ExpenseName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
