Public Class frmInvCostPivt

    Private Sub frmInvCostPivt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmInvCostPivt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsItemCostRetail.stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.DsItemCostRetail.stocks)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub


End Class