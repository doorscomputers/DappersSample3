<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesWithNetPvt
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.VwSaleswCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesWithCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesWithCost = New DoorsPOS.WinApp.dsSalesWithCost()
        Me.fielddtInsertdt1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldprice1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddetamnt1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldcost1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CostAmount = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.Profit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddtInsertdt = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddtInsertdt2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddtInsertdt3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwSaleswCostTableAdapter = New DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSaleswCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesWithCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesWithCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwSaleswCostBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielddtInsertdt1, Me.fielditemdesc1, Me.fieldprice1, Me.fieldqty1, Me.fielddetamnt1, Me.fieldcost1, Me.CostAmount, Me.Profit, Me.fielddtInsertdt, Me.fielddtInsertdt2, Me.fielddtInsertdt3})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(876, 446)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwSaleswCostBindingSource
        '
        Me.VwSaleswCostBindingSource.DataMember = "vwSaleswCost"
        Me.VwSaleswCostBindingSource.DataSource = Me.DsSalesWithCostBindingSource
        '
        'DsSalesWithCostBindingSource
        '
        Me.DsSalesWithCostBindingSource.DataSource = Me.DsSalesWithCost
        Me.DsSalesWithCostBindingSource.Position = 0
        '
        'DsSalesWithCost
        '
        Me.DsSalesWithCost.DataSetName = "dsSalesWithCost"
        Me.DsSalesWithCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielddtInsertdt1
        '
        Me.fielddtInsertdt1.AreaIndex = 0
        Me.fielddtInsertdt1.Caption = "Date Sold"
        Me.fielddtInsertdt1.FieldName = "dtInsert_dt"
        Me.fielddtInsertdt1.Name = "fielddtInsertdt1"
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 0
        Me.fielditemdesc1.Caption = "Item Description"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        Me.fielditemdesc1.Width = 106
        '
        'fieldprice1
        '
        Me.fieldprice1.AreaIndex = 2
        Me.fieldprice1.Caption = "Price"
        Me.fieldprice1.FieldName = "price"
        Me.fieldprice1.Name = "fieldprice1"
        Me.fieldprice1.Width = 69
        '
        'fieldqty1
        '
        Me.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty1.AreaIndex = 0
        Me.fieldqty1.Caption = "Qty Sold"
        Me.fieldqty1.FieldName = "qty"
        Me.fieldqty1.Name = "fieldqty1"
        Me.fieldqty1.Width = 57
        '
        'fielddetamnt1
        '
        Me.fielddetamnt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fielddetamnt1.AreaIndex = 2
        Me.fielddetamnt1.Caption = "Sold Amount"
        Me.fielddetamnt1.FieldName = "det_amnt"
        Me.fielddetamnt1.Name = "fielddetamnt1"
        Me.fielddetamnt1.Width = 83
        '
        'fieldcost1
        '
        Me.fieldcost1.AreaIndex = 1
        Me.fieldcost1.Caption = "Cost"
        Me.fieldcost1.FieldName = "cost"
        Me.fieldcost1.Name = "fieldcost1"
        Me.fieldcost1.Width = 75
        '
        'CostAmount
        '
        Me.CostAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.CostAmount.AreaIndex = 1
        Me.CostAmount.Caption = "Cost Amount"
        Me.CostAmount.Name = "CostAmount"
        Me.CostAmount.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.CostAmount.UnboundExpression = "[cost] * [qty]"
        Me.CostAmount.UnboundFieldName = "PivotGridField1"
        Me.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.CostAmount.Width = 90
        '
        'Profit
        '
        Me.Profit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.Profit.AreaIndex = 3
        Me.Profit.Caption = "Profit"
        Me.Profit.Name = "Profit"
        Me.Profit.UnboundExpression = "[det_amnt] - [PivotGridField1]"
        Me.Profit.UnboundFieldName = "Profit"
        Me.Profit.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fielddtInsertdt
        '
        Me.fielddtInsertdt.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fielddtInsertdt.AreaIndex = 1
        Me.fielddtInsertdt.Caption = "Month"
        Me.fielddtInsertdt.FieldName = "dtInsert_dt"
        Me.fielddtInsertdt.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fielddtInsertdt.Name = "fielddtInsertdt"
        Me.fielddtInsertdt.UnboundFieldName = "fielddtInsertdt"
        '
        'fielddtInsertdt2
        '
        Me.fielddtInsertdt2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fielddtInsertdt2.AreaIndex = 0
        Me.fielddtInsertdt2.Caption = "Year"
        Me.fielddtInsertdt2.FieldName = "dtInsert_dt"
        Me.fielddtInsertdt2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fielddtInsertdt2.Name = "fielddtInsertdt2"
        Me.fielddtInsertdt2.UnboundFieldName = "fielddtInsertdt2"
        '
        'fielddtInsertdt3
        '
        Me.fielddtInsertdt3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielddtInsertdt3.AreaIndex = 1
        Me.fielddtInsertdt3.Caption = "Date Sold"
        Me.fielddtInsertdt3.FieldName = "dtInsert_dt"
        Me.fielddtInsertdt3.Name = "fielddtInsertdt3"
        Me.fielddtInsertdt3.Width = 146
        '
        'VwSaleswCostTableAdapter
        '
        Me.VwSaleswCostTableAdapter.ClearBeforeFill = True
        '
        'frmSalesWithNetPvt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 446)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmSalesWithNetPvt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales With Net Income"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSaleswCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesWithCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesWithCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsSalesWithCostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSalesWithCost As DoorsPOS.WinApp.dsSalesWithCost
    Friend WithEvents VwSaleswCostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSaleswCostTableAdapter As DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter
    Friend WithEvents fielddtInsertdt1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldprice1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddetamnt1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldcost1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CostAmount As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Profit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddtInsertdt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddtInsertdt2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddtInsertdt3 As DevExpress.XtraPivotGrid.PivotGridField
End Class
