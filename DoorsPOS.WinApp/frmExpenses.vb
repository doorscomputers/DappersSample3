Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Public Class frmExpenses
    Dim mgr8 As stocksManager
    Private Sub frmExpenses_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub


    Private Sub frmExpenses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If btnSave.Enabled = True Then
            e.Cancel = True
            MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.")
        End If
    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadExpenses()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadExpenses()
        Dim mgrs As tblExpensesManager = New tblExpensesManager()
        mgrs.DataObject.OrderByFilter = tblExpensesData.OrderByFilters.expdesc
        Dim cols As tblExpensesCollection
        cols = mgrs.BuildCollection()
        leexpenses.Properties.DisplayMember = "expdesc"
        leexpenses.Properties.ValueMember = "expenseid"
        leexpenses.Properties.DataSource = cols
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub EnableControls()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        GroupControl1.Enabled = True
        btnClose.Enabled = False
        btnNew.Enabled = False
        deexpDate.Focus()
    End Sub

    Private Sub DisableControls()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        GroupControl1.Enabled = False
        btnClose.Enabled = True
        btnNew.Enabled = True
        btnNew.Focus()
    End Sub

    Private Sub InitControls()
        deexpDate.EditValue = DateAndTime.Today
        txtRemarks.Text = ""
        ceAmount.Value = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableControls()
        InitControls()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableControls()
        InitControls()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If leexpenses.Text = String.Empty Then
            MessageBox.Show("Please select the expense type before saving")
            leexpenses.Focus()
            Exit Sub
        End If

        If ceAmount.Value <= 0 Then
            MessageBox.Show("Please enter the Amount")
            ceAmount.Focus()
            Exit Sub
        End If

        If deexpDate.Text = String.Empty Then
            MessageBox.Show("Please enter the date of expenditure")
            deexpDate.Focus()
            Exit Sub
        End If


        Dim TranBo As PDSATransaction = New PDSATransaction()
        Dim mgrexp As tblExpenseTransManager = New tblExpenseTransManager()

        Try
            mgrexp.DataObject.TransactionType = PDSATransactionType.Insert
            mgrexp.DataObject.Entity.expdate = CDate(deexpDate.Text)
            mgrexp.DataObject.Entity.expamount = CDec(ceAmount.Value)
            mgrexp.DataObject.Entity.expenseid = CInt(leexpenses.EditValue)
            mgrexp.DataObject.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrexp.DataObject.Entity.expremarks = txtRemarks.Text
            TranBo.Add(mgrexp.DataObject)
            'later on put a code here to call a stored proc to save the data to an accounting type

            TranBo.Execute()
            DisableControls()
            MessageBox.Show("Expense Entry Form Successfully Saved", "Saving Successful")
            InitControls()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub txtRemarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemarks.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSave.Focus()
        End If
    End Sub

End Class