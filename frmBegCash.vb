Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports PDSA.WinForms.Forms
Imports PDSA.WinForms.Security

Public Class frmBegCash
    Public WithEvents Trantr As PDSATransaction
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        btnOk_ClickExtracted()
    End Sub
    Sub btnOk_ClickExtracted()
        If cebegcash.Value > 0 Then
            Dim mgrtr As tblreadingManager = New tblreadingManager()
            Dim col As New tblreadingCollection
            Trantr = New PDSATransaction()
            Dim vReadingNoT1 As Integer = 0
            Try

                Dim spGetReadingNoT1 As spGetReadingNoManager
                Dim transpGetReadingNo As PDSATransaction = New PDSATransaction()
                spGetReadingNoT1 = New spGetReadingNoManager()
                transpGetReadingNo.Add(spGetReadingNoT1.DataObject)
                transpGetReadingNo.Execute()
                vReadingNoT1 = 0
                vReadingNoT1 = Convert.ToInt32(spGetReadingNoT1.DataObject.Entity.ReadingNo)


                mgrtr.Entity.datereading = DateAndTime.Now
                mgrtr.Entity.cashier = PDSAAppConfig.CurrentLoginID
                mgrtr.Entity.begincash = CDec(cebegcash.Value)
                mgrtr.Entity.terminal = 1
                mgrtr.Entity.readingno = vReadingNoT1
                Trantr.Add(mgrtr.DataObject)
                Trantr.Execute()

                Dim frm As New frmPOS
                frm.Show()
                frm = Nothing
                Me.Close()
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            Me.Close()
        Else
            MessageBox.Show("Enter a Cash value Greater than Zero.")
            cebegcash.Focus()
        End If
    End Sub

    Private Sub frmBegCash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBegCash_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PDSAAppConfig.CurrentLoginID <> "Admin" Then
            cmbUserType.Text = "Cashier"
        Else
            cmbUserType.Text = "Admin"
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cebegcash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cebegcash.KeyPress
        If e.KeyChar = Chr(13) Then
            btnOk_ClickExtracted()
            Me.Close()
        End If
    End Sub

    Private Sub cebegcash_EditValueChanged(sender As Object, e As EventArgs) Handles cebegcash.EditValueChanged

    End Sub
End Class