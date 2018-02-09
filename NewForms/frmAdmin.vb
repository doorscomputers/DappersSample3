Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Waiters2Dataset.waiter2' table. You can move, or remove it, as needed.
        Me.Waiter2TableAdapter.Fill(Me.Waiters2Dataset.waiter2)


    End Sub

    Private Sub simBtnSave_Click(sender As Object, e As EventArgs) Handles simBtnSave.Click
        Try
            '    c1DataViewSet1.Update()
            MessageBox.Show("Changes Saved", "DoorsPOS")
        Catch ex As Exception
            MessageBox.Show("Not Saved, Password too weak!")
        End Try
    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Waiter2TableAdapter.Update(Waiters2Dataset.waiter2)
    End Sub
End Class