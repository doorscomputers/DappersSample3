Namespace Win_Dashboards
    Partial Public Class SalesPAstHr
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesPAstHr))
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartDashboardItem1
            '
            Dimension1.DataMember = "dtInsert_dt"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Hour
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            Measure1.DataMember = "det_amnt"
            Dimension2.DataMember = "pos_date"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Day
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2")
            Me.chartDashboardItem1.DataSource = Me.dataSource1
            Me.chartDashboardItem1.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Sales Chart per Hour"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "det_amnt (Sum)"
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
            Me.dataSource1.Filter = "[vwSales.pos_date] Between(?paramDate, ?paramDate2)"
            Me.dataSource1.Name = "Data Source 5"
            '
            'pivotDashboardItem1
            '
            Dimension3.DataMember = "pos_date"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            Measure2.DataMember = "det_amnt"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension4.DataMember = "dtInsert_dt"
            Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Hour
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2")
            Me.pivotDashboardItem1.DataSource = Me.dataSource1
            Me.pivotDashboardItem1.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.Name = "Grid View"
            Me.pivotDashboardItem1.NamesRepository.Clear()
            Me.pivotDashboardItem1.NamesRepository.Add(Measure2, "Amount")
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.pivotDashboardItem1.ShowCaption = True
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure2})
            '
            'SalesPAstHr
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.chartDashboardItem1, Me.pivotDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
            DashboardLayoutItem1.Weight = 54.866310160427808R
            DashboardLayoutItem2.DashboardItem = Me.pivotDashboardItem1
            DashboardLayoutItem2.Weight = 45.133689839572192R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            Me.LayoutRoot = DashboardLayoutGroup1
            DashboardParameter1.Description = "From"
            DashboardParameter1.Name = "paramDate"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
            DashboardParameter2.Description = "To"
            DashboardParameter2.Name = "paramDate2"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(2014, 2, 1, 13, 18, 31, 0)
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Previous Sales Per Hour"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents dataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem

#End Region
    End Class
End Namespace