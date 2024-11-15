<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales2DayCashr
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
        Me.VwSalesTodayCshrBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsSale2dayCashrBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsSale2dayCashr = New DoorsPOS.WinApp.dsSale2dayCashr()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotsales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwSalesTodayCshrTableAdapter = New DoorsPOS.WinApp.dsSale2dayCashrTableAdapters.vwSalesTodayCshrTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSalesTodayCshrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSale2dayCashrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSale2dayCashr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwSalesTodayCshrBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(831, 440)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwSalesTodayCshrBindingSource
        '
        Me.VwSalesTodayCshrBindingSource.DataMember = "vwSalesTodayCshr"
        Me.VwSalesTodayCshrBindingSource.DataSource = Me.DsSale2dayCashrBindingSource
        '
        'DsSale2dayCashrBindingSource
        '
        Me.DsSale2dayCashrBindingSource.DataSource = Me.DsSale2dayCashr
        Me.DsSale2dayCashrBindingSource.Position = 0
        '
        'DsSale2dayCashr
        '
        Me.DsSale2dayCashr.DataSetName = "dsSale2dayCashr"
        Me.DsSale2dayCashr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpos_date, Me.colsInsert_id, Me.coltotsales})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totsales", Me.coltotsales, "SUM={0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colsInsert_id, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Date "
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 0
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 1
        '
        'coltotsales
        '
        Me.coltotsales.Caption = "Sales"
        Me.coltotsales.DisplayFormat.FormatString = "N2"
        Me.coltotsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotsales.FieldName = "totsales"
        Me.coltotsales.Name = "coltotsales"
        Me.coltotsales.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totsales", "SUM={0:N2}")})
        Me.coltotsales.Visible = True
        Me.coltotsales.VisibleIndex = 1
        '
        'VwSalesTodayCshrTableAdapter
        '
        Me.VwSalesTodayCshrTableAdapter.ClearBeforeFill = True
        '
        'frmSales2DayCashr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 440)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales2DayCashr"
        Me.Text = "Sales Today per Cashier"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSalesTodayCshrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSale2dayCashrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSale2dayCashr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsSale2dayCashrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSale2dayCashr As DoorsPOS.WinApp.dsSale2dayCashr
    Friend WithEvents VwSalesTodayCshrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSalesTodayCshrTableAdapter As DoorsPOS.WinApp.dsSale2dayCashrTableAdapters.vwSalesTodayCshrTableAdapter
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotsales As DevExpress.XtraGrid.Columns.GridColumn
End Class
