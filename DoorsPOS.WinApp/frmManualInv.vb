Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors

Public Class frmManualInv
    Dim mgr9 As stocksManager

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim frmitemserch As New frmItemSearch
        frmitemserch.ShowDialog()
        txtItem.Text = String.Empty
        txtStckId.Text = String.Empty
        txtItem.Text = frmitemserch.vItem.ToString
        txtStckId.Text = frmitemserch.vStckid.ToString
        If txtStckId.Text = String.Empty Then
            Exit Sub
        Else
            ceQty.Focus()
        End If
        ceQty.Focus()
    End Sub

    Private Sub frmManualInv_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmManualInv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnSave.Enabled = True Then
            e.Cancel = True
            MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtItem.Text = String.Empty Then
            MessageBox.Show("Please select the item counted.")
            txtItem.Focus()
            Exit Sub
        End If

        If ceQty.Value < 0 Then
            MessageBox.Show("Please enter the number of items counted.")
            ceQty.Focus()
            Exit Sub
        End If

        If deBoDate.Text = String.Empty Then
            MessageBox.Show("Please enter the date the item was counted.")
            deBoDate.Focus()
            Exit Sub
        End If


        Dim TranMI As PDSATransaction = New PDSATransaction()
        Dim mgrMI As InvntoryManager = New InvntoryManager()

        Try
            mgrMI.DataObject.TransactionType = PDSATransactionType.Insert
            mgrMI.DataObject.Entity.amnt = 0
            'mgrMI.DataObject.Entity.amnt = 0
            mgrMI.DataObject.Entity.prevavlbl = 0 'frmItemSearch.vAvlbl
            mgrMI.DataObject.Entity.midate = CDate(deBoDate.Text)
            mgrMI.DataObject.Entity.qty = CInt(ceQty.Value)
            mgrMI.DataObject.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrMI.DataObject.Entity.sLastUpdateid = PDSAAppConfig.CurrentLoginID
            mgrMI.DataObject.Entity.stckid = CInt(Trim(txtStckId.Text))

            TranMI.Add(mgrMI.DataObject)

            Dim mgrspInv As spInvntoryManager = New spInvntoryManager()
            mgrspInv.Entity.StckIid = CInt(txtStckId.Text)
            TranMI.Add(mgrspInv.DataObject)

            TranMI.Execute()
            DisableControls()
            MessageBox.Show("Manual Inventory Entry Successfully Saved", "Saved")
            InitControls()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableControls()
        InitControls()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableControls()
        InitControls()
    End Sub

    Private Sub ceQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceQty.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub EnableControls()
        btnSave.Enabled = True
        btnCancel.Enabled = True
        GroupControl1.Enabled = True
        btnClose.Enabled = False
        btnNew.Enabled = False
        deBoDate.Focus()
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
        deBoDate.EditValue = DateAndTime.Today
        txtItem.Text = ""
        txtStckId.Text = ""
        ceQty.Value = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class