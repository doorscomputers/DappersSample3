Public Class frmItemLedgerPvt

    Private Sub frmItemLedgerPvt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmItemLedgerPvt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsLedger.vwItemLedger2' table. You can move, or remove it, as needed.
        Me.VwItemLedger2TableAdapter.Fill(Me.DsLedger.vwItemLedger2)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub

End Class