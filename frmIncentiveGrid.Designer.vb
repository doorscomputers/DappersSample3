﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncentiveGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpIncentiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSpIncentive = New DoorsPOS.WinApp.dsSpIncentive()
        Me.grdIncentives = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colincentive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwaiter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwtid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIncentives1 = New DoorsPOS.WinApp.dsIncentives()
        Me.VwIncentivesTableAdapter1 = New DoorsPOS.WinApp.dsIncentivesTableAdapters.vwIncentivesTableAdapter()
        Me.SpIncentiveTableAdapter = New DoorsPOS.WinApp.dsSpIncentiveTableAdapters.spIncentiveTableAdapter()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpIncentiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSpIncentive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdIncentives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncentives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.SpIncentiveBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.grdIncentives
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(980, 389)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdIncentives})
        '
        'SpIncentiveBindingSource
        '
        Me.SpIncentiveBindingSource.DataMember = "spIncentive"
        Me.SpIncentiveBindingSource.DataSource = Me.DsSpIncentive
        '
        'DsSpIncentive
        '
        Me.DsSpIncentive.DataSetName = "dsSpIncentive"
        Me.DsSpIncentive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdIncentives
        '
        Me.grdIncentives.ActiveFilterString = "IsThisMonth([pos_date])"
        Me.grdIncentives.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpos_date, Me.GridColumn1, Me.colincentive, Me.colqty, Me.colwaiter, Me.GridColumn2, Me.colwtid})
        Me.grdIncentives.GridControl = Me.GridControl1
        Me.grdIncentives.GroupCount = 1
        Me.grdIncentives.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "incentive", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "incentive", Me.colincentive, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Nothing, "SUM={0:0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "SUM={0:0.##}")})
        Me.grdIncentives.Name = "grdIncentives"
        Me.grdIncentives.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.grdIncentives.OptionsView.ShowFooter = True
        Me.grdIncentives.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colwaiter, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Date Sold"
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.OptionsColumn.ReadOnly = True
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 0
        Me.colpos_date.Width = 192
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Item Sold"
        Me.GridColumn1.FieldName = "item_desc"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 480
        '
        'colincentive
        '
        Me.colincentive.Caption = "Incentive Amount"
        Me.colincentive.DisplayFormat.FormatString = "N2"
        Me.colincentive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colincentive.FieldName = "incentive"
        Me.colincentive.GroupFormat.FormatString = "N2"
        Me.colincentive.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colincentive.Name = "colincentive"
        Me.colincentive.OptionsColumn.ReadOnly = True
        Me.colincentive.Visible = True
        Me.colincentive.VisibleIndex = 3
        Me.colincentive.Width = 129
        '
        'colqty
        '
        Me.colqty.Caption = "Qty"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        Me.colqty.Width = 62
        '
        'colwaiter
        '
        Me.colwaiter.Caption = "Employee Name"
        Me.colwaiter.FieldName = "waiter"
        Me.colwaiter.Name = "colwaiter"
        Me.colwaiter.OptionsColumn.ReadOnly = True
        Me.colwaiter.Visible = True
        Me.colwaiter.VisibleIndex = 3
        Me.colwaiter.Width = 122
        '
        'colwtid
        '
        Me.colwtid.FieldName = "wtid"
        Me.colwtid.Name = "colwtid"
        Me.colwtid.OptionsColumn.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "vwIncentives"
        Me.BindingSource1.DataSource = Me.DsIncentives1
        Me.BindingSource1.Sort = ""
        '
        'DsIncentives1
        '
        Me.DsIncentives1.DataSetName = "dsIncentives"
        Me.DsIncentives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwIncentivesTableAdapter1
        '
        Me.VwIncentivesTableAdapter1.ClearBeforeFill = True
        '
        'SpIncentiveTableAdapter
        '
        Me.SpIncentiveTableAdapter.ClearBeforeFill = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Amount"
        Me.GridColumn2.DisplayFormat.FormatString = "N2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn2", "SUM={0:N2}")})
        Me.GridColumn2.UnboundExpression = "[incentive] * [qty]"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'frmIncentiveGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 389)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmIncentiveGrid"
        Me.Text = "Incentives Grid View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpIncentiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSpIncentive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdIncentives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncentives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdIncentives As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsIncentives1 As DoorsPOS.WinApp.dsIncentives
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colincentive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwaiter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwtid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VwIncentivesTableAdapter1 As DoorsPOS.WinApp.dsIncentivesTableAdapters.vwIncentivesTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsSpIncentive As DoorsPOS.WinApp.dsSpIncentive
    Friend WithEvents SpIncentiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpIncentiveTableAdapter As DoorsPOS.WinApp.dsSpIncentiveTableAdapters.spIncentiveTableAdapter
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class