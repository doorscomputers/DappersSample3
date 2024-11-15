Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Public Class frmBarcodes
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
            txtBarcode.Focus()
        End If
        txtBarcode.Focus()
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
        If txtBarcode.Text = String.Empty Then
            MessageBox.Show("New Barcode is Empty. Enter a New Barcode")
            txtBarcode.Focus()
            Exit Sub
        End If

        If deBoDate.Text = String.Empty Then
            MessageBox.Show("Please enter the date the item was counted.")
            deBoDate.Focus()
            Exit Sub
        End If

        Dim tranBarcode As PDSATransaction = New PDSATransaction()
        Dim mgrBarcode As tblBarcodesManager = New tblBarcodesManager()
        Try
            mgrBarcode.DataObject.TransactionType = PDSATransactionType.Insert
            mgrBarcode.DataObject.Entity.barcode = txtBarcode.Text
            mgrBarcode.DataObject.Entity.dateadded = CDate(deBoDate.Text)
            mgrBarcode.DataObject.Entity.stckid = CInt(Trim(txtStckId.Text))
            tranBarcode.Add(mgrBarcode.DataObject)
            tranBarcode.Execute()

            DisableControls()
            MessageBox.Show("New Barcode Successfully Saved", "Saved")
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

    Private Sub ceQty_KeyPress(sender As Object, e As KeyPressEventArgs)
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
        txtStckId.Text = String.Empty
        txtBarcode.Text = String.Empty
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class