Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmLoginEmp
    Dim userid As Integer = 0
    Dim username As String = String.Empty

    Private Sub frmLoginEmp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            userid = 0
            username = String.Empty
            Try
                Dim mgremp As New waitersManager()
                Dim cols As New waitersCollection
                mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
                mgremp.Entity.pword = Trim(txtPass.Text)
                cols = mgremp.BuildCollection()
                If mgremp.DataObject.RowsAffected > 0 Then
                    userid = mgremp.DataObject.Entity.wtid
                    username = mgremp.DataObject.Entity.waiter

                    'Check if the user is already logged in
                    Try
                        Dim mgr As New EmployeeTransManager()
                        Dim colss As New EmployeeTransCollection
                        mgr.DataObject.WhereFilter = EmployeeTransData.WhereFilters.fkdate
                        mgr.Entity.fkwtid = userid
                        mgr.Entity.trandate = Date.Today
                        colss = mgr.BuildCollection()
                        If mgr.DataObject.RowsAffected > 0 Then
                            MessageBox.Show("User is already logged in")
                        Else
                            'add a new record to the Employee Trans table
                            Try
                                Dim mgrempadd As New EmployeeTransManager
                                mgrempadd.Entity.trandate = Date.Today
                                mgrempadd.Entity.empbreak = DateAndTime.Now
                                mgrempadd.Entity.empbreakin = DateAndTime.Now
                                mgrempadd.Entity.empin = DateAndTime.Now
                                mgrempadd.Entity.empout = DateAndTime.Now
                                mgrempadd.Entity.stats = False
                                mgrempadd.Entity.fkwtid = userid
                                'mgremp.Entity
                                mgrempadd.DataObject.Insert()
                                MessageBox.Show(username + " Successfully Logged In")
                                Me.Close()
                            Catch ex As PDSAValidationException
                                MessageBox.Show(ex.Message)
                            Catch ex As Exception
                                MessageBox.Show(ex.ToString())
                            End Try
                        End If


                    Catch ex As PDSAValidationException
                        MessageBox.Show(ex.Message)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try

                Else
                    MessageBox.Show("Not a valid password, try again.")

                End If
            Catch ex As PDSAApplicationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class