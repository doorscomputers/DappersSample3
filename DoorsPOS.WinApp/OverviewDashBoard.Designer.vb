Namespace Win_Dashboards
    Partial Public Class OverviewDashBoard
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverviewDashBoard))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane3 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries3 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane4 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries4 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource2 = New DevExpress.DashboardCommon.DataSource()
            Me.ChartDashboardItem3 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource3 = New DevExpress.DashboardCommon.DataSource()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.ChartDashboardItem4 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.Dsinvpayvw1 = New DoorsPOS.WinApp.dsinvpayvw()
            Me.DataSource5 = New DevExpress.DashboardCommon.DataSource()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Dsinvpayvw1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ChartDashboardItem2
            '
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Dimension1.DataMember = "drdate"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Measure1.DataMember = "dramnt"
            Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure1.NumericFormat.IncludeGroupSeparator = True
            Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem1")
            Me.ChartDashboardItem2.DataSource = Me.DataSource2
            Me.ChartDashboardItem2.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.InteractivityOptions.IsDrillDownEnabled = True
            Me.ChartDashboardItem2.Name = "Monthly Purchases"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.Title = "Amount"
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.Name = "dramnt (Sum)"
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'DataSource2
            '
            Me.DataSource2.ComponentName = "DataSource2"
            Me.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable")
            Me.DataSource2.Name = "dstotalpurchases"
            '
            'ChartDashboardItem3
            '
            Me.ChartDashboardItem3.AxisX.TitleVisible = False
            Me.ChartDashboardItem3.ComponentName = "ChartDashboardItem3"
            Dimension2.DataMember = "expdate"
            Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Measure2.DataMember = "expamount"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Me.ChartDashboardItem3.DataItemRepository.Clear()
            Me.ChartDashboardItem3.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ChartDashboardItem3.DataItemRepository.Add(Measure2, "DataItem1")
            Me.ChartDashboardItem3.DataSource = Me.DataSource3
            Me.ChartDashboardItem3.IgnoreMasterFilters = False
            Me.ChartDashboardItem3.Name = "Monthly Expenses"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.Title = "Amount"
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.Name = "expamount (Sum)"
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.ChartDashboardItem3.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.ChartDashboardItem3.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension2})
            Me.ChartDashboardItem3.ShowCaption = True
            '
            'DataSource3
            '
            Me.DataSource3.ComponentName = "DataSource3"
            Me.DataSource3.DataProviderSerializable = resources.GetString("DataSource3.DataProviderSerializable")
            Me.DataSource3.Name = "dstotalexpenses"
            '
            'ChartDashboardItem1
            '
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure3.DataMember = "totsales"
            Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure3.NumericFormat.IncludeGroupSeparator = True
            Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Dimension3.DataMember = "pos_date"
            Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension3.SortByMeasureName = "DataItem0"
            Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.ChartDashboardItem1.DataSource = Me.DataSource1
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Monthly Sales"
            ChartPane3.Name = "Pane 1"
            ChartPane3.PrimaryAxisY.ShowGridLines = True
            ChartPane3.PrimaryAxisY.Title = "Amount"
            ChartPane3.PrimaryAxisY.TitleVisible = True
            ChartPane3.SecondaryAxisY.ShowGridLines = False
            ChartPane3.SecondaryAxisY.TitleVisible = True
            SimpleSeries3.Name = "totsales (Sum)"
            SimpleSeries3.AddDataItem("Value", Measure3)
            ChartPane3.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries3})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane3})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'DataSource1
            '
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable")
            Me.DataSource1.Name = "dstotalsales"
            '
            'ChartDashboardItem4
            '
            Dimension4.DataMember = "supplier"
            Me.ChartDashboardItem4.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ChartDashboardItem4.AxisX.TitleVisible = False
            Me.ChartDashboardItem4.ComponentName = "ChartDashboardItem4"
            Dimension5.DataMember = "paydate"
            Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Measure4.DataMember = "amnt"
            Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure4.NumericFormat.IncludeGroupSeparator = True
            Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            Me.ChartDashboardItem4.DataItemRepository.Clear()
            Me.ChartDashboardItem4.DataItemRepository.Add(Dimension4, "DataItem2")
            Me.ChartDashboardItem4.DataItemRepository.Add(Dimension5, "DataItem1")
            Me.ChartDashboardItem4.DataItemRepository.Add(Measure4, "DataItem0")
            Me.ChartDashboardItem4.DataSource = Me.DataSource5
            Me.ChartDashboardItem4.IgnoreMasterFilters = False
            Me.ChartDashboardItem4.Name = "Monthly Payment to Suppliers"
            ChartPane4.Name = "Pane 1"
            ChartPane4.PrimaryAxisY.ShowGridLines = True
            ChartPane4.PrimaryAxisY.Title = "Amount"
            ChartPane4.PrimaryAxisY.TitleVisible = True
            ChartPane4.SecondaryAxisY.ShowGridLines = False
            ChartPane4.SecondaryAxisY.TitleVisible = True
            SimpleSeries4.Name = "amnt (Sum)"
            SimpleSeries4.AddDataItem("Value", Measure4)
            ChartPane4.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries4})
            Me.ChartDashboardItem4.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane4})
            Me.ChartDashboardItem4.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5})
            Me.ChartDashboardItem4.ShowCaption = True
            '
            'Dsinvpayvw1
            '
            Me.Dsinvpayvw1.DataSetName = "dsinvpayvw"
            Me.Dsinvpayvw1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DataSource5
            '
            Me.DataSource5.ComponentName = "DataSource5"
            Me.DataSource5.DataProviderSerializable = resources.GetString("DataSource5.DataProviderSerializable")
            Me.DataSource5.Name = "dsInvpd"
            '
            'OverviewDashBoard
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1, Me.DataSource2, Me.DataSource3, Me.DataSource5})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1, Me.ChartDashboardItem2, Me.ChartDashboardItem3, Me.ChartDashboardItem4})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem1.Weight = 49.558638083228246R
            DashboardLayoutItem2.DashboardItem = Me.ChartDashboardItem3
            DashboardLayoutItem2.Weight = 50.441361916771754R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup2.Weight = 49.90439770554493R
            DashboardLayoutItem3.DashboardItem = Me.ChartDashboardItem4
            DashboardLayoutItem3.Weight = 49.936948297604033R
            DashboardLayoutItem4.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem4.Weight = 50.063051702395967R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem3, DashboardLayoutItem4})
            DashboardLayoutGroup3.Weight = 50.09560229445507R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup3})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Overview"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Dsinvpayvw1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents DataSource2 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents DataSource3 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents ChartDashboardItem3 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem4 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents DataSource5 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents Dsinvpayvw1 As DoorsPOS.WinApp.dsinvpayvw

#End Region
    End Class
End Namespace