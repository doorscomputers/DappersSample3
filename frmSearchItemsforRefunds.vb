Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DevExpress.Utils

Public Class frmSearchItemsforRefunds


    Protected Friend Sub LoadItems()
        If txtitem.Text = String.Empty Then
            MessageBox.Show("Enter an item description to seaarch.")
            txtitem.Focus()
            Exit Sub
        Else
            Dim TranspStock As New PDSATransaction()
            Dim mgrloaditem As spgetsaleslast30daysManager

            Try

                mgrloaditem = New spgetsaleslast30daysManager()
                mgrloaditem.Entity.Itemdescription = Trim(txtItem.Text)
                TranspStock.Add(mgrloaditem.DataObject)
                TranspStock.Execute()
                GridControl1.DataSource = mgrloaditem.DataObject.GetDataSet.Tables(0)
                gridView1.Columns(0).Visible = False
                gridView1.Columns("categoryid").Visible = False
                gridView1.Columns("catgory").Visible = False
                gridView1.Columns("mowd").Visible = False
                gridView1.Columns("dtInsert_dt").Visible = False
                gridView1.Columns(1).Width = 350
                gridView1.Columns(1).Caption = "Items Bought"
                gridView1.Columns(2).Caption = "Price"
                gridView1.Columns(3).Caption = "Qty"
                gridView1.Columns(4).Caption = "Amount"
                gridView1.Columns(7).Caption = "Sales No."
                gridView1.Columns(8).Caption = "Date Sold"

                gridView1.Columns(2).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(4).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(5).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(8).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(7).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(7).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                gridView1.Columns(8).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                gridView1.Columns(2).DisplayFormat.FormatType = FormatType.Numeric
                gridView1.Columns(2).DisplayFormat.FormatString = "n2"

                gridView1.Columns(3).DisplayFormat.FormatType = FormatType.Numeric
                gridView1.Columns(3).DisplayFormat.FormatString = "n2"

                gridView1.Columns(4).DisplayFormat.FormatType = FormatType.Numeric
                gridView1.Columns(4).DisplayFormat.FormatString = "n2"

                'Dim mgritem As spgetsaleslast30daysManager = New spgetsaleslast30daysManager()
                'Dim cols As posstocksCollection
                'mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.cashier
                'mgritem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                'mgritem.Entity.itemdesc = Trim(txtitem.Text)
                'mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc
                'cols = mgritem.BuildCollection()
                'If mgritem.DataObject.RowsAffected > 0 Then


                'Else

                'End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnButton1_Click(sender As Object, e As EventArgs) Handles btnButton1.Click
        LoadItems()
    End Sub

    Private Sub lblLabel1_Click(sender As Object, e As EventArgs) Handles lblLabel1.Click

    End Sub

    Private Sub txtItem_EditValueChanged(sender As Object, e As EventArgs) Handles txtItem.EditValueChanged

    End Sub

    Private Sub txtItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadItems()
            GridControl1.Focus()
        End If
    End Sub
End Class