Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Public Class frmPO
    Dim mgrpohdrtmp As pohdrtmpManager
    Dim mgrpodettmp As podettmpManager
    'Dim mgrdrheader As pohdrtmpManager
    Dim mgrseven As stocksManager
    Dim Totss As Decimal = 0
    Private mOrderId As Integer = 0
    Private mdrId As Integer = 0
    Private WithEvents TranDr As PDSATransaction
    Private Sub frmPO_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'AddHandler ComboBoxEdit1.SelectedIndexChanged, AddressOf comboBoxEdit1_SelectedIndexChanged
        ' Add available skin names to the combo box.
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            ComboBoxEdit1.Properties.Items.Add(cnt.SkinName)
        Next cnt
        Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
        Dim skinName As String = comboBox.Text
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName
    End Sub

    Private Sub frmPO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim vRows As Integer = drgrid.Rows.Count
        If vRows > 0 Then
            MessageBox.Show("Purchase Order List Exist. Please Save/Post or Click New before closing the PO Entry Form.")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        dedlvrydate.EditValue = Date.Today
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'Dim btn As New DataGridViewButtonColumn()
        'drgrid.Columns.Add(btn)
        'btn.HeaderText = "Remove"
        'btn.Text = "Remove"
        'btn.Name = "Remove"
        'btn.UseColumnTextForButtonValue = True
        LoadSupplier()
        btnNew.Focus()
        'load_items()
        Me.Cursor = Cursors.Default
    End Sub

    Sub load_supplier()
        Dim mgrsup As suppliersManager
        Dim cols As suppliersCollection
        Try
            mgrsup = New suppliersManager()
            mgrsup.DataObject.SelectFilter = suppliersData.SelectFilters.ListBox
            mgrsup.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier

            mgrsup.DataObject.Load()
            cols = mgrsup.BuildCollection()
            'GridLookUpEdit1.Properties.PopupFormWidth = 720
            'GridLookUpEdit1.Properties.DisplayMember = "supplier"
            'GridLookUpEdit1.Properties.ValueMember = "supcode"
            'GridLookUpEdit1.Properties.DataSource = cols

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If ceQty.Value <= 0 Then
            MessageBox.Show("Qty Delivered cannot be equal or less than zero")
            Exit Sub
        Else
            Call SendItemtoGrid()
            btnItemSearch.Focus()
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Enablectrl()
        drgrid.Rows.Clear()
        dedlvrydate.EditValue = Date.Today
        ceQty.Value = 0
        ceCost.Value = 0
        txtStckid.Text = String.Empty
        txtSupcode.Text = String.Empty
        dedlvrydate.Focus()
    End Sub

    Sub SendItemtoGrid()

        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1
        Dim nProdIDD As Integer = 0
        Dim Amount3 As Decimal = 0
        If ceQty.Value > 0 Then
            Amount3 = CDec(ceQty.Value * ceCost.Value)
        Else
            Amount3 = 0
        End If

        Try
            nProdIDD = CInt(txtStckid.Text)
            For I = 0 To drgrid.Rows.Count - 1
                If nProdIDD = CInt(drgrid.Rows(I).Cells(0).Value) Then
                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next

            ' if item is not found, add it


            If ItemLoc = -1 Then
                drgrid.Rows.Add(mgrseven.DataObject.Entity.stckid, mgrseven.DataObject.Entity.itemdesc, ceQty.Value, mgrseven.DataObject.Entity.cost, Amount3)
            Else

                ' if item is already there increase its count
                Dim ItemCount As Integer = CInt(drgrid.Rows(ItemLoc).Cells(2).Value)
                ItemCount += CInt(ceQty.Value)
                Dim NewPrice As Decimal = mgrseven.DataObject.Entity.cost * ItemCount
                drgrid.Rows(ItemLoc).Cells(2).Value = ItemCount
                drgrid.Rows(ItemLoc).Cells(4).Value = NewPrice

            End If
            Dim Totsss As Decimal = 0

            For I = 0 To drgrid.Rows.Count - 1
                Totsss += CDec(drgrid.Rows(I).Cells(4).Value)
            Next
            'Select the last row.
            Me.drgrid.Rows(Me.drgrid.RowCount - 1).Selected = True
            'Scroll to the last row.
            Me.drgrid.FirstDisplayedScrollingRowIndex = Me.drgrid.RowCount - 1

            txtsum.Text = FormatNumber(CStr(Totsss))
            ceQty.Value = 1
            txtItem.Text = String.Empty
            ceCost.Value = 0
            txtStckid.Text = String.Empty

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    'Private Sub btnSupSearch_Click(sender As Object, e As EventArgs) Handles btnSupSearch.Click
    '    Dim frmSupsearch As New frmSupplierSearch
    '    frmSupsearch.ShowDialog()
    '    Try
    '        txtSupplier.Text = String.Empty
    '        txtSupplier.Text = frmSupsearch.vSupplier.ToString()
    '        txtSupcode.Text = frmSupsearch.vSupCode.ToString()
    '        If txtSupcode.Text = String.Empty Then
    '            MessageBox.Show("Please Select a supplier!")
    '            Exit Sub
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try

    'End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim frmitemserch As New frmItemSearch
        frmitemserch.ShowDialog()
        txtItem.Text = String.Empty
        txtStckid.Text = String.Empty
        txtItem.Text = frmitemserch.vItem.ToString
        txtStckid.Text = frmitemserch.vStckid.ToString
        If txtStckid.Text = String.Empty Then
            Exit Sub
        Else
            ItemsearchExecute()
        End If

    End Sub

    Private Sub ItemsearchExecute()
        Dim col1 As stocksCollection
        Dim nStckid As Integer = 0
        Try
            mgrseven = New stocksManager()
            mgrseven.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
            mgrseven.DataObject.Entity.stckid = CInt(txtStckid.Text)

            col1 = mgrseven.BuildCollection()

            If mgrseven.DataObject.RowsAffected > 0 Then

                nStckid = mgrseven.DataObject.Entity.stckid
                ceCost.Value = mgrseven.DataObject.Entity.cost

                ceQty.Focus()
                'SendItemtoGrid()

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        If ceQty.Value < 0 Then
            MessageBox.Show("Qty Delivered cannot be equal or less than zero")

        End If
    End Sub
    Private Sub drgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellClick

        If e.ColumnIndex = -1 Then
            Dim ansint As Integer = 7
            ansint = MsgBox("Are you sure you want Delete the selected Row?", MsgBoxStyle.YesNo, "Delete Row Confirmation")
            If ansint = 6 Then
                Dim ii As Integer
                Try
                    drgrid.Rows.Remove(drgrid.SelectedRows(0))
                    For ii = 0 To drgrid.Rows.Count - 1
                        Totss += CDec(drgrid.Rows(ii).Cells(4).Value)
                    Next

                    txtsum.Text = FormatNumber(CStr(Totss))

                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If
    End Sub
    Private Sub Tran_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.AfterSubmit
        If e.ClassName = "pohdrtmpData" Then
            mOrderId = DirectCast(e.DataClassTable.EntityObject, pohdrtmp).poidtmp
        End If
    End Sub

    Private Sub Tran_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "podettmpData" Then
            DirectCast(e.DataClassTable.EntityObject, podettmp).poidtmp = mOrderId
        End If
    End Sub
   
    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        If drgrid.Rows.Count > 0 Then
            MessageBox.Show("There is a Pending PO Entry. Pelase save or delete it first!")
            Exit Sub
        End If
        Dim mgrRetrieve As vwPoSavedManager 'vwSuspendDlvryManager
        Dim col5 As vwPoSavedCollection 'vwSuspendDlvryCollection

        Try
            mgrRetrieve = New vwPoSavedManager() 'vwSuspendDlvryManager()
            mgrRetrieve.DataObject.WhereFilter = vwPoSavedData.WhereFilters.sInsert_id 'vwSuspendDlvryData.WhereFilters.employee
            mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID

            col5 = mgrRetrieve.BuildCollection()
            If mgrRetrieve.DataObject.RowsAffected > 0 Then
                DGRetrieve.Visible = True
                DGRetrieve.Focus()
                DGRetrieve.DataSource = col5

            Else
                MessageBox.Show("N o   S u s p e n d e d   Purchase Order   t o   D i s p l a y")
                DGRetrieve.Visible = False
                leSupplier.Focus()

            End If


        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub DGRetrieve_KeyDown(sender As Object, e As KeyEventArgs) Handles DGRetrieve.KeyDown
        Dim ii As Integer
        If e.KeyCode = Keys.Enter Then
            'If DGRetrieve.Rows.Count <= 0 Then
            '    Exit Sub
            'End If
            Dim vCellVal As Integer = 0
            Dim row As Integer = DGRetrieve.CurrentCellAddress.Y
            Dim column As Integer = DGRetrieve.CurrentCellAddress.X
            Dim col4 As vwPOSuspendedCollection 'vwDlvrySuspendedCollection

            If column > 1 Then
                MessageBox.Show("Please select the suspended PO on the first column or select the second column to Cancel Retrieval of Suspended PO")
                Exit Sub
            End If

            If column = 0 Then ' this is the main code to be executed

                vCellVal = CInt(DGRetrieve.CurrentCell.Value)
                Dim mgrRetrivDr As vwPOSuspendedManager 'vwDlvrySuspendedManager
                Dim mgrdrTmp As pohdrtmpManager 'dlvryhdrtmpManager

                Try
                    mgrRetrivDr = New vwPOSuspendedManager 'vwDlvrySuspendedManager()
                    mgrRetrivDr.DataObject.WhereFilter = vwPOSuspendedData.WhereFilters.poid 'vwDlvrySuspendedData.WhereFilters.DrKey
                    mgrRetrivDr.Entity.poidtmp = vCellVal

                    col4 = mgrRetrivDr.BuildCollection()
                    If mgrRetrivDr.DataObject.RowsAffected > 0 Then
                        For ii = 0 To mgrRetrivDr.DataObject.GetDataTable.Rows.Count - 1
                            drgrid.Rows.Add(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("qty")), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("cost"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("podetamnt"))
                            'txtSupcode.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supcode"))
                            'txtSupplier.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supplier"))
                            dedlvrydate.EditValue = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("podate"))
                        Next
                        Dim Tots22 As Decimal = 0
                        Dim iii As Integer
                        For iii = 0 To drgrid.Rows.Count - 1
                            Tots22 += CDec(drgrid.Rows(iii).Cells(4).Value)
                        Next
                        txtsum.Text = FormatNumber(CStr(Tots22))
                        DGRetrieve.Visible = False
                    End If

                    'delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
                    mgrdrTmp = New pohdrtmpManager  'dlvryhdrtmpManager()
                    mgrdrTmp.DataObject.DeleteByPK(vCellVal)


                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If
            leSupplier.Focus()

            If column = 1 Then
                DGRetrieve.Visible = False
            End If

        End If
    End Sub

    Private Sub drgrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellEndEdit
        Dim roww As Integer = DGRetrieve.CurrentCellAddress.Y
        Dim varrowindex As Integer = 0
        Dim vqty As Integer = 0
        Dim vamnt As Decimal = 0
        varrowindex = drgrid.SelectedCells(0).RowIndex
        vqty = CInt(drgrid.Rows(varrowindex).Cells(2).Value)
        vamnt = CDec(drgrid.Rows(varrowindex).Cells(4).Value)

        'Dim rowww As Integer = CInt(DGRetrieve.CurrentRow.Selected())
        drgrid.Rows(varrowindex).Cells(4).Value = vqty * vamnt
        Dim I As Integer = 0
        Totss = 0
        For I = 0 To drgrid.Rows.Count - 1
            Totss += CDec(drgrid.Rows(I).Cells(4).Value)
        Next
        txtsum.Text = FormatNumber(Totss, 2)
    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure All information entered are correct(Supplier,Items Ordered,Date Ordered etc.) before clicking yes to save!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If

        If drgrid.Rows.Count <= 0 Then
            MessageBox.Show("Item list is empty!")
            btnItemSearch.Focus()
            Exit Sub
        End If
        If leSupplier.Text = String.Empty Then
            MessageBox.Show("Please select a supplier before saving.")
            leSupplier.Focus()
            Exit Sub
        End If

        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranDr = New PDSATransaction()
        mgrpohdrtmp = New pohdrtmpManager  'dlvry_hdrManager()
        mgrpohdrtmp.DataObject.TransactionType = PDSATransactionType.Insert
        Try

            mgrpohdrtmp.Entity.podate = CDate(dedlvrydate.Text)
            mgrpohdrtmp.Entity.dtInsertdt = Date.Now
            mgrpohdrtmp.Entity.dtLastUpdatedt = Date.Now
            mgrpohdrtmp.Entity.dlivered = True
            mgrpohdrtmp.Entity.drpsted = True
            mgrpohdrtmp.Entity.poamnt = CDec(txtsum.Text) 'vGrandTotal
            mgrpohdrtmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrpohdrtmp.Entity.supcode = CInt(txtSupcode.Text)
            TranDr.Add(mgrpohdrtmp.DataObject)


            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrpodettmp = New podettmpManager()
                mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Insert
                mgrpodettmp.Entity.poidtmp = mOrderId 'mdrId
                mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrpodettmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                    mgrpodettmp.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                Else
                    mgrpodettmp.Entity.qty = 0
                End If
                mgrpodettmp.Entity.cost = CDec(drgrid.Rows(iii).Cells(4).Value)
                mgrpodettmp.Entity.podetamnt = CDec(drgrid.Rows(iii).Cells(4).Value)
                TranDr.Add(mgrpodettmp.DataObject)
            Next
            TranDr.Execute()

            'Dim TranDrSp As New PDSATransaction()
            'Dim mgrspDrTrans As New spDlvryProcManager()

            'mgrspDrTrans.Entity.drdrid = mdrId
            'mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
            'TranDrSp.Add(mgrspDrTrans.DataObject)
            'TranDrSp.Execute()
            MessageBox.Show("PO Transaction Successfully Saved.")
            'btnPost.Enabled = False
            Call Disablectrl()

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure you selected the correct supplier and entered the correct items and totals before clicking yes!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If
        'Check Before Saving
        If drgrid.Rows.Count <= 0 Then
            MessageBox.Show("Item list is empty!")
            Exit Sub
        End If
        'If txtSupcode.Text = String.Empty Then
        'MessageBox.Show("Please select a supplier before saving.")
        'Exit Sub
        'End If

        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranDr = New PDSATransaction()

        Try
            mgrpohdrtmp = New pohdrtmpManager()
            mgrpohdrtmp.Entity.podate = CDate(dedlvrydate.Text)
            mgrpohdrtmp.Entity.dtInsertdt = Date.Now
            mgrpohdrtmp.Entity.dtLastUpdatedt = Date.Now
            mgrpohdrtmp.Entity.dlivered = False
            mgrpohdrtmp.Entity.drpsted = False
            mgrpohdrtmp.Entity.poamnt = CDec(txtsum.Text) 'vGrandTotal
            mgrpohdrtmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrpohdrtmp.Entity.supcode = CInt(leSupplier.EditValue) 'CInt(txtSupcode.Text)
            TranDr.Add(mgrpohdrtmp.DataObject)

            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrpodettmp = New podettmpManager()  'dlvry_detManager()
                mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Insert
                mgrpodettmp.Entity.poidtmp = mOrderId 'mdrId
                mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrpodettmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                    mgrpodettmp.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                Else
                    mgrpodettmp.Entity.qty = 0
                End If
                mgrpodettmp.Entity.cost = CDec(drgrid.Rows(iii).Cells(4).Value)
                mgrpodettmp.Entity.podetamnt = CDec(drgrid.Rows(iii).Cells(4).Value)
                TranDr.Add(mgrpodettmp.DataObject)
            Next
            TranDr.Execute()
            MessageBox.Show("PO successfuly saved.")
            'btnSave.Enabled = False
            Call Disablectrl()

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub Disablectrl()
        GroupControl1.Enabled = False
        dedlvrydate.Enabled = False
        btnItemSearch.Enabled = False
        ceQty.Enabled = False
        ceCost.Enabled = False
        btnAdd.Enabled = False
        drgrid.Enabled = False
        btnPost.Enabled = False
        btnRetrieve.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
    End Sub

    Private Sub Enablectrl()
        GroupControl1.Enabled = True
        dedlvrydate.Enabled = True
        btnItemSearch.Enabled = True
        ceQty.Enabled = True
        ceCost.Enabled = True
        btnAdd.Enabled = True
        drgrid.Enabled = True
        btnPost.Enabled = True
        btnRetrieve.Enabled = True
        btnSave.Enabled = True
        btnNew.Enabled = False
    End Sub

    Private Sub LoadSupplier()
        Dim mgrs As suppliersManager = New suppliersManager()
        mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier
        Dim cols As suppliersCollection
        cols = mgrs.BuildCollection()
        leSupplier.Properties.DisplayMember = "supplier"
        leSupplier.Properties.ValueMember = "supcode"
        leSupplier.Properties.DataSource = cols
    End Sub

  
End Class



