Public Class frmPasswordInput

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            username = String.Empty
            Try
                Dim mgremp As New waitersManager()
                Dim cols As New waitersCollection
                mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword

                mgremp.Entity.pword = Trim(txtPassword.Text.ToString)
                cols = mgremp.BuildCollection()
                If mgremp.DataObject.RowsAffected > 0 Then
                    frmPOS.ceWtid.Value = mgremp.DataObject.Entity.wtid
                    'MessageBox.Show(CStr(vEmpID))
                    'MessageBox.Show(CStr(mgremp.DataObject.Entity.waiter))
                    vEmpID = mgremp.DataObject.Entity.wtid
                    'MessageBox.Show(CStr(vEmpID))
                    frmPOS.passcorrect = True
                    Me.Close()
                Else
                    MessageBox.Show("Not a valid password, try again.")
                    'Me.Close()
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub frmPasswordInput_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPasswordInput_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            ''~~~ Calling it and passing the name of the form to be displayed
            'Dim myObj As abcLockScreen = New abcLockScreen
            'myObj.LockSystemAndShow(Form2)
            e.Handled = True
        End If
    End Sub

End Class