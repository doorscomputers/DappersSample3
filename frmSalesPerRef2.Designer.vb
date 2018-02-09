<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesPerRef2
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
        Me.VwSalesRefMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dssalesref2 = New DoorsPOS.WinApp.dssalesref2()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpostmp_hdrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwSalesRefMainTableAdapter = New DoorsPOS.WinApp.dssalesref2TableAdapters.vwSalesRefMainTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSalesRefMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dssalesref2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwSalesRefMainBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(993, 492)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwSalesRefMainBindingSource
        '
        Me.VwSalesRefMainBindingSource.DataMember = "vwSalesRefMain"
        Me.VwSalesRefMainBindingSource.DataSource = Me.Dssalesref2
        '
        'Dssalesref2
        '
        Me.Dssalesref2.DataSetName = "dssalesref2"
        Me.Dssalesref2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpos_date, Me.colpostmp_hdrid, Me.colitem_desc, Me.colcost, Me.colprice, Me.coldet_amnt, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", Me.coldet_amnt, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpos_date, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpostmp_hdrid, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Date"
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 0
        '
        'colpostmp_hdrid
        '
        Me.colpostmp_hdrid.AppearanceCell.Options.UseTextOptions = True
        Me.colpostmp_hdrid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colpostmp_hdrid.AppearanceHeader.Options.UseTextOptions = True
        Me.colpostmp_hdrid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colpostmp_hdrid.Caption = "Reference No."
        Me.colpostmp_hdrid.FieldName = "postmp_hdrid"
        Me.colpostmp_hdrid.Name = "colpostmp_hdrid"
        Me.colpostmp_hdrid.Visible = True
        Me.colpostmp_hdrid.VisibleIndex = 0
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        '
        'colcost
        '
        Me.colcost.Caption = "Cost"
        Me.colcost.DisplayFormat.FormatString = "N2"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.Name = "colcost"
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
        Me.colprice.VisibleIndex = 1
        '
        'coldet_amnt
        '
        Me.coldet_amnt.AppearanceHeader.Options.UseTextOptions = True
        Me.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldet_amnt.Caption = "Amount"
        Me.coldet_amnt.DisplayFormat.FormatString = "N2"
        Me.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldet_amnt.FieldName = "det_amnt"
        Me.coldet_amnt.Name = "coldet_amnt"
        Me.coldet_amnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", "SUM={0:N2}")})
        Me.coldet_amnt.Visible = True
        Me.coldet_amnt.VisibleIndex = 3
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
        Me.colsInsert_id.VisibleIndex = 2
        '
        'VwSalesRefMainTableAdapter
        '
        Me.VwSalesRefMainTableAdapter.ClearBeforeFill = True
        '
        'frmSalesPerRef2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 492)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmSalesPerRef2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Past Sales Per Reference No."
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSalesRefMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dssalesref2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Dssalesref2 As DoorsPOS.WinApp.dssalesref2
    Friend WithEvents VwSalesRefMainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSalesRefMainTableAdapter As DoorsPOS.WinApp.dssalesref2TableAdapters.vwSalesRefMainTableAdapter
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpostmp_hdrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
