Public Class xrReceiptTodaRaba

    Private Sub XrLabel6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel6.BeforePrint
        If XrLabel29.Text = "CASH" Then
            XrLabel33.Text = "CASH"
            XrLabel6.Text = "OR#:"
        End If

        If XrLabel29.Text = "VOID-CASH" Then
            XrLabel6.Text = "VOID OR Number:"
        End If

        If XrLabel29.Text = "VOID-CREDIT" Then
            XrLabel6.Text = "VOID Charge Inv. #:"
        End If


        If XrLabel29.Text = "CREDIT" Then
            XrLabel29.Text = "Purchase Order"
            XrLabel33.Text = "Purchase Order"
            XrLabel6.Text = "Charge Inv. #:"
            xRLabel31.Text = " "
            XrLabel18.Text = "0"
        End If

    End Sub


End Class