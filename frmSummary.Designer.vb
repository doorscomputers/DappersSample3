<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.TblreadingBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsReading = New DoorsPOS.WinApp.dsReading()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcashreadid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldatereading = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalsales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbegincash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpickup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdcash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalrefs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colovershort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchangeprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotaldiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltransfer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpayments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalcredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalcheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tblreadingTableAdapter = New DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblreadingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.TblreadingBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(906, 447)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'TblreadingBindingSource
        '
        Me.TblreadingBindingSource.DataMember = "tblreading"
        Me.TblreadingBindingSource.DataSource = Me.DsReading
        '
        'DsReading
        '
        Me.DsReading.DataSetName = "dsReading"
        Me.DsReading.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcashreadid, Me.coldatereading, Me.coltotalsales, Me.colbegincash, Me.colpickup, Me.coladdcash, Me.coltotalrefs, Me.colovershort, Me.colcashier, Me.colchangeprice, Me.coltotaldiscount, Me.coltransfer, Me.colpayments, Me.coltotalcredit, Me.coltotalcheque})
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsFind.AlwaysVisible = True
        Me.gridView1.OptionsView.ShowAutoFilterRow = True
        Me.gridView1.OptionsView.ShowFooter = True
        '
        'colcashreadid
        '
        Me.colcashreadid.FieldName = "cashreadid"
        Me.colcashreadid.Name = "colcashreadid"
        Me.colcashreadid.OptionsColumn.ReadOnly = True
        '
        'coldatereading
        '
        Me.coldatereading.Caption = "Date"
        Me.coldatereading.FieldName = "datereading"
        Me.coldatereading.Name = "coldatereading"
        Me.coldatereading.Visible = True
        Me.coldatereading.VisibleIndex = 1
        Me.coldatereading.Width = 134
        '
        'coltotalsales
        '
        Me.coltotalsales.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotalsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotalsales.Caption = "Total Sales"
        Me.coltotalsales.DisplayFormat.FormatString = "n2"
        Me.coltotalsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotalsales.FieldName = "totalsales"
        Me.coltotalsales.Name = "coltotalsales"
        Me.coltotalsales.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalsales", "SUM={0:n2}")})
        Me.coltotalsales.Visible = True
        Me.coltotalsales.VisibleIndex = 3
        Me.coltotalsales.Width = 138
        '
        'colbegincash
        '
        Me.colbegincash.Caption = "Beginning Cash"
        Me.colbegincash.DisplayFormat.FormatString = "N2"
        Me.colbegincash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbegincash.FieldName = "begincash"
        Me.colbegincash.Name = "colbegincash"
        Me.colbegincash.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "begincash", "SUM={0:N2}")})
        Me.colbegincash.Visible = True
        Me.colbegincash.VisibleIndex = 2
        Me.colbegincash.Width = 112
        '
        'colpickup
        '
        Me.colpickup.AppearanceHeader.Options.UseTextOptions = True
        Me.colpickup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colpickup.Caption = "Petty Cash"
        Me.colpickup.DisplayFormat.FormatString = "n2"
        Me.colpickup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colpickup.FieldName = "pickup"
        Me.colpickup.Name = "colpickup"
        Me.colpickup.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pickup", "SUM={0:n2}")})
        Me.colpickup.Visible = True
        Me.colpickup.VisibleIndex = 5
        Me.colpickup.Width = 138
        '
        'coladdcash
        '
        Me.coladdcash.AppearanceHeader.Options.UseTextOptions = True
        Me.coladdcash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coladdcash.Caption = "Add Fund"
        Me.coladdcash.DisplayFormat.FormatString = "n2"
        Me.coladdcash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coladdcash.FieldName = "addcash"
        Me.coladdcash.Name = "coladdcash"
        Me.coladdcash.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "addcash", "SUM={0:n2}")})
        Me.coladdcash.Visible = True
        Me.coladdcash.VisibleIndex = 4
        Me.coladdcash.Width = 138
        '
        'coltotalrefs
        '
        Me.coltotalrefs.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotalrefs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotalrefs.Caption = "Refunds"
        Me.coltotalrefs.DisplayFormat.FormatString = "n2"
        Me.coltotalrefs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotalrefs.FieldName = "totalrefs"
        Me.coltotalrefs.Name = "coltotalrefs"
        Me.coltotalrefs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalrefs", "SUM={0:n2}")})
        Me.coltotalrefs.Visible = True
        Me.coltotalrefs.VisibleIndex = 6
        Me.coltotalrefs.Width = 138
        '
        'colovershort
        '
        Me.colovershort.AppearanceHeader.Options.UseTextOptions = True
        Me.colovershort.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colovershort.Caption = "Short/Over"
        Me.colovershort.DisplayFormat.FormatString = "n2"
        Me.colovershort.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colovershort.FieldName = "overshort"
        Me.colovershort.Name = "colovershort"
        Me.colovershort.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "overshort", "SUM={0:n2}")})
        Me.colovershort.Visible = True
        Me.colovershort.VisibleIndex = 7
        Me.colovershort.Width = 146
        '
        'colcashier
        '
        Me.colcashier.Caption = "Cashier"
        Me.colcashier.FieldName = "cashier"
        Me.colcashier.Name = "colcashier"
        Me.colcashier.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "cashier", "{0}")})
        Me.colcashier.Visible = True
        Me.colcashier.VisibleIndex = 0
        Me.colcashier.Width = 134
        '
        'colchangeprice
        '
        Me.colchangeprice.FieldName = "changeprice"
        Me.colchangeprice.Name = "colchangeprice"
        '
        'coltotaldiscount
        '
        Me.coltotaldiscount.Caption = "Total Discount"
        Me.coltotaldiscount.FieldName = "totaldiscount"
        Me.coltotaldiscount.Name = "coltotaldiscount"
        '
        'coltransfer
        '
        Me.coltransfer.FieldName = "transfer"
        Me.coltransfer.Name = "coltransfer"
        '
        'colpayments
        '
        Me.colpayments.Caption = "Payments"
        Me.colpayments.FieldName = "payments"
        Me.colpayments.Name = "colpayments"
        '
        'coltotalcredit
        '
        Me.coltotalcredit.Caption = "Total Credit"
        Me.coltotalcredit.FieldName = "totalcredit"
        Me.coltotalcredit.Name = "coltotalcredit"
        '
        'coltotalcheque
        '
        Me.coltotalcheque.FieldName = "totalcheque"
        Me.coltotalcheque.Name = "coltotalcheque"
        '
        'tblreadingTableAdapter
        '
        Me.tblreadingTableAdapter.ClearBeforeFill = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 447)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmSummary"
        Me.Text = "Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblreadingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsReading As DoorsPOS.WinApp.dsReading
    Friend WithEvents TblreadingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblreadingTableAdapter As DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter
    Friend WithEvents colcashreadid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatereading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalsales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbegincash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpickup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdcash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalrefs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colovershort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcashier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchangeprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotaldiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltransfer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalcredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalcheque As DevExpress.XtraGrid.Columns.GridColumn
End Class
