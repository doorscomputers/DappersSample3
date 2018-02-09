<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarcodeGrd
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
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DsStocksBarcode = New DoorsPOS.WinApp.dsStocksBarcode()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stocksTableAdapter = New DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.stocksTableAdapter()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TblBarcodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBarcodesTableAdapter = New DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter()
        Me.TableAdapterManager = New DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.binFKtblBarcodesstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardView2 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colbcodeid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstckid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldateadded = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStocksBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBarcodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binFKtblBarcodesstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = "stocks"
        Me.GridControl1.DataSource = Me.DsStocksBarcode
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(723, 215)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.CardView1})
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colstckid, Me.colbarcode, Me.colitem_desc})
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        '
        'DsStocksBarcode
        '
        Me.DsStocksBarcode.DataSetName = "dsStocksBarcode"
        Me.DsStocksBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.DsStocksBarcode
        '
        'stocksTableAdapter
        '
        Me.stocksTableAdapter.ClearBeforeFill = True
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        Me.colstckid.OptionsColumn.ReadOnly = True
        Me.colstckid.Visible = True
        Me.colstckid.VisibleIndex = 0
        '
        'colbarcode
        '
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 1
        '
        'colitem_desc
        '
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 2
        '
        'TblBarcodesBindingSource
        '
        Me.TblBarcodesBindingSource.DataMember = "tblBarcodes"
        Me.TblBarcodesBindingSource.DataSource = Me.DsStocksBarcode
        '
        'TblBarcodesTableAdapter
        '
        Me.TblBarcodesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.stocksTableAdapter = Me.stocksTableAdapter
        Me.TableAdapterManager.tblBarcodesTableAdapter = Me.TblBarcodesTableAdapter
        Me.TableAdapterManager.UpdateOrder = DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GridControl1
        Me.CardView1.Name = "CardView1"
        '
        'GridControl2
        '
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.binFKtblBarcodesstocksBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(12, 234)
        Me.GridControl2.MainView = Me.CardView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(752, 200)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView2})
        '
        'binFKtblBarcodesstocksBindingSource
        '
        Me.binFKtblBarcodesstocksBindingSource.DataMember = "FK_tblBarcodes_stocks"
        Me.binFKtblBarcodesstocksBindingSource.DataSource = Me.StocksBindingSource
        '
        'CardView2
        '
        Me.CardView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbcodeid, Me.colbarcode1, Me.colstckid1, Me.coldateadded})
        Me.CardView2.FocusedCardTopFieldIndex = 0
        Me.CardView2.GridControl = Me.GridControl2
        Me.CardView2.Name = "CardView2"
        Me.CardView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colbcodeid
        '
        Me.colbcodeid.FieldName = "bcodeid"
        Me.colbcodeid.Name = "colbcodeid"
        Me.colbcodeid.OptionsColumn.ReadOnly = True
        Me.colbcodeid.Visible = True
        Me.colbcodeid.VisibleIndex = 0
        '
        'colbarcode1
        '
        Me.colbarcode1.FieldName = "barcode"
        Me.colbarcode1.Name = "colbarcode1"
        Me.colbarcode1.Visible = True
        Me.colbarcode1.VisibleIndex = 1
        '
        'colstckid1
        '
        Me.colstckid1.FieldName = "stckid"
        Me.colstckid1.Name = "colstckid1"
        Me.colstckid1.Visible = True
        Me.colstckid1.VisibleIndex = 2
        '
        'coldateadded
        '
        Me.coldateadded.FieldName = "dateadded"
        Me.coldateadded.Name = "coldateadded"
        Me.coldateadded.Visible = True
        Me.coldateadded.VisibleIndex = 3
        '
        'frmBarcodeGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 446)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBarcodeGrd"
        Me.Text = "frmBarcodeGrd"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStocksBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBarcodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binFKtblBarcodesstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsStocksBarcode As DoorsPOS.WinApp.dsStocksBarcode
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents stocksTableAdapter As DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.stocksTableAdapter
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TblBarcodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBarcodesTableAdapter As DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter
    Friend WithEvents TableAdapterManager As DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents binFKtblBarcodesstocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CardView2 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents colbcodeid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstckid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateadded As DevExpress.XtraGrid.Columns.GridColumn
End Class
