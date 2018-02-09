Imports PDSA.WinForms.Forms
Imports System.Windows.Forms
Imports PDSA.WinForms.Security
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmLogin

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        Dim mgr As New EmployeeTransManager()
        Dim mgrEmp As New waitersManager()
        mgrEmp()

    End Sub
End Class