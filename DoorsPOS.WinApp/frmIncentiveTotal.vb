Public Class frmIncentiveTotal
    Private Sub frmIncentiveTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsIncentivesNew.vwIncentives' table. You can move, or remove it, as needed.
        Me.VwIncentivesTableAdapter.Fill(Me.DsIncentivesNew.vwIncentives)

    End Sub
End Class