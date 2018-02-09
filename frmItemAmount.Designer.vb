<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemAmount
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
        Me.DsItemCost = New DoorsPOS.WinApp.dsItemCost()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colavailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StocksTableAdapter = New DoorsPOS.WinApp.dsItemCostTableAdapters.stocksTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemCost, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridControl1.Size = New System.Drawing.Size(920, 478)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.DsItemCost
        '
        'DsItemCost
        '
        Me.DsItemCost.DataSetName = "dsItemCost"
        Me.DsItemCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbarcode, Me.colitem_desc, Me.colavailable, Me.colcost, Me.colretail, Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colbarcode
        '
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        '
        'colavailable
        '
        Me.colavailable.AppearanceCell.Options.UseTextOptions = True
        Me.colavailable.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colavailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colavailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colavailable.Caption = "On Hand"
        Me.colavailable.DisplayFormat.FormatString = "N2"
        Me.colavailable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colavailable.FieldName = "available"
        Me.colavailable.Name = "colavailable"
        Me.colavailable.Visible = True
        Me.colavailable.VisibleIndex = 1
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
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Cost Amount"
        Me.GridColumn1.DisplayFormat.FormatString = "N2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", "SUM={0:N2}")})
        Me.GridColumn1.UnboundExpression = "[cost]  * [available]"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.Caption = "Retail Amount"
        Me.GridColumn2.DisplayFormat.FormatString = "N2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn2", "SUM={0:N2}")})
        Me.GridColumn2.UnboundExpression = "[retail] * [available]"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'frmItemAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 478)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmItemAmount"
        Me.Text = "Items with Cost Amount"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsItemCost As DoorsPOS.WinApp.dsItemCost
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colavailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As DoorsPOS.WinApp.dsItemCostTableAdapters.stocksTableAdapter
End Class
