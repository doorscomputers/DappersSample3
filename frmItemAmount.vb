Public Class frmItemAmount

    Private Sub frmItemAmount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmItemAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsItemCost.stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.DsItemCost.stocks)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class