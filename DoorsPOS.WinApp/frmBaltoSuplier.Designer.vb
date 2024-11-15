<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaltoSuplier
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
        Me.VwBalSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBaltoSupplier = New DoorsPOS.WinApp.dsBaltoSupplier()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsupcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwBalSupplierTableAdapter = New DoorsPOS.WinApp.dsBaltoSupplierTableAdapters.vwBalSupplierTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBalSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBaltoSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwBalSupplierBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1003, 486)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwBalSupplierBindingSource
        '
        Me.VwBalSupplierBindingSource.DataMember = "vwBalSupplier"
        Me.VwBalSupplierBindingSource.DataSource = Me.DsBaltoSupplier
        '
        'DsBaltoSupplier
        '
        Me.DsBaltoSupplier.DataSetName = "dsBaltoSupplier"
        Me.DsBaltoSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsupcode, Me.colsupplier, Me.coladdress, Me.colbalance})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", Me.colbalance, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colbalance, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colsupcode
        '
        Me.colsupcode.FieldName = "supcode"
        Me.colsupcode.Name = "colsupcode"
        Me.colsupcode.OptionsColumn.ReadOnly = True
        '
        'colsupplier
        '
        Me.colsupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 0
        Me.colsupplier.Width = 275
        '
        'coladdress
        '
        Me.coladdress.AppearanceHeader.Options.UseTextOptions = True
        Me.coladdress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coladdress.Caption = "Address"
        Me.coladdress.FieldName = "address"
        Me.coladdress.Name = "coladdress"
        Me.coladdress.Visible = True
        Me.coladdress.VisibleIndex = 2
        Me.coladdress.Width = 651
        '
        'colbalance
        '
        Me.colbalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colbalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colbalance.Caption = "Balance to Supplier"
        Me.colbalance.DisplayFormat.FormatString = "N2"
        Me.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbalance.FieldName = "balance"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", "SUM={0:N2}")})
        Me.colbalance.Visible = True
        Me.colbalance.VisibleIndex = 1
        Me.colbalance.Width = 136
        '
        'VwBalSupplierTableAdapter
        '
        Me.VwBalSupplierTableAdapter.ClearBeforeFill = True
        '
        'frmBaltoSuplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 486)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBaltoSuplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Balance to Suppliers"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBalSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBaltoSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsBaltoSupplier As DoorsPOS.WinApp.dsBaltoSupplier
    Friend WithEvents VwBalSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwBalSupplierTableAdapter As DoorsPOS.WinApp.dsBaltoSupplierTableAdapters.vwBalSupplierTableAdapter
    Friend WithEvents colsupcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbalance As DevExpress.XtraGrid.Columns.GridColumn
End Class
