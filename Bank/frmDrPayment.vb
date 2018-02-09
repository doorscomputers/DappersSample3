Imports DevExpress.XtraEditors
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmDrPayment
    Dim mgrSupBal As dlvry_hdrManager = New dlvry_hdrManager()
    Dim colSupBal As dlvry_hdrCollection
    Dim Tots As Decimal = 0
    Private WithEvents TranPayment As PDSATransaction 'Payment Transaction
    Dim mgrHP As paymnthdrManager ' Payment HEader Manager
    Dim mgrDP As paymntdetlManager 'Payment Detail Manager
    Dim mPid As Integer = 0
    Dim mgrdlvry As dlvry_hdrManager
    Dim mgrSupplier As suppliersManager

    Private Sub frmDrPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmDrPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Dim vRowss As Integer = dgPayment.Rows.Count
        'If vRowss > 0 Then
        '    MessageBox.Show("Payment List Exist. Please Save before closing the Delivery Entry Form.")
        '    e.Cancel = True
        'End If
    End Sub
    Private Sub frmDrPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadBank()
        LoadSupplier()
        Me.Cursor = Cursors.Default
        GroupControl1.Enabled = False
        GroupControl2.Enabled = False
    End Sub
    Private Sub leBank_LostFocus(sender As Object, e As EventArgs) Handles leBank.LostFocus
        'MessageBox.Show(CStr(leBank.EditValue))
    End Sub

    Private Sub LoadBank()
        Try
            'Dim mgrbank As bankManager = New bankManager()
            'Dim colbank As bankCollection

            'mgrbank.DataObject.SelectFilter = bankData.SelectFilters.All
            'colbank = mgrbank.BuildCollection()
            'leBank.Properties.DisplayMember = "bank"
            'leBank.Properties.ValueMember = "bankid"
            'leBank.Properties.DataSource = colbank
            Dim mgrbank As spBanksManager = New spBanksManager()
            Dim colbank As spBanksCollection = mgrbank.BuildCollection()

            leBank.Properties.DisplayMember = "bank"
            leBank.Properties.ValueMember = "bankid"
            leBank.Properties.DataSource = colbank
            'leBank.Properties.Columns(0).Visible = False
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

    End Sub

    Private Sub LoadSupplier()
        Try
            Dim mgrs As suppliersManager = New suppliersManager()
            mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier
            Dim cols As suppliersCollection
            cols = mgrs.BuildCollection()
            leSupplier.Properties.DisplayMember = "supplier"
            leSupplier.Properties.ValueMember = "supcode"
            leSupplier.Properties.DataSource = cols
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

    End Sub

    Private Sub LoadSupBal()
        Try
            mgrSupBal.DataObject.WhereFilter = dlvry_hdrData.WhereFilters.SupplierUnpd
            mgrSupBal.Entity.supcode = CInt(leSupplier.EditValue)
            colSupBal = mgrSupBal.BuildCollection()

            ledrs.Properties.DisplayMember = "drinv"
            ledrs.Properties.ValueMember = "drid"
            ledrs.Properties.DataSource = colSupBal
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub GetBalAmnt()
        Dim mgrGetbal As dlvry_hdrManager = New dlvry_hdrManager()
        Dim vInt As Integer = 0
        vInt = CInt(ledrs.EditValue)
        mgrGetbal.DataObject.LoadByPK(vInt)
        ceAmount.Value = mgrGetbal.DataObject.Entity.drbal

    End Sub
    Sub EnableBtns()
        Try
            dgPayment.Rows.Clear()
            GroupControl2.Enabled = True
            GroupControl1.Enabled = True
            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnNew.Enabled = False
            deDatePaid.EditValue = DateAndTime.Today
            deChkDate.EditValue = DateAndTime.Today
            'Catch ex As PDSAValidationException
            '    MessageBox.Show(ex.Message)
            '    Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Sub DisableBtns()
        Try

            GroupControl2.Enabled = False
            GroupControl1.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnNew.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim vAp As Decimal = 0 ' vAP is equal to Amount Paid
        Dim vTotP As Decimal = 0 ' Total Invoices
        If txtTotInv.Text = "0" Or txtTotInv.Text = String.Empty Then
            MessageBox.Show("No item in the list to process")
            Exit Sub
        End If
        If txtChkNo.Text = String.Empty Then
            MessageBox.Show("Please enter a cheque no. before saving.")
            Exit Sub
        End If

        If deDatePaid.Text = String.Empty Then
            MessageBox.Show("Date Paid must not be blank.")
            Exit Sub
        End If

        Dim grdcounts As Integer = 0
        grdcounts = dgPayment.Rows.Count
        If grdcounts < 1 Then
            MessageBox.Show("No item in the list to process")
            Exit Sub
        End If

        vAp = CDec(ceAmntPd.Value)
        vTotP = CDec(txtTotInv.Text)
        If vAp <> vTotP Then
            MessageBox.Show("Please make sure the Total Amount Paid is equal than the Total Invoice(s) Balance to be Paid.", "Amount not Equal", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure you selected the correct supplier and entered the correct invoice(s) and totals before clicking yes!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If
        'Call Save Payment Procedure
        SavePayment()
        DisableBtns()
        ClearCtrls()
        btnNew.Focus()
    End Sub
    Private Sub SavePayment()
        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranPayment = New PDSATransaction()
        mgrHP = New paymnthdrManager()
        mgrHP.DataObject.TransactionType = PDSATransactionType.Insert
        Try
            'Save Header Section of Invoice Payment
            mgrHP.Entity.paydate = CDate(deDatePaid.Text)
            mgrHP.Entity.amntpaid = CDec(ceAmntPd.Value)
            mgrHP.Entity.bankid = CInt(leBank.EditValue)
            mgrHP.Entity.chqdate = CDate(deChkDate.Text)
            'mgrHP.Entity.dtInsertdt = Date.Now
            'mgrHP.Entity.dtLastUpdatedt = Date.Now
            mgrHP.Entity.chqno = Trim(txtChkNo.Text)
            mgrHP.Entity.remarks = Trim(txtremarks.Text)
            mgrHP.Entity.supcode = CInt(leSupplier.EditValue)

            mgrHP.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            TranPayment.Add(mgrHP.DataObject)
            TranPayment.Execute()
            grdCount = dgPayment.Rows.Count
            'TranPayment = New PDSATransaction()
            For iii = 0 To grdCount - 1
                mgrDP = New paymntdetlManager()
                mgrDP.DataObject.TransactionType = PDSATransactionType.Insert
                mgrDP.Entity.payid = mPid
                mgrDP.Entity.drinv = CStr(dgPayment.Rows(iii).Cells(1).Value)
                mgrDP.Entity.amnt = CDec(dgPayment.Rows(iii).Cells(2).Value)
                mgrDP.Entity.drid = CInt(dgPayment.Rows(iii).Cells(0).Value)
                TranPayment.Add(mgrDP.DataObject)
                'TranPayment.Execute()
                'Update dlvry_hdr paid field to true
                mgrdlvry = New dlvry_hdrManager()
                'TranPayment = New PDSATransaction()
                mgrdlvry.DataObject.SelectFilter = dlvry_hdrData.SelectFilters.All
                mgrdlvry.DataObject.LoadByPK(CInt(dgPayment.Rows(iii).Cells(0).Value))
                mgrdlvry.DataObject.TransactionType = PDSATransactionType.Update
                mgrdlvry.Entity.paid = True
                TranPayment.Add(mgrdlvry.DataObject)
                'TranPayment.Execute()
                'Update the balance on suppliers by subtractivng the amount to the current balance
                mgrSupplier = New suppliersManager
                'TranPayment = New PDSATransaction()
                mgrSupplier.DataObject.SelectFilter = suppliersData.SelectFilters.All
                mgrSupplier.DataObject.LoadByPK(CInt(leSupplier.EditValue))
                mgrSupplier.DataObject.TransactionType = PDSATransactionType.Update
                mgrSupplier.Entity.balance = mgrSupplier.Entity.balance - CDec(txtTotInv.Text)
                TranPayment.Add(mgrSupplier.DataObject)
                'TranPayment.Execute()
            Next
            'execute Transaction on Payment Saving and Update the Paid to true on dlvry_hdr
            'to exclude in the payment selection
            TranPayment.Execute()
            'Stored Proc 
            'Dim TranDrSp As New PDSATransaction()
            'Dim mgrspDrTrans As New spDlvryProcManager()
            'mgrspDrTrans.Entity.drdrid = mPid
            'mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
            'TranDrSp.Add(mgrspDrTrans.DataObject)
            'TranDrSp.Execute()
            MessageBox.Show("Invoice Payment Successfully Saved.")
            Call DisableBtns()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MessageBox.Show(mgrSupplier.DataObject.ClassName)
            MessageBox.Show(mgrSupplier.DataObject.SQL)
            Exit Sub
        End Try
    End Sub
    Private Sub TranPayment_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranPayment.AfterSubmit
        If e.ClassName = "paymnthdrData" Then
            mPid = DirectCast(e.DataClassTable.EntityObject, paymnthdr).payid
        End If
    End Sub
    Private Sub Tranpayment_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranPayment.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "paymntdetlData" Then
            DirectCast(e.DataClassTable.EntityObject, paymntdetl).payid = mPid
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableBtns()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure you selected the correct supplier and entered the correct items and totals before clicking yes!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If
        DisableBtns()
        ClearCtrls()
    End Sub
    Sub SendItemtoGrid()

        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1
        Dim nDrid As Integer = 0
        Try
            nDrid = CInt(ledrs.Text)
            For I = 0 To dgPayment.Rows.Count - 1
                'nDrid = CInt(ledrs.Text) 'If nDrid = CInt(dgPayment.Rows(I).Cells(1).Value) Then
                If nDrid = CInt(dgPayment.Rows(I).Cells(1).Value) Then
                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next
            ' if item is not found, add it
            If ItemLoc = -1 Then
                Dim vInv As Integer = 0
                Dim vBal As String = ""
                vInv = CInt(ledrs.EditValue)
                dgPayment.Rows.Add(vInv, ledrs.Text, ceAmount.Value)
            Else
                'MessageBox.Show("Invoice No. is already on the list to be paid.")
                Exit Sub
            End If

            Tots = 0
            If dgPayment.Rows.Count >= 1 Then
                For I = 0 To dgPayment.Rows.Count - 1
                    Tots += CDec(dgPayment.Rows(I).Cells(2).Value)
                Next
            End If

            'Scroll to the last row.
            Me.dgPayment.FirstDisplayedScrollingRowIndex = Me.dgPayment.RowCount - 1

            'Select the last row.
            Me.dgPayment.Rows(Me.dgPayment.RowCount - 1).Selected = True

            'CalcEdit1.Value = Tots
            txtTotInv.Text = FormatNumber(CStr(Tots))

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub txtremarks_LostFocus(sender As Object, e As EventArgs) Handles txtremarks.LostFocus
        ledrs.Focus()
    End Sub

    Private Sub ledrs_GotFocus(sender As Object, e As EventArgs) Handles ledrs.GotFocus
        LoadSupBal()
    End Sub

    Private Sub ledrs_LostFocus(sender As Object, e As EventArgs) Handles ledrs.LostFocus
        If ledrs.Text <> "" Then
            GetBalAmnt()
            'ceAmount.Value = mgrSupBal.DataObject.Entity.drbal
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If ledrs.Text <> "" And ceAmount.Value >= 0.1 Then
                SendItemtoGrid()
                ledrs.Text = ""
                ceAmount.Value = 0
                ledrs.Focus()
            End If
        
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub dgPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPayment.CellClick
        If e.ColumnIndex = -1 Then
            Dim Totss As Decimal = 0
            Dim ansint As Integer = 7
            ansint = MsgBox("Are you sure you want Delete the selected Payment?", MsgBoxStyle.YesNo, "Delete Row Confirmation")
            If ansint = 6 Then
                Dim ii As Integer = 0
                Try
                    dgPayment.Rows.Remove(dgPayment.SelectedRows(0))
                    For ii = 0 To dgPayment.Rows.Count - 1
                        Totss += CDec(dgPayment.Rows(ii).Cells(2).Value)
                    Next
                    txtTotInv.Text = FormatNumber(CStr(Totss))
                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If
    End Sub
    Private Sub ClearCtrls()
        deDatePaid.EditValue = DateAndTime.Today
        ceAmntPd.Value = 0
        deChkDate.EditValue = DateAndTime.Today
        txtChkNo.Text = String.Empty
        leBank.Text = String.Empty
        leSupplier.Text = String.Empty
        txtremarks.Text = String.Empty
        ledrs.Text = String.Empty
        ceAmount.Value = 0
        txtTotInv.Text = "0"
    End Sub

    Private Sub txtTotInv_GotFocus(sender As Object, e As EventArgs) Handles txtTotInv.GotFocus
        txtTotInv.Enabled = False
    End Sub

    Private Sub txtTotInv_LostFocus(sender As Object, e As EventArgs) Handles txtTotInv.LostFocus
        txtTotInv.Enabled = True
    End Sub

    Private Sub txtChkNo_LostFocus(sender As Object, e As EventArgs) Handles txtChkNo.LostFocus
        If txtChkNo.Text <> "" Then
            Try
                Dim mgrchq As paymnthdrManager = New paymnthdrManager()
                mgrchq.DataObject.SelectFilter = paymnthdrData.SelectFilters.All
                mgrchq.DataObject.WhereFilter = paymnthdrData.WhereFilters.chqno
                mgrchq.Entity.chqno = Trim(txtChkNo.Text)
                mgrchq.DataObject.Load()
                If mgrchq.DataObject.RowsAffected > 0 Then
                    MessageBox.Show("Cheque no. is already Issued", "Cheque No. Duplicate", MessageBoxButtons.OK)
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                Exit Sub
            End Try
        End If
    End Sub

End Class