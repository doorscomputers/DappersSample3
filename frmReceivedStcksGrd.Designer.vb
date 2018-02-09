<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedStcksGrd
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.VwReceivedStocksBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsReceivedStcksBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsReceivedStcks = New DoorsPOS.WinApp.dsReceivedStcks()
        Me.fielditemdesc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldlocation = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldrdate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsInsertid = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldrdate4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldrdate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldrdate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldrdate3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwReceivedStocksTableAdapter = New DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReceivedStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReceivedStcksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReceivedStcks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwReceivedStocksBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielditemdesc, Me.fieldlocation, Me.fieldqty, Me.fieldrdate, Me.fieldsInsertid, Me.fieldrdate4, Me.fieldrdate1, Me.fieldrdate2, Me.fieldrdate3})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(809, 489)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwReceivedStocksBindingSource
        '
        Me.VwReceivedStocksBindingSource.DataMember = "vwReceivedStocks"
        Me.VwReceivedStocksBindingSource.DataSource = Me.DsReceivedStcksBindingSource
        '
        'DsReceivedStcksBindingSource
        '
        Me.DsReceivedStcksBindingSource.DataSource = Me.DsReceivedStcks
        Me.DsReceivedStcksBindingSource.Position = 0
        '
        'DsReceivedStcks
        '
        Me.DsReceivedStcks.DataSetName = "dsReceivedStcks"
        Me.DsReceivedStcks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielditemdesc
        '
        Me.fielditemdesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc.AreaIndex = 1
        Me.fielditemdesc.Caption = "Items Received"
        Me.fielditemdesc.FieldName = "item_desc"
        Me.fielditemdesc.Name = "fielditemdesc"
        Me.fielditemdesc.Width = 194
        '
        'fieldlocation
        '
        Me.fieldlocation.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldlocation.AreaIndex = 0
        Me.fieldlocation.Caption = "Received From"
        Me.fieldlocation.FieldName = "location"
        Me.fieldlocation.Name = "fieldlocation"
        Me.fieldlocation.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldqty
        '
        Me.fieldqty.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty.AreaIndex = 0
        Me.fieldqty.Caption = "Qty Received"
        Me.fieldqty.FieldName = "qty"
        Me.fieldqty.Name = "fieldqty"
        '
        'fieldrdate
        '
        Me.fieldrdate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldrdate.AreaIndex = 2
        Me.fieldrdate.Caption = "Date Transferred"
        Me.fieldrdate.CellFormat.FormatString = "d"
        Me.fieldrdate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldrdate.FieldName = "rdate"
        Me.fieldrdate.Name = "fieldrdate"
        Me.fieldrdate.ValueFormat.FormatString = "d"
        Me.fieldrdate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldrdate.Width = 151
        '
        'fieldsInsertid
        '
        Me.fieldsInsertid.AreaIndex = 0
        Me.fieldsInsertid.Caption = "Employee"
        Me.fieldsInsertid.FieldName = "sInsert_id"
        Me.fieldsInsertid.Name = "fieldsInsertid"
        '
        'fieldrdate4
        '
        Me.fieldrdate4.AreaIndex = 1
        Me.fieldrdate4.Caption = "Week"
        Me.fieldrdate4.FieldName = "rdate"
        Me.fieldrdate4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfMonth
        Me.fieldrdate4.Name = "fieldrdate4"
        Me.fieldrdate4.UnboundFieldName = "fieldrdate4"
        '
        'fieldrdate1
        '
        Me.fieldrdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldrdate1.AreaIndex = 1
        Me.fieldrdate1.Caption = "Month"
        Me.fieldrdate1.FieldName = "rdate"
        Me.fieldrdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldrdate1.Name = "fieldrdate1"
        Me.fieldrdate1.UnboundFieldName = "fieldrdate1"
        '
        'fieldrdate2
        '
        Me.fieldrdate2.AreaIndex = 2
        Me.fieldrdate2.Caption = "Qtr"
        Me.fieldrdate2.FieldName = "rdate"
        Me.fieldrdate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
        Me.fieldrdate2.Name = "fieldrdate2"
        Me.fieldrdate2.UnboundFieldName = "fieldrdate2"
        '
        'fieldrdate3
        '
        Me.fieldrdate3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldrdate3.AreaIndex = 0
        Me.fieldrdate3.Caption = "Year"
        Me.fieldrdate3.FieldName = "rdate"
        Me.fieldrdate3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldrdate3.Name = "fieldrdate3"
        Me.fieldrdate3.UnboundFieldName = "fieldrdate3"
        '
        'VwReceivedStocksTableAdapter
        '
        Me.VwReceivedStocksTableAdapter.ClearBeforeFill = True
        '
        'frmReceivedStcksGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 489)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmReceivedStcksGrd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Received Stocks"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReceivedStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReceivedStcksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReceivedStcks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsReceivedStcksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReceivedStcks As DoorsPOS.WinApp.dsReceivedStcks
    Friend WithEvents VwReceivedStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReceivedStocksTableAdapter As DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter
    Friend WithEvents fielditemdesc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlocation As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldrdate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsInsertid As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldrdate4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldrdate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldrdate2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldrdate3 As DevExpress.XtraPivotGrid.PivotGridField
End Class
