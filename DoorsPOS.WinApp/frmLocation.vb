﻿Public Class frmLocation 

    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard

        ' This line of code is generated by Data Source Configuration Wizard
        LocationTableAdapter1.Fill(DsLocation1.location)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            C1DataViewSet1.Update()
            MessageBox.Show("Item Edit Successfully Saved")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub frmLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class