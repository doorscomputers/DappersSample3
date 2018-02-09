<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesWithNet
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
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsSalesWithCost = New DoorsPOS.WinApp.dsSalesWithCost()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwSaleswCostBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CostAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Profit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwSaleswCostTableAdapter = New DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesWithCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSaleswCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsSalesWithCost
        Me.C1DataViewSet1.DiagramXML = ""
        '
        'DsSalesWithCost
        '
        Me.DsSalesWithCost.DataSetName = "dsSalesWithCost"
        Me.DsSalesWithCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwSaleswCostBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1059, 487)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwSaleswCostBindingSource
        '
        Me.VwSaleswCostBindingSource.DataMember = "vwSaleswCost"
        Me.VwSaleswCostBindingSource.DataSource = Me.DsSalesWithCost
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colitem_desc, Me.colcost, Me.colprice, Me.colqty, Me.coldet_amnt, Me.CostAmount, Me.Profit})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "cost", Me.colcost, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", Me.coldet_amnt, "SUM={0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Profit", Me.Profit, "SUM={0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostAmount", Me.CostAmount, "SUM={0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "SUM={0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date Sold"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 113
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Sold"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        Me.colitem_desc.Width = 228
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
        Me.colcost.Width = 115
        '
        'colprice
        '
        Me.colprice.AppearanceHeader.Options.UseTextOptions = True
        Me.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colprice.Caption = "Price"
        Me.colprice.DisplayFormat.FormatString = "N2"
        Me.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 3
        Me.colprice.Width = 115
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty Sold"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "SUM={0:0.##}")})
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 4
        Me.colqty.Width = 115
        '
        'coldet_amnt
        '
        Me.coldet_amnt.AppearanceHeader.Options.UseTextOptions = True
        Me.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldet_amnt.Caption = "Sold Amount"
        Me.coldet_amnt.DisplayFormat.FormatString = "N2"
        Me.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldet_amnt.FieldName = "det_amnt"
        Me.coldet_amnt.Name = "coldet_amnt"
        Me.coldet_amnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", "SUM={0:N2}")})
        Me.coldet_amnt.Visible = True
        Me.coldet_amnt.VisibleIndex = 6
        Me.coldet_amnt.Width = 115
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
        Me.CostAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostAmount", "SUM={0:N2}")})
        Me.CostAmount.UnboundExpression = "[cost] * [qty]"
        Me.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.CostAmount.Visible = True
        Me.CostAmount.VisibleIndex = 5
        Me.CostAmount.Width = 115
        '
        'Profit
        '
        Me.Profit.AppearanceHeader.Options.UseTextOptions = True
        Me.Profit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Profit.Caption = "Profit"
        Me.Profit.DisplayFormat.FormatString = "N2"
        Me.Profit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Profit.FieldName = "Profit"
        Me.Profit.Name = "Profit"
        Me.Profit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Profit", "SUM={0:N2}")})
        Me.Profit.UnboundExpression = "[det_amnt] - [CostAmount]"
        Me.Profit.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Profit.Visible = True
        Me.Profit.VisibleIndex = 7
        Me.Profit.Width = 130
        '
        'VwSaleswCostTableAdapter
        '
        Me.VwSaleswCostTableAdapter.ClearBeforeFill = True
        '
        'frmSalesWithNet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 487)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmSalesWithNet"
        Me.Text = "Sales With Computed Profit based on Cost when the Item was Sold"
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesWithCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSaleswCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsSalesWithCost As DoorsPOS.WinApp.dsSalesWithCost
    Friend WithEvents VwSaleswCostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSaleswCostTableAdapter As DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CostAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Profit As DevExpress.XtraGrid.Columns.GridColumn
End Class
