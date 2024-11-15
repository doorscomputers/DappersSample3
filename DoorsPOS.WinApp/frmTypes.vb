Public Class frmTypes

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Try
            C1DataViewSet1.Update()
            MessageBox.Show("Changes Saved", "DoorsPOS")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "DOORSPOS")
        End Try
    End Sub

    Private Sub frmTypes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class