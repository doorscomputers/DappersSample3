Public Class frmRefundsGrid

    Private Sub frmRefundsGrid_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRefundsGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        'TODO: This line of code loads data into the 'DsRefunds.vwRefunds' table. You can move, or remove it, as needed.
        Me.VwRefundsTableAdapter.Fill(Me.DsRefunds.vwRefunds)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class