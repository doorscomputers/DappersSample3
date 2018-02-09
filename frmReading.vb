Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports PDSA.WinForms.Forms
Imports PDSA.WinForms.Security
Imports System.Windows.Forms.Form
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraEditors
Public Class frmReading
    Dim vreadningnum As Integer = 0 ' new Code to be copied to other terminals
    Private Sub ceCheque_GotFocus(sender As Object, e As EventArgs) Handles ceCheque.GotFocus
        ceCheque.SelectAll()
    End Sub
    'Private Sub ceCheque_EditValueChanged(sender As Object, e As EventArgs) Handles ceCheque.EditValueChanged
    '    Dim decCheque As Decimal = 0

    '    decCheque = CDec(ceCheque.Text) * 1
    '    Dim amnt As Decimal = 0
    '    'Cheque.Text = FormatNumber(CStr(decCheque), 2)
    '    amnt = Convert.ToDecimal(Cheque.Text) + Convert.ToDecimal(Thousand.Text) + Convert.ToDecimal(FiveHundred.Text) + Convert.ToDecimal(twohundred.Text) + Convert.ToDecimal(OneHundred.Text) + Convert.ToDecimal(Fifty.Text) + Convert.ToDecimal(Twenty.Text) + Convert.ToDecimal(Ten.Text) + Convert.ToDecimal(Five.Text) + Convert.ToDecimal(One.Text) + Convert.ToDecimal(Cents.Text)
    '    'amnt = CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text)
    '    TotalAmount.Text = FormatNumber(CStr(amnt), 2)
    'End Sub

    'Private Sub ceThousand_EditValueChanged(sender As Object, e As EventArgs) Handles ceThousand.EditValueChanged
    '    Thousand.Text = CStr(CDec(ceThousand.Value * 1000))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceFiveHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceFiveHundred.EditValueChanged
    '    FiveHundred.Text = CStr(CDec(ceFiveHundred.Value * 500))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceTwoHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceTwoHundred.EditValueChanged
    '    twohundred.Text = CStr(CDec(ceTwoHundred.Value * 200))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceOneHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceOneHundred.EditValueChanged
    '    OneHundred.Text = CStr(CDec(ceOneHundred.Value * 100))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceFifty_EditValueChanged(sender As Object, e As EventArgs) Handles ceFifty.EditValueChanged
    '    Fifty.Text = CStr(CDec(ceFifty.Value * 50))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceTwenty_EditValueChanged(sender As Object, e As EventArgs) Handles ceTwenty.EditValueChanged
    '    Twenty.Text = CStr(CDec(ceTwenty.Value * 20))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceTen_EditValueChanged(sender As Object, e As EventArgs) Handles ceTen.EditValueChanged
    '    Ten.Text = CStr(CDec(ceTen.Value * 10))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceFive_EditValueChanged(sender As Object, e As EventArgs) Handles ceFive.EditValueChanged
    '    Five.Text = CStr(CDec(ceFive.Value * 5))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceOne_EditValueChanged(sender As Object, e As EventArgs) Handles ceOne.EditValueChanged
    '    One.Text = CStr(CDec(ceOne.Value * 1))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    'Private Sub ceCents_EditValueChanged(sender As Object, e As EventArgs) Handles ceCents.EditValueChanged
    '    Cents.Text = CStr(CDec(ceCents.Value * 0.25))
    '    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
    'End Sub

    Private Sub ceCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles ceCheque.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            ceThousand.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            ceThousand.Focus()
            Call calcgt()
            ceThousand.Focus()
        End If

    End Sub

    Private Sub ceThousand_GotFocus(sender As Object, e As EventArgs) Handles ceThousand.GotFocus, cekAmnt.GotFocus, cefivehamnt.GotFocus, cethamnt.GotFocus, ceonehundredamnt.GotFocus, cefiftyamnt.GotFocus, cetwentyamnt.GotFocus, cetenamnt.GotFocus, cefiveamnt.GotFocus, ceonepesoamnt.GotFocus, cecentsamnt.GotFocus, ceGT.GotFocus, ceEOne.GotFocus, ceETen.GotFocus, ceET.GotFocus, ceEF.GotFocus, ceEOh.GotFocus, ceETotal.GotFocus, ceETh.GotFocus
        ceThousand.SelectAll()
    End Sub

    Private Sub ceThousand_KeyDown(sender As Object, e As KeyEventArgs) Handles ceThousand.KeyDown, cekAmnt.KeyDown, cefivehamnt.KeyDown, cethamnt.KeyDown, ceonehundredamnt.KeyDown, cefiftyamnt.KeyDown, cetwentyamnt.KeyDown, cetenamnt.KeyDown, cefiveamnt.KeyDown, ceonepesoamnt.KeyDown, cecentsamnt.KeyDown, ceGT.KeyDown, ceETh.KeyDown, ceEOh.KeyDown, ceEF.KeyDown, ceET.KeyDown, ceETen.KeyDown, ceEOne.KeyDown, ceETotal.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            ceCheque.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            ceFiveHundred.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            cekAmnt.Value = ceThousand.Value * 1000
            Call calcgt()
            ceFiveHundred.Focus()
        End If

    End Sub

    Private Sub ceFiveHundred_GotFocus(sender As Object, e As EventArgs) Handles ceFiveHundred.GotFocus
        ceFiveHundred.SelectAll()
    End Sub

    Private Sub ceFiveHundred_KeyDown(sender As Object, e As KeyEventArgs) Handles ceFiveHundred.KeyDown
        If e.KeyCode = Keys.Up Then
            ceThousand.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceTwoHundred.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            cefivehamnt.Value = ceFiveHundred.Value * 500
            ceGT.Value = 0
            Call calcgt()
            ceTwoHundred.Focus()
        End If
    End Sub

    Private Sub ceTwoHundred_GotFocus(sender As Object, e As EventArgs) Handles ceTwoHundred.GotFocus
        ceTwoHundred.SelectAll()
    End Sub

    Private Sub ceTwoHundred_KeyDown(sender As Object, e As KeyEventArgs) Handles ceTwoHundred.KeyDown
        If e.KeyCode = Keys.Up Then
            ceFiveHundred.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceOneHundred.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cethamnt.Value = ceTwoHundred.Value * 200
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceOneHundred_GotFocus(sender As Object, e As EventArgs) Handles ceOneHundred.GotFocus
        ceOneHundred.SelectAll()
    End Sub

    Private Sub ceOneHundred_KeyDown(sender As Object, e As KeyEventArgs) Handles ceOneHundred.KeyDown
        If e.KeyCode = Keys.Up Then
            ceTwoHundred.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceFifty.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            ceonehundredamnt.Value = ceOneHundred.Value * 100
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceFifty_GotFocus(sender As Object, e As EventArgs) Handles ceFifty.GotFocus
        ceFifty.SelectAll()
    End Sub

    Private Sub ceFifty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceFifty.KeyDown
        If e.KeyCode = Keys.Up Then
            ceOneHundred.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceTwenty.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cefiftyamnt.Value = ceFifty.Value * 50
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceTwenty_GotFocus(sender As Object, e As EventArgs) Handles ceTwenty.GotFocus
        ceTwenty.SelectAll()
    End Sub

    Private Sub ceTwenty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceTwenty.KeyDown
        If e.KeyCode = Keys.Up Then
            ceFifty.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceTen.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cetwentyamnt.Value = ceTwenty.Value * 20
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceTen_GotFocus(sender As Object, e As EventArgs) Handles ceTen.GotFocus
        ceTen.SelectAll()
    End Sub

    Private Sub ceTen_KeyDown(sender As Object, e As KeyEventArgs) Handles ceTen.KeyDown
        If e.KeyCode = Keys.Up Then
            ceTwenty.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceFive.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cetenamnt.Value = ceTen.Value * 10
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceFive_GotFocus(sender As Object, e As EventArgs) Handles ceFive.GotFocus
        ceFive.SelectAll()
    End Sub

    Private Sub ceFive_KeyDown(sender As Object, e As KeyEventArgs) Handles ceFive.KeyDown
        If e.KeyCode = Keys.Up Then
            ceTen.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceOne.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cefiveamnt.Value = ceFive.Value * 5
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceOne_GotFocus(sender As Object, e As EventArgs) Handles ceOne.GotFocus
        ceOne.SelectAll()
    End Sub

    Private Sub ceOne_KeyDown(sender As Object, e As KeyEventArgs) Handles ceOne.KeyDown
        If e.KeyCode = Keys.Up Then
            ceFive.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            ceCents.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            ceonepesoamnt.Value = ceOne.Value * 1
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub ceCents_GotFocus(sender As Object, e As EventArgs) Handles ceCents.GotFocus
        ceCents.SelectAll()
    End Sub

    Private Sub ceCents_KeyDown(sender As Object, e As KeyEventArgs) Handles ceCents.KeyDown
        If e.KeyCode = Keys.Up Then
            ceOne.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            btnSave.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            cecentsamnt.Value = CDec(ceCents.Value * 0.25)
            ceGT.Value = 0
            Call calcgt()
        End If
    End Sub

    Private Sub calcgt()
        ceGT.Value = CDec(ceCheque.Value + cekAmnt.Value + cefivehamnt.Value + cethamnt.Value + ceonehundredamnt.Value + cefiftyamnt.Value + cetwentyamnt.Value + cetenamnt.Value + cefiveamnt.Value + ceonepesoamnt.Value + cecentsamnt.Value)
    End Sub
    Private Sub frmReading_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ceCheque.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceCheque.Focus()
            Exit Sub
        End If

        If ceThousand.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceThousand.Focus()
            Exit Sub
        End If
        If ceFiveHundred.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceFiveHundred.Focus()
            Exit Sub
        End If
        If ceTwoHundred.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceTwoHundred.Focus()
            Exit Sub
        End If
        If ceOneHundred.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceOneHundred.Focus()
            Exit Sub
        End If
        If ceFifty.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceFifty.Focus()
            Exit Sub
        End If
        If ceTwenty.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceTwenty.Focus()
            Exit Sub
        End If
        If ceTen.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceTen.Focus()
            Exit Sub
        End If
        If ceFive.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceFive.Focus()
            Exit Sub
        End If
        If ceOne.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceOne.Focus()
            Exit Sub
        End If
        If ceCents.Value < 0 Then
            MessageBox.Show("Negative Values are not allowed!")
            ceCents.Focus()
            Exit Sub
        End If
        Dim ansreading As Integer = 7
        ansreading = MsgBox("Make sure all the Cash Count are entered correctly before continuing. Please Confirm by Clicking Yes", MsgBoxStyle.YesNo, "Confirm Cash Count")
        If ansreading = 7 Then
            Exit Sub
        End If



        btnSave.Enabled = False
        Dim mgr As tblreadingManager
        Dim tran As PDSATransaction

        Dim tran5 As PDSATransaction
        Dim totalcashbd As Decimal = 0 ' Total Cash Breakdown
        Dim computerresults As Decimal = 0
        Dim vovershort As Decimal = 0

        Dim mgrtransfer As spTmptoFinalPOSManager

        Try
            sqlSTR = "exec spGetTotalSalesDiscountCredit @TotalSales2=0,@TotalSales=0,@TotalDiscamnt=0,@TotalCredit=0,@TotalRefunds=0,@CountTotalSales=0,@CountTotalRefunds=0,@CountTotalDiscounts=0,@CountSenior=0,@Countdiscreg=0,@CountVoids=0,@CountReceipt=0,@BegReceipt=0,@EndReceipt=0,@Terminal=1,@InsertID=" & PDSAAppConfig.CurrentLoginID
            ' MessageBox.Show(sqlSTR)
            'sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
            ExecuteSQLQuery(sqlSTR)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            MessageBox.Show("Reading Not Saved. Please Try Again")
            Exit Sub
        End Try


        Try
            ''execute the stored proc to get the total sales
            ''tran4 = New PDSATransaction()
            ''tran5 = New PDSATransaction()
            'sqlSTR = "exec spGetTotalSalesDiscountCredit @TotalSales2=0,@TotalSales=0,@TotalDiscamnt=0,@TotalCredit=0,@TotalRefunds=0,@CountTotalSales=0,@CountTotalRefunds=0,@CountTotalDiscounts=0,@CountSenior=0,@Countdiscreg=0,@CountVoids=0,@CountReceipt=0,@BegReceipt=0,@EndReceipt=0,@InsertID=" & PDSAAppConfig.CurrentLoginID
            '' MessageBox.Show(sqlSTR)
            ''sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
            'ExecuteSQLQuery(sqlSTR)

            'mgrgetsalestot = New spGetTransAmountManager()
            'mgrgetsalestot.Entity.InsertID = PDSAAppConfig.CurrentLoginID
            'mgrgetsalestot.DataObject.Execute()
            'tran4.Add(mgrgetsalestot.DataObject)
            'tran4.Execute()

            tran = New PDSATransaction()
            mgr = New tblreadingManager()
            'mgr.DataObject.SelectFilter = tblreadingData.SelectFilters.All
            mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.cashierupstd
            mgr.Entity.cashier = CStr(PDSAAppConfig.CurrentLoginID)
            mgr.DataObject.Load()
            If mgr.DataObject.RowsAffected > 0 Then
                vreadningnum = mgr.DataObject.Entity.readingno
                mgr.DataObject.Entity.totalcheque = Convert.ToDecimal(ceCheque.Value)
                mgr.DataObject.Entity.thousndp = Convert.ToDecimal(ceThousand.Value)
                mgr.DataObject.Entity.fiehundredp = Convert.ToDecimal(ceFiveHundred.Value)
                mgr.DataObject.Entity.twohundredp = Convert.ToDecimal(ceTwoHundred.Value)
                mgr.DataObject.Entity.onehundredp = Convert.ToDecimal(ceOneHundred.Value)
                mgr.DataObject.Entity.fiftyp = Convert.ToDecimal(ceFifty.Value)
                mgr.DataObject.Entity.twentyp = Convert.ToDecimal(ceTwenty.Value)
                mgr.DataObject.Entity.tenp = Convert.ToDecimal(ceTen.Value)
                mgr.DataObject.Entity.fivep = Convert.ToDecimal(ceFive.Value)
                mgr.DataObject.Entity.onep = Convert.ToDecimal(ceOne.Value)
                mgr.DataObject.Entity.twentyfive = Convert.ToDecimal(ceCents.Value)
                mgr.DataObject.Entity.readtime = DateTime.Now
                mgr.DataObject.Entity.ETwo = Convert.ToDecimal(CalcEdit7.Value)
                mgr.DataObject.Entity.EOneHundred = Convert.ToDecimal(CalcEdit8.Value)
                mgr.DataObject.Entity.EFifty = Convert.ToDecimal(CalcEdit9.Value)
                mgr.DataObject.Entity.ETwenty = Convert.ToDecimal(CalcEdit10.Value)
                mgr.DataObject.Entity.ETen = Convert.ToDecimal(CalcEdit11.Value)
                mgr.DataObject.Entity.Eone = Convert.ToDecimal(CalcEdit12.Value)
                mgr.DataObject.Entity.TotRemit = Convert.ToDecimal(ceETotal.Value)

                'Comment Oct 17 2017
                '''mgr.DataObject.Entity.overshort = Convert.ToDecimal(TotalAmount.Text)
                ''mgr.DataObject.Entity.status = True

                ''Total all the cash count and Add cheque amount to be subtracted to the computer generated results
                'totalcashbd = CDec((Convert.ToDecimal(ceCheque.Value) * 1) + (Convert.ToDecimal(ceThousand.Value) * 1000) + (Convert.ToDecimal(ceFiveHundred.Value * 500)) + (Convert.ToDecimal(ceTwoHundred.Value) * 200) +
                '(Convert.ToDecimal(ceOneHundred.Value) * 100) + (Convert.ToDecimal(ceFifty.Value) * 50) + (Convert.ToDecimal(ceTwenty.Value) * 20) _
                '+ (Convert.ToDecimal(ceTen.Value) * 10) + (Convert.ToDecimal(ceFive.Value) * 5) + (Convert.ToDecimal(ceOne.Value) * 1) +
                '(Convert.ToDecimal(ceCents.Value) * 0.25))

                '' computerresults = (mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.payments + mgr.DataObject.Entity.begincash) - (mgr.DataObject.Entity.totalcredit + mgr.DataObject.Entity.pickup)
                'computerresults = (mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.payments + mgr.DataObject.Entity.begincash) - (mgr.DataObject.Entity.pickup) '- (mgr.DataObject.Entity.totaldiscount) 'vovershort = computerresults - totalcashbd
                'vovershort = totalcashbd - computerresults
                'End of Comment Oct 2017

                'New Code Oct 2017
                computerresults = (CDec(ceGT.Value) + mgr.DataObject.Entity.pickup + CDec(mgr.DataObject.Entity.totalrefs * -1) + mgr.DataObject.Entity.totaldiscount + mgr.DataObject.Entity.totalcredit + mgr.DataObject.Entity.totalcheque + Convert.ToDecimal(ceETotal.Value))
                totalcashbd = CDec(mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.begincash + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.totalcredit)
                vovershort = computerresults - totalcashbd
                'End of NEw Code Oct 2017
                mgr.DataObject.Entity.overshort = vovershort
                'update transaction code below
                mgr.DataObject.TransactionType = PDSATransactionType.Update
                tran.Add(mgr.DataObject)
                tran.Execute()

                'execute stored proc to transfer temporary sales data to pos_hdr and pos_det
                tran5 = New PDSATransaction()
                mgrtransfer = New spTmptoFinalPOSManager()
                mgrtransfer.Entity.InsertID = PDSAAppConfig.CurrentLoginID
                mgrtransfer.Entity.trminal = 1
                tran5.Add(mgrtransfer.DataObject)
                tran5.Execute()

                Dim strsqlupdatetrminal As String = "EXECUTE spGetTotalAccSalesPerTerminal 1,0,0"
                ExecuteSQLQuery(strsqlupdatetrminal)



                Dim mgrr As tblreadingManager = New tblreadingManager()
                Dim tranr As PDSATransaction = New PDSATransaction()

                Dim rep As New Zout()
                rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
                rep.RequestParameters = False
                rep.PrintingSystem.ShowMarginsWarning = False
                rep.Print()

                Dim rep2 As New xrZReading()
                rep2.PCashier.Value = PDSAAppConfig.CurrentLoginID
                rep2.TerminalNo.Value = 1
                rep2.readingid.Value = vreadningnum
                rep2.RequestParameters = False
                rep2.PrintingSystem.ShowMarginsWarning = False
                rep2.Print()


                'rep.ShowPreview()

                ''+New Code
                'Dim repCashtaken As New xrPettyCash()
                ''rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
                ''rep.RequestParameters = False
                'repCashtaken.PrintingSystem.ShowMarginsWarning = False
                'repCashtaken.Print()

                'Dim posrep As New xrTrasnferPrnt()
                ''posrep.DataSource = sqlDT
                ''posrep.Parameter1.Value = vSalesNum
                ''posrep.RequestParameters = False
                'posrep.PrintingSystem.ShowMarginsWarning = False
                'posrep.Print()

                'Dim repreceive As New xrReceiveStocks()
                'repreceive.PrintingSystem.ShowMarginsWarning = False
                'repreceive.Print()


                ''+End of New Code

                'mgr.DataObject.SelectFilter = tblreadingData.SelectFilters.All
                mgrr.DataObject.WhereFilter = tblreadingData.WhereFilters.cashierupstd
                mgrr.Entity.cashier = CStr(PDSAAppConfig.CurrentLoginID)
                mgrr.DataObject.Load()
                If mgrr.DataObject.RowsAffected > 0 Then
                    mgrr.DataObject.Entity.status = True
                    mgrr.DataObject.TransactionType = PDSATransactionType.Update
                    tranr.Add(mgrr.DataObject)
                    tranr.Execute()
                End If
                ' PrintReading()
                MessageBox.Show("Cash Breakdown Successfully Saved")
                Me.Close()
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub PrintReading()


        'Dim rep As New Zout()
        'rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
        'rep.RequestParameters = False
        'rep.PrintingSystem.ShowMarginsWarning = False
        'rep.Print()
        Dim mgrr As tblreadingManager = New tblreadingManager()
        Dim tranr As PDSATransaction = New PDSATransaction()
        Dim rep As New Zout()
        rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
        rep.RequestParameters = False
        rep.PrintingSystem.ShowMarginsWarning = False
        rep.Print()
        'mgr.DataObject.SelectFilter = tblreadingData.SelectFilters.All
        mgrr.DataObject.WhereFilter = tblreadingData.WhereFilters.cashierupstd
        mgrr.Entity.cashier = CStr(PDSAAppConfig.CurrentLoginID)
        mgrr.DataObject.Load()
        If mgrr.DataObject.RowsAffected > 0 Then
            mgrr.DataObject.Entity.status = True
            mgrr.DataObject.TransactionType = PDSATransactionType.Update
            tranr.Add(mgrr.DataObject)
            tranr.Execute()
        End If

        Me.Close()

    End Sub

    Private Sub frmReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cethamnt.Value = 0
        ceonehundredamnt.Value = 0
        cefiftyamnt.Value = 0
        cetwentyamnt.Value = 0
        cetenamnt.Value = 0
        cefiveamnt.Value = 0
        ceonepesoamnt.Value = 0
        cecentsamnt.Value = 0
        cekAmnt.Focus()

    End Sub

    Private Sub ceCheque_Spin(sender As Object, e As SpinEventArgs) Handles ceCheque.Spin
        e.Handled = True
    End Sub

    Private Sub ceThousand_Spin(sender As Object, e As SpinEventArgs) Handles ceThousand.Spin, cekAmnt.Spin, cefivehamnt.Spin, cethamnt.Spin, ceonehundredamnt.Spin, cefiftyamnt.Spin, cetwentyamnt.Spin, cetenamnt.Spin, cefiveamnt.Spin, ceonepesoamnt.Spin, cecentsamnt.Spin, ceGT.Spin, ceETh.Spin, ceEOh.Spin, ceEF.Spin, ceET.Spin, ceETen.Spin, ceEOne.Spin, ceETotal.Spin
        e.Handled = True
    End Sub

    Private Sub ceFiveHundred_Spin(sender As Object, e As SpinEventArgs) Handles ceFiveHundred.Spin
        e.Handled = True
    End Sub

    Private Sub ceTwoHundred_Spin(sender As Object, e As SpinEventArgs) Handles ceTwoHundred.Spin, CalcEdit7.Spin
        e.Handled = True
    End Sub
    Private Sub ceOneHundred_Spin(sender As Object, e As SpinEventArgs) Handles ceOneHundred.Spin, CalcEdit8.Spin
        e.Handled = True
    End Sub
    Private Sub ceFifty_Spin(sender As Object, e As SpinEventArgs) Handles ceFifty.Spin, CalcEdit9.Spin
        e.Handled = True
    End Sub

    Private Sub ceTwenty_Spin(sender As Object, e As SpinEventArgs) Handles ceTwenty.Spin, CalcEdit10.Spin
        e.Handled = True
    End Sub
    Private Sub ceTen_Spin(sender As Object, e As SpinEventArgs) Handles ceTen.Spin, CalcEdit11.Spin
        e.Handled = True
    End Sub

    Private Sub ceFive_Spin(sender As Object, e As SpinEventArgs) Handles ceFive.Spin
        e.Handled = True
    End Sub

    Private Sub ceOne_Spin(sender As Object, e As SpinEventArgs) Handles ceOne.Spin, CalcEdit12.Spin
        e.Handled = True
    End Sub
    Private Sub ceCents_Spin(sender As Object, e As SpinEventArgs) Handles ceCents.Spin
        e.Handled = True
    End Sub

    Private Sub btnSave_GotFocus(sender As Object, e As EventArgs) Handles btnSave.GotFocus
        ceETotal.Value = CDec(ceETh.Value + ceEOh.Value + ceEF.Value + ceET.Value + ceETen.Value + ceEOne.Value)
    End Sub

    Private Sub CalcEdit7_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit7.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            ceCents.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            CalcEdit8.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceETh.Value = CalcEdit7.Value * 200
            Call calcEgt()
            CalcEdit8.Focus()
        End If
    End Sub

    Private Sub calcEgt()
        ceGT.Value = 0
        ceGT.Value = CDec(cekAmnt.Value + cefivehamnt.Value + cethamnt.Value + ceonehundredamnt.Value + cefiftyamnt.Value + cetwentyamnt.Value + cetenamnt.Value + cefiveamnt.Value + ceonepesoamnt.Value + cecentsamnt.Value)
    End Sub

    Private Sub CalcEdit8_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit8.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            CalcEdit7.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            CalcEdit9.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceEOh.Value = CalcEdit8.Value * 100
            Call calcEgt()
            CalcEdit9.Focus()
        End If
    End Sub

    Private Sub CalcEdit9_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit9.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            CalcEdit8.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            CalcEdit10.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceEF.Value = CalcEdit9.Value * 50
            Call calcEgt()
            CalcEdit10.Focus()
        End If
    End Sub

    Private Sub CalcEdit10_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit10.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            CalcEdit9.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            CalcEdit11.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceET.Value = CalcEdit10.Value * 20
            Call calcEgt()
            CalcEdit11.Focus()
        End If
    End Sub

    Private Sub CalcEdit11_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit11.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            CalcEdit10.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            CalcEdit12.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceETen.Value = CalcEdit11.Value * 10
            Call calcEgt()
            CalcEdit12.Focus()
        End If
    End Sub

    Private Sub CalcEdit12_KeyDown(sender As Object, e As KeyEventArgs) Handles CalcEdit12.KeyDown
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            CalcEdit11.Focus()
        End If
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            btnSave.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            ceEOne.Value = CalcEdit12.Value * 1
            Call calcEgt()
            btnSave.Focus()
        End If
    End Sub
End Class