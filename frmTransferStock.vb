Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Public Class frmTransferStock
    Dim mgr7 As stocksManager
    Dim mgrdrheader As transfer_hdrManager ' Transfer_hdr
    Dim mgrdrdetail As transfer_detManager ' transfer_det
    Dim Totss As Decimal = 0
    'Private mOrderId As Integer = 0
    Private mdrId As Integer = 0
    Private WithEvents TranHdrtmp As PDSATransaction
    Private WithEvents TranDr As PDSATransaction

    Public vItem As String = String.Empty
    Public vStckid As Integer = 0
    Public vPrice As Decimal = 0
    Public vWPrice As Decimal = 0
    Public vbocde As String = String.Empty
    Public vAvlbl As Integer = 0
    Public vInnerQty As Integer = 0
    Public vTrpieces As Integer = 0


    Private Sub frmTransferStock_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmTransferStock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim vRows As Integer = drgrid.Rows.Count
        If vRows > 0 Then
            MessageBox.Show("Transfer List not saved. Please Post before closing the Transfer Entry Form to avoid unfinished work.")
            e.Cancel = True
        End If
    End Sub
    Private Sub frmTransferStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLocation()
        Me.Cursor = Cursors.WaitCursor
        dedlvrydate.EditValue = Date.Today
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        drgrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.Cursor = Cursors.Default
    End Sub
    Sub LoadLocation()
        Dim mgrloc As locationManager = New locationManager()
        Try
            Dim mgrs As locationManager = New locationManager()
            mgrs.DataObject.OrderByFilter = locationData.OrderByFilters.location
            Dim cols As locationCollection
            cols = mgrs.BuildCollection()
            leLocation.Properties.DisplayMember = "location"
            leLocation.Properties.ValueMember = "locid"
            leLocation.Properties.DataSource = cols

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
    End Sub

    Private Sub btnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Try
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
    End Sub

    Private Sub ItemsearchExecute()
        Dim col1 As stocksCollection
        Dim nStckid As Integer = 0
        Try
            mgr7 = New stocksManager()
            mgr7.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
            mgr7.DataObject.Entity.stckid = CInt(txtStckid.Text)

            col1 = mgr7.BuildCollection()

            If mgr7.DataObject.RowsAffected > 0 Then

                nStckid = mgr7.DataObject.Entity.stckid
                ceCost.Value = mgr7.DataObject.Entity.cost

                ceQty.Focus()
                'SendItemtoGrid()

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If ceQty.Value <= 0 Then
            MessageBox.Show("Qty to be transferred cannot be less than or equal to zero")
            ceQty.Focus()
            Exit Sub
        Else
            Call SendItemtoGrid()
            'btnItemSearch.Focus()
            txtItem.Focus()
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Enablectrl()
        drgrid.Rows.Clear()
        dedlvrydate.EditValue = Date.Today
        ceQty.Value = 0
        ceCost.Value = 0
        txtStckid.Text = String.Empty
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
                drgrid.Rows.Add(mgr7.DataObject.Entity.stckid, mgr7.DataObject.Entity.itemdesc, ceQty.Value, mgr7.DataObject.Entity.cost, Amount3)
            Else

                ' if item is already there increase its count
                Dim ItemCount As Integer = CInt(drgrid.Rows(ItemLoc).Cells(2).Value)
                ItemCount += CInt(ceQty.Value)
                Dim NewPrice As Decimal = mgr7.DataObject.Entity.cost * ItemCount
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

    Private Sub ceQty_LostFocus(sender As Object, e As EventArgs) Handles ceQty.LostFocus
        If ceQty.Value < 0 Then
            MessageBox.Show("Qty Trasnferred cannot be equal or less than zero")

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

    Private Sub TranDr_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.AfterSubmit
        If e.ClassName = "transfer_hdrData" Then ' Transfer_hdr
            mdrId = DirectCast(e.DataClassTable.EntityObject, transfer_hdr).tid
        End If
    End Sub

    Private Sub TranDr_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles TranDr.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        If e.ClassName = "transfer_detData" Then ' Transfer_det
            DirectCast(e.DataClassTable.EntityObject, transfer_det).tid = mdrId
        End If
    End Sub
    Private Sub drgrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellEndEdit
        'Dim roww As Integer = DGRetrieve.CurrentCellAddress.Y
        'Dim varrowindex As Integer = 0
        'Dim vqty As Integer = 0
        'Dim vamnt As Decimal = 0
        'varrowindex = drgrid.SelectedCells(0).RowIndex
        'vqty = CInt(drgrid.Rows(varrowindex).Cells(2).Value)
        'vamnt = CDec(drgrid.Rows(varrowindex).Cells(4).Value)

        ''Dim rowww As Integer = CInt(DGRetrieve.CurrentRow.Selected())
        'drgrid.Rows(varrowindex).Cells(5).Value = vqty * vamnt
        'Dim I As Integer = 0
        'Totss = 0
        'For I = 0 To drgrid.Rows.Count - 1
        '    Totss += CDec(drgrid.Rows(I).Cells(5).Value)
        'Next
        'txtsum.Text = FormatNumber(Totss, 2)
        'txtGrand.Text = FormatNumber(Totss, 2)

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If leLocation.Text = String.Empty Then
            MessageBox.Show("Identify the location where you are transferring the stock.")
            leLocation.Focus()
            Exit Sub
        End If
        Dim ansint As Integer = 0
        ansint = 7
        ansint = MsgBox("Please make sure All information entered are correct(Where to transfer,Items,Date Transferred etc.) before clicking yes to Save!", MsgBoxStyle.YesNo)
        If ansint = 7 Then
            Exit Sub
        End If

        If drgrid.Rows.Count <= 0 Then
            MessageBox.Show("No Item to be transferred on the list.")
            btnItemSearch.Focus()
            Exit Sub
        End If




        Dim grdCount As Integer = 0
        Dim iii As Integer = 0
        TranDr = New PDSATransaction()
        mgrdrheader = New transfer_hdrManager() ' Transfer_hdr
        mgrdrheader.DataObject.TransactionType = PDSATransactionType.Insert
        Try

            Dim mTransferID As Integer
            '+The code to Execute the Sequence operation
            Dim spGetTransferNo As spGetTransferNoManager
            Dim transpGetReceiptNo As PDSATransaction = New PDSATransaction()
            spGetTransferNo = New spGetTransferNoManager()
            transpGetReceiptNo.Add(spGetTransferNo.DataObject)
            transpGetReceiptNo.Execute()
            'MessageBox.Show(spGetReceiptNo.DataObject.Entity.ReceiptNo.ToString)
            mTransferID = 0
            mTransferID = Convert.ToInt32(spGetTransferNo.DataObject.Entity.TransferNo)

            mgrdrheader.Entity.tdate = CDate(dedlvrydate.Text)
            mgrdrheader.Entity.TransferNo = mTransferID
            mgrdrheader.Entity.locid = CInt(leLocation.EditValue)
            mgrdrheader.Entity.dtInsertdt = Date.Now
            mgrdrheader.Entity.dtLastUpdatedt = Date.Now
            mgrdrheader.Entity.tamnt = CDec(txtsum.Text)
            mgrdrheader.Entity.sInsertid = PDSAAppConfig.CurrentLoginID

            TranDr.Add(mgrdrheader.DataObject)

            'save trasfer_det on the grid
            grdCount = drgrid.Rows.Count
            For iii = 0 To grdCount - 1
                mgrdrdetail = New transfer_detManager()
                mgrdrdetail.DataObject.TransactionType = PDSATransactionType.Insert
                mgrdrdetail.Entity.tid = mdrId
                mgrdrdetail.Entity.stckid = Convert.ToInt32(drgrid.Rows(iii).Cells(0).Value)
                mgrdrdetail.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                If CInt(drgrid.Rows(iii).Cells(2).Value) > 0 Then
                    mgrdrdetail.Entity.qty = CInt(drgrid.Rows(iii).Cells(2).Value)
                Else
                    mgrdrdetail.Entity.qty = 0
                End If

                mgrdrdetail.Entity.price = CDec(drgrid.Rows(iii).Cells(3).Value)
                mgrdrdetail.Entity.tamnt = CDec(drgrid.Rows(iii).Cells(4).Value)
                TranDr.Add(mgrdrdetail.DataObject)
            Next
            TranDr.Execute()

            Dim TranSpTrans As New PDSATransaction()
            Dim mgrspDrTrans As New spTransferProcManager()

            mgrspDrTrans.Entity.tid = mdrId
            TranSpTrans.Add(mgrspDrTrans.DataObject)
            TranSpTrans.Execute()

            'Dim posrep As New xrTrasnferPrnt()
            Dim posrep As New xrTransfer()
            'posrep.DataSource = sqlDT
            posrep.TransferId.Value = mdrId
            posrep.RequestParameters = False
            posrep.PrintingSystem.ShowMarginsWarning = False
            posrep.Print()



            MessageBox.Show("Transfer Stocks Transaction Successfully Posted.")
            InitCtrls()
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
        'btnRetrieve.Enabled = False
        'btnSave.Enabled = False
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
        'btnRetrieve.Enabled = True
        'btnSave.Enabled = True
        btnNew.Enabled = False
    End Sub

    Sub InitCtrls()
        ceQty.Value = 0
        ceCost.Value = 0
        txtItem.Text = String.Empty
        drgrid.Rows.Clear()
    End Sub

    Private Sub drgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drgrid.CellContentClick

    End Sub
    Private Sub dgitems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgitems.KeyDown
        If e.KeyCode = Keys.Enter Then

            If dgitems.Rows.Count < 1 Then
                Exit Sub
            End If
            Try
                Dim vRow As Integer = 0
                Dim vint As Integer = 0
                Dim x1 As String = String.Empty
                Dim x2 As String = String.Empty
                ' Dim x2 As Integer = 0
                Dim x3 As Integer = 0
                Dim x4 As Decimal = 0
                Dim x5 As Integer = 0
                Dim x6 As String = String.Empty
                vRow = dgitems.CurrentRow.Index
                'vint = CInt(dgitems(0, vRow).Value)
                'x1 = CStr(dgitems(1, vRow).Value)
                'x2 = CStr(dgitems(2, vRow).Value)
                'x3 = CDec(dgitems(12, vRow).Value)
                'x4 = CDec(dgitems(13, vRow).Value)
                vint = CInt(dgitems(0, vRow).Value)
                x1 = CStr(dgitems(1, vRow).Value)
                x2 = CStr(dgitems(2, vRow).Value)
                x3 = CInt(dgitems(3, vRow).Value)
                x4 = CDec(dgitems(4, vRow).Value)
                'x5 = CInt(dgitems(6, vRow).Value)
                'x6 = CStr(dgitems(7, vRow).Value)
                vStckid = vint
                vItem = x2
                vAvlbl = x3
                vbocde = x1
                vPrice = x3
                vWPrice = x4
                'vInnerQty = x5

                txtbcodes.Text = String.Empty
                txtStckid.Text = String.Empty
                txtItem.Text = vItem.ToString
                txtbcodes.Text = vbocde.ToString
                'txtBarcode.Text = vbocde.ToString
                txtStckid.Text = vStckid.ToString

                If txtStckid.Text = String.Empty Then
                    Exit Sub
                Else
                    ItemsearchExecute()
                End If



                ' ''txtBarcode.SelectAll()
                ''If txtStckid.Text = String.Empty Then
                ''    Exit Sub
                ''Else
                ''    ItemsearchExecute()
                ''End If
                ''txtitem.Focus()

                dgitems.Visible = False
                'ceQty.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Escape Then

            dgitems.Visible = False
            txtItem.Focus()
            txtItem.SelectAll()

            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgitems_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgitems.KeyPress
        If e.KeyChar = Chr(27) Then
            'DGRetrieve.Visible = False
            dgitems.Visible = False
            txtItem.Focus()
        End If
    End Sub
    Private Sub txtItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim nProdID As Integer = 0
            'nStckid = 0
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
        If e.KeyCode = Keys.F1 Then
            'vpieces = CInt(drgrid.SelectedRows(0).Cells(2).Value)
            SetQuantity()
            e.Handled = True
        End If


        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
        'If e.KeyCode = Keys.Left Then
        '    txtBarcode.Focus()
        '    txtitem.Text = ""
        'End If

        If e.KeyCode = Keys.Down Then
            dgitems.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            dgitems.Visible = False
            txtItem.Focus()
            txtItem.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
    Friend Sub SetQuantity()
        Try
            If drgrid.Rows.Count >= 1 Then
                Dim formQty As New frmTrQty
                formQty.ShowDialog()

                drgrid.SelectedRows(0).Cells(2).Value = CInt(frmTrQty.qtyTr)
                drgrid.SelectedRows(0).Cells(4).Value = CDec(CInt(frmTrQty.qtyTr) * CDec(drgrid.SelectedRows(0).Cells(3).Value))
                txtItem.Text = String.Empty

                Dim IAyI As Integer = 0
                Dim TotalDelivery As Decimal
                TotalDelivery = 0
                For IAyI = 0 To drgrid.Rows.Count - 1
                    TotalDelivery += CDec(drgrid.Rows(IAyI).Cells(4).Value)
                Next

                ' txtCounts.Text = CStr(PosGrid.Rows.Count)

                'Scroll to the last row.
                Me.drgrid.FirstDisplayedScrollingRowIndex = Me.drgrid.RowCount - 1

                'Select the last row.
                Me.drgrid.Rows(Me.drgrid.RowCount - 1).Selected = True
                'txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtsum.Text = FormatNumber(TotalDelivery, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                'CheckSumifNegative()
                'vpTotalSales = TotalDelivery
                vTrpieces = 1

                txtItem.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
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
            ceQty.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub txtItem_KeyUp(sender As Object, e As KeyEventArgs) Handles txtItem.KeyUp
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        If txtItem.Text = String.Empty Then
            'MessageBox.Show("Enter an item description to seaarch.")
            'txtitem.Focus()
            dgitems.Visible = False
            Exit Sub
        Else

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

                    dgitems.DataSource = mgrloaditem.DataObject.GetDataTable()
                    dgitems.Visible = True
                    dgitems.Columns(0).Visible = False
                    dgitems.Columns(1).Visible = False
                    dgitems.Columns(4).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(2).Width = 450
                    dgitems.Columns(2).HeaderText = "Item Description"
                    dgitems.Columns(3).HeaderText = "Avlbl"
                    dgitems.Columns(5).HeaderText = "Retail Price"
                    dgitems.Columns(6).HeaderText = "Whole Sale"
                    dgitems.Columns(7).HeaderText = "Packaging"
                    'dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(3).Width = 70
                    dgitems.Columns(5).Width = 130
                    'dgitems.Columns(8).Visible = False
                    'dgitems.Columns(9).Visible = False
                    'dgitems.Columns(10).Visible = False
                    With dgitems.ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.White
                        .Font = New Font("Tahoma", 14.0F, FontStyle.Regular)
                    End With

                    With Me.dgitems
                        .RowTemplate.Height = 26
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular)
                        .RowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular)
                        .Columns("item_desc").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular)
                        .Columns("retail").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular)
                        .Columns("available").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular)

                        .Columns("retail").DefaultCellStyle.Format = "c"
                        .Columns("retail2").DefaultCellStyle.Format = "c"
                        .Columns("retail").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("retail2").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("Available").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        ' ''.DefaultCellStyle.NullValue = "no entry"
                        ''.Columns("Packaging").DefaultCellStyle.Alignment = _
                        ''DataGridViewContentAlignment.MiddleRight()
                        '.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        '.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        '.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                    End With
                    'txtfilter.Enabled = True
                    'btnFilter.Enabled = True
                    'dgitems.Focus()
                Else
                    'MessageBox.Show("No item(s) related to the search criteria!")
                    txtItem.Focus()

                    'txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If



    End Sub

    Private Sub leLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles leLocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtItem.Focus()
        End If
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        VoidItem()
    End Sub

    Private Sub VoidItem()
        If drgrid.Rows.Count = 0 Then
            'txtBarcode.Focus()
            'btnSearchItems.Focus()
            ' txtitem.Focus()
            txtItem.Text = String.Empty
            txtItem.Focus()
            Exit Sub
        End If

        Dim ii As Integer
        Dim trtotal As Decimal = 0


        Try

            If drgrid.SelectedRows.Count = 0 Then
                Exit Sub
            End If


            drgrid.Rows.Remove(drgrid.SelectedRows(0))
            For ii = 0 To drgrid.Rows.Count - 1
                trtotal += CDec(drgrid.Rows(ii).Cells(4).Value)
            Next


            txtsum.Text = FormatNumber(trtotal, 2, , TriState.True, TriState.True)  'FormatNumber(CStr(Totss))
            txtItem.Focus()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub frmTransferStock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'vpieces = CInt(drgrid.SelectedRows(0).Cells(2).Value)
            SetQuantity()
            e.Handled = True
        End If
    End Sub

    Private Sub ceQty_EditValueChanged(sender As Object, e As EventArgs) Handles ceQty.EditValueChanged

    End Sub

    Private Sub ceQty_KeyDown(sender As Object, e As KeyEventArgs) Handles ceQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ceQty.Value <= 0 Then
                MessageBox.Show("Qty to be transferred cannot be less than or equal to zero")
                ceQty.Focus()
                Exit Sub
            Else
                Call SendItemtoGrid()
                'btnItemSearch.Focus()
                txtItem.Focus()
            End If
        End If
    End Sub
End Class