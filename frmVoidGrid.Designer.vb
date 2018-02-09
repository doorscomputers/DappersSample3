<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidGrid
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
        Me.VwVoidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVoid = New DoorsPOS.WinApp.dsVoid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwVoidTableAdapter = New DoorsPOS.WinApp.dsVoidTableAdapters.vwVoidTableAdapter()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVoidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVoid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.VwVoidBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(858, 492)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwVoidBindingSource
        '
        Me.VwVoidBindingSource.DataMember = "vwVoid"
        Me.VwVoidBindingSource.DataSource = Me.DsVoid
        '
        'DsVoid
        '
        Me.DsVoid.DataSetName = "dsVoid"
        Me.DsVoid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colitem_desc, Me.colcost, Me.colprice, Me.colqty, Me.GridColumn1, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "SUM={0:0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", Me.GridColumn1, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 118
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
        Me.colcost.Width = 67
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
        Me.colprice.Width = 79
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 1
        Me.colqty.Width = 43
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Amount"
        Me.GridColumn1.DisplayFormat.FormatString = "N2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", "SUM={0:N2}")})
        Me.GridColumn1.UnboundExpression = "[qty] * [price]"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 94
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 5
        Me.colsInsert_id.Width = 321
        '
        'VwVoidTableAdapter
        '
        Me.VwVoidTableAdapter.ClearBeforeFill = True
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        Me.colitem_desc.Width = 474
        '
        'frmVoidGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 492)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoidGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Void Items Grid View"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVoidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVoid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsVoid As DoorsPOS.WinApp.dsVoid
    Friend WithEvents VwVoidBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwVoidTableAdapter As DoorsPOS.WinApp.dsVoidTableAdapters.vwVoidTableAdapter
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
End Class
