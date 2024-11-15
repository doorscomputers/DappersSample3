Public Class frmNewPrice
    Public Shared vItemCode As String = String.Empty
    Public Shared vRetWhol As String = String.Empty

    Private Sub frmNewPrice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmNewPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                'If ceQty.Value < 1 Then
                'ceQty.Value = 1
                'End If
                'frmPOS.qtyy = CInt(ceQty.Value)
                Me.Close()
                frmPOS.txtBarcode.Focus()
                frmPOS.Activate()

            End If

            If e.KeyCode = Keys.Enter Then
                If cePrice.Value <= 0 Then
                    cePrice.Value = 0
                    MessageBox.Show("Price cannot be lesser than or equal to Zero", "Price Change Error")
                    cePrice.SelectAll()
                    Exit Sub
                End If

                'Dim strSqlChangePrice As String = String.Empty
                'If vRetWhol = "Retail" Then
                '    strSqlChangePrice = "Update stocks set Retail=" & CDec(cePrice.Value) & " WHERE barcode='" & vItemCode & "'"
                '    ExecuteSQLQuery(strSqlChangePrice)
                'Else
                '    strSqlChangePrice = "Update stocks set wsale=" & CDec(cePrice.Value) & " WHERE barcode='" & vItemCode & "'"
                '    ExecuteSQLQuery(strSqlChangePrice)
                'End If


                Me.Close()
                frmPOS.vPriceChange = CDec(cePrice.Value)
                'frmPOS.txtBarcode.Focus()
                frmPOS.GridLookUpEdit2.Focus()
                frmPOS.Activate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub frmNewPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cePrice.Value = 0
        cePrice.SelectAll()
    End Sub
End Class