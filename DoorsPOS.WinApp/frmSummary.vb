Public Class frmSummary

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        'TODO: This line of code loads data into the 'DsReading.tblreading' table. You can move, or remove it, as needed.
        Me.tblreadingTableAdapter.Fill(Me.DsReading.tblreading)

    End Sub
End Class