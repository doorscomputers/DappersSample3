Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors


Public Class frmDelivery
    Dim mgrhdrtmp As dlvryhdrtmpManager
    Dim drd As dlvrydettmpManager
    Dim mgrdrheader As dlvry_hdrManager
    Dim mgrdrdetail As dlvry_detManager
    Dim mgr7 As stocksManager
    Dim Totss As Decimal = 0
    Dim vGrandTotal As Decimal = 0
    Private mOrderId As Integer = 0
    Private mdrId As Integer = 0
    Private WithEvents TranHdrtmp As PDSATransaction
    Private WithEvents TranDr As PDSATransaction
    Public Shared strItemvar As String = String.Empty
    Dim nStckid As Integer = 0
    Dim nProdID As Integer = 0

    Public vItem As String = String.Empty
    Public vStckid As Integer = 0
    Public vPrice As Decimal = 0
    Public vWPrice As Decimal = 0
    Public vbocde As String = String.Empty
    Private Sub frmDelivery_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub LoadSupplier()
        Try
            Dim mgrs As suppliersManager = New suppliersManager()
            mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier
            Dim cols As suppliersCollection
            cols = mgrs.BuildCollection()
            leSupplier.Properties.DisplayMember = "supplier"
            leSupplier.Properties.ValueMember = "supcode"
            leSupplier.Properties.DataSource = cols
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

    End Sub
    Private Sub frmDelivery_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Dim vRows As Integer = drgrid.Rows.Count
        'If vRows > 0 Then ' If vRows > 0 Then
        '    MessageBox.Show("Delivery List Exist. Please Save/Post or Click New before closing the Delivery Entry Form.")
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        dedlvrydate.EditValue = Date.Today
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'Dim btn As New DataGridViewButtonColumn()
        'drgrid.Columns.Add(btn)
        'btn.HeaderText = "Remove"
        'btn.Text = "Remove"
        'btn.Name = "Remove"
        'btn.UseColumnTextForButtonValue = True

        LoadSupplier()
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

    Private Sub ComputeDue()
        If cmbType.Text = "COD" Or cmbType.Text = "I.S." Then
            deDue.EditValue = CDate(dedlvrydate.EditValue)
        Else
            If ceDays.Value > 0 Then
                deDue.EditValue = DateAdd(DateInterval.Day, ceDays.Value, CDate(dedlvrydate.EditValue))
            End If
        End If
    End Sub

    Private Sub ceDays_LostFocus(sender As Object, e As EventArgs) Handles ceDays.LostFocus
        ComputeDue()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If ceCost.Value = 0 Then
        '    MessageBox.Show("Item Cost Must be Greater than zero")
        '    Exit Sub
        'End If

        'If ceQty.Value <= 0 And ceFree.Value <= 0 Then
        '    MessageBox.Show("Qty Delivered cannot be equal or less than zero")
        '    Exit Sub
        'Else
        '    Call SendItemtoGrid()
        '    btnItemSearch.Focus()
        'End If

        Call AddTwoList()
    End Sub
    Private Sub AddTwoList()
        If ceCost.Value = 0 Then
            MessageBox.Show("Item Cost Must be Greater than zero")
            Exit Sub
        End If

        If ceQty.Value <= 0 And ceFree.Value <= 0 Then
            MessageBox.Show("Qty Delivered cannot be equal or less than zero")
            Exit Sub
        Else
            Call SendItemtoGrid()
            'btnItemSearch.Focus()
            txtItem.Focus()
        End If
        'btnItemSearch.Focus()
        txtItem.Focus()
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Enablectrl()
        drgrid.Rows.Clear()
        dedlvrydate.EditValue = Date.Today
        txtInv.Text = String.Empty
        ceDays.Value = 0
        deDue.EditValue = Date.Today
        ceQty.Value = 0
        ceFree.Value = 0
        ceCost.Value = 0
        cediscamnt.Value = 0
        txtStckid.Text = String.Empty
        txtSupcode.Text = String.Empty
        txtsum.Text = "0"
        cediscamnt.Value = 0
        txtGrand.Text = "0"
        dedlvrydate.Focus()

    End Sub

    Sub SendItemtoGrid()

        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1
        Dim nProdIDD As Integer = 0
        Dim Amount3 As Decimal = 0

        Try
            If ceQty.Value > 0 Then
                Amount3 = CDec(ceQty.Value * ceCost.Value)
                If ceAmountDisc.Value > 0 Then
                    Amount3 -= CDec(ceAmountDisc.Value)
                End If
            Else
                Amount3 = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        

        Try
            nProdIDD = CInt(txtStckid.Text)
            For I = 0 To drgrid.Rows.Count - 1
                MessageBox.Show(CStr(drgrid.Rows(I).Cells(0).Value))

                If nProdIDD = CInt(drgrid.Rows(I).Cells(0).Value) Then
                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next

            ' if item is not found, add it


            If ItemLoc = -1 Then
                'drgrid.Rows.Add(mgr7.DataObject.Entity.stckid, mgr7.DataObject.Entity.itemdesc, ceQty.Value, ceFree.Value, mgr7.DataObject.Entity.cost, Amount3, deExpDate.EditValue, txtLotNo.Text, cePrcentDisc.Value, cediscamnt.Value)
                drgrid.Rows.Add(nProdIDD, vItem, ceQty.Value, ceFree.Value, ceCost.Value, Amount3, deExpDate.EditValue, txtLotNo.Text, cePrcentDisc.Value, cediscamnt.Value)

            Else

                ' if item is already there increase its count
                Dim ItemCount As Integer = CInt(drgrid.Rows(ItemLoc).Cells(2).Value)
                ItemCount += CInt(ceQty.Value)
                Dim NewPrice As Decimal = mgr7.DataObject.Entity.cost * ItemCount
                drgrid.Rows(ItemLoc).Cells(2).Value = ItemCount
                drgrid.Rows(ItemLoc).Cells(5).Value = NewPrice

            End If
            Dim Totsss As Decimal = 0

            For I = 0 To drgrid.Rows.Count - 1
                Totsss += CDec(drgrid.Rows(I).Cells(5).Value)
            Next
            'Select the last row.
            Me.drgrid.Rows(Me.drgrid.RowCount - 1).Selected = True
            'Scroll to the last row.
            Me.drgrid.FirstDisplayedScrollingRowIndex = Me.drgrid.RowCount - 1



            txtsum.Text = FormatNumber(CStr(Totsss))
            txtGrand.Text = FormatNumber(CStr(Totsss))
            ceQty.Value = 1
            ceFree.Value = 0
            txtItem.Text = String.Empty
            ceCost.Value = 0
            txtStckid.Text = String.Empty
            txtLotNo.Text = String.Empty
            deExpDate.Text = String.Empty
            cePrcentDisc.Value = 0
            cediscamnt.Value = 0
            ceAmountDisc.Value = 0
            strItemvar = ""
            vItem = ""
            vbocde = ""
            txtItem.Focus()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnSupSearch_Click(sender As Object, e As EventArgs) Handles btnSupSearch.Click
        Dim frmSupsearch As New frmSupplierSearch
        frmSupsearch.ShowDialog()
        Try
            txtSupplier.Text = String.Empty
            txtSupplier.Text = frmSupsearch.vSupplier.ToString()
            txtSupcode.Text = frmSupsearch.vSupCode.ToString()
            If txtSupcode.Text = String.Empty Then
                MessageBox.Show("Please Select a supplier!")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        txtInv.Focus()
    End Sub

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
    Sub DgitemsKeydown()
        If dgitems.Rows.Count < 1 Then
            Exit Sub
        End If
        Try
            Dim vRow As Integer = 0
            Dim vint As Integer = 0
            Dim x1 As String = String.Empty
            Dim x2 As String = String.Empty
            Dim x3 As Integer = 0
            Dim x4 As Decimal = 0
            Dim x5 As Integer = 0
            Dim x6 As String = String.Empty
            vRow = dgitems.CurrentRow.Index
            vint = CInt(dgitems(0, vRow).Value)
            x1 = CStr(dgitems(1, vRow).Value)
            x2 = CStr(dgitems(2, vRow).Value)
            x3 = CInt(dgitems(3, vRow).Value)
            x4 = CDec(dgitems(4, vRow).Value)

            vStckid = vint
            vItem = x2
            vbocde = x1
            vPrice = x3
            vWPrice = x4

            txtStckid.Text = String.Empty
            txtItem.Text = vItem.ToString
            txtStckid.Text = vStckid.ToString
            ItemsearchExecute()

            dgitems.Visible = False
            'ceQtyy.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub ItemsearchExecute()
        Dim col1 As stocksCollection
        nStckid = 0
        nProdID = 0
        Try
            mgr7 = New stocksManager()
            mgr7.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            mgr7.DataObject.Entity.stckid = CInt(txtStckid.Text)
            col1 = mgr7.BuildCollection()
            If mgr7.DataObject.RowsAffected > 0 Then
                nStckid = mgr7.DataObject.Entity.stckid
                ceCost.Value = mgr7.DataObject.Entity.cost
                vItem = mgr7.DataObject.Entity.itemdesc
                ceQty.Focus()
                ceQty.SelectAll()
            End If
            If dgitems.Visible = True Then
                dgitems.Visible = False
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        If ceQty.Value < 0 Or ceFree.Value < 0 Then
            MessageBox.Show("Qty Delivered cannot be equal or less than zero")
        End If
    End Sub
    Private Sub ceFree_LostFocus(sender As Object, e As EventArgs) Handles ceFree.LostFocus
        If ceQty.Value < 0 Or ceFree.Value < 0 Then
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

                    ' If drgrid.SelectedRows.Count = 0 Then
                    'Exit Sub
                    'End If
                    Dim vRoww As Integer = 0

                    Dim x1 As String = String.Empty
                    vRoww = drgrid.CurrentRow.Index
                    strItemvar = CStr(drgrid(1, vRoww).Value)

                    drgrid.Rows.Remove(drgrid.SelectedRows(0))
                    For ii = 0 To drgrid.Rows.Count - 1
                        Totss += CDec(drgrid.Rows(ii).Cells(5).Value)
                    Next
                    txtsum.Text = FormatNumber(CStr(Totss))
                    txtGrand.Text = FormatNumber(CStr(Totss))
                    cediscamnt.Value = 0

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

                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If


    End Sub

    Private Sub cediscamnt_EditValueChanged(sender As Object, e As EventArgs) Handles cediscamnt.EditValueChanged
        If txtsum.Text = "" Then
            Exit Sub
        End If

        Dim vSubTotals As Decimal = 0
        Dim vGrandTotals As Decimal = 0
        vSubTotals = CDec(txtsum.Text)

        If CDec(cediscamnt.Value) < 0 Then
            MessageBox.Show("Discount can't be less than or equal to zero!")
            Exit Sub
        End If
        If CDec(cediscamnt.Value) > vSubTotals Then
            MessageBox.Show("Discount can't be greater than the Total Amount!")
            Exit Sub
        End If

        vGrandTotals = vSubTotals - CDec(cediscamnt.Value)
        txtGrand.Text = FormatNumber(vGrandTotals, 2)

    End Sub

    Private Sub ceCost_DoubleClick(sender As Object, e As EventArgs) Handles ceCost.DoubleClick
        Try

            Dim mgrstk As New stocksManager()
            Dim mgrstkk As New stocksManager()
            Dim vmarkup As Decimal = 0 ' markup
            Dim vprices As Decimal = 0 ' cost of the item
            Dim vmupamnt As Decimal = 0 ' markup amount
            Dim vFinalPrice As Decimal = 0 ' Final Price
            Dim trans As New PDSATransaction()

            mgrstk.DataObject.SelectFilter = stocksData.SelectFilters.All
            mgrstk.DataObject.LoadByPK(CInt(txtStckid.Text))
            vmarkup = CDec(mgrstk.DataObject.Entity.markup)
            vprices = mgrstk.DataObject.Entity.cost
            vmupamnt = CDec(ceCost.Value) * (vmarkup / 100)
            vFinalPrice = CDec(ceCost.Value) + vmupamnt
            mgrstk.Entity.cost = CDec(ceCost.Value)
            mgrstk.Entity.retail = vFinalPrice
            mgrstk.DataObject.UpdateFilter = stocksData.UpdateFilters.PrimaryKey
            trans.Add(mgrstk.DataObject)
            'mgrstk.DataObject.Entity.stckid = CInt(txtStckid.Text)
            mgrstk.DataObject.TransactionType = PDSATransactionType.Update


         
            'mgrstk.DataObject.Update()
            'trans.Add(mgrstk.DataObject)
            'trans.Execute()
            trans.Add(mgrstk.DataObject)
            trans.Execute()
            MessageBox.Show("Retail Price updated successfully. Retail Price is now" & CStr(vFinalPrice))
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private Sub Tran_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranHdrtmp.AfterSubmit
        If e.ClassName = "dlvryhdrtmpData" Then
            mOrderId = DirectCast(e.DataClassTable.EntityObject, dlvryhdrtmp).dridtmp
        End If
    End Sub

    Private Sub Tran_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranHdrtmp.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "dlvrydettmpData" Then
            DirectCast(e.DataClassTable.EntityObject, dlvrydettmp).dridtmp = mOrderId
        End If
    End Sub
    Private Sub TranDr_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.AfterSubmit
        If e.ClassName = "dlvry_hdrData" Then
            mdrId = DirectCast(e.DataClassTable.EntityObject, dlvry_hdr).drid
        End If
    End Sub

    Private Sub TranDr_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "dlvry_detData" Then
            DirectCast(e.DataClassTable.EntityObject, dlvry_det).drid = mdrId
        End If
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        If drgrid.Rows.Count > 0 Then
            MessageBox.Show("There is a Pending Delivery Entry. Pelase save it first!")
            Exit Sub
        End If
        Dim mgrRetrieve As vwSuspendDlvryManager
        Dim col5 As vwSuspendDlvryCollection

        Try
            mgrRetrieve = New vwSuspendDlvryManager()
            mgrRetrieve.DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.employee
            mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID

            col5 = mgrRetrieve.BuildCollection()
            If mgrRetrieve.DataObject.RowsAffected > 0 Then
                DGRetrieve.Visible = True
                DGRetrieve.Focus()
                DGRetrieve.DataSource = col5

            Else
                MessageBox.Show("N o   S u s p e n d e d   Delivery   t o   D i s p l a y")
                DGRetrieve.Visible = False
                btnSupSearch.Focus()


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
            Dim col4 As vwDlvrySuspendedCollection

            If column > 1 Then
                MessageBox.Show("Please select the suspended Delivery on the first column or select the second column to Cancel Retrieval of Suspended Delivery")
                Exit Sub
            End If

            If column = 0 Then ' this is the main code to be executed

                vCellVal = CInt(DGRetrieve.CurrentCell.Value)
                Dim mgrRetrivDr As vwDlvrySuspendedManager
                Dim mgrdrTmp As dlvryhdrtmpManager

                Try
                    mgrRetrivDr = New vwDlvrySuspendedManager()
                    mgrRetrivDr.DataObject.WhereFilter = vwDlvrySuspendedData.WhereFilters.DrKey
                    mgrRetrivDr.Entity.dridtmp = vCellVal

                    col4 = mgrRetrivDr.BuildCollection()
                    If mgrRetrivDr.DataObject.RowsAffected > 0 Then
                        For ii = 0 To mgrRetrivDr.DataObject.GetDataTable.Rows.Count - 1
                            drgrid.Rows.Add(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("item_desc")), CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("qty")), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("freee"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("cost"), mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("drdetamnt"))
                            txtSupcode.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supcode"))
                            txtSupplier.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supplier"))
                            ceDays.Value = CDec(CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("terms")))
                            deDue.EditValue = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("drdue"))
                            dedlvrydate.EditValue = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("drdate"))
                            txtInv.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("drinv"))
                            leSupplier.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supplier"))
                        Next
                        Dim Tots22 As Decimal = 0
                        Dim iii As Integer
                        For iii = 0 To drgrid.Rows.Count - 1
                            Tots22 += CDec(drgrid.Rows(iii).Cells(5).Value)
                        Next
                        txtsum.Text = FormatNumber(CStr(Tots22))
                        txtGrand.Text = FormatNumber(CStr(Tots22))

                        DGRetrieve.Visible = False
                        'btnItemSearch.Focus()
                        txtItem.Focus()
                    End If

                    'delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
                    mgrdrTmp = New dlvryhdrtmpManager()
                    mgrdrTmp.DataObject.DeleteByPK(vCellVal)
                    'btnItemSearch.Focus()

                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If
            ''btnSupSearch.Focus()
            'leSupplier.Focus()
            'btnItemSearch.Focus()
            txtItem.Focus()
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
        drgrid.Rows(varrowindex).Cells(5).Value = vqty * vamnt
        Dim I As Integer = 0
        Totss = 0
        For I = 0 To drgrid.Rows.Count - 1
            Totss += CDec(drgrid.Rows(I).Cells(5).Value)
        Next
        txtsum.Text = FormatNumber(Totss, 2)
        txtGrand.Text = FormatNumber(Totss, 2)

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure All information entered are correct(invoice#,Supplier,Items,Date Delivered etc.) before clicking yes to save!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If

        If drgrid.Rows.Count <= 0 Then
            MessageBox.Show("Item list is empty!")
            btnItemSearch.Focus()
            Exit Sub
        End If
        'If txtSupcode.Text = String.Empty Then
        '    MessageBox.Show("Please select a supplier before saving.")
        '    btnSupSearch.Focus()
        '    Exit Sub
        'End If
        If leSupplier.Text = String.Empty Then
            MessageBox.Show("Please select a supplier before saving.")
            leSupplier.Focus()
            Exit Sub
        End If
        If txtInv.Text = String.Empty Then
            MessageBox.Show("Please Enter an Invoice# before saving.")
            txtInv.Focus()
            Exit Sub
        End If

        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranDr = New PDSATransaction()
        mgrdrheader = New dlvry_hdrManager()
        mgrdrheader.DataObject.TransactionType = PDSATransactionType.Insert
        Try

            mgrdrheader.Entity.drdate = CDate(dedlvrydate.Text)
            If CShort(ceDays.Value) > 0 Then
                mgrdrheader.Entity.ttype = "CREDIT"
            Else
                mgrdrheader.Entity.ttype = "COD"
            End If

            mgrdrheader.Entity.terms = CShort(ceDays.Value)
            mgrdrheader.Entity.drdue = CDate(deDue.Text)
            mgrdrheader.Entity.drdscamnt = cediscamnt.Value
            mgrdrheader.Entity.drinv = Trim(txtInv.Text)
            mgrdrheader.Entity.paid = False
            mgrdrheader.Entity.drpsted = True
            mgrdrheader.Entity.drbal = CDec(txtGrand.Text) 'vGrandTotal
            mgrdrheader.Entity.dramnt = CDec(txtsum.Text)
            mgrdrheader.Entity.drpsted = False
            mgrdrheader.Entity.drsubtot = CDec(txtsum.Text)
            mgrdrheader.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrdrheader.Entity.dtInsertdt = Date.Now
            mgrdrheader.Entity.dtLastUpdatedt = Date.Now
            mgrdrheader.Entity.supcode = CInt(leSupplier.EditValue) 'CInt(txtSupcode.Text)
            'mgrdrheader.Entity.iConcurrencyid
            TranDr.Add(mgrdrheader.DataObject)


            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrdrdetail = New dlvry_detManager()
                mgrdrdetail.DataObject.TransactionType = PDSATransactionType.Insert
                mgrdrdetail.Entity.drid = mdrId
                mgrdrdetail.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrdrdetail.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                    mgrdrdetail.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                Else
                    mgrdrdetail.Entity.qty = 0
                End If
                If CInt(drgrid.Rows(iii).Cells(3).Value) > 0 Then
                    mgrdrdetail.Entity.freee = CInt(drgrid.Rows(iii).Cells(3).Value)
                Else
                    mgrdrdetail.Entity.freee = 0
                End If
                mgrdrdetail.Entity.cost = CDec(drgrid.Rows(iii).Cells(4).Value)
                mgrdrdetail.Entity.drdetamnt = CDec(drgrid.Rows(iii).Cells(5).Value)
                mgrdrdetail.Entity.lotno = CStr(drgrid.Rows(iii).Cells(7).Value)
                If CStr(drgrid.Rows(iii).Cells(6).Value) <> String.Empty Then
                    mgrdrdetail.Entity.expdate = CDate(drgrid.Rows(iii).Cells(6).Value)
                End If
                mgrdrdetail.Entity.disc = CInt(drgrid.Rows(iii).Cells(8).Value)
                mgrdrdetail.Entity.discamnt = CDec(drgrid.Rows(iii).Cells(9).Value)
                'drd.Entity.detamnt = Convert.ToDecimal(drdgrid.Rows(iii).Cells(4).Value) * Convert.ToInt32(drdgrid.Rows(iii).Cells(5).Value)

                TranDr.Add(mgrdrdetail.DataObject)
            Next
            TranDr.Execute()

            Dim TranDrSp As New PDSATransaction()
            Dim mgrspDrTrans As New spDlvryProcManager()

            mgrspDrTrans.Entity.drdrid = mdrId
            mgrspDrTrans.Entity.supcode = CInt(leSupplier.EditValue)
            TranDrSp.Add(mgrspDrTrans.DataObject)
            TranDrSp.Execute()
            MessageBox.Show("Delivery Transaction Successfully Posted.")
            'btnPost.Enabled = False
            Call Disablectrl()

            'If MsgBox("Press Enter to Print, Press N or Click No To Cancel Printing", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then

            'End If

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

        If leSupplier.Text = String.Empty Then
            MessageBox.Show("Please select a supplier before saving.")
            leSupplier.Focus()
            Exit Sub
        End If
        'If txtSupcode.Text = String.Empty Then
        'MessageBox.Show("Please select a supplier before saving.")
        'Exit Sub
        'End If
        If txtInv.Text = String.Empty Then
            MessageBox.Show("Invoice NUmber cannot be left blank before saving.")
            Exit Sub
        End If


        Dim grdCount As Integer = 0
        Dim iii As Integer = 0

        Try

            TranHdrtmp = New PDSATransaction()
            mgrhdrtmp = New dlvryhdrtmpManager()
            'drd = New dlvrydettmpManager()
            'mgrhdrtmp.DataObject.TransactionType = PDSATransactionType.Insert
            mgrhdrtmp.Entity.drdate = CDate(dedlvrydate.Text)
            mgrhdrtmp.Entity.ttype = "COD"
            mgrhdrtmp.Entity.terms = CShort(ceDays.Value)
            mgrhdrtmp.Entity.drdue = CDate(deDue.Text)
            mgrhdrtmp.Entity.drdscamnt = cediscamnt.Value
            mgrhdrtmp.Entity.dtInsertdt = Date.Now
            mgrhdrtmp.Entity.dtLastUpdatedt = Date.Now
            mgrhdrtmp.Entity.drinv = Trim(txtInv.Text)

            mgrhdrtmp.Entity.drbal = vGrandTotal
            mgrhdrtmp.Entity.dramnt = vGrandTotal
            mgrhdrtmp.Entity.drpsted = False
            mgrhdrtmp.Entity.drsubtot = Totss
            mgrhdrtmp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrhdrtmp.Entity.supcode = CInt(leSupplier.EditValue) 'CInt(txtSupcode.Text)
            TranHdrtmp.Add(mgrhdrtmp.DataObject)


            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                drd = New dlvrydettmpManager()
                drd.DataObject.TransactionType = PDSATransactionType.Insert
                drd.Entity.dridtmp = mOrderId
                drd.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                drd.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                    drd.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                Else
                    drd.Entity.qty = 0
                End If
                If CInt(drgrid.Rows(iii).Cells(3).Value) > 0 Then
                    drd.Entity.freee = CInt(drgrid.Rows(iii).Cells(3).Value)
                Else
                    drd.Entity.freee = 0
                End If
                drd.Entity.cost = CDec(drgrid.Rows(iii).Cells(4).Value)
                drd.Entity.drdetamnt = CDec(drgrid.Rows(iii).Cells(5).Value)
                'drd.Entity.detamnt = Convert.ToDecimal(drdgrid.Rows(iii).Cells(4).Value) * Convert.ToInt32(drdgrid.Rows(iii).Cells(5).Value)

                TranHdrtmp.Add(drd.DataObject)
            Next

            TranHdrtmp.Execute()
            MessageBox.Show("Delivery successfuly saved.")
            drgrid.Rows.Clear()
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
        btnSupSearch.Enabled = False
        leSupplier.Enabled = False
        txtInv.Enabled = False
        ceDays.Enabled = False
        deDue.Enabled = False
        btnItemSearch.Enabled = False
        ceQty.Enabled = False
        ceFree.Enabled = False
        ceCost.Enabled = False
        btnAdd.Enabled = False
        drgrid.Enabled = False
        btnPost.Enabled = False
        btnRetrieve.Enabled = False
        btnSave.Enabled = False
        cediscamnt.Enabled = False
        btnNew.Enabled = True
        txtItem.Enabled = False
    End Sub

    Private Sub Enablectrl()
        GroupControl1.Enabled = True
        dedlvrydate.Enabled = True
        btnSupSearch.Enabled = True
        leSupplier.Enabled = True
        txtInv.Enabled = True
        ceDays.Enabled = True
        deDue.Enabled = True
        btnItemSearch.Enabled = True
        ceQty.Enabled = True
        ceFree.Enabled = True
        ceCost.Enabled = True
        btnAdd.Enabled = True
        drgrid.Enabled = True
        btnPost.Enabled = True
        btnRetrieve.Enabled = True
        txtItem.Enabled = True
        btnSave.Enabled = True
        cediscamnt.Enabled = True
        btnNew.Enabled = False

    End Sub

    Private Sub txtInv_LostFocus(sender As Object, e As EventArgs) Handles txtInv.LostFocus
        If txtInv.Text <> "" Then
            Dim mgrinv As vwDlvryManager = New vwDlvryManager()
            mgrinv.DataObject.SelectFilter = vwDlvryData.SelectFilters.All
            mgrinv.DataObject.WhereFilter = vwDlvryData.WhereFilters.drinv
            mgrinv.Entity.drinv = Trim(txtInv.Text)
            mgrinv.DataObject.Load()
            If mgrinv.DataObject.RowsAffected > 0 Then
                MessageBox.Show("Invoice number already exist-" & "Issued by " & mgrinv.DataObject.Entity.supplier & " On " & mgrinv.DataObject.Entity.drdate & "-Posted by " & mgrinv.DataObject.Entity.sInsertid & " - And is Paid?  " & mgrinv.DataObject.Entity.paid)
                txtInv.Text = ""
                txtInv.Focus()
            End If

        End If
    End Sub

    Private Sub dedlvrydate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dedlvrydate.KeyPress
        If e.KeyChar = Chr(13) Then
            leSupplier.Focus()
        End If
    End Sub

    Private Sub leSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles leSupplier.KeyPress
        If e.KeyChar = Chr(13) Then
            txtInv.Focus()
        End If
    End Sub

    Private Sub btnAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAdd.KeyDown
        If e.KeyCode = Keys.Left Then
            ceAmountDisc.Focus()
        End If
    End Sub

    Private Sub ceAmountDisc_KeyDown(sender As Object, e As KeyEventArgs) Handles ceAmountDisc.KeyDown
        If e.KeyCode = Keys.Left Then
            cePrcentDisc.Focus()
        End If
    End Sub

    Private Sub cePrcentDisc_KeyDown(sender As Object, e As KeyEventArgs) Handles cePrcentDisc.KeyDown

        If e.KeyCode = Keys.Left Then
            deExpDate.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            ceAmountDisc.Value = CDec((CInt(ceQty.Value) * CDec(ceCost.Value)) * (CInt(cePrcentDisc.Value) / 100))
            Call AddTwoList()
        End If

    End Sub

    Private Sub deExpDate_KeyDown(sender As Object, e As KeyEventArgs) Handles deExpDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call AddTwoList()
            Exit Sub
        End If

        If e.KeyCode = Keys.Left Then
            txtLotNo.Focus()
        End If
    End Sub

    Private Sub LabelControl13_Click(sender As Object, e As EventArgs) Handles LabelControl13.Click
        txtLotNo.Focus()
    End Sub

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs) Handles LabelControl8.Click
        ceQty.Focus()
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        dedlvrydate.Focus()
    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click
        leSupplier.Focus()
    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles LabelControl3.Click
        txtInv.Focus()
    End Sub

    Private Sub LabelControl5_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click
        ceDays.Focus()
    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click
        deDue.Focus()
    End Sub

    Private Sub LabelControl9_Click(sender As Object, e As EventArgs) Handles LabelControl9.Click
        ceCost.Focus()
    End Sub

    Private Sub LabelControl14_Click(sender As Object, e As EventArgs) Handles LabelControl14.Click
        deExpDate.Focus()
    End Sub

    Private Sub LabelControl16_Click(sender As Object, e As EventArgs) Handles LabelControl16.Click
        ceAmountDisc.Focus()
    End Sub

    Private Sub LabelControl15_Click(sender As Object, e As EventArgs) Handles LabelControl15.Click
        cePrcentDisc.Focus()
    End Sub




    Private Sub cePrcentDisc_EditValueChanged(sender As Object, e As EventArgs) Handles cePrcentDisc.EditValueChanged

    End Sub

    Private Sub ceFree_KeyDown(sender As Object, e As KeyEventArgs) Handles ceFree.KeyDown
        If e.KeyCode = Keys.Enter Then
            ceCost.Focus()
        End If
    End Sub

    Private Sub ceCost_KeyDown(sender As Object, e As KeyEventArgs) Handles ceCost.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Call AddTwoList()
        'End If
    End Sub

    Private Sub deDue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles deDue.KeyPress
        If e.KeyChar = Chr(13) Then
            'btnItemSearch.Focus()
            txtItem.Focus()
        End If
    End Sub

    Private Sub btnNewSupplier_Click(sender As Object, e As EventArgs) Handles btnNewSupplier.Click
        Dim frm As frmSuppliers
        frm = New frmSuppliers
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim frm As frmNewItems
        frm = New frmNewItems
        frm.ShowDialog()
        frm = Nothing
        btnItemSearch.Focus()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim frm As frmEditItems
        frm = New frmEditItems
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As frmItemlist2
        frm = New frmItemlist2
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        If txtItem.Text = String.Empty Then
            'MessageBox.Show("Enter an item description to seaarch.")
            'txtitem.Focus()
            dgitems.Visible = False
            Exit Sub
        Else
            nStckid = 0
            nProdID = 0
            Dim mgrloaditem As vwStocksManager
            Dim cols As vwStocksCollection

            Try

                mgrloaditem = New vwStocksManager()
                mgrloaditem.DataObject.SelectFilter = vwStocksData.SelectFilters.All
                mgrloaditem.DataObject.WhereFilter = vwStocksData.WhereFilters.likeitem
                mgrloaditem.Entity.itemdesc = Trim(txtItem.Text)
                mgrloaditem.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript
                cols = mgrloaditem.BuildCollection()
                If mgrloaditem.DataObject.RowsAffected > 0 Then
                    nProdID = mgrloaditem.Entity.stckid
                    nStckid = mgrloaditem.Entity.stckid

                    dgitems.DataSource = mgrloaditem.DataObject.GetDataTable()
                    dgitems.Visible = True
                    dgitems.Columns(0).Visible = False
                    dgitems.Columns(1).Visible = False
                    dgitems.Columns(4).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(2).Width = 500
                    dgitems.Columns(2).HeaderText = "Item Description"
                    dgitems.Columns(3).HeaderText = "Available"
                    dgitems.Columns(5).HeaderText = "Retail Price"
                    dgitems.Columns(6).HeaderText = "Whole Sale"
                    dgitems.Columns(7).HeaderText = "Packaging"
                    'dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(5).Width = 150
                    'dgitems.Columns(8).Visible = False
                    'dgitems.Columns(9).Visible = False
                    'dgitems.Columns(10).Visible = False
                    With dgitems.ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.White
                        .Font = New Font("Tahoma", 12.0F, FontStyle.Regular)
                    End With

                    With Me.dgitems
                        .RowTemplate.Height = 26
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .RowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("item_desc").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("retail").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("available").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)

                        .Columns("retail").DefaultCellStyle.Format = "c"
                        .Columns("retail2").DefaultCellStyle.Format = "c"
                        .Columns("retail").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("retail2").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("Available").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        ' ''.DefaultCellStyle.NullValue = "no entry"
                        ''.Columns("Packaging").DefaultCellStyle.Alignment = _
                        ''DataGridViewContentAlignment.MiddleRight()
                        '.DefaultCellStyle.WrapMode = DataGridViewTriState.False
                        '.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        '.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                    End With

                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub dgitems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgitems.KeyDown

        If e.KeyCode = Keys.Enter Then
            DgitemsKeydown()
            e.SuppressKeyPress = True
            dgitems.Visible = False
            ceQty.Focus()
            ceQty.SelectAll()
        End If

        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If drgrid.Rows.Count > 1 Then
                    drgrid.Focus()
                End If
            End If

        End If

        If e.KeyCode = Keys.Escape Then

            dgitems.Visible = False
            'txtitem.Focus()
            'txtitem.SelectAll()
            txtItem.Focus()
            txtItem.SelectAll()
            e.SuppressKeyPress = True
        End If


    End Sub

    Private Sub txtItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItem.KeyDown

        If e.KeyCode = Keys.Enter Then
            nProdID = 0
            nStckid = 0
            If Not String.IsNullOrEmpty(txtItem.Text) Then
                Try
                    Dim mgr As stocksManager
                    Dim col1 As stocksCollection
                    mgr = New stocksManager()
                    mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                    mgr.Entity.barcode = txtItem.Text.Trim
                    col1 = mgr.BuildCollection()
                    If mgr.DataObject.RowsAffected > 0 Then
                        nProdID = mgr.DataObject.Entity.stckid
                        txtItem.Text = mgr.DataObject.Entity.itemdesc
                        vbocde = mgr.DataObject.Entity.barcode
                        ceCost.Value = mgr.DataObject.Entity.cost
                        txtStckid.Text = CStr(mgr.DataObject.Entity.stckid)
                        dgitems.Visible = False
                        vItem = mgr.DataObject.Entity.itemdesc
                        ceQty.Focus()


                    Else
                        If dgitems.Visible = True Then
                            DgitemsKeydown()
                        End If
                    End If
                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If

        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If drgrid.Rows.Count > 1 Then
                    drgrid.Focus()
                End If
            End If

        End If

        If e.KeyCode = Keys.Escape Then
            dgitems.Visible = False
            txtItem.Focus()
            txtItem.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtItem_KeyUp(sender As Object, e As KeyEventArgs) Handles txtItem.KeyUp
        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If drgrid.Rows.Count > 1 Then
                    drgrid.Focus()
                End If
            End If
        End If
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem.KeyPress
        If e.KeyChar = Chr(27) Then
            dgitems.Visible = False
        End If
    End Sub
End Class