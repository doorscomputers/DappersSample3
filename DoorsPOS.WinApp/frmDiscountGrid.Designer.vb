<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscountGrid
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
        Me.PoshdrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDiscount = New DoorsPOS.WinApp.dsDiscount()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpostmp_hdrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldisc_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pos_hdrTableAdapter = New DoorsPOS.WinApp.dsDiscountTableAdapters.pos_hdrTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoshdrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PoshdrBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(855, 509)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PoshdrBindingSource
        '
        Me.PoshdrBindingSource.DataMember = "pos_hdr"
        Me.PoshdrBindingSource.DataSource = Me.DsDiscount
        '
        'DsDiscount
        '
        Me.DsDiscount.DataSetName = "dsDiscount"
        Me.DsDiscount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpostmp_hdrid, Me.coldtInsert_dt, Me.coldisc_amnt, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disc_amnt", Me.coldisc_amnt, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colpostmp_hdrid
        '
        Me.colpostmp_hdrid.Caption = "Reference No."
        Me.colpostmp_hdrid.FieldName = "Receipt"
        Me.colpostmp_hdrid.Name = "colpostmp_hdrid"
        Me.colpostmp_hdrid.Visible = True
        Me.colpostmp_hdrid.VisibleIndex = 1
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 175
        '
        'coldisc_amnt
        '
        Me.coldisc_amnt.AppearanceHeader.Options.UseTextOptions = True
        Me.coldisc_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldisc_amnt.Caption = "Discount Amount"
        Me.coldisc_amnt.DisplayFormat.FormatString = "N2"
        Me.coldisc_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldisc_amnt.FieldName = "disc_amnt"
        Me.coldisc_amnt.Name = "coldisc_amnt"
        Me.coldisc_amnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disc_amnt", "SUM={0:N2}")})
        Me.coldisc_amnt.Visible = True
        Me.coldisc_amnt.VisibleIndex = 2
        Me.coldisc_amnt.Width = 129
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 3
        Me.colsInsert_id.Width = 558
        '
        'Pos_hdrTableAdapter
        '
        Me.Pos_hdrTableAdapter.ClearBeforeFill = True
        '
        'frmDiscountGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 509)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiscountGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Discounts Grid View"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoshdrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsDiscount As DoorsPOS.WinApp.dsDiscount
    Friend WithEvents PoshdrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pos_hdrTableAdapter As DoorsPOS.WinApp.dsDiscountTableAdapters.pos_hdrTableAdapter
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldisc_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpostmp_hdrid As DevExpress.XtraGrid.Columns.GridColumn
End Class
