<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwSalesArchiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesArchive = New DoorsPOS.WinApp.dsSalesArchive()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontact_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpos_tme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldet_amnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltrminal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwSalesArchiveTableAdapter = New DoorsPOS.WinApp.dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSalesArchiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesArchive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colqty
        '
        Me.colqty.Caption = "Qty Sold"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 8
        Me.colqty.Width = 62
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Sold"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "item_desc", "{0}")})
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 5
        Me.colitem_desc.Width = 254
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mode of Payment"
        Me.GridColumn2.FieldName = "mowd"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn2.Width = 144
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.VwSalesArchiveBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1142, 591)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwSalesArchiveBindingSource
        '
        Me.VwSalesArchiveBindingSource.DataMember = "vwSalesArchive"
        Me.VwSalesArchiveBindingSource.DataSource = Me.DsSalesArchive
        '
        'DsSalesArchive
        '
        Me.DsSalesArchive.DataSetName = "dsSalesArchive"
        Me.DsSalesArchive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterString = "[pos_date] >= #2017-06-01# And [pos_date] < #2014-12-31#"
        Me.GridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.colcontact_no, Me.colReceipt, Me.colpos_date, Me.colpos_tme, Me.colitem_desc, Me.colcost, Me.colprice, Me.colqty, Me.coldet_amnt, Me.colsInsert_id, Me.GridColumn1, Me.GridColumn2, Me.colcustid, Me.collastname, Me.colfirstname, Me.colmiddlename, Me.coltrminal})
        GridFormatRule1.Column = Me.colqty
        GridFormatRule1.ColumnApplyTo = Me.colitem_desc
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Expression = "[qty] < 1"
        FormatConditionRuleExpression1.PredefinedName = "Green Bold Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.Column = Me.GridColumn2
        GridFormatRule2.ColumnApplyTo = Me.colitem_desc
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Expression = "[GridColumn2] = 'CREDIT'"
        FormatConditionRuleExpression2.PredefinedName = "Red Bold Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", Me.coldet_amnt, "SUM={0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", Me.colqty, "SUM={0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Name"
        Me.GridColumn3.FieldName = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.UnboundExpression = "[lastname] + ',' + [firstname] + ' ' + [middlename]"
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'colcontact_no
        '
        Me.colcontact_no.FieldName = "contact_no"
        Me.colcontact_no.Name = "colcontact_no"
        '
        'colReceipt
        '
        Me.colReceipt.Caption = "Ref #"
        Me.colReceipt.FieldName = "Receipt"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.Visible = True
        Me.colReceipt.VisibleIndex = 1
        Me.colReceipt.Width = 94
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Date Sold"
        Me.colpos_date.DisplayFormat.FormatString = "d"
        Me.colpos_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 3
        Me.colpos_date.Width = 132
        '
        'colpos_tme
        '
        Me.colpos_tme.Caption = "Date Sold with Time"
        Me.colpos_tme.DisplayFormat.FormatString = "G"
        Me.colpos_tme.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colpos_tme.FieldName = "pos_tme"
        Me.colpos_tme.Name = "colpos_tme"
        Me.colpos_tme.Visible = True
        Me.colpos_tme.VisibleIndex = 4
        Me.colpos_tme.Width = 165
        '
        'colcost
        '
        Me.colcost.AppearanceCell.Options.UseTextOptions = True
        Me.colcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost.Caption = "Cost"
        Me.colcost.DisplayFormat.FormatString = "N2"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.Name = "colcost"
        Me.colcost.Visible = True
        Me.colcost.VisibleIndex = 6
        Me.colcost.Width = 56
        '
        'colprice
        '
        Me.colprice.AppearanceCell.Options.UseTextOptions = True
        Me.colprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colprice.AppearanceHeader.Options.UseTextOptions = True
        Me.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colprice.Caption = "Price"
        Me.colprice.DisplayFormat.FormatString = "N2"
        Me.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colprice.FieldName = "price"
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 7
        Me.colprice.Width = 56
        '
        'coldet_amnt
        '
        Me.coldet_amnt.AppearanceCell.Options.UseTextOptions = True
        Me.coldet_amnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldet_amnt.AppearanceHeader.Options.UseTextOptions = True
        Me.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coldet_amnt.Caption = "Amount"
        Me.coldet_amnt.DisplayFormat.FormatString = "N2"
        Me.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldet_amnt.FieldName = "det_amnt"
        Me.coldet_amnt.Name = "coldet_amnt"
        Me.coldet_amnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", "SUM={0:N2}")})
        Me.coldet_amnt.Visible = True
        Me.coldet_amnt.VisibleIndex = 9
        Me.coldet_amnt.Width = 106
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.Caption = "Cashier"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 0
        Me.colsInsert_id.Width = 99
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Trans Type"
        Me.GridColumn1.FieldName = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundExpression = "Iif([qty] < 1, 'Refund', 'Regular')"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn1.Width = 134
        '
        'colcustid
        '
        Me.colcustid.FieldName = "custid"
        Me.colcustid.Name = "colcustid"
        '
        'collastname
        '
        Me.collastname.FieldName = "lastname"
        Me.collastname.Name = "collastname"
        '
        'colfirstname
        '
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        '
        'colmiddlename
        '
        Me.colmiddlename.FieldName = "middlename"
        Me.colmiddlename.Name = "colmiddlename"
        '
        'coltrminal
        '
        Me.coltrminal.Caption = "Terminal #"
        Me.coltrminal.FieldName = "trminal"
        Me.coltrminal.Name = "coltrminal"
        '
        'VwSalesArchiveTableAdapter
        '
        Me.VwSalesArchiveTableAdapter.ClearBeforeFill = True
        '
        'frmSalesHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 591)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales History"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSalesArchiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesArchive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsSalesArchive As DoorsPOS.WinApp.dsSalesArchive
    Friend WithEvents VwSalesArchiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSalesArchiveTableAdapter As DoorsPOS.WinApp.dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldet_amnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpos_tme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontact_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltrminal As DevExpress.XtraGrid.Columns.GridColumn
End Class
