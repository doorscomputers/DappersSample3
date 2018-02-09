Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors
Public Class frmCreditPayment
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ''Dim mgr As New membersManager
        ''Dim cols As membersCollection
        ''mgr.DataObject.SelectFilter = membersData.SelectFilters.WithBalance
        ''mgr.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
        ''cols = mgr.BuildCollection()
        ''GridControl1.DataSource = cols
        'gridControl1.Visible = True
        'gridControl1.Focus()
        ''SendKeys.Send("CTRL" + "F")
        InvokeSearch()
    End Sub
    Sub InvokeSearch()
        gridControl1.Visible = True
        gridControl1.Focus()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ceamount.Value <= 0 Then
            MessageBox.Show("Please enter an amount paid by the customer.")
            Exit Sub
        End If

        If CStr(depaydate.EditValue) = "" Then
            MessageBox.Show("Please enter the date paid by the customer.")
            Exit Sub
        End If

        If txtcheque.Text <> "" Then
            If txtbank.Text = "" Or txtacntname.Text = "" Then
                MessageBox.Show("Please enter cheque details like Cheque #, Bank Name and Account Name.")
                Exit Sub
            End If
        End If

        If cebalance.Value <= 0 Then
            MessageBox.Show("Customer has zero balance but you can still accept payment.")
        End If

        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to Save the payment?", MsgBoxStyle.YesNo, "Payment Confirmation")
        If ansint = 6 Then
            Try
                Dim tranmgr As PDSATransaction
                Dim mgr As New membersManager()
                Dim mgrrdng As New tblreadingManager()
                tranmgr = New PDSATransaction()
                mgr.DataObject.LoadByPK(CInt(txtcustid.Text))
                Dim vresult As Decimal = Convert.ToDecimal(cebalance.Value - ceamount.Value)
                mgr.Entity.Balance = vresult
                mgr.DataObject.UpdateFilter = membersData.UpdateFilters.PrimaryKey
                tranmgr.Add(mgr.DataObject)
                'mgr.DataObject.Update()
                ''''''''''''''''
                Dim mgrpay As New paymentManager()
                mgrpay.Entity.CustID = Convert.ToInt32(txtcustid.Text)
                mgrpay.Entity.PayDate = CDate(depaydate.EditValue)
                mgrpay.Entity.BankName = txtbank.Text
                mgrpay.Entity.AccountName = txtacntname.Text
                mgrpay.Entity.CheckNo = txtcheque.Text
                mgrpay.Entity.Amount = Convert.ToDecimal(ceamount.Value)
                mgrpay.Entity.OldBal = Convert.ToDecimal(cebalance.Value)
                mgrpay.Entity.NewBal = Convert.ToDecimal(cebalance.Value) - Convert.ToDecimal(ceamount.Value)
                mgrpay.Entity.Remarks = PDSAAppConfig.CurrentLoginID
                mgrpay.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgrpay.Entity.TimeEncoded = DateAndTime.Now
                'mgrpay.DataObject.Insert()
                tranmgr.Add(mgrpay.DataObject)

                mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All
                mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                mgrrdng.Entity.cashier = PDSAAppConfig.CurrentLoginID
                mgrrdng.DataObject.Load()
                If mgrrdng.DataObject.RowsAffected > 0 Then
                    mgrrdng.Entity.payments = mgrrdng.Entity.payments + Convert.ToDecimal(ceamount.Value)
                    mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey
                End If
                mgr.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Update
                mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert
                mgrrdng.DataObject.TransactionType = PDSATransactionType.Update
                tranmgr.Add(mgrrdng.DataObject)

                'tranmgr = New PDSATransaction()
                'tranmgr.Add(mgr.DataObject)
                'tranmgr.Add(mgrpay.DataObject)
                'tranmgr.Add(mgrrdng.DataObject)
                tranmgr.Execute()

                Dim pospaycredit As New xrCustPayReceipt()
                'AddHandler pospaycredit.PrintingSystem.StartPrint, AddressOf ReportOnStartPrint
                'posrep.DataSource = sqlDT
                pospaycredit.cID.Value = CInt(txtcustid.Text)
                pospaycredit.CurDate.Value = CDate(depaydate.EditValue)
                pospaycredit.RequestParameters = False
                pospaycredit.PrintingSystem.ShowMarginsWarning = False

                pospaycredit.Print()


                disable()
                initialvals()


                'MessageBox.Show(CStr(mgr.DataObject.SQL))
                MessageBox.Show("Payment successfully saved.")

                Me.Close()
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                DisplayException(ex)
            End Try
        End If
    End Sub
    Private Sub ReportOnStartPrint(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.PrintDocumentEventArgs)
        e.PrintDocument.PrinterSettings.Copies = 2
    End Sub
    Private Sub DisplayException(ByVal ex As Exception)
        'tbException.Text = ex.ToString()
        MessageBox.Show(ex.ToString)
        'MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
    End Sub
    Private Sub frmCreditPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmCreditPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsMemberBalance.MemberBalance' table. You can move, or remove it, as needed.
        Me.MemberBalanceTableAdapter1.Fill(Me.DsMemberBalance.MemberBalance)
        'TODO: This line of code loads data into the 'DsBalance.MemberBalance' table. You can move, or remove it, as needed.
        'Me.MemberBalanceTableAdapter.Fill(Me.DsBalance.MemberBalance)
        gridControl1.Enabled = True
        btnnew.Focus()
    End Sub
    Sub enable()
        btnnew.Enabled = False
        btnsave.Enabled = True
        btncancel.Enabled = True
        btnclose.Enabled = False
        btnsearch.Enabled = True
    End Sub
    Sub disable()
        btnnew.Enabled = True
        btnsave.Enabled = False
        btncancel.Enabled = False
        btnclose.Enabled = True
        btnsearch.Enabled = False
    End Sub
    Sub initialvals()
        txtcustid.Text = String.Empty
        txtlast.Text = String.Empty
        txtfirst.Text = String.Empty
        cebalance.Value = 0
        ceamount.Value = 0
        txtacntname.Text = String.Empty
        txtbank.Text = String.Empty
        txtcheque.Text = String.Empty
        depaydate.EditValue = DateAndTime.Today
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enable()
        initialvals()
        InvokeSearch()
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
            ans = MsgBox("Pending Credit payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo)
            If ans = 7 Then
                Exit Sub
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub gridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles gridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim value As String = ""
            Dim vlast As String = String.Empty
            Dim vfirst As String = String.Empty
            Dim vmid As String = String.Empty
            Dim vcustid As String = String.Empty
            Dim vbal As Decimal = 0

            If GridView1.SelectedRowsCount > 0 Then
                vlast = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "lastname").ToString
                'value = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "custid").ToString
                vfirst = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "firstname").ToString
                vbal = Convert.ToDecimal(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "balance"))
                value = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(3)))
                'vcustid = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(4)))
                vcustid = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, GridView1.Columns("custid"))
                txtcustid.Text = vcustid
                txtlast.Text = vfirst
                txtfirst.Text = vlast
                cebalance.Value = vbal
                gridControl1.Visible = False
                depaydate.Focus()
            End If
        End If
    End Sub
End Class