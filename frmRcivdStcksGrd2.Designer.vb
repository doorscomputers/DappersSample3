<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRcivdStcksGrd2
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
        Me.VwReceivedStocksBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsReceivedStcks = New DoorsPOS.WinApp.dsReceivedStcks()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwReceivedStocksTableAdapter = New DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReceivedStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReceivedStcks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwReceivedStocksBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(836, 495)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwReceivedStocksBindingSource
        '
        Me.VwReceivedStocksBindingSource.DataMember = "vwReceivedStocks"
        Me.VwReceivedStocksBindingSource.DataSource = Me.DsReceivedStcks
        '
        'DsReceivedStcks
        '
        Me.DsReceivedStcks.DataSetName = "dsReceivedStcks"
        Me.DsReceivedStcks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colrdate, Me.colsInsert_id, Me.collocation, Me.colitem_desc, Me.colqty})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.collocation, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colrdate
        '
        Me.colrdate.Caption = "Date Received"
        Me.colrdate.FieldName = "rdate"
        Me.colrdate.Name = "colrdate"
        Me.colrdate.Visible = True
        Me.colrdate.VisibleIndex = 0
        Me.colrdate.Width = 115
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.Caption = "Encoder"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 4
        Me.colsInsert_id.Width = 408
        '
        'collocation
        '
        Me.collocation.AppearanceCell.Options.UseTextOptions = True
        Me.collocation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.collocation.AppearanceHeader.Options.UseTextOptions = True
        Me.collocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.collocation.Caption = "From Location"
        Me.collocation.FieldName = "location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = True
        Me.collocation.VisibleIndex = 3
        Me.collocation.Width = 205
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        Me.colitem_desc.Width = 237
        '
        'colqty
        '
        Me.colqty.Caption = "Qty Received"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        Me.colqty.Width = 101
        '
        'VwReceivedStocksTableAdapter
        '
        Me.VwReceivedStocksTableAdapter.ClearBeforeFill = True
        '
        'frmRcivdStcksGrd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 495)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmRcivdStcksGrd2"
        Me.Text = "Received Stocks View2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReceivedStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReceivedStcks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsReceivedStcks As DoorsPOS.WinApp.dsReceivedStcks
    Friend WithEvents VwReceivedStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReceivedStocksTableAdapter As DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter
    Friend WithEvents colrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
End Class
