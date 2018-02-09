Public Class frmBank

    Private Sub frmBank_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        C1DataViewSet1.Update()
        MessageBox.Show("Changes Saved", "DoorsPOS")
    End Sub
End Class