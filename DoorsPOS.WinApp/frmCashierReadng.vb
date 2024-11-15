Public Class frmCashierReadng

    Private Sub frmCashierReadng_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCashierReadng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsvwReading.vwReading' table. You can move, or remove it, as needed.
        Me.VwReadingTableAdapter.Fill(Me.DsvwReading.vwReading)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub
End Class