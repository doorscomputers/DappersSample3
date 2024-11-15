Imports DevExpress.XtraGrid
Public Class frmCreditGrid

    Private Sub frmCreditGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VwCreditDS.vwCredit' table. You can move, or remove it, as needed.
        Me.VwCreditTableAdapter1.Fill(Me.VwCreditDS.vwCredit)
        'TODO: This line of code loads data into the 'DsCredits.vwCredit' table. You can move, or remove it, as needed.


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
End Class