Public Class frmRefund
    Private Sub frmRefund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub
    Private Sub LoadCustomers()
        Try
            Dim mgrs As membersManager = New membersManager()
            mgrs.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
            Dim cols As membersCollection
            cols = mgrs.BuildCollection()
            leSupplier.Properties.DisplayMember = "lastname"
            leSupplier.Properties.ValueMember = "CustID"
            leSupplier.Properties.DataSource = cols
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

    End Sub
End Class