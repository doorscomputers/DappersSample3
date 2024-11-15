Public Class frmSuppliers

    Private Sub frmSuppliers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSupplierss.suppliers' table. You can move, or remove it, as needed.
        Me.suppliersTableAdapter.Fill(Me.DsSupplierss.suppliers)

    End Sub

    Private Sub simBtnSave_Click(sender As Object, e As EventArgs) Handles simBtnSave.Click
        c1DataViewSet1.Update()
        MessageBox.Show("Changes Saved", "DoorsPOS")
    End Sub
End Class