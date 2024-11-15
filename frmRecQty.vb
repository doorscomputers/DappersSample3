Public Class frmRecQty
    Public Shared qtyRec As Integer = 0
    Private Sub frmRecQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmRecQty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub ceTrQty_EditValueChanged(sender As Object, e As EventArgs) Handles ceRecQty.EditValueChanged

    End Sub

    Private Sub ceTrQty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceRecQty.KeyDown
        qtyRec = 1
        Try
            If e.KeyCode = Keys.Escape Then

                Me.Close()
                frmReceiveStokcs.txtItem.Focus()
                frmReceiveStokcs.Activate()

            End If

            If e.KeyCode = Keys.Enter Then
                If ceRecQty.Value <= 0 Then
                    ceRecQty.Value = 1
                End If
                qtyRec = CInt(ceRecQty.Value)
                frmReceiveStokcs.vRecpieces = CInt(ceRecQty.Value)
                ' frmTransferStock.GridLookUpEdit2.Focus()
                frmReceiveStokcs.Activate()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class