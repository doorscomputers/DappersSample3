Namespace Win_Dashboards
    Partial Public Class dbSalesAmount
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dbSalesAmount))
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim DataConnection1 As DevExpress.DataAccess.DataConnection = New DevExpress.DataAccess.DataConnection()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.DataSource2 = New DevExpress.DashboardCommon.DataSource()
            Me.DsSale2dayCashr2 = New DoorsPOS.WinApp.dsSale2dayCashr()
            Me.DataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.DsSale2dayCashr1 = New DoorsPOS.WinApp.dsSale2dayCashr()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DsSale2dayCashr2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DsSale2dayCashr1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'DataSource2
            '
            Me.DataSource2.ComponentName = "DataSource2"
            Me.DataSource2.Data = Me.DsSale2dayCashr2
            Me.DataSource2.DataMember = "vwSalesTodayCshr"
            Me.DataSource2.Name = "Data Source 1"
            '
            'DsSale2dayCashr2
            '
            Me.DsSale2dayCashr2.DataSetName = "dsSale2dayCashr"
            Me.DsSale2dayCashr2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DataSource1
            '
            Me.DataSource1.ComponentName = "DataSource1"
            Me.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable")
            Me.DataSource1.Filter = ""
            Me.DataSource1.Name = "dsSales3"
            '
            'DsSale2dayCashr1
            '
            Me.DsSale2dayCashr1.DataSetName = "dsSale2dayCashr"
            Me.DsSale2dayCashr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ChartDashboardItem1
            '
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Chart 1"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'dbSalesAmount
            '
            DataConnection1.Name = "DOORSCOMPUTERS\SQLEXPRESS_doorsposConnection"
            DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable")
            DataConnection1.ProviderKey = "MSSqlServer"
            Me.DataConnections.Add(DataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() {Me.DataSource1, Me.DataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ChartDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem1.Weight = 100.0R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1})
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Me.DataSource2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DsSale2dayCashr2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DsSale2dayCashr1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DataSource1 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents DataSource2 As DevExpress.DashboardCommon.DataSource
        Friend WithEvents DsSale2dayCashr2 As DoorsPOS.WinApp.dsSale2dayCashr
        Friend WithEvents DsSale2dayCashr1 As DoorsPOS.WinApp.dsSale2dayCashr
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem

#End Region
    End Class
End Namespace