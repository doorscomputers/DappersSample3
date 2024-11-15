<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrSalesHistory
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrSalesHistory))
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xRLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SalesDateFrom = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SalesDateTo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.taym = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CashierCaps = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalBill = New DevExpress.XtraReports.UI.CalculatedField()
        Me.VAT = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Changess = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GT = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SubTotss = New DevExpress.XtraReports.UI.CalculatedField()
        Me.nvat = New DevExpress.XtraReports.UI.CalculatedField()
        Me.sumnvat = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalculatedField2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.vatsales = New DevExpress.XtraReports.UI.CalculatedField()
        Me.vnv = New DevExpress.XtraReports.UI.CalculatedField()
        Me.FL = New DevExpress.XtraReports.UI.CalculatedField()
        Me.VwReceiptTableAdapter = New DoorsPOS.WinApp.dsvwReceiptTableAdapters.vwReceiptTableAdapter()
        Me.fullname = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DsSalesArchive1 = New DoorsPOS.WinApp.dsSalesArchive()
        Me.VwSalesArchiveTableAdapter = New DoorsPOS.WinApp.dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter()
        Me.full = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotBill = New DevExpress.XtraReports.UI.CalculatedField()
        Me.VAT2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DsSalesArchive1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel12, Me.XrLabel11, Me.XrLabel15})
        Me.Detail.HeightF = 15.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[price]")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(121.6875!, 0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(45.20836!, 15.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel14.TextFormatString = "{0:n2}"
        '
        'XrLabel12
        '
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[item_desc]")})
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(30.22919!, 0!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(88.52081!, 15.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")})
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(171.2708!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(30.62499!, 15.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[det_amnt]")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(201.8959!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(61.45834!, 15.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel15.TextFormatString = "{0:n2}"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 11.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 9.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel23, Me.XrLabel22, Me.XrLabel43, Me.XrLabel52, Me.XrLabel51, Me.XrLabel49, Me.XrLabel48, Me.XrLabel47, Me.XrLabel46, Me.XrLabel32, Me.XrLabel45, Me.XrLabel44, Me.XrLabel41, Me.XrLabel36, Me.XrLine1, Me.XrLabel30, Me.xRLine7, Me.XrLabel39, Me.XrLabel38, Me.XrLabel37, Me.XrLabel26})
        Me.GroupFooter1.HeightF = 149.6876!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLine3
        '
        Me.XrLine3.LineStyle = DevExpress.Drawing.DXDashStyle.Dot
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 2.979152!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(232.4793!, 2.000061!)
        '
        'XrLabel23
        '
        Me.XrLabel23.AutoWidth = True
        Me.XrLabel23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([vwReceipt.item_desc])")})
        Me.XrLabel23.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 4.979213!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(106.0213!, 17.70834!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel23.Summary = XrSummary1
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel23.TextFormatString = "-----{0} Items----"
        '
        'XrLabel22
        '
        Me.XrLabel22.AutoWidth = True
        Me.XrLabel22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([qty])")})
        Me.XrLabel22.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(158.3539!, 4.979213!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(106.0213!, 17.70834!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel22.Summary = XrSummary2
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel22.TextFormatString = "-----{0} Total Count----"
        '
        'XrLabel43
        '
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[exempt]")})
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(176.707!, 107.0627!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(84.77159!, 17.70834!)
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel43.TextFormatString = "{0:n2}"
        '
        'XrLabel52
        '
        Me.XrLabel52.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totsales]")})
        Me.XrLabel52.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(175.8743!, 40.3959!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(87.45967!, 17.70833!)
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel52.TextFormatString = "{0:n2}"
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(144.7911!, 89.35432!)
        Me.XrLabel51.Multiline = True
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(10.85323!, 17.70834!)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = ":"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(144.7911!, 126.8543!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(10.85323!, 17.70834!)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = ":"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel48
        '
        Me.XrLabel48.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(144.7911!, 71.64593!)
        Me.XrLabel48.Multiline = True
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(10.85323!, 17.70834!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = ":"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(144.7911!, 107.0627!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(10.85323!, 17.70834!)
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = ":"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel46
        '
        Me.XrLabel46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotBill]")})
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(176.4986!, 71.64593!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(84.97998!, 17.70834!)
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel46.TextFormatString = "{0:n2}"
        '
        'XrLabel32
        '
        Me.XrLabel32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VAT2]")})
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(176.3111!, 89.35432!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(85.16751!, 17.70834!)
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel32.TextFormatString = "{0:n2}"
        '
        'XrLabel45
        '
        Me.XrLabel45.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.0!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 89.35432!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(111.1352!, 17.70833!)
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "VAT 12%"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel44
        '
        Me.XrLabel44.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(226.2498!, 126.8543!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(35.22876!, 17.70834!)
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "0.00"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel41
        '
        Me.XrLabel41.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 8.5!)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 126.8543!)
        Me.XrLabel41.Multiline = True
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(105.0003!, 17.70833!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "VAT-Zero Rated Sale"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 107.0627!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(108.979!, 17.70833!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "VAT-Exempt Sale"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LineStyle = DevExpress.Drawing.DXDashStyle.Dot
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 58.10423!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(234.7914!, 2.083336!)
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.0!)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 71.64593!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(106.0213!, 17.70834!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "VATable Sale"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xRLine7
        '
        Me.xRLine7.LocationFloat = New DevExpress.Utils.PointFloat(23.7906!, 147.6875!)
        Me.xRLine7.Name = "xRLine7"
        Me.xRLine7.SizeF = New System.Drawing.SizeF(237.688!, 2.000061!)
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 40.3959!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(116.062!, 17.70833!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Total Sale"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[disc_amnt]")})
        Me.XrLabel38.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(164.3752!, 22.68756!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(100.0!, 17.70834!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel38.TextFormatString = "{0:n2}"
        '
        'XrLabel37
        '
        Me.XrLabel37.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(29.58377!, 22.68747!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(52.49965!, 17.70834!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Discount:"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vwReceipt.pos_date]")})
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(155.2508!, 40.3959!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(10.60382!, 17.70834!)
        Me.XrLabel26.TextFormatString = "{0:MM/dd/yy}"
        Me.XrLabel26.Visible = False
        '
        'XrLabel67
        '
        Me.XrLabel67.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[full]")})
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(73.56215!, 53.12506!)
        Me.XrLabel67.Multiline = True
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(192.708!, 17.70834!)
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 8.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 53.125!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(39.77134!, 17.70834!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Sold to:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel54, Me.XrLabel62, Me.XrLabel5, Me.XrLabel27, Me.XrLabel65, Me.XrLabel24, Me.XrLabel50, Me.XrLabel2, Me.XrLabel1})
        Me.ReportHeader.HeightF = 183.3749!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel54
        '
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(34.16672!, 165.6666!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(76.66596!, 17.70834!)
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Terminal: "
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[trminal]")})
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(129.5423!, 165.6666!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(97.68773!, 17.70834!)
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.Text = "All"
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 147.9583!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(71.18885!, 17.70834!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Cashier:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sInsert_id]")})
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(129.5423!, 147.9583!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(134.8123!, 17.70834!)
        Me.XrLabel27.StylePriority.UseFont = False
        '
        'XrLabel65
        '
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(107.8957!, 131.2918!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(21.64644!, 17.70834!)
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "To"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.SalesDateFrom]")})
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 130.2499!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(72.83482!, 17.70834!)
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel50
        '
        Me.XrLabel50.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters.SalesDateTo]")})
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(129.5423!, 130.2499!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(100.0!, 17.70834!)
        Me.XrLabel50.Text = "XrLabel50"
        Me.XrLabel50.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 112.5415!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(235.8127!, 17.70834!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Electronic Sales Journal"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(34.16673!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(232.1035!, 112.5414!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = resources.GetString("XrLabel1.Text")
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'SalesDateFrom
        '
        Me.SalesDateFrom.Description = "From"
        Me.SalesDateFrom.Name = "SalesDateFrom"
        Me.SalesDateFrom.Type = GetType(Date)
        '
        'SalesDateTo
        '
        Me.SalesDateTo.Description = "To"
        Me.SalesDateTo.Name = "SalesDateTo"
        Me.SalesDateTo.Type = GetType(Date)
        Me.SalesDateTo.ValueInfo = "2099-12-31"
        '
        'taym
        '
        Me.taym.DataMember = "vwReceipt"
        Me.taym.Expression = "Now()"
        Me.taym.Name = "taym"
        '
        'CashierCaps
        '
        Me.CashierCaps.DataMember = "vwReceipt"
        Me.CashierCaps.Expression = "Upper([sInsert_id])"
        Me.CashierCaps.Name = "CashierCaps"
        '
        'TotalBill
        '
        Me.TotalBill.DataMember = "vwReceipt"
        Me.TotalBill.Expression = "[vatable]/1.12"
        Me.TotalBill.Name = "TotalBill"
        '
        'VAT
        '
        Me.VAT.DataMember = "vwReceipt"
        Me.VAT.Expression = "[vatable]/1.12*.12"
        Me.VAT.Name = "VAT"
        '
        'Changess
        '
        Me.Changess.DataMember = "vwReceipt"
        Me.Changess.Expression = "[tendered] - [GT]"
        Me.Changess.Name = "Changess"
        '
        'GT
        '
        Me.GT.DataMember = "vwReceipt"
        Me.GT.Expression = "[totsales] - [disc_amnt]"
        Me.GT.Name = "GT"
        '
        'SubTotss
        '
        Me.SubTotss.DataMember = "vwReceipt"
        Me.SubTotss.Expression = "Sum([det_amnt])"
        Me.SubTotss.Name = "SubTotss"
        '
        'nvat
        '
        Me.nvat.DataMember = "vwReceipt"
        Me.nvat.Expression = "Iif([vatable]=0,[det_amnt]  , 0)"
        Me.nvat.Name = "nvat"
        '
        'sumnvat
        '
        Me.sumnvat.DataMember = "vwReceipt"
        Me.sumnvat.Name = "sumnvat"
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "vwReceipt"
        Me.CalculatedField1.Expression = "'*********'+[item_desc].Count()  + 'item(s)*********'"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'CalculatedField2
        '
        Me.CalculatedField2.DataMember = "vwReceipt"
        Me.CalculatedField2.Expression = "[totsales] - [disc_amnt]"
        Me.CalculatedField2.Name = "CalculatedField2"
        '
        'vatsales
        '
        Me.vatsales.DataMember = "vwReceipt"
        Me.vatsales.Expression = "Iif([incentiv]=1,[det_amnt] ,0)"
        Me.vatsales.Name = "vatsales"
        '
        'vnv
        '
        Me.vnv.DataMember = "vwReceipt"
        Me.vnv.Expression = "Iif([active]=1,'V'  ,'NV' )"
        Me.vnv.Name = "vnv"
        '
        'FL
        '
        Me.FL.DataMember = "vwReceipt"
        Me.FL.Expression = "[firstname]=','+[lastname]"
        Me.FL.Name = "FL"
        '
        'VwReceiptTableAdapter
        '
        Me.VwReceiptTableAdapter.ClearBeforeFill = True
        '
        'fullname
        '
        Me.fullname.DataMember = "vwReceipt"
        Me.fullname.Expression = "Trim([firstname]) + ',' + Trim([lastname])"
        Me.fullname.Name = "fullname"
        '
        'DsSalesArchive1
        '
        Me.DsSalesArchive1.DataSetName = "dsSalesArchive"
        Me.DsSalesArchive1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwSalesArchiveTableAdapter
        '
        Me.VwSalesArchiveTableAdapter.ClearBeforeFill = True
        '
        'full
        '
        Me.full.DataMember = "vwSalesArchive"
        Me.full.Expression = "trim([firstname]) +', ' + Trim([lastname])"
        Me.full.Name = "full"
        '
        'TotBill
        '
        Me.TotBill.DataMember = "vwSalesArchive"
        Me.TotBill.Expression = "[totsales]/1.12"
        Me.TotBill.Name = "TotBill"
        '
        'VAT2
        '
        Me.VAT2.DataMember = "vwSalesArchive"
        Me.VAT2.Expression = "[totsales]/1.12*.12"
        Me.VAT2.Name = "VAT2"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel67, Me.XrLabel3, Me.XrLabel8, Me.XrLabel7, Me.XrLabel9, Me.XrLabel33, Me.XrLabel28, Me.XrLabel25, Me.XrLabel6, Me.XrLabel4, Me.XrLabel13, Me.XrLine5})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("postmp_hdrid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 96.6665!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(175.8743!, 78.54147!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(30.62498!, 16.04169!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Qty"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(126.2909!, 78.54147!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(45.20832!, 16.04169!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Price"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 78.54147!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(88.52075!, 16.04169!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Item"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(206.4992!, 78.54147!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(61.45834!, 16.04169!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Amount"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[mowd]")})
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(127.8963!, 0!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(132.5003!, 17.70845!)
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 0!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(75.39587!, 17.70834!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Trans Type:"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Receipt]")})
        Me.XrLabel25.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(127.8963!, 17.7084!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(132.5003!, 17.70834!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel25.TextFormatString = "{0:0000000000#}"
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 17.7084!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(84.95918!, 17.70834!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Receipt No.:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 35.41673!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(75.39587!, 17.70834!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Date/Time:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[pos_tme]")})
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 9.75!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(109.8321!, 35.41673!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(158.1048!, 17.70834!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.TextFormatString = "{0:M/d/yyyy h:mm tt}"
        '
        'XrLine5
        '
        Me.XrLine5.LineStyle = DevExpress.Drawing.DXDashStyle.Dot
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(33.79082!, 94.58316!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(234.7914!, 2.083336!)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel29})
        Me.ReportFooter.HeightF = 21.875!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel17
        '
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([totsales])")})
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(142.7492!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(121.626!, 17.70833!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary3
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrLabel17.TextFormatString = "{0:n2}"
        Me.XrLabel17.Visible = False
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(26.68718!, 0!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(116.062!, 17.70833!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "GRAND Total"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel29.Visible = False
        '
        'xrSalesHistory
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupFooter1, Me.ReportHeader, Me.GroupHeader1, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.taym, Me.CashierCaps, Me.TotalBill, Me.VAT, Me.Changess, Me.GT, Me.SubTotss, Me.nvat, Me.sumnvat, Me.CalculatedField1, Me.CalculatedField2, Me.vatsales, Me.vnv, Me.FL, Me.fullname, Me.full, Me.TotBill, Me.VAT2})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DsSalesArchive1})
        Me.DataAdapter = Me.VwSalesArchiveTableAdapter
        Me.DataMember = "vwSalesArchive"
        Me.DataSource = Me.DsSalesArchive1
        Me.FilterString = "[pos_date] Between(?SalesDateFrom, ?SalesDateTo) And [mowd] = 'CASH' And [trminal" &
    "] = 1"
        Me.Margins = New DevExpress.Drawing.DXMargins(4.0!, 557.0!, 11.0!, 9.0!)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SalesDateFrom, Me.SalesDateTo})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = False
        Me.ShowPrintStatusDialog = False
        Me.Version = "22.2"
        CType(Me.DsSalesArchive1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xRLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents taym As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CashierCaps As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalBill As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents VAT As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Changess As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GT As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SubTotss As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents nvat As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents sumnvat As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalculatedField2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents vatsales As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents vnv As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents FL As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents VwReceiptTableAdapter As dsvwReceiptTableAdapters.vwReceiptTableAdapter
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SalesDateFrom As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SalesDateTo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fullname As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DsSalesArchive1 As dsSalesArchive
    Friend WithEvents VwSalesArchiveTableAdapter As dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter
    Friend WithEvents full As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotBill As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents VAT2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
End Class
