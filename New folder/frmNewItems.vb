Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation

Public Class frmNewItems
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
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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
        ceCost.Enabled = True
        ceRetail.Enabled = True
        ceWholesale.Enabled = True
        ceMin.Enabled = True
        ceMax.Enabled = True
        GroupControl1.Enabled = True

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
        ceCost.Enabled = False
        ceRetail.Enabled = False
        ceWholesale.Enabled = False
        ceMin.Enabled = False
        ceMax.Enabled = False
        btnClose.Enabled = False
        GroupControl1.Enabled = False
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
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtBarcode.Text = String.Empty Or txtItem.Text = String.Empty Or ceCost.Value < 0 Or ceRetail.Value <= 0 Or ceWholesale.Value < 0 Then
            MessageBox.Show("Fill up the required information before saving.(Itemcode,ItemDescription,Cost,Retail and Wholesale.")
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableCtrols()
        btnNew.Focus()
    End Sub

    Private Sub txtBarcode_LostFocus(sender As Object, e As EventArgs) Handles txtBarcode.LostFocus
        If txtBarcode.Text <> "" Then
            Try
            Dim mgrbcode As stocksManager = New stocksManager()
            mgrbcode.DataObject.SelectFilter = stocksData.SelectFilters.ListBox
            mgrbcode.DataObject.WhereFilter = stocksData.WhereFilters.barcode
            mgrbcode.Entity.barcode = Trim(txtBarcode.Text)
            mgrbcode.DataObject.Load()
                If mgrbcode.DataObject.RowsAffected > 0 Then
                    MessageBox.Show("Itemcode Already exist", "Duplicate Itemcode found")
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub txtItem_LostFocus(sender As Object, e As EventArgs) Handles txtItem.LostFocus
        If Trim(txtItem.Text) <> "" Then
            Try
                Dim mgrdesc As stocksManager = New stocksManager()
                mgrdesc.DataObject.SelectFilter = stocksData.SelectFilters.All
                mgrdesc.DataObject.WhereFilter = stocksData.WhereFilters.items
                mgrdesc.Entity.itemdesc = Trim(txtItem.Text)
                mgrdesc.DataObject.Load()
                If mgrdesc.DataObject.RowsAffected > 0 Then
                    MessageBox.Show("Item Description Already exist", "Duplicate Item Desc found")
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
End Class