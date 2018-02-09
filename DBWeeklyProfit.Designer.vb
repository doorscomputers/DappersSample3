Namespace Win_Dashboards
    Partial Public Class WeeklyProfitDB
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
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim CalculatedField1 As DevExpress.DashboardCommon.CalculatedField = New DevExpress.DashboardCommon.CalculatedField()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeeklyProfitDB))
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.PivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            Me.PivotDashboardItem2 = New DevExpress.DashboardCommon.PivotDashboardItem()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PivotDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem1
            '
            Dimension1.DataMember = "pos_date"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension2.DataMember = "pos_date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth
            Dimension2.TopNOptions.Count = 30
            Dimension2.TopNOptions.Enabled = True
            Dimension2.TopNOptions.MeasureName = "DataItem0"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1, Dimension2})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "Profit"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension3.DataMember = "pos_date"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3")
            Me.ChartDashboardItem1.DataSource = Me.DataSource1
            Me.ChartDashboardItem1.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Top 30 Weekly Profit Chart (1=1st Week, 2=2nd Week, 3-3rd Weeek, 4=4th Week, 5=5t" & _
        "h Week)"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "Profit (Sum)"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DataSource1
            '
            CalculatedField1.DataType = DevExpress.DashboardCommon.CalculatedFieldType.[Decimal]
            CalculatedField1.Expression = "[det_amnt]  -  ([qty] * [cost])"
            CalculatedField1.Name = "Profit"
            Me.DataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() {CalculatedField1})
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable")
            Me.DataSource1.Name = "dsWeekly"
            '
            'PivotDashboardItem1
            '
            Me.PivotDashboardItem1.AutoExpandRowGroups = True
            Dimension4.DataMember = "pos_date"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.PivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.PivotDashboardItem1.ComponentName = "PivotDashboardItem1"
            Measure2.DataMember = "Profit"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension5.DataMember = "pos_date"
            Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension6.DataMember = "pos_date"
            Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth
            Me.PivotDashboardItem1.DataItemRepository.Clear()
            Me.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem1")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.PivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem3")
            Me.PivotDashboardItem1.DataSource = Me.DataSource1
            Me.PivotDashboardItem1.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.PivotDashboardItem1.IgnoreMasterFilters = False
            Me.PivotDashboardItem1.Name = "Weekly Profit"
            Me.PivotDashboardItem1.NamesRepository.Clear()
            Me.PivotDashboardItem1.NamesRepository.Add(Measure2, "Profit (Sum)")
            Me.PivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5, Dimension6})
            Me.PivotDashboardItem1.ShowCaption = True
            Me.PivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'PivotDashboardItem2
            '
            Me.PivotDashboardItem2.AutoExpandRowGroups = True
            Me.PivotDashboardItem2.ComponentName = "PivotDashboardItem2"
            Measure3.DataMember = "Profit"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension7.DataMember = "pos_date"
            Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension7.SortByMeasureName = "DataItem0"
            Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension8.DataMember = "pos_date"
            Dimension8.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth
            Dimension8.SortByMeasureName = "DataItem0"
            Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.PivotDashboardItem2.DataItemRepository.Clear()
            Me.PivotDashboardItem2.DataItemRepository.Add(Measure3, "DataItem0")
            Me.PivotDashboardItem2.DataItemRepository.Add(Dimension7, "DataItem1")
            Me.PivotDashboardItem2.DataItemRepository.Add(Dimension8, "DataItem2")
            Me.PivotDashboardItem2.DataSource = Me.DataSource1
            Me.PivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)"
            Me.PivotDashboardItem2.IgnoreMasterFilters = False
            Me.PivotDashboardItem2.Name = "Week Profit (Highest to Lowest Regardless of Month)"
            Me.PivotDashboardItem2.NamesRepository.Clear()
            Me.PivotDashboardItem2.NamesRepository.Add(Measure3, "Profit")
            Me.PivotDashboardItem2.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7, Dimension8})
            Me.PivotDashboardItem2.ShowCaption = True
            Me.PivotDashboardItem2.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure3})
            '
            'WeeklyProfitDB
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.PivotDashboardItem1, Me.PivotDashboardItem2})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 50.098619329388562R
            DashboardLayoutItem2.DashboardItem = Me.PivotDashboardItem1
            DashboardLayoutItem2.Weight = 66.205837173579113R
            DashboardLayoutItem3.DashboardItem = Me.PivotDashboardItem2
            DashboardLayoutItem3.Weight = 33.794162826420894R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup2.Weight = 49.901380670611438R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutGroup2})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Name = "DateFrom"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2000, 2, 10, 10, 25, 0, 0)
            DashboardParameter2.Name = "DateTo"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(2014, 2, 10, 10, 25, 52, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Weekly Profit"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PivotDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents PivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
        Friend WithEvents PivotDashboardItem2 As DevExpress.DashboardCommon.PivotDashboardItem

#End Region
    End Class
End Namespace