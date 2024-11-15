Public Class frmDlvryGrid2

    Private Sub frmDlvryGrid2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmDlvryGrid2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        'TODO: This line of code loads data into the 'DsvwDeliveries.vwDlvryDetails' table. You can move, or remove it, as needed.
        Me.VwDlvryDetailsTableAdapter.Fill(Me.DsvwDeliveries.vwDlvryDetails)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub

End Class