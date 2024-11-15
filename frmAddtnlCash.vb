Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class frmAddtnlCash
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ceamount.Value <= 0 Then
            MessageBox.Show("Please enter amount added.")
            Exit Sub
        End If

        If CStr(depaydate.EditValue) = "" Then
            MessageBox.Show("Please enter amount added.")
            Exit Sub
        End If

        Dim ansint As Integer = 7
        ansint = MsgBox("Are you sure you want to Save the Additional Cash Amount?", MsgBoxStyle.YesNo, "Additional Cash Save Confirmation")
        If ansint = 6 Then
            Try
                Dim tranmgr As PDSATransaction = New PDSATransaction()
                Dim mgrpay As New additnlcashManager
                Dim mgrrdng As New tblreadingManager()

                '''''''''''''''

                mgrpay.Entity.posdate = CDate(depaydate.EditValue)
                mgrpay.Entity.acamnt = Convert.ToDecimal(ceamount.Value)
                mgrpay.Entity.acremarks = txtremark.Text
                mgrpay.Entity.cashier = PDSAAppConfig.CurrentLoginID

                mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All
                mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                mgrrdng.Entity.cashier = PDSAAppConfig.CurrentLoginID
                mgrrdng.DataObject.Load()
                If mgrrdng.DataObject.RowsAffected > 0 Then
                    mgrrdng.Entity.addcash = Convert.ToDecimal(ceamount.Value) + mgrrdng.Entity.addcash
                    mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey
                End If

                mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert
                mgrrdng.DataObject.TransactionType = PDSATransactionType.Update
                tranmgr.Add(mgrpay.DataObject)
                tranmgr.Add(mgrrdng.DataObject)
                tranmgr.Execute()

                Dim intgc As Integer = 0
                intgc = mgrpay.Entity.acid
                Dim ansint11 As Integer = 7
                ansint11 = MsgBox("Print Petty Cash?", MsgBoxStyle.YesNo, "Print Confirmation")
                If ansint11 = 6 Then
                    Dim xraddcash As New xrAddCash2()
                    xraddcash.adcashid.Value = intgc
                    xraddcash.RequestParameters = False
                    xraddcash.PrintingSystem.ShowMarginsWarning = False
                    AddHandler xraddcash.PrintingSystem.StartPrint, AddressOf ReportOnStartPrint
                    xraddcash.Print()
                End If

                disable()
                initialvals()
                MessageBox.Show("Addtional Cash successfully saved.")
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
        ansint = MsgBox("Are you sure you want to cancel Additonal Cash Entry?", MsgBoxStyle.YesNo, "Cancel Confirmation")
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

    Private Sub frmAddtnlCash_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
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
        End If
    End Sub
    Private Sub frmAddtnlCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depaydate.EditValue = DateAndTime.Today
    End Sub
End Class