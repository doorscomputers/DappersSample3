﻿Namespace Win_Dashboards
    Partial Public Class dsHiLoItems
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dsHiLoItems))
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource2 = New DevExpress.DashboardCommon.DataSource()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem1
            '
            Dimension1.DataMember = "item_desc"
            Dimension1.SortByMeasureName = "DataItem1"
            Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension1.TopNOptions.Count = 30
            Dimension1.TopNOptions.Enabled = True
            Dimension1.TopNOptions.MeasureName = "DataItem1"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "qty"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension2.DataMember = "pos_date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension2.TopNOptions.Count = 30
            Dimension2.TopNOptions.Enabled = True
            Dimension2.TopNOptions.MeasureName = "DataItem1"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.ChartDashboardItem1.DataSource = Me.DataSource2
            Me.ChartDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)"
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Top 30 Items Sold Monthly Chart"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.Title = "Qty Sold"
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "qty (Sum)"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DataSource2
            '
            Me.DataSource2.ComponentName = "DataSource2"
            Me.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable")
            Me.DataSource2.Filter = ""
            Me.DataSource2.Name = "Data Source 11"
            '
            'PivotDashboardItem1
            '
            Me.PivotDashboardItem1.AutoExpandRowGroups = True
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Dimension3.DataMember = "pos_date"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension4.DataMember = "item_desc"
            Dimension4.SortByMeasureName = "DataItem2"
            Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Measure2.DataMember = "qty"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Measure3.DataMember = "det_amnt"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2")
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure3, "DataItem3")
            Me.PivotDashboardItem1.DataSource = Me.DataSource2
            Me.PivotDashboardItem1.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.Name = "Sold Items Per Month"
            Measure4.DataMember = "qty"
            Me.PivotDashboardItem1.NamesRepository.Clear()
            Me.PivotDashboardItem1.NamesRepository.Add(Measure4, "Total Qty Sold")
            Me.PivotDashboardItem1.NamesRepository.Add(Measure2, "Qty Sold")
            Me.PivotDashboardItem1.NamesRepository.Add(Measure3, "Amount")
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3, Dimension4})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2, Measure3})
            '
            'DataSource1
            '
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable")
            Me.DataSource1.Filter = ""
            Me.DataSource1.Name = "dsSales"
            '
            'dsHiLoItems
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1, Me.DataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.PivotDashboardItem1, Me.ChartDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 58.068459657701709R
            DashboardLayoutItem2.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem2.Weight = 41.931540342298291R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "DateFrom"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2000, 2, 6, 19, 4, 0, 0)
            DashboardParameter2.Name = "DateTo"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(2999, 2, 6, 19, 5, 0, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Items Sold perItem Chart and Item Grid Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents DataSource2 As DevExpress.DashboardCommon.DataSource

#End Region
    End Class
End Namespace