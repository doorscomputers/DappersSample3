﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrBIRSalesReport
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xRLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xRLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsReading1 = New DoorsPOS.WinApp.dsReading()
        Me.TblreadingTableAdapter = New DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter()
        Me.DateFrom = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DateTo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.calcEndBal = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.DsReading1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel39, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.XrLabel35, Me.XrLabel34, Me.XrLabel33, Me.XrLabel32, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26})
        Me.Detail.HeightF = 32.29167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel39
        '
        Me.XrLabel39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.cashreadid")})
        Me.XrLabel39.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(1206.875!, 0.0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(70.8335!, 23.0!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "XrLabel39"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel38
        '
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.cntvoids", "{0:n2}")})
        Me.XrLabel38.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(1019.375!, 0.0!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(80.20819!, 23.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "XrLabel38"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel37
        '
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.totalrefs", "{0:n2}")})
        Me.XrLabel37.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(926.6666!, 0.0!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(80.20837!, 23.0!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "XrLabel37"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel36
        '
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.totaldiscount", "{0:n2}")})
        Me.XrLabel36.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(833.9583!, 0.0!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "XrLabel36"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.totzerorated", "{0:n2}")})
        Me.XrLabel35.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(732.9166!, 0.0!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(88.54181!, 23.0!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "XrLabel35"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.sumexempt", "{0:n2}")})
        Me.XrLabel34.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(652.7083!, 0.0!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.sumvat", "{0:n2}")})
        Me.XrLabel33.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(566.2501!, 0.0!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(80.20825!, 23.0!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.totvat", "{0:n2}")})
        Me.XrLabel32.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(480.8333!, 0.0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(80.20825!, 23.0!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "XrLabel32"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.totalsales", "{0:n2}")})
        Me.XrLabel31.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(392.2917!, 0.0!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(80.20828!, 23.0!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "XrLabel31"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.calcEndBal", "{0:n2}")})
        Me.XrLabel30.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(229.7916!, 0.0!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(77.08336!, 23.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel30"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.prevtotal", "{0:n2}")})
        Me.XrLabel29.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(312.0834!, 0.0!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "XrLabel29"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.endreceipt")})
        Me.XrLabel28.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(154.7917!, 0.0!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(74.99998!, 23.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.begreceipt")})
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.25!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(79.79167!, 0.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(74.99998!, 23.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "XrLabel27"
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "tblreading.datereading", "{0:MM/dd/yyyy}")})
        Me.XrLabel26.Font = New DevExpress.Drawing.DXFont("Times New Roman", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(69.79166!, 23.0!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "XrLabel26"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.xRLabel3, Me.XrLabel2, Me.xRLabel1})
        Me.TopMargin.HeightF = 145.625!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel25
        '
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(1283.958!, 98.66667!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(96.04163!, 23.0!)
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Remarks"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(1217.292!, 122.625!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(60.41663!, 23.0!)
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Counter"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel23
        '
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1217.292!, 98.66667!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(60.41663!, 23.0!)
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Reset"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel22
        '
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1111.042!, 122.625!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(96.875!, 23.0!)
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Overflow"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(1111.042!, 98.66667!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(96.875!, 23.0!)
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Sales Overrun"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(1019.375!, 98.66667!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Voids"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel19
        '
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(926.6666!, 98.66667!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Returns"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel18
        '
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(833.9583!, 98.66667!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Discounts"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(741.25!, 121.6667!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Sales"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(652.7083!, 121.6667!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Sales"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(741.25!, 98.66667!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Zero Rated"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(652.7083!, 98.66667!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "VAT Exempt"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(566.25!, 98.66667!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "VAT Amount"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(480.8333!, 98.66667!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "VAT Sales"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(392.2917!, 98.66667!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Total Sales"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(312.0834!, 121.6667!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Balance"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(312.0834!, 98.66667!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Beginning"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(226.6667!, 121.6667!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Balance"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(226.6667!, 98.66667!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(80.20831!, 23.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Ending " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(170.4167!, 121.6667!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(56.25003!, 23.0!)
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "To"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(79.79167!, 121.6667!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(42.70834!, 23.0!)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "From"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(79.79167!, 98.66667!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(146.875!, 23.0!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Invoice Number"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xRLabel3
        '
        Me.xRLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 98.66667!)
        Me.xRLabel3.Name = "xRLabel3"
        Me.xRLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xRLabel3.SizeF = New System.Drawing.SizeF(69.79166!, 23.0!)
        Me.xRLabel3.Text = "Date"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 46.95832!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1370.0!, 20.91667!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "POS X, Serial Number XX-AXXX Machine Number XXXXXXXXX"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xRLabel1
        '
        Me.xRLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.xRLabel1.Multiline = True
        Me.xRLabel1.Name = "xRLabel1"
        Me.xRLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xRLabel1.SizeF = New System.Drawing.SizeF(1370.0!, 46.95834!)
        Me.xRLabel1.StylePriority.UseTextAlignment = False
        Me.xRLabel1.Text = "BIR Sales Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Store Code :XXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tin Number: XXX-XXX-XXX-000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.xRLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 5.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsReading1
        '
        Me.DsReading1.DataSetName = "dsReading"
        Me.DsReading1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblreadingTableAdapter
        '
        Me.TblreadingTableAdapter.ClearBeforeFill = True
        '
        'DateFrom
        '
        Me.DateFrom.Description = "DateFrom"
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Type = GetType(Date)
        Me.DateFrom.ValueInfo = "2014-07-01"
        '
        'DateTo
        '
        Me.DateTo.Description = "DateTo"
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Type = GetType(Date)
        Me.DateTo.ValueInfo = "2099-01-01"
        '
        'calcEndBal
        '
        Me.calcEndBal.DataMember = "tblreading"
        Me.calcEndBal.Expression = "[prevtotal] + [totalsales]"
        Me.calcEndBal.Name = "calcEndBal"
        '
        'xrBIRSalesReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcEndBal})
        Me.DataAdapter = Me.TblreadingTableAdapter
        Me.DataMember = "tblreading"
        Me.DataSource = Me.DsReading1
        Me.FilterString = "[datereading] >= ?DateFrom And [datereading] <= ?DateTo"
        Me.Landscape = True
        Me.Margins = New DevExpress.Drawing.DXMargins(5, 5, 146, 5)
        Me.PageHeight = 850
        Me.PageWidth = 1400
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Legal
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.DateFrom, Me.DateTo})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.1"
        CType(Me.DsReading1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xRLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xRLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsReading1 As DoorsPOS.WinApp.dsReading
    Friend WithEvents TblreadingTableAdapter As DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter
    Friend WithEvents DateFrom As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DateTo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents calcEndBal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
End Class
