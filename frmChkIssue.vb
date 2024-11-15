Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Imports DynamicComponents.Number2Text
Imports DevExpress.XtraReports.UI
Public Class frmChkIssue
    Private WithEvents trans As PDSATransaction
    'Dim oTextNum As New DynamicComponents.Number2Text()
    Dim mgrChkIssued As ChkIssuedManager = New ChkIssuedManager()
    Dim colSupBal As dlvry_hdrCollection
    Dim Tots As Decimal = 0
    Private WithEvents TranPayment As PDSATransaction 'Payment Transaction
    Dim mgrHP As paymnthdrManager ' Payment HEader Manager
    Dim mgrDP As paymntdetlManager 'Payment Detail Manager
    Dim mPid As Integer = 0
    Dim mgrdlvry As dlvry_hdrManager
    Dim mgrSupplier As suppliersManager
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewTrans()
        btnNew.Enabled = False
    End Sub


    Sub NewTrans()
        leBank.Enabled = True
        deDateIssued.Enabled = True
        txtChkNo.Enabled = True
        ceAmount.Enabled = True
        txtPayee.Enabled = True
        txtRemarks.Enabled = True
        btnNew.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        deDateIssued.EditValue = DateAndTime.Today
        btnNew.Enabled = False
        leBank.Focus()


    End Sub

    Sub TransFinished()
        leBank.Enabled = False
        deDateIssued.Enabled = False
        txtChkNo.Enabled = False
        ceAmount.Enabled = False
        txtPayee.Enabled = False
        txtRemarks.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        btnNew.Enabled = True
        btnNew.Focus()
    End Sub

    Private Sub frmChkIssue_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmChkIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' oTextNum = New DynamicComponents.Number2Text()
        Me.Cursor = Cursors.WaitCursor
        LoadBank()
        btnNew.Focus()
        Me.Cursor = Cursors.Default
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Are you sure you want to cancel the current operation?", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If
        ClearCtrls()
        TransFinished()
    End Sub
    Sub ClearCtrls()
        leBank.Text = String.Empty
        deDateIssued.EditValue = DateTime.Today
        txtChkNo.Text = String.Empty
        ceAmount.Value = 0
        txtPayee.Text = String.Empty
        txtRemarks.Text = String.Empty
        txtamntwords.Text = String.Empty
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Please double check if all the information are correct", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then

            If leBank.Text = String.Empty Then
                MessageBox.Show("Bank Info must not be blank.")
                leBank.Focus()
                Exit Sub
            End If

            If txtChkNo.Text = String.Empty Then
                MessageBox.Show("Check no. must not be blank.")
                txtChkNo.Focus()
                Exit Sub
            End If
            If ceAmount.Value <= 0 Then
                MessageBox.Show("Amount must not be less than or equal to Zero.")
                ceAmount.Focus()
                Exit Sub
            End If

            If txtPayee.Text = String.Empty Then
                MessageBox.Show("Payee Info must not be blank.")
                txtPayee.Focus()
                Exit Sub
            End If

            Dim mgrChkIssued As ChkIssuedManager
            trans = New PDSATransaction()
            mgrChkIssued = New ChkIssuedManager()
            mgrChkIssued.DataObject.TransactionType = PDSATransactionType.Insert
            Try
                'Save Header Section 
                mgrChkIssued.Entity.Trandate = CDate(deDateIssued.Text)
                mgrChkIssued.Entity.bankid = CInt(leBank.EditValue)
                mgrChkIssued.Entity.Payee = txtPayee.Text.Trim
                mgrChkIssued.Entity.Chkdate = CDate(deDateIssued.Text)
                mgrChkIssued.Entity.Chkno = txtChkNo.Text.Trim
                mgrChkIssued.Entity.ChkAmnt = Convert.ToDecimal(ceAmount.Value)
                mgrChkIssued.Entity.AmountWords = txtamntwords.Text.Trim
                mgrChkIssued.Entity.Cleared = False
                mgrChkIssued.Entity.Cancelled = False
                mgrChkIssued.Entity.Remarks = txtRemarks.Text.Trim
                mgrChkIssued.Entity.dtInsertdt = Now
                mgrChkIssued.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                trans.Add(mgrChkIssued.DataObject)
                ''TranPayment.Execute()
                ''Update dlvry_hdr paid field to true
                'mgrdlvry = New dlvry_hdrManager()
                ''TranPayment = New PDSATransaction()
                'mgrdlvry.DataObject.SelectFilter = dlvry_hdrData.SelectFilters.All
                'mgrdlvry.DataObject.LoadByPK(CInt(dgPayment.Rows(iii).Cells(0).Value))
                'mgrdlvry.DataObject.TransactionType = PDSATransactionType.Update
                'mgrdlvry.Entity.paid = True
                'TranPayment.Add(mgrdlvry.DataObject)

                'Update the balance on suppliers by subtractivng the amount to the current balance
                'mgrSupplier = New suppliersManager
                ''TranPayment = New PDSATransaction()
                'mgrSupplier.DataObject.SelectFilter = suppliersData.SelectFilters.All
                'mgrSupplier.DataObject.LoadByPK(CInt(leSupplier.EditValue))
                'mgrSupplier.DataObject.TransactionType = PDSATransactionType.Update
                'mgrSupplier.Entity.balance = mgrSupplier.Entity.balance - CDec(txtTotInv.Text)
                'trans.Add(mgrSupplier.DataObject)

                'execute Transaction on Payment Saving and Update the Paid to true on dlvry_hdr
                'to exclude in the payment selection
                trans.Execute()
                'Stored Proc 
                'Dim TranDrSp As New PDSATransaction()
                'Dim mgrspDrTrans As New spDlvryProcManager()
                'mgrspDrTrans.Entity.drdrid = mPid
                'mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
                'TranDrSp.Add(mgrspDrTrans.DataObject)
                'TranDrSp.Execute()
                If MsgBox("Press Enter to Print, Press N or Click No To Cancel Printing", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then

                    Dim repUCPB As New xrUCPB()
                    Dim repCHINA As New xrChina()
                    Dim repRCBC As New xrRCBC()

                    If leBank.Text = "UCPB" Then

                        'AddHandler posrep.PrintingSystem.StartPrint, AddressOf Me.PrintingSystem_StartPrint
                        'posrep.DataSource = sqlDT
                        repUCPB.chkid.Value = mPid
                        repUCPB.RequestParameters = False
                        repUCPB.PrintingSystem.ShowMarginsWarning = False
                        repUCPB.Print()
                    ElseIf leBank.Text = "CHINA" Then
                        repCHINA.chkid.Value = mPid
                        repCHINA.RequestParameters = False
                        repCHINA.PrintingSystem.ShowMarginsWarning = False
                        repCHINA.Print()

                    Else
                        repRCBC.chkid.Value = mPid
                        repRCBC.RequestParameters = False
                        repRCBC.PrintingSystem.ShowMarginsWarning = False
                        repRCBC.Print()

                    End If

                End If

                MessageBox.Show("Record Successfully Saved.")
                TransFinished()
                ClearCtrls()
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                MessageBox.Show(mgrSupplier.DataObject.ClassName)
                MessageBox.Show(mgrSupplier.DataObject.SQL)
                Exit Sub
            End Try
        End If


    End Sub
    Private Sub TranPayment_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranPayment.AfterSubmit
        If e.ClassName = "ChkIssuedData" Then
            mPid = DirectCast(e.DataClassTable.EntityObject, ChkIssued).chkisueid
        End If
    End Sub

    Private Sub txtChkNo_LostFocus(sender As Object, e As EventArgs) Handles txtChkNo.LostFocus
        If txtChkNo.Text <> String.Empty Then
            Try
                Dim mgrChkIssued As ChkIssuedManager = New ChkIssuedManager()
                mgrChkIssued.DataObject.SelectFilter = ChkIssuedData.SelectFilters.All
                'mgrChkIssued.DataObject.WhereFilter = ChkIssuedData.WhereFilters.ChkNo
                mgrChkIssued.Entity.ChkNo = txtChkNo.Text.Trim
                mgrChkIssued.DataObject.Load()
                If mgrChkIssued.DataObject.RowsAffected > 0 Then
                    MessageBox.Show("Check No. Already Issued to " & mgrChkIssued.DataObject.Entity.Payee)

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

    Private Sub textOfNumber()

        'oTextNum.setRegistrationKey("3842-539-837-306-5999") ' replace with your purchased serial number once you get one

        'oTextNum.setCurrency("Peso", "Pesos", "cent", "cents")
        'Me.txtamntwords.RightToLeft = Windows.Forms.RightToLeft.No
        'Me.txtamntwords.Text = oTextNum.translateNumber(CStr(valid(Me.ceAmount.Text)), Language_ID.English)

    End Sub
    Private Function valid(ByVal str As String) As Decimal
        On Error Resume Next
        If str = "" Then
            Return CDec("0.0")
        Else
            Return CDec(str)
        End If

    End Function

    Private Sub ceAmount_Leave(sender As Object, e As EventArgs) Handles ceAmount.Leave
        textOfNumber()
    End Sub

End Class