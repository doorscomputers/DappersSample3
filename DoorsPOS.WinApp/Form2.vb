''' <summary>
''' Sample Login screen page
''' </summary>
''' <remarks>by, Akhilesh B Chandran
''' akhileshbc @ VBForums</remarks>
Public Class Form2
    Dim bolExit As Boolean = False  '~~~ Used to detect whether the form is being closed only after entering the correct password and not by pressing "Alt" + "F4"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPwd.Text.Trim.ToLower = "abc" Then        '~~~ Check if the password is correct
            bolExit = True                          '~~~ If so, we got the green signal to close the form :-)
            'MessageBox.Show("You are lucky !!!", "Success")
            Me.Close()                              '~~~ Close it
        Else                                            '~~~ Otherwise, display a message
            MessageBox.Show("Password Incorrect", "Wrong Password !!! ")
        End If
    End Sub

    Private Sub Form2_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        txtPwd.Visible = True
        Label1.Visible = True
        txtPwd.Focus()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bolExit = False Then     '~~~ When closing the form, checks whether it is being closed by "Alt" + "F4" or by entering the correct password.
            e.Cancel = True         '~~~ If the closing is done without entering the correct password, then prevent the form from being closed
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            txtPwd.Visible = True
            Label1.Visible = True
            txtPwd.Focus()
            'Button1.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPwd.KeyPress
        If e.KeyChar = Chr(13) Then

            username = String.Empty
            Try
                Dim mgremp As New waitersManager()
                Dim cols As New waitersCollection
                mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
                mgremp.Entity.pword = Trim(txtPwd.Text)
                cols = mgremp.BuildCollection()
                If mgremp.DataObject.RowsAffected > 0 Then
                    bolExit = True                          '~~~ If so, we got the green signal to close the form :-)
                    'MessageBox.Show("You are lucky !!!", "Success")
                    Me.Close()                              '~~~ Close it
                Else
                    MessageBox.Show("Not a valid password, try again.")

                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

End Class