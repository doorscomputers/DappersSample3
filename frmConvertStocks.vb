Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Public Class frmConvertStocks
    Private WithEvents TranBo As PDSATransaction
    Dim mgr8 As stocksManager
    Dim mOrderId As Integer = 0
    Dim Tran2 As PDSATransaction
    Dim Tran3 As PDSATransaction
    Private Sub frmConvertStocks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmConvertStocks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnSave.Enabled = True Then
            e.Cancel = True
            MessageBox.Show("Save or Cancel the Conversion of Items First Before Closing the Form.")
        End If
    End Sub

    Private Sub frmConvertStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim frmitemserch As New frmItemSearch
        frmitemserch.ShowDialog()
        txtItem.Text = String.Empty
        txtStckId.Text = String.Empty
        txtItem.Text = frmitemserch.vItem.ToString
        txtStckId.Text = frmitemserch.vStckid.ToString
        ceInner.Value = frmitemserch.vInnerQty
        ceAvlbl.Value = frmitemserch.vAvlbl

        If txtStckId.Text = String.Empty Then
            Exit Sub
        Else
            ItemsearchExecute()
        End If
        btnItemsearch2.Focus()
    End Sub

    Private Sub ItemsearchExecute()
        Dim col2 As stocksCollection
        Dim nStckid As Integer = 0
        Try
            mgr8 = New stocksManager()
            mgr8.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            mgr8.DataObject.Entity.stckid = CInt(txtStckId.Text)
            col2 = mgr8.BuildCollection()
            If mgr8.DataObject.RowsAffected > 0 Then
                nStckid = mgr8.DataObject.Entity.stckid
                'txtPrice.Text = FormatNumber(CStr(mgr8.DataObject.Entity.cost), 2)
                ceQty.Focus()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cePcs.Value <= 1 Then
            MessageBox.Show("Cannot convert quantity")
            Exit Sub
        End If
        If ceQty.Value > ceAvlbl.Value Then
            MessageBox.Show("Quantity to be converted must not be greater than the available stock.")
            Exit Sub
        End If
        If txtItem.Text = String.Empty Then
            MessageBox.Show("Please select an item to be converted.")
            txtItem.Focus()
            Exit Sub
        End If

        If ceQty.Value <= 0 Then
            MessageBox.Show("Please enter the number of items to be converted.")
            ceQty.Focus()
            Exit Sub
        End If

        If deBoDate.Text = String.Empty Then
            MessageBox.Show("Please enter the date the item was converted.")
            deBoDate.Focus()
            Exit Sub
        End If

        If ceInner.Value < 2 Then
            MessageBox.Show("The Item Innerbox Qty is not valid and should be at least 2.")
            ceInner.Focus()
            Exit Sub
        End If


        TranBo = New PDSATransaction() ' did not change but the transaction is about converting items to pieces
        Tran2 = New PDSATransaction()
        Tran3 = New PDSATransaction()
        Dim mgrbo As convertstckManager = New convertstckManager() ' mgrbo is just a variable but it is pertaining to the convertstck table

        Try
            mgrbo.DataObject.TransactionType = PDSATransactionType.Insert
            mgrbo.DataObject.Entity.innerqty = CInt(ceInner.Value)
            mgrbo.DataObject.Entity.condate = CDate(deBoDate.Text)
            mgrbo.DataObject.Entity.fromstckid = CInt(txtStckId.Text)
            mgrbo.DataObject.Entity.tostckid = CInt(txtstckid2.Text)
            mgrbo.DataObject.Entity.fromqty = CInt(ceQty.Value)
            mgrbo.DataObject.Entity.InsertedBy = PDSAAppConfig.CurrentLoginID
            mgrbo.DataObject.Entity.ModifiedBy = PDSAAppConfig.CurrentLoginID
            mgrbo.DataObject.Entity.InsertedOn = DateTime.Now
            mgrbo.DataObject.Entity.toqty = CInt(cePcs.Value)
            TranBo.Add(mgrbo.DataObject)
            TranBo.Execute()

            Dim mgrspBo As spConvertFirstManager = New spConvertFirstManager()
            mgrspBo.Entity.StckIid = CInt(txtStckId.Text)
            mgrspBo.Entity.Convertid = mOrderId
            Tran2.Add(mgrspBo.DataObject)
            'TranBo.Add(mgrspBo.DataObject)

            Dim mgrspconsec As spConvertsecondManager = New spConvertsecondManager()
            mgrspconsec.Entity.StckIid = CInt(txtstckid2.Text)
            mgrspconsec.Entity.Convertid = mOrderId
            Tran2.Add(mgrspconsec.DataObject)
            'TranBo.Add(mgrspconsec.DataObject)

            Tran2.Execute()
            'TranBo.Execute()
            DisableControls()
            MessageBox.Show("Conversion Entry Successfully Saved", "Saved")
            InitControls()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

    End Sub
    Private Sub TranBo_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranBo.AfterSubmit
        ' Get the SQL Identity generated and store into local variable
        If e.ClassName = "convertstckData" Then
            mOrderId = DirectCast(e.DataClassTable.EntityObject, convertstck).convertid
        End If
    End Sub

    Private Sub Tran_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranBo.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "convertstckData" Then
            DirectCast(e.DataClassTable.EntityObject, convertstck).convertid = mOrderId
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
        txtitem2.Text = ""
        txtStckId.Text = ""
        txtstckid2.Text = ""
        ceQty.Value = 0
        cePcs.Value = 0
        ceAvlbl.Value = 0

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
            If ceInner.Value >= 2 Then
                cePcs.Value = CInt(ceInner.Value * ceQty.Value)
                btnSave.Focus()
            Else
                MessageBox.Show("Quantity must be at least greater than or equal to 2.Make sure the item to be converted is not a PC item")
            End If

        End If
    End Sub

    Private Sub btnItemsearch2_Click(sender As Object, e As EventArgs) Handles btnItemsearch2.Click
        Dim frmitemserch2 As New frmItemSearch
        frmitemserch2.ShowDialog()
        txtitem2.Text = String.Empty
        txtstckid2.Text = String.Empty
        txtitem2.Text = frmitemserch2.vItem.ToString
        txtstckid2.Text = frmitemserch2.vStckid.ToString
        If txtstckid2.Text = String.Empty Then
            Exit Sub
        Else
            ItemsearchExecute()
        End If
        ceQty.Focus()
    End Sub

    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        

    End Sub
End Class