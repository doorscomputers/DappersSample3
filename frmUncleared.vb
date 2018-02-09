Public Class frmUncleared

    Private Sub frmUncleared_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsPDC.dlvry_hdr' table. You can move, or remove it, as needed.
        Me.dlvry_hdrTableAdapter.Fill(Me.DsPDC.dlvry_hdr)

    End Sub
End Class