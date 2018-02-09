<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefundsToday
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
        Me.VwSales2dayItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesTodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesToday = New DoorsPOS.WinApp.dsSalesToday()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwSales2dayItemsTableAdapter = New DoorsPOS.WinApp.dsSalesTodayTableAdapters.vwSales2dayItemsTableAdapter()
        Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSales2dayItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesTodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.VwSales2dayItemsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(958, 453)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwSales2dayItemsBindingSource
        '
        Me.VwSales2dayItemsBindingSource.DataMember = "vwSales2dayItems"
        Me.VwSales2dayItemsBindingSource.DataSource = Me.DsSalesTodayBindingSource
        '
        'DsSalesTodayBindingSource
        '
        Me.DsSalesTodayBindingSource.DataSource = Me.DsSalesToday
        Me.DsSalesTodayBindingSource.Position = 0
        '
        'DsSalesToday
        '
        Me.DsSalesToday.DataSetName = "dsSalesToday"
        Me.DsSalesToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterString = "IsOutlookIntervalToday([dtInsert_dt]) And [qty] < 1.0"
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceipt, Me.colcustid, Me.collastname, Me.colfirstname, Me.coldtInsert_dt, Me.colitem_desc, Me.colqty, Me.colprice, Me.GridColumn1, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", Me.GridColumn1, "SUM={0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colcustid
        '
        Me.colcustid.Caption = "Customer ID"
        Me.colcustid.FieldName = "custid"
        Me.colcustid.Name = "colcustid"
        Me.colcustid.Width = 77
        '
        'collastname
        '
        Me.collastname.Caption = "Last Name"
        Me.collastname.FieldName = "lastname"
        Me.collastname.Name = "collastname"
        Me.collastname.Width = 117
        '
        'colfirstname
        '
        Me.colfirstname.Caption = "First Name"
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        Me.colfirstname.Width = 121
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date"
        Me.coldtInsert_dt.DisplayFormat.FormatString = "G"
        Me.coldtInsert_dt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Date]
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 1
        Me.coldtInsert_dt.Width = 235
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Items Returned"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 3
        Me.colitem_desc.Width = 243
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty Sold"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        Me.colqty.Width = 168
        '
        'colprice
        '
        Me.colprice.AppearanceHeader.Options.UseTextOptions = True
        Me.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colprice.Caption = "Price"
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        Me.colprice.Width = 119
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Amount"
        Me.GridColumn1.DisplayFormat.FormatString = "n2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", "SUM={0:n2}")})
        Me.GridColumn1.UnboundExpression = "[price] * [qty]"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 432
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Width = 115
        '
        'VwSales2dayItemsTableAdapter
        '
        Me.VwSales2dayItemsTableAdapter.ClearBeforeFill = True
        '
        'colReceipt
        '
        Me.colReceipt.Caption = "Ref #"
        Me.colReceipt.FieldName = "Receipt"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.Visible = True
        Me.colReceipt.VisibleIndex = 0
        '
        'frmRefundsToday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 453)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmRefundsToday"
        Me.Text = "Refunds Today"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSales2dayItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesTodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents VwSales2dayItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSalesTodayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSalesToday As DoorsPOS.WinApp.dsSalesToday
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VwSales2dayItemsTableAdapter As DoorsPOS.WinApp.dsSalesTodayTableAdapters.vwSales2dayItemsTableAdapter
    Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
End Class
