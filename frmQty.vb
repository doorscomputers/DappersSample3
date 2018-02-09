Public Class frmQty

    Private Sub ceQty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceQty.KeyDown
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
                If ceQty.Value < 1 Then
                    ceQty.Value = 1
                End If
                Me.Close()
                frmPOS.vpieces = CInt(ceQty.Value)
                'frmPOS.txtBarcode.Focus()
                frmPOS.GridLookUpEdit2.Focus()
                frmPOS.Activate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub frmQty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmQty_Load(sender As Object, e As EventArgs) Handles Me.Load
        ceQty.Value = 1
        ceQty.SelectAll()
    End Sub

    Private Sub ceQty_EditValueChanged(sender As Object, e As EventArgs) Handles ceQty.EditValueChanged

    End Sub
End Class