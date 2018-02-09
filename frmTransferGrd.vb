Imports DevExpress.XtraGrid
Public Class frmTransferGrd

    Private Sub frmTransferGrd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTransferGrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsTransfered.vwTransfered' table. You can move, or remove it, as needed.
        Me.VwTransferedTableAdapter.Fill(Me.DsTransfered.vwTransfered)
        'TODO: This line of code loads data into the 'DsTransfered.vwTransfered' table. You can move, or remove it, as needed.
        Me.VwTransferedTableAdapter.Fill(Me.DsTransfered.vwTransfered)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ShowGridPreview(GridControl1)
    End Sub

    Sub ShowGridPreview(ByVal grid As GridControl)
        ' Check whether the GridControl can be previewed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The Printing' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        grid.ShowPrintPreview()
    End Sub

   
End Class