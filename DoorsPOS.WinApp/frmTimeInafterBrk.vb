Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmTimeInafterBrk
    Dim userid As Integer = 0
    Dim username As String = String.Empty
    Dim pkemptrans As Integer = 0
    Private Sub frmTimeInafterBrk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            userid = 0
            username = String.Empty
            pkemptrans = 0
            Try
                ' check if the password exist
                Dim mgremp As New waitersManager()
                Dim cols As New waitersCollection
                mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
                mgremp.Entity.pword = Trim(txtPass.Text)
                cols = mgremp.BuildCollection()
                If mgremp.DataObject.RowsAffected > 0 Then
                    userid = mgremp.DataObject.Entity.wtid
                    username = mgremp.DataObject.Entity.waiter

                    'Check if the user is already logged in by checking the fkwtid  
                    ' and the current date field
                    Try
                        Dim mgr As New EmployeeTransManager()
                        mgr.DataObject.SelectFilter = EmployeeTransData.SelectFilters.All
                        mgr.DataObject.WhereFilter = EmployeeTransData.WhereFilters.fkdate
                        mgr.Entity.fkwtid = userid
                        mgr.Entity.trandate = Date.Today
                        'colss = mgr.BuildCollection()
                        mgr.DataObject.Load()
                        If mgr.DataObject.RowsAffected > 0 Then
                            If mgr.Entity.bempbreak = False Then
                                MessageBox.Show("You cannot login after the break because you did not log your breaktime.Operation Cancelled")
                                Me.Close()
                                Exit Sub
                            End If
                            'MessageBox.Show("User is already logged in")
                            'edit the empbreak field
                            'get the primary key for update criteria
                            pkemptrans = mgr.DataObject.Entity.linoutid
                            Try

                                mgr.Entity.linoutid = pkemptrans
                                mgr.Entity.empbreakin = DateAndTime.Now
                                mgr.Entity.bempbreakin = True
                                mgr.DataObject.UpdateFilter = EmployeeTransData.UpdateFilters.PrimaryKey
                                mgr.DataObject.Update()
                                MessageBox.Show("Time in after Breaktime Successfull for " + username)
                                Me.Close()
                            Catch ex As PDSAValidationException
                                MessageBox.Show(ex.Message)
                            Catch ex As Exception
                                MessageBox.Show(ex.ToString())
                            End Try

                        Else
                            MessageBox.Show("Employee may not be logged in yet")
                            Me.Close()
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

   
End Class