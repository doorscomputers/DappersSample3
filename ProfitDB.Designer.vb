Namespace Win_Dashboards
    Partial Public Class ProfitDB
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
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim CalculatedField2 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfitDB))
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane3 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries3 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure5 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension10 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension11 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure6 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension12 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension13 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem6 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter3 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.Profit = New DevExpress.DashboardCommon.DataSource()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.ChartDashboardItem3 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.PivotDashboardItem2 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.PivotDashboardItem3 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Profit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem2
            '
            Dimension1.DataMember = "pos_date"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Measure1.DataMember = "Profit"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension2.DataMember = "pos_date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.ChartDashboardItem2.DataSource = Me.Profit
            Me.ChartDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.ChartDashboardItem2.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.Name = "Monthly Profit Chart"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "Profit (Sum)"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'Profit
            '
            CalculatedField1.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField1.Expression = "[qty] * [cost]"
            CalculatedField1.Name = "CostAmnt"
            CalculatedField2.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField2.Expression = "[det_amnt] - ([cost] * [qty])"
            CalculatedField2.Name = "Profit"
            Me.Profit.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1, CalculatedField2})
            Me.Profit.ComponentName = "Profit"
            Me.Profit.DataProviderSerializable = resources.GetString("Profit.DataProviderSerializable")
            Me.Profit.Name = "Profit"
            '
            'ChartDashboardItem1
            '
            Dimension3.DataMember = "pos_date"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure2.DataMember = "Profit"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension4.DataMember = "pos_date"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2")
            Me.ChartDashboardItem1.DataSource = Me.Profit
            Me.ChartDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)"
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Quarterly Profit Chart"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.Name = "Profit (Sum)"
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'ChartDashboardItem3
            '
            Dimension5.DataMember = "pos_date"
            Me.ChartDashboardItem3.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5})
            Me.ChartDashboardItem3.AxisX.TitleVisible = False
            Me.ChartDashboardItem3.ComponentName = "ChartDashboardItem3"
            Measure3.DataMember = "Profit"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension6.DataMember = "pos_date"
            Me.ChartDashboardItem3.DataItemRepository.Clear()
            Me.ChartDashboardItem3.DataItemRepository.Add(Measure3, "DataItem0")
            Me.ChartDashboardItem3.DataItemRepository.Add(Dimension5, "DataItem1")
            Me.ChartDashboardItem3.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.ChartDashboardItem3.DataSource = Me.Profit
            Me.ChartDashboardItem3.FilterString = "[DataItem1] Between(2014, ?YrEnd)"
            Me.ChartDashboardItem3.IgnoreMasterFilters = False
            Me.ChartDashboardItem3.Name = "Annual Profit"
            ChartPane3.Name = "Pane 1"
            ChartPane3.PrimaryAxisY.ShowGridLines = True
            ChartPane3.PrimaryAxisY.TitleVisible = True
            ChartPane3.SecondaryAxisY.ShowGridLines = False
            ChartPane3.SecondaryAxisY.TitleVisible = True
            SimpleSeries3.Name = "Profit (Sum)"
            SimpleSeries3.AddDataItem("Value", Measure3)
            ChartPane3.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries3})
            Me.ChartDashboardItem3.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane3})
            Me.ChartDashboardItem3.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension6})
            Me.ChartDashboardItem3.ShowCaption = True
            '
            'PivotDashboardItem2
            '
            Me.PivotDashboardItem2.AutoExpandRowGroups = True
            Me.PivotDashboardItem2.ComponentName = "PivotDashboardItem2"
            Dimension7.DataMember = "pos_date"
            Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Measure4.DataMember = "Profit"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension8.DataMember = "catgory"
            Dimension8.SortByMeasureName = "DataItem2"
            Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.PivotDashboardItem2.DataItemRepository.Clear()
            Me.PivotDashboardItem2.DataItemRepository.Add(Dimension7, "DataItem1")
            Me.PivotDashboardItem2.DataItemRepository.Add(Measure4, "DataItem2")
            Me.PivotDashboardItem2.DataItemRepository.Add(Dimension8, "DataItem0")
            Me.PivotDashboardItem2.DataSource = Me.Profit
            Me.PivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.PivotDashboardItem2.IgnoreMasterFilters = False
            Me.PivotDashboardItem2.Name = "Monthly Profit"
            Me.PivotDashboardItem2.NamesRepository.Clear()
            Me.PivotDashboardItem2.NamesRepository.Add(Measure4, "Profit (Sum)")
            Me.PivotDashboardItem2.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7, Dimension8})
            Me.PivotDashboardItem2.ShowCaption = True
            Me.PivotDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure4})
            '
            'PivotDashboardItem3
            '
            Me.PivotDashboardItem3.AutoExpandRowGroups = True
            Me.PivotDashboardItem3.ComponentName = "PivotDashboardItem3"
            Measure5.DataMember = "Profit"
            Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure5.NumericFormat.IncludeGroupSeparator = True
            Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension9.DataMember = "pos_date"
            Dimension9.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension9.SortByMeasureName = "DataItem0"
            Dimension9.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension10.DataMember = "catgory"
            Dimension10.SortByMeasureName = "DataItem0"
            Dimension10.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.PivotDashboardItem3.DataItemRepository.Clear()
            Me.PivotDashboardItem3.DataItemRepository.Add(Measure5, "DataItem0")
            Me.PivotDashboardItem3.DataItemRepository.Add(Dimension9, "DataItem1")
            Me.PivotDashboardItem3.DataItemRepository.Add(Dimension10, "DataItem2")
            Me.PivotDashboardItem3.DataSource = Me.Profit
            Me.PivotDashboardItem3.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.PivotDashboardItem3.IgnoreMasterFilters = False
            Me.PivotDashboardItem3.Name = "Profit (Highest to Lowest)"
            Me.PivotDashboardItem3.NamesRepository.Clear()
            Me.PivotDashboardItem3.NamesRepository.Add(Measure5, "Profit (Sum)")
            Me.PivotDashboardItem3.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension9, Dimension10})
            Me.PivotDashboardItem3.ShowCaption = True
            Me.PivotDashboardItem3.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure5})
            '
            'PivotDashboardItem1
            '
            Me.PivotDashboardItem1.AutoExpandRowGroups = True
            Dimension11.DataMember = "pos_date"
            Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.PivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension11})
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Measure6.DataMember = "Profit"
            Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure6.NumericFormat.IncludeGroupSeparator = True
            Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension12.DataMember = "item_desc"
            Dimension13.DataMember = "pos_date"
            Dimension13.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure6, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem2")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension13, "DataItem3")
            Me.PivotDashboardItem1.DataSource = Me.Profit
            Me.PivotDashboardItem1.FilterString = "[DataItem3] Between(?DateFrom, ?DateTo)"
            Me.PivotDashboardItem1.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.Name = "Profit per Item (Monthly View)"
            Me.PivotDashboardItem1.NamesRepository.Clear()
            Me.PivotDashboardItem1.NamesRepository.Add(Measure6, "Profit (Sum)")
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension12, Dimension13})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure6})
            '
            'ProfitDB
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.Profit})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ChartDashboardItem2, Me.PivotDashboardItem1, Me.PivotDashboardItem2, Me.ChartDashboardItem3, Me.PivotDashboardItem3})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem1.Weight = 52.227342549923193R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem2.Weight = 23.80952380952381R
            DashboardLayoutItem3.DashboardItem = Me.ChartDashboardItem3
            DashboardLayoutItem3.Weight = 23.963133640552996R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup2.Weight = 50.69033530571992R
            DashboardLayoutItem4.DashboardItem = Me.PivotDashboardItem2
            DashboardLayoutItem4.Weight = 29.3394777265745R
            DashboardLayoutItem5.DashboardItem = Me.PivotDashboardItem3
            DashboardLayoutItem5.Weight = 27.1889400921659R
            DashboardLayoutItem6.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem6.Weight = 43.4715821812596R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem4, DashboardLayoutItem5, DashboardLayoutItem6})
            DashboardLayoutGroup3.Weight = 49.30966469428008R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "DateFrom"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2000, 2, 7, 21, 12, 0, 0)
            DashboardParameter2.Name = "DateTo"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(2999, 2, 7, 21, 12, 0, 0)
            DashboardParameter3.Name = "YrEnd"
            DashboardParameter3.Type = GetType(Integer)
            DashboardParameter3.Value = 2099
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2, DashboardParameter3})
            Me.Title.Text = "Profit Overview"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Profit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Profit As DevExpress.DashboardCommon.DataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents PivotDashboardItem2 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents ChartDashboardItem3 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents PivotDashboardItem3 As DevExpress.DashboardCommon.PivotDashboardItem

#End Region
    End Class
End Namespace