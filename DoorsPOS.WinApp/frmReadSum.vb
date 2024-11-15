Imports PDSA.DataLayer.DataClasses

Public Class frmReadSum
    Private Sub frmReadSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btmClose_Click(sender As Object, e As EventArgs) Handles btmClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim tran As PDSATransaction
            tran = New PDSATransaction()
            Dim rmmgr As ReadingSumManager = New ReadingSumManager()
            rmmgr.DataObject.TransactionType = PDSATransactionType.Insert
            rmmgr.Entity.ReadingDate = CDate(deDate.EditValue)
            rmmgr.Entity.Location = cmbBranch.Text
            rmmgr.Entity.Cashier = cmbCashier.Text
            rmmgr.Entity.TotalSales = CDec(ceTotalSales.Value)
            rmmgr.Entity.BegCash = CDec(ceBegCash.Value)
            rmmgr.Entity.CashEnd = CDec(ceCashEnd.Value)
            rmmgr.Entity.xShort = CDec(ceShort.Value)
            rmmgr.Entity.OverAmount = CDec(ceOver.Value)
            rmmgr.Entity.PettyCash = CDec(cepc.Value)
            rmmgr.Entity.AddFund = CDec(ceaf.Value)
            rmmgr.Entity.Remittance = CDec(ceri.Value)

            tran.Add(rmmgr.DataObject)
            tran.Execute()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class