Public Class frmCustSearch
    Public vCustid As Integer = 0
    Public vLname As String = String.Empty
    Public vFname As String = String.Empty

    Private Sub frmCustSearch_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCustSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            MessageBox.Show("Please Note that no customer is selected when you pressed the ESC key!")
            vCustid = 1
            vLname = "CASH"
            vFname = "CASH"
            frmPOS.cmbPaymentType.Text = "CASH"

            Me.Close()
        End If
    End Sub

    Private Sub frmCustSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLastname.Focus()
    End Sub

    Sub LoadCust()
        If txtLastname.Text = String.Empty Then
            MessageBox.Show("Enter a lastname to seaarch !")
            txtLastname.Focus()
            Exit Sub
        Else

            Dim mgrmembers As membersManager
            Dim cols As membersCollection
            Try
                mgrmembers = New membersManager
                mgrmembers.DataObject.SelectFilter = membersData.SelectFilters.ListBox
                mgrmembers.DataObject.WhereFilter = membersData.WhereFilters.Likelastname
                mgrmembers.Entity.lastname = txtLastname.Text.ToString
                mgrmembers.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
                cols = mgrmembers.BuildCollection()
                If mgrmembers.DataObject.RowsAffected > 0 Then
                    dgcustomer.DataSource = cols
                    dgcustomer.Columns(0).Width = 0
                    dgcustomer.Columns(1).Width = 300
                    dgcustomer.Columns(2).Width = 300
                    dgcustomer.Columns(3).Width = 50

                    dgcustomer.Focus()
                Else
                    MessageBox.Show("No customers related to the search criteria!")
                End If

            Catch ex As PDSAValidationException
                '    MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadCust()
    End Sub

    Private Sub txtLastname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLastname.KeyDown
        If e.KeyCode = Keys.Down Then
            dgcustomer.Focus()
        End If
        If e.KeyCode = Keys.Right Then
            btnSearch.Focus()
        End If
    End Sub

    Private Sub txtLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadCust()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Me.Close()
    End Sub

    Private Sub dgcustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles dgcustomer.KeyDown
        If e.KeyCode = Keys.Enter Then

            If dgcustomer.Rows.Count < 1 Then
                Exit Sub
            End If
            Try
                Dim vRow As Integer = 0
                Dim vint As Integer = 0
                Dim x1 As String = String.Empty
                Dim x2 As String = String.Empty
                vRow = dgcustomer.CurrentRow.Index
                vint = CInt(dgcustomer(0, vRow).Value)
                x1 = CStr(dgcustomer(1, vRow).Value)
                x2 = CStr(dgcustomer(2, vRow).Value)
                vCustid = vint
                vLname = x1
                vFname = x2

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtLastname.Focus()
    End Sub
End Class