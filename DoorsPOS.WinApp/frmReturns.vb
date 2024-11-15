Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Public Class frmReturns

    Dim mgr8 As stocksManager
    Private Sub frmReturns_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmReturns_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnSave.Enabled = True Then
            e.Cancel = True
            MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.")
        End If
    End Sub

    Private Sub frmReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        LoadMember()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadMember()
        Dim mgrs As membersManager = New membersManager()
        mgrs.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
        Dim cols As membersCollection
        cols = mgrs.BuildCollection()
        leSupplier.Properties.DisplayMember = "lastname"
        leSupplier.Properties.ValueMember = "CustID"
        leSupplier.Properties.DataSource = cols
    End Sub

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
            ItemsearchExecute()
        End If

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
                txtPrice.Text = FormatNumber(CStr(mgr8.DataObject.Entity.cost), 2)
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
        If txtItem.Text = String.Empty Then
            MessageBox.Show("Please select an item to be returned.")
            txtItem.Focus()
            Exit Sub
        End If

        If ceQty.Value <= 0 Then
            MessageBox.Show("Please enter the number of items to be returned.")
            ceQty.Focus()
            Exit Sub
        End If

        If deBoDate.Text = String.Empty Then
            MessageBox.Show("Please enter the date the item was returned.")
            deBoDate.Focus()
            Exit Sub
        End If

        If leSupplier.Text = String.Empty Then
            MessageBox.Show("Please select the supplier of the item to be returned.")
            leSupplier.Focus()
            Exit Sub
        End If


        Dim TranBo As PDSATransaction = New PDSATransaction()
        Dim mgrbo As boManager = New boManager()

        Try
            mgrbo.DataObject.TransactionType = PDSATransactionType.Insert
            mgrbo.DataObject.Entity.amnt = 0
            mgrbo.DataObject.Entity.bodate = CDate(deBoDate.Text)
            mgrbo.DataObject.Entity.prevavlbl = 0
            mgrbo.DataObject.Entity.price = 0
            mgrbo.DataObject.Entity.qty = CInt(ceQty.Value)
            mgrbo.DataObject.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrbo.DataObject.Entity.sLastUpdateid = PDSAAppConfig.CurrentLoginID
            mgrbo.DataObject.Entity.stckid = CInt(Trim(txtStckId.Text))
            mgrbo.DataObject.Entity.supcode = CInt(leSupplier.EditValue)
            TranBo.Add(mgrbo.DataObject)

            Dim mgrspBo As spBackOrderManager = New spBackOrderManager()
            mgrspBo.Entity.StckIid = CInt(txtStckId.Text)
            TranBo.Add(mgrspBo.DataObject)

            TranBo.Execute()
            DisableControls()
            MessageBox.Show("Back Order Entry Successfully Saved", "Saved")
            InitControls()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

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
        txtPrice.Text = ""
        ceQty.Value = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableControls()
        InitControls()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableControls()
        InitControls()
    End Sub

    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        btnSave.Focus()
    End Sub
End Class
