Public Class frmBOGrid

    Private Sub frmBOGrid_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBOGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsBO.vwBO' table. You can move, or remove it, as needed.
        Me.VwBOTableAdapter.Fill(Me.DsBO.vwBO)

    End Sub

    Private Sub PivotGridControl1_DoubleClick(sender As Object, e As EventArgs) Handles PivotGridControl1.DoubleClick
        PivotGridControl1.ShowPrintPreview()
    End Sub

End Class