﻿Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data.Filtering
Public Class frmReadingSumGrid
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill a SqlDataSource
        SqlDataSource1.Fill()
    End Sub

    Private Sub frmReadingSumGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub
End Class