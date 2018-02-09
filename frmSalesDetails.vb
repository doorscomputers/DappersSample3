Public Class frmSalesDetails

    Private Sub frmSalesDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSalesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        'TODO: This line of code loads data into the 'DsItemsSold.vwSales' table. You can move, or remove it, as needed.
        Me.VwSalesTableAdapter.Fill(Me.DsItemsSold.vwSales)
        'TODO: This line of code loads data into the 'DsItemsSold.vwSales' table. You can move, or remove it, as needed.

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub
End Class