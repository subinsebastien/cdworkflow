Public Class hhhh

    Private Sub hhhh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.emp1' table. You can move, or remove it, as needed.
        Me.Emp1TableAdapter.Fill(Me.TestDataSet.emp1)
        MdiParent = drier_name
    End Sub
End Class