Public Class frmNotFound

    Private Sub frmNotFound_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmNotFound_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.Close()
            Me.Dispose()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub frmNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = Color.Black And Label2.ForeColor = Color.Black And Label3.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
            Label3.ForeColor = Color.Red
        Else
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If

    End Sub
End Class