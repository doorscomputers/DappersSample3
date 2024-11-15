Public Class frmSupplierSearch

    Public vSupplier As String = String.Empty
    Public vSupCode As Integer = 0
    Dim mgrSupplier As suppliersManager
    Dim cols As suppliersCollection
    
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchSuppliers()
        'txtSupplier.Focus()
        'txtSupplier.SelectAll()
    End Sub
    Sub SearchSuppliers()
        If txtSupplier.Text = String.Empty Then
            MessageBox.Show("Enter a Supplier to seaarch.")
            txtSupplier.Focus()
            Exit Sub
        Else

            
            Try
                mgrSupplier = New suppliersManager()
                mgrSupplier.DataObject.SelectFilter = suppliersData.SelectFilters.ListBox
                mgrSupplier.DataObject.WhereFilter = suppliersData.WhereFilters.Likesupplier
                mgrSupplier.Entity.supplier = Trim(txtSupplier.Text)
                mgrSupplier.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier
                'mgrSupplier.DataObject.Load()
                cols = mgrSupplier.BuildCollection()
                If mgrSupplier.DataObject.RowsAffected > 0 Then
                    dgSuppliers.DataSource = cols
                    dgSuppliers.Columns(0).Visible = False
                    dgSuppliers.Columns(1).Visible = True
                    'dgitems.Columns(1).Width = 500
                    dgSuppliers.Columns(1).HeaderText = "Supplier"
                    dgSuppliers.Columns(1).Width = 700
                    'dgSuppliers.Columns(3).Width = 300
                    'dgitems.Columns(4).Width = 400
                    dgSuppliers.Columns(2).Visible = False
                    dgSuppliers.Columns(3).Visible = False
                    dgSuppliers.Columns(4).Visible = False
                    dgSuppliers.Columns(5).Visible = False
                    dgSuppliers.Columns(6).Visible = False
                    dgSuppliers.Columns(7).Visible = False
                    dgSuppliers.Columns(8).Visible = False
                    dgSuppliers.Columns(9).Visible = False
                    dgSuppliers.Columns(10).Visible = False
                    dgSuppliers.Columns(11).Visible = False
                    dgSuppliers.Columns(12).Visible = False
                    dgSuppliers.Columns(13).Visible = False
                    dgSuppliers.Columns(14).Visible = False
                    dgSuppliers.Columns(15).Visible = False
                    dgSuppliers.Columns(16).Visible = False
                    dgSuppliers.Columns(17).Visible = False
                    dgSuppliers.Columns(18).Visible = False
                    
                    dgSuppliers.Focus()
                Else
                    MessageBox.Show("No Supplier(s) related to the search criteria!")
                    txtSupplier.Focus()
                    txtSupplier.SelectAll()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub dgSuppliers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgSuppliers.KeyDown
        If e.KeyCode = Keys.Enter Then

            If dgSuppliers.Rows.Count < 1 Then
                Exit Sub
            End If
            Try
                Dim vRow As Integer = 0
                Dim vint As Integer = 0
                Dim x1 As String = String.Empty


                vRow = dgSuppliers.CurrentRow.Index
                vint = CInt(dgSuppliers(0, vRow).Value)
                x1 = CStr(dgSuppliers(1, vRow).Value)

                vSupCode = vint
                vSupplier = x1

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
        txtSupplier.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnSup.Click
        txtSupplier.Focus()
        txtSupplier.SelectAll()
    End Sub

    Private Sub txtSupplier_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtSupplier.KeyDown
        If e.KeyCode = Keys.Down Then
            dgSuppliers.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            btnSearch.Focus()
        End If
    End Sub
    Private Sub txtSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplier.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchSuppliers()
        End If
    End Sub
End Class

