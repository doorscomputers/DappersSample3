
Public Class frmTrQty
    Public Shared qtyTr As Integer = 0
    Private Sub frmTrQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ceTrQty.Value = 1
        ceTrQty.SelectAll()
    End Sub

    Private Sub frmTrQty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTrQty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
                frmTransferStock.txtItem.Focus()
                frmTransferStock.Activate()

            End If

            If e.KeyCode = Keys.Enter Then
                If ceTrQty.Value < 1 Then
                    ceTrQty.Value = 1
                End If
                Me.Close()
                frmTransferStock.vTrpieces = CInt(ceTrQty.Value)
                'frmTransferStock.GridLookUpEdit2.Focus()
                frmTransferStock.Activate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ceQty_EditValueChanged(sender As Object, e As EventArgs) Handles ceTrQty.EditValueChanged

    End Sub

    Private Sub ceQty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceTrQty.KeyDown
        qtyTr = 1
        Try
            If e.KeyCode = Keys.Escape Then

                Me.Close()
                frmTransferStock.txtItem.Focus()
                frmTransferStock.Activate()

            End If

            If e.KeyCode = Keys.Enter Then
                If ceTrQty.Value <= 0 Then
                    ceTrQty.Value = 1
                End If
                qtyTr = CInt(ceTrQty.Value)
                frmTransferStock.vTrpieces = CInt(ceTrQty.Value)
                ' frmTransferStock.GridLookUpEdit2.Focus()
                frmTransferStock.Activate()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class