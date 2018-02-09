Namespace Win_Dashboards
    Partial Public Class Dashboard1
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
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Gauge1 As DevExpress.DashboardCommon.Gauge = New DevExpress.DashboardCommon.Gauge()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup4 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.GaugeDashboardItem1 = New DevExpress.DashboardCommon.GaugeDashboardItem()
            Me.GridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.DataSource2 = New DevExpress.DashboardCommon.DataSource()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GaugeDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem1
            '
            Dimension1.DataMember = "dtInsert_dt"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "det_amnt"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataSource = Me.DataSource2
            Me.ChartDashboardItem1.FilterString = "[DataItem1] Between(?From, ?To)"
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart View"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "Amount Sold"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DataSource1
            '
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable")
            Me.DataSource1.Name = "Data Source 1"
            '
            'GaugeDashboardItem1
            '
            Me.GaugeDashboardItem1.ComponentName = "GaugeDashboardItem1"
            Measure2.DataMember = "totsales"
            Dimension2.DataMember = "dtInsert_dt"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.GaugeDashboardItem1.DataItemRepository.Clear()
            Me.GaugeDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.GaugeDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.GaugeDashboardItem1.DataSource = Me.DataSource1
            Gauge1.Name = "totsales (Sum)"
            Gauge1.AddDataItem("ActualValue", Measure2)
            Me.GaugeDashboardItem1.Gauges.AddRange(New DevExpress.DashboardCommon.Gauge() {Gauge1})
            Me.GaugeDashboardItem1.IgnoreMasterFilters = False
            Me.GaugeDashboardItem1.Name = "Gauge View"
            Me.GaugeDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.GaugeDashboardItem1.ShowCaption = True
            '
            'GridDashboardItem1
            '
            Dimension3.DataMember = "dtInsert_dt"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            GridDimensionColumn1.Name = "Month-Year"
            GridDimensionColumn1.AddDataItem("Dimension", Dimension3)
            Measure3.DataMember = "totsales"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn1.Name = "Amount"
            GridMeasureColumn1.AddDataItem("Measure", Measure3)
            Me.GridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridMeasureColumn1})
            Me.GridDashboardItem1.ComponentName = "GridDashboardItem1"
            Me.GridDashboardItem1.DataItemRepository.Clear()
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem0")
            Me.GridDashboardItem1.DataItemRepository.Add(Measure3, "DataItem1")
            Me.GridDashboardItem1.DataSource = Me.DataSource1
            Me.GridDashboardItem1.FilterString = "[DataItem0] Between(?From, ?To)"
            Me.GridDashboardItem1.IgnoreMasterFilters = False
            Me.GridDashboardItem1.Name = "Grid View"
            Me.GridDashboardItem1.ShowCaption = True
            '
            'PivotDashboardItem1
            '
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Measure4.DataMember = "totsales"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension4.DataMember = "dtInsert_dt"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure4, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1")
            Me.PivotDashboardItem1.DataSource = Me.DataSource1
            Me.PivotDashboardItem1.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.Name = "Grid View2"
            Me.PivotDashboardItem1.NamesRepository.Clear()
            Me.PivotDashboardItem1.NamesRepository.Add(Measure4, "Amount")
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure4})
            '
            'DataSource2
            '
            Me.DataSource2.ComponentName = "DataSource2"
            Me.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable")
            Me.DataSource2.Name = "cashsales"
            '
            'Dashboard1
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1, Me.DataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.GridDashboardItem1, Me.PivotDashboardItem1, Me.GaugeDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.GaugeDashboardItem1
            DashboardLayoutItem2.Weight = 49.802371541501977R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem2})
            DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup3.Weight = 50.0R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutGroup3})
            DashboardLayoutGroup2.Weight = 49.901380670611438R
            DashboardLayoutItem3.DashboardItem = Me.GridDashboardItem1
            DashboardLayoutItem3.Weight = 50.0R
            DashboardLayoutItem4.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem4.Weight = 50.0R
            DashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup4.Weight = 50.098619329388562R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup4})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "From"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2014, 2, 2, 23, 7, 33, 0)
            DashboardParameter2.Name = "To"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(9999, 2, 2, 23, 7, 0, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GaugeDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents GridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents GaugeDashboardItem1 As DevExpress.DashboardCommon.GaugeDashboardItem
        Friend WithEvents DataSource2 As DevExpress.DashboardCommon.DataSource

#End Region
    End Class
End Namespace