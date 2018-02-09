Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmCheque
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ceamount.Value <= 0 Then
            MessageBox.Show("Please enter cheque amount.")
            ceamount.Focus()
            Exit Sub
        End If

        If CStr(depaydate.EditValue) = "" Then
            MessageBox.Show("Please enter cheque amount.")
            depaydate.Focus()
            Exit Sub
        End If

        If txtcheque.Text = "" Or txtcheque.Text = String.Empty Then
            MessageBox.Show("Please enter cheque details like Cheque #, Bank and Account Name.")
            txtcheque.Focus()
            Exit Sub
        End If
        If txtbank.Text = "" Or txtbank.Text = String.Empty Then
            MessageBox.Show("Please enter cheque details like Name of Bank and Account Name.")
            txtbank.Focus()
            Exit Sub
        End If

        If txtacntname.Text = "" Or txtacntname.Text = String.Empty Then
            MessageBox.Show("Please enter cheque details like Name of Bank and Account Name.")
            txtacntname.Focus()
            Exit Sub
        End If


        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to Save the Cheque payment?", MsgBoxStyle.YesNo, "Cheque Payment Confirmation")
        If ansint = 6 Then
            Try
                Dim tranmgr As PDSATransaction = New PDSATransaction()
                Dim mgrpay As New chkpayManager
                Dim mgrrdng As New tblreadingManager()

                '''''''''''''''

                mgrpay.Entity.chkdate = CDate(depaydate.EditValue)
                mgrpay.Entity.bank = txtbank.Text
                mgrpay.Entity.payee = txtacntname.Text
                mgrpay.Entity.chkno = txtcheque.Text
                mgrpay.Entity.amnt = Convert.ToDecimal(ceamount.Value)
                mgrpay.Entity.chkremark = txtremark.Text
                mgrpay.Entity.cashier = PDSAAppConfig.CurrentLoginID
                'mgrpay.DataObject.Insert()

                mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All
                mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                mgrrdng.Entity.cashier = PDSAAppConfig.CurrentLoginID
                mgrrdng.DataObject.Load()
                If mgrrdng.DataObject.RowsAffected > 0 Then
                    mgrrdng.Entity.totalcheque = Convert.ToDecimal(ceamount.Value) + mgrrdng.Entity.totalcheque
                    mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey
                End If

                mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert
                mgrrdng.DataObject.TransactionType = PDSATransactionType.Update
                tranmgr.Add(mgrpay.DataObject)
                tranmgr.Add(mgrrdng.DataObject)
                tranmgr.Execute()

                disable()
                initialvals()
                MessageBox.Show("Cheque Payment successfully saved.")
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                DisplayException(ex)
            End Try

            Me.Close()
        End If
    End Sub
    Private Sub DisplayException(ByVal ex As Exception)
        'tbException.Text = ex.ToString()
        MessageBox.Show(ex.ToString)
        'MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
    End Sub

    Sub enable()
        btnnew.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
        btnclose.Enabled = False
    End Sub
    Sub disable()
        btnnew.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
        btnclose.Enabled = True
    End Sub
    Sub initialvals()
        ceamount.Value = 0
        txtacntname.Text = String.Empty
        txtbank.Text = String.Empty
        txtcheque.Text = String.Empty
        depaydate.EditValue = DateAndTime.Today
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enable()
        initialvals()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to cancel the payment?", MsgBoxStyle.YesNo, "Cancel Confirmation")
        If ansint = 6 Then
            disable()
            initialvals()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If btnsave.Enabled = True Then
            Dim ans As Integer = 0
            ans = MsgBox("Pending Cheque payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo)
            If ans = 7 Then
                Exit Sub
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmCheque_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If btnsave.Enabled = True Then
                Dim ans As Integer = 0
                ans = MsgBox("Pending Cheque payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo)
                If ans = 7 Then
                    Exit Sub
                Else
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depaydate.EditValue = DateAndTime.Today
    End Sub
End Class