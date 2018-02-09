<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDetails
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
        Me.VwSalesBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsItemsSoldBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsItemsSold = New DoorsPOS.WinApp.dsItemsSold()
        Me.fielddtInsertdt1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldposdate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldposdate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddetamnt1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwSalesTableAdapter = New DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemsSoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemsSold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.Cell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldHeader.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PivotGridControl1.Appearance.FieldValue.Options.UseFont = True
        Me.PivotGridControl1.DataSource = Me.VwSalesBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielddtInsertdt1, Me.fieldposdate1, Me.fieldposdate, Me.fielditemdesc1, Me.fieldqty1, Me.fielddetamnt1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1013, 487)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwSalesBindingSource
        '
        Me.VwSalesBindingSource.DataMember = "vwSales"
        Me.VwSalesBindingSource.DataSource = Me.DsItemsSoldBindingSource
        '
        'DsItemsSoldBindingSource
        '
        Me.DsItemsSoldBindingSource.DataSource = Me.DsItemsSold
        Me.DsItemsSoldBindingSource.Position = 0
        '
        'DsItemsSold
        '
        Me.DsItemsSold.DataSetName = "dsItemsSold"
        Me.DsItemsSold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fielddtInsertdt1
        '
        Me.fielddtInsertdt1.AreaIndex = 0
        Me.fielddtInsertdt1.Caption = "Date Sold"
        Me.fielddtInsertdt1.FieldName = "dtInsert_dt"
        Me.fielddtInsertdt1.Name = "fielddtInsertdt1"
        Me.fielddtInsertdt1.Width = 160
        '
        'fieldposdate1
        '
        Me.fieldposdate1.AreaIndex = 1
        Me.fieldposdate1.Caption = "Year"
        Me.fieldposdate1.FieldName = "pos_date"
        Me.fieldposdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldposdate1.Name = "fieldposdate1"
        Me.fieldposdate1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldposdate1.UnboundFieldName = "fieldposdate1"
        '
        'fieldposdate
        '
        Me.fieldposdate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldposdate.AreaIndex = 0
        Me.fieldposdate.Caption = "Month"
        Me.fieldposdate.FieldName = "pos_date"
        Me.fieldposdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldposdate.Name = "fieldposdate"
        Me.fieldposdate.UnboundFieldName = "fieldposdate"
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 1
        Me.fielditemdesc1.Caption = "Items Sold"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        '
        'fieldqty1
        '
        Me.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty1.AreaIndex = 0
        Me.fieldqty1.Caption = "Qty Sold"
        Me.fieldqty1.FieldName = "qty"
        Me.fieldqty1.Name = "fieldqty1"
        Me.fieldqty1.ValueFormat.FormatString = "N0"
        Me.fieldqty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fielddetamnt1
        '
        Me.fielddetamnt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fielddetamnt1.AreaIndex = 1
        Me.fielddetamnt1.Caption = "Amount"
        Me.fielddetamnt1.FieldName = "det_amnt"
        Me.fielddetamnt1.Name = "fielddetamnt1"
        Me.fielddetamnt1.ValueFormat.FormatString = "N2"
        Me.fielddetamnt1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'VwSalesTableAdapter
        '
        Me.VwSalesTableAdapter.ClearBeforeFill = True
        '
        'frmSalesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 487)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmSalesDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items Sold"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemsSoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemsSold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsItemsSoldBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsItemsSold As DoorsPOS.WinApp.dsItemsSold
    Friend WithEvents VwSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSalesTableAdapter As DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter
    Friend WithEvents fielddtInsertdt1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldposdate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldposdate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddetamnt1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
