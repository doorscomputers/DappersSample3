Namespace Win_Dashboards
    Partial Public Class Itemssoldsummry
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Itemssoldsummry))
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.pivotDashboardItem2 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartDashboardItem1
            '
            Dimension1.DataMember = "catgory"
            Dimension1.SortByMeasureName = "DataItem1"
            Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            Measure1.DataMember = "qty"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Precision = 0
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension2.DataMember = "pos_date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.chartDashboardItem1.DataSource = Me.dataSource1
            Me.chartDashboardItem1.IgnoreMasterFilters = False
            Me.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
            Me.chartDashboardItem1.Name = "Chart Grouped by Category"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.Title = "Qty Sold Total"
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "qty (Sum)"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.chartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.chartDashboardItem1.ShowCaption = True
            '
            'dataSource1
            '
            Me.dataSource1.ComponentName = "dataSource1"
            Me.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable")
            Me.dataSource1.Filter = ""
            Me.dataSource1.Name = "Data Source 3"
            '
            'pieDashboardItem1
            '
            Dimension3.DataMember = "catgory"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            Measure2.DataMember = "qty"
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.pieDashboardItem1.DataSource = Me.dataSource1
            Me.pieDashboardItem1.IgnoreMasterFilters = False
            Me.pieDashboardItem1.Name = "Chart Grouped by Month-Year"
            Me.pieDashboardItem1.NamesRepository.Clear()
            Me.pieDashboardItem1.NamesRepository.Add(Measure2, "Qty Sold Total")
            Me.pieDashboardItem1.ShowCaption = True
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'pivotDashboardItem2
            '
            Me.pivotDashboardItem2.AutoExpandRowGroups = True
            Me.pivotDashboardItem2.ComponentName = "pivotDashboardItem2"
            Dimension4.DataMember = "catgory"
            Dimension4.SortByMeasureName = "DataItem1"
            Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Measure3.DataMember = "qty"
            Measure4.DataMember = "det_amnt"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension5.DataMember = "pos_date"
            Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.pivotDashboardItem2.DataItemRepository.Clear()
            Me.pivotDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.pivotDashboardItem2.DataItemRepository.Add(Measure3, "DataItem1")
            Me.pivotDashboardItem2.DataItemRepository.Add(Measure4, "DataItem3")
            Me.pivotDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem2")
            Me.pivotDashboardItem2.DataSource = Me.dataSource1
            Me.pivotDashboardItem2.FilterString = "[DataItem2] Between(?From, ?To)"
            Me.pivotDashboardItem2.IgnoreMasterFilters = False
            Me.pivotDashboardItem2.Name = "Sold Items Monthly (View 1)"
            Me.pivotDashboardItem2.NamesRepository.Clear()
            Me.pivotDashboardItem2.NamesRepository.Add(Measure3, "Qty Sold")
            Me.pivotDashboardItem2.NamesRepository.Add(Measure4, "Amount")
            Me.pivotDashboardItem2.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5, Dimension4})
            Me.pivotDashboardItem2.ShowCaption = True
            Me.pivotDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure3, Measure4})
            '
            'pivotDashboardItem1
            '
            Me.pivotDashboardItem1.AutoExpandRowGroups = True
            Dimension6.DataMember = "pos_date"
            Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            Measure5.DataMember = "qty"
            Dimension7.DataMember = "catgory"
            Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Measure6.DataMember = "det_amnt"
            Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure6.NumericFormat.IncludeGroupSeparator = True
            Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension8.DataMember = "item_desc"
            Dimension8.SortByMeasureName = "DataItem1"
            Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(Measure5, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.pivotDashboardItem1.DataItemRepository.Add(Measure6, "DataItem3")
            Me.pivotDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem4")
            Me.pivotDashboardItem1.DataSource = Me.dataSource1
            Me.pivotDashboardItem1.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.Name = "Sold Items Monthly (View2)"
            Me.pivotDashboardItem1.NamesRepository.Clear()
            Me.pivotDashboardItem1.NamesRepository.Add(Measure5, "Qty Sold")
            Me.pivotDashboardItem1.NamesRepository.Add(Measure6, "Amount")
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7, Dimension8})
            Me.pivotDashboardItem1.ShowCaption = True
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure5, Measure6})
            '
            'Itemssoldsummry
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.chartDashboardItem1, Me.pieDashboardItem1, Me.pivotDashboardItem1, Me.pivotDashboardItem2})
            DashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
            DashboardLayoutItem1.Weight = 49.923195084485407R
            DashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            DashboardLayoutItem2.Weight = 50.076804915514593R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.Weight = 43.589743589743591R
            DashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem2
            DashboardLayoutItem3.Weight = 48.387096774193552R
            DashboardLayoutItem4.DashboardItem = Me.pivotDashboardItem1
            DashboardLayoutItem4.Weight = 51.612903225806448R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup3.Weight = 56.410256410256409R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "From"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2013, 12, 2, 0, 0, 0, 0)
            DashboardParameter2.Name = "To"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(9999, 12, 2, 0, 0, 0, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Sales per Item Category Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents dataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
        Friend WithEvents pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents pivotDashboardItem2 As DevExpress.DashboardCommon.PivotDashboardItem

#End Region
    End Class
End Namespace