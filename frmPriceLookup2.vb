Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmPriceLookup2
    Public vItem As String = String.Empty
    Public vStckid As Integer = 0
    Public vPrice As Decimal = 0
    Public vWPrice As Decimal = 0
    Public vbocde As String = String.Empty
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
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(1).Width = 500
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(4).Width = 150
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
    Sub LoadItemsbyBarcode()
        If txtBarcode.Text = String.Empty Then
            MessageBox.Show("Barcode is Blank, Scan another or proceed to Item Search")
            txtitem.Focus()
            Exit Sub
        Else

            'Dim mgrloaditembc As vwStocksManager

            Try

                Dim mgritems As vwStocksLookupManager = New vwStocksLookupManager()
                Dim colss As vwStocksLookupCollection
                mgritems.DataObject.WhereFilter = vwStocksLookupData.WhereFilters.barcode
                mgritems.Entity.barcode = Trim(txtBarcode.Text)
                mgritems.DataObject.OrderByFilter = vwStocksLookupData.OrderByFilters.barcode
                colss = mgritems.BuildCollection()
                If mgritems.DataObject.RowsAffected > 0 Then
                    dgitems.DataSource = colss
                    'dgitems.Columns(0).Visible = False
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    'dgitems.Columns(8).Visible = False
                    dgitems.Columns(0).Width = 160
                    dgitems.Columns(1).Width = 380
                    dgitems.Columns(0).HeaderText = "Barcode"
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 135
                    dgitems.Columns(4).Width = 135

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
                        .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With



                    'dgitems.Columns(5).Width = 0
                    'txtfilter.Enabled = True
                    'btnFilter.Enabled = True
                    'dgitems.Focus()
                    txtBarcode.Focus()
                    txtBarcode.SelectAll()
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
    Sub SearchItems2()
        If txtitem.Text = String.Empty Then
            MessageBox.Show("Enter an item description to seaarch.")
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
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(1).Width = 500
                    dgitems.Columns(1).HeaderText = "Item Description"
                    dgitems.Columns(2).HeaderText = "Available"
                    dgitems.Columns(3).HeaderText = "Retail Price"
                    dgitems.Columns(4).HeaderText = "Whole Sale"
                    dgitems.Columns(2).Width = 100
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(4).Width = 150
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
                    dgitems.Columns(2).Width = 500
                    dgitems.Columns(3).Width = 300
                    'dgitems.Columns(4).Width = 400
                    dgitems.Columns(4).Visible = False
                    dgitems.Columns(5).Visible = False
                    dgitems.Columns(6).Visible = False
                    'dgitems.Columns(7).Visible = False
                    dgitems.Columns(8).Visible = False
                    dgitems.Columns(9).Visible = False
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

    Private Sub frmPriceLookup2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPriceLookup2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmPriceLookup2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadItemsbyBarcode()
        End If
    End Sub

    Private Sub txtBarcode_EditValueChanged(sender As Object, e As EventArgs) Handles txtBarcode.EditValueChanged

    End Sub

    Private Sub txtitem_TextChanged(sender As Object, e As EventArgs) Handles txtitem.TextChanged

    End Sub
End Class