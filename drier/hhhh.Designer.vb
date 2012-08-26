<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hhhh
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TestDataSet = New drier.testDataSet
        Me.Emp1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp1TableAdapter = New drier.testDataSetTableAdapters.emp1TableAdapter
        Me.EnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emp1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnameDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.SalDataGridViewTextBoxColumn, Me.EidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Emp1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Emp1BindingSource
        '
        Me.Emp1BindingSource.DataMember = "emp1"
        Me.Emp1BindingSource.DataSource = Me.TestDataSet
        '
        'Emp1TableAdapter
        '
        Me.Emp1TableAdapter.ClearBeforeFill = True
        '
        'EnameDataGridViewTextBoxColumn
        '
        Me.EnameDataGridViewTextBoxColumn.DataPropertyName = "ename"
        Me.EnameDataGridViewTextBoxColumn.HeaderText = "ename"
        Me.EnameDataGridViewTextBoxColumn.Name = "EnameDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'SalDataGridViewTextBoxColumn
        '
        Me.SalDataGridViewTextBoxColumn.DataPropertyName = "sal"
        Me.SalDataGridViewTextBoxColumn.HeaderText = "sal"
        Me.SalDataGridViewTextBoxColumn.Name = "SalDataGridViewTextBoxColumn"
        '
        'EidDataGridViewTextBoxColumn
        '
        Me.EidDataGridViewTextBoxColumn.DataPropertyName = "Eid"
        Me.EidDataGridViewTextBoxColumn.HeaderText = "Eid"
        Me.EidDataGridViewTextBoxColumn.Name = "EidDataGridViewTextBoxColumn"
        '
        'hhhh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 262)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "hhhh"
        Me.Text = "hhhh"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emp1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TestDataSet As drier.testDataSet
    Friend WithEvents Emp1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Emp1TableAdapter As drier.testDataSetTableAdapters.emp1TableAdapter
    Friend WithEvents EnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
