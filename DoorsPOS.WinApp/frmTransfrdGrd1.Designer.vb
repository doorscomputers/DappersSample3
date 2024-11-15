<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfrdGrd1
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
        Me.VwTransferedBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsTransferedBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsTransfered = New DoorsPOS.WinApp.dsTransfered()
        Me.fieldtdate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsInsertid1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldlocation1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtdate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtdate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwTransferedTableAdapter = New DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransferedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTransferedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTransfered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwTransferedBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldtdate1, Me.fielditemdesc1, Me.fieldqty1, Me.fieldsInsertid1, Me.fieldlocation1, Me.fieldtdate, Me.fieldtdate2})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(904, 451)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwTransferedBindingSource
        '
        Me.VwTransferedBindingSource.DataMember = "vwTransfered"
        Me.VwTransferedBindingSource.DataSource = Me.DsTransferedBindingSource
        '
        'DsTransferedBindingSource
        '
        Me.DsTransferedBindingSource.DataSource = Me.DsTransfered
        Me.DsTransferedBindingSource.Position = 0
        '
        'DsTransfered
        '
        Me.DsTransfered.DataSetName = "dsTransfered"
        Me.DsTransfered.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldtdate1
        '
        Me.fieldtdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtdate1.AreaIndex = 0
        Me.fieldtdate1.Caption = "Year"
        Me.fieldtdate1.FieldName = "tdate"
        Me.fieldtdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldtdate1.Name = "fieldtdate1"
        Me.fieldtdate1.UnboundFieldName = "fieldtdate1"
        Me.fieldtdate1.Width = 88
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 1
        Me.fielditemdesc1.Caption = "Item Description"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        Me.fielditemdesc1.Width = 203
        '
        'fieldqty1
        '
        Me.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty1.AreaIndex = 0
        Me.fieldqty1.Caption = "Qty Transferred"
        Me.fieldqty1.FieldName = "qty"
        Me.fieldqty1.Name = "fieldqty1"
        '
        'fieldsInsertid1
        '
        Me.fieldsInsertid1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsInsertid1.AreaIndex = 2
        Me.fieldsInsertid1.Caption = "Encoder"
        Me.fieldsInsertid1.FieldName = "sInsert_id"
        Me.fieldsInsertid1.Name = "fieldsInsertid1"
        '
        'fieldlocation1
        '
        Me.fieldlocation1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldlocation1.AreaIndex = 0
        Me.fieldlocation1.Caption = "Transferred To"
        Me.fieldlocation1.FieldName = "location"
        Me.fieldlocation1.Name = "fieldlocation1"
        '
        'fieldtdate
        '
        Me.fieldtdate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtdate.AreaIndex = 1
        Me.fieldtdate.Caption = "Month"
        Me.fieldtdate.FieldName = "tdate"
        Me.fieldtdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldtdate.Name = "fieldtdate"
        Me.fieldtdate.UnboundFieldName = "fieldtdate"
        '
        'fieldtdate2
        '
        Me.fieldtdate2.AreaIndex = 0
        Me.fieldtdate2.Caption = "Date"
        Me.fieldtdate2.FieldName = "tdate"
        Me.fieldtdate2.Name = "fieldtdate2"
        '
        'VwTransferedTableAdapter
        '
        Me.VwTransferedTableAdapter.ClearBeforeFill = True
        '
        'frmTransfrdGrd1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 451)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmTransfrdGrd1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transferred Stocks View1"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransferedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTransferedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTransfered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsTransferedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTransfered As DoorsPOS.WinApp.dsTransfered
    Friend WithEvents VwTransferedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwTransferedTableAdapter As DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter
    Friend WithEvents fieldtdate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsInsertid1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlocation1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtdate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtdate2 As DevExpress.XtraPivotGrid.PivotGridField
End Class
