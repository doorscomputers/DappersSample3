<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvCostPivt
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
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemCostRetail = New DoorsPOS.WinApp.dsItemCostRetail()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldavailable1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldcost1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CostAmnt = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldretail1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.StocksTableAdapter = New DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemCostRetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.StocksBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielditemdesc1, Me.fieldavailable1, Me.fieldcost1, Me.PivotGridField2, Me.CostAmnt, Me.fieldretail1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(868, 451)
        Me.PivotGridControl1.TabIndex = 0
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.DsItemCostRetail
        '
        'DsItemCostRetail
        '
        Me.DsItemCostRetail.DataSetName = "dsItemCostRetail"
        Me.DsItemCostRetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 0
        Me.fielditemdesc1.Caption = "Item Description"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        Me.fielditemdesc1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fielditemdesc1.Width = 208
        '
        'fieldavailable1
        '
        Me.fieldavailable1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldavailable1.AreaIndex = 1
        Me.fieldavailable1.Caption = "Available"
        Me.fieldavailable1.FieldName = "available"
        Me.fieldavailable1.Name = "fieldavailable1"
        Me.fieldavailable1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldcost1
        '
        Me.fieldcost1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldcost1.AreaIndex = 2
        Me.fieldcost1.Caption = "Item Cost"
        Me.fieldcost1.CellFormat.FormatString = "N2"
        Me.fieldcost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldcost1.FieldName = "cost"
        Me.fieldcost1.GrandTotalText = "Total"
        Me.fieldcost1.Name = "fieldcost1"
        Me.fieldcost1.TotalCellFormat.FormatString = "N2"
        Me.fieldcost1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldcost1.TotalValueFormat.FormatString = "N2"
        Me.fieldcost1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldcost1.ValueFormat.FormatString = "N2"
        Me.fieldcost1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Retail Amount"
        Me.PivotGridField2.CellFormat.FormatString = "N2"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.PivotGridField2.TotalCellFormat.FormatString = "N2"
        Me.PivotGridField2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.TotalValueFormat.FormatString = "N2"
        Me.PivotGridField2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.UnboundExpression = "[available] * [retail]"
        Me.PivotGridField2.UnboundFieldName = "PivotGridField2"
        Me.PivotGridField2.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField2.ValueFormat.FormatString = "N2"
        Me.PivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'CostAmnt
        '
        Me.CostAmnt.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.CostAmnt.AreaIndex = 0
        Me.CostAmnt.Caption = "Cost Amount"
        Me.CostAmnt.CellFormat.FormatString = "N2"
        Me.CostAmnt.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CostAmnt.Name = "CostAmnt"
        Me.CostAmnt.UnboundExpression = "[available] * [cost]"
        Me.CostAmnt.UnboundFieldName = "CostAmnt"
        Me.CostAmnt.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'fieldretail1
        '
        Me.fieldretail1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldretail1.AreaIndex = 3
        Me.fieldretail1.Caption = "Item Price"
        Me.fieldretail1.CellFormat.FormatString = "N2"
        Me.fieldretail1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldretail1.FieldName = "retail"
        Me.fieldretail1.Name = "fieldretail1"
        Me.fieldretail1.ValueFormat.FormatString = "N2"
        Me.fieldretail1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'frmInvCostPivt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 451)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmInvCostPivt"
        Me.Text = "Inventory Cost with Amount Total"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemCostRetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsItemCostRetail As DoorsPOS.WinApp.dsItemCostRetail
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldavailable1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldcost1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CostAmnt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldretail1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
