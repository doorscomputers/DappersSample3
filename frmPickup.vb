Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class frmPickup
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If ceamount.Value <= 0 Then
            MessageBox.Show("Please enter amount picked up.")
            Exit Sub
        End If

        If CStr(depaydate.EditValue) = "" Then
            MessageBox.Show("Please enter amount picked up.")
            Exit Sub
        End If

        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to Save the Picked-up Cash?", MsgBoxStyle.YesNo, "Pick-up Cash Save Confirmation")
        If ansint = 6 Then
            Try
                'usb printer
                OpenCashdrawer()

                ''lpt printer
                'Dim intFileNo As Integer = FreeFile()
                'FileOpen(1, "c:\escapes.txt", OpenMode.Output)
                'PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))
                'FileClose(1)
                'Shell("print /d:com1 c:\escapes.txt", vbNormalFocus)


                Dim tranmgr As PDSATransaction = New PDSATransaction()
                Dim mgrpay As New petty_cashManager
                Dim mgrrdng As New tblreadingManager()

                '''''''''''''''

                mgrpay.Entity.posdate = CDate(depaydate.EditValue)
                mgrpay.Entity.pcamnt = Convert.ToDecimal(ceamount.Value)
                mgrpay.Entity.pcrem = txtremark.Text
                mgrpay.Entity.cashier = PDSAAppConfig.CurrentLoginID

                mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All
                mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                mgrrdng.Entity.cashier = PDSAAppConfig.CurrentLoginID
                mgrrdng.DataObject.Load()
                If mgrrdng.DataObject.RowsAffected > 0 Then
                    mgrrdng.Entity.pickup = Convert.ToDecimal(ceamount.Value) + mgrrdng.Entity.pickup
                    mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey
                End If

                mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert
                mgrrdng.DataObject.TransactionType = PDSATransactionType.Update
                tranmgr.Add(mgrpay.DataObject)
                tranmgr.Add(mgrrdng.DataObject)
                tranmgr.Execute()
                Dim intgc As Integer = 0
                intgc = mgrpay.Entity.pcid

                Dim xrgetcash As New xrGetCash()
                'posrep.DataSource = sqlDT
                Dim strcashier As String = String.Empty
                strcashier = PDSAAppConfig.CurrentLoginID
                'xrgetcash.Cashier.Value = strcashier
                'xrgetcash.DateTme.Value = CDate(depaydate.Text)
                xrgetcash.ptyCashID.Value = intgc
                xrgetcash.RequestParameters = False
                xrgetcash.PrintingSystem.ShowMarginsWarning = False
                AddHandler xrgetcash.PrintingSystem.StartPrint, AddressOf ReportOnStartPrint
                xrgetcash.Print()


                disable()
                initialvals()
                MessageBox.Show("Pickup Cash successfully saved.")
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                DisplayException(ex)
            End Try

            Me.Close()
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
        txtremark.Text = String.Empty
        depaydate.EditValue = DateAndTime.Today
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enable()
        initialvals()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel Confirmation")
        If ansint = 6 Then
            disable()
            initialvals()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If btnsave.Enabled = True Then
            Dim ans As Integer = 0
            ans = MsgBox("Pending Additional Cash Transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo)
            If ans = 7 Then
                Exit Sub
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmAddtnlCash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPickup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If btnsave.Enabled = True Then
                Dim ans As Integer = 0
                ans = MsgBox("Pending Pick-up Cash Transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo)
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

    Private Sub frmPickup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depaydate.EditValue = DateAndTime.Today
    End Sub
End Class