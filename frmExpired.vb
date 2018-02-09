Public Class frmExpired

    Private Sub frmExpired_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsspExpiration.spExpirationDate' table. You can move, or remove it, as needed.
        Me.spExpirationDateTableAdapter.Fill(Me.DsspExpiration.spExpirationDate)
        'TODO: This line of code loads data into the 'DsvwExpired.vwExpired' table. You can move, or remove it, as needed.


    End Sub
End Class