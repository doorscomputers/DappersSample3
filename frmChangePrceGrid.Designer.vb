<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePrceGrid
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
        Me.VwChangePriceBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsChangePrice = New DoorsPOS.WinApp.dsChangePrice()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colws = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwChangePriceTableAdapter = New DoorsPOS.WinApp.dsChangePriceTableAdapters.vwChangePriceTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwChangePriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsChangePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwChangePriceBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(859, 522)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwChangePriceBindingSource
        '
        Me.VwChangePriceBindingSource.DataMember = "vwChangePrice"
        Me.VwChangePriceBindingSource.DataSource = Me.DsChangePrice
        '
        'DsChangePrice
        '
        Me.DsChangePrice.DataSetName = "dsChangePrice"
        Me.DsChangePrice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colbarcode, Me.colitem_desc, Me.colprice, Me.colws, Me.colqty, Me.coldet_amnt, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date Sold"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 119
        '
        'colbarcode
        '
        Me.colbarcode.Caption = "ItemCode"
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 1
        Me.colbarcode.Width = 90
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 2
        Me.colitem_desc.Width = 213
        '
        'colprice
        '
        Me.colprice.Caption = "New Price"
        Me.colprice.DisplayFormat.FormatString = "N2"
        Me.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 3
        Me.colprice.Width = 82
        '
        'colws
        '
        Me.colws.Caption = "Original Price"
        Me.colws.DisplayFormat.FormatString = "N2"
        Me.colws.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colws.FieldName = "ws"
        Me.colws.Name = "colws"
        Me.colws.Visible = True
        Me.colws.VisibleIndex = 4
        Me.colws.Width = 68
        '
        'colqty
        '
        Me.colqty.Caption = "Qty Sold"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 5
        Me.colqty.Width = 55
        '
        'coldet_amnt
        '
        Me.coldet_amnt.Caption = "Amount"
        Me.coldet_amnt.DisplayFormat.FormatString = "N2"
        Me.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldet_amnt.FieldName = "det_amnt"
        Me.coldet_amnt.Name = "coldet_amnt"
        Me.coldet_amnt.Visible = True
        Me.coldet_amnt.VisibleIndex = 6
        Me.coldet_amnt.Width = 214
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 7
        '
        'VwChangePriceTableAdapter
        '
        Me.VwChangePriceTableAdapter.ClearBeforeFill = True
        '
        'frmChangePrceGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 522)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePrceGrid"
        Me.Text = "Changed Price Sold Items"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwChangePriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsChangePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsChangePrice As DoorsPOS.WinApp.dsChangePrice
    Friend WithEvents VwChangePriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwChangePriceTableAdapter As DoorsPOS.WinApp.dsChangePriceTableAdapters.vwChangePriceTableAdapter
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colws As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
