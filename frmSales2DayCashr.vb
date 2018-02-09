Public Class frmSales2DayCashr

    Private Sub frmSales2DayCashr_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSales2DayCashr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        'TODO: This line of code loads data into the 'DsSale2dayCashr.vwSalesTodayCshr' table. You can move, or remove it, as needed.
        Me.VwSalesTodayCshrTableAdapter.Fill(Me.DsSale2dayCashr.vwSalesTodayCshr)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class