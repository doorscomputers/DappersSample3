Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI

Public Class frmBelowMin

    Private Sub frmBelowMin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim belowmin As New XrItemsBelowMinim()
        belowmin.PrintingSystem.ShowMarginsWarning = False
        belowmin.ShowPreview()
    End Sub
End Class