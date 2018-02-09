Public Class frmRcivdStcksGrd2

    Private Sub frmRcivdStcksGrd2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRcivdStcksGrd2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsReceivedStcks.vwReceivedStocks' table. You can move, or remove it, as needed.
        Me.VwReceivedStocksTableAdapter.Fill(Me.DsReceivedStcks.vwReceivedStocks)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class