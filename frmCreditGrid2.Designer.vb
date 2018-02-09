<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditGrid2
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
        Me.VwCreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCreditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCredits = New DoorsPOS.WinApp.dsCredits()
        Me.VwCreditTableAdapter = New DoorsPOS.WinApp.dsCreditsTableAdapters.vwCreditTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwCreditDS = New DoorsPOS.WinApp.vwCreditDS()
        Me.VwCreditBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwCreditTableAdapter1 = New DoorsPOS.WinApp.vwCreditDSTableAdapters.vwCreditTableAdapter()
        CType(Me.VwCreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCreditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCreditDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCreditBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwCreditBindingSource
        '
        Me.VwCreditBindingSource.DataMember = "vwCredit"
        Me.VwCreditBindingSource.DataSource = Me.DsCreditsBindingSource
        '
        'DsCreditsBindingSource
        '
        Me.DsCreditsBindingSource.DataSource = Me.DsCredits
        Me.DsCreditsBindingSource.Position = 0
        '
        'DsCredits
        '
        Me.DsCredits.DataSetName = "dsCredits"
        Me.DsCredits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCreditTableAdapter
        '
        Me.VwCreditTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwCreditBindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(965, 499)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpos_date, Me.Customer, Me.colitem_desc, Me.colprice, Me.colqty, Me.coldet_amnt})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", Me.coldet_amnt, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.Customer, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpos_date, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Credit Date"
        Me.colpos_date.DisplayFormat.FormatString = "G"
        Me.colpos_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 4
        '
        'Customer
        '
        Me.Customer.Caption = "Customer"
        Me.Customer.FieldName = "Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.UnboundExpression = "[lastname]+','+[firstname]+' '+[middlename]"
        Me.Customer.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Customer.Visible = True
        Me.Customer.VisibleIndex = 5
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        Me.colitem_desc.Width = 83
        '
        'colprice
        '
        Me.colprice.AppearanceHeader.Options.UseTextOptions = True
        Me.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colprice.Caption = "Price"
        Me.colprice.DisplayFormat.FormatString = "N2"
        Me.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 1
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Credit Qty"
        Me.colqty.DisplayFormat.FormatString = "N0"
        Me.colqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 2
        '
        'coldet_amnt
        '
        Me.coldet_amnt.Caption = "Amount"
        Me.coldet_amnt.DisplayFormat.FormatString = "N2"
        Me.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldet_amnt.FieldName = "det_amnt"
        Me.coldet_amnt.Name = "coldet_amnt"
        Me.coldet_amnt.Visible = True
        Me.coldet_amnt.VisibleIndex = 3
        '
        'VwCreditDS
        '
        Me.VwCreditDS.DataSetName = "vwCreditDS"
        Me.VwCreditDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCreditBindingSource1
        '
        Me.VwCreditBindingSource1.DataMember = "vwCredit"
        Me.VwCreditBindingSource1.DataSource = Me.VwCreditDS
        '
        'VwCreditTableAdapter1
        '
        Me.VwCreditTableAdapter1.ClearBeforeFill = True
        '
        'frmCreditGrid2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 499)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmCreditGrid2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Credits Grid View 2"
        CType(Me.VwCreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCreditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCredits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCreditDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCreditBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VwCreditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCreditsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCredits As DoorsPOS.WinApp.dsCredits
    Friend WithEvents VwCreditTableAdapter As DoorsPOS.WinApp.dsCreditsTableAdapters.vwCreditTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VwCreditDS As DoorsPOS.WinApp.vwCreditDS
    Friend WithEvents VwCreditBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VwCreditTableAdapter1 As DoorsPOS.WinApp.vwCreditDSTableAdapters.vwCreditTableAdapter
End Class
