Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

Public Class frmNewItems
    Dim mgrstock As stocksManager
    'Dim colStocks As stocksCollection
    Dim trans As PDSATransaction

    Private Sub frmNewItems_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmNewItems_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnSave.Enabled = True Then
            MessageBox.Show("There is a pending data entry,Save or Cancel before Closing.")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmNewItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ceMarkup1.Enabled = True
        ceMarkup2.Enabled = True
        ceMarkup3.Enabled = True
        ceMarkup4.Enabled = True
        retail1.Enabled = True
        retail2.Enabled = True
        retail3.Enabled = True
        retail4.Enabled = True

    End Sub

    Private Sub DisableCtrols()
        btnNew.Enabled = True
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
        ceMarkup1.Enabled = False
        ceMarkup2.Enabled = False
        ceMarkup3.Enabled = False
        ceMarkup4.Enabled = False
        retail1.Enabled = False
        retail2.Enabled = False
        retail3.Enabled = False
        retail4.Enabled = False
    End Sub
    Private Sub ClearCtrls()
        txtBarcode.Text = String.Empty
        txtItem.Text = String.Empty
        ceCost.Value = 0
        ceRetail.Value = 0
        ceWholesale.Value = 0
        ceMin.Value = 0
        ceMax.Value = 0
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableCtrols()
        InitControls()
        txtBarcode.Focus()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Trim(txtItem.Text) <> "" Then
            Try
                Dim mgrdesc As stocksManager = New stocksManager()
                mgrdesc.DataObject.SelectFilter = stocksData.SelectFilters.All
                mgrdesc.DataObject.WhereFilter = stocksData.WhereFilters.items
                mgrdesc.Entity.itemdesc = Trim(txtItem.Text)
                mgrdesc.DataObject.Load()
                If mgrdesc.DataObject.RowsAffected > 0 Then
                    MessageBox.Show("Item Description Already exist", "Duplicate Item Description found")
                    txtItem.Focus()
                    Exit Sub
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

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
                    Exit Sub
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If



        If leSuppliers.Text = String.Empty Then
            'MessageBox.Show("Supplier is Blank.")
            leSuppliers.EditValue = 40
        End If

        If leCategories.Text = String.Empty Then
            leCategories.EditValue = 1
        End If

        If leType.Text = String.Empty Then
            leType.EditValue = 1
        End If
        If leBrand.Text = String.Empty Then
            leBrand.EditValue = 143
        End If

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
        If ceWholesale.Value > ceRetail.Value Then
            MessageBox.Show("Wholesale Must be Lesser than the Retail Price.")
            ceWholesale.Focus()
            Exit Sub
        End If
        If ceWholesale.Value <= 0 Then
            MessageBox.Show("Wholesale Must be Greater than Zero.")
            ceWholesale.Focus()
            Exit Sub
        End If

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
                trans = New PDSATransaction()
                mgrstock = New stocksManager()
                mgrstock.Entity.barcode = Trim(txtBarcode.Text)
                mgrstock.Entity.itemdesc = Trim(txtItem.Text)
                mgrstock.Entity.available = 0
                mgrstock.Entity.beginvstock = 0
                mgrstock.Entity.supcode = CInt(leSuppliers.EditValue)
                mgrstock.Entity.categoryid = CInt(leCategories.EditValue)
                mgrstock.Entity.cost = CDec(ceCost.Value)
                mgrstock.Entity.dept = CInt(leBrand.EditValue)
                mgrstock.Entity.lastcost = 0
                mgrstock.Entity.lastprice = 0
                mgrstock.Entity.lastwholesale = 0
                mgrstock.Entity.markup = CDec(ceMarkup1.Value) 'CInt(compmup1.Value)
                mgrstock.Entity.markup2 = CDec(ceMarkup2.Value) ' CInt(compmup2.EditValue)
                mgrstock.Entity.markup3 = CDec(ceMarkup3.Value) ' CInt(compmup2.EditValue)
                mgrstock.Entity.markup4 = CDec(ceMarkup4.Value) ' CInt(compmup2.EditValue)
                mgrstock.Entity.maximum = CInt(ceMax.Value)
                mgrstock.Entity.minimum = CInt(ceMin.Value)
                mgrstock.Entity.retail = CDec(ceRetail.Value)
                mgrstock.Entity.wsale = CDec(ceWholesale.Value)
                mgrstock.Entity.retail2 = CDec(retail2.Value)
                mgrstock.Entity.retail3 = CDec(retail3.Value)
                mgrstock.Entity.retail4 = CDec(retail4.Value)
                mgrstock.Entity.sizeid = CInt(leType.EditValue)
                mgrstock.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgrstock.Entity.active = True
                mgrstock.Entity.vat = 1
                trans.Add(mgrstock.DataObject)
                trans.Execute()

                btnSave.Enabled = False
                btnCancel.Enabled = False
                btnClose.Enabled = True
                btnNew.Enabled = True
                btnNew.Focus()
                MessageBox.Show("New Item Successfully Saved", "Item Saved")

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableCtrols()
        btnNew.Focus()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        InitControls()
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

    Private Sub CheckRetail()
        If ceCost.Value >= 0.1 And ceRetail.Value >= 0.1 Then
            If CDec(ceRetail.Value) <= CDec(ceCost.Value) Then
                MessageBox.Show("Retail Amount Must be Higher than the Cost", "Retail Amount Error")
                ceRetail.Value = 0
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CheckWholesale()
        If ceWholesale.Value >= 0.1 And ceRetail.Value >= 0.1 Then
            If CDec(ceWholesale.Value) <= CDec(ceCost.Value) Or CDec(ceWholesale.Value) >= CDec(ceRetail.Value) Then
                MessageBox.Show("Wholesale Must be Higher than the Cost and Lesser than the Retail", "Wholesale Amount Error")
                ceWholesale.Value = 0
                Exit Sub
            End If
        End If
    End Sub
    Private Sub ceRetail_LostFocus(sender As Object, e As EventArgs) Handles ceRetail.LostFocus
        CheckRetail()
    End Sub
    Private Sub ceWholesale_LostFocus(sender As Object, e As EventArgs) Handles ceWholesale.LostFocus
        CheckWholesale()
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

    Private Sub retail4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles retail4.KeyPress, ceAvlbl.KeyPress
        If e.KeyChar = Chr(13) Then
            If ceCost.Value > 0 Then
                ceMarkup4.EditValue = CDec((((retail4.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
        End If
    End Sub

    Private Sub retail4_KeyDown(sender As Object, e As KeyEventArgs) Handles retail4.KeyDown, ceAvlbl.KeyDown
        If e.KeyCode = Keys.Up Then
            retail3.Focus()
            e.Handled = True
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
                ceMarkup2.EditValue = CDec((((ceRetail.Value - ceCost.Value) * 100) / ceCost.Value))
            End If
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
        End If

        If e.KeyCode = Keys.Down Then
            ceMarkup1.Focus()
            e.Handled = True
        End If


        If e.KeyCode = Keys.Right Then
            ceMarkup4.Focus()
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

    Private Sub ceCost_KeyDown(sender As Object, e As KeyEventArgs) Handles ceCost.KeyDown
        If e.KeyCode = Keys.Up Then
            leType.Focus()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Down Then
            ceRetail.Focus()
            e.Handled = True
        End If
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

    Private Sub btnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSave.KeyDown
        If e.KeyCode = Keys.Up Then
            ceMax.Focus()
            e.Handled = True

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
        End If

        If e.KeyCode = Keys.Down Then
            compwholesale.Focus()
            e.Handled = True
        End If
    End Sub


    Private Sub btnNewsupplier_Click(sender As Object, e As EventArgs) Handles btnNewsupplier.Click
        Dim frm As frmSuppliers
        frm = New frmSuppliers
        frm.ShowDialog()
        frm = Nothing
        leSuppliers.Focus()
    End Sub

    Private Sub btnNewCategory_Click(sender As Object, e As EventArgs) Handles btnNewCategory.Click
        Dim frm As frmCategory
        frm = New frmCategory
        frm.ShowDialog()
        frm = Nothing
        leCategories.Focus()
    End Sub

    Private Sub btnNewBrand_Click(sender As Object, e As EventArgs) Handles btnNewBrand.Click
        Dim frm As frmBrand
        frm = New frmBrand
        frm.ShowDialog()
        frm = Nothing
        leBrand.Focus()
    End Sub

    Private Sub btnNewType_Click(sender As Object, e As EventArgs) Handles btnNewType.Click
        Dim frm As frmTypes
        frm = New frmTypes
        frm.ShowDialog()
        frm = Nothing
        leType.Focus()
    End Sub


    Private Sub leSuppliers_GotFocus(sender As Object, e As EventArgs) Handles leSuppliers.GotFocus
        LoadSupplier()
    End Sub


    Private Sub leCategories_GotFocus(sender As Object, e As EventArgs) Handles leCategories.GotFocus
        LoadCategory()
    End Sub


    Private Sub leBrand_GotFocus(sender As Object, e As EventArgs) Handles leBrand.GotFocus
        LoadBrand()
    End Sub

    Private Sub leType_GotFocus(sender As Object, e As EventArgs) Handles leType.GotFocus
        LoadType()
    End Sub
End Class