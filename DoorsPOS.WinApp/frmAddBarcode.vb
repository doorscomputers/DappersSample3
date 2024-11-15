Public Class frmAddBarcode

    Private Sub frmAddBarcode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        c1DataViewSet1.Update()
        MessageBox.Show("Changes Saved", "DoorsPOS")
    End Sub
End Class