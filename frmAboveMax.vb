Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Public Class frmAboveMax
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abovemax As New XRItemsAboveMaxim()
        abovemax.PrintingSystem.ShowMarginsWarning = False
        abovemax.ShowPreview()
    End Sub

    Private Sub frmAboveMax_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class