<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemLedgerPvt
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.VwItemLedger2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLedger = New DoorsPOS.WinApp.dsLedger()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtysold1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtypurchased1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtyreturned1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldbackorder1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtransDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldfree1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldmanualinv1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtytransfrd1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtyreceived1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtransDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqtyconvertd = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtransDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwItemLedger2TableAdapter = New DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwItemLedger2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwItemLedger2BindingSource1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielditemdesc1, Me.fieldqtysold1, Me.fieldqtypurchased1, Me.fieldqtyreturned1, Me.fieldbackorder1, Me.fieldtransDate1, Me.fieldfree1, Me.fieldmanualinv1, Me.fieldqtytransfrd1, Me.fieldqtyreceived1, Me.fieldtransDate, Me.fieldqtyconvertd, Me.fieldtransDate2})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(873, 477)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwItemLedger2BindingSource1
        '
        Me.VwItemLedger2BindingSource1.DataMember = "vwItemLedger2"
        Me.VwItemLedger2BindingSource1.DataSource = Me.DsLedgerBindingSource
        '
        'DsLedgerBindingSource
        '
        Me.DsLedgerBindingSource.DataSource = Me.DsLedger
        Me.DsLedgerBindingSource.Position = 0
        '
        'DsLedger
        '
        Me.DsLedger.DataSetName = "dsLedger"
        Me.DsLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 0
        Me.fielditemdesc1.Caption = "Item Description"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        Me.fielditemdesc1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldqtysold1
        '
        Me.fieldqtysold1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtysold1.AreaIndex = 1
        Me.fieldqtysold1.Caption = "Qty Sold"
        Me.fieldqtysold1.FieldName = "qty_sold"
        Me.fieldqtysold1.Name = "fieldqtysold1"
        Me.fieldqtysold1.Width = 65
        '
        'fieldqtypurchased1
        '
        Me.fieldqtypurchased1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtypurchased1.AreaIndex = 0
        Me.fieldqtypurchased1.Caption = "Qty Purchased"
        Me.fieldqtypurchased1.FieldName = "qty_purchased"
        Me.fieldqtypurchased1.Name = "fieldqtypurchased1"
        Me.fieldqtypurchased1.Width = 83
        '
        'fieldqtyreturned1
        '
        Me.fieldqtyreturned1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtyreturned1.AreaIndex = 2
        Me.fieldqtyreturned1.Caption = "Qty Returned"
        Me.fieldqtyreturned1.FieldName = "qtyreturned"
        Me.fieldqtyreturned1.Name = "fieldqtyreturned1"
        Me.fieldqtyreturned1.Width = 72
        '
        'fieldbackorder1
        '
        Me.fieldbackorder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldbackorder1.AreaIndex = 3
        Me.fieldbackorder1.Caption = "Backorder"
        Me.fieldbackorder1.FieldName = "backorder"
        Me.fieldbackorder1.Name = "fieldbackorder1"
        Me.fieldbackorder1.Width = 65
        '
        'fieldtransDate1
        '
        Me.fieldtransDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtransDate1.AreaIndex = 0
        Me.fieldtransDate1.Caption = "Year"
        Me.fieldtransDate1.FieldName = "trans_Date"
        Me.fieldtransDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldtransDate1.Name = "fieldtransDate1"
        Me.fieldtransDate1.UnboundFieldName = "fieldtransDate1"
        '
        'fieldfree1
        '
        Me.fieldfree1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldfree1.AreaIndex = 6
        Me.fieldfree1.Caption = "Free"
        Me.fieldfree1.FieldName = "free"
        Me.fieldfree1.Name = "fieldfree1"
        Me.fieldfree1.Width = 42
        '
        'fieldmanualinv1
        '
        Me.fieldmanualinv1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldmanualinv1.AreaIndex = 7
        Me.fieldmanualinv1.Caption = "Manual Inv"
        Me.fieldmanualinv1.FieldName = "manualinv"
        Me.fieldmanualinv1.Name = "fieldmanualinv1"
        Me.fieldmanualinv1.Width = 65
        '
        'fieldqtytransfrd1
        '
        Me.fieldqtytransfrd1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtytransfrd1.AreaIndex = 4
        Me.fieldqtytransfrd1.Caption = "Qty Transfrd"
        Me.fieldqtytransfrd1.FieldName = "qtytransfrd"
        Me.fieldqtytransfrd1.Name = "fieldqtytransfrd1"
        Me.fieldqtytransfrd1.Width = 73
        '
        'fieldqtyreceived1
        '
        Me.fieldqtyreceived1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtyreceived1.AreaIndex = 5
        Me.fieldqtyreceived1.Caption = "Qty Received"
        Me.fieldqtyreceived1.FieldName = "qtyreceived"
        Me.fieldqtyreceived1.Name = "fieldqtyreceived1"
        Me.fieldqtyreceived1.Width = 67
        '
        'fieldtransDate
        '
        Me.fieldtransDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtransDate.AreaIndex = 1
        Me.fieldtransDate.Caption = "Month"
        Me.fieldtransDate.FieldName = "trans_Date"
        Me.fieldtransDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldtransDate.Name = "fieldtransDate"
        Me.fieldtransDate.UnboundFieldName = "fieldtransDate"
        '
        'fieldqtyconvertd
        '
        Me.fieldqtyconvertd.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqtyconvertd.AreaIndex = 8
        Me.fieldqtyconvertd.Caption = "Qty Converted"
        Me.fieldqtyconvertd.FieldName = "qtyconvertd"
        Me.fieldqtyconvertd.Name = "fieldqtyconvertd"
        '
        'fieldtransDate2
        '
        Me.fieldtransDate2.AreaIndex = 0
        Me.fieldtransDate2.Caption = "Day"
        Me.fieldtransDate2.CellFormat.FormatString = "d"
        Me.fieldtransDate2.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldtransDate2.FieldName = "trans_Date"
        Me.fieldtransDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay
        Me.fieldtransDate2.Name = "fieldtransDate2"
        Me.fieldtransDate2.UnboundFieldName = "fieldtransDate2"
        '
        'VwItemLedger2TableAdapter
        '
        Me.VwItemLedger2TableAdapter.ClearBeforeFill = True
        '
        'frmItemLedgerPvt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 477)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmItemLedgerPvt"
        Me.Text = "Item Ledger"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwItemLedger2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsLedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsLedger As DoorsPOS.WinApp.dsLedger
    Friend WithEvents VwItemLedger2TableAdapter As DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter
    Friend WithEvents VwItemLedger2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtysold1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtypurchased1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtyreturned1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldbackorder1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtransDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfree1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldmanualinv1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtytransfrd1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtyreceived1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtransDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtransDate2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqtyconvertd As DevExpress.XtraPivotGrid.PivotGridField
End Class
