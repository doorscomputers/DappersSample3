﻿Imports DevExpress.XtraGrid
Public Class frmManualInvGrid

    Private Sub frmManualInvGrid_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmManualInvGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsInitInv.Invntory' table. You can move, or remove it, as needed.
        Me.InvntoryTableAdapter.Fill(Me.DsInitInv.Invntory)
        'TODO: This line of code loads data into the 'DsManualInv.Invntory' table. You can move, or remove it, as needed.
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ShowGridPreview(GridControl1)
    End Sub

    Sub ShowGridPreview(ByVal grid As GridControl)
        ' Check whether the GridControl can be previewed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The Printing' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        grid.ShowPrintPreview()
    End Sub

End Class