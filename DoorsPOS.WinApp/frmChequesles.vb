Public Class frmCheqSales

    Private Sub frmCashSales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCashSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True

        'TODO: This line of code loads data into the 'DsCheques.pos_hdr' table. You can move, or remove it, as needed.
        Me.Pos_hdrTableAdapter.Fill(Me.DsCheques.pos_hdr)

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class