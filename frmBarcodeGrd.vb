Public Class frmBarcodeGrd

    Private Sub frmBarcodeGrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStocksBarcode.tblBarcodes' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsStocksBarcode.stocks' table. You can move, or remove it, as needed.
        Me.stocksTableAdapter.Fill(Me.DsStocksBarcode.stocks)

        Me.TblBarcodesTableAdapter.Fill(Me.DsStocksBarcode.tblBarcodes)

    End Sub
End Class