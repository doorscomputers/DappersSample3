<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyPrcHistory
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwBuyPriceHistoryBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsBuyPrice = New DoorsPOS.WinApp.dsBuyPrice()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DsBuyPriceBindingSource = New System.Windows.Forms.BindingSource()
        Me.VwBuyPriceHistoryTableAdapter = New DoorsPOS.WinApp.dsBuyPriceTableAdapters.vwBuyPriceHistoryTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBuyPriceHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBuyPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBuyPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwBuyPriceHistoryBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(687, 519)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwBuyPriceHistoryBindingSource
        '
        Me.VwBuyPriceHistoryBindingSource.DataMember = "vwBuyPriceHistory"
        Me.VwBuyPriceHistoryBindingSource.DataSource = Me.DsBuyPrice
        '
        'DsBuyPrice
        '
        Me.DsBuyPrice.DataSetName = "dsBuyPrice"
        Me.DsBuyPrice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcost, Me.colitem_desc, Me.coldrdate, Me.colsupplier})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colsupplier, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colcost
        '
        Me.colcost.AppearanceCell.Options.UseTextOptions = True
        Me.colcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost.Caption = "Cost"
        Me.colcost.DisplayFormat.FormatString = "N2"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.Name = "colcost"
        Me.colcost.Visible = True
        Me.colcost.VisibleIndex = 1
        Me.colcost.Width = 104
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        '
        'coldrdate
        '
        Me.coldrdate.Caption = "Purchase Date "
        Me.coldrdate.FieldName = "drdate"
        Me.coldrdate.Name = "coldrdate"
        Me.coldrdate.Visible = True
        Me.coldrdate.VisibleIndex = 0
        Me.coldrdate.Width = 354
        '
        'colsupplier
        '
        Me.colsupplier.AppearanceCell.Options.UseTextOptions = True
        Me.colsupplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 2
        Me.colsupplier.Width = 606
        '
        'DsBuyPriceBindingSource
        '
        Me.DsBuyPriceBindingSource.DataSource = Me.DsBuyPrice
        Me.DsBuyPriceBindingSource.Position = 0
        '
        'VwBuyPriceHistoryTableAdapter
        '
        Me.VwBuyPriceHistoryTableAdapter.ClearBeforeFill = True
        '
        'frmBuyPrcHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 519)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBuyPrcHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Buying Price History"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBuyPriceHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBuyPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBuyPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsBuyPrice As DoorsPOS.WinApp.dsBuyPrice
    Friend WithEvents VwBuyPriceHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwBuyPriceHistoryTableAdapter As DoorsPOS.WinApp.dsBuyPriceTableAdapters.vwBuyPriceHistoryTableAdapter
    Friend WithEvents coldrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsBuyPriceBindingSource As System.Windows.Forms.BindingSource
End Class
