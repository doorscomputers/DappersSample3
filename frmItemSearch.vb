Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

Public Class frmItemSearch
    Public vItem As String = String.Empty
    Public vStckid As Integer = 0
    Public vPrice As Decimal = 0
    Public vWPrice As Decimal = 0
    Public vbocde As String = String.Empty
    Public vAvlbl As Integer = 0
    Public vInnerQty As Integer = 0
    Private WithEvents TranspDelstock As PDSATransaction
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        DelItems()

        LoadItems()

        'txtitem.Focus()
        'txtitem.SelectAll()
    End Sub
    Sub DelItems()
        'Dim TranspDelStock As New PDSATransaction()
        'Dim mgrdelitem As spDelposstocksManager

        'Try

        '    mgrdelitem = New spDelposstocksManager()
        '    mgrdelitem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
        '    TranspDelStock.Add(mgrdelitem.DataObject)
        '    TranspDelStock.Execute()
        'Catch ex As PDSAValidationException
        '    '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
        TranspDelstock = New PDSATransaction()
        Dim mgrdelitem As posstocksmanager = New posstocksmanager()
        Try
            mgrdelitem.DataObject.TransactionType = PDSATransactionType.Delete
            mgrdelitem.DataObject.SelectFilter = posstocksData.SelectFilters.All
            mgrdelitem.DataObject.DeleteFilter = posstocksData.DeleteFilters.DeleteByUserID
            mgrdelitem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            TranspDelstock.Add(mgrdelitem.DataObject)
            TranspDelstock.Execute()

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub LoadItems()
        If txtitem.Text = String.Empty Then
            MessageBox.Show("Enter an item description to seaarch.")
            txtitem.Focus()
            Exit Sub
        Else
            Dim TranspStock As New PDSATransaction()
            Dim mgrloaditem As spStocksManager

            Try

                mgrloaditem = New spStocksManager()
                mgrloaditem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgrloaditem.Entity.itemdesc = Trim(txtitem.Text)
                TranspStock.Add(mgrloaditem.DataObject)
                TranspStock.Execute()

                Dim mgritem As posstocksmanager = New posstocksmanager()
                Dim cols As posstocksCollection
                mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.cashier
                mgritem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgritem.Entity.itemdesc = Trim(txtitem.Text)
                mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc
                cols = mgritem.BuildCollection()
                If mgritem.DataObject.RowsAffected > 0 Then
                    dgitems.DataSource = cols
                    dgitems.Columns(0).Visible = False
                    ''dgitems.Columns(5).Visible = False
                    'dgitems.Columns(6).Visible = False
                    'dgitems.Columns(7).Visible = False
                    'dgitems.Columns(8).Visible = False
                    dgitems.Columns(1).Width = 500
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(6).HeaderText = "Packaging"
                    dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(4).Width = 150
                    dgitems.Columns(6).Width = 100
                    dgitems.Columns(7).Width = 100
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(9).Visible = False
                    dgitems.Columns(10).Visible = False
                    With Me.dgitems
                        .Columns("retail").DefaultCellStyle.Format = "c"
                        .Columns("retail2").DefaultCellStyle.Format = "c"
                        .Columns("retail").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("retail2").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("Available").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        '.DefaultCellStyle.NullValue = "no entry"
                        .Columns("Packaging").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                    txtfilter.Enabled = True
                    btnFilter.Enabled = True
                    dgitems.Focus()
                Else
                    MessageBox.Show("No item(s) related to the search criteria!")
                    txtitem.Focus()
                    txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Sub LoadBarcode()
        If txtbcode.Text = String.Empty Then
            MessageBox.Show("Enter an item barcode to search.")
            txtbcode.Focus()
            Exit Sub
        Else



            Try
                Dim mgrloaditems As vwBarcodeManager = New vwBarcodeManager()

                Dim cols As vwBarcodeCollection
                mgrloaditems.DataObject.WhereFilter = vwBarcodeData.WhereFilters.barcode
                mgrloaditems.Entity.barcode = Trim(txtbcode.Text)

                cols = mgrloaditems.BuildCollection()
                If mgrloaditems.DataObject.RowsAffected > 0 Then
                    dgitems.DataSource = cols
                    dgitems.Columns(0).Visible = False
                    ''dgitems.Columns(5).Visible = False
                    'dgitems.Columns(6).Visible = False
                    'dgitems.Columns(7).Visible = False
                    'dgitems.Columns(8).Visible = False
                    dgitems.Columns(1).Width = 500
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(6).HeaderText = "Packaging"
                    dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(4).Width = 150
                    dgitems.Columns(6).Width = 100
                    dgitems.Columns(7).Width = 100
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(9).Visible = False
                    dgitems.Columns(10).Visible = False
                    With Me.dgitems
                        .Columns("retail").DefaultCellStyle.Format = "c"
                        .Columns("retail2").DefaultCellStyle.Format = "c"
                        .Columns("retail").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("retail2").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("Available").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        '.DefaultCellStyle.NullValue = "no entry"
                        .Columns("Packaging").DefaultCellStyle.Alignment = _
                            DataGridViewContentAlignment.MiddleRight
                        .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                    txtfilter.Enabled = True
                    btnFilter.Enabled = True
                    dgitems.Focus()
                Else
                    'MessageBox.Show("No item(s) related to the search criteria!")
                    'txtitem.Focus()
                    'txtitem.SelectAll()
                    MoreBarcodes()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub MoreBarcodes()

        Try
            Dim mgrloaditemss As vwBarcodeMoreManager = New vwBarcodeMoreManager()

            Dim cols As vwBarcodeMoreCollection
            mgrloaditemss.DataObject.WhereFilter = vwBarcodeMoreData.WhereFilters.barcode
            mgrloaditemss.Entity.barcode = Trim(txtbcode.Text)

            cols = mgrloaditemss.BuildCollection()
            If mgrloaditemss.DataObject.RowsAffected > 0 Then

                dgitems.DataSource = cols
                dgitems.Columns(0).Visible = False
                ''dgitems.Columns(5).Visible = False
                'dgitems.Columns(6).Visible = False
                'dgitems.Columns(7).Visible = False
                'dgitems.Columns(8).Visible = False
                dgitems.Columns(1).Width = 500
                dgitems.Columns(1).HeaderText = "Item Description"
                dgitems.Columns(2).HeaderText = "Available"
                dgitems.Columns(3).HeaderText = "Retail Price"
                dgitems.Columns(4).HeaderText = "Whole Sale"
                dgitems.Columns(6).HeaderText = "Packaging"
                dgitems.Columns(7).HeaderText = "Barcode"
                dgitems.Columns(2).Width = 100
                dgitems.Columns(3).Width = 150
                dgitems.Columns(4).Width = 150
                dgitems.Columns(6).Width = 100
                dgitems.Columns(7).Width = 100
                dgitems.Columns(5).Visible = False
                dgitems.Columns(8).Visible = False
                dgitems.Columns(9).Visible = False
                dgitems.Columns(10).Visible = False
                With Me.dgitems
                    .Columns("retail").DefaultCellStyle.Format = "c"
                    .Columns("retail2").DefaultCellStyle.Format = "c"
                    .Columns("retail").DefaultCellStyle.Alignment = _
                        DataGridViewContentAlignment.MiddleRight
                    .Columns("retail2").DefaultCellStyle.Alignment = _
                        DataGridViewContentAlignment.MiddleRight
                    .Columns("Available").DefaultCellStyle.Alignment = _
                        DataGridViewContentAlignment.MiddleRight
                    '.DefaultCellStyle.NullValue = "no entry"
                    .Columns("Packaging").DefaultCellStyle.Alignment = _
                        DataGridViewContentAlignment.MiddleRight
                    .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                End With
                txtfilter.Enabled = True
                btnFilter.Enabled = True
                dgitems.Focus()
            Else
                MessageBox.Show("No item(s) related to the search criteria!")
                txtitem.Focus()
                txtitem.SelectAll()
            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SearchItems2()
        If txtitem.Text = String.Empty Then
            MessageBox.Show("Enter an item description to search.")
            txtitem.Focus()
            Exit Sub
        Else

            Dim mgritem As posstocksmanager
            Dim cols As posstocksCollection
            Try
                mgritem = New posstocksmanager()
                mgritem.DataObject.SelectFilter = posstocksData.SelectFilters.All
                mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.Likeitem_desc
                mgritem.Entity.itemdesc = Trim(txtfilter.Text)
                mgritem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc
                cols = mgritem.BuildCollection()
                If mgritem.DataObject.RowsAffected > 0 Then
                    dgitems.DataSource = cols
                    dgitems.Columns(0).Visible = False
                    'dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(1).Width = 500
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(6).HeaderText = "Packaging"
                    dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(4).Width = 150
                    dgitems.Columns(5).Width = 100
                    dgitems.Columns(7).Width = 100
                    dgitems.Focus()
                Else
                    MessageBox.Show("No item(s) related to the search criteria!")
                    txtitem.Focus()
                    txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                '    MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Sub SearchItems()
        If txtitem.Text = String.Empty Then
            MessageBox.Show("Enter an item description to seaarch.")
            txtitem.Focus()
            Exit Sub
        Else

            Dim mgritem As stocksManager
            Dim cols As stocksCollection
            Try
                mgritem = New stocksManager
                mgritem.DataObject.SelectFilter = stocksData.SelectFilters.positems
                'mgritem.DataObject.WhereFilter = stocksData.WhereFilters.Likebarcode
                mgritem.DataObject.WhereFilter = stocksData.WhereFilters.likeitem
                mgritem.Entity.itemdesc = Trim(txtitem.Text)
                mgritem.DataObject.OrderByFilter = stocksData.OrderByFilters.itemdesc
                cols = mgritem.BuildCollection()
                If mgritem.DataObject.RowsAffected > 0 Then
                    dgitems.DataSource = cols
                    dgitems.Columns(0).Visible = False
                    dgitems.Columns(1).Visible = False
                    'dgitems.Columns(1).Width = 500
                    dgitems.Columns(2).HeaderText = "Item Description"
                    dgitems.Columns(3).HeaderText = "Available"
                    dgitems.Columns(4).HeaderText = "Retail Price"
                    dgitems.Columns(8).HeaderText = "Whole Sale"
                    dgitems.Columns(6).HeaderText = "Packaging"
                    dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(2).Width = 500
                    dgitems.Columns(3).Width = 300
                    'dgitems.Columns(4).Width = 400
                    dgitems.Columns(4).Visible = False
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    'dgitems.Columns(7).Visible = False
                    'dgitems.Columns(8).Visible = False
                    'dgitems.Columns(9).Visible = False
                    dgitems.Columns(10).Visible = False
                    dgitems.Columns(11).Visible = False
                    dgitems.Columns(13).Visible = False
                    dgitems.Columns(14).Visible = False
                    dgitems.Columns(15).Visible = False
                    dgitems.Columns(16).Visible = False
                    dgitems.Columns(17).Visible = False
                    dgitems.Columns(18).Visible = False
                    dgitems.Columns(19).Visible = False
                    dgitems.Columns(20).Visible = False
                    dgitems.Columns(21).Visible = False
                    dgitems.Columns(22).Visible = False
                    dgitems.Columns(23).Visible = False
                    dgitems.Columns(24).Visible = False
                    dgitems.Columns(25).Visible = False
                    dgitems.Columns(26).Visible = False
                    dgitems.Columns(27).Visible = False
                    dgitems.Columns(28).Visible = False
                    dgitems.Columns(29).Visible = False
                    dgitems.Columns(30).Visible = False
                    dgitems.Columns(31).Visible = False
                    dgitems.Columns(32).Visible = False
                    dgitems.Focus()
                Else
                    MessageBox.Show("No item(s) related to the search criteria!")
                    txtitem.Focus()
                    txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                '    MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub txtitem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitem.KeyDown
        If e.KeyCode = Keys.Down Then
            dgitems.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            btnSearch.Focus()
        End If
    End Sub
    Private Sub txtitem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtitem.KeyPress
        If e.KeyChar = Chr(13) Then
            DelItems()
            LoadItems()
        End If
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
                'Dim x2 As String = String.Empty
                Dim x2 As Integer = 0
                Dim x3 As Decimal = 0
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
                x2 = CInt(dgitems(2, vRow).Value)
                x3 = CDec(dgitems(3, vRow).Value)
                x4 = CDec(dgitems(4, vRow).Value)
                x5 = CInt(dgitems(6, vRow).Value)
                x6 = CStr(dgitems(7, vRow).Value)
                vStckid = vint
                vItem = x1 '
                vAvlbl = x2
                vbocde = x6
                vPrice = x3
                vWPrice = x4
                vInnerQty = x5
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub frmItemSearch_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmItemSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtitem.Text = frmDelivery.strItemvar
        txtitem.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        txtitem.Focus()
        txtitem.SelectAll()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        txtfilter.Focus()
        txtfilter.SelectAll()
    End Sub

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchItems2()
        End If
    End Sub

    Private Sub txtbcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbcode.KeyDown
        If e.KeyCode = Keys.Down Then
            dgitems.Focus()
        End If
        'If e.KeyCode = Keys.Right Then
        '    btnSearch.Focus()
        'End If
    End Sub

    Private Sub txtbcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbcode.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadBarcode()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtbcode.Focus()
        txtbcode.SelectAll()
    End Sub

    
    Private Sub txtitem_TextChanged(sender As Object, e As EventArgs) Handles txtitem.TextChanged

    End Sub

    Private Sub txtbcode_TextChanged(sender As Object, e As EventArgs) Handles txtbcode.TextChanged

    End Sub

    Private Sub txtfilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfilter.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            dgitems.Focus()
        End If
    End Sub
End Class