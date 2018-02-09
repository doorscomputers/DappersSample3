<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemLedgerGrd1
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
        Me.VwItemLedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwItemLedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwItemLedger = New DoorsPOS.WinApp.dsvwItemLedger()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colilid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpostmp_hdrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty_sold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty_purchased = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqtyreturned = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfree = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbackorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmanualinv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevious_Stock_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRunning_Stock_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltransdates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqtytransfrd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwItemLedgerTableAdapter = New DoorsPOS.WinApp.dsvwItemLedgerTableAdapters.vwItemLedgerTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwItemLedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwItemLedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwItemLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwItemLedgerBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(952, 438)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwItemLedgerBindingSource
        '
        Me.VwItemLedgerBindingSource.DataMember = "vwItemLedger"
        Me.VwItemLedgerBindingSource.DataSource = Me.DsvwItemLedgerBindingSource
        '
        'DsvwItemLedgerBindingSource
        '
        Me.DsvwItemLedgerBindingSource.DataSource = Me.DsvwItemLedger
        Me.DsvwItemLedgerBindingSource.Position = 0
        '
        'DsvwItemLedger
        '
        Me.DsvwItemLedger.DataSetName = "dsvwItemLedger"
        Me.DsvwItemLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colilid, Me.colstckid, Me.colitem_desc, Me.colpostmp_hdrid, Me.colqty_sold, Me.colqty_purchased, Me.colqtyreturned, Me.colfree, Me.colbackorder, Me.colmanualinv, Me.colPrevious_Stock_Balance, Me.colRunning_Stock_Balance, Me.coltrans_Date, Me.coltransdates, Me.colqtytransfrd})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colilid
        '
        Me.colilid.FieldName = "ilid"
        Me.colilid.Name = "colilid"
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Descsription"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        '
        'colpostmp_hdrid
        '
        Me.colpostmp_hdrid.FieldName = "postmp_hdrid"
        Me.colpostmp_hdrid.Name = "colpostmp_hdrid"
        '
        'colqty_sold
        '
        Me.colqty_sold.Caption = "Qty Sold"
        Me.colqty_sold.FieldName = "qty_sold"
        Me.colqty_sold.Name = "colqty_sold"
        Me.colqty_sold.Visible = True
        Me.colqty_sold.VisibleIndex = 2
        Me.colqty_sold.Width = 56
        '
        'colqty_purchased
        '
        Me.colqty_purchased.Caption = "Qty Purchased"
        Me.colqty_purchased.FieldName = "qty_purchased"
        Me.colqty_purchased.Name = "colqty_purchased"
        Me.colqty_purchased.Visible = True
        Me.colqty_purchased.VisibleIndex = 3
        Me.colqty_purchased.Width = 84
        '
        'colqtyreturned
        '
        Me.colqtyreturned.Caption = "Qty Returned"
        Me.colqtyreturned.FieldName = "qtyreturned"
        Me.colqtyreturned.Name = "colqtyreturned"
        Me.colqtyreturned.Visible = True
        Me.colqtyreturned.VisibleIndex = 4
        Me.colqtyreturned.Width = 80
        '
        'colfree
        '
        Me.colfree.Caption = "Free Items"
        Me.colfree.FieldName = "free"
        Me.colfree.Name = "colfree"
        Me.colfree.Visible = True
        Me.colfree.VisibleIndex = 7
        Me.colfree.Width = 80
        '
        'colbackorder
        '
        Me.colbackorder.Caption = "BO"
        Me.colbackorder.FieldName = "backorder"
        Me.colbackorder.Name = "colbackorder"
        Me.colbackorder.Visible = True
        Me.colbackorder.VisibleIndex = 5
        Me.colbackorder.Width = 61
        '
        'colmanualinv
        '
        Me.colmanualinv.Caption = "Manual Inventory"
        Me.colmanualinv.FieldName = "manualinv"
        Me.colmanualinv.Name = "colmanualinv"
        Me.colmanualinv.Visible = True
        Me.colmanualinv.VisibleIndex = 8
        Me.colmanualinv.Width = 363
        '
        'colPrevious_Stock_Balance
        '
        Me.colPrevious_Stock_Balance.Caption = "Previous Stock Count"
        Me.colPrevious_Stock_Balance.FieldName = "Previous_Stock_Balance"
        Me.colPrevious_Stock_Balance.Name = "colPrevious_Stock_Balance"
        Me.colPrevious_Stock_Balance.Visible = True
        Me.colPrevious_Stock_Balance.VisibleIndex = 1
        Me.colPrevious_Stock_Balance.Width = 112
        '
        'colRunning_Stock_Balance
        '
        Me.colRunning_Stock_Balance.Caption = "Running Stock Count"
        Me.colRunning_Stock_Balance.FieldName = "Running_Stock_Balance"
        Me.colRunning_Stock_Balance.Name = "colRunning_Stock_Balance"
        Me.colRunning_Stock_Balance.Visible = True
        Me.colRunning_Stock_Balance.VisibleIndex = 6
        Me.colRunning_Stock_Balance.Width = 112
        '
        'coltrans_Date
        '
        Me.coltrans_Date.Caption = "Transaction Date"
        Me.coltrans_Date.FieldName = "trans_Date"
        Me.coltrans_Date.Name = "coltrans_Date"
        Me.coltrans_Date.Visible = True
        Me.coltrans_Date.VisibleIndex = 0
        Me.coltrans_Date.Width = 118
        '
        'coltransdates
        '
        Me.coltransdates.FieldName = "transdates"
        Me.coltransdates.Name = "coltransdates"
        '
        'colqtytransfrd
        '
        Me.colqtytransfrd.FieldName = "qtytransfrd"
        Me.colqtytransfrd.Name = "colqtytransfrd"
        '
        'VwItemLedgerTableAdapter
        '
        Me.VwItemLedgerTableAdapter.ClearBeforeFill = True
        '
        'frmItemLedgerGrd1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 438)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmItemLedgerGrd1"
        Me.Text = "Item Ledger Grid View"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwItemLedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwItemLedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwItemLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsvwItemLedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsvwItemLedger As DoorsPOS.WinApp.dsvwItemLedger
    Friend WithEvents VwItemLedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwItemLedgerTableAdapter As DoorsPOS.WinApp.dsvwItemLedgerTableAdapters.vwItemLedgerTableAdapter
    Friend WithEvents colilid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpostmp_hdrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevious_Stock_Balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty_sold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty_purchased As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqtyreturned As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbackorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRunning_Stock_Balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltransdates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfree As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmanualinv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqtytransfrd As DevExpress.XtraGrid.Columns.GridColumn
End Class
