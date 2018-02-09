<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertGrid
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
        Me.VwItemConvertBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsConvert = New DoorsPOS.WinApp.dsConvert()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colilid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrans_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqtyconvertd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevious_Stock_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRunning_Stock_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwItemConvertTableAdapter = New DoorsPOS.WinApp.dsConvertTableAdapters.vwItemConvertTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwItemConvertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConvert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwItemConvertBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(935, 486)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwItemConvertBindingSource
        '
        Me.VwItemConvertBindingSource.DataMember = "vwItemConvert"
        Me.VwItemConvertBindingSource.DataSource = Me.DsConvert
        '
        'DsConvert
        '
        Me.DsConvert.DataSetName = "dsConvert"
        Me.DsConvert.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colilid, Me.coltrans_Date, Me.colitem_desc, Me.colqtyconvertd, Me.colPrevious_Stock_Balance, Me.colRunning_Stock_Balance, Me.colstckid})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coltrans_Date, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colilid
        '
        Me.colilid.Caption = "Trans No."
        Me.colilid.FieldName = "ilid"
        Me.colilid.Name = "colilid"
        Me.colilid.Visible = True
        Me.colilid.VisibleIndex = 0
        Me.colilid.Width = 83
        '
        'coltrans_Date
        '
        Me.coltrans_Date.Caption = "Date Converted"
        Me.coltrans_Date.FieldName = "trans_Date"
        Me.coltrans_Date.Name = "coltrans_Date"
        Me.coltrans_Date.Visible = True
        Me.coltrans_Date.VisibleIndex = 1
        Me.coltrans_Date.Width = 108
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 2
        Me.colitem_desc.Width = 277
        '
        'colqtyconvertd
        '
        Me.colqtyconvertd.Caption = "Qty Converted"
        Me.colqtyconvertd.FieldName = "qtyconvertd"
        Me.colqtyconvertd.Name = "colqtyconvertd"
        Me.colqtyconvertd.Visible = True
        Me.colqtyconvertd.VisibleIndex = 2
        Me.colqtyconvertd.Width = 137
        '
        'colPrevious_Stock_Balance
        '
        Me.colPrevious_Stock_Balance.Caption = "Previous Stock Balance"
        Me.colPrevious_Stock_Balance.FieldName = "Previous_Stock_Balance"
        Me.colPrevious_Stock_Balance.Name = "colPrevious_Stock_Balance"
        Me.colPrevious_Stock_Balance.Visible = True
        Me.colPrevious_Stock_Balance.VisibleIndex = 3
        Me.colPrevious_Stock_Balance.Width = 220
        '
        'colRunning_Stock_Balance
        '
        Me.colRunning_Stock_Balance.Caption = "Running Stock Balance"
        Me.colRunning_Stock_Balance.FieldName = "Running_Stock_Balance"
        Me.colRunning_Stock_Balance.Name = "colRunning_Stock_Balance"
        Me.colRunning_Stock_Balance.Visible = True
        Me.colRunning_Stock_Balance.VisibleIndex = 4
        Me.colRunning_Stock_Balance.Width = 237
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        '
        'VwItemConvertTableAdapter
        '
        Me.VwItemConvertTableAdapter.ClearBeforeFill = True
        '
        'frmConvertGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 486)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmConvertGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items Converted to Pieces"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwItemConvertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConvert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsConvert As DoorsPOS.WinApp.dsConvert
    Friend WithEvents VwItemConvertBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwItemConvertTableAdapter As DoorsPOS.WinApp.dsConvertTableAdapters.vwItemConvertTableAdapter
    Friend WithEvents colilid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrans_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqtyconvertd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevious_Stock_Balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRunning_Stock_Balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
End Class
