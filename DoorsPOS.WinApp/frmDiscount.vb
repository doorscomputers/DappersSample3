Public Class frmDiscount

    Private Sub ceDisc_KeyDown(sender As Object, e As KeyEventArgs) Handles ceDisc.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            frmPOS.vdisc = 0
            frmPOS.vdiscamnt = 0
            Me.Close()
        End If
    End Sub

    Private Sub ceDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ceDisc.KeyPress
        Dim ansstr As Integer = 0
        Dim percentamnt As Decimal = 0
        'Dim origtotal As Decimal = 0
        If e.KeyChar = Chr(13) Then


            'If e.KeyCode = Keys.Enter Then
            If ceDisc.Value < 0 Then
                ceDisc.Value = 0
                MessageBox.Show("Discount should be a positive number.")
                Exit Sub
            End If
            ansstr = CInt(MessageBox.Show("Select Yes for Percent(%) Discount OR No for Amount Discount", "Type of Discount", MessageBoxButtons.YesNo))
            If ceDisc.Value = 0 Then
                frmPOS.vtotalsales = 0
                Me.Close()
                Exit Sub
            End If

            If ansstr = 6 Then
                Try
                    If ceDisc.Value >= 100 Then
                        MessageBox.Show("Percent Discount must not be greater than or equal to 100%")
                        Exit Sub
                    End If

                    frmPOS.vdisc = CInt(ceDisc.Value)
                    percentamnt = CDec(CDec(frmPOS.vtotalsales) * (CInt(ceDisc.Value) / 100)) 'CDec((CDec(frmPOS.vtotalsales) / 1.12) * (CInt(ceDisc.Value) / 100))
                    frmPOS.vdiscamnt = percentamnt
                    frmPOS.vtotalsales = CDec(frmPOS.vtotalsales - percentamnt) ' CDec((frmPOS.vtotalsales / 1.12) - percentamnt)
                    vpTotalSales = CDec(frmPOS.vtotalsales) 'frmPOS.vtotalsales - percentamnt
                    'frmPOS.LessDiscount()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            Else
                Try
                    If ceDisc.Value > frmPOS.vtotalsales Then
                        MessageBox.Show("Amount Discount must not be greater than or equal to the Total Amount to be paid!")
                        Exit Sub
                    End If
                    frmPOS.vdiscamnt = CDec(ceDisc.Value)
                    frmPOS.vtotalsales = frmPOS.vtotalsales - frmPOS.vdiscamnt
                    vpTotalSales = CDec(frmPOS.vtotalsales) 'CDec(frmPOS.vtotalsales - frmPOS.vdiscamnt)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If
            Me.Close()

        End If
    End Sub

    Private Sub frmDiscount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class