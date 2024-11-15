<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveryGrid
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
        Me.VwDlvryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwDeliveriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwDeliveries = New DoorsPOS.WinApp.dsvwDeliveries()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfreee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrdetamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwDlvryDetailsTableAdapter = New DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDlvryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwDeliveriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwDlvryDetailsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(929, 468)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwDlvryDetailsBindingSource
        '
        Me.VwDlvryDetailsBindingSource.DataMember = "vwDlvryDetails"
        Me.VwDlvryDetailsBindingSource.DataSource = Me.DsvwDeliveriesBindingSource
        '
        'DsvwDeliveriesBindingSource
        '
        Me.DsvwDeliveriesBindingSource.DataSource = Me.DsvwDeliveries
        Me.DsvwDeliveriesBindingSource.Position = 0
        '
        'DsvwDeliveries
        '
        Me.DsvwDeliveries.DataSetName = "dsvwDeliveries"
        Me.DsvwDeliveries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colsupplier, Me.coldrid, Me.colitem_desc, Me.colcost, Me.colqty, Me.colfreee, Me.coldrdetamnt, Me.colsInsert_id, Me.colexpdate, Me.collotno})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 3
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "drdetamnt", Me.coldrdetamnt, "SUM={0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "item_desc", Me.colitem_desc, "ITEM COUNT={0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colsupplier, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldrid, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 130
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 0
        '
        'coldrid
        '
        Me.coldrid.Caption = "Dr. No."
        Me.coldrid.FieldName = "drinv"
        Me.coldrid.Name = "coldrid"
        Me.coldrid.Visible = True
        Me.coldrid.VisibleIndex = 0
        Me.coldrid.Width = 70
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        Me.colitem_desc.Width = 291
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
        Me.colcost.VisibleIndex = 1
        Me.colcost.Width = 63
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty"
        Me.colqty.DisplayFormat.FormatString = "N0"
        Me.colqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        Me.colqty.Width = 45
        '
        'colfreee
        '
        Me.colfreee.AppearanceHeader.Options.UseTextOptions = True
        Me.colfreee.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colfreee.Caption = "Free"
        Me.colfreee.DisplayFormat.FormatString = "N0"
        Me.colfreee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colfreee.FieldName = "freee"
        Me.colfreee.Name = "colfreee"
        Me.colfreee.Visible = True
        Me.colfreee.VisibleIndex = 4
        Me.colfreee.Width = 65
        '
        'coldrdetamnt
        '
        Me.coldrdetamnt.AppearanceHeader.Options.UseTextOptions = True
        Me.coldrdetamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldrdetamnt.Caption = "Amount"
        Me.coldrdetamnt.DisplayFormat.FormatString = "N2"
        Me.coldrdetamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldrdetamnt.FieldName = "drdetamnt"
        Me.coldrdetamnt.Name = "coldrdetamnt"
        Me.coldrdetamnt.Visible = True
        Me.coldrdetamnt.VisibleIndex = 3
        Me.coldrdetamnt.Width = 100
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Encoder"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 5
        Me.colsInsert_id.Width = 302
        '
        'colexpdate
        '
        Me.colexpdate.Caption = "Expiration Date"
        Me.colexpdate.FieldName = "expdate"
        Me.colexpdate.Name = "colexpdate"
        Me.colexpdate.Visible = True
        Me.colexpdate.VisibleIndex = 6
        '
        'collotno
        '
        Me.collotno.Caption = "Lot No."
        Me.collotno.FieldName = "lotno"
        Me.collotno.Name = "collotno"
        Me.collotno.Visible = True
        Me.collotno.VisibleIndex = 7
        '
        'VwDlvryDetailsTableAdapter
        '
        Me.VwDlvryDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmDeliveryGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 468)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmDeliveryGrid"
        Me.Text = "Deliveries Grid View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDlvryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwDeliveriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsvwDeliveriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsvwDeliveries As DoorsPOS.WinApp.dsvwDeliveries
    Friend WithEvents VwDlvryDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwDlvryDetailsTableAdapter As DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfreee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrdetamnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collotno As DevExpress.XtraGrid.Columns.GridColumn
End Class
