Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Dapper
Imports Z.Dapper.Plus
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTestDapper
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim barcode As String = TextEdit1.Text
        Dim stock As ClassStock = GetStockByBarcode(barcode)

        If stock IsNot Nothing Then
            ' If a record is found, assign values to TextEdit2 and TextEdit3
            TextEdit2.Text = stock.barcode
            TextEdit3.Text = stock.item_desc
        Else
            'MessageBox.Show("Stock not found.")
            MessageBox.Show("Stock not found.")
        End If
    End Sub


    Private Function GetStockByBarcode(barcode As String) As ClassStock
        Dim connectionString As String = "Server=DOORSCOMPUTERS\SQLEXPRESS;Database=doorspos;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM stocks WHERE barcode = @barcode AND active = 1"
            Return connection.Query(Of ClassStock)(sql, New With {.barcode = barcode}).SingleOrDefault()
        End Using
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim searchText As String = TextEdit1.Text
        Dim stocks As List(Of ClassStock) = GetStocksByItemDesc(searchText)

        If stocks IsNot Nothing AndAlso stocks.Count > 0 Then
            ' Bind the result to the GridControl
            'GridControl1.DataSource = stocks
            'CustomizeGridColumns()
            GridControl1.DataSource = stocks
            CustomizeGridColumns()
        Else
            MessageBox.Show("Stock not found.")
            ' Clear the grid if no stock found
            GridControl1.DataSource = Nothing
        End If
    End Sub

    Private Function GetStocksByItemDesc(searchText As String) As List(Of ClassStock)
        Dim connectionString As String = "Server=DOORSCOMPUTERS\SQLEXPRESS;Database=doorspos;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM stocks WHERE item_desc LIKE @item_desc AND active = 1"
            Return connection.Query(Of ClassStock)(sql, New With {.item_desc = "%" & searchText & "%"}).ToList()
        End Using
    End Function

    Private Sub CustomizeGridColumns()
        Dim gridView As GridView = CType(GridControl1.MainView, GridView)

        ' Loop through all columns and hide them by default
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
            col.Visible = False
        Next

        ' Set the specific columns to be visible and rename headers
        gridView.Columns("barcode").Visible = True
        gridView.Columns("barcode").Caption = "Barcode"
        gridView.Columns("item_desc").Visible = True
        gridView.Columns("item_desc").Caption = "Item Description"
        gridView.Columns("available").Visible = True
        gridView.Columns("available").Caption = "Qty On Hand"
        gridView.Columns("available").OptionsColumn.AllowEdit = False ' Make this column read-only
        gridView.Columns("retail").Visible = True
        gridView.Columns("retail").Caption = "Retail"
        gridView.Columns("retail2").Visible = True
        gridView.Columns("retail2").Caption = "Wholesale"

        ' Optionally, set the order of the columns if needed
        gridView.Columns("barcode").VisibleIndex = 0
        gridView.Columns("item_desc").VisibleIndex = 1
        gridView.Columns("available").VisibleIndex = 2
        gridView.Columns("retail").VisibleIndex = 3
        gridView.Columns("retail2").VisibleIndex = 4
    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim gridView As GridView = CType(GridControl1.MainView, GridView)
        If e.FocusedRowHandle >= 0 Then
            Dim selectedRow As ClassStock = CType(gridView.GetRow(e.FocusedRowHandle), ClassStock)
            If selectedRow IsNot Nothing Then
                TextEdit2.Text = selectedRow.barcode
                TextEdit3.Text = selectedRow.item_desc
                TextEdit4.Text = selectedRow.available.ToString()
                TextEdit5.Text = selectedRow.retail.ToString()
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim gridView As GridView = CType(GridControl1.MainView, GridView)
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim stocks As List(Of ClassStock) = CType(GridControl1.DataSource, List(Of ClassStock))
        SaveStocksToDatabase1(stocks)
    End Sub

    Private Sub SaveStocksToDatabase1(stocks As List(Of ClassStock))
        Dim connectionString As String = "Server=DOORSCOMPUTERS\SQLEXPRESS;Database=doorspos;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    For Each stock As ClassStock In stocks
                        Dim sql As String = "
                            UPDATE stocks 
                            SET barcode = @barcode, item_desc = @item_desc, available = @available, retail = @retail, retail2 = @retail2
                            WHERE stckid = @stckid"
                        connection.Execute(sql, stock, transaction)
                    Next
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("An error occurred while saving data: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim gridView As GridView = CType(GridControl1.MainView, GridView)
        gridView.PostEditor()
        gridView.UpdateCurrentRow()

        Dim stocks As List(Of ClassStock) = CType(GridControl1.DataSource, List(Of ClassStock))
        SaveStocksToDatabase2(stocks)
    End Sub

    Private Sub SaveStocksToDatabase2(stocks As List(Of ClassStock))
        Dim connectionString As String = "Server=DOORSCOMPUTERS\SQLEXPRESS;Database=doorspos;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    For Each stock As ClassStock In stocks
                        Dim sql As String = "
                            UPDATE stocks 
                            SET barcode = @barcode, item_desc = @item_desc, available = @available, retail = @retail, retail2 = @retail2
                            WHERE stckid = @stckid"
                        connection.Execute(sql, stock, transaction)
                    Next
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("An error occurred while saving data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class