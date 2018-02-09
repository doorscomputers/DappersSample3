<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvCostGrid
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
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemCostRetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemCostRetail = New DoorsPOS.WinApp.dsItemCostRetail()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colavailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CostAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RetailAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StocksTableAdapter = New DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemCostRetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemCostRetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StocksBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(890, 491)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.DsItemCostRetailBindingSource
        '
        'DsItemCostRetailBindingSource
        '
        Me.DsItemCostRetailBindingSource.DataSource = Me.DsItemCostRetail
        Me.DsItemCostRetailBindingSource.Position = 0
        '
        'DsItemCostRetail
        '
        Me.DsItemCostRetail.DataSetName = "dsItemCostRetail"
        Me.DsItemCostRetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colitem_desc, Me.colavailable, Me.colcost, Me.colretail, Me.CostAmount, Me.RetailAmount})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colretail, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        Me.colitem_desc.Width = 326
        '
        'colavailable
        '
        Me.colavailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colavailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colavailable.Caption = "Available"
        Me.colavailable.FieldName = "available"
        Me.colavailable.Name = "colavailable"
        Me.colavailable.Visible = True
        Me.colavailable.VisibleIndex = 1
        Me.colavailable.Width = 67
        '
        'colcost
        '
        Me.colcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost.Caption = "Cost"
        Me.colcost.DisplayFormat.FormatString = "N2"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.Name = "colcost"
        Me.colcost.Visible = True
        Me.colcost.VisibleIndex = 2
        Me.colcost.Width = 99
        '
        'colretail
        '
        Me.colretail.AppearanceHeader.Options.UseTextOptions = True
        Me.colretail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colretail.Caption = "Retail"
        Me.colretail.DisplayFormat.FormatString = "N2"
        Me.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail.FieldName = "retail"
        Me.colretail.Name = "colretail"
        Me.colretail.Visible = True
        Me.colretail.VisibleIndex = 3
        Me.colretail.Width = 115
        '
        'CostAmount
        '
        Me.CostAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.CostAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CostAmount.Caption = "Cost Amount"
        Me.CostAmount.DisplayFormat.FormatString = "N2"
        Me.CostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostAmount.FieldName = "CostAmount"
        Me.CostAmount.Name = "CostAmount"
        Me.CostAmount.UnboundExpression = "[available] * [cost]"
        Me.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.CostAmount.Visible = True
        Me.CostAmount.VisibleIndex = 4
        Me.CostAmount.Width = 217
        '
        'RetailAmount
        '
        Me.RetailAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.RetailAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RetailAmount.Caption = "Retail Amount"
        Me.RetailAmount.DisplayFormat.FormatString = "N2"
        Me.RetailAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RetailAmount.FieldName = "RetailAmount"
        Me.RetailAmount.Name = "RetailAmount"
        Me.RetailAmount.UnboundExpression = "[available] * [retail]"
        Me.RetailAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.RetailAmount.Visible = True
        Me.RetailAmount.VisibleIndex = 5
        Me.RetailAmount.Width = 242
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'frmInvCostGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 491)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmInvCostGrid"
        Me.Text = "Inventory Cost Grid"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemCostRetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemCostRetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colavailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsItemCostRetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsItemCostRetail As DoorsPOS.WinApp.dsItemCostRetail
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter
    Friend WithEvents CostAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RetailAmount As DevExpress.XtraGrid.Columns.GridColumn
End Class
