Public Class frmExpensesPvt

    Private Sub frmExpensesPvt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmExpensesPvt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExpenses.tblExpenseTrans' table. You can move, or remove it, as needed.
        Me.TblExpenseTransTableAdapter.Fill(Me.DsExpenses.tblExpenseTrans)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub
End Class