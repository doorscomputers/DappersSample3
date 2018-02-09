Public Class frmPriceLookup

    Private Sub frmPriceLookup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPriceLookup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmPriceLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsvwItems.vwItems' table. You can move, or remove it, as needed.
        Me.VwItemsTableAdapter.Fill(Me.DsvwItems.vwItems)

    End Sub
End Class