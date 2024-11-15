<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferGrd
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
        Me.VwTransferedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTransfered = New DoorsPOS.WinApp.dsTransfered()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coltdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltdetamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwTransferedTableAdapter = New DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter()
        Me.colTransferNo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransferedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTransfered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwTransferedBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(888, 500)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwTransferedBindingSource
        '
        Me.VwTransferedBindingSource.DataMember = "vwTransfered"
        Me.VwTransferedBindingSource.DataSource = Me.DsTransfered
        '
        'DsTransfered
        '
        Me.DsTransfered.DataSetName = "dsTransfered"
        Me.DsTransfered.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltdate, Me.colstckid, Me.colTransferNo, Me.coldtInsert_dt, Me.collocation, Me.colitem_desc, Me.colprice, Me.colqty, Me.coltdetamnt, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'coltdate
        '
        Me.coltdate.FieldName = "tdate"
        Me.coltdate.Name = "coltdate"
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date Transferred"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 1
        '
        'collocation
        '
        Me.collocation.Caption = "Location"
        Me.collocation.FieldName = "location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = True
        Me.collocation.VisibleIndex = 3
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Items Transferred"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        '
        'colprice
        '
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        '
        'colqty
        '
        Me.colqty.Caption = "Qty"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        '
        'coltdetamnt
        '
        Me.coltdetamnt.FieldName = "tdetamnt"
        Me.coltdetamnt.Name = "coltdetamnt"
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "UserName"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 4
        '
        'VwTransferedTableAdapter
        '
        Me.VwTransferedTableAdapter.ClearBeforeFill = True
        '
        'colTransferNo
        '
        Me.colTransferNo.Caption = "Transfer #"
        Me.colTransferNo.FieldName = "TransferNo"
        Me.colTransferNo.Name = "colTransferNo"
        Me.colTransferNo.Visible = True
        Me.colTransferNo.VisibleIndex = 0
        '
        'frmTransferGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 500)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmTransferGrd"
        Me.Text = "Transferred Stocks"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransferedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTransfered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTransfered As DoorsPOS.WinApp.dsTransfered
    Friend WithEvents VwTransferedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwTransferedTableAdapter As DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter
    Friend WithEvents coltdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltdetamnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
