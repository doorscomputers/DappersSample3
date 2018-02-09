Public Class frmTransfrdGrd1

    Private Sub frmTransfrdGrd1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTransfrdGrd1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTransfered.vwTransfered' table. You can move, or remove it, as needed.
        Me.VwTransferedTableAdapter.Fill(Me.DsTransfered.vwTransfered)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub
End Class