Public Class frmItemList

    Private Sub frmItemList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsvwItems.vwItems' table. You can move, or remove it, as needed.
        Me.VwItemsTableAdapter.Fill(Me.DsvwItems.vwItems)

    End Sub
End Class