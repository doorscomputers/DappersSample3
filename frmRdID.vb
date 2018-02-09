Public Class frmRdID

    Private Sub frmRdID_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
        Me.Dispose()
    End Sub

    Private Sub frmRdID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsRdID.tblreading' table. You can move, or remove it, as needed.
        Me.TblreadingTableAdapter.Fill(Me.DsRdID.tblreading)

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class