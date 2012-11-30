<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDetails
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GridviewDetails = New System.Windows.Forms.DataGridView
        Me.Cust_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridviewDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CDWorkFlow.My.Resources.Resources.BannerImage
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 100)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'GridviewDetails
        '
        Me.GridviewDetails.AllowUserToAddRows = False
        Me.GridviewDetails.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridviewDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridviewDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridviewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridviewDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridviewDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridviewDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridviewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridviewDetails.ColumnHeadersVisible = False
        Me.GridviewDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cust_name, Me.credit})
        Me.GridviewDetails.Enabled = False
        Me.GridviewDetails.Location = New System.Drawing.Point(12, 112)
        Me.GridviewDetails.Name = "GridviewDetails"
        Me.GridviewDetails.ReadOnly = True
        Me.GridviewDetails.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.GridviewDetails.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridviewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridviewDetails.Size = New System.Drawing.Size(429, 225)
        Me.GridviewDetails.TabIndex = 92
        '
        'Cust_name
        '
        Me.Cust_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cust_name.HeaderText = ""
        Me.Cust_name.Name = "Cust_name"
        Me.Cust_name.ReadOnly = True
        '
        'credit
        '
        Me.credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.credit.DefaultCellStyle = DataGridViewCellStyle5
        Me.credit.HeaderText = ""
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'TransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(453, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridviewDetails)
        Me.MaximizeBox = False
        Me.Name = "TransactionDetails"
        Me.Text = "TransactionDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridviewDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridviewDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Cust_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
