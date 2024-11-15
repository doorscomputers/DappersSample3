Public Class frmSalestoday

    Private Sub frmSalestoday_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSalestoday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSpSalesToday.spSalesTodayqry' table. You can move, or remove it, as needed.
        Me.SpSalesTodayqryTableAdapter.Fill(Me.DsSpSalesToday.spSalesTodayqry)
        'TODO: This line of code loads data into the 'DsSalesToday.vwSales2dayItems' table. You can move, or remove it, as needed.


    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class