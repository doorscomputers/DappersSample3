﻿Imports DevExpress.XtraGrid
Public Class frmDeliveryGrid

    Private Sub frmDeliveryGrid_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmDeliveryGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        'TODO: This line of code loads data into the 'DsvwDeliveries.vwDlvryDetails' table. You can move, or remove it, as needed.
        Me.VwDlvryDetailsTableAdapter.Fill(Me.DsvwDeliveries.vwDlvryDetails)

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

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class