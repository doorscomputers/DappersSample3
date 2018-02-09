Imports DevExpress.XtraGrid
Public Class frmCreditGrid2

    Private Sub frmCreditGrid2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
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

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ShowGridPreview(GridControl1)
    End Sub

    Private Sub frmCreditGrid2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'VwCreditDS.vwCredit' table. You can move, or remove it, as needed.
        Me.VwCreditTableAdapter1.Fill(Me.VwCreditDS.vwCredit)
        'TODO: This line of code loads data into the 'DsCredits.vwCredit' table. You can move, or remove it, as needed.

    End Sub
End Class