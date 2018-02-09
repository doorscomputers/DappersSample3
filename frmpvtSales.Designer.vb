<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpvtSales
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
        Me.DsItemsSold = New DoorsPOS.WinApp.dsItemsSold()
        Me.VwSalesBindingSource = New System.Windows.Forms.BindingSource()
        Me.VwSalesTableAdapter = New DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemsSold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsItemsSold
        Me.C1DataViewSet1.DiagramXML = ""
        '
        'DsItemsSold
        '
        Me.DsItemsSold.DataSetName = "dsItemsSold"
        Me.DsItemsSold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwSalesBindingSource
        '
        Me.VwSalesBindingSource.DataMember = "vwSales"
        Me.VwSalesBindingSource.DataSource = Me.DsItemsSold
        '
        'VwSalesTableAdapter
        '
        Me.VwSalesTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwSalesBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1071, 488)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colitem_desc, Me.colprice, Me.colqty, Me.coldet_amnt})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "(SUM={0:#}) "), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", Me.coldet_amnt, "(SUM={0:#.##}) ")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date Sold"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 153
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Items Sold"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        Me.colitem_desc.Width = 364
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
        Me.colprice.Width = 193
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colqty.Caption = "Qty Sold"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", "SUM={0:0.##}")})
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        Me.colqty.Width = 108
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
        Me.coldet_amnt.Width = 248
        '
        'frmpvtSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 488)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmpvtSales"
        Me.Text = "Items Sold"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemsSold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents DsItemsSold As DoorsPOS.WinApp.dsItemsSold
    Friend WithEvents VwSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSalesTableAdapter As DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
End Class
