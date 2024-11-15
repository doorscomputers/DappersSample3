Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmEditItems
    Dim Tran As PDSATransaction = New PDSATransaction()
    Dim mgrstock As stocksManager = New stocksManager()
    Dim trans As PDSATransaction
    Dim lastCost As Decimal = 0
    Dim lastPrice As Decimal = 0
    Dim lastWholeSale As Decimal = 0
    Dim StockPK As Integer = 0
    Dim vBarcode As String = String.Empty
    Dim vItem As String = String.Empty
    Public vbocde As String = String.Empty

    Private Sub frmEditItems_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEditItems_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnSave.Enabled = True Then
            MessageBox.Show("There is a pending data entry,Save or Cancel before Closing.")
            e.Cancel = True
        End If
    End Sub
    Private Sub frmEditItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.Focus()
        Call DisableCtrols()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        LoadSupplier()
        LoadCategory()
        LoadBrand()
        LoadType()
        Me.Cursor = Cursors.Default
        btnNew.Focus()
    End Sub

    Sub SearchBarcode()

        mgrstock.DataObject.WhereFilter = stocksData.WhereFilters.barcode
        mgrstock.DataObject.Entity.barcode = txtsrchbcode.Text
        mgrstock.DataObject.Load()
        If mgrstock.DataObject.RowsAffected > 0 Then
            txtBarcode.Text = mgrstock.DataObject.Entity.barcode
            txtItem.Text = mgrstock.DataObject.Entity.itemdesc
            ceAvlbl.Value = CDec(mgrstock.Entity.available)
            leSuppliers.EditValue = mgrstock.Entity.supcode
            leCategories.EditValue = mgrstock.Entity.categoryid
            ceCost.Value = mgrstock.Entity.cost
            leBrand.EditValue = mgrstock.Entity.dept
            leType.EditValue = mgrstock.Entity.sizeid

            ceCost.Value = mgrstock.Entity.cost
            lastCost = mgrstock.Entity.cost
            ceWholesale.Value = mgrstock.Entity.retail2 'wsale
            lastWholeSale = mgrstock.Entity.retail2
            lastPrice = mgrstock.Entity.retail
            txtLastPrice.Text = CStr(mgrstock.Entity.lastprice)
            txtLastCost.Text = CStr(mgrstock.Entity.lastcost)
            ceRetail.Value = mgrstock.Entity.retail
            ceMin.Value = CDec(mgrstock.Entity.minimum)
            ceMax.Value = CDec(mgrstock.Entity.maximum)
            ceMarkup1.Value = CDec(mgrstock.Entity.markup)
            ceMarkup2.Value = CDec(mgrstock.Entity.markup2)
            ceMarkup3.Value = CDec(mgrstock.Entity.markup3)
            ceMarkup4.Value = CDec(mgrstock.Entity.markup4)
            retail1.Value = mgrstock.Entity.retail
            retail2.Value = mgrstock.Entity.retail2
            retail3.Value = mgrstock.Entity.retail3
            retail4.Value = mgrstock.Entity.retail4

            ceRetail.Value = mgrstock.Entity.retail
            ceWholesale.Value = mgrstock.Entity.retail2
            mgrstock.Entity.retail2 = CDec(retail2.Value)
            mgrstock.Entity.retail3 = CDec(retail3.Value)
            mgrstock.Entity.retail4 = CDec(retail4.Value)

            mgrstock.Entity.maximum = CInt(ceMax.Value)
            mgrstock.Entity.minimum = CInt(ceMin.Value)

            txtEditedOn.Text = CStr(mgrstock.Entity.dtLastUpdatedt)
            txtEditedBy.Text = CStr(mgrstock.Entity.sLastUpdateid)
            txtCreatedBy.Text = CStr(mgrstock.Entity.sInsertid)
            txtCreatedOn.Text = CStr(mgrstock.Entity.dtInsertdt)
            mgrstock.Entity.vat = mgrstock.Entity.vat
            chkIncentive.EditValue = mgrstock.Entity.active
            ceIncentive.Value = mgrstock.Entity.vat 'mgrstock.Entity.incentive
            StockPK = mgrstock.Entity.stckid
            vBarcode = mgrstock.Entity.barcode
            vItem = mgrstock.Entity.itemdesc
            ceAvlbl.Enabled = False
            If chkIncentive.Checked = True Then
                ceIncentive.Enabled = True
            Else
                ceIncentive.Enabled = False
            End If
            'btnSave.Enabled = True
            'btnCancel.Enabled = True
            btnNew.Enabled = True
            btnNew.Focus()
        Else
            ClearCtrls()
            DisableCtrols()
            StockPK = 0
            vBarcode = String.Empty
            vItem = String.Empty
            MessageBox.Show("Barcode Not Found")
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnNew.Enabled = False
            'txtBarcode.Focus()
            'txtBarcode.SelectAll()
            txtsrchbcode.Focus()
            txtsrchbcode.SelectAll()
        End If
    End Sub

    Private Sub dgitems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgitems.KeyDown

        If e.KeyCode = Keys.Enter Then
            DgitemsKeydown()
            e.SuppressKeyPress = True
            txtItem.Focus()
        End If

        If e.KeyCode = Keys.Escape Then
            dgitems.Visible = False
            txtItem.Focus()
            e.SuppressKeyPress = True
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
            vRow = dgitems.CurrentRow.Index
            vint = CInt(dgitems(0, vRow).Value)
            x1 = CStr(dgitems(1, vRow).Value)
            vbocde = x1
            'txtBarcode.Text = vbocde.ToString
            txtsrchbcode.Text = vbocde.ToString
            'Search for the Barcode
            SearchBarcode()
            dgitems.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        EnableCtrols()
        InitControls()
        txtBarcode.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableCtrols()
        btnNew.Focus()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        InitControls()
        btnNew.Enabled = False
        txtsrchbcode.Enabled = True
        txtsrchitemdesc.Enabled = True
        txtsrchbcode.SelectAll()
        txtsrchbcode.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub InitControls()
        txtBarcode.Text = String.Empty
        txtItem.Text = String.Empty
        'leSuppliers.Text = String.Empty
        'leCategories.Text = String.Empty
        'leBrand.Text = String.Empty
        'leType.Text = String.Empty
        ceCost.Value = 0
        ceRetail.Value = 0
        ceWholesale.Value = 0
        ceMin.Value = 0
        ceMax.Value = 0
        compmup1.Value = 0
        compmup2.Text = "0"
        compretail.Text = "0"
        compwholesale.Value = 0
        ceMarkup1.Value = 0
        retail1.Value = 0
        ceMarkup2.Value = 0
        retail2.Value = 0
        ceMarkup3.Value = 0
        retail3.Value = 0
        ceMarkup4.Value = 0
        retail4.Value = 0
    End Sub

    Private Sub EnableCtrols()
        btnNew.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtBarcode.Enabled = True
        txtItem.Enabled = True
        leSuppliers.Enabled = True
        leCategories.Enabled = True
        leBrand.Enabled = True
        leType.Enabled = True
        ceCost.Enabled = True
        ceRetail.Enabled = True
        ceWholesale.Enabled = True
        ceMin.Enabled = True
        ceMax.Enabled = True
        GroupControl1.Enabled = True
        ceMin.Value = 10
        ceMax.Value = 1000
        retail2.Enabled = True
        retail3.Enabled = True
        retail4.Enabled = True
        ceAvlbl.Enabled = False
        compwholesale.Enabled = True
        ceMarkup1.Enabled = True
        retail1.Enabled = True
        ceMarkup2.Enabled = True
        ceMarkup3.Enabled = True
        ceMarkup4.Enabled = True
        retail4.Enabled = True
        ceIncentive.Enabled = True
    End Sub

    Private Sub DisableCtrols()
        ' btnNew.Enabled = True
        btnClose.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtBarcode.Enabled = False
        txtItem.Enabled = False
        leSuppliers.Enabled = False
        leCategories.Enabled = False
        leBrand.Enabled = False
        leType.Enabled = False
        ceCost.Enabled = False
        ceRetail.Enabled = False
        ceWholesale.Enabled = False
        ceMin.Enabled = False
        ceMax.Enabled = False
        btnClose.Enabled = False
        GroupControl1.Enabled = False
        retail2.Enabled = False
        retail3.Enabled = False
        retail4.Enabled = False
        ceAvlbl.Enabled = False
        compwholesale.Enabled = False
        ceMarkup1.Enabled = False
        retail1.Enabled = False
        ceMarkup2.Enabled = False
        retail2.Enabled = False
        ceMarkup3.Enabled = False
        retail3.Enabled = False
        ceMarkup4.Enabled = False
        retail4.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        ceIncentive.Enabled = False

    End Sub
    Private Sub ClearCtrls()
        txtBarcode.Text = String.Empty
        txtItem.Text = String.Empty
        ceCost.Value = 0
        ceRetail.Value = 0
        ceWholesale.Value = 0
        ceMin.Value = 0
        ceMax.Value = 0
        compwholesale.Value = 0
        ceMarkup1.Value = 0
        retail1.Value = 0
        ceMarkup2.Value = 0
        retail2.Value = 0
        ceMarkup3.Value = 0
        retail3.Value = 0
        ceMarkup4.Value = 0
        retail4.Value = 0
        chkIncentive.EditValue = 0
        ceIncentive.Value = 1
        txtCreatedBy.Text = String.Empty
        txtCreatedOn.Text = String.Empty
        txtEditedBy.Text = String.Empty
        txtEditedOn.Text = String.Empty
        txtLastCost.Text = String.Empty
        txtLastPrice.Text = String.Empty
        lastCost = 0
        lastPrice = 0
        lastWholeSale = 0
        retail1.Value = 0
        retail2.Value = 0
        retail3.Value = 0
        retail4.Value = 0

    End Sub
    Private Sub LoadSupplier()
        Dim mgrs As suppliersManager = New suppliersManager()
        mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier
        Dim cols As suppliersCollection = mgrs.BuildCollection()
        leSuppliers.Properties.DisplayMember = "supplier"
        leSuppliers.Properties.ValueMember = "supcode"
        leSuppliers.Properties.DataSource = cols
    End Sub
    Private Sub LoadCategory()
        Dim mgrcat As categoriesManager = New categoriesManager()
        mgrcat.DataObject.OrderByFilter = categoriesData.OrderByFilters.catgory
        Dim colscat As categoriesCollection = mgrcat.BuildCollection()
        leCategories.Properties.DisplayMember = "catgory"
        leCategories.Properties.ValueMember = "categoryid"
        leCategories.Properties.DataSource = colscat
    End Sub

    Private Sub LoadBrand()
        Dim mgrbrand As deptManager = New deptManager()
        'mgrbrand.DataObject.OrderByFilter = deptData.OrderByFilters.DEPT
        Dim colsdept As deptCollection = mgrbrand.BuildCollection()
        leBrand.Properties.DisplayMember = "DEPTD"
        leBrand.Properties.ValueMember = "deptid"
        leBrand.Properties.DataSource = colsdept
    End Sub

    Private Sub LoadType()
        Dim mgrsize As wsizeManager = New wsizeManager()
        mgrsize.DataObject.OrderByFilter = wsizeData.OrderByFilters.sayz
        Dim cols As wsizeCollection = mgrsize.BuildCollection()
        leType.Properties.DisplayMember = "sayz"
        leType.Properties.ValueMember = "sizeid"
        leType.Properties.DataSource = cols
    End Sub
    Private Sub btnNew_Click_1(sender As Object, e As EventArgs)
        EnableCtrols()
        InitControls()
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If vItem <> txtItem.Text Then
        '    If Trim(txtItem.Text) <> "" Then
        '        Try
        '            Dim mgrdesc As stocksManager = New stocksManager()
        '            mgrdesc.DataObject.SelectFilter = stocksData.SelectFilters.All
        '            mgrdesc.DataObject.WhereFilter = stocksData.WhereFilters.items
        '            mgrdesc.Entity.itemdesc = Trim(txtItem.Text)
        '            mgrdesc.DataObject.Load()
        '            If mgrdesc.DataObject.RowsAffected > 0 Then
        '                MessageBox.Show("Item Description Already Exist", "Duplicate Item Description Found")
        '                txtItem.Focus()
        '                Exit Sub
        '            End If
        '        Catch ex As PDSAValidationException
        '            MessageBox.Show(ex.Message)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.ToString())
        '        End Try
        '    End If
        'End If

        'If vBarcode <> txtBarcode.Text Then
        '    If txtBarcode.Text <> "" Then
        '        Try
        '            Dim mgrbcode As stocksManager = New stocksManager()
        '            mgrbcode.DataObject.SelectFilter = stocksData.SelectFilters.ListBox
        '            mgrbcode.DataObject.WhereFilter = stocksData.WhereFilters.barcode
        '            mgrbcode.Entity.barcode = Trim(txtBarcode.Text)
        '            mgrbcode.DataObject.Load()
        '            If mgrbcode.DataObject.RowsAffected > 0 Then
        '                MessageBox.Show("Item Code Already Exist", "Duplicate Barcode Found")
        '                'txtBarcode.Text = ""
        '                txtBarcode.Focus()
        '                Exit Sub
        '            End If

        '        Catch ex As PDSAValidationException
        '            MessageBox.Show(ex.Message)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.ToString())
        '        End Try
        '    End If
        'End If


        If leSuppliers.Text = String.Empty Then
            'MessageBox.Show("Supplier is Blank.")
            leSuppliers.EditValue = 1
        End If

        If leCategories.Text = String.Empty Then
            leCategories.EditValue = 1
        End If

        If leType.Text = String.Empty Then
            leType.EditValue = 1
        End If
        If leBrand.Text = String.Empty Then
            leBrand.EditValue = 1
        End If

        'Enable this check if the client wants to have a wholesale validation
        'If ceWholesale.Value <= 0 Then
        '    MessageBox.Show("Wholesale must be greater than Zero.")
        '    ceWholesale.Focus()
        '    Exit Sub
        'End If

        'CheckRetail()
        'CheckWholesale()

        If ceCost.Value < 0 Then
            MessageBox.Show("Cost must be Greater than Zero")
            ceCost.Focus()
            Exit Sub
        End If
        If ceRetail.Value <= 0 Then
            MessageBox.Show("Retail Must be greater than Zero.")
            ceRetail.Focus()
            Exit Sub
        End If

        If ceRetail.Value < ceCost.Value Then
            MessageBox.Show("Retail must be Greater than the Cost")
            ceRetail.Focus()
            Exit Sub
        End If


        'If ceWholesale.Value <= ceCost.Value Then
        '    MessageBox.Show("Wholesale Must be Greater than the Cost Price.")
        '    ceWholesale.Focus()
        '    Exit Sub
        'End If
        'If ceWholesale.Value > ceRetail.Value Then
        '    MessageBox.Show("Wholesale Must be Lesser than the Retail Price.")
        '    ceWholesale.Focus()
        '    Exit Sub
        'End If
        ' If ceWholesale.Value <= 0 Then
        'ceWholesale.Value = 0
        'ceWholesale.Focus()
        'Exit Sub
        'End If



        If txtItem.Text = String.Empty Then
            MessageBox.Show("Item Description Must not be Blank")
            txtItem.Focus()
            Exit Sub
        End If

        If txtBarcode.Text = String.Empty Then
            MessageBox.Show("Item Code Must not be Blank")
            txtBarcode.Focus()
            Exit Sub
        Else

            Try
                Dim tranUpdate As PDSATransaction
                tranUpdate = New PDSATransaction()
                Dim mgrstockk As stocksManager

                mgrstockk = New stocksManager()
                mgrstockk.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                mgrstockk.Entity.barcode = vBarcode 'CStr(txtBarcode.Text)
                mgrstockk.DataObject.Load()
                'mgrstockk.DataObject.UpdateFilter = stocksData.UpdateFilters.PrimaryKey
                'mgrstockk.DataObject.LoadByPK(StockPK)

                If mgrstockk.DataObject.RowsAffected > 0 Then

                    mgrstockk.DataObject.Entity.itemdesc = Trim(txtItem.Text)
                    mgrstockk.DataObject.Entity.barcode = Trim(txtBarcode.Text)
                    mgrstockk.DataObject.Entity.available = CDec(ceAvlbl.Value)
                    mgrstockk.DataObject.Entity.supcode = CInt(leSuppliers.EditValue)
                    mgrstockk.DataObject.Entity.categoryid = CInt(leCategories.EditValue)
                    mgrstockk.DataObject.Entity.cost = CDec(ceCost.Value)
                    mgrstockk.Entity.dept = CInt(leBrand.EditValue)
                    ''mgrstock.Entity.lastcost = 0
                    ''mgrstock.Entity.lastprice = 0
                    ''mgrstock.Entity.lastwholesale = 0
                    'mgrstockk.Entity.lastcost = CDec(ceCost.Value)

                    ' mgrstock.Entity.lastprice = CDec(ceRetail.Value)
                    mgrstockk.Entity.lastwholesale = CDec(ceWholesale.Value)
                    mgrstockk.Entity.markup = CDec(ceMarkup1.Value)
                    mgrstockk.Entity.markup2 = CDec(ceMarkup2.Value)
                    mgrstockk.Entity.markup3 = CDec(ceMarkup3.Value)
                    mgrstockk.Entity.markup4 = CDec(ceMarkup4.Value)

                    mgrstockk.Entity.retail = CDec(ceRetail.Value)
                    mgrstockk.Entity.retail2 = CDec(ceWholesale.Value)
                    mgrstockk.Entity.wsale = CDec(ceWholesale.Value)
                    mgrstockk.Entity.retail3 = CDec(retail3.Value)
                    mgrstockk.Entity.retail4 = CDec(retail4.Value)

                    mgrstockk.Entity.maximum = CInt(ceMax.Value)
                    mgrstockk.Entity.minimum = CInt(ceMin.Value)

                    mgrstockk.Entity.sizeid = CInt(leType.EditValue)
                    mgrstockk.Entity.dtLastUpdatedt = DateTime.Now
                    mgrstockk.Entity.sLastUpdateid = PDSAAppConfig.CurrentLoginID
                    If lastCost <> ceCost.Value Then
                        mgrstockk.Entity.lastcost = lastCost 'CDec(ceCost.Value)
                    End If
                    If lastPrice <> ceRetail.Value Then
                        mgrstockk.Entity.lastprice = lastPrice 'CDec(ceRetail.Value)
                    End If


                    mgrstockk.Entity.vat = CInt(ceIncentive.Value)
                    mgrstockk.Entity.active = CBool(chkIncentive.EditValue)
                    mgrstockk.Entity.incentive = 0 'CDec(ceIncentive.Value)
                    mgrstockk.DataObject.TransactionType = PDSATransactionType.Update
                    tranUpdate.Add(mgrstockk.DataObject)
                    tranUpdate.Execute()

                    btnSave.Enabled = False
                    btnCancel.Enabled = False
                    btnClose.Enabled = True
                    btnNew.Enabled = True
                    btnNew.Focus()
                    DisableCtrols()
                    btnNew.Enabled = False
                    MessageBox.Show("New Item Successfully Saved", "New Item")
                    btnSave.Enabled = False
                    btnSave.Enabled = False
                    btnClose.Enabled = True
                    txtsrchbcode.Text = String.Empty
                    txtsrchbcode.Enabled = True
                    txtsrchitemdesc.Enabled = True
                    txtsrchbcode.Focus()
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub CheckRetail()
        If ceCost.Value >= 0.1 And ceRetail.Value >= 0.1 Then
            If CDec(ceRetail.Value) <= CDec(ceCost.Value) Then
                MessageBox.Show("Retail Amount Must be Higher than the Cost", "Retail Amount Error")
                ceRetail.SelectAll()
                ceRetail.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CheckWholesale()
        'If ceWholesale.Value >= 0.1 And ceRetail.Value >= 0.1 Then
        '    If CDec(ceWholesale.Value) <= CDec(ceCost.Value) Then
        '        ' MessageBox.Show("Wholesale Must be Higher than the Cost ", "Wholesale Amount Error")
        '        ceWholesale.SelectAll()
        '        ceWholesale.Focus()
        '        Exit Sub
        '    End If

        '    If CDec(ceWholesale.Value) >= CDec(ceRetail.Value) Then
        '        'MessageBox.Show("Wholesale Must be Lesser than the Retail", "Wholesale Amount Error")
        '        ceWholesale.SelectAll()
        '        ceWholesale.Focus()
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub compmup1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles compmup1.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                compretail.Text = CStr(ceCost.Value + (ceCost.Value * (compmup1.Value / 100)))
                'ceRetail.Value = CDec(ceCost.Value + (ceCost.Value * (compmup1.Value / 100)))
            End If
        End If
    End Sub

    Private Sub compwholesale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles compwholesale.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                compmup2.EditValue = CDec((((compwholesale.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub ceMarkup1_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMarkup1.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMax.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMarkup2.Focus()
            e.Handled = True
            Exit Sub
        End If
        If e.KeyCode = Keys.Left Then
            ceRetail.Focus()
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub ceMarkup1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceMarkup1.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                retail1.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100)))
                retail2.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100)))
                retail3.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100)))
                retail4.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100)))
                ceRetail.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100)))
                ceWholesale.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup1.Value / 100))) - 1
                ceMarkup2.Value = ceMarkup1.Value
                ceMarkup3.Value = ceMarkup1.Value
                ceMarkup4.Value = ceMarkup1.Value
            End If
        End If
    End Sub

    Private Sub ceMarkup2_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMarkup2.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup1.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMarkup3.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Left Then
            ceWholesale.Focus()
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub ceMarkup2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceMarkup2.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                retail2.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup2.Value / 100)))
                ceWholesale.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup2.Value / 100)))
            End If
        End If
    End Sub

    Private Sub ceMarkup3_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMarkup3.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup2.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMarkup4.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Left Then
            ceMin.Focus()
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub ceMarkup3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceMarkup3.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                retail3.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup3.Value / 100)))
            End If
        End If
    End Sub

    Private Sub ceMarkup4_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMarkup4.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup3.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            btnSave.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Left Then
            ceMax.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ceMarkup4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceMarkup4.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                retail4.Value = CDec(ceCost.Value + (ceCost.Value * (ceMarkup4.Value / 100)))
            End If
        End If
    End Sub
    Private Sub retail1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retail1.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                ceMarkup1.EditValue = CDec((((retail1.Value - ceCost.Value) * 100) / ceCost.Value))
                ceRetail.Value = retail1.Value
            End If
        End If
    End Sub

    Private Sub retail2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retail2.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                ceMarkup2.EditValue = CDec((((retail2.Value - ceCost.Value) * 100) / ceCost.Value))
                ceWholesale.Value = retail2.Value
            End If
        End If
    End Sub

    Private Sub retail3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retail3.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                ceMarkup3.EditValue = CDec((((retail3.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub retail4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retail4.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                ceMarkup4.EditValue = CDec((((retail4.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub retail4_KeyDown(sender As Object, e As KeyEventArgs) Handles retail4.KeyDown
        If e.KeyCode = Keys.Up Then
            retail3.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            btnSave.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub retail3_KeyDown(sender As Object, e As KeyEventArgs) Handles retail3.KeyDown
        If e.KeyCode = Keys.Up Then
            retail2.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            retail4.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub retail2_KeyDown(sender As Object, e As KeyEventArgs) Handles retail2.KeyDown
        If e.KeyCode = Keys.Up Then
            retail1.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            retail3.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub retail1_KeyDown(sender As Object, e As KeyEventArgs) Handles retail1.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup4.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            retail2.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ceRetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceRetail.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 And ceRetail.Value > 0 Then
                ceMarkup1.EditValue = CDec((((ceRetail.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub ceWholesale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceWholesale.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 And ceWholesale.Value > 0 Then
                ceMarkup2.EditValue = CDec((((ceWholesale.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub ceCost_KeyDown(sender As Object, e As KeyEventArgs) Handles ceCost.KeyDown
        If e.KeyCode = Keys.Up Then
            leType.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceRetail.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ceRetail_KeyDown(sender As Object, e As KeyEventArgs) Handles ceRetail.KeyDown
        If e.KeyCode = Keys.Up Then
            ceCost.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceWholesale.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Right Then
            ceMarkup1.Focus()
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub ceWholesale_KeyDown(sender As Object, e As KeyEventArgs) Handles ceWholesale.KeyDown
        If e.KeyCode = Keys.Up Then
            ceRetail.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMin.Focus()
            e.Handled = True
            Exit Sub
        End If


        If e.KeyCode = Keys.Right Then
            ceMarkup2.Focus()
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub ceMin_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMin.KeyDown
        If e.KeyCode = Keys.Up Then
            ceWholesale.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMax.Focus()
            e.Handled = True
            Exit Sub
        End If


        If e.KeyCode = Keys.Right Then
            ceMarkup3.Focus()
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub ceMax_KeyDown(sender As Object, e As KeyEventArgs) Handles ceMax.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMin.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceMarkup1.Focus()
            e.Handled = True
            Exit Sub
        End If


        If e.KeyCode = Keys.Right Then
            ceMarkup4.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub chkIncentive_Click(sender As Object, e As EventArgs) Handles chkIncentive.Click
        'If chkIncentive.Checked = True Then
        '    ceIncentive.Enabled = True
        'Else
        ceIncentive.Enabled = True
        'End If
    End Sub

    Private Sub chkIncentive_KeyDown(sender As Object, e As KeyEventArgs) Handles chkIncentive.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup4.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceIncentive.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ceIncentive_KeyDown(sender As Object, e As KeyEventArgs) Handles ceIncentive.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup4.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            ceAvlbl.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ceAvlbl_KeyDown(sender As Object, e As KeyEventArgs) Handles ceAvlbl.KeyDown
        If e.KeyCode = Keys.Up Then
            ceIncentive.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            btnSave.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnNew_Click_2(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableCtrols()
        ' InitControls()
        txtsrchbcode.Enabled = False
        txtsrchitemdesc.Enabled = False
        btnSave.Enabled = True
        btnSave.Enabled = True
        btnClose.Enabled = False

        txtBarcode.Focus()

    End Sub

    Private Sub txtsrchbcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsrchbcode.KeyPress
        If btnSave.Enabled = True Then
            Exit Sub
        End If
        If e.KeyChar = Chr(13) Then
            SearchBarcode()
        End If
    End Sub

    Private Sub txtsrchitemdesc_TextChanged(sender As Object, e As EventArgs) Handles txtsrchitemdesc.TextChanged
        If txtsrchitemdesc.Text = String.Empty Then
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
                mgrloaditem.Entity.itemdesc = Trim(txtsrchitemdesc.Text)
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
                    'txtfilter.Enabled = True
                    'btnFilter.Enabled = True
                    'dgitems.Focus()
                Else
                    'MessageBox.Show("No item(s) related to the search criteria!")
                    'txtitem.Focus()
                    'txtBarcode.Focus()
                    'txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub txtsrchitemdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsrchitemdesc.KeyDown

        If e.KeyCode = Keys.Enter Then
            If dgitems.Visible = True Then
                ' DgitemsKeydown()
                DgitemsKeydown()
                e.SuppressKeyPress = True
                txtItem.Focus()
            End If
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            End If
            Exit Sub
        End If
        If e.KeyCode = Keys.Left Then
            txtsrchbcode.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Escape Then

            dgitems.Visible = False
            'txtitem.Focus()
            'txtitem.SelectAll()
            txtBarcode.Focus()
            txtBarcode.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ceWholesale_EditValueChanged(sender As Object, e As EventArgs) Handles ceWholesale.EditValueChanged

    End Sub

    Private Sub leType_KeyDown(sender As Object, e As KeyEventArgs) Handles leType.KeyDown
        If e.KeyCode = Keys.Up Then
            leBrand.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            ceCost.Focus()
            e.Handled = True
        End If
    End Sub


    Private Sub leBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles leBrand.KeyDown
        If e.KeyCode = Keys.Up Then
            leCategories.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            leType.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub leCategories_KeyDown(sender As Object, e As KeyEventArgs) Handles leCategories.KeyDown
        If e.KeyCode = Keys.Up Then
            leSuppliers.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            leBrand.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub leSuppliers_KeyDown(sender As Object, e As KeyEventArgs) Handles leSuppliers.KeyDown
        If e.KeyCode = Keys.Up Then
            txtItem.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            leCategories.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub txtItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItem.KeyDown
        If e.KeyCode = Keys.Up Then
            txtBarcode.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            leSuppliers.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown

        If e.KeyCode = Keys.Down Then
            txtItem.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Enter Then
            If txtBarcode.Text <> "" Then
                Try
                    Dim mgrbcode As stocksManager = New stocksManager()
                    mgrbcode.DataObject.SelectFilter = stocksData.SelectFilters.ListBox
                    mgrbcode.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                    mgrbcode.Entity.barcode = Trim(txtBarcode.Text)
                    mgrbcode.DataObject.Load()
                    If mgrbcode.DataObject.RowsAffected > 0 Then
                        MessageBox.Show("Barocde Already exist", "Duplicate Barcode found")
                        'txtBarcode.Text = ""
                        txtBarcode.Focus()
                    End If

                Catch ex As PDSAValidationException
                    MessageBox.Show(ex.Message)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub compmup1_KeyDown(sender As Object, e As KeyEventArgs) Handles compmup1.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMarkup4.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            compwholesale.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub compwholesale_KeyDown(sender As Object, e As KeyEventArgs) Handles compwholesale.KeyDown
        If e.KeyCode = Keys.Up Then
            compmup1.Focus()
            e.Handled = True
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then
            compwholesale.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnNew_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNew.KeyDown
        If e.KeyCode = Keys.Up Then
            txtsrchbcode.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtsrchbcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsrchbcode.KeyDown
        If e.KeyCode = Keys.Right Then
            txtsrchitemdesc.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnFocusBcode_Click(sender As Object, e As EventArgs) Handles btnFocusBcode.Click
        txtsrchbcode.Focus()
    End Sub

    Private Sub btnSrchItem_Click(sender As Object, e As EventArgs) Handles btnSrchItem.Click
        txtsrchitemdesc.Focus()
    End Sub
End Class