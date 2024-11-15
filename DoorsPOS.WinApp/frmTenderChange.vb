Public Class frmTenderChange
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub frmTenderChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimpleButton1.Focus()
    End Sub

    Private Sub frmTenderChange_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = CStr(CInt(TextBox1.Text) - 1)
        SimpleButton1.Text = "CLOSE(" & TextBox1.Text & ")"
        If TextBox1.Text = "0" Then
            Me.Close()
        End If
    End Sub

End Class