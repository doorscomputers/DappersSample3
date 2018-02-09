Public Class frmSTCredit

    Private Sub frmSTCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        Me.VwSales2dayItemsTableAdapter.Fill(Me.DsSalesToday.vwSales2dayItems)
    End Sub
    Private Sub frmSTCredit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub


End Class