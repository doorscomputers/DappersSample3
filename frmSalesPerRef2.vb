Public Class frmSalesPerRef2

    Private Sub frmSalesPerRef2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub


    Private Sub frmSalesPerRef2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dssalesref2.vwSalesRefMain' table. You can move, or remove it, as needed.
        Me.VwSalesRefMainTableAdapter.Fill(Me.Dssalesref2.vwSalesRefMain)
        'TODO: This line of code loads data into the 'Dssalesref2.vwSalesRefMain' table. You can move, or remove it, as needed.
        Me.VwSalesRefMainTableAdapter.Fill(Me.Dssalesref2.vwSalesRefMain)

    End Sub


    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub


End Class