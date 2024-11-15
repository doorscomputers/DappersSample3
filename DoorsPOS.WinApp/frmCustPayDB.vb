
Public Class frmCustPayDB
    'Private mFormsTracker As PDSAFormsTracker
    Private Sub frmCustPayDB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'mFormsTracker.CloseAll()
        Me.Dispose()
    End Sub

    Private Sub frmCustPayDB_Load(sender As Object, e As EventArgs) Handles Me.Load
        'mFormsTracker = New PDSAFormsTracker
        'PDSAFormsTracker.FormsTracker = mFormsTracker
    End Sub
End Class