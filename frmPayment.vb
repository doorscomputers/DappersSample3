Public Class frmPayment
    Public Shared vTender As Decimal = 0
    Private Sub ceTendered_KeyDown(sender As Object, e As KeyEventArgs) Handles ceTendered.KeyDown
        If e.KeyCode = Keys.Enter Then
            payconfirm = True
            Dim vtendered As Decimal = CDec(ceTendered.Value)
            Dim vtotamnt As Decimal = CDec(txtTotAmnt.Text)
            Dim vchange As Decimal = 0

            If vtendered < vtotamnt Then
                MessageBox.Show("Payment must be greater than or equal to the Total Amount Purchased!")
                ceTendered.Focus()
                Exit Sub
            Else
                Try
                    vchange = vtendered - vtotamnt
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
            'Call frmPOS.TakePayment()
            CallExtracted()
        End If

        If e.KeyCode = Keys.Escape Then
            'vTender = CDec(ceTendered.Value)
            vTender = 0
            Me.Close()
            'Me.Hide()
            frmPOS.txtTendered.Text = "0"
            frmPOS.lblChange.Text = "0"
            frmPOS.txtitem.Focus()
            'frmPOS.Activate()

        End If

    End Sub
    Sub CallExtracted()
        vTender = CDec(ceTendered.Value)

        frmPOS.vtendered = FormatNumber(CStr(ceTendered.Value))
        frmPOS.vchange = FormatNumber(CStr(txtChange.Text))
        'ne comment, uncomment if something goes wrong
        ' just to prevent form from closing so that cashiers can see the change
        'and amount to be paid and tendered
        Me.Close()

        'frmPOS.Activate()

    End Sub

    Sub CallExtracted2()
        vTender = 0

        frmPOS.vtendered = FormatNumber(CStr(0))
        frmPOS.vchange = FormatNumber(CStr(0))
        Me.Close()

        frmPOS.Activate()

    End Sub
    Private Sub frmPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                e.Handled = True
                ceTendered.Value = 100
                ceTendered.Focus()
                'ceTendered.SelectAll()
            Case Keys.F2
                e.Handled = True
                ceTendered.Value = 200
                ceTendered.Focus()
                'ceTendered.SelectAll()
            Case Keys.F3
                e.Handled = True
                ceTendered.Value = 300
                ceTendered.Focus()
                'ceTendered.SelectAll()
            Case Keys.F4
                e.Handled = True
                ceTendered.Value = 400
                ceTendered.Focus()

            Case Keys.F5
                e.Handled = True
                ceTendered.Value = 500
                ceTendered.Focus()

            Case Keys.F6
                e.Handled = True
                ceTendered.Value = 600
                ceTendered.Focus()

            Case Keys.F7
                e.Handled = True
                ceTendered.Value = 700
                ceTendered.Focus()

            Case Keys.F8
                e.Handled = True
                ceTendered.Value = 800
                ceTendered.Focus()

            Case Keys.F9
                e.Handled = True
                ceTendered.Value = 900
                ceTendered.Focus()

            Case Keys.F10
                e.Handled = True
                ceTendered.Value = 1000
                ceTendered.Focus()

        End Select
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''txtTotAmnt.Text = FormatNumber(CStr(frmPOS.Tots))
        'txtTotAmnt.Text = FormatNumber(CStr(vpTotalSales))
        ''txtTotAmnt.Text = FormatNumber(CStr(frmPOS.vtotalsales))
        'ceTendered.Value = vpTotalSales 'frmPOS.Tots
        txtChange.Text = "0"
        ceTendered.Focus()
        ceTendered.SelectAll()
    End Sub

    Private Sub ceTendered_EditValueChanged(sender As Object, e As EventArgs) Handles ceTendered.EditValueChanged
        Dim vtenderedd As Decimal = CDec(ceTendered.Value)
        Dim vtotamntt As Decimal = CDec(txtTotAmnt.Text)
        Dim vchangee As Decimal = 0
        Try
            vchangee = vtenderedd - vtotamntt
            txtChange.Text = FormatNumber(CStr(vchangee))
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Class