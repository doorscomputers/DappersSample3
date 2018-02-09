Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmCancelCheck
    Private WithEvents TransCancel As PDSATransaction
    Dim mgrChkIssued As ChkIssuedManager
    Dim chkissuedpk As Integer = 0
    Dim mPid As Integer = 0
    Public Sub txtChkNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtChkNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                chkissuedpk = 0
                Dim mgrChkIssued As ChkIssuedManager = New ChkIssuedManager()
                mgrChkIssued.DataObject.SelectFilter = ChkIssuedData.SelectFilters.All
                '  mgrChkIssued.DataObject.WhereFilter = ChkIssuedData.WhereFilters.Chkno
                mgrChkIssued.Entity.Chkno = txtChkNo.Text.Trim
                mgrChkIssued.DataObject.Load()
                If mgrChkIssued.DataObject.RowsAffected > 0 Then
                    deChkDate.EditValue = mgrChkIssued.DataObject.Entity.Chkdate
                    ceAmount.Value = mgrChkIssued.DataObject.Entity.ChkAmnt
                    txtPayee.Text = mgrChkIssued.DataObject.Entity.Payee
                    txtRemarks.Text = mgrChkIssued.DataObject.Entity.Remarks
                    chkissuedpk = mgrChkIssued.DataObject.Entity.chkisueid
                    txtChkNo.Enabled = False
                    btnSave.Enabled = True
                    btnSave.Focus()
                Else
                    MessageBox.Show("Check No. is not yet Issued.", "Check # Not Found!")
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

    Private Sub frmCancelCheck_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCancelCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChkNo.Text = String.Empty
        deChkDate.Text = String.Empty
        ceAmount.Value = 0
        txtPayee.Text = String.Empty
        txtRemarks.Text = String.Empty
        btnSave.Enabled = False
        txtChkNo.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtChkNo.Text = String.Empty
        deChkDate.Text = String.Empty
        ceAmount.Value = 0
        txtPayee.Text = String.Empty
        txtRemarks.Text = String.Empty
        btnSave.Enabled = False
        txtChkNo.Enabled = True
        txtChkNo.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtChkNo.Text <> String.Empty Then

            If MsgBox("Are you sure you want to cancel the issued check?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then
                TransCancel = New PDSATransaction()

                Try
                    'mgrChkIssued = New ChkIssuedManager()
                    'mgrChkIssued.DataObject.SelectFilter = ChkIssuedData.SelectFilters.All

                    'mgrChkIssued.DataObject.UpdateFilter = ChkIssuedData.UpdateFilters.PrimaryKey
                    'mgrChkIssued.DataObject.LoadByPK(chkissuedpk)
                    'mgrChkIssued.Entity.Cancelled = True
                    'mgrChkIssued.Entity.sLastUpdatedt = DateTime.Now

                    'TransCancel.Add(mgrChkIssued.DataObject)
                    'mgrChkIssued.DataObject.TransactionType = PDSATransactionType.Update
                    'TransCancel.Add(mgrChkIssued.DataObject)
                    'TransCancel.Execute()
                    Dim TranCancel As PDSATransaction = New PDSATransaction()
                    Dim mgrChkIssued As ChkIssuedManager = New ChkIssuedManager()

                    mgrChkIssued.DataObject.WhereFilter = ChkIssuedData.WhereFilters.PrimaryKey
                    mgrChkIssued.Entity.chkisueid = chkissuedpk
                    mgrChkIssued.DataObject.Load()
                    If mgrChkIssued.DataObject.RowsAffected > 0 Then
                        mgrChkIssued.DataObject.Entity.Cancelled = True
                        mgrChkIssued.DataObject.Entity.sLastUpdatedt = DateTime.Now
                        mgrChkIssued.DataObject.TransactionType = PDSATransactionType.Update
                        TranCancel.Add(mgrChkIssued.DataObject)
                        TranCancel.Execute()
                    End If

                    MessageBox.Show("Check No Successfully Cancelled.", "Check cancelled")
                    txtChkNo.Text = String.Empty
                    deChkDate.Text = String.Empty
                    ceAmount.Value = 0
                    txtPayee.Text = String.Empty
                    txtRemarks.Text = String.Empty
                    btnSave.Enabled = False
                    txtChkNo.Enabled = True
                    txtChkNo.Focus()

                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                    Exit Sub
                End Try

            End If

        End If

    End Sub

    Private Sub TransCancel_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TransCancel.AfterSubmit
        If e.ClassName = "ChkIssuedData" Then
            mPid = DirectCast(e.DataClassTable.EntityObject, ChkIssued).chkisueid
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class