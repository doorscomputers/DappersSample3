Module VarsModule
    Public TotalSold As Decimal = 0
    Public QtySold As Integer = 0
    Public QtyRefund As Integer = 0
    Public payconfirm As Boolean = False
    Public vpTotalSales As Decimal = 0
    Public vEmpID As Integer = 0
    Public vSalesNum As Integer = 0

    Public Sub OpenCashdrawer()
        'Modify DrawerCode to your receipt printer open drawer code
        Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
        'Modify PrinterName to your receipt printer name
        Dim PrinterName As String = "EPSON TMU220"

        RawPrinter.PrintRaw(PrinterName, DrawerCode)
    End Sub
End Module
