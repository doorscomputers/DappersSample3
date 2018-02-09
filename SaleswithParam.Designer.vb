Namespace Win_Dashboards
    Partial Public Class SaleswithParam
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
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn2 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim GridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardParameter1 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DynamicListLookUpSettings1 As DevExpress.DashboardCommon.DynamicListLookUpSettings = New DevExpress.DashboardCommon.DynamicListLookUpSettings()
            Dim DashboardParameter2 As DevExpress.DashboardCommon.DashboardParameter = New DevExpress.DashboardCommon.DashboardParameter()
            Dim DynamicListLookUpSettings2 As DevExpress.DashboardCommon.DynamicListLookUpSettings = New DevExpress.DashboardCommon.DynamicListLookUpSettings()
            Me.GridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.DsSalesArchive1 = New DoorsPOS.WinApp.dsSalesArchive()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DsSalesArchive1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'GridDashboardItem1
            '
            Dimension1.DataMember = "dtInsert_dt"
            Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DateHourMinute
            GridDimensionColumn1.AddDataItem("Dimension", Dimension1)
            Dimension2.DataMember = "item_desc"
            GridDimensionColumn2.AddDataItem("Dimension", Dimension2)
            Measure1.DataMember = "qty"
            GridMeasureColumn1.AddDataItem("Measure", Measure1)
            Measure2.DataMember = "det_amnt"
            Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number
            Measure2.NumericFormat.IncludeGroupSeparator = True
            Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones
            GridMeasureColumn2.AddDataItem("Measure", Measure2)
            Me.GridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridMeasureColumn1, GridMeasureColumn2})
            Me.GridDashboardItem1.ComponentName = "GridDashboardItem1"
            Me.GridDashboardItem1.DataItemRepository.Clear()
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.GridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem2")
            Me.GridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem3")
            Me.GridDashboardItem1.DataSource = Me.DataSource1
            Me.GridDashboardItem1.IgnoreMasterFilters = False
            Me.GridDashboardItem1.Name = "Grid 1"
            Me.GridDashboardItem1.ShowCaption = True
            '
            'DataSource1
            '
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.Data = Me.DsSalesArchive1
            Me.DataSource1.DataMember = "vwSalesArchive"
            Me.DataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client
            Me.DataSource1.Filter = "[pos_date] >= ?FromDate And [pos_date] <= ?EndDate"
            Me.DataSource1.Name = "Data Source 1"
            '
            'DsSalesArchive1
            '
            Me.DsSalesArchive1.DataSetName = "dsSalesArchive"
            Me.DsSalesArchive1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'SaleswithParam
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.GridDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.GridDashboardItem1
            DashboardLayoutItem1.Weight = 100.0R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            DynamicListLookUpSettings1.DataSourceName = "DataSource1"
            DynamicListLookUpSettings1.DisplayMember = "pos_date"
            DynamicListLookUpSettings1.ValueMember = "pos_date"
            DashboardParameter1.LookUpSettings = DynamicListLookUpSettings1
            DashboardParameter1.Name = "EndDate"
            DashboardParameter1.Type = GetType(Date)
            DashboardParameter1.Value = New Date(CType(0, Long))
            DynamicListLookUpSettings2.DataSourceName = "DataSource1"
            DynamicListLookUpSettings2.DisplayMember = "pos_date"
            DynamicListLookUpSettings2.ValueMember = "pos_date"
            DashboardParameter2.LookUpSettings = DynamicListLookUpSettings2
            DashboardParameter2.Name = "FromDate"
            DashboardParameter2.Type = GetType(Date)
            DashboardParameter2.Value = New Date(CType(0, Long))
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() {DashboardParameter1, DashboardParameter2})
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DsSalesArchive1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents GridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents DsSalesArchive1 As DoorsPOS.WinApp.dsSalesArchive

#End Region
    End Class
End Namespace